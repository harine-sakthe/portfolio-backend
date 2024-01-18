using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers
{
	[ApiController]
	[Route("api/education")]
	public class EducationController : ControllerBase
	{
		private readonly IServices _services;

		public EducationController(IServices services)
		{
			_services = services;
		}

		[HttpGet("getEducationDetails")]
		public async Task<IActionResult> GetEducationDetails()
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

