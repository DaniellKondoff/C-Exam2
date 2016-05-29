using System;

    class Program
    {
        static void Main()
        {
            double FG=double.Parse(Console.ReadLine());
            double FGA = double.Parse(Console.ReadLine());
            double ZP = double.Parse(Console.ReadLine());
            double TOV = double.Parse(Console.ReadLine());
            double ORB = double.Parse(Console.ReadLine());
            double OppDRB = double.Parse(Console.ReadLine());
            double FT = double.Parse(Console.ReadLine());
            double FTA = double.Parse(Console.ReadLine());

            double eFG=((FG+0.5*ZP))/FGA;
            double TOVFormula = TOV / ((FGA + 0.44 * FTA +TOV));
            double ORBFormula = ORB / ((ORB + OppDRB));
            double FTFormula = FT / FGA;

            Console.WriteLine("eFG% {0:F3}",eFG);
            Console.WriteLine("TOV% {0:F3}",TOVFormula);
            Console.WriteLine("ORB% {0:F3}", ORBFormula);
            Console.WriteLine("FT% {0:F3}", FTFormula);
            
        }
    }

