using Blog.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.Articles
{
    public interface IArticleService
    {
        Task<List<Article>> GetAllArticlesAsync();
    }
}
