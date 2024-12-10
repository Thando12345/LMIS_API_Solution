using Microsoft.EntityFrameworkCore;
using LMIS_Dev_Branch.Models;

namespace LMIS_Dev_Branch.Data
{
    public static class DbContextProvider
    {
        private static @null _context;

        public static @null GetContext()
        {
            if (_context == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<@null>();
                optionsBuilder.UseSqlServer("Server=DESKTOP-RULM89R\\SQLEXPRESS;Database=LMS_Db;Trusted_Connection=True;TrustServerCertificate=True;");

                _context = new @null(optionsBuilder.Options);
            }
            return _context;
        }
    }
}
