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
using System.Windows.Shapes;
using WalkyDog.ViewModels;

namespace WalkyDog.Views
{
  /*  public interface IView
    {
        IViewModel ViewModel
        {
            get;
            set;
        }

        void Show();
    }*/

    /// <summary>
    /// Interaction logic for LoginWindow.xaml
/*    /// </summary>
    public partial class LoginWindow : Window, IView
    {
        public LoginWindow(AuthenticationViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }

      
        public IViewModel ViewModel
        {
            get { return DataContext as IViewModel; }
            set { DataContext = value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e) //signUP
        {
            

            SignUp page = new SignUp();

            page.Title = "SignUp";

            this.Content = page;
        }
    }*/
}
