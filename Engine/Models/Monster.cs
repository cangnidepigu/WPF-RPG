﻿using System;
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
            private set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }

        public int RewardExperiencePoints { get; private set; }
        public int RewardGold { get; set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; }


        public Monster(string name, string imageName,
            int maximuHitPoints, int hitPoints,
            int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = string.Format("pack://application:,,,/Engine;component/Images/Monsters/{0}");
            MaximumPoints = maximuHitPoints;
            HitPoints = hitPoints;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            Inventory = new ObservableCollection<ItemQuantity>();
        }

    }
}
