using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Engine.World.GlobalVariables;

namespace Engine.World.Sprites2D
{
    public class Sprite2D
    {

        private Texture2D image;
        private Vector2 topleft, botRight;
        private Color color;

        public Sprite2D(Texture2D _image, Vector2 _topLeft, Vector2 _botRight, Color _color)
        {
            image = _image;
            topleft = _topLeft;
            botRight = _botRight;
            color = _color;
        }

        public void Update(GameTime _gameTime)
        {

        }

        public Texture2D getTexture2D()
        {
            return image;
        }

        public Rectangle getRectangle()
        {
            return new Rectangle();
        }

        public Color getColor()
        {
            return color;
        }
    }
}
