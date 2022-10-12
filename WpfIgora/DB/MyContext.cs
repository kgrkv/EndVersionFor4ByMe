using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIgora.DB
{
    public class MyContext:DbContext
    {
        private string cs = "server = 192.168.10.160; database = kgrkvk; User Id = stud; password = stud;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }

       public  DbSet<User> Users { get; set; }
       public DbSet<Worker> Workers { get; set; }

    }
}
