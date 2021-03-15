using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Page2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2Content : ContentPage
    {
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
               
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
            }
        }
        public Page2Content(string email, string password)
        {
            InitializeComponent();
            BindingContext = this;

            Email = email;
            Password = password;

        }
    }
}