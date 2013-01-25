using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game.Elements
{
    class Player : Element
    {
        private KeyboardState keyboard;
        private float x, y;
        private float speed;
        ImageLoader sprite;
        public Player(GameManager gm,float x, float y) : base(x,y)
        {
            sprite = new ImageLoader(gm.getGraphicsDevice(),"Player",1);
            this.x = x;
            this.y = y;
            speed = 5;
        }
        public void move()
        {
            keyboard = new KeyboardState();
            if(keyboard.IsKeyDown(Keys.A))
            {
                x -= speed;
            }
            if(keyboard.IsKeyDown(Keys.D))
            {
                y -= speed;
            }
        }
        public Texture2D getImage()
        {
            return sprite.getImage(1);
        }
    }
}
