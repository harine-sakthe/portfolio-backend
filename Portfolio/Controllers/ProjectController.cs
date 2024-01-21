using Portfolio.Controllers;
using Portfolio.Models;
using Portfolio;

public class ProjectController : BaseController<Projects>
{
	public ProjectController(IServices services) : base(services)
	{
	}

}
