﻿using System.ComponentModel.DataAnnotations;

namespace Demo_PL.Models
{
	public class ForgetPasswordViewModel
	{
		[Required]
		[EmailAddress(ErrorMessage ="Invalid Email!!")]
		public string EmailAddress { get; set; }
	}
}
