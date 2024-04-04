using Firebase.Auth;
using Microsoft.Maui.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBullingApp2.ViewModels
{
    internal class LoginViewModel: INotifyPropertyChanged
    {
         
        public string webApiKey = "AIzaSyAL7Uqk0_pC_-PaJsJ5OyGXF7wQKFQRpBg ";
        private INavigation _navigation;
        private string userName;
        private string userPassword;
        private object content;
        private readonly object authProvider;
        private readonly object auth;

        public event PropertyChangedEventHandler PropertyChanged;

        public Command RegisterBtn { get; }
        public Command LoginBtn { get; }

        public string UserName
        {
            get => userName; set
            {
                userName = value;
                RaisePropertyChanged("UserName");
            }
        }



        public string UserPassword
        {
            get => userPassword; set
            {
                userPassword = value;
                RaisePropertyChanged("userPassword");
            }
        }
        public LoginViewModel(INavigation navigation)

        {
            this._navigation = navigation;
            RegisterBtn = new Command(RegisterBtnTappedAsync);
            LoginBtn = new Command(LoginBtnTappedAsync);
        }

        private async void LoginBtnTappedAsync(object obj)
        {
            var authProvider = new FirebaseAuth(new FirebaseConfig(webApiKey));
            try
            {
                await authProvider.SignInWithEmailAndPasswordAsync(UserName, UserPassword);
                //var content = await auth.GetFreshAuthAsync();
                var serializedContent = JsonConvert.SerializeObject(content);
                Preferences.Set("FreshFirebaseToken", serializedContent);
                await this._navigation.PushAsync(new Dashboard());
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert",ex.Message, "OK");
                throw;
            }
            
        }

        private async void RegisterBtnTappedAsync(object obj)
        {
            await this._navigation.PushAsync(new RegisterPage());
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

   
}



