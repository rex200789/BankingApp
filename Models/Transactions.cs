using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    public class Transactions : ITransactions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TRANSACTION_ID { get; set; }

        public int FROM_ACCOUNT_ID { get; set; }
        public int TO_ACCOUNT_ID { get; set; }
        public DateTime TRANACTION_TIMESTAMP { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal FROM_ACCOUNT_BALANCE { get; set; }
        public decimal TO_ACCOUNT_BALANCE { get; set; }
        public string FROM_ACCOUNT_NAME { get; set; }
        public string TO_ACCOUNT_NAME { get; set; }
    }
}