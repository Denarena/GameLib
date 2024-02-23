using GameLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace TestApp
{
    class Program
    {
        static ShapeObject cube1;
        public static void Main(string[] args)
        {
            Game.Functions(onLoad, onDraw, onUpdate);
            Game.LoadWindow(new Vector2(900,500), "TestApp", Color.Azure);



            

            Game.AddShape(new ShapeObject(new Vector2(500, 300), new Vector2(300, 120), "Cuboid2", Color.Red));
        }

        public static void onLoad()
        {
            
            Console.WriteLine("Loading");
            cube1 = new ShapeObject(new Vector2(100, 150), new Vector2(1, 200), "Cuboid1", Color.Black);
        }
        public static void onDraw()
        {

        }

        public static int frames = 0;
        public static void onUpdate()
        {
            frames++;
            Console.WriteLine(frames);
            cube1.position.x += 1f;
        }
    }
}