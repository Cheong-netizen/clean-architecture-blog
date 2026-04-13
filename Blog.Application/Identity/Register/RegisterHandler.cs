using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.Identity.Register
{
    public class RegisterHandler : IRequestHandler<RegisterCommand, bool>
    {
        public Task<bool> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
