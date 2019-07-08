﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridModeAuthSample.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string Role { get; set; }
		public DateTime LoginTime { get; set; }
	}

	public class UserMock
	{
		public static User FindUser(string userName, string password)
		{
			return new User()
			{
				Id = 123,
				Name = "admin",
				Account = "Administrator",
				Password = "123456",
				Email = "admin@qq.com",
				LoginTime = DateTime.Now,
				Role = userName.Equals("admin") ? "Admin" : "User"
			};
		}
	}
}
