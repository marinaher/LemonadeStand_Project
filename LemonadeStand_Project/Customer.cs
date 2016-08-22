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

        public int thirst;
        public double customerCash;
        
        

        public Customer()
        {
            thirst = 0;
            customerCash = 0;
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
