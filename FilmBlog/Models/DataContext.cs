using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmBlog.Models
{
    public class DataContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-STS14AS8; database=Logindb; integrated security=true;");
            base.OnConfiguring(optionsBuilder); // IdentityDbContext yaptığımız için zorunlu.
        }


        public DbSet<Blog> Blogs { get; set; }
        
    }
}
