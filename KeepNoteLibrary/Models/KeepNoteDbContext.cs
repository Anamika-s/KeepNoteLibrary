using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepNoteDAOLayer.Models
{
    public class KeepNoteDbContext : DbContext
    {
        IConfiguration config;
        
        
         
        public DbSet<Category> Categories { get; set; }
        public  DbSet<Notes> Notes  { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //string mySqlConnectionStr = config["ConnectionStrings:MyConnection"].ToString();
            //  config.GetConnectionString("MyConnection");
            options.UseSqlServer("server=LAPTOP-53S2KQS8;database=UstPractice;integrated security=true;");
        }
    }
}
