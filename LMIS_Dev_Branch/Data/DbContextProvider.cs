using Microsoft.EntityFrameworkCore;
using LMIS_Dev_Branch.Models;

namespace LMIS_Dev_Branch.Data
{
    public static class DbContextProvider
    {
        private static AppDbContext _context;

        public static AppDbContext GetContext()
        {
            if (_context == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                optionsBuilder.UseSqlServer("Server=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True;");

                _context = new AppDbContext(optionsBuilder.Options);
            }
            return _context;
        }
    }
}
