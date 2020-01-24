using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Engine.World.GlobalVariables;

namespace Engine.World.Inputs
{
    public class SKeyboard
    {

        private Keys[] pressedKeys;

        public SKeyboard()
        {
            pressedKeys = new Keys[254];
        }

        public void Update(GameTime _gameTime)
        {
            pressedKeys = Keyboard.GetState().GetPressedKeys();
        }

        public Keys[] getPressedKeys()
        {
            return pressedKeys;
        }

        public bool isPressed(Keys _key)
        {
            return Keyboard.GetState().IsKeyDown(_key);
        }

        public bool isHeld(Keys key)
        {
            return false;
        }
    }
}
