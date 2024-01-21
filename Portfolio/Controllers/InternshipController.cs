using Portfolio.Controllers;
using Portfolio.Models;
using Portfolio;

public class InternshipController : BaseController<Internships>
{
	public InternshipController(IServices services) : base(services)
	{
	}

}