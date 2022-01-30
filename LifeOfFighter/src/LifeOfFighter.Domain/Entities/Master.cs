using LifeOfFighter.Domain.Common;
using LifeOfFighter.Domain.Enums;

namespace LifeOfFighter.Domain.Entities
{
    public class Master : BaseEntity
    {
        public string Name { get; set; }
        public MasterLevelEnum Level { get; set; }
        public RegionLevelEnum RegionLevel { get; set; }
    }
}
