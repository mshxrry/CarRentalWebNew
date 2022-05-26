using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CarRentalWeb.Models;
using CarRentalClub.Models;

namespace CarRentalWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CarRentalWeb.Models.Customer> Customer { get; set; }
        public DbSet<CarRentalWeb.Models.Reservation> Reservation { get; set; }
        public DbSet<CarRentalWeb.Models.Vehicle> Vehicle { get; set; }
        public DbSet<CarRentalClub.Models.Location> Location { get; set; }
    }
}
