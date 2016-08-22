using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Day
    {
        public int dayNumber;
        public double lemonadePrice;
        public double endOfDayTotal;

        public Day()
        {
            dayNumber = 1;
        }
        public void StartDay()
        {
            Console.WriteLine("It's time to sell some Lemonade!");
            Console.WriteLine("\nHow much would you like to charge per cup of Lemonade?");
            string input = Console.ReadLine();
            if (input != null)
            {
                lemonadePrice = double.Parse(input);
            }
            else
            {
                StartDay();
            }
            Console.WriteLine("Got it. Each cup of Lemonade cost ${0}.", lemonadePrice);
        }
        public void CustomerTransactions(Inventory inventory, Player player, Customer customer)
        {
            int customerCapabilityToBuy = 0;

            foreach (Customer person in customer.CustomerList)
            {
                if (customer.customerCash >= lemonadePrice && customer.thirst > 1)
                {
                    customerCapabilityToBuy++;
                }
            }

            if (customerCapabilityToBuy == 0)
            {
                Console.WriteLine("Sorry, no more customers want to buy your Lemonade. Go home.");
            }
            else if (customerCapabilityToBuy != 0)
            {
                if (inventory.inventoryLemonCount >= 1 && inventory.inventorySugarCount >= 1 && inventory.inventoryIceCount >= 3 && inventory.inventoryCupsCount >= 6)
                {
                    inventory.UpdateInventory();
                    while (customerCapabilityToBuy >= customer.pitcher)
                    {
                        endOfDayTotal = player.amountOfMoney + (lemonadePrice * customer.pitcher);
                        customerCapabilityToBuy -= customer.pitcher;
                        for (int i = 0; i < customer.pitcher; i++)
                        {
                            customer.CustomerList.RemoveAt(0);
                        }
                        if (inventory.inventoryLemonCount >= 1 && inventory.inventorySugarCount >= 1 && inventory.inventoryIceCount >= 3 && inventory.inventoryCupsCount >= 6)
                        {
                            inventory.UpdateInventory();
                        }
                        else
                        {
                            customerCapabilityToBuy = 0;
                        }
                    }
                    player.amountOfMoney += (lemonadePrice * customerCapabilityToBuy);
                    for (int i = 0; i < customerCapabilityToBuy; i++)
                    {
                        customer.CustomerList.RemoveAt(0);
                    }
                    Console.WriteLine("Total amount in your wallet at the end of today is ${0}.", endOfDayTotal);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Not enough Materials to make Lemonade.");
                    Console.ReadLine();
                    //go back to buy ingredients
                }
            }
        }
    }
}
