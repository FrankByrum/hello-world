using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAuthApp.Models;
using OAuthApp.Views;

namespace OAuthApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private Account signUpAccount;
        private Credential signInCredential;
        private string results;
        
        public MainPageViewModel()
        {
            this.signUpAccount = new Account();
            this.signInCredential = new Credential();
        }

        public Account SignUpAccount
        {
            get { return this.signUpAccount; }
            set { this.SetProperty(ref this.signUpAccount, "SignUpAccount", value); }
        }

        public Credential SignInCredential
        {
            get { return this.signInCredential; }
            set { this.SetProperty(ref this.signInCredential, "SignInCredential", value); }
        }

        public string Results
        {
            get { return this.results; }
            set { this.SetProperty(ref this.results, "Results", value); }
        }

        public void DoSignUp(MainPage view)
        {
            this.Results = string.Format("user:{0}\r\npassword:{1}\r\n", this.SignUpAccount.EmailAddress, this.SignUpAccount.Password);
        }
    }
}
