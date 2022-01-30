using LifeOfFighter.Application.Repositories;
using LifeOfFighter.Application.Services.Interfaces;
using LifeOfFighter.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace LifeOfFighter.Application.Services
{
    public class PlayerFighterService : IPlayerFighterService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlayerFighterService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PlayerFighter> Get(long id) =>
            await _unitOfWork.PlayerFighter.GetAsync(x => x.Id == id);

        public Task<PlayerFighter> TrainingSkill(long playerFighterId, long playerSkillId)
        {
            throw new NotImplementedException();
        }

        public async Task<PlayerFighter> TrainingAgility(PlayerFighter playerFighter)
        {
            TrainingAttribute(playerFighter.Fighter.Agility);
            _unitOfWork.PlayerFighter.Update(playerFighter);
            await _unitOfWork.CommitAsync();
            return await Get(playerFighter.Id);
        }

        public async Task<PlayerFighter> TrainingConstitution(PlayerFighter playerFighter)
        {
            TrainingAttribute(playerFighter.Fighter.Constitution);
            _unitOfWork.PlayerFighter.Update(playerFighter);
            await _unitOfWork.CommitAsync();
            return await Get(playerFighter.Id);
        }

        public async Task <PlayerFighter> TrainingStrength(PlayerFighter playerFighter)
        {
            TrainingAttribute(playerFighter.Fighter.Strength);
            _unitOfWork.PlayerFighter.Update(playerFighter);
            await _unitOfWork.CommitAsync();
            return await Get(playerFighter.Id);
        }

        public async Task<PlayerFighter> TrainingTechnique(PlayerFighter playerFighter)
        {
            TrainingAttribute(playerFighter.Fighter.Technique);
            _unitOfWork.PlayerFighter.Update(playerFighter);
            await _unitOfWork.CommitAsync();
            return await Get(playerFighter.Id);
        }

        public static void TrainingAttribute(FighterAttribute attribute)
        {
            attribute.Experience += 20;
            if(attribute.Experience >= attribute.ExperienceNextLevel)
            {
                attribute.Experience = 0;
                attribute.Level++;
            }
        }

        public async Task<PlayerFighter> Update(PlayerFighter playerFighter)
        {
            _unitOfWork.PlayerFighter.Update(playerFighter);
            await _unitOfWork.CommitAsync();
            return await Get(playerFighter.Id);
        }
    }
}
