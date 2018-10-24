using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW5SimpleDB.Models
{
    public class User
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required, StringLength(15)]
        public string LastName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DOB.Year;
                if(DOB > today.AddYears (-age))
                {
                    age--;
                }
                return age;
            }
        }

        public override string ToString()
        {
            return @"{base.ToString()}: {FirstName} {LastName} DOB = {DOB} Age = {Age}";
        }
    }
}