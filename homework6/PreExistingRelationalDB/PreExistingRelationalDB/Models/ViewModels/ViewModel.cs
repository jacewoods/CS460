using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreExistingRelationalDB.Models.ViewModels
{
    /// <summary>
    /// Conduit for Employee View to get database information from Person
    /// </summary>
    public class ViewModel
    {
        public Person Person { get; set; }
    }
}