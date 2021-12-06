using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

using WalkyDog.Commands;
using WalkyDog.Models;

namespace WalkyDog.ViewModels
{

    internal class UserViewModel : Notifier
    {
        string Conn = "SERVER=localhost;DATABASE=walkydog;UID=root;PASSWORD=201933043";
        //새 인스턴스 초기화 
        public UserViewModel()
        {
            _User = new User();
            UpdateCommand = new UserUpdateCommand(this);
            Whoiam = new User[]
            {
                new User("반려견"),
                new User("산책 도우미")
            };

        }

        // 업뎃 가능한 상태인지 나타내는거 
        public bool CanUpdate
        {
            get
            {
                if (User == null) //아무것도 안적으면 업뎃 ㄴㄴ 못함
                {
                    return false;
                }
                return true;
            }

        }

        private User _User;


        public User User
        {
            get
            {
                return _User;
            }
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }


        //회원가입
        public void SaveChanges()
        {


            // Debug.Assert(false, String.Format("{0} was a updated.", User.Name));

            using (MySqlConnection conn = new MySqlConnection(Conn))
            {
                conn.Open();
                 MySqlCommand msc = new MySqlCommand("INSERT INTO user(rudog,id,pw,name,bio) values('" + User.RuDog + "','" + User.Id + "','" + User.Pw + "','" + User.Name + "','" + User.Bio + "');", conn);
               // MySqlCommand msc = new MySqlCommand("INSERT INTO user(rudog,id,pw,name,bio) values('a','b','c','f','f');", conn);
                msc.ExecuteNonQuery();
            }

        }




        private IEnumerable<User> _whoiam;
        public IEnumerable<User> Whoiam
        {
            get { return _whoiam; }
            set
            {
                // Some logic here
                _whoiam = value;
                OnPropertyChanged("Whoiam");
            }
        }

        private User _selectwho;
        public User Selectedwho
        {
            get
            {
                return _selectwho;
            }
            set
            {
                _selectwho = value;
                OnPropertyChanged("Selectedwho");
                OnselectedChanged();
            }
        }

        private void OnselectedChanged()
        {
            decidedwho();
        }

        private void decidedwho()
        {
            if (Selectedwho == null)
                return;
            User.RuDog = Selectedwho.RuDog;
        }
    }
}