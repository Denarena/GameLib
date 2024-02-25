using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameLib
{
    public class SpriteObject
    {
        public Vector2 position, size;
        public String name, directory;
        public Bitmap sprite;
        public SpriteObject SprCollisionObject;
        public ShapeObject ShpCollisionObject;

        public SpriteObject(Vector2 size, Vector2 position, String directory, String name)
        {
            Log.Debug("Creating Sprite Object '" + name + "' At (" + position.x + "," + position.y + ")");

            this.position = position;
            this.size = size;
            this.name = name;
            this.directory = directory;

            Image tmp = Image.FromFile(directory) as Bitmap;

            Bitmap sprite = new Bitmap(tmp);
            this.sprite = sprite;

            Game.AddSprite(this);
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
            Game.RemoveSprite(this);
        }
    }
}
