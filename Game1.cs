using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_Lesson_One
{
    public class Game1 : Game    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D dinoTexture;
        Texture2D ghostTexture;
        Texture2D earthTexture;
        Texture2D meteorTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 1200;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();

            this.Window.Title = "My First MonoGame project";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dinoTexture = Content.Load<Texture2D>("dino");
            ghostTexture = Content.Load<Texture2D>("ghost");
            earthTexture = Content.Load<Texture2D>("Earth");
            meteorTexture = Content.Load<Texture2D>("meteor");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(earthTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(dinoTexture, new Vector2(10, 500), Color.White);
            _spriteBatch.Draw(dinoTexture, new Vector2(900, 500), Color.White);
            _spriteBatch.Draw(meteorTexture, new Vector2(600, 20), Color.White);


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
