using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers
{
	[Route("api/Internship")]
	[ApiController]
	public class InternshipController : ControllerBase
	{
		private readonly IServices _services;

		public InternshipController(IServices services)
		{
			_services = services;
		}
		[HttpGet("getInternshipDetails")]
		public async Task<IActionResult> GetInternshipDetails()
		{
			try
			{
				var educationDetails = await _services.GetEducationDetailsAsync();
				return Ok(educationDetails);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"An error occurred while fetching education details: {ex.Message}");
			}
		}

	}
}
