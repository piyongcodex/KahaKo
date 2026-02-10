using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KahaKo.Services;

namespace KahaKo.ViewModels
{
    // ViewModels/LoginViewModel.cs
    public partial class LoginViewModel : ObservableObject
    {
        private readonly AuthService _authService;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string errorMessage;

        [ObservableProperty]
        private bool hasError;

        public LoginViewModel(AuthService authService)
        {
            _authService = authService;
        }

        [RelayCommand]
        async Task Login()
        {
            if (string.IsNullOrWhiteSpace(Username) ||
                string.IsNullOrWhiteSpace(Password))
            {
                ErrorMessage = "Please enter username and password";
                HasError = true;
                return;
            }

            var user = await _authService.Login(Username, Password);

            if (user != null)
            {
                // Navigate to dashboard
                await Shell.Current.GoToAsync("//DashboardPage");
            }
            else
            {
                ErrorMessage = "Invalid username or password";
                HasError = true;
            }
        }
    }
}
