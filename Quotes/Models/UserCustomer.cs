using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quotes.Models
{
    public class UserCustomer
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string LoginError { get; set; }

    }
}
