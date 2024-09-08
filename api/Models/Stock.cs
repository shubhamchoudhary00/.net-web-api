using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("Stocks")]
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; } // Corrected from 'int' to 'decimal'

        [Column(TypeName = "decimal(18,2)")]
        public decimal Lastdiv { get; set; } // Corrected from 'int' to 'decimal'

        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }

        public List<Comments> CommentsList { get; set; } = new List<Comments>(); // Renamed MyProperty
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>(); // Renamed MyProperty
    }
}
