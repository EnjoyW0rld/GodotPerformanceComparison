using Godot;
using System;

public class TileColour : Sprite
{
    [Export] private Texture blackTile;
    [Export] private Texture whiteTile;
    
    public void SetColour(bool isBlack)
    {
        Texture = isBlack ? blackTile : whiteTile;
    }
    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
