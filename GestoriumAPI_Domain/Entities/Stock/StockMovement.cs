using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestoriumAPI_Domain.Entities.Base;
using GestoriumAPI_Domain.Entities.Products;
using GestoriumAPI_Domain.Enums;


namespace GestoriumAPI_Domain.Entities.Stock
{
	public sealed class StockMovement : BaseEntity
	{
		public int IdProduct { get; set; }
		public MovementType Type { get; set; }
		public StockStatus Situation { get; set; }
		public int Quantity { get; set; }
		public DateTime MovementDate { get; set; }
		public string? Notes { get; set; }
	}
}
