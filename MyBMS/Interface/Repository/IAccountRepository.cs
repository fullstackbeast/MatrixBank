using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBMS.Models;
using MyBMS.Models.Entities;

namespace MyBMS.Interface.Repository
{
    public interface IAccountRepository
    {

        public bool Create(Account account);
        public Account FindById(int id);
        public Account Update(Account account);

        public bool UpdateMultiple(List<Account> accounts);
        public Account FindByAccountNumber(string accountNumber);
    }
}
