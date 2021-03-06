﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Traquest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlRoot : MasterDetailPage
    {
        public ControlRoot()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ControlRootMenuItem;
            if (item == null)
                return;
            else if (item.Id == (int)ViewModels.RootMenuItemId.Exit)
            {
                //close network streams and stop sessions. set app to sleep
            }

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}