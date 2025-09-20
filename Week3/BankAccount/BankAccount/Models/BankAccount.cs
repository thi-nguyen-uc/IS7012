using System.ComponentModel.DataAnnotations;

namespace BankAccount.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }
        [Display(Name = "Account Name")]
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        [Display(Name = "Date Opened")]
        public DateTime DateOpened { get; set; }
        public int AccountHolderId { get; set; }
        [Display(Name = "Account Holder")]
        public AccountHolder? AccountHolder { get; set; }
    }
    
}