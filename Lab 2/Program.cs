using Lab_2;
using System;
using System.Numerics;

class Program
    {

        


    



    



    static void Main(string[] args)
        {


        Circle cirkel = new Circle(new Vector2(4, 5),  7F);

        Console.Write(cirkel);
        Console.WriteLine();

       

        Rectangle rektangel = new Rectangle(new Vector2(5, 2), new Vector2(5, 10));

        Console.Write(rektangel);
        Console.WriteLine();




        Triangle triangel = new Triangle(new Vector2(1, 1), new Vector2(1, 1), new Vector2(1, 1));

        Console.Write(triangel);

        Console.WriteLine();


        Sphere sfär = new Sphere(new Vector3(1, 2, 3), 10, 10);

        Console.Write(sfär);
        Console.WriteLine();

        Cuboid kub = new Cuboid(new Vector3(1, 2, 3), new Vector3(1, 2, 3));

        Console.Write(kub.ToString());
        Console.WriteLine();


        Console.ReadKey();

        }
    }

