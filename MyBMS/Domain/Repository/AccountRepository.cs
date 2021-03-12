using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MySql.Data.MySqlClient;
using MyBMS.Interface.Repository;
using MyBMS.Models.Entities;
using BMSEFDB.Models;

namespace MyBMS.Domain.Repository
{
    public class AccountRepository : IAccountRepository
    {


        private readonly BankDBContext _context;

        public AccountRepository(BankDBContext context)
        {
            _context = context;

        }

        public bool Create(Account account)
        {

            _context.Accounts.Add(account);
            _context.SaveChanges();
            return true;
        }

        public Account FindById(int id)
        {
            return _context.Accounts.FirstOrDefault(a => a.AccountHolderId == id);
        }

        public Account Update(Account account)
        {
            _context.Accounts.Update(account);
            _context.SaveChanges();
            return account;
        }

        public bool UpdateMultiple(List<Account> accounts)
        {
            _context.Accounts.UpdateRange(accounts);
            _context.SaveChanges();
            return true;
        }

        public Account FindByAccountNumber(string accountNumber)
        {
            return _context.Accounts.FirstOrDefault(an => an.AccountNumber == accountNumber);
        }







    }



}
