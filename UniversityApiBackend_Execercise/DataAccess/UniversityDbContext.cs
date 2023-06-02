using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using UniversityApiBackend_Execercise.Models.DataModels;

namespace UniversityApiBackend_Execercise.DataAccess
{
    public class UniversityDbContext: DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options): base(options)
        {

        }

        //TODO add DbSets
        public DbSet<User>? Users { get; set; }

    }
}
