using GestoriumAPI_Domain.Enums;
using GestoriumAPI_Domain.Entities.Base;

namespace GestoriumAPI_Domain.Entities.Clients;
public class ClientPayment : BaseEntity
{
	public Guid CustomerId { get; set; }
	public decimal Amount { get; set; }
	public DateTime PaymentDate { get; set; }
	public PaymentMethod Method { get; set; }
	public string? Description { get; set; }
}
