using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkyDog.Models
{
    public class User : Notifier
    {
        public User(String userName)
        {
            Name = userName;
        }

        private string _Name;

        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                Name = value;
                OnPropertyChanged("Name");
            }
        }

    }
}
