﻿using System;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        public SignUp()
        {
            InitializeComponent();
           // DataContext = new UserViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("회원가입 완료");
            NavigationService.Navigate(
             new Uri("Views/Login.xaml", UriKind.Relative)
             );
        }
    }
}
