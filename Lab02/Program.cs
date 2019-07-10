using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isUsing = false;

            do
            {
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

                Console.Write("Enter length: ");
                double roomLength = Double.Parse(Console.ReadLine());

                Console.Write("Enter width: ");
                double roomWidth = Double.Parse(Console.ReadLine());

                Console.Write("Enter height: ");
                double roomHeight = Double.Parse(Console.ReadLine());

                Console.WriteLine("Area: " + (roomLength * roomWidth));
                Console.WriteLine("Perimeter: " + ((roomLength * 2) + (roomWidth * 2)));
                Console.WriteLine("Volume: " + (roomLength * roomWidth * roomHeight) + "\n");

                Console.Write("Continue? (y/n)");
                string strContinue = Console.ReadLine();

                if (strContinue == "y")
                {
                    isUsing = true;
                }
                else
                {
                    isUsing = false;
                }

            } while (isUsing == true);
        }
    }
}
