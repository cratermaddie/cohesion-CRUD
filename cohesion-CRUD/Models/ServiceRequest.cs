
using System;
using System.Text.Json.Serialization;

namespace cohesion_CRUD.Models
{
	public class ServiceRequest
	{
		public Guid Id { get; private set; }
		public String buildingCode { get; set; }
		public String description { get; set; }
		[JsonConverter(typeof(JsonStringEnumConverter))]
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
