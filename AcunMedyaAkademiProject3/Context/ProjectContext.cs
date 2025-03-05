using AcunMedyaAkademiProject3.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaAkademiProject3.Context
{
    public class ProjectContext : DbContext
    {
     
        //onconfigurin isimli bir metod var bu metdon ovverride ediliyor (ovverride benim istediğim şekilde yaz dmeek!)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured) {
                {
                    optionsBuilder.UseSqlServer("Server=SONER\\SQLEXPRESS;initial catalog=AcunmedyaDb3;integrated security=true;");

                }

            }
        }

        public DbSet<Product> Products { get; set; }    
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> Abouts { get; set; } 

    }
}
