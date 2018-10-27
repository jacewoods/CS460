using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HW5SimpleDB.Models;

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