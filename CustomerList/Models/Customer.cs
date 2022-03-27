using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace CustomerList.Models
{
    public class Customer
    {
        // EF Core will configure the database to generate this value
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a gender.")]
        public string GenderID { get; set; }
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
    }



}


