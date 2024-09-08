using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;
        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Comments>> GetAllAsync()
        {
            return await _context.Comment.ToListAsync();
        }

        public async Task<Comments> GetByIdAsync(int id)
        {
            return await _context.Comment.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Comments> CreateAsync(Comments commentModel)
        {
            await _context.Comment.AddAsync(commentModel);
            await _context.SaveChangesAsync();
            return commentModel;
        }

        public async Task<Comments?> UpdateAsync(int id, Comments commentModel)
        {
            var existingComment = await _context.Comment.FindAsync(id);
            if (existingComment == null)
            {
                return null;
            }
            existingComment.Title = commentModel.Title;
            existingComment.Content = commentModel.Content;
            await _context.SaveChangesAsync();
            return existingComment;
        }

        public async Task<Comments> DeleteAsync(int id)
        {
            var comment = await _context.Comment.FirstOrDefaultAsync(x => x.Id == id);
            if (comment == null)
            {
                return null;
            }
            _context.Comment.Remove(comment);
            await _context.SaveChangesAsync();
            return comment;


        }
    }
}