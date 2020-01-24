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
            pressedButtons = new MouseButton[10];
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

        public bool isPressed(MouseButton _button)
        {
            return pressedButtons[(int)_button] != MouseButton.Released;
        }

        //TODO test if button is held
        public bool isHeld(MouseButton _button)
        {
            return false;
        }
    }

    public enum MouseButton : int { 
        LeftButton,
        MiddleButton,
        RightButton,
        Mouse4,
        Mouse5,

        Released = 8,
        Held = 9
    }
}
