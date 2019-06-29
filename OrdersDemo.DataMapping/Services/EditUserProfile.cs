using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.DataMapping.Services
{
    public class EditUserProfile
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "First Name can't exceed 50 char")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "Last Name can't exceed 50 char")]
        public string LastName { get; set; }

        
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        
        public string UserName { get; set; }

        public string Address { get; set; }
    }
}
