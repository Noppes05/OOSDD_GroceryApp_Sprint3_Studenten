using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.App.Views;
using Grocery.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.App.ViewModels
{
    public partial class RegistrationViewModel : BaseViewModel
    {
        private readonly IAuthService _authService;
        [ObservableProperty] private string name;
        [ObservableProperty] private string email;
        [ObservableProperty] private string password;
        [ObservableProperty] private string registrationMessage;

        public RegistrationViewModel(IAuthService authService)
        {
            _authService = authService;
        }

        [RelayCommand]
        public void Register()
        {
            bool status = _authService.Register(name, email, password, out string errorMessage);
            if (status)
            {
                RegistrationMessage = "Uw account is succesvol aangemaakt, u kunt nu inloggen.";
            }
            else
            {
                RegistrationMessage = errorMessage;
            }
        }

        [RelayCommand]
        public async Task NavigateToLogin()
        {
            Application.Current.MainPage = new LoginView(new LoginViewModel(_authService, new GlobalViewModel()));
        }
    }
}
