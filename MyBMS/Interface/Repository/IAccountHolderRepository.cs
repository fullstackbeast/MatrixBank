 
using System;
using System.Collections.Generic;
using System.Text;
using MyBMS.Models;
using MyBMS.Models.Entities;

namespace MyBMS.Interface.Repository
{
    public interface IAccountHolderRepository
    {
        public  int CreateAccountHolder(AccountHolder accountHolder);

        public AccountHolder FindByEmail(string email);
       public AccountHolder GetDetails(int id);
        public AccountHolder FindById(int id);
        public AccountHolder Update(AccountHolder accountHolder);
        public List<AccountHolder> GetAll();
        public void DeleteAccountHolder(int id);
    }
}
