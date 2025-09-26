using System;

namespace ElectricityBillCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input: Customer details
            Console.Write("Enter Customer ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            double units = Convert.ToDouble(Console.ReadLine());

            double chargePerUnit = 0;

           
            if (units <= 199)
                chargePerUnit = 1.20;
            else if (units >= 200 && units < 400)
                chargePerUnit = 1.50;
            else if (units >= 400 && units < 600)
                chargePerUnit = 1.80;
            else
                chargePerUnit = 2.00;

       
            double totalAmount = units * chargePerUnit;

        
            Console.WriteLine("\n--- Electricity Bill ---");
            Console.WriteLine($"Customer ID   : {customerId}");
            Console.WriteLine($"Customer Name : {customerName}");
            Console.WriteLine($"Units Consumed: {units}");
            Console.WriteLine($"Charge/Unit   : {chargePerUnit}");
            Console.WriteLine($"Total Amount  : {totalAmount}");
        }
    }
}
