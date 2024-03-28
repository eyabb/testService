using Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.ViewModels
{
	public class RegisteUserViewModel
	{
		[Required]
		public string UserName { get; set; }
		
		[Required]
		[MinLength(6)]
		public string Password { get; set; }
		
		[Required]
		public string DisplayName { get; set; }
        //public ArrayList<> Roles { get; set; }
        public String[] Roles { get; set; }
	}
}
