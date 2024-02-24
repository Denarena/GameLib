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
            {"g","g","g","g","g","g","g"},
            {"g",".",".",".",".",".","g"},
            {"g",".","g",".","g","g","g"},
            {"g",".","g",".",".",".","."},
            {"g",".","g","g","g","g","g"},
            {"g",".",".",".",".",".","g"},
            {"g","g","g","g",".","g","g"},
        };

        public static void Main(string[] args)
        {
            Game.Functions(onLoad, onDraw, onUpdate);
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
                        new ShapeObject(new Vector2(50, 50), new Vector2(i * 50, j * 50), "Wall", Color.DarkCyan);
                    }
                }
            }
        }

        static SpriteObject player = new SpriteObject(new Vector2(32, 36), new Vector2(50, 50), "Assets/Player.png", "Player");

        public static void onDraw()
        {
            
        }
        public static void onUpdate()
        {
            if (Input.W)
            {
                player.position.y -= 2;
            }
            if (Input.S)
            {
                player.position.y += 2;
            }
            if (Input.A)
            {
                player.position.x -= 2;
            }
            if (Input.D)
            {
                player.position.x += 2;
            }
        }
    }
}