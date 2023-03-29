using System;
using System.Collections.Generic;
class Program
{
   static void Main(string [] args){
    double p1x,p1y,p2x,p2y,p3x,p3y;
    double centerX, centerY, radius;
    p1x = double.Parse(Console.ReadLine());
      p1y = double.Parse(Console.ReadLine());
    p2x = double.Parse(Console.ReadLine());
      p2y = double.Parse(Console.ReadLine());
       p3x = double.Parse(Console.ReadLine());
      p3y = double.Parse(Console.ReadLine());
      centerX = p3x;
        centerY = p3y;
        radius = Math.Sqrt(Math.Pow(centerX - p1x, 2) + Math.Pow(centerY - p2y, 2));
        Console.WriteLine(centerX);
        Console.WriteLine(centerY);
        Console.WriteLine(radius);
   }
}
