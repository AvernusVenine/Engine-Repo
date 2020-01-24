using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Engine.World.GlobalVariables;
using Engine.World.Sprites2D;

namespace Engine.World.Scene
{
    public class Scene
    {
        private Texture2D image;
        private Vector2 topLeft;
        private Vector2 botRight;
        private Vector3 color;

        public Scene(Texture2D _image, Vector2 _topLeft, Vector2 _botRight, Vector3 _color)
        {
            image = _image;
            topLeft = _topLeft;
            botRight = _botRight;
            color = _color;
        }

        public Scene(Texture2D _image, Vector3 _color)
        {
            image = _image;
            color = _color;
            topLeft = Vector2.Zero;
            botRight = new Vector2();
        }

        public void Draw(GameTime _gameTime)
        {

        }

    }
}
