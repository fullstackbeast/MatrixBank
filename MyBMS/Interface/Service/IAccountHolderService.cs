using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBMS.Models.Entities;

namespace MyBMS.Interface.Service
{
    public interface IAccountHolderService
    {

        public AccountHolder CreateAccountHolder(AccountHolder accountHolder);
        public List<AccountHolder> GetAll();
        public AccountHolder FindById(int id);
        public AccountHolder FindByEmail(string email);
         public AccountHolder GetDetails(int id);
        public void UpdateAccountHolder(AccountHolder accountHolder);
        public void DeleteAccountHolder(int id);
     
    }
}