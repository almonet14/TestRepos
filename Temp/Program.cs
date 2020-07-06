using System;
using System.Collections.Generic;
using System.Linq;



namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            List<double> prices = new List<double>();
            List<double> total = new List<double>() { 0, 0, 0, 0 };
            int quantity = 0;
            int userInput = -1;
            

            products.Add("1.  Product A");
            products.Add("2.  Prodcut B");
            products.Add("3.  Product C");
            products.Add("4.  Product D");

            prices.Add(13.98);
            prices.Add(32.87);
            prices.Add(50.45);
            prices.Add(25.68);

            Console.WriteLine("Please enter the corresponding number to the product you would like to add to your cart:");
            Console.WriteLine("Enter '0' when you are finished.");
            Console.WriteLine();

            foreach (var i in products)
            {
                Console.WriteLine(i);
            }

            int productCount = products.Count;

            userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput != 0)
            {
                Console.WriteLine();
                

                //if (userInput == 0)
                //{
                //    break;
                //}

                //if (userInput > productCount || userInput < 0)
                //{
                //   Console.WriteLine("That is an unavailable product number, please try again.");
                //    continue;
                //}


                Console.WriteLine("How many would you like?");
                quantity = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        total[0] += prices.ElementAt(0) * quantity;
                        break;
                    case 2:
                        total[1] += prices.ElementAt(1) * quantity;
                        break;
                    case 3:
                        total[2] += prices.ElementAt(2) * quantity;
                        break;
                    case 4:
                        total[3] += prices.ElementAt(3) * quantity;
                        break;
                    default:
                        Console.WriteLine("That is an unavailable product number, please try again.");
                        break;
                }


            }
            

            double grandTotal = total.Sum(Convert.ToInt32);

            Console.Clear();
            Console.WriteLine($"Your total for Prodcut A is: {total.ElementAt(0)}");
            Console.WriteLine($"Your total for Prodcut B is: {total.ElementAt(1)}");
            Console.WriteLine($"Your total for Prodcut C is: {total.ElementAt(2)}");
            Console.WriteLine($"Your total for Prodcut D is: {total.ElementAt(3)}");
            Console.WriteLine($"Making your total for all products {grandTotal}");







            Console.ReadLine();
        }
    }
}
