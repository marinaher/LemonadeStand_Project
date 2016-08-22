using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Recipe
    {
        public Recipe()
        {

        }
        public void RecipeInfo()
        {
            Console.WriteLine("To make the perfect Lemoneeville Valley Lemonade, I've created a recipe for you.");
            Console.WriteLine("\nOne pitcher (which holds 6 cups of delicious lemonade), you'll need: \n* 1 Lemons \n* 1 cups of sugar \n* 3 cups of ice \n* 6 cups.");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
