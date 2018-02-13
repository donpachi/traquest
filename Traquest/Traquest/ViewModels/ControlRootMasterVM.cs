using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Traquest.Views;

namespace Traquest.ViewModels
{
    public enum RootMenuItemId { Home, Sessions, Test, Settings, Exit };

    [XamlCompilation(XamlCompilationOptions.Compile)]
    class ControlRootMasterVM : INotifyPropertyChanged
    {
        public ObservableCollection<ControlRootMenuItem> MenuItems { get; set; }
        public string AppName { get; }

        public ControlRootMasterVM()
        {
            AppName = "Traquest";
            MenuItems = new ObservableCollection<ControlRootMenuItem>(new[]
            {
                new ControlRootMenuItem { Id = 0, Title = "Home" , TargetType = typeof(HomePage)},
                new ControlRootMenuItem { Id = 1, Title = "Sessions", TargetType = typeof(SessionsPage)},
                new ControlRootMenuItem { Id = 2, Title = "Test" },
                new ControlRootMenuItem { Id = 3, Title = "Settings", TargetType = typeof(SettingsPage)},
                new ControlRootMenuItem { Id = 4, Title = "Exit Application" },
            });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
