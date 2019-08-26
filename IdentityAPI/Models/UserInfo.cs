using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAPI.Models
{
    [Table("RegisteredUsers")]
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="First Name Required!")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Last Name Required!")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Email Required!")]
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password Required!")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Contact Number")]
        [Required(ErrorMessage ="Contact Number required!")]
        public int ContactNumber { get; set; }
    }
}
