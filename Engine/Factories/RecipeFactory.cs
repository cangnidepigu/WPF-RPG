using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class RecipeFactory
    {
        private static readonly List<Recipe> _recipes = new List<Recipe>();

        static RecipeFactory()
        {
            Recipe granolaBar = new Recipe(1, "Granola bar");
            granolaBar.AddIngredient(3001, 1);
            granolaBar.AddIngredient(3002, 1);
            granolaBar.AddIngredient(3003, 1);
            granolaBar.AddOutputItem(2001, 1);

            _recipes.Add(granolaBar);

            Recipe monsterEnergyDrink = new Recipe(2, "Monster Energy Drink");
            monsterEnergyDrink.AddIngredient(3005, 2);
            monsterEnergyDrink.AddIngredient(3004, 1);
            monsterEnergyDrink.AddIngredient(3002, 1);
            monsterEnergyDrink.AddOutputItem(2002, 1);

            _recipes.Add(monsterEnergyDrink);
        }

        public static Recipe RecipeByID(int id)
        {
            return _recipes.FirstOrDefault(x => x.ID == id);
        }
    }
}
