using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace GameLib
{
    public class ShapeObject
    {
        public Vector2 position, size;
        public String name;
        public Color color;
        
        public ShapeObject(Vector2 size, Vector2 position, String name, Color color)
        {
            Log.Debug("Creating Shape '" + name + "'");

            this.position = position;
            this.size = size;
            this.name = name;
            this.color = color;

            Game.AddShape(this);
        }

        public void Destroy()
        {
            Game.RemoveShape(this);
        }
    }
}
