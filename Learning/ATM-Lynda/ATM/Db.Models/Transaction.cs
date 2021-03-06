﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM.Db.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public int CheckingAccountId { get; set; }
        public CheckingAccount CheckingAccount { get; set; }
    }
}