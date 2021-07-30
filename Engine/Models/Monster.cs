using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get; }
        public int RewardExperiencePoints { get; }

        public Monster(string name, string imageName,
            int maximuHitPoints, int currentHitPoints,
            int rewardExperiencePoints, int gold) :
            base(name, maximuHitPoints, currentHitPoints, gold)
        {
            ImageName = $"pack://application:,,,/Engine;component/Images/Monsters/{imageName}";
            RewardExperiencePoints = rewardExperiencePoints;
        }

    }
}
