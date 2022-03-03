using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyBlue.Domain.Models
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public DateTime DateOfBirth { get; set; }

        public string Selfie { get; set; }
        public string TelephoneNumber { get; set; }
        public string BVN { get; set; }
        public string AccountNumber { get; set; }

    }
}
