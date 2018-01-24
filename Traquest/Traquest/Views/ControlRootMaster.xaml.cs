using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Traquest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlRootMaster : ContentPage
    {
        public ListView ListView;

        public ControlRootMaster()
        {
            InitializeComponent();

            BindingContext = new ViewModels.ControlRootMasterVM();
            ListView = MenuItemsListView;
        }

    }
}