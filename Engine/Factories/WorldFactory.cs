using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "Big corns with BIG RATS, WATCH OUT",
                "FarmFields.png");

            newWorld.LocationAt(-2, -1).AddMonster(2, 100);

            newWorld.AddLocation(-1, -1, "Farmer's House",
                "This is the house of your mate Deez.",
                "Farmhouse.png");

            newWorld.AddLocation(0, -1, "Home", 
                "This is your home", 
                "Home.png");

            newWorld.AddLocation(-1, 0, "Trading Shop",
                "Susan's shop. Who know what you gon' find there bud.",
                "Trader.png");

            newWorld.AddLocation(0, 0, "Town square",
                "You see a fountain here.",
                "TownSquare.png");

            newWorld.AddLocation(1, 0, "Town Gate",
                "There is a gate here with a warning on top: BIG CHUNGUS AHEAD.",
                "TownGate.png");

            newWorld.AddLocation(2, 0, "Spider Forest",
                "The trees in this forest are covered in sticky white thing.",
                "SpiderForest.png");

            newWorld.LocationAt(2, 0).AddMonster(3, 100);

            newWorld.AddLocation(3, 0, "The Pit",
                "Kitava-type boss fight",
                "Syziph.png");

            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with funni smoke coming out of the chimney.",
                "HerbalistsHut.png");

            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, snek might come an' bite ya'.",
                "HerbalistsGarden.png");

            newWorld.LocationAt(0, 2).AddMonster(1, 100);


            return newWorld;
        }
    }
}
