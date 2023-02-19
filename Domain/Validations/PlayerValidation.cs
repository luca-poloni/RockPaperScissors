using FluentValidation;
using Domain.ValueObjects;

namespace Domain.Validations
{
    public static class PlayerValidation
    {
        public static AbstractValidator<PlayerValueObject> Validator { get; } = new InlineValidator<PlayerValueObject>();

        static PlayerValidation()
        {
            Validator.RuleFor(x => x.Name).NotEmpty().WithMessage("Name is empty or contains white spaces.");
        }
    }
}
