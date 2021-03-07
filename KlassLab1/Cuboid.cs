using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab_2
{
    public class Cuboid : Shape3D
    {
        private Vector3 center;

        private Vector3 Length;
        private float Height;
        private float volume;
        private float Width;
        private Vector3 Size;
        private Vector2 vector2;
        private int v;
        private float area;


        public Cuboid(Vector3 _center, Vector3 size)
        {

            this.center = _center;
            this.Size = size;




            volume = size.X * size.Y * size.Z;
            area = 2.0F * size.X * size.Y + size.Y * size.Z * 2.0F + size.X * size.Z * 2.0F;





        }
        public Cuboid(Vector3 center, float width)
        {


            this.center = center;


            Size = new Vector3(width, width, width);

            volume = Size.X * Size.Y * Size.Z;
            area = 2.0F * Size.X * Size.Y + Size.Y * Size.Z * 2.0F + Size.X * Size.Z * 2.0F;




        }







        //}

        //public Cuboid(Vector2 vector2, int v)
        //{
        //    //this.vector2 = vector2;
        //    //this.v = v;
        //}

        public override float Volume { get { return volume; } }

        public override Vector3 Center { get { return center; } }



        public bool IsCube { get { return Height == Width; } }

        public override float Area  {get { return area;} }

        public override string ToString()
        {
            
        return $"Cuboid @({Center.X}, {Center.Y});Length = {Size.X}, Height = {Size.Y}, Width = {Size.Z} Area = {area}, Volume = {volume}";
            
            
        }


    }
    }

//Denna klass ska ha en konstruktor som tar parametrar: Vector3 center, Vector3
//size (dvs. höjd/bredd/djup), samt en alternativ konstruktor: Vector3 center, float
//width (som sätter höjd, bredd djup till samma värde).
//Den ska även implementera en property IsCube som returnerar true om höjd,
//bredd och djup är lika (annars false).