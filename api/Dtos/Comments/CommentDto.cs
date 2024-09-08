using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comments
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;  // Ensures non-null string
        public string Content { get; set; } = string.Empty;  // Ensures non-null string
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        // Navigation property for relationship with Stock
        public int? StockId { get; set; }  // Nullable Stock ID
    }
}