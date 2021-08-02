using Microsoft.EntityFrameworkCore;

namespace cohesion_CRUD.Models
{
	public class ServiceRequestContext : DbContext
	{
		public ServiceRequestContext(DbContextOptions<ServiceRequestContext> options) : base(options)
		{
		}

		public DbSet<ServiceRequest> ServiceRequests { get; set; }
	}
}
