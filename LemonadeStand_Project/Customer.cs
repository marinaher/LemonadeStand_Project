using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Customer
    {
        Random random = new Random();

        public List<Customer> CustomerList = new List<Customer>();

        public int thirst;
        public double customerCash;
        public int pitcher = 6;
        public double people;

        public Customer()
        {
            thirst = 0;
            customerCash = 0;
        }
        public List<Customer> CreateCustomer(Weather weather)
        {
            people = weather.currentTemperature * 0.50;

            for (int i = 0; i < people; i++)
            {
                Customer customer = new Customer();

                customer.thirst = GetThirst();
                customer.customerCash = GetCustomerCash();

                CustomerList.Add(customer);
            }
            return CustomerList;
        }
        public int GetThirst()
        {
            int thirstiness = 0;
            thirstiness = random.Next(0, 4);
            return thirstiness;
        }
        public double GetCustomerCash()
        {
            double cash = 0;
            cash = random.Next(1, 15);
            return cash * .10;
        }
    }
}
