using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Identity.Client;

namespace Portfolio.Models
{
	public class Internships
	{
		public int id { get; set; }
		public string title { get; set; }
		public string role { get; set; }
		public string timePeriod { get; set; }
		public string duration {  get; set; } 
		public string companyname { get; set; }
	}
}
