using Asteroids.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Asteroids;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private GameManager _gameManager;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        Globals.WindowSize=new(1280, 720);
        _graphics.PreferredBackBufferWidth=Globals.WindowSize.X;
        _graphics.PreferredBackBufferHeight=Globals.WindowSize.Y;
        _graphics.ApplyChanges();
        Globals.Content = Content;
        _gameManager = new GameManager();
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        Globals.SpriteBatch = _spriteBatch;

    }

    protected override void Update(GameTime gameTime)
    {
        Globals.Update(gameTime);
        _gameManager.Update();
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();


        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        
        _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
        _gameManager.Draw();
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}