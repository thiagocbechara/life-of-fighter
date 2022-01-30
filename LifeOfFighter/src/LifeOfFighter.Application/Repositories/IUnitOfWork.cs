using LifeOfFighter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeOfFighter.Application.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<PlayerFighter> PlayerFighter { get; }
        IRepository<SkillFighter> SkillFighter { get; }

        Task CommitAsync();
    }
}
