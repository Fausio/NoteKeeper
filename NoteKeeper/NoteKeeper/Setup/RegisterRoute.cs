using NoteKeeper.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NoteKeeper.Setup
{
    public static class RegisterRoute
    {

        public static void Register_Route()
        {
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }
    }
}
