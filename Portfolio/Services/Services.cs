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
		public async Task<IEnumerable<T>> GetDetailsAsync<T>() where T : class
		{
			return await _context.Set<T>().ToListAsync();
		}

		public async Task CreateAsync<T>(T entity) where T : class
		{
			_context.Set<T>().Add(entity);
			await _context.SaveChangesAsync();
		}

		
	}
}
