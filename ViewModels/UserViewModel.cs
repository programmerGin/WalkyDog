using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WalkyDog.Commands;
using WalkyDog.Models;

namespace WalkyDog.ViewModels
{

    internal class UserViewModel
    {
        string Conn = "SERVER=localhost;DATABASE=test;UID=root;PASSWORD=201933043";
        //새 인스턴스 초기화 
        public UserViewModel()
        {
            _User = new User("Sojin");
            UpdateCommand = new UserUpdateCommand(this);
        }

        // 업뎃 가능한 상태인지 나타내는거 
        public bool CanUpdate
        {
            get {
                if(User == null) //아무것도 안적으면 업뎃 ㄴㄴ 못함
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(User.Name);
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

        
        public void SaveChanges()
        {


            // Debug.Assert(false, String.Format("{0} was a updated.", User.Name));
            
            using (MySqlConnection conn = new MySqlConnection(Conn))
            {
                conn.Open();
                MySqlCommand msc = new MySqlCommand("INSERT INTO test(name) values('"+User.Name+"')", conn);
                msc.ExecuteNonQuery();
            }

        }

    }





}

