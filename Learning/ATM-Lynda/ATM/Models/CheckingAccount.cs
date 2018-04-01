using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Account Number")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Account number is required")]
        public string AccountNumber { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(0.0, 500000000.0)]
        public decimal Balance { get; set; }
        public string Name
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
}