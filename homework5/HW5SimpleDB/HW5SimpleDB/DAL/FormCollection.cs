using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW5SimpleDB.Models;

namespace HW5SimpleDB.DAL
{
    public class FormCollection
    {
        public List<FridgeForm> Users;

        public FormCollection()
        {
            Users = new List<FridgeForm>
            {
                new FridgeForm {FirstName = "John", LastName = "Doe", PhoneNumber = "503-999-9998", ApartmentName = "Westfield Apartments", UnitNumber = 865, Explanation = "Fridge is Melting" },
                new FridgeForm {FirstName = "Claire", LastName = "Smith", PhoneNumber = "503-555-5558", ApartmentName = "Westfield Apartments", UnitNumber = 764, Explanation = "Fridge Exploded" },
                new FridgeForm {FirstName = "Samantha", LastName = "George", PhoneNumber = "503-444-4448", ApartmentName = "Cooltown Apartments", UnitNumber = 502, Explanation = "Fridge Wont Turn On" },
                new FridgeForm {FirstName = "Robert", LastName = "Woods", PhoneNumber = "503-333-3338", ApartmentName = "Cooltown Apartments", UnitNumber = 501, Explanation = "Fridge Is on Fire" },
                new FridgeForm {FirstName = "Sam", LastName = "Schnepp", PhoneNumber = "971-123-4567", ApartmentName = "Dimsdale Apartments", UnitNumber = 300, Explanation = "Fridge Split in Half" }
            };
        }

        // Should add a method to add a user
    }
}