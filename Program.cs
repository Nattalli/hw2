using System;

namespace HW2
{
    class Converter
    {
        public double usd;
        public double eur;

        public Converter(double Usd, double Eur)
        {
            usd = Usd;
            eur = Eur;
        }

        public double FromHrToEur(double hr)
        {
            return hr / eur;
        }

        public double FromHrToUsd(double hr)
        {
            return hr / usd;
        }

        public double FromEurToHr(double hr)
        {
            return eur * hr;
        }

        public double FromUsdToHr(double hr)
        {
            return usd * hr;
        }

        public double FromEurToUsd(double hr)
        {
            return (hr * eur) / usd;
        }

        public double FromUsdToEur(double hr)
        {
            return (hr * usd) / eur;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Converter first = new Converter(28.4, 33.33);
            Console.WriteLine("Оберiть з якої будемо переводити:\n hrn, eur, usd.");
            string a = Console.ReadLine();
            Console.WriteLine("В яку конвертувати:\n hrn, eur, usd.");
            string b = Console.ReadLine();
            Console.WriteLine("Яку суму хочете конвертувати");
            double c;
            c = double.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine($"{c}{a} = {c}{a}");
            }
            if (a == "eur")
            {
                if (b == "hrn") Console.WriteLine(c + " " + a + " = " + first.FromEurToHr(c) + " " + b);
                if (b == "usd") Console.WriteLine(c + " " + a + " = " + first.FromEurToUsd(c) + " " + b); 
            }

            if (a == "hrn")
            {
                if (b == "usd") Console.WriteLine(c + " " + a + " = " + first.FromHrToUsd(c) + " " + b); 
                if (b == "eur") Console.WriteLine(c + " " + a + " = " + first.FromHrToEur(c) + " " + b); 
            }

            if (a == "usd")
            {
                if (b == "hrn") Console.WriteLine(c + " " + a + " = " + first.FromUsdToHr(c) + " " + b); 
                if (b == "eur") Console.WriteLine(c + " " + a + " = " + first.FromUsdToEur(c) + " " + b); 
            }
        }
    }
}
