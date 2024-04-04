using CyberBullingApp2.ViewModels;
using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace CyberBullingApp2
{
    internal class RegisterViewModel
    {
        private INavigation navigation;

        public string webApiKey = "AIzaSyAL7Uqk0_pC_-PaJsJ5OyGXF7wQKFQRpBg";
       // private INavigation navigation;
        private string email;
        private string password;


        public event PropertyChangedEventHandler? PropertyChanged;
        public string Email
        {
            get => email;
            set
            {
                email = value;
                RaisePropertyChanged("Email");
            }
        }

        private void RaisePropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public string Password
        {
            get => password;
            set
            {
                password = value;
                RaisePropertyChanged("Password");
            }
        }
        public Command RegisterUser {  get; set; }
        public RegisterViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            RegisterUser = new Command(RegisterUserTappedAsync);
        }

        private async void RegisterUserTappedAsync(object obj)
        {
            try
            {
                var testEmail = email;
                var auth = new FirebaseAuth(new FirebaseConfig(webApiKey));
                await auth.CreateUserWithEmailAndPasswordAsync(Email, Password);
                string token = auth.FirebaseToken;

                if (token != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Alert", "User Registered successfully", "OK");

                    await this.navigation.PopAsync();
                }
            }
            catch (System.Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
                throw;
            }

        }
    }

}
