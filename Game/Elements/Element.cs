using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Elements
{
    public abstract class Element
    {
        private float x, y;
        public Element(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
