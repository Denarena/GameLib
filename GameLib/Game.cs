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
using System.Security.Policy;

namespace GameLib
{
    public class Game
    {
        internal static Action user_loadFunc, user_DrawFunc, user_UpdateFunc;
        public static Color BGColor;

        public static Keys KeyPresses;

        public static Vector2 CameraPosition = new Vector2();

        internal static List<ShapeObject> shpObjects = new List<ShapeObject>();
        internal static List<SpriteObject> sprObjects = new List<SpriteObject>();

        public static void AddShape(ShapeObject shape)
        {
            shpObjects.Add(shape);
        }
        public static void RemoveShape(ShapeObject shape)
        {
            shpObjects.Remove(shape);
            Log.Debug("Removing Shape Object '" + shape.name + "' At (" + shape.position.x + "," + shape.position.y + ")");
            shape = null;
        }

        public static void AddSprite(SpriteObject sprite)
        {
            sprObjects.Add(sprite);
        }
        public static void RemoveSprite(SpriteObject sprite)
        {
            sprObjects.Remove(sprite);
            Log.Debug("Removing Sprite Object '" + sprite.name + "' At (" + sprite.position.x + "," + sprite.position.y + ")");
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

        internal static void OnLoad()
        {
            user_loadFunc();
        }

        internal static void OnDraw()
        {
            user_DrawFunc();
        }

        internal static void OnUpdate()
        {
            Window.SetCamPosition(CameraPosition);
            user_UpdateFunc();
        }

        internal static void GetKeyUp(KeyEventArgs e)
        {
            KeyPresses = e.KeyCode;
            Input.GetKeyUp();
        }
        internal static void GetKeyDown(KeyEventArgs e)
        {
            KeyPresses = e.KeyCode;
            Input.GetKeyDown();
        }

        public static int toInt(bool boolean)
        {
            int value = 0;
            if (boolean) { value = 1; } else { value = 0; }
            return value;
        }
    }

    internal class Wind : Window 
    { 
        public Wind(Vector2 Size, String Title) : base(new Vector2(Size.x, Size.y), Title)  { } 
    }
}