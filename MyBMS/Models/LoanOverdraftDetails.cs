using System;
using System.Collections.Generic;
using System.Text;
using MyBMS.Models.Entities;

namespace MyBMS.Models
{
    public abstract class LoanOverdraftDetails: BaseEntity
    {

        public AccountHolder AccountHolder { get; set; }

        public int AccountHolderId { get; set; }

        public double Amount { get; set; }

        public int Status { get; set; }


       
    }
}
