using BankingApp.Models;
using System.Collections.Generic;

namespace BankingApp.Services
{
    public interface IAccountService
    {
        IEnumerable<Accounts> GetAccounts();
    }
}