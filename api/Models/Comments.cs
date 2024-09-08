using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("Comments")]
    public class Comments
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;  // Ensures non-null string
        public string Content { get; set; } = string.Empty;  // Ensures non-null string
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        // Navigation property for relationship with Stock
        public int? StockId { get; set; }  // Nullable Stock ID
        public Stock? Stock { get; set; }  // Nullable navigation
    }
}