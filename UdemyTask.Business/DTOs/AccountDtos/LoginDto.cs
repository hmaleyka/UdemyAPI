using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTask.Business.DTOs.AccountDtos
{
    public record LoginDto
    {
        public string UserNameOrEmail {  get; set; }
        public string Password { get; set; }
    }
   public class LoginValidation : AbstractValidator<LoginDto>
    {
        public LoginValidation()
        {
            RuleFor(l => l.UserNameOrEmail)
                .NotEmpty()
                .WithMessage("usernameoremail shouldn't be null");
            RuleFor(l => l.Password)
                .NotEmpty()
                .WithMessage("Password shouldn't be null");
        }
    }
}
