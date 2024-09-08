using api.Dtos.Stocks;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            if (stockModel == null) return null;

            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                Lastdiv = stockModel.Lastdiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap,
                CommentsList = stockModel.CommentsList.Select(c => c.ToCommentDto()).ToList()
            };
        }

        // Reverse mapping method to convert StockDto to Stock entity
        public static Stock ToStock(this StockDto stockDto)
        {
            if (stockDto == null) return null;

            return new Stock
            {
                Id = stockDto.Id,
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                Lastdiv = stockDto.Lastdiv,
                Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap
            };
        }
        public static Stock ToStackFromCreateDto(this CreateStockRequestDto stockDto)
        {
            return new Stock
            {
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                Lastdiv = stockDto.Lastdiv,
                Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap
            };
        }
    }
}
