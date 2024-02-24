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
using System.Security.Cryptography.X509Certificates;
using System.Media;

namespace TestApp
{
    class Program
    {

        public static bool left, right, up, down;


        static string[,] map =
        {
            {".",".",".",".",".",".","."},
            {".",".",".",".",".",".","."},
            {".",".",".",".","g",".","."},
            {".",".","g",".","g",".","."},
            {"g","g","g","g","g","g","g"},
            {".",".",".",".",".",".","."},
            {".",".",".",".",".",".","."},
        };

        public static void Main(string[] args)
        {
            Game.Functions(onLoad, onDraw, onUpdate, GetKeyUp, GetKeyDown);
            Game.LoadWindow(new Vector2(900, 500), "TestApp", Color.Azure);
        }

        public static void onLoad()
        {
            Game.CameraPosition.x += 200;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[j, i] == "g")
                    {
                        new SpriteObject(new Vector2(50, 50), new Vector2(i * 50, j * 50), "Assets/Wall.png", "Wall");
                    }
                }
            }
        }

        static SpriteObject player = new SpriteObject(new Vector2(32, 36), new Vector2(50, 50), "Assets/Player.png", "Player");
        public static void GetKeyUp()
        {
            if (Game.KeyPresses == Keys.W) { up = false; Log.Info("Key W Up"); }
            if (Game.KeyPresses == Keys.A) { left = false; Log.Info("Key W Up"); }
            if (Game.KeyPresses == Keys.S) { down = false; Log.Info("Key W Up"); }
            if (Game.KeyPresses == Keys.D) { right = false; Log.Info("Key W Up"); }
        }
        public static void GetKeyDown()
        {
            if (Game.KeyPresses == Keys.W) { up = true; Log.Info("Key W Down"); }
            if (Game.KeyPresses == Keys.A) { left = true; Log.Info("Key W Down"); }
            if (Game.KeyPresses == Keys.S) { down = true; Log.Info("Key W Down"); }
            if (Game.KeyPresses == Keys.D) { right = true; Log.Info("Key W Down"); }
        }

        public static void onDraw()
        {
            
        }
        public static void onUpdate()
        {
            if (up)
            {
                player.position.y -= 2;
            }
            if (down)
            {
                player.position.y += 2;
            }
            if (left)
            {
                player.position.x -= 2;
            }
            if (right)
            {
                player.position.x += 2;
            }
        }
    }
}