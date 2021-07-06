using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : BaseNotificationClass
    {
        private int _hitPoints;

        public string Name { get; set; }
        public string ImageName { get; set; }
        public int MaximumPoints { get; private set; }
        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public int RewardExperiencePoints { get; private set; }
        public int RewardGold { get; set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; }


        public Monster(string name, string imageName,
            int maximuHitPoints, int hitPoints,
            int minimumDamage, int maximumDamage,
            int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = $"pack://application:,,,/Engine;component/Images/Monsters/{imageName}";
            MaximumPoints = maximuHitPoints;
            HitPoints = hitPoints;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            Inventory = new ObservableCollection<ItemQuantity>();
        }

    }
}
