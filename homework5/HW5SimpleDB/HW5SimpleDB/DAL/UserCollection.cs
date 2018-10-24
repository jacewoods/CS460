using HW5SimpleDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW5SimpleDB.Models;

namespace User_NoDB.DAL
{
    public class UserCollection
    {
        public List<User> Users;

        public UserCollection()
        {
            Users = new List<User>
            {
                new User {FirstName = "Bob", LastName = "Roberts", DOB = new DateTime(1994,8,13) },
                new User {FirstName = "Bill", LastName = "Williams", DOB = new DateTime(1990,1,20) },
                new User {FirstName = "Diane", LastName = "Jackson", DOB = new DateTime(1981,2,14) },
                new User {FirstName = "Sue", LastName = "Susanson", DOB = new DateTime(1950,2,25) },
                new User {FirstName = "Jean Luc", LastName = "Picard", DOB = new DateTime(2105,4,9) }
            };
        }

        // Should add a method to add a user
    }
}