using System;

namespace BankingApp.Models
{
    public interface ITransactions
    {
        decimal AMOUNT { get; set; }
        decimal FROM_ACCOUNT_BALANCE { get; set; }
        int FROM_ACCOUNT_ID { get; set; }
        string FROM_ACCOUNT_NAME { get; set; }
        decimal TO_ACCOUNT_BALANCE { get; set; }
        int TO_ACCOUNT_ID { get; set; }
        string TO_ACCOUNT_NAME { get; set; }
        DateTime TRANACTION_TIMESTAMP { get; set; }
        int TRANSACTION_ID { get; set; }
    }
}