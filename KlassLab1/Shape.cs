using System;
using System.Numerics;
using System.Collections.Generic;
namespace Lab_2
{
    public abstract class Shape
    {
        public Random Rng = new Random();
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape RandomShape(Random Rng)
        {

            Shape shape = null;

            switch (Rng.Next(7))
            {


                case 0:
                    shape = new Circle(new Vector2(Rng.Next(-100, 101), Rng.Next(-100, 101)), (Rng.Next(1, 5)));
                    break;

                case 1:
                    shape = new Triangle(new Vector2(Rng.Next(-100, 101), Rng.Next(-100, 101))
                        , new Vector2(Rng.Next(-100, 101), Rng.Next(-100, 101))
                        , new Vector2(Rng.Next(-100, 101), Rng.Next(-100, 101)));
                    break;



                case 2:
                    shape = new Rectangle(new Vector2(Rng.Next(-100, 101), Rng.Next(-100, 101)), (Rng.Next(1, 5)));
                    break;

                case 3:
                    shape = new Cuboid(new Vector3(Rng.Next(-100, 101), Rng.Next(-100, 101), Rng.Next(-100, 101)),
                            new Vector3(Rng.Next(-100, 101), Rng.Next(-100, 101), Rng.Next(-100, 101)));
                    break;
                case 4:
                    shape = new Sphere(new Vector3(Rng.Next(-100, 101), Rng.Next(-100, 101), Rng.Next(-100, 101)), 10, 10);
                    break;


            }
            return shape;





        }
    }
}

























