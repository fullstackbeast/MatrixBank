using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyBMS.Models.Entities
{
    public class AccountHolder : Details
    {
        public AccountHolder()
        {
            Loans = new List<Loan>();
            OverDrafts = new List<Overdraft>();
        }
        
        public DateTime DateOfBirth { get; set; }

       
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public Account Account {get; set;}

        public IList<Loan> Loans { get; set; } 

        public IList<Overdraft> OverDrafts { get; set; } 
    }
}
