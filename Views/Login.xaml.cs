﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WalkyDog.ViewModels;

namespace WalkyDog.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            DataContext = new LoginViewModel(this);
        }

      

        private void Button_Click(object sender, RoutedEventArgs e) // Sign Up 
        {
            NavigationService.Navigate(
               new Uri("Views/SignUp.xaml", UriKind.Relative)
               );
        }
        public bool IsDefault { get; set; }
      

private void Loginbtn(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
