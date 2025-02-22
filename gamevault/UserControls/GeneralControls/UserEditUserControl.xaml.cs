﻿using gamevault.Helper;
using gamevault.Models;
using gamevault.ViewModels;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gamevault.UserControls
{
    /// <summary>
    /// Interaction logic for UserEditUserControl.xaml
    /// </summary>
    public partial class UserEditUserControl : UserControl
    {
        internal event EventHandler UserSaved;
        internal UserEditUserControl(User user)
        {
            InitializeComponent();
            this.DataContext = Copy(user);

        }

        private void Save_Clicked(object sender, RoutedEventArgs e)
        {
            if (this.UserSaved != null)
                this.UserSaved(sender, e);
        }
        private void Save_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (this.UserSaved != null)
                    this.UserSaved(uiBtnSave, e);
            }
        }
        private User Copy(User source)
        {
            User dest = new User();
            foreach (var prop in dest.GetType().GetProperties())
            {
                prop.SetValue(dest, prop.GetValue(source));
            }
            return dest;
        }


        private void UploadProfilePicture_Click(object sender, RoutedEventArgs e)
        {
            if (fileSelectionPopupPP.Visibility == Visibility.Visible)
            {
                fileSelectionPopupPP.Visibility = Visibility.Collapsed;
            }
            else
            {
                fileSelectionPopupPP.Visibility = Visibility.Visible;
                fileSelectionPopupBP.Visibility = Visibility.Collapsed;
            }
        }

        private void UploadBackgroundPicture_Click(object sender, RoutedEventArgs e)
        {
            if (fileSelectionPopupBP.Visibility == Visibility.Visible)
            {
                fileSelectionPopupBP.Visibility = Visibility.Collapsed;
            }
            else
            {
                fileSelectionPopupBP.Visibility = Visibility.Visible;
                fileSelectionPopupPP.Visibility = Visibility.Collapsed;
            }
        }

        private void UserEditPopup_Close(object sender, MouseButtonEventArgs e)
        {
            var parent = this.Parent as Panel;
            if (parent != null)
            {
                parent.Visibility = Visibility.Collapsed;
            }
        }
    }
}
