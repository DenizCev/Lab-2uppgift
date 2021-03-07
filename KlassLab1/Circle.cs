using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab_2
{
    public class Circle : Shape2D
    {
        private Vector2 position;
        private float radius;
        public Circle(Vector2 center, float radius)
        {
            this.position = center;
            this.radius = radius;
        }
        public override Vector3 Center => new Vector3(position, 0);
        public override float Circumference => (radius + radius) * MathF.PI;
        public override float Area => (float)Math.PI * radius * radius;
        public override string ToString()
        {
            return $"Circle @({position.X}, {position.Y}): r = {radius}";






        }

    }
}











   

    
//Klassen Circle ska ha en(1) konstruktor som tar en Vector2 center som första
//parameter, och en float radius som andra parameter.Den ska override:a
//ToString() på så sätt att t.ex:
//Console.WriteLine(new Circle(new Vector2(3.0f, 4.0f), 2.0f));
//=> “circle @(3.0, 4.0): r = 2.0”
