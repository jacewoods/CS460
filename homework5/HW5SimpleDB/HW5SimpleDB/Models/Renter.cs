using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Establish the elements that will be used in the database, including their required inputs and error messages that transfer to View
/// </summary>
namespace HW5SimpleDB.Models
{
    public class Renter
    {
        [Key]
        public int ID { get; set; }

        [Required (ErrorMessage = "Please input a First Name"), StringLength(20, ErrorMessage = "Input can be no longer than 20 Characters")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Please input a Last Name"), StringLength(20, ErrorMessage ="Input can be no longer than 20 Characters")]
        public string LastName { get; set; }

        [Required (ErrorMessage ="Please input a Phone Number"), RegularExpression("^\\d{3}-\\d{3}-\\d{4}$", ErrorMessage = "Phone Number must be in format \"XXX-XXX-XXXX\"")]
        public string PhoneNumber { get; set; }

        [Required (ErrorMessage = "Please input an Apartment Name"), StringLength(30, ErrorMessage = "Input can be no longer than 30 Characters")]
        public string ApartmentName { get; set; }

        [Required (ErrorMessage = "Please input a Unit Number"), Range(0,9999, ErrorMessage = "Unit Number must be between 0 and 9999")]
        public int UnitNumber { get; set; }

        [Required (ErrorMessage = "Please input an Explanation"), StringLength(60, ErrorMessage = "Input can be no longer than 60 Characters")]
        public string Explanation { get; set; }

        [Required]
        public bool Permission { get; set; }
        

        public override string ToString()
        {
            return $"{base.ToString()}: {FirstName} {LastName} {PhoneNumber} {ApartmentName} UnitNumber = {UnitNumber} {Explanation} Permission = {Permission}";
        }
    }
}