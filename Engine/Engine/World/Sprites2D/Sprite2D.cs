using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

using Engine.World.GlobalVariables;

namespace Engine.World.Sprites2D
{
    public class Sprite2D
    {
        public static List<Sprite2D> gameSprites;

        protected Texture2D image;
        protected Vector2 topleft, botRight;
        protected Color color;

        public Sprite2D(Texture2D _image, Vector2 _topLeft, Vector2 _botRight)
        {
            image = _image;
            topleft = _topLeft;
            botRight = _botRight;

            gameSprites.Add(this);
        }

        public void LoadContent()
        {
            image = 
        }

        public virtual void Update(GameTime _gameTime)
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

        public List<Sprite2D> getGameSprites()
        {
            return gameSprites;
        }
    }
}
