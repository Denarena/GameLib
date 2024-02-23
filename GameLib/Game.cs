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

namespace GameLib
{
    public class Game
    {
        private static Action user_loadFunc, user_DrawFunc, user_UpdateFunc;
        public static Color BGColor;

        public static List<ShapeObject> Objects = new List<ShapeObject>();

        public static void AddShape(float scale, Vector2 position, Vector2 size, String name, Color color)
        {
            ShapeObject shape = new ShapeObject(scale, position, size, name, color);
            Objects.Add(shape);
        }
        public static void RemoveShape(ShapeObject shape)
        {
            Objects.Remove(shape);
        }

        public static void LoadWindow(Vector2 Size, String Title, Color BackGroundColor)
        {
            Console.WriteLine("Creating Window");
            BGColor = BackGroundColor;
            Wind program = new Wind(Size, Title); 
        }

        public static void Functions(Action loadFunc, Action DrawFunc, Action UpdateFunc)
        {
           user_loadFunc = loadFunc;
           user_DrawFunc = DrawFunc;
           user_UpdateFunc = UpdateFunc;
        }

        public static void OnLoad()
        {
            user_loadFunc();
        }

        public static void OnDraw()
        {
            user_DrawFunc();
        }

        public static void OnUpdate()
        {
            user_UpdateFunc();
        }
    }

    public class Wind : Window 
    { 
        public Wind(Vector2 Size, String Title) : base(new Vector2(Size.x, Size.y), Title)  { } 
    }
}
