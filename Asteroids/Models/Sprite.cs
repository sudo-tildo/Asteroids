using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroids.Models;

public abstract class Sprite
{
    protected readonly Texture2D Texture;
    public Vector2 Position;
    protected float Rotation;
    protected float Speed;
    protected float FrameTime = 0.1f;
    protected  int CurrentFrame = 0;
    protected int FrameCount = 1;
    protected Point FrameSize;
    protected float Scale;
    
    public Rectangle CollisionRectangle => new(Position.ToPoint(), FrameSize);
    
    public Sprite(Texture2D texture)
    {
        this.Texture = texture;
    }

    public virtual void Update()
    {
        
    }

    public virtual void Draw()
    {
        
    }
}