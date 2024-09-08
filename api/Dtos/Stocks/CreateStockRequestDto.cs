using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stocks
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 characters")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(10, ErrorMessage = "Company Name can not be over 10 characters")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1, 100000000)]

        public decimal Purchase { get; set; } // Corrected from 'int' to 'decimal'

        [Required]
        [Range(0.01, 10000)]
        public decimal Lastdiv { get; set; } // Corrected from 'int' to 'decimal'
        [Required]
        [MaxLength(10, ErrorMessage = "IndustryName cannot be over 10 characters")]
        public string Industry { get; set; } = string.Empty;
        [Range(1, 50000000)]
        public long MarketCap { get; set; }

    }
}