using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace Game
{
    class ImageLoader
    {
        Texture2D[] animation;
        public ImageLoader(GraphicsDevice graphicsDevice, string fileName,int frames)
        {
            animation = new Texture2D[frames];
            for (int i = 0; i < frames; i++)
            {
                animation[i] = Texture2D.FromStream(graphicsDevice,File.OpenRead(Directory.GetCurrentDirectory()+ "\\" + fileName + "_" + (i).ToString()+".png"));
            }
        }
        public Texture2D getImage(int i)
        {
            return animation[i];
        }
    }
}
