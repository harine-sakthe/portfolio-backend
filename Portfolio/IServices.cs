using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Threading.Tasks;

namespace Portfolio
{
	public interface IServices
	{
		Task CreateContactFormAsync(ContactForm form);
		Task<IActionResult> GetEducationDetailsAsync();
		Task<IActionResult> GetCertificationDetailsAsync();
		Task<IActionResult> GetInternshipDetailsAsync();
		Task<IActionResult> GetLanguageDetailsAsync();
		Task<IActionResult> GetProjectDetailsAsync();
	}
}
