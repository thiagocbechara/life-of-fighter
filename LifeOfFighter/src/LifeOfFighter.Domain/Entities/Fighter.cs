using LifeOfFighter.Domain.Common;
using System.Collections.Generic;

namespace LifeOfFighter.Domain.Entities
{
    public class Fighter : BaseEntity
    {
        public string Name { get; set; }
        public FighterAttribute Strength { get; set; }
        public FighterAttribute Agility { get; set; }
        public FighterAttribute Constitution { get; set; }
        public FighterAttribute Technique { get; set; }
        public IEnumerable<SkillFighter> Skills { get; set; }
    }
}
