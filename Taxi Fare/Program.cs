using System;

namespace Taxi_Fare
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            int startCost = 3;
            try
            {

            
                Console.Write("Enter the the distance of the journey: ");
                int distance = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number of passengers: ");
                int passengers = Convert.ToInt32(Console.ReadLine());

                if (distance > 1) 
                {
                    distance = distance - 1;
                }
            

                double cost = distance * 2;
                cost = cost + startCost;
                
                if (passengers >= 5)
                {
                    cost = cost * 1.5;
                }
                Console.WriteLine("The final cost is "+ cost);
                
            }

            catch (Exception e)
            {
                Console.WriteLine("This is not a valid input");
            }

            }
        }
    }
}
