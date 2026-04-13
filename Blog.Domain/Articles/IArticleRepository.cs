using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Articles
{
    public interface IArticleRepository
    {
        Task<List<Article>> GetArticlesAsync();
    }
}
