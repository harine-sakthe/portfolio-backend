using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers
{
	[ApiController]
	[Route("portFolio/[controller]")]
	public class BaseController<T> : ControllerBase where T : class
	{
		private readonly IServices _services;

		public BaseController(IServices services)
		{
			_services = services;
		}

		//For fetching the datas from the database to display it in the Frontend Page.
		[HttpGet("getDetails")]
		public async Task<IActionResult> GetDetails()
		{
			try
			{
				var details = await _services.GetDetailsAsync<T>();
				return Ok(details);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"An error occurred while fetching details: {ex.Message}");
			}
		}


		//For posting the datas(Not Necessary)
		[HttpPost("submitDetails")]
		public async Task<IActionResult> CreateDetails([FromBody] T details)
		{
			try
			{
				await _services.CreateAsync(details);
				return Ok("Details submitted successfully");
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"An error occurred while processing the details: {ex.Message}");
			}
		}

	}
}
