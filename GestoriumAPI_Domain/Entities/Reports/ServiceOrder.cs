using GestoriumAPI_Domain.Entities.Base;
using GestoriumAPI_Domain.Entities.Items;
using GestoriumAPI_Domain.Enums;

namespace GestoriumAPI_Domain.Entities.Reports
{
	public sealed class ServiceOrder : BaseEntity
	{
		public required string Customer { get; set; }
		public required string CustomerContact { get; set; }
		public DateTime OpenDate { get; set; }
		public DateTime? CompletionDate { get; set; }
		public ServiceOrderStatus? Status { get; set; }
		public List<OrderItems>? Items { get; set; }
		public decimal? EstimatedValue { get; set; }
		public decimal? ServiceRate { get; set; }
		public decimal? FinalValue { get; set; }
	}
}
