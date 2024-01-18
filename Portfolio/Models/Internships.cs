using Microsoft.Identity.Client;

namespace Portfolio.Models
{
	public class Internships
	{
		public int id { get; set; }
		public string title { get; set; }
		public string role { get; set; }
		public string description { get; set; }
		public string duration {  get; set; }
	}
}
