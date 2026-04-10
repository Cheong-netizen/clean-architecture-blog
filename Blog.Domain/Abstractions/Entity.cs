using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Abstractions
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpload { get; set; }

    }
}
