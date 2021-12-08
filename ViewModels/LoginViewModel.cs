using Microsoft.EntityFrameworkCore.Metadata;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Input;
using WalkyDog.Commands;
using WalkyDog.Models;
using WalkyDog.ViewModels;

namespace WalkyDog.ViewModels
{

    internal class LoginViewModel : Notifier
    {
        string Conn = "SERVER=localhost;DATABASE=walkydog;UID=root;PASSWORD=201933043";
        public LoginViewModel()
        {

            _User = new User();
            //로긴
            LoginCommand = new UserLoginCommand(this);

            toggleExecuteCommand = new RelayCommand(ChangeCanExecute);
           /* LoginCommand = new RelayCommand(ShowMessage, param => canExecute);*/
        }

       

        

        
        public bool FindUser()
        {
            string userid = User.Id;
            string userpw = User.Pw;
            using (MySqlConnection conn = new MySqlConnection(Conn))
            {
                DataSet ds = new DataSet();
                string sql = "SELECT id,pw,rudog,name,bio,image FROM USER WHERE id = '" + User.Id + "' and pw = '" + User.Pw + "';";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "user");
                try
                {
                    for (int i = 0; i <= ds.Tables[0].Rows.Count; i++)
                    {
                 
                        User.RuDog = ds.Tables[0].Rows[0]["RuDog"].ToString();
                        User.Id = ds.Tables[0].Rows[0]["Id"].ToString();
                        User.Pw = ds.Tables[0].Rows[0]["Pw"].ToString();
                        string v = ds.Tables[0].Rows[0]["Name"].ToString();
                        User.Name = v;
                        User.Bio = ds.Tables[0].Rows[0]["Bio"].ToString();
                    }
                    if(userid == User.Id && userpw == User.Pw)
                        //값 잘 받는것 확인 

                        return true;
                    else
                        return false;
                }
                catch (Exception e)
                {
                    throw e;
                }

            }

        }

        public bool CanLogin
        {
            get
            {


                if (User == null)
                {
                    return false;
                }
                return true;
            }
        }



        private void ShowMessage(object obj)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show(obj.ToString());
        }

        private void ChangeCanExecute(object obj)
        {
            canExecute = !canExecute;
        }

        public UserLoginCommand LoginCommand { get; private set; }


   
        


        private User _User;


        public User User
        {
            get
            {
                return _User;
            }
        }

 
    

        // ViewModel 에서 버튼 이벤트 만들기 함수들 ㅠㅠ  버튼이벤트되면 메소드가 안되고 메소드되면 버튼이벤트가 안되고 
        // //Q1.  버튼 하나로 메소드랑 ㅇ벤트 같이 못하는지 여쭤보기
       // private ICommand loginCommand;
        private ICommand toggleExecuteCommand { get; set; }

        private bool canExecute = true;
        public string LoginButtonContent
        {
            get
            {
                return "Login !";
            }
        }

        public bool CanExecute
        {
            get
            {
                return this.canExecute;
            }

            set
            {
                if (this.canExecute == value)
                {
                    return;
                }

                this.canExecute = value;
            }
        }

        public ICommand ToggleExecuteCommand
        {
            get
            {
                return toggleExecuteCommand;
            }
            set
            {
                toggleExecuteCommand = value;
            }
        }



       


       
        
    }
}
