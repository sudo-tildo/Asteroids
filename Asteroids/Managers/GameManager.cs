using System;
using Asteroids.Models;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroids.Managers;

public class GameManager
{
    private readonly Ship _ship;
    public GameManager()
    {
        _ship = new Ship(Globals.Content.Load<Texture2D>("Player_Ship/Ship"));
    }

    public void Update()
    {
        _ship.Update();
    }

    public void Draw()
    {
        _ship.Draw();
    }
}