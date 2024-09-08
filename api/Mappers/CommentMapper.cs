using api.Dtos.Comments;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {
        // Maps Comments to CommentDto
        public static CommentDto ToCommentDto(this Comments commentModel)
        {
            if (commentModel == null) return null;

            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId
            };
        }

        // Maps CommentDto to Comments
        public static Comments ToComment(this CommentDto commentDto)
        {
            if (commentDto == null) return null;

            return new Comments
            {
                Id = commentDto.Id,
                Title = commentDto.Title,
                Content = commentDto.Content,
                CreatedOn = commentDto.CreatedOn,
                StockId = commentDto.StockId
            };
        }

        public static Comments ToCommentFromCreate(this CreateCommentDto commentDto, int stockId)
        {
            return new Comments
            {

                Title = commentDto.Title,
                Content = commentDto.Content,
                StockId = stockId
            };
        }
        public static Comments ToCommentFromUpdate(this UpdateCommentRequestDto commentDto)
        {
            return new Comments
            {

                Title = commentDto.Title,
                Content = commentDto.Content,
            };
        }
    }
}
