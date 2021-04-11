using BankingApp.Context;
using BankingApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BankingApp.Services
{
    public class TransactionService : ITransactionService
    {
        private SQLiteDBContext _context;
        public IEnumerable<Transactions> _accounts;

        public TransactionService(IEnumerable<Transactions> accounts, SQLiteDBContext context)
        {
            _accounts = accounts;
            _context = context;
        }

        public IEnumerable<Transactions> GetTransactions()
        {
            return _context.Transactions.AsEnumerable();
        }
    }
}