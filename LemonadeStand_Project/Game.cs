using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Game
    {
        Player player = new Player();
        Inventory inventory = new Inventory();
        Weather weather = new Weather();
        Recipe recipe = new Recipe();
        Day day = new Day();
        BuyFromStore buyFromStore = new BuyFromStore();
        Customer customer;

        public int dayNumber = 1;

        public Game()
        {
            Console.WriteLine("Before we play, what is your name?");
            player.name = Console.ReadLine();
            Console.WriteLine("\nHi, It's nice to meet you {0}!", player.getName());
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Welcome to Lemoneeville Valley where the best lemons are grown!");

            Console.WriteLine("\nRules here are simple: ");
            Console.WriteLine("\n* Make as much money as you can in seven days. \n* Make sure to buy your products daily, if not, they may spoil and you'll have unhappy customers! \n* Keep an eye on the forecast and plan accordingly.");
            Console.WriteLine("\nBest of Luck! Show the world that we really do grow the best lemons. \n\nIf not, I may kick you out of town...kidding......or am I?");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            recipe.RecipeInfo();
        }
        public void StartGame()
        {
            string condition = weather.CurrentWeatherCondition();
            int degrees = weather.currentTemperature;

            Console.WriteLine("DAY {0} of 7.", dayNumber);
            Console.WriteLine("\nWeather condition: {0}. \tToday's temperature is: {1} degrees.", condition, degrees);
            Console.WriteLine("___________________________________________________________________________");

            Console.WriteLine("This is your current inventory: ");
            Console.WriteLine("\nLemons:\t{0} \tSugar:\t{1} \nIce: \t{2} \tCups: \t{3}", inventory.inventoryLemonCount, inventory.inventorySugarCount, inventory.inventoryIceCount, inventory.inventoryCupsCount);

            Console.WriteLine("\nLet's go purchase some ingredients for your Lemonade.");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            buyFromStore.BuyIngredients(player, inventory);

            Console.WriteLine("\nPress Enter to continue..");
            Console.ReadLine();
            Console.Clear();

            day.StartDay();
            day.CustomerTransactions(inventory, player, customer);
        }
    }
}
