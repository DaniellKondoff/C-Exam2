using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n;
            int height = 3 * n;
            int widhtTop = n + 1;
            int topHight = n;
            int space = (width - widhtTop) / 2;
            int topDigit = ((n / 2) + 1);

            Console.Write(new string(' ', space));
            Console.Write(new string('*',widhtTop));
            Console.Write(new string(' ', space));
            Console.WriteLine();
            
            //tophalf
            for (int i = 0; i < topDigit; i++)
            {
                Console.Write(new string(' ', space));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', n-1));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', space));
                Console.WriteLine();
            }

            space -= 1;
            
            for (int i = 0; i < (n-1)-topDigit; i++)
            {
                Console.Write(new string(' ', space));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', widhtTop));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', space));
                widhtTop+=2;
                space--;
                Console.WriteLine();
            }

            //MiddleHalf
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', 1));
                Console.Write(new string('.', width - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine();
            }
            
            //BottomHalf
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', 1));
                Console.Write(new string('@', width - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine();
            }

            Console.Write(new string('*', width));


            Console.WriteLine();
            
        }
    }

