using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using ATM.Models;

namespace ATM.Db.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        [Column(TypeName ="varchar")]
        public string AccountNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Range(0.0, 500000000.0)]
        public decimal Balance { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
}
}