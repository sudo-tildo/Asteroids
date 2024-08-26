using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroids;

public static class Globals
{
    public static SpriteBatch SpriteBatch { get; set; }
    public static ContentManager Content { get; set; }
    public static GraphicsDevice GraphicsDevice { get; set; }
    public static float Time { get; set; }
    public static Point WindowSize { get; set; }

    public static void Update(GameTime gameTime)
    {
        Time = (float)gameTime.ElapsedGameTime.TotalSeconds;
    }
}