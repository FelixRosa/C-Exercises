using System;

namespace Exercise1_Control_Flow
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Test 1.
            Console.WriteLine("Enter a number!"); 
            var userIn = Console.ReadLine();
           Console.WriteLine(ProgLogic.CheckNumber(Convert.ToInt32(userIn)));
           Console.WriteLine("\n");
           
           //Test 2.
           Console.WriteLine("Enter first number!");
           var var1 = Console.ReadLine();
           Console.WriteLine("Enter second number!");
           var var2 = Console.ReadLine();
           Console.WriteLine(ProgLogic.MaxNum(Convert.ToInt32(var1), Convert.ToInt32(var2)));
           Console.WriteLine("\n");
           
           //Test 3.
           Console.WriteLine("Enter Width of the picture.");
           var inWidth = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter Height of the picture.");
           var inHeight = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(ProgLogic.GetImageType(inWidth, inHeight));
           Console.WriteLine("\n");
            
            //Test 4.
            Console.WriteLine("Enter the Speedlimit");
            var userSpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Speed");
            var userSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ProgLogic.SpeedCam(userSpeedLimit, userSpeed));
            
        }
    }
}