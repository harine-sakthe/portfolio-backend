using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Threading.Tasks;

namespace Portfolio
{
	public interface IServices
	{
		Task CreateContactFormAsync(ContactForm form);
		Task CreateAsync<T>(T details) where T : class;
		Task<IEnumerable<T>> GetDetailsAsync<T>() where T : class;


	}
}
