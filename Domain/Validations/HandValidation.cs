using FluentValidation;
using Domain.ValueObjects;

namespace Domain.Validations
{
    public static class HandValidation
    {
        public static AbstractValidator<HandValueObject> Validator { get; } = new InlineValidator<HandValueObject>();

        static HandValidation()
        {
            Validator.RuleFor(x => x.Type).IsInEnum().WithMessage("Hand Enum is outside the possible range of values.");
        }
    }
}