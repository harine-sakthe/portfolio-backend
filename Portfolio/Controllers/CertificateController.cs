using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
	[Route("api/certificate")]
	[ApiController]
	public class CertificateController : ControllerBase
	{
		private readonly IServices _services;

		public CertificateController(IServices services)
		{
			_services = services;
		}

		[HttpGet("getCertificationDetails")]
		public async Task<IActionResult> GetEducationDetails()
		{
			try
			{
				var certificationDetails = await _services.GetCertificationDetailsAsync();
				return Ok(certificationDetails);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"An error occurred while fetching education details: {ex.Message}");
			}
		}
	}
}

