using BankingApp.Models;
using System.Collections.Generic;

namespace BankingApp.Services
{
    public interface ITransactionService
    {
        IEnumerable<Transactions> GetTransactions();
    }
}