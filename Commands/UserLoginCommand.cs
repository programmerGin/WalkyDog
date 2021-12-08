using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WalkyDog.ViewModels;


namespace WalkyDog.Commands
{
    internal class UserLoginCommand : ICommand
    {
        public UserLoginCommand(LoginViewModel viewModel)
        {
            _ViewModel = viewModel;
        }

        public UserLoginCommand()
        {
        }

        private LoginViewModel _ViewModel;

        public event System.EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }


        public bool CanExecute(object parameter)
        {
            return _ViewModel.CanLogin;
        }

        public void Execute(object parameter)
        {
            _ViewModel.FindUser();
        }

        public static implicit operator UserLoginCommand(RelayCommand v)
        {
            throw new NotImplementedException();
        }
    }
}
