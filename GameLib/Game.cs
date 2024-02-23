using System;
using System.Windows.Input;
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
using System.Threading;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace GameLib
{
    public class Game
    {
        private static Action user_loadFunc, user_DrawFunc, user_UpdateFunc;
        public static Color BGColor;

        public static Vector2 CameraPosition = new Vector2();

        public static List<ShapeObject> shpObjects = new List<ShapeObject>();
        public static List<SpriteObject> sprObjects = new List<SpriteObject>();

        public static void AddShape(ShapeObject shape)
        {
            shpObjects.Add(shape);
        }
        public static void RemoveShape(ShapeObject shape)
        {   
            shpObjects.Remove(shape);
            Log.Debug("Removing Shape '" + shape.name + "'");
            shape = null;
        }

        public static void AddSprite(SpriteObject sprite)
        {
            sprObjects.Add(sprite);
        }
        public static void RemoveSprite(SpriteObject sprite)
        {
            sprObjects.Remove(sprite);
            Log.Debug("Removing Sprite '" + sprite.name + "'");
            sprite = null;
        }

        public static void LoadWindow(Vector2 Size, String Title, Color BackGroundColor)
        {
            Log.Info("Creating Window");
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
            Window.SetCamPosition(CameraPosition);
            user_UpdateFunc();
        }

        public virtual void GetKeyUp(KeyEventArgs e)
        {

        }
        public virtual void GetKeyDown(KeyEventArgs e)
        {

        }
    }

    public class Wind : Window 
    { 
        public Wind(Vector2 Size, String Title) : base(new Vector2(Size.x, Size.y), Title)  { } 
    }
}
