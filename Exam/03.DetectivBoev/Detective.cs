using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Detective
    {
        static void Main()
        {
            string secret = Console.ReadLine();
            string message = Console.ReadLine();
            int sum = 0 ;
            

           

            foreach (char item in secret)
            {
                Console.WriteLine((int)item);
                sum +=item;
            }
            string result = sum.ToString();
            Console.WriteLine(result);

            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
                
            //}
           
           

            


        }
    }

