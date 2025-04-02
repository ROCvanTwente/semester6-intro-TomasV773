﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRDbDependency.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Column(TypeName = "nvarchar"), StringLength(50)]
		public string Name { get; set; } = string.Empty;
		
		[Column(TypeName = "nvarchar"), StringLength(50)]
		public string Category { get; set; } = string.Empty;

		[Column(TypeName = "decimal(10,2)")]
		public string? Price { get; set; }
	}
}
