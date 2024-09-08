using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comments
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be of 5 character")]
        [MaxLength(280, ErrorMessage = "Title can not be over 280 characters")]
        public string Title { get; set; } = string.Empty;  // Ensures non-null string

        [Required]
        [MinLength(5, ErrorMessage = "Title must be of 5 character")]
        [MaxLength(280, ErrorMessage = "Title can not be over 280 characters")]
        public string Content { get; set; } = string.Empty;
    }
}