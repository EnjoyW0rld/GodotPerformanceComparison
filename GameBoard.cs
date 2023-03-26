using Godot;
using System;

public class GameBoard : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    //[Export] private Sprite[] sprites;
    //[Export] private Sprite sprite;
    [Export] private PackedScene tile;
    [Export] private int size;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                var newTile = tile.Instance();
                Sprite newSprite = newTile as Sprite;
                newSprite.Position = new Vector2(x * 100, y * 100);
                TileColour tc = newTile as TileColour;
                tc.SetColour((x + y) % 2 == 1);
                //newSprite.GlobalScale()
                AddChild(newTile);
            }
        }

        //var scene = GD.Load<PackedScene>
        //newSprite.Position = new Vector2(100, 100);
        //GD.Print(newSprite);
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
