using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using FluentValidation;



namespace chat_app.Models
{
    public class RegisterForm
    {



        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string? Username { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public string? VerifyPassword { get; set; }


    }

    public class RegisterValidator: AbstractValidator<RegisterForm> 
    {

        private IDbContextFactory<chat_app.Data.chat_appContext> _dbFactory;

        public RegisterValidator(IDbContextFactory<chat_app.Data.chat_appContext> dbFactory)
        {
            _dbFactory = dbFactory;

            RuleFor(user => user.Username)
                .NotEmpty().WithMessage("Username cannot be empty")
                .MaximumLength(30).WithMessage("Username cannot exceed 30 characters")
                .MinimumLength(4).WithMessage("Username must be at least 4 characters")
                .MustAsync(async (username, cancellation) =>
                    {
                        using var context = _dbFactory.CreateDbContext();
                        User? user = await context.User.FirstOrDefaultAsync(m => m.Username == username);
                        return( user == null);
                    }
                ).WithMessage("Username is already in use");

            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("Password cannot be empty")
                .MaximumLength(60).WithMessage("Password cannot exceed 60 characters")
                .MinimumLength(5).WithMessage("Password must be at least 5 characters");

            RuleFor(user => user.VerifyPassword)
                .NotEmpty().WithMessage("Password cannot be empty")
                .MaximumLength(60).WithMessage("Password cannot exceed 60 characters")
                .MinimumLength(5).WithMessage("Password must be at least 5 characters")
                .Equal(user => user.Password).WithMessage("Passwords must match");
        }
    
    
    }




}
