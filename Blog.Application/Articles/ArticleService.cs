using Blog.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.Articles
{
    public class ArticleService : IArticleService
    {
        public List<Article> GetAllArticles()
        {
            return new List<Article> {
                new Article
                {
                    Id = 1,
                    Title = "Test",
                    Content = "Test"
                }
            };
        }
    }
}
