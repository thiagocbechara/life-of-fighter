using LifeOfFighter.Domain.Common;

namespace LifeOfFighter.Domain.Entities
{
    public class SkillFighter: BaseEntity
    {
        public Skill Skill { get; set; }
        public decimal CurrentSkillPoints { get; set; }
        public decimal CurrentSkillPercent => CurrentSkillPoints / Skill.SkillPointsToMastered;
        public bool IsMastered => CurrentSkillPoints >= Skill.SkillPointsToMastered;
        public bool IsEnabledToUse => CurrentSkillPoints > 0;
    }
}
