using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Engine.World.Sprites2D.Cursor;
using Engine.World.Inputs;

namespace Engine.World.GlobalVariables
{
    public static class Globals
    {

        public static GraphicsDeviceManager graphicsDeviceManager;

        //Global Sprites
        public static Cursor cursor;

        //Global Data-Structs
        public static KeyStateHandler keyStates;

        //User Inputs
        public static SMouse mouse;
        public static SKeyboard keyboard;
    }
}
