using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW5SimpleDB.Models
{
    public class Renter
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(20)]
        public string FirstName { get; set; }

        [Required, StringLength(20)]
        public string LastName { get; set; }

        [Required, RegularExpression("^\\d{3}-\\d{3}-\\d{4}$")]
        public string PhoneNumber { get; set; }

        [Required, StringLength(30)]
        public string ApartmentName { get; set; }

        [Required, Range(0,9999)]
        public int UnitNumber { get; set; }

        [Required, StringLength(200)]
        public string Explanation { get; set; }

        [Required]
        public bool Permission { get; set; }


        

        public override string ToString()
        {
            return $"{base.ToString()}: {FirstName} {LastName} {PhoneNumber} {ApartmentName} UnitNumber = {UnitNumber} {Explanation} Permission = {Permission}";
        }
    }
}