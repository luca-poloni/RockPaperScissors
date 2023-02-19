using FluentValidation;
using Domain.Validations;

namespace Domain.ValueObjects
{
    public record PlayerValueObject 
    {
        public string Name { get; }
        public HandValueObject Hand { get; }

        public PlayerValueObject(string name, HandValueObject hand)
        {
            Name = name;
            Hand = hand;

            var result = PlayerValidation.Validator.Validate(this);

            if (!result.IsValid)
                throw new ValidationException(result.ToString());
        }
    }
}
