using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSearch.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
    }
}
