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

        private const int MOUSE_SIZE = 50;

        public Cursor()
            : base(new Texture2D(Globals.graphicsDeviceManager.GraphicsDevice, MOUSE_SIZE, MOUSE_SIZE), new Vector2(Mouse.GetState().X, Mouse.GetState().Y), new Vector2(MOUSE_SIZE))
        {

        }

        public override void Update(GameTime _gameTime)
        {
            MouseState mouseState = Mouse.GetState();


            //Change to mouse class
            base.topleft = new Vector2(mouseState.X, mouseState.Y);
            base.botRight = new Vector2(mouseState.X + MOUSE_SIZE, mouseState.Y + MOUSE_SIZE);

            base.Update(_gameTime);
        }

    }
}
