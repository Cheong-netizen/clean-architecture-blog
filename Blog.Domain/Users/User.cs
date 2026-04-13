using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Users
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }
}
