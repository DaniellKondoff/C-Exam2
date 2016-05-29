using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Wiggle
    {
        static void Main()
        {
            long n = 36854775807;
            long r = 2285477580;
            int p = 0;

            for (int i = 0; i <=64; i++)
          {
            int c = 1;
            int mask = c << p;
            long reslt = mask & n;
            long result = mask & r;
            //Console.WriteLine(reslt);
            bool isTrue = (reslt != 0);
            bool isTruee = (reslt != 0);

            Console.WriteLine(isTrue);
            Console.WriteLine(isTruee);
            p++;
          }
           
        }
    }

