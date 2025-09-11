namespace BankAccount.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateOpened { get; set; }
        public int AccountHolderId { get; set; }
        public AccountHolder AccountHolder { get; set; }
    }
    public class AccountHolder
    {
        public int AccountHolderId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<BankAccount>? BankAccounts { get; set; }
    }
}
