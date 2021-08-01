using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
