﻿using System.Formats.Asn1;

namespace TileCost_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float totalCostFlooring;
            float area ;
            const float PI = 3.14F;
            string selectedShape;

            const string RECTANGLE = "Rectangle";
            const string CIRCLE = "Circle";
            const string POLYGON = "Polygon";
            const string TRIANGLE = "Triangle"; 
            
            const char RECTANGLE_ID = '1';
            const char CIRCLE_ID = '2';
            const char POLYGON_ID = '3';
            const char TRIANGLE_ID = '4';

            Console.WriteLine("Hello, welcome to tile cost calculator: \nlet's start !");
            while (true)
            {
                Console.WriteLine("Select the shape you want to calculate the total cost of: ");

                Console.WriteLine($"1: {RECTANGLE} \n2: {CIRCLE} \n3: {POLYGON} \n4: {TRIANGLE} \n\n\n");
                char choice = Console.ReadKey().KeyChar;
                
                //clearing console for better readability
                Console.Clear();

                
                Console.WriteLine("\nEnter the cost per one unit of flooring");
                float costPerUnit = Convert.ToInt32(Console.ReadLine());
                

                Console.WriteLine("\nEnter estimatedWorking Time");
                int estimatedWorkingHours = Convert.ToInt32(Console.ReadLine());

                if (choice == RECTANGLE_ID)
                {
                    // A = w * l
                    Console.WriteLine("Enter the width: ");
                    float width = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the height: ");
                    float height = Convert.ToInt32(Console.ReadLine()); ;


                    area = width * height;

                    selectedShape = RECTANGLE;

                }
                else if (choice == CIRCLE_ID)
                {
                    //A = pi * R2
                    float radius = Convert.ToInt32(Console.ReadLine());
                    area = (PI * (radius*radius)); //radius * radius same as Math.POW(radius, 2.0)

                    selectedShape = CIRCLE;
                }
                else if (choice == POLYGON_ID)
                {
                    //A = 1/2 * p * apothem
                    Console.WriteLine("Enter the perimeter: ");
                    float perimeter = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the apothem: ");
                    float apothem = Convert.ToInt32(Console.ReadLine()); ;


                    area = 1 / 2 * perimeter * apothem;
                    selectedShape = POLYGON;
                }
                else if (choice == TRIANGLE_ID)
                {
                    //A = Hb * b / 2
                    Console.WriteLine("Enter the base: ");
                    float baseOfATriangle = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the height: ");
                    float heightOfATriangle = Convert.ToInt32(Console.ReadLine()); ;


                    area = heightOfATriangle * baseOfATriangle / 2;
 
                    selectedShape = TRIANGLE;
                }
                else
                {
                    //ADDED Difficulty notify the user that the given shape is not supported
                    Console.WriteLine("\nShape not supported try again !");
                    return; //restart the loop
                }

                totalCostFlooring = area * costPerUnit;
                float totalPerHour = totalCostFlooring / estimatedWorkingHours;

                Console.WriteLine($"\nThe total cost for flooring an {selectedShape} shaped area of {area} is {totalCostFlooring} \n" +
                                  $"for an estimation of {totalPerHour} total per hour");


                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(); //wait for user interaction to continue
                Console.Clear();
            }

        }

    }
}