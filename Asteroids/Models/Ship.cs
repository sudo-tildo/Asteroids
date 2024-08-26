using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Asteroids.Models;

public class Ship : Sprite
{
    private Rectangle _shipRect { get; set; }
    public Ship(Texture2D texture) : base(texture)
    {
        FrameSize = new Point(texture.Width / 5, texture.Height / 2);
        Position = new(Globals.WindowSize.X / 2, Globals.WindowSize.Y / 2);
        Scale = 5f;
    }

    private void UpdateRect()
    {
        Point location = new(CurrentFrame * FrameSize.X, FrameSize.Y);
        _shipRect = new(location, FrameSize);
    }

    private void UpdateAnimation()
    {
        FrameTime -= Globals.Time * 1.5f;
        if (FrameTime <= 0)
        {
            FrameTime += 0.1f;
            CurrentFrame += FrameCount;
            
            if (CurrentFrame == 2) FrameCount = -1;
            if (CurrentFrame == 0) FrameCount = 1;
        }
    }

    public override void Update()
    {
        UpdateRect();
        UpdateAnimation();
        if (Keyboard.GetState().IsKeyDown(Keys.Up)){Position.Y -= 1;}
        if (Keyboard.GetState().IsKeyDown(Keys.Down)){Position.Y += 1;}
        if (Keyboard.GetState().IsKeyDown(Keys.Left)){Position.X -= 1;}
        if (Keyboard.GetState().IsKeyDown(Keys.Right)){Position.X += 1;}
        Console.WriteLine(Position);
    }

    public override void Draw()
    {
        Globals.SpriteBatch.Draw(base.Texture, Position, _shipRect, Color.White,
            Rotation, 
            Vector2.Zero, 
            Scale,
            SpriteEffects.None, 
            0f);
    }
}