using System.ComponentModel.DataAnnotations;

namespace Project.PL.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "NewPassword Is Required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "ConfirmPassword Is Required")]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}
