using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.ComponentModel;

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
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        public User(int ruDog)
        {
            RuDog = ruDog;
        }

        private int _RuDog;

        public int RuDog
        {
            get
            {
                return _RuDog;
            }
            set
            {
                _RuDog = value;
                OnPropertyChanged("RuDog");
            }
        }





    }
}
