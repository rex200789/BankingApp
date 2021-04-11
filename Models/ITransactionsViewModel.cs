using System.Collections.Generic;

namespace BankingApp.Models
{
    public interface ITransactionsViewModel
    {
        decimal Amount { get; set; }
        int FromId { get; set; }
        IEnumerable<Accounts> ListItems { get; set; }
        ITransactions LogEntry { get; set; }
        int ToId { get; set; }
    }
}