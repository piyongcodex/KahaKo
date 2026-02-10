using KahaKo.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahaKo.Services
{
    public class DatabaseService
    {
        private readonly AppDbContext _context;

        public DatabaseService()
        {
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
        }

        public AppDbContext GetContext() => _context;
    }
}
