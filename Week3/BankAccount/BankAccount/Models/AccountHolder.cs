using System.ComponentModel.DataAnnotations;

namespace BankAccount.Models
{
    public class AccountHolder
    {
        public int AccountHolderId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$",
            ErrorMessage = "SSN must be in the format ###-##-####")]
        public string SSN { get; set; }
        public string PhoneNumber { get; set; }
        public List<BankAccount>? BankAccounts { get; set; }
        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";
    }
}
