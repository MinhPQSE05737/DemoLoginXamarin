using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App3.ViewModels
{
    class LoginViewModel /*: INotifyPropertyChanged*/
    {
        //public DisplayAlert(string title, string message, string cancel);
        //public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public Action DisplayInvalidLoginPrompt;
        
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                //PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                //PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {

            //if (email != "minhpq@vietis.com.vn" || password != "12345")
            //{
            //    DisplayInvalidLoginPrompt();
            //}
             if(email == null)
            {
                Application.Current.MainPage.DisplayAlert("Alert", "Email can not be empty", "OK");
            }
            else if (password == null)
            {
                Application.Current.MainPage.DisplayAlert("Alert", "Password can not be empty", "OK");
            }
            else
            {
                Application.Current.MainPage.Navigation.PushAsync(new Page2.Page2Content(email, password));
            }
        }

       
    }
}
