using Blog.Domain.Articles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Infrastructure.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _context;

        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> CreateArticlesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Article>> GetArticlesAsync(Article article)
        {
            return await _context.Articles.ToListAsync();
        }
    }
}
