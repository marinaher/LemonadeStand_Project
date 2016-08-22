using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Day
    {
        public List<Customer> CustomerList = new List<Customer>();
        Random random = new Random();

        public int dayNumber;
        public double lemonadePrice;
        public double endOfDayTotal;
        public double people;
        public int pitcher;

        public Day()
        {
            dayNumber = 1;
            pitcher = 6;
        }
        public List<Customer> CreateCustomer(Weather weather)
        {
            people = weather.currentTemperature * 0.50;

            for (int i = 0; i < people; i++)
            {
                Customer customer = new Customer();

                customer.thirst = customer.GetThirst();
                customer.customerCash = customer.GetCustomerCash();

                CustomerList.Add(customer);
            }
            return CustomerList;
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
        public void CustomerTransactions(Inventory inventory, Player player)
        {
            int customerCapabilityToBuy = 0;

            foreach (Customer customer in CustomerList)
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
                    while (customerCapabilityToBuy >= pitcher)
                    {
                        endOfDayTotal = player.amountOfMoney + (lemonadePrice * pitcher);
                        customerCapabilityToBuy -= pitcher;
                        for (int i = 0; i < pitcher; i++)
                        {
                            CustomerList.RemoveAt(0);
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
                        CustomerList.RemoveAt(0);
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
