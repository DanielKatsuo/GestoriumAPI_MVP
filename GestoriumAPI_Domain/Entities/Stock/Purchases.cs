using GestoriumAPI_Domain.Enums;
using GestoriumAPI_Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI_Domain.Entities.Stock
{
	public sealed class Purchases : BaseEntity
	{
		public Guid IdSupplier { get; set; }
		public DateTime PurchaseDate { get; set; }
		public decimal TotalAmount { get; set; }
		public string? PaymentMethod { get; set; }
		public PurchaseStatus? Status { get; set; }
		public string? Notes { get; set; }
		public DateTime LastUpdate { get; set; }
	}
}
