using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers
{
	[Route("api/Language")]
	[ApiController]
	public class LanguageController : ControllerBase
	{
		private readonly IServices _services;

		public LanguageController(IServices services)
		{
			_services = services;
		}
		[HttpGet("getInternshipDetails")]
		public async Task<IActionResult> GetLanguageDetails()
		{
			try
			{
				var languageDetails = await _services.GetLanguageDetailsAsync();
				return Ok(languageDetails);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"An error occurred while fetching education details: {ex.Message}");
			}
		}

	}
}
