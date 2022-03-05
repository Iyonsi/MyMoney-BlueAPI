using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyBlue.Domain.Models
{
    public class Customer : BaseEntity
    {

        [Required, Display(Name = "FirstName")]
        [StringLength(15, ErrorMessage = "First name should not be more than 15 characters")]
        public string FirstName { get; set; }

        [Required, Display(Name = "LastName")]
        [StringLength(15, ErrorMessage = "Last name should not be more than 15 characters")]
        public string LastName { get; set; }

        [Display(Name = "DateofBirth")]
        public DateTime DateOfBirth { get; set; }

        [Required, Display(Name = "PhoneNumber")]
        public string Selfie { get; set; }

        [Required, Display(Name = "TelephoneNumber")]
        public string PhoneNumber { get; set; }

        [Required, Display(Name = "BVN")]
        public string BVN { get; set; }

        [Required, Display(Name = "AccountNumber")]
        public string AccountNumber { get; set; }

        [Required]
        public string Score { get; set; }
    }
}
