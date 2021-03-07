using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab_2
{
    public class Sphere : Shape3D
    {
        public static double center;
        private Vector3 vector3;


        public float Radius { get; }
        public override float Volume { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }
        public int V { get; }


        public Sphere(Vector3 center, float area, float radius)
        {
            this.Center = center;
            this.Area = (float)(4 * Math.PI * radius * radius);
            this.Radius = (float)(radius * radius * Math.PI);

            double Volume = (4 * Math.PI * radius * radius * radius) / 3;













        }

        //public Sphere(Vector3 vector3)
        //{
        //    this.vector3 = vector3;

        //}

        //public Sphere(Vector3 vector3, int v) : this(vector3)
        //{
        //    V = v;
        ////}

        public override string ToString()
        {
            return $"Sphere @({Center.X}, {Center.Y}); Area = {Area}, Center = {Center}, Radius = {Radius}";

        }
    }
}


