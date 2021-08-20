using System.Linq;
using Engine.Services;
using Engine.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EngineTests.Services
{
    [TestClass]
    public class TestSaveGameService
    {
        [TestMethod]
        public void Test_Restore_0_1_000()
        {
            GameSession gameSession =
                SaveGameService
                    .LoadLastSaveOrCreateNew(@".\TestFiles\SavedGames\Game_0_1_000.soscsrpg");

            // Game session data
            Assert.AreEqual("0.1.000", gameSession.Version);
            Assert.AreEqual(2, gameSession.CurrentLocation.XCoordinate);
            Assert.AreEqual(0, gameSession.CurrentLocation.YCoordinate);

            // Player data
            Assert.AreEqual("Game Master", gameSession.CurrentPlayer.CharacterClass);
            Assert.AreEqual("Joe", gameSession.CurrentPlayer.Name);
            Assert.AreEqual(14, gameSession.CurrentPlayer.Dexterity);
            Assert.AreEqual(26, gameSession.CurrentPlayer.CurrentHitPoints);
            Assert.AreEqual(30, gameSession.CurrentPlayer.MaximumHitPoints);
            Assert.AreEqual(290, gameSession.CurrentPlayer.ExperiencePoints);
            Assert.AreEqual(3, gameSession.CurrentPlayer.Level);
            Assert.AreEqual(193, gameSession.CurrentPlayer.Gold);

            // Player quest data
            Assert.AreEqual(1, gameSession.CurrentPlayer.Quests.Count);
            Assert.AreEqual(1, gameSession.CurrentPlayer.Quests[0].PlayerQuest.ID);
            Assert.IsTrue(gameSession.CurrentPlayer.Quests[0].IsCompleted);

            // Player recipe data
            Assert.AreEqual(2, gameSession.CurrentPlayer.Recipes.Count);
            Assert.AreEqual(1, gameSession.CurrentPlayer.Recipes[0].ID);

            // Player inventory data
            Assert.AreEqual(49, gameSession.CurrentPlayer.Inventory.Items.Count);
            Assert.AreEqual(1, gameSession.CurrentPlayer.Inventory.Items.Count(i => i.ItemTypeID.Equals(1003)));
            Assert.AreEqual(1, gameSession.CurrentPlayer.Inventory.Items.Count(i => i.ItemTypeID.Equals(1002)));
            Assert.AreEqual(16, gameSession.CurrentPlayer.Inventory.Items.Count(i => i.ItemTypeID.Equals(9002)));
            Assert.AreEqual(1, gameSession.CurrentPlayer.Inventory.Items.Count(i => i.ItemTypeID.Equals(3001)));
            Assert.AreEqual(4, gameSession.CurrentPlayer.Inventory.Items.Count(i => i.ItemTypeID.Equals(9001)));
        }
    }
}
