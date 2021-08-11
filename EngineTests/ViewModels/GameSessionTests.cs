using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels.Tests
{
    [TestClass]
    public class GameSessionTests
    {
        [TestMethod]
        public void TestCreateGameSession()
        {
            GameSession gameSession = new GameSession();

            Assert.IsNotNull(gameSession.CurrentPlayer);
            Assert.AreEqual("Town Square", gameSession.CurrentLocation.Name);
        }

        [TestMethod]
        public void TestPlayerMovesHomeAndIsCompletelyHealedOnKilled()
        {
            GameSession gameSession = new GameSession();

            gameSession.CurrentPlayer.TakeDamage(9999);

            Assert.AreEqual("Home", gameSession.CurrentLocation.Name);
            Assert.AreEqual(gameSession.CurrentPlayer.Level * 10, gameSession.CurrentPlayer.CurrentHitPoints);
        }
    }
}