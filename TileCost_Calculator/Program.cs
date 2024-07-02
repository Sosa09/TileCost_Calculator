using System.Formats.Asn1;

namespace TileCost_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float totalCostFlooring = 0;
            float area = 0;
            string shape = "";

            Console.WriteLine("Hello, welcome to tile cost calculator: \nlet's start !");
            while (true)
            {
                Console.WriteLine("Select the shape you want to calculate the total cost of: ");

                Console.WriteLine("1: Rectangle \n2: Circle \n3: Polygon \n4: Triangle \n\n\n");
                char choice = Console.ReadKey().KeyChar;
                Console.Clear();
                Console.WriteLine("\nEnter the cost per one unit of flooring");
                float costPerUnit = Convert.ToInt32(Console.ReadLine());
                float ratePerHour = Convert.ToInt32(Console.ReadLine());
                int estiatedWorkingHours = Convert.ToInt32(Console.ReadLine());
                if (choice == '1')
                {
                    // A = w * l
                    Console.WriteLine("Enter the width: ");
                    float width = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the height: ");
                    float height = Convert.ToInt32(Console.ReadLine()); ;


                    area = width * height;
                    totalCostFlooring = area * costPerUnit;
                    shape = "rectangle";

                }
                else if (choice == '2')
                {
                    //A = pi * R2
                 
                    double radius = Convert.ToInt32(Console.ReadLine());
                    area = (float)(3.14 * Math.Pow(radius, 2.0)); //casting double to float


                    totalCostFlooring = area * costPerUnit;
                    shape = "Circle";
                }
                else if (choice == '3')
                {
                    //A = 1/2 * p * apothem
                    Console.WriteLine("Enter the perimeter: ");
                    float perimeter = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the apothem: ");
                    float apothem = Convert.ToInt32(Console.ReadLine()); ;


                    area = 1 / 2 * perimeter * apothem;
                    totalCostFlooring = area * costPerUnit;
                    shape = "Polygon";
                }
                else if (choice == '4')
                {
                    //A = Hb * b / 2
                    Console.WriteLine("Enter the base: ");
                    float baseOfATriangle = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the height: ");
                    float heightOfATriangle = Convert.ToInt32(Console.ReadLine()); ;


                    area = heightOfATriangle * baseOfATriangle / 2;
                    totalCostFlooring = area * costPerUnit;
                    shape = "Triangle";
                }
                else
                {
                    //ADDED Difficulty notify the user that the given shape is not supported
                    Console.WriteLine("\nShape not supported try again !");
                    return; //restart the loop
                }

                Console.WriteLine($"\nThe total cost for flooring an {shape} shaped area of {area} is {totalCostFlooring}");
                Console.ReadKey(); //wait for user interaction to continue
                Console.Clear();
            }

        }

    }
}