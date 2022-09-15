using NoteKeeper.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NoteKeeper.Setup
{
    public static class DependencyServiceRegister
    {
        public static void Dependency_ServiceRegister()
        {
            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MockPLDataStore>();
        }
    }
}
