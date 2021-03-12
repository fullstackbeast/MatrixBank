
using BMSEFDB.Models;
using Microsoft.EntityFrameworkCore;
using MyBMS.Interface.Repository;
using MyBMS.Models;
using MyBMS.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBMS.Domain.Repository
{
    public class AccountHolderRepository : IAccountHolderRepository
    {


        private readonly BankDBContext _context;

        public AccountHolderRepository(BankDBContext context)
        {
            _context = context;

        }
        public int CreateAccountHolder(AccountHolder accountHolder)
        {
            try
            {
                _context.AccountHolders.Add(accountHolder);
                _context.SaveChanges();
                return accountHolder.Id;


            }
            catch (Exception ea)
            {
                Console.WriteLine($"err2: {ea.Message}");
            }



            return 0;

        }

        public AccountHolder FindByEmail(string email)
        {

            return _context.AccountHolders.FirstOrDefault(e => e.Email == email);
        }

        public AccountHolder FindById(int id)
        {
            return _context.AccountHolders.FirstOrDefault(i => i.Id == id);
        }

        public AccountHolder Update(AccountHolder accountHolder)
        {
            _context.AccountHolders.Update(accountHolder);
            _context.SaveChanges();
            return accountHolder;
        }

        public List<AccountHolder> GetAll()
        {
            return _context.AccountHolders.ToList();
        }

        public AccountHolder GetDetails(int id)
        {

            var accountHolder = _context.AccountHolders
                .Where(ach => ach.Id == id)
                .Include(ach => ach.Account).FirstOrDefault();
            return accountHolder;

        }


        public void DeleteAccountHolder(int id)
        {
            var accountHolder = _context.AccountHolders.Find(id);
            _context.AccountHolders.Remove(accountHolder);
            _context.SaveChanges();
        }

    }
}