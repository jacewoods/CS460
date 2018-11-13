using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HW8.Models;

namespace HW8.DAL
{
    public class AuctionContext : DbContext
    {
        public AuctionContext() : base("name=Auctions") { }

        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Bid> Bids { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
    }

}