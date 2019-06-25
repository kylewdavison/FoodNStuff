﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoonNStuff.MVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        //public string FullName {get{return $"{FirstName} {LastName}";}}
        //testing commit
    }
}