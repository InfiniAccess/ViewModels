using System.ComponentModel.DataAnnotations;
namespace Tester.Models
{
    public class User
    {
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name:")]
        public string LastName { get; set; }
    }
}