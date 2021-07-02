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
                "pack://application:,,,/Engine;component/Images/Locations/FarmFields.png");

            newWorld.LocationAt(-2, -1).AddMonster(2, 100);

            newWorld.AddLocation(-1, -1, "Farmer's House",
                "This is the house of your mate Deez.",
                "pack://application:,,,/Engine;component/Images/Locations/Farmhouse.png");

            newWorld.AddLocation(0, -1, "Home", 
                "This is your home", 
                "pack://application:,,,/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(-1, 0, "Trading Shop",
                "Susan's shop. Who know what you gon' find there bud.",
                "pack://application:,,,/Engine;component/Images/Locations/Trader.png");

            newWorld.AddLocation(0, 0, "Town square",
                "You see a fountain here.",
                "pack://application:,,,/Engine;component/Images/Locations/TownSquare.png");

            newWorld.AddLocation(1, 0, "Town Gate",
                "There is a gate here with a warning on top: BIG CHUNGUS AHEAD.",
                "pack://application:,,,/Engine;component/Images/Locations/TownGate.png");

            newWorld.AddLocation(2, 0, "Spider Forest",
                "The trees in this forest are covered in sticky white thing.",
                "pack://application:,,,/Engine;component/Images/Locations/SpiderForest.png");

            newWorld.LocationAt(2, 0).AddMonster(3, 100);

            newWorld.AddLocation(3, 0, "The Pit",
                "Kitava-type boss fight",
                "pack://application:,,,/Engine;component/Images/Locations/Syziph.png");

            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with funni smoke coming out of the chimney.",
                "pack://application:,,,/Engine;component/Images/Locations/HerbalistsHut.png");

            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, snek might come an' bite ya'.",
                "pack://application:,,,/Engine;component/Images/Locations/HerbalistsGarden.png");

            newWorld.LocationAt(0, 2).AddMonster(1, 100);


            return newWorld;
        }
    }
}
