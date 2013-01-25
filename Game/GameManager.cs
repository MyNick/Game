using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Game.Elements;

namespace Game
{
    class GameManager
    {
        private Player player;
        private GraphicsDevice graphicsDevice;
        public GameManager(GraphicsDevice graphicsDevice)
        {
            player = new Player(this,100, 100);
            this.graphicsDevice = graphicsDevice;
        }
        public void movePlayer()
        {
            player.move();
        }
        public GraphicsDevice getGraphicsDevice()
        {
            return graphicsDevice;
        }
        public Texture2D getPlayerImage()
        {
            return player.getImage();
        }
    }
}
