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

        static string[,] map =
        {
            {"g","g","g","g","g","g","g"},
            {"g",".",".",".",".","c","g"},
            {"g",".","g",".","g","g","g"},
            {"g","c","g",".",".",".","."},
            {"g",".","g","g","g","g","g"},
            {"g",".",".",".",".","c","g"},
            {"g","g","g","g",".","g","g"},
        };

        public static void Main(string[] args)
        {
            Game.Functions(onLoad, onDraw, onUpdate);
            Game.LoadWindow(new Vector2(900, 500), "TestApp", Color.Azure);
        }
        public static int colliding = 0;
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
                    if (map[j, i] == "c")
                    {
                        new SpriteObject(new Vector2(40.6f, 49.3f), new Vector2(i * 50, j * 50), "Assets/Collectable.png", "Collectable");
                    }
                }
            }
        }

        static SpriteObject player = new SpriteObject(new Vector2(27.2f, 30.6f), new Vector2(210, 300), "Assets/Player.png", "Player");

        static float speed = 2f;

        public static void onDraw()
        {
            
        }
        public static void onUpdate()
        {
            int hMove = Game.toInt(Input.D) - Game.toInt(Input.A);
            float hSpd = hMove * speed;
            int vMove = Game.toInt(Input.W) - Game.toInt(Input.S);
            float vSpd = vMove * speed;

            if (player.isColliding("Wall", new Vector2(player.position.x+hSpd,player.position.y)))
            {
                hSpd = 0;
            }
            else if(player.isColliding("Wall", new Vector2(player.position.x, player.position.y - vSpd)))
            {
                vSpd = 0;
            }
            player.position.x += hSpd;
            player.position.y -= vSpd;

            if (player.isColliding("Collectable", player.position))
            {
                player.CollisionObject.Destroy();
            }
        }
    }
}