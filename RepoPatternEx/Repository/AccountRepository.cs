using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId)).ToList();
        }

        public void CreateAccount(Account account)
        {
            Create(account);
        }

        public void DeleteAccount(Account account)
        {
            Delete(account);
        }

        public Account GetAccountById(Guid accountId)
        {
            return FindByCondition(account => account.AccountId.Equals(accountId))
                    .FirstOrDefault();
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return FindAll()
                .OrderBy(a => a.Owner.Name)
                .ToList();
        }

        public void UpdateAccount(Account account)
        {
            Update(account);
        }
    }
}