using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab_2
{
    public class Triangle : Shape2D
    {
        private Vector2 vector2;
        private int v;

        public Vector2 P1 { get; }
        public Vector2 P2 { get; }
        public Vector2 P3 { get; }
        public Vector3 Size { get; }

        public override Vector3 Center => new Vector3((P1.X + P2.X + P3.X) / 3.0f, (P1.Y + P2.Y + P3.Y) / 3.0f, 0);


        public override float Area => throw new NotImplementedException();
        public override float Circumference => (P1 - P2).Length() + (P2 - P3).Length() + (P3 - P1).Length();
        public override string ToString()
        {
            return $"Triangle @({Center.X}, {Center.Y}); P1 = {P1}, P2 = {P2}, P3 = {P3}";

        }

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)

        {
            P1 = p1;
            P2 = p2;
            P3 = p3;  





        }

        //public Triangle(Vector2 vector2, int v)
        //{
        //    this.vector2 = vector2;
        //    this.v = v;
        //}
    }
}




  






//Circumference = Vector2.Distance(p1, p2) + Vector2.Distance(p1, p3) + Vector2.Distance(p2, p3);

//Center = new Vector3((P1.X + P2.Y + P3.X) / 3, ((P1.Y + P2.Y + P3.Y) / 3), 0);

//Area = Math.Abs(P1.X * (P2.Y - P3.Y) + P2.Y * (P3.Y - P1.X) + P3.Y * (P1.X - P2.Y) / 2);