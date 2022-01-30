using LifeOfFighter.Domain.Common.Interfaces;
using System;

namespace LifeOfFighter.Domain.Common
{
    public abstract class BaseEntity : IIdentityEntity, IAuditableEntity
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}