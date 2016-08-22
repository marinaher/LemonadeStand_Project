using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class BuyFromStore
    {
        public double costOfLemon = 0.20;
        public double costOfSugar = 0.15;
        public double costOfIce = 0.10;
        public double costOfCups = 0.50;

        public int buyLemonAmount;
        public int buySugarAmount;
        public int buyIceAmount;
        public int buyCupsAmount;

        public BuyFromStore()
        {

        }

        public void BuyIngredients(Player player, Inventory inventory)
        {
            BuyLemons(player, inventory);
            BuySugar(player, inventory);
            BuyIce(player, inventory);
            BuyCups(player, inventory);
        }
        public double BuyLemons(Player player, Inventory inventory)
        {
            Console.WriteLine("How many Lemons would you like to buy?");
            string lemonAmountInput = Console.ReadLine();
            int.TryParse(lemonAmountInput, out buyLemonAmount);
            if (player.amountOfMoney - (costOfLemon * buyLemonAmount) > costOfLemon)
            {
                inventory.inventoryLemonCount += buyLemonAmount;
                player.amountOfMoney = (player.amountOfMoney - (costOfLemon * buyLemonAmount));
                Console.WriteLine("You bought {0} Lemons.", buyLemonAmount);
            }
            else if (player.amountOfMoney < (costOfLemon * buyLemonAmount))
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
                BuyLemons(player, inventory);
            }
            for (int i = 0; i < buyLemonAmount; i++)
            {
                Lemon lemon = new Lemon(player);
                inventory.inventoryLemon.Add(lemon);
            }
            return buyLemonAmount;
        }
        public double BuySugar(Player player, Inventory inventory)
        {
            Console.WriteLine("\nHow many cups of sugar would you like to buy?");
            string sugarAmountInput = Console.ReadLine();
            int.TryParse(sugarAmountInput, out buySugarAmount);
            if (player.amountOfMoney - (costOfSugar * buySugarAmount) > costOfSugar)
            {
                inventory.inventorySugarCount += buySugarAmount;
                player.amountOfMoney = player.amountOfMoney - (costOfSugar * buySugarAmount);
                Console.WriteLine("You bought {0} cups of Sugar.", buySugarAmount);
            }
            else if (player.amountOfMoney < (costOfSugar * buySugarAmount))
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
                BuySugar(player, inventory);
            }
            for (int k = 0; k < buySugarAmount; k++)
            {
                Sugar sugar = new Sugar(player);
                inventory.inventorySugar.Add(sugar);
            }
            return buySugarAmount;
        }
        public double BuyIce(Player player, Inventory inventory)
        {
            Console.WriteLine("\nHow many cups of ice would you like to buy?");
            string iceAmountInput = Console.ReadLine();
            int.TryParse(iceAmountInput, out buyIceAmount);
            if (player.amountOfMoney - (costOfIce * buyIceAmount) > costOfIce)
            {
                inventory.inventoryIceCount += buyIceAmount;
                player.amountOfMoney = player.amountOfMoney - (costOfIce * buyIceAmount);
                Console.WriteLine("You bought {0} cups of ice.", buyIceAmount);
            }
            else if (player.amountOfMoney < (costOfIce * buyIceAmount))
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
                BuyIce(player, inventory);
            }
            for (int j = 0; j < buyIceAmount; j++)
            {
                Ice ice = new Ice(player);
                inventory.inventoryIce.Add(ice);
            }
            return buyIceAmount;
        }
        public double BuyCups(Player player, Inventory inventory)
        {
            Console.WriteLine("\nHow many cups would you like to buy?");
            string cupsAmountInput = Console.ReadLine();
            int.TryParse(cupsAmountInput, out buyCupsAmount);

            if (player.amountOfMoney - (costOfCups * buyCupsAmount) > costOfCups)
            {
                inventory.inventoryCupsCount += buyCupsAmount;
                player.amountOfMoney = player.amountOfMoney - (costOfCups * buyCupsAmount);
                Console.WriteLine("You bought {0} cups.", buyCupsAmount);
            }
            else if (player.amountOfMoney < (costOfCups * buyCupsAmount))
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
                BuyCups(player, inventory);
            }
            for (int l = 0; l < buyCupsAmount; l++)
            {
                Cups cups = new Cups(player);
                inventory.inventoryCups.Add(cups);
            }
            return buyCupsAmount;
        }
    }
}
