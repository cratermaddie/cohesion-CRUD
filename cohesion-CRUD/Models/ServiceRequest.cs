using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cohesion_CRUD.Models
{
	public class ServiceRequest
	{
		public Guid id { get; } = new Guid();
		public String buildingCode { get; set; }
		public String description { get; set; }
		public CurrentStatus currentStatus { get; set; }
		public String createdBy { get; set; }
		public DateTime createdDate { get; set; }
		public String lastModifiedBy { get; set; }
		public DateTime lastModifiedDate { get; set; }
	}

	public enum CurrentStatus
	{
		NotApplicable,
		Created,
		InProgress,
		Complete,
		Canceled
	}
}
