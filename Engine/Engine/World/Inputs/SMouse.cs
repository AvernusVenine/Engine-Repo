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
    public class SMouse
    {
        public SMouse()
        {

        }

        public void Update(GameTime _gameTime)
        {

        }
    }

    public enum SMouseState : int //Max 1-7
    {
        Left = 1,
        Middle = 2,
        Right = 3
    }

    public class KeyStateHandler
    {

        private bool[] keyStates;

        public KeyStateHandler()
        {
            keyStates = new bool[254];
        }
        
        public void UpdateState()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();

            for (int i = 0; i < pressedKeys.Count(); i++)
            {
                keyStates[(int)pressedKeys[i]] = Keyboard.GetState().IsKeyDown(pressedKeys[i]);
            }

            MouseState mouseState = Mouse.GetState();
            //TODO Possibly improve?
            keyStates[(int)SMouseState.Left] = (mouseState.LeftButton == ButtonState.Pressed);
            keyStates[(int)SMouseState.Middle] = (mouseState.MiddleButton == ButtonState.Pressed);
            keyStates[(int)SMouseState.Right] = (mouseState.RightButton == ButtonState.Pressed);

        }

    }
}
