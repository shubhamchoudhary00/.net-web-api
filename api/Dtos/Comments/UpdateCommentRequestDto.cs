using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comments
{
    public class UpdateCommentRequestDto
    {
        public string Title { get; set; } = string.Empty;  // Ensures non-null string
        public string Content { get; set; } = string.Empty;
    }
}