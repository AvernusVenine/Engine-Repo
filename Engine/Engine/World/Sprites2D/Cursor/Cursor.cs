using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Engine.World.Sprites2D;
using Engine.World.GlobalVariables;

namespace Engine.World.Sprites2D.Cursor
{
    public class Cursor : Sprite2D
    {

        public Cursor() : base(new Texture2D(Globals.graphicsDeviceManager.GraphicsDevice, 50, 50), new Vector2(), new Vector2(50), Color.White)
        {

        }

        public void Update(GameTime _gameTime)
        {
            MouseState mouseState = Mouse.GetState();

            base.topleft = new Vector2(mouseState.X, mouseState.Y);

            base.Update(_gameTime);
        }

    }
}
