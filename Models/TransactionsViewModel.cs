using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    public class TransactionsViewModel : ITransactionsViewModel
    {
        public IEnumerable<Accounts> ListItems { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        public ITransactions LogEntry { get; set; }
    }
}