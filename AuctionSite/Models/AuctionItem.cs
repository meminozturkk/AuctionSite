using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionSite.Models
{
	public class AuctionItem
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public DateTime Date { get; set; }
		public decimal Price { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }
	}
}