using Portfolio.Controllers;
using Portfolio.Models;
using Portfolio;

public class CertificateController : BaseController<Certifications>
{
	public CertificateController(IServices services) : base(services)
	{
	}

}