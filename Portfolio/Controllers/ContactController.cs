using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers
{
	[ApiController]
	[Route("api/contact")]
	public class ContactController : ControllerBase
	{
		private readonly IServices _services;

		public ContactController(IServices services)
		{
			_services = services;
		}

		[HttpPost("submitDetails")]
		public async Task<IActionResult> SubmitForm([FromBody] ContactForm form)
		{
			try
			{
				await _services.CreateContactFormAsync(form);
				return Ok("Form submitted successfully");
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"An error occurred while processing the form: {ex.Message}");
			}
		}


	}

}
