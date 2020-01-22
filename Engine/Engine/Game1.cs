using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

using Engine.World.Sprites2D;
using Engine.World.Sprites2D.Cursor;
using Engine.World.GlobalVariables;
using Engine.World.Inputs;

namespace Engine
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private List<Sprite2D> sprites; //Possibly create own data structure
        
        public Game1()
        {
            Globals.graphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        //For non graphical content
        protected override void Initialize()
        {
            sprites = new List<Sprite2D>();

            //TODO: Initialize Objects here
            Globals.cursor = new Cursor();

            Globals.mouse = new SMouse();
            Globals.keyboard = new SKeyboard();

            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);


        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            Globals.keyStates.UpdateState(Mouse.GetState());
            Globals.mouse.Update(gameTime);
            Globals.keyStates.UpdateState(Keyboard.GetState());
            Globals.keyboard.Update(gameTime);

            for(int i = 0; i < sprites.Count; i++)
            {
                sprites[i].Update(gameTime);
            }

            base.Update(gameTime);
        }

        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);

            spriteBatch.Begin(); //TODO: Add sprites here

            for(int i = 0; i < sprites.Count; i++)
            {
                spriteBatch.Draw(sprites[i].getTexture2D(), sprites[i].getRectangle(), sprites[i].getColor());
            }

            spriteBatch.End();
        }
    }
}
