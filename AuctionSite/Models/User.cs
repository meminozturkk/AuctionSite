﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionSite.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
	}
}