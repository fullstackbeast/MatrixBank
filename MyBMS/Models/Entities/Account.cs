using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyBMS.Models.Entities
{
    public class Account
    {
      
        public int AccountHolderId { get; set; }
        public string AccountNumber { get; set; }

        public double AccountBalance { get; set; }

        public int Pin { get; set; }
        public int AccountStatus { get; set; }

        public AccountHolder AccountHolder { get; set; }

    }
}
