﻿using Microsoft.AspNetCore.Identity;

namespace RestaurantProject.Models
{
	public class ApplicationUser : IdentityUser
	{
		public ICollection<Order>? Orders { get; set; }
	}
}
