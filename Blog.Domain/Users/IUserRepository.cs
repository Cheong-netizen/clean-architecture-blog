using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Users
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
    }
}
