using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.Identity.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator() 
        {
            RuleFor(v => v.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("A valid email is required");

            RuleFor(v => v.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(7).WithMessage("Minimum length required for password is 7 characters")
                .Matches(@"[A-Z]").WithMessage("Minimum 1 uppercase letter")
                .Matches(@"[a-z]").WithMessage("Minimum 1 lowercase letter")
                .MaximumLength(20).WithMessage("Maximum length of 20");

            RuleFor(v => v.DisplayName)
                .NotEmpty().WithMessage("Username is required")
                .MaximumLength(20).WithMessage("Username's maximum length is 20 characters");
        }
    }
}
