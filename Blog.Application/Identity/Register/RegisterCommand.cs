using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blog.Application.Identity.Register
{
    public record RegisterCommand(
        [Required] string Email,
        [Required][MinLength(6)] string Password,
        [Required] string DisplayName
    ) : IRequest<bool>;
}
