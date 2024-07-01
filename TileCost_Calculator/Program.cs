namespace TileCost_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to tile cost calculator: \nlet's start !");
            while (true)
            {
                Console.WriteLine("Select the shape you want to calculate the total cost of: ");

                Console.WriteLine("1: Rectangle \n2: Circle \n3: Polygon \n4: Triangle \n");
                char choice = Console.ReadKey().KeyChar;

                Console.WriteLine("Enter the cost per one unit of flooring");
                float costPerUnit = Convert.ToInt32(Console.ReadLine()); ;

                if (choice == '1')
                    _costForRectange(costPerUnit);
                else if (choice == '2')
                    _costForCircle(costPerUnit);
                else if (choice == '3')
                    _costForPolygon(costPerUnit);
                else if (choice == '4')
                    _costForTriangle(costPerUnit);
                else
                {
                    //ADDED Difficulty notify the user that the given shape is not supported
                    Console.WriteLine("Shape not supported try again !");
                }
            }

        }
        private static void _costForRectange(float costPerUnit) 
        {
            // A = w * l
            Console.WriteLine("Enter the width: ");
            float width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            float height = Convert.ToInt32(Console.ReadLine()); ;
 

            float area = width * height;
            float totalCostFlooring = area * costPerUnit;

            //calculate the cost to cover the area
            Console.WriteLine($"The total cost for flooring an rectangle shaped area of {area} is {totalCostFlooring}");
        }
        private static void _costForCircle(float costPerUnit)
        {
            //A = pi * R2
            //using double since math.pow canonly be used using double
            double radius = Convert.ToInt32(Console.ReadLine());
            double area = 3.14 * Math.Pow(radius, 2.0);
            

            double totalCostFlooring = area * (double)costPerUnit;

            //calculate the cost to cover the area
            Console.WriteLine($"The total cost for flooring a circle shaped area of {area} is {totalCostFlooring}");
        }

        private static void _costForPolygon(float costPerUnit)
        {
            //A = 1/2 * p * apothem
            Console.WriteLine("Enter the perimeter: ");
            float perimeter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the apothem: ");
            float apothem = Convert.ToInt32(Console.ReadLine()); ;


            float area = 1/2 * perimeter * apothem;
            float totalCostFlooring = area * costPerUnit;

            //calculate the cost to cover the area
            Console.WriteLine($"The total cost for flooring an polygon shaped area of {area} is {totalCostFlooring}");

        }
        private static void _costForTriangle(float costPerUnit)
        {
            //A = Hb * b / 2
            Console.WriteLine("Enter the base: ");
            float baseOfATriangle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            float heightOfATriangle = Convert.ToInt32(Console.ReadLine()); ;


            float area = heightOfATriangle * baseOfATriangle / 2;
            float totalCostFlooring = area * costPerUnit;

            //calculate the cost to cover the area
            Console.WriteLine($"The total cost for flooring an Triangle shaped area of {area} is {totalCostFlooring}");

        }
    }
}