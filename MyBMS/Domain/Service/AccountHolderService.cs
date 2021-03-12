

using MyBMS.Interface.Repository;
using MyBMS.Interface.Service;
using MyBMS.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBMS.Domain.Service
{
    public class AccountHolderService : IAccountHolderService
    {
        private readonly IAccountHolderRepository _accountHolderRepository;
        private readonly IAccountRepository _accountRepository;



        public AccountHolderService(IAccountHolderRepository accountHolderRepository, IAccountRepository accountRepostiory)
        {
            _accountHolderRepository = accountHolderRepository;
            _accountRepository = accountRepostiory;
        }

        public List<AccountHolder> GetAll()
        {
            return _accountHolderRepository.GetAll();
        }

        public AccountHolder CreateAccountHolder(AccountHolder newAccountHolder)
        {
            int accountHolderId = _accountHolderRepository.CreateAccountHolder(newAccountHolder);

            if (accountHolderId != 0)
            {
                if (CreateAccount(accountHolderId))
                {
                    return newAccountHolder;
                }
            }

            return newAccountHolder;
        }

        public AccountHolder FindById(int id)
        {
            return _accountHolderRepository.FindById(id);
        }
        public AccountHolder FindByEmail(string email)
        {
            return _accountHolderRepository.FindByEmail(email);
        }

        public AccountHolder GetDetails(int id)
        {
            return _accountHolderRepository.GetDetails(id);
        }

        public void UpdateAccountHolder(AccountHolder accountHolder)
        {

            _accountHolderRepository.Update(accountHolder);

        }

        private bool CreateAccount(int accountHolderId)
        {
            string accountNumber = GenerateAccountNumber();

            Account newAccount = new Account
            {
                AccountHolderId = accountHolderId,
                AccountNumber = accountNumber,
                AccountBalance = 0,
                Pin = 0,
                AccountStatus = 1
            };

            bool hasCreate = _accountRepository.Create(newAccount);

            return hasCreate;

        }


        private string GenerateAccountNumber()
        {
            Random random = new Random();

            string firstFive = random.Next(1, 10000).ToString("00000");
            string secondFive = random.Next(1, 10000).ToString("00000");

            string generatedNumber = $"{firstFive}{secondFive}";

            return generatedNumber;
        }

        public void DeleteAccountHolder(int id)
        {
            _accountHolderRepository.DeleteAccountHolder(id);
        }

    }
}
