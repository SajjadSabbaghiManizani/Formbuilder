using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static System.Net.Mime.MediaTypeNames;



namespace Infrastructure.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Form> Forms { get; set; }
        public DbSet<FormStyle> FormStyles { get; set; }
        public DbSet<FormElement>  FormElements { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            


        }
    }
}
