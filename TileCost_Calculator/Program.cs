namespace TileCost_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcomd to tile cost calculator: \nlet's start !");
            
            Console.WriteLine("Enter the width: ");
            float width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            float height = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter the cost per one unit of flooring");
            float costPerOneUnit = Convert.ToInt32(Console.ReadLine()); ;

            float area = width * height;
            float totalCostFlooring = area * costPerOneUnit;

            //calculate the cost to cover the area
            Console.WriteLine($"The total cost for flooring an area of {area} is {totalCostFlooring}");


        }


    }
}