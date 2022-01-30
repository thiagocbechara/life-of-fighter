using LifeOfFighter.Domain.Entities;
using System.Threading.Tasks;

namespace LifeOfFighter.Application.Services.Interfaces
{
    public interface IPlayerFighterService
    {
        Task<PlayerFighter> Get(long id);
        Task<PlayerFighter> Update(PlayerFighter playerFighter);
        Task<PlayerFighter> TrainingStrength(PlayerFighter playerFighter);
        Task<PlayerFighter> TrainingAgility(PlayerFighter playerFighter);
        Task<PlayerFighter> TrainingConstitution(PlayerFighter playerFighter);
        Task<PlayerFighter> TrainingTechnique(PlayerFighter playerFighter);
        Task<PlayerFighter> TrainingSkill(long playerFighterId, long playerSkillId);
    }
}
