using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace chat_app.Models
{
    public class LoginForm
    {
        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string? Username { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

    }


    public class LoginValidator : AbstractValidator<LoginForm>
    {

        public LoginValidator()
        {

            RuleFor(user => user.Username)
                .NotEmpty().WithMessage("Username cannot be empty")
                .MaximumLength(30).WithMessage("Username cannot exceed 30 characters")
                .MinimumLength(4).WithMessage("Username must be at least 4 characters");

            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("Password cannot be empty")
                .MaximumLength(60).WithMessage("Password cannot exceed 60 characters")
                .MinimumLength(5).WithMessage("Password must be at least 5 characters");
        }


    }
}
