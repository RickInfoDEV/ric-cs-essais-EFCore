using Microsoft.EntityFrameworkCore;
using WizLib_Model.Models;

namespace WizLib_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } //Spécifie qu'il faudra avoir une table Categories pour y mettre les Entity de type Category.
        public DbSet<Genre> Genres { get; set; }
    }
}
