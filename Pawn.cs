using Godot;
using System;

public class Pawn : Sprite
{
    private int id;
    private Pawn _childPawn;
    private GameBoard _board;
    int[] pos = new int[2];
    public int[] GridPos { get { return pos; } }


    public override void _Ready()
    {

    }

    public void Initialize(GameBoard board, int id, Vector2 pos)
    {
        this.id = id;
        this._board = board;
        Position = pos;
    }

    public void Move()
    {
        for (int i = 0; i < _board.BoardSize; i++)
        {

        }
    }
    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
