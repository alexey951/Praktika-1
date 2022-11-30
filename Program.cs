using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dixitomi());
            Console.WriteLine(GoldenSec());
        }
        static public double Function(double x)
        {
            return (Math.Log(2 * x) * x) + (20 * Math.Sin(x / 0.5)) - 3;
        }
        static public double Dixitomi()
        {
            Console.WriteLine("Метод дихитомии");
            double a = 1;
            double b = 7;
            int n = 10; // число итераций
            double x1 = 0;
            double x2 = 0;
            double accuracy = 0.001;
            bool IsX1Funct = true;
            for (int i = 0; i <= n; i++)
            {
                double medium = (a + b) / 2;
                x1 = medium - accuracy;
                x2 = medium + accuracy;
                if (Function(x1) >= Function(x2))
                {
                    a = x1;
                    b = medium;
                }
                else
                {
                    b = x2;
                    a = medium;
                    IsX1Funct = false;
                }
            }
            if (IsX1Funct == true)
                return Function(x1);
            else
                return Function(x2);
        }
        static public double GoldenSec()
        {
            Console.WriteLine("Метод золотого сечения");
            double a = 1;
            double b = 7;
            int n = 10; // число итераций
            double x1 = 0;
            double x2 = 0;
            bool IsX1Funct = true;
            for (int i = 0; i <= n; i++)
            {
                x1 = b - (b - a) / 1.618;
                x2 = a + (b - a) / 1.618;
                if (Function(x1) >= Function(x2))
                {
                    a = x1;
                }
                else
                {
                    b = x2;
                    IsX1Funct = false;

                }
            }
            if (IsX1Funct == true)
                return Function(x1) - (a + b) / 2;
            else
                return Function(x2) - (a + b) / 2;
        }
    }
}
