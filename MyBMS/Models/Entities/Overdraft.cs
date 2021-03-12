using System;
using System.Collections.Generic;
using System.Text;

namespace MyBMS.Models.Entities
{
    public class Overdraft : LoanOverdraftDetails
    {

        public double AmountLeft { get; set; }
        public DateTime OverdraftDate { get; }


       
    }
}
