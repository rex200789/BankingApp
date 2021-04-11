using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    public class Accounts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ACCOUNT_ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter an account name")]
        [StringLength(maximumLength: 25, MinimumLength = 1, ErrorMessage = "Length must be between 1 to 25 characters")]
        public string ACCOUNT_NAME { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ACCOUNT_BALANCE { get; set; }

        public bool ACTIVE { get; set; }
    }
}