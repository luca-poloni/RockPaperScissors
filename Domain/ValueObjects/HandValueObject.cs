using FluentValidation;
using Domain.Enums;
using Domain.Exceptions;
using Domain.Validations;

namespace Domain.ValueObjects
{
    public record HandValueObject
    {
        private static readonly Dictionary<HandEnum, HandEnum> _disputes = new()
        {
            { HandEnum.Rock, HandEnum.Scissors },
            { HandEnum.Paper, HandEnum.Rock },
            { HandEnum.Scissors, HandEnum.Paper}
        };

        public HandEnum Type { get; }

        public HandValueObject(HandEnum type)
        {
            Type = type;

            var result = HandValidation.Validator.Validate(this);

            if (!result.IsValid)
                throw new ValidationException(result.ToString());
        }

        public bool Wins(HandValueObject otherHand)
        {
            if (Equals(otherHand))
                throw new EqualsHandsException();

            return _disputes.GetValueOrDefault(Type) == otherHand.Type;
        }
    }
}
