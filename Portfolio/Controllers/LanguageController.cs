using Portfolio.Controllers;
using Portfolio.Models;
using Portfolio;

public class LanguageController : BaseController<Languages>
{
	public LanguageController(IServices services) : base(services)
	{
	}

}