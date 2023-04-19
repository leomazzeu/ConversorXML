using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorXML
{
    public class AppDbContext : DbContext
    {
        public DbSet<XmlModel> Query_Result { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost,1433;Database=NOMEBASEDEDADOS;User ID=sa;Password=123");
    }
}
