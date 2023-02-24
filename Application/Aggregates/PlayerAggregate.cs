using System.ComponentModel.DataAnnotations;

namespace Application.Aggregates
{
    public class PlayerAggregate
    {
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; }

        [Required]
        [MinLength(4)]
        [MaxLength(8)]
        public string HandName { get; }

        public PlayerAggregate(string name, string handName)
        {
            Name = name;
            HandName = handName;
        }
    }
}
