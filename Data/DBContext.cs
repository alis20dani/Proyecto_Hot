using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mi_proyecto_sena.Models;
using Microsoft.EntityFrameworkCore;

namespace mi_proyecto_sena.Data
{

    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<usuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuarioModel>().HasKey(U => U.User_Id);
            modelBuilder.Entity<usuarioModel>().Property(U => U.User_Id).ValueGeneratedOnAdd();
        }

    }
}