﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Drawing.Drawing2D;

namespace GameLib
{
    public class Window
    {
        public static Screen Wind = new Screen();

        public static Color BGColor = Game.BGColor;

        static Vector2 cameraPosition = new Vector2();

        public static void SetCamPosition(Vector2 CameraPosition)
        {
            cameraPosition.x = -CameraPosition.x;
            cameraPosition.y = -CameraPosition.y;
        }

        public Window(Vector2 Size, String Title)
        {
            Wind.Size = new Size((int)Size.x, (int)Size.y);
            Wind.Text = Title;
            Wind.Paint += Renderer;
            Wind.KeyDown += Window_KeyDown;
            Wind.KeyUp += Window_KeyUp;
            Wind.MaximumSize = Wind.Size;

            Thread GameLoopThread = null;

            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();

            void GameLoop()
            {
                Game.OnLoad();
                while (GameLoopThread != null)
                {
                    try
                    {
                        Game.OnDraw();
                        Wind.BeginInvoke((MethodInvoker)delegate { Wind.Refresh(); });
                        Game.OnUpdate();
                        Thread.Sleep(2);
                    }
                    catch
                    {
                        Log.Line(40);
                        Log.Error("Window Closed Or Not Open");
                        Log.Error("Restart Game To Reopen");
                        Log.NewLine();
                        Log.Info("Press any key to close...");

                        Console.ReadKey();

                        GameLoopThread.Abort();
                    }
                }
            }

            Thread WindowThread = new Thread(new ThreadStart(RunWindow));
            WindowThread.Start();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            Game.GetKeyUp(e);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Game.GetKeyDown(e);
        }

        private void RunWindow()
        {
            Application.Run(Wind);
        }

        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.Clear(BGColor);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.TranslateTransform(cameraPosition.x, cameraPosition.y);

            try
            {
                foreach (ShapeObject shape in Game.shpObjects)
                {
                    if (shape.shape == Shape.Rectangle)
                    {
                        g.FillRectangle(new SolidBrush(shape.color), shape.position.x, shape.position.y, shape.size.x, shape.size.y);
                    }
                    else if(shape.shape == Shape.Circle)
                    {
                        return;
                    }
                }

                foreach (SpriteObject sprite in Game.sprObjects)
                {
                    g.DrawImage(sprite.sprite, sprite.position.x, sprite.position.y, sprite.size.x, sprite.size.y);
                }
            }
            catch
            {
                Log.Error("Waiting...");
            }
        }
    }
}
