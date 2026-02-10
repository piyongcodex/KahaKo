using CommunityToolkit.Mvvm.ComponentModel;
using KahaKo.Data;
using KahaKo.Helpers;
using KahaKo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahaKo.Services
{
    public partial class AuthService : ObservableObject
    {
        private readonly AppDbContext _context;

        [ObservableProperty]
        private User currentUser;

        public AuthService(DatabaseService dbService)
        {
            _context = dbService.GetContext();
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u =>
                    u.Username == username &&
                    u.IsActive);

            if (user != null &&
                BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                CurrentUser = user;
                return user;
            }

            return null;
        }

        public void Logout()
        {
            CurrentUser = null;
        }

        public bool HasPermission(UserRole requiredRole)
        {
            if (CurrentUser == null) return false;
            return CurrentUser.Role <= requiredRole;
        }
    }
}
