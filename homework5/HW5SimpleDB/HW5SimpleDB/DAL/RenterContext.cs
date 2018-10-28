using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HW5SimpleDB.Models;


/// <summary>
/// Connect the "OurRenters" database to the application
/// </summary>
namespace HW5SimpleDB.DAL
{
    public class RenterContext : DbContext
    {
        public RenterContext() : base("name=OurRenters")
        {

        }
        public virtual DbSet<Renter> Renters { get; set; }
    }
}