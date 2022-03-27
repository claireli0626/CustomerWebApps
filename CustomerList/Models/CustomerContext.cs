using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerList.Models
{
        public class CustomerContext : DbContext
        {
            public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
            { }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Gender> Genders { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Gender>().HasData(
                    new Gender { GenderID = "M", Name = "Male" },
                    new Gender { GenderID = "F", Name = "Famale" },
                    new Gender { GenderID = "I", Name = "Intersex" }
                    );


                modelBuilder.Entity<Customer>().HasData(new Customer
                {
                    CustomerId = 1,
                    FirstName = "A",
                    LastName = "J",
                    GenderID = "M",
                    Email = "aj@gmail.com"
                }, new Customer
                {
                    CustomerId = 2,
                    FirstName = "B",
                    LastName = "K",
                    GenderID = "F",
                    Email = "bk@gmail.com"
                }, new Customer
                {
                    CustomerId = 3,
                    FirstName = "C",
                    LastName = "L",
                    GenderID = "F",
                    Email = "cl@gmail.com"
                }, new Customer
                {
                    CustomerId = 4,
                    FirstName = "D",
                    LastName = "M",
                    GenderID = "I",
                    Email = "dm@gmail.com"
                }, new Customer
                {
                    CustomerId = 5,
                    FirstName = "E",
                    LastName = "N",
                    GenderID = "M",
                    Email = "en@gmail.com"
                });
            }

        }
}
