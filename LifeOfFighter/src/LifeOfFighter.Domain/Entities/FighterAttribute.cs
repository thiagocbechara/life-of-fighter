using LifeOfFighter.Domain.Common;
using LifeOfFighter.Domain.Enums;

namespace LifeOfFighter.Domain.Entities
{
    public class FighterAttribute : BaseEntity
    {
        public int Level { get; set; }
        public decimal Experience { get; set; }
        public decimal ExperienceNextLevel => 0.25M*(Level^3)+4M*Level;
        public AttributeTypeEnum Type { get; set; }
    }
}
