using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAllAccounts();
        IEnumerable<Account> AccountsByOwner(Guid accountId);
        Account GetAccountById(Guid accountId);
        void CreateAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(Account account);
    }
}