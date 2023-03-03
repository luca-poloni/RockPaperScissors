using Domain.Exceptions;
using Domain.Interfaces;
using Domain.Implementations;

namespace Domain.Factories
{
    public static class HandFactory
    {
        public static IHand Create(string name)
        {
            switch (name.ToUpper())
            {
                case "ROCK":
                    return new RockUseCase();
                case "PAPER":
                    return new PaperUseCase();
                case "SCISSORS":
                    return new ScissorsUseCase();
                default:
                    throw new InvalidHandException();
            }
        }
    }
}
