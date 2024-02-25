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
        public String shape;
        public SpriteObject SprCollisionObject;
        public ShapeObject ShpCollisionObject;

        public ShapeObject(Vector2 size, Vector2 position, String name, Color color, String shape)
        {
            Log.Debug("Creating Shape Object '" + name + "' At (" + position.x + "," + position.y + ")");

            this.position = position;
            this.size = size;
            this.name = name;
            this.color = color;
            this.shape = shape;

            Game.AddShape(this);
        }

        public bool isColliding(String name, Vector2 position)
        {
            foreach (SpriteObject b in Game.sprObjects)
            {
                SprCollisionObject = b;
                if (b.name == name)
                {
                    if (position.x < b.position.x + b.size.x &&
                        position.x + size.x > b.position.x &&
                        position.y < b.position.y + b.size.y &&
                        position.y + size.y > b.position.y) { return true; }
                }
            }
            foreach (ShapeObject b in Game.shpObjects)
            {
                ShpCollisionObject = b;
                if (b.name == name)
                {
                    if (position.x < b.position.x + b.size.x &&
                        position.x + size.x > b.position.x &&
                        position.y < b.position.y + b.size.y &&
                        position.y + size.y > b.position.y) { return true; }
                }
            }

            return false;
        }

        public void Destroy()
        {
            Game.RemoveShape(this);
        }
    }
}
