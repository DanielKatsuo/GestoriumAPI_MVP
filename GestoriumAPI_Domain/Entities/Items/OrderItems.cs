using GestoriumAPI_Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI_Domain.Entities.Items
{
	public class OrderItems : BaseEntity
	{
		public Guid Product { get; set; }
		public Guid Service { get; set; }
		public int Quantity { get; set; }
	}
}
