using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Establish the elements that will be used in the database
/// </summary>
namespace GiphyProj.Models
{
    public class Giphy
    {
        public int ID { get; set; }

        private DateTime Date = DateTime.Now;

        public DateTime CurrentTime
        {
            get { return Date; }
            set { Date = value; }
        }

        public string InputTerm { get; set; }

        public string IPAddress { get; set; }

        public string BrowserType { get; set; }
    }
}