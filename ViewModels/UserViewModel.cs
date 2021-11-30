using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkyDog.Models;

namespace WalkyDog.ViewModels
{
    internal class UserViewModel
    {

        public UserViewModel()
        {
            _User = new User("Sojin");
        }

        private User _User;

        public User User
        {
            get
            {
                return _User;
            }
        }

        public void SvaeChanges()
        {
            Debug.Assert(false, String.Format("{0} was a updated.", User.Name));
        }

    }





}

