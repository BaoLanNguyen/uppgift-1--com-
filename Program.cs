using System;

namespace uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur mycket väger kuvertet för varje m^2 (måste vara mellan 50 och 200): ");
            int num = int.Parse(Console.ReadLine());
            while (num<50 || num>200)
            {
                Console.WriteLine("värdet är inte inom intervallet, försök igen: ");
                num = int.Parse(Console.ReadLine());   
            }
            Console.WriteLine("hur mycket väger affischet för varje m^2 (måste vara mellan 50 och 200): ");
            int num2 = int.Parse(Console.ReadLine());
            while (num2<50 || num2>200)
            {
                Console.WriteLine("värdet är inte inom intervallet, försök igen: ");
                num2 = int.Parse(Console.ReadLine());   
            }
            Console.WriteLine("hur mycket väger bladet för varje m^2 (måste vara mellan 50 och 200): ");
            int num3 = int.Parse(Console.ReadLine());
            while (num3<50 || num3>200)
            {
                Console.WriteLine("värdet är inte inom intervallet, försök igen: ");
                num3 = int.Parse(Console.ReadLine());   
            }
            double converter = Math.Pow(10, -6);
            double area1 = 229*324*converter;
            double area2 = 297*420*converter;
            double area3 = 210*297*converter;
            double result = area1*2*num + area2*2*num2 + area3*1*num3;
            double result2 = Math.Round(result,4); 
            Console.WriteLine("Svar: "+ result2 +".");

        }
    }
}
