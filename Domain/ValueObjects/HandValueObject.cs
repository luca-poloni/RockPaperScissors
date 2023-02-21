using FluentValidation;
using Domain.Enums;
using Domain.Exceptions;
using Domain.Validations;

namespace Domain.ValueObjects
{
    public record HandValueObject
    {
        private static readonly Dictionary<HandTypeEnum, HandTypeEnum> _disputes = new()
        {
            { HandTypeEnum.Rock, HandTypeEnum.Scissors },
            { HandTypeEnum.Paper, HandTypeEnum.Rock },
            { HandTypeEnum.Scissors, HandTypeEnum.Paper}
        };

        public HandTypeEnum Type { get; }

        public HandValueObject(HandTypeEnum type)
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
