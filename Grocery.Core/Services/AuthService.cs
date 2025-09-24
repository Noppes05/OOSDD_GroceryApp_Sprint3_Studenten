using Grocery.Core.Helpers;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IClientService _clientService;
        public AuthService(IClientService clientService)
        {
            _clientService = clientService;
        }
        public Client? Login(string email, string password)
        {
            Client? client = _clientService.Get(email);
            if (client == null) return null;
            if (PasswordHelper.VerifyPassword(password, client.Password)) return client;
            return null;
        }

        public bool Register(string? name, string? email, string? password, out string errorMessage)
        {
            if (email == null && password == null && name == null)
            {
                errorMessage = "Vul alle velden in.";
                return false;
            }
            if (_clientService.Get(email) == null) 
            {
                errorMessage = $"er bestaat al een account met deze emailaddress:{email}";
                return false;
            }
            string hashedPassword = PasswordHelper.HashPassword(password);
            int id = _clientService.GetAll().Max(c => c.Id);
            Client newClient = new(id + 1, name, email, hashedPassword);
            bool status = _clientService.Add(newClient);
            if (!status)
            {
                errorMessage = "Er is iets misgegaan bij het aanmaken van uw account, probeer het later opnieuw.";
                return false;
            }
            errorMessage = string.Empty;
            return true;

        }
    }
}
