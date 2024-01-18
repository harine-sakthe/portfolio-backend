using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers
{
	[ApiController]
	[Route("api/project")]
	public class ProjectController : ControllerBase
	{
		private readonly IServices _services;

		public ProjectController(IServices services)
		{
			_services = services;
		}

		[HttpGet("getEducationDetails")]
		public async Task<IActionResult> GetProjectDetails()
		{
			try
			{
				var projectDetails = await _services.GetProjectDetailsAsync();
				return Ok(projectDetails);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"An error occurred while fetching education details: {ex.Message}");
			}
		}

	}

}

