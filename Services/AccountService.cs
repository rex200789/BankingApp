using BankingApp.Context;
using BankingApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BankingApp.Services
{
    public class AccountService : IAccountService
    {
        private SQLiteDBContext _context;
        public IEnumerable<Accounts> _accounts;

        public AccountService(IEnumerable<Accounts> accounts, SQLiteDBContext context)
        {
            _accounts = accounts;
            _context = context;
        }

        public IEnumerable<Accounts> GetAccounts()
        {
            return _context.Accounts.AsEnumerable();
        }
    }
}