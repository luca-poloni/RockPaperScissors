using FluentValidation;
using Domain.Validations;
using Domain.Interfaces;

namespace Domain.Implementations
{
    public class Player : IPlayer
    {
        public string Name { get; }
        public IHand Hand { get; }

        public Player(string name, IHand hand)
        {
            Name = name;
            Hand = hand;

            var result = PlayerValidation.Validator.Validate(this);

            if (!result.IsValid)
                throw new ValidationException(result.ToString());
        }

        public override string ToString()
        {
            return $"Name: {Name} | Hand: {Hand.GetType().Name}";
        }
    }
}
