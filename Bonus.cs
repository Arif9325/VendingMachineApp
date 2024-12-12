using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIIIProject
{
    internal class Bonus
    {
        public class VendingMachine
        {
            //data members
            private int month;
            private double revenue;

            //constructor
            public VendingMachine(int month, double revenue)
            {
                Month = month;
                Revenue = revenue;
            }

            //properties
            public int Month 
            { 
                get { return month; }
                set { month = value; }
            }
            public double Revenue
            {
                get { return revenue; }
                set { revenue = value; }
            }
        }

        public static void Run()
        {
            //create list to hold values
            List<VendingMachine> vendingMachineData = GenerateMonthlyRevenues();
            //holds highest monthly revenue
            double highestRevenue = FindHighestRevenue(vendingMachineData);

            Console.WriteLine("Monthly Revenues for the Vending Machine:");
            //display all revenues per month
            foreach (var period in vendingMachineData)
            {
                Console.WriteLine($"Month {period.Month}: ${period.Revenue}");
            }
            //display answer
            Console.WriteLine($"\nHighest Monthly Revenue: ${highestRevenue}");
        }

        private static List<VendingMachine> GenerateMonthlyRevenues()
        {
            //create list to hold values
            List<VendingMachine> vendingMachineData = new List<VendingMachine>();
            //to generate at random numbers
            Random random = new Random();
            //loop through each month to get a value
            for (int month = 1; month <= 12; month++)
            {
                //random revenue between 0 and 1000
                double revenue = random.NextDouble() * 1000;
                vendingMachineData.Add(new VendingMachine(month, revenue));
            }

            return vendingMachineData;
        }

        private static double FindHighestRevenue(List<VendingMachine> vendingMachineData)
        {
            double highestRevenue = 0;
            //determines which revenue out of the 12 is the greatest
            foreach (var item in vendingMachineData)
            {
                if (item.Revenue > highestRevenue)
                {
                    highestRevenue = item.Revenue;
                }
            }

            return highestRevenue;
        }

    }
}
