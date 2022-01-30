using LifeOfFighter.Domain.Common;
using LifeOfFighter.Domain.Enums;

namespace LifeOfFighter.Domain.Entities
{
    public class Skill : BaseEntity
    {
        public string Name { get; set; }
        public decimal BaseDamage { get; set; }
        public SkillTypeEnum Type { get; set; }
        public SkillStyleEnum Style { get; set; }
        public MasterLevelEnum MasterLevelRequired { get; set; }
        public decimal SkillPointsToMastered { get; set; }
    }
}
