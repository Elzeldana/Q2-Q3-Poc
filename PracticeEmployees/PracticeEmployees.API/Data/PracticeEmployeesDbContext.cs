using Microsoft.EntityFrameworkCore;

namespace PracticeEmployees.API.Data
{
    public class PracticeEmployeesDbContext :DbContext
    {
        public PracticeEmployeesDbContext(DbContextOptions options ) : base( options )
        {

        }
    }
}
