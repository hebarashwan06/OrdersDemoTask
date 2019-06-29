using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.DataMapping.Entities
{
    public class UserProfile
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(50,ErrorMessage ="First Name can't exceed 50 char")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "Last Name can't exceed 50 char")]
        public string LastName { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage ="User Name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Address { get; set; }
    }
}
