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
        public float scale;
        public Vector2 position, size;
        String name;
        
        public ShapeObject(float scale, Vector2 position, Vector2 size, String name)
        {
            this.scale = scale;
            this.position = position;
            this.size = size;
            this.name = name;

            Game.AddShape(this);
        }

        public void Destroy()
        {
            Game.RemoveShape(this);
        }
    }
}
