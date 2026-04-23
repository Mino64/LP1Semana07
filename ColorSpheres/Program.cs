using System;

namespace ColorSpheres
{
    public class Program
    {
     static void Main(string[] args)
        {
            
            Color red   = new Color(255, 0, 0);
            Color blue  = new Color(0, 0, 255, 180);
            Color green = new Color(0, 255, 0);
 
            Sphere s1 = new Sphere(red, 5.0);
            Sphere s2 = new Sphere(blue, 3.5);
            Sphere s3 = new Sphere(green, 7.0);
 

            Console.WriteLine("=== Throwing spheres ===");
            s1.Throw();
            s1.Throw();
            s1.Throw();
 
            s2.Throw();
            s2.Throw();
            s2.Throw();
 
            s3.Throw();
 
            Console.WriteLine(s1.GetTimesThrown());
            Console.WriteLine(s2.GetTimesThrown());
            Console.WriteLine(s3.GetTimesThrown());
 

            Console.WriteLine("\n=== Popping s2 ===");
            s2.Pop();
            s2.Throw();
            Console.WriteLine(s2.GetTimesThrown());
 

            Console.WriteLine("\n=== Popping s1 ===");
            s1.Throw();
            s1.Pop();
            s1.Throw();
            Console.WriteLine(s1.GetTimesThrown());


            Console.WriteLine("\n=== Final state of s3 ===");
            s3.Throw();
            s3.Throw();
            Console.WriteLine(s3.GetTimesThrown());
        }
        }
    }
