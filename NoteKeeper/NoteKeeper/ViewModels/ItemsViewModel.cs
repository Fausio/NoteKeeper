using NoteKeeper.Models;
using NoteKeeper.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NoteKeeper.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private Note _selectedNote;

        public ObservableCollection<Note> Notes { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Note> NoteTapped { get; }

        public ItemsViewModel()
        {
            Title = "Note Keeper";
            Notes = new ObservableCollection<Note>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            NoteTapped = new Command<Note>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Notes.Clear();
             
                var items = await pLDataStore.GetNotesAsync(true);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        Notes.Add(item);
                    }
                }
              
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedNote = null;
        }

        public Note SelectedNote
        {
            get => _selectedNote;
            set
            {
                SetProperty(ref _selectedNote, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(ItemDetailPage));
        }

        async void OnItemSelected(Note note)
        {
            if (note == null)
                return;
             
            await App.Current.MainPage.Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(note)));
             
        }
    }
}