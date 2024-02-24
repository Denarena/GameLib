using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib
{
    public class SpriteObject
    {
        public Vector2 position, size;
        public String name, directory;
        public Bitmap sprite;

        public SpriteObject(Vector2 size, Vector2 position, String directory, String name)
        {
            Log.Debug("Creating Sprite Object '" + name + "' At (" + position.x + "," + position.y + ")");f

            this.position = position;
            this.size = size;
            this.name = name;
            this.directory = directory;

            Image tmp = Image.FromFile(directory) as Bitmap;

            Bitmap sprite = new Bitmap(tmp);
            this.sprite = sprite;

            Game.AddSprite(this);
        }
    }
}
