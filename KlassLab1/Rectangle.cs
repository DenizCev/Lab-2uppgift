using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab_2
{
    public class Rectangle : Shape2D
    {
        public override float Circumference { get; }
        public override Vector3 Center { get; }
        
        public float Width { get;}
        public Vector2 Size { get; }
        public override float Area { get;  }
        public  bool IsSquare { get; }
        public override string ToString() {
            return $"Rectangle @({Size.X}, {Size.Y}); Size.X = {Size.X}, Size.Y = {Size.Y}, Size = {Size}";


        }
        public Rectangle(Vector2 center, Vector2 size)
        {
            this.Center = new Vector3(center, 0);

            this.Size = size;

            Circumference = 2 * (Size.X + Size.Y);

            Area = Size.X * Size.Y;

            IsSquare = (Size.X == Size.Y);


            




        }
        public Rectangle(Vector2 center, float width)
        {

            this.Center = new Vector3(center, 0);

            this.Width = width;

            Circumference = width + width + width + width;

            Area = width * width;

            IsSquare = true;

        }


        
    }
}
