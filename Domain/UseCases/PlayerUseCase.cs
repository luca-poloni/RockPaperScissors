using FluentValidation;
using Domain.Interfaces;

namespace Domain.Implementations
{
    public sealed class PlayerUseCase : IPlayer
    {
        public string Name { get; }
        public IHand Hand { get; }

        public PlayerUseCase(string name, IHand hand)
        {
            Name = name;
            Hand = hand;

            var result = PlayerValidation.Validator.Validate(this);

            if (!result.IsValid)
                throw new ValidationException(result.ToString());
        }

        public override string ToString()
        {
            return $"Name: {Name} | Hand: {Hand.Name}";
        }

        private static class PlayerValidation
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
}
