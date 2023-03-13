using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerTC { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int BirthYear { get; set; }
    }
}
