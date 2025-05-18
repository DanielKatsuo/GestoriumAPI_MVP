using System.IO;
using GestoriumAPI_Domain.Entities.Clients;
using GestoriumAPI_Domain.Entities.Financial;
using GestoriumAPI_Domain.Entities.Items;
using GestoriumAPI_Domain.Entities.Logger;
using GestoriumAPI_Domain.Entities.Payments;
using GestoriumAPI_Domain.Entities.Products;
using GestoriumAPI_Domain.Entities.Reports;
using GestoriumAPI_Domain.Entities.Stock;
using GestoriumAPI_Domain.Entities.Suppliers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace GestoriumAPI_Infrastructure.Data
{
	public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
	{

		#region Clients  
		public DbSet<ClientInfo> ClientInfo { get; set; } = null!;
		public DbSet<ClientPayment> ClientPayment { get; set; } = null!;
		#endregion

		#region Financial
		public DbSet<TotalizersFinancial> TotalizersFinancial { get; set; } = null!;
		#endregion

		#region Items
		public DbSet<OrderItems> OrderItems { get; set; } = null!;
		#endregion

		#region ErrorLog
		public DbSet<ErrorLog> ErrorLog { get; set; } = null!;
		#endregion

		#region Payment
		public DbSet<Invoice> Invoice { get; set; } = null!;
		#endregion

		#region Products  
		public DbSet<Product> Product { get; set; } = null!;
		#endregion

		#region Reports
		public DbSet<ProvidedServices> ProvidedServices { get; set; } = null!;
		public DbSet<ServiceOrder> ServiceOrder { get; set; } = null!;
		#endregion

		#region Stock
		public DbSet<Purchases> Purchases { get; set; } = null!;
		public DbSet<StockMovement> StockMovement { get; set; } = null!;
		#endregion

		#region Suppliers
		public DbSet<Suppliers> Suppliers { get; set; } = null!;
		#endregion
	}

	public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
	{
		public DataContext CreateDbContext(string[] args)
		{
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
			optionsBuilder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));

			return new DataContext(optionsBuilder.Options);
		}
	}
}
