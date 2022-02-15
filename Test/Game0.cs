using System;
using KaguEngine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PrimitiveExpander;
using Test.Entity;

namespace Test
{
    public class Game0 : Game
    {
        private GraphicsDeviceManager _deviceManager;
        private SpriteBatch _spriteBatch;
        private readonly Random _random;

        private Moon _moon;
        private Player _player;

        public Game0()
        {
            Content.RootDirectory = "Content";

            _random = new Random();
            _deviceManager = new GraphicsDeviceManager(this);
            IsMouseVisible = true;
            Window.AllowUserResizing = true;
        }

        protected override void Initialize()
        {
            PrimitiveRenderer.Initialise(GraphicsDevice);
            Kagu.Init();

            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            
            Kagu.Texture2DManager.Add("player", Content.Load<Texture2D>("missing"));
            
            _moon = new Moon0();
            
            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            Kagu.Update(gameTime);

            _moon.Update(gameTime);
            
            //Update PrimitiveRendererCamera
            PrimitiveRenderer.UpdateDefaultCamera();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _moon.Draw(_spriteBatch, gameTime);
            _spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}