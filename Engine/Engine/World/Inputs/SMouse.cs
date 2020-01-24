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

        private MouseButton[] pressedButtons;

        public SMouse()
        {
            pressedButtons = new MouseButton[3];
        }

        //Change list to an array
        public void Update(GameTime _gameTime)
        {
            MouseState mouseState = Mouse.GetState();

            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                pressedButtons[(int)MouseButton.LeftButton] = MouseButton.LeftButton;
            } else
            {
                pressedButtons[(int)MouseButton.LeftButton] = MouseButton.Released;
            }
            if (mouseState.MiddleButton == ButtonState.Pressed)
            {
                pressedButtons[(int)MouseButton.MiddleButton] = MouseButton.MiddleButton;
            } else
            {
                pressedButtons[(int)MouseButton.MiddleButton] = MouseButton.Released;
            }
            if (mouseState.RightButton == ButtonState.Pressed)
            {
                pressedButtons[(int)MouseButton.RightButton] = MouseButton.RightButton;
            } else
            {
                pressedButtons[(int)MouseButton.RightButton] = MouseButton.Released;
            }
        }

        public MouseButton[] getPressedButtons()
        {
            return pressedButtons;
        }

        public bool isPressed(MouseButton mouseButton)
        {
            return pressedButtons[(int)mouseButton] != MouseButton.Released;
        }

        public bool isHeald(MouseButton mouseButton)
        {

        }
    }

    public enum MouseButton : int { 
        LeftButton,
        MiddleButton,
        RightButton,
        Mouse4,
        Mouse5,

        Released = 9,
        Heald = 10
    }
}
