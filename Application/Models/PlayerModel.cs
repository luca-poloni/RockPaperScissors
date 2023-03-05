namespace Application.Models
{
    public sealed record PlayerModel
    {
        public string Name { get; }
        public string HandName { get; }

        public PlayerModel(string name, string handName)
        {
            Name = name;
            HandName = handName;
        }
    }
}
