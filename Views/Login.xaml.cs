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
    /// 

    public partial class Login : Page, IView
    {


        public Login(AuthenticationViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
           
        }
        public IViewModel ViewModel
        { //login 생성자 파라미터로 AuthenticationViewModel 받아서  datacontext는 viewmodel을 지정하는것임 
            get { return DataContext as IViewModel; }
            set { DataContext = value; }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // login => Matching page 
        {
            NavigationService.Navigate(
                new Uri("Views/Matching.xaml", UriKind.Relative)
                );
        }

        private void Button_Click(object sender, RoutedEventArgs e) // Sign Up 
        {
            NavigationService.Navigate(
               new Uri("Views/SignUp.xaml", UriKind.Relative)
               );
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
