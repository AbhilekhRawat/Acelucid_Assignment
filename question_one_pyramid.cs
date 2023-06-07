using System;
namespace DrawPyramid
 {
    class Program
      {
         static void Main(string[] args)
          {
              
             Console.WriteLine("Enter the height of the triangle:");
             int x = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i<= x; i++)
              {
                 for (int j = 1; j <= (x - i); j++)
                    Console.Write(" ");
 
                for (int t = 1; t <i * 2; t++)
                   Console.Write("-");
                Console.WriteLine();
              }
           Console.ReadLine();
        }
    }
}

