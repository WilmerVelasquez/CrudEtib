using CrudEtib.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudEtib.Infrastructure.Data
{
    public class ApplicationDbContext :DbContext 
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Usuarios> Usuario { get; set; }
	}
}
