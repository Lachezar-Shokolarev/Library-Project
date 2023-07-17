using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using LibraryWeb.Models;

namespace LibraryWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<LibraryWeb.Models.Roles>(entity =>
            {
                entity.HasKey(x => x.RoleID);

            });

            modelBuilder.Entity<LibraryWeb.Models.Title>(entity =>
            {
                entity.Ignore(x => x.Images);

            });

            modelBuilder.Entity<LibraryWeb.Models.LibraryItem>(entity =>
            {
                entity.HasKey(x => x.InventoryNumber);

            });
        }
        public DbSet<LibraryWeb.Models.Roles> Roles { get; set; }
        public DbSet<LibraryWeb.Models.User> User { get; set; }
        public DbSet<LibraryWeb.Models.Section> Section { get; set; }
        public DbSet<LibraryWeb.Models.Title> Title { get; set; }
        public DbSet<LibraryWeb.Models.LibraryItem> LibraryItem { get; set; }
    }
}
