using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GiphyProj.Models;

namespace GiphyProj.DAL
{
    public class GiphyContext : DbContext
    {
        public GiphyContext() : base("name=Giphies")
        {

        }
        public virtual DbSet<Giphy> Giphies { get; set; }
    }
}