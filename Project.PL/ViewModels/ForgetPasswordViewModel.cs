using System.ComponentModel.DataAnnotations;

namespace Project.PL.ViewModels
{
	public class ForgetPasswordViewModel
	{
		[Required(ErrorMessage = "Email Is Required")]
		[EmailAddress(ErrorMessage = "Email Is Invalid")]
		public string Email { get; set; }
	}
}
