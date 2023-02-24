using FluentValidation;
using Domain.Interfaces;

namespace Domain.Validations
{
    public static class PlayerValidation
    {
        public static AbstractValidator<IPlayer> Validator { get; } = new InlineValidator<IPlayer>();

        static PlayerValidation()
        {
            Validator.RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is empty or contains white spaces.")
                .MinimumLength(3).WithMessage("Minimum Length for Name is 3 characters.")
                .MaximumLength(100).WithMessage("Maximum Length for Name is 100 characters.");
        }
    }
}
