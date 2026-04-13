using Blog.Domain.Articles;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.Articles.GetArticles
{
    public class GetArticlesQuery : IRequest<List<Article>>
    {
    }
}
