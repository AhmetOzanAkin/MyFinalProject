using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public string CustomerId { get; set; } // Northwind veritabanında string verildi diye string tanımladık normalde id string olmaz
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

    }
}
