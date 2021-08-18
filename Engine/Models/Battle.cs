using System;
using Engine.EventArgs;
using Engine.Services;

namespace Engine.Models
{
    public class Battle : IDisposable
    {
        private readonly MessageBroker _messageBroker = MessageBroker.GetInstance();
        private readonly Player _player;
        private readonly Monster _opponent;

        private enum Combatant
        {
            Player,
            Opponent
        }

        private static Combatant FirstAttacker =>
            RandomNumberGenerator.NumberBetween(1, 2) == 1 ? Combatant.Player : Combatant.Opponent;

        private event EventHandler<CombatVictoryEventArgs> OnCombatVictory;

        public Battle(Player player, Monster opponent)
        {

        }
    }
}
