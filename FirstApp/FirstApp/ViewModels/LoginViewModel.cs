﻿using FirstApp.Models;
using FirstApp.Views;
using Xamarin.Forms;

namespace FirstApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string email;
        private string password;

        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            if (await Auth.Login(Email, Password))
            {
                Email = "";
                Password = "";
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            }

        }
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }
    }
}
