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

    public int BoardSize { get { return size; } }

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

        //_placedPawns[0, 1] = 1;
        //_placedPawns[1, 3] = 1;
        //_placedPawns[2, 0] = 1;
        //_placedPawns[3, 2] = 1;
        //GD.Print(IsSolved());
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
            _placedPawns[0, i] = 1;

        }
    }

    private void MovePawn()
    {
        for (int i = 0; i < size; i++)
        {


            //pawns[0].Position = GetPosAt(0, i);
        }
        //pawns[0].Move();
    }

    public override void _Process(float delta)
    {
        //base._Process(delta);
        if (Input.IsKeyPressed((int)KeyList.G))
        {
            GD.Print(IsSolved());
        }
    }

    private Vector2 GetPosAt(int x, int y)
    {
        return basePos + new Vector2(scale.x * x, scale.y * y);
    }

    private bool IsSolved()
    {
        for (int i = 0; i < size; i++)
        {
            int[] gridPos = pawns[i].GridPos;
            if (CheckVertical(gridPos)
                && CheckDiagonal(gridPos)
                && CheckDiagonal(gridPos, 1)) continue;

            return false;
        }
        return true;
    }
    /// <summary>
    /// Put 1 in yOffset to mirror the check diagonal
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="yOffset"></param>
    /// <returns></returns>
    private bool CheckDiagonal(int[] pos, int yOffset = -1)
    {
        int[] currentPos = pos;
        currentPos[0]--;
        currentPos[1] += yOffset;

        while (currentPos[0] >= 0 && currentPos[1] >= 0)
        {
            if (_placedPawns[currentPos[0], currentPos[1]] != 0)
            {
                return false;
            }
            currentPos[0]--;
            currentPos[1] += yOffset;
        }

        currentPos = pos;
        currentPos[0]++;
        currentPos[1] -= yOffset;

        while (currentPos[0] < size && currentPos[1] < size)
        {
            if (_placedPawns[currentPos[0], currentPos[1]] != 0)
            {
                return false;
            }
            currentPos[0]++;
            currentPos[1] -= yOffset;
        }

        return true;
    }
    private bool CheckVertical(int[] pos)
    {
        bool foundOrigin = false;
        for (int y = 0; y < size; y++)
        {
            if (_placedPawns[pos[0], y] != 0)
            {
                if (foundOrigin) return false;
                else foundOrigin = true;
            }
        }
        return true;
    }
}
