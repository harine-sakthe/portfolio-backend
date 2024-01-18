using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portfolio.Services
{
	public class Services : IServices
	{
		private readonly DatabaseContext _context;

		public Services(DatabaseContext context)
		{
			_context = context;
		}

		public async Task CreateContactFormAsync(ContactForm form)
		{
			try
			{
				_context.contactForms.Add(form);
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception("Error saving contact form to the database", ex);
			}
		}

		public async Task<IActionResult> GetEducationDetailsAsync()
		{
			try
			{
				var educationDetails = await _context.educations.ToListAsync();
				return new OkObjectResult(educationDetails);
			}
			catch (Exception ex)
			{
				throw new Exception($"Error getting education details: {ex.Message}");
			}
		}
		public async Task<IActionResult> GetCertificationDetailsAsync()
		{
			try
			{
				var certificationDetails = await _context.educations.ToListAsync();
				return new OkObjectResult(certificationDetails);
			}
			catch (Exception ex)
			{
				throw new Exception($"Error getting education details: {ex.Message}");
			}
		}
		public async Task<IActionResult> GetInternshipDetailsAsync()
		{
			try
			{
				var internshipDetails = await _context.internships.ToListAsync();
				return new OkObjectResult(internshipDetails);
			}
			catch (Exception ex)
			{
				throw new Exception($"Error getting internship details: {ex.Message}");
			}
		}
		public async Task<IActionResult> GetLanguageDetailsAsync()
		{
			try
			{
				var languageDetails = await _context.languages.ToListAsync();
				return new OkObjectResult(languageDetails);
			}
			catch (Exception ex)
			{
				throw new Exception($"Error getting language details: {ex.Message}");
			}
		}
		public async Task<IActionResult> GetProjectDetailsAsync()
		{
			try
			{
				var projectDetails = await _context.Projects.ToListAsync();
				return new OkObjectResult(projectDetails);
			}
			catch (Exception ex)
			{
				throw new Exception($"Error getting project details: {ex.Message}");
			}
		}
	}
}
