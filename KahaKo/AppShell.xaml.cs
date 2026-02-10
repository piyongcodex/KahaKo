using KahaKo.Models;
using KahaKo.Services;

namespace KahaKo
{
    public partial class AppShell : Shell
    {
        private readonly AuthService _authService;
        public AppShell(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;

            UpdateTabVisibility();
        }
        private void UpdateTabVisibility()
        {
            var user = _authService.CurrentUser;

            if (user == null) return;

            // Hide/Show tabs based on role
            var productsTab = Items.FirstOrDefault(i => i.Title == "Products");
            var usersTab = Items.FirstOrDefault(i => i.Title == "Users");

            if (productsTab != null)
                productsTab.IsVisible = user.Role <= UserRole.Manager;

            if (usersTab != null)
                usersTab.IsVisible = user.Role == UserRole.Admin;
        }
    }
}
