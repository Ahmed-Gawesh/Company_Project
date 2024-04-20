using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Project.PL.ViewModels
{
	public class RegisterViewModel:IdentityUser
	{
		[Required(ErrorMessage ="FName Is Required")]
		public string FName { get; set; }
		[Required(ErrorMessage = "LName Is Required")]

		public string LName { get; set; }
		[Required(ErrorMessage = "E-Mail Is Required")]
		[EmailAddress]
		public string Email { get; set; }
		[Required(ErrorMessage ="Password Is Required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required(ErrorMessage = "ConfirmPassword Is Required")]
		[DataType(DataType.Password)]
		[Compare("Password")]
		public string ConfirmPassword { get; set; }
		public bool IsAgree { get; set; }


	}
}
