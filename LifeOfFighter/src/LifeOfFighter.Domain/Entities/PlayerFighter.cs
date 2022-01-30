using LifeOfFighter.Domain.Common;

namespace LifeOfFighter.Domain.Entities
{
    public class PlayerFighter : BaseEntity
    {
        public Fighter Fighter { get; set; }
    }
}
