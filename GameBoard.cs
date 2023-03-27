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
    [Export] private PackedScene pawn;
    [Export] private int size;
    private int[,] _placedPawns;
    private Pawn[] pawns;
    private Vector2 scale = Vector2.Zero;
    private Vector2 basePos = Vector2.Zero;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

        _placedPawns = new int[size, size];
        pawns = new Pawn[size];

        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                _placedPawns[x, y] = 0;
                var newTile = tile.Instance();

                TileColour tc = newTile as TileColour;
                tc.SetColour((x + y) % 2 == 1);

                if (scale == Vector2.Zero)
                {
                    scale = tc.GetTextureScale();
                    basePos = scale / 2;
                }

                Sprite newSprite = newTile as Sprite;
                newSprite.Position = new Vector2(x * scale.x, y * scale.y) + basePos;

                AddChild(newTile);
            }
        }
        InstantiatePawns();

    }
    private void InstantiatePawns()
    {
        for (int i = 0; i < size; i++)
        {
            Node newPawn = pawn.Instance();
            AddChild(newPawn);
            Pawn pawnScript = newPawn as Pawn;
            pawns[i] = pawnScript;
            pawnScript.Initialize(this, i, GetPosAt(0, i));

        }
    }

    public override void _Process(float delta)
    {
        //base._Process(delta);

    }

    private Vector2 GetPosAt(int x, int y)
    {
        return basePos + new Vector2(scale.x * x, scale.y * y);
    }
}
