using Godot;
using System;
using System.Collections.Generic;
using System.Diagnostics;

public class GameBoard : Node
{
    [Export] private int size;

    public int BoardSize { get { return size; } }



    bool done = false;
    public override void _Process(float delta)
    {
        if (Input.IsKeyPressed((int)KeyList.G) && !done)
        {
            done = true;
                answer = new List<List<int[]>>();
                var w = System.Diagnostics.Stopwatch.StartNew();
                SolveNQueens(size);
                w.Stop();

                GD.Print(w.ElapsedMilliseconds + " Time");

        }
    }


    private List<List<int[]>> answer;

    private void Rec(List<int[]> board, int row)
    {
        if (row == board.Count)
        {
            answer.Add(new List<int[]>(board));
            return;
        }
        for (int i = 0; i < board.Count; i++)
        {
            //Checking if position is safe and making recursive call
            if (Safe(row, i, board))
            {
                int[] rowArr = board[row].Clone() as int[];
                rowArr[i] = 1;
                board[row] = rowArr;
                Rec(board, row + 1);
                rowArr[i] = 0;
                board[row] = rowArr;
            }
        }
    }
    private List<List<int[]>> SolveNQueens(int n)
    {
        int[] row = new int[n];
        for (int i = 0; i < n; i++)
        {
            row[i] = 0;
        }
        List<int[]> board = new List<int[]>();
        for (int i = 0; i < n; i++)
            board.Add(row);
        Rec(board, 0);
        return answer;
    }
    private bool Safe(int row, int col, List<int[]> board)
    {
        //Check in the same columt
        for (int i = 0; i < board.Count; i++)
        {
            if (board[i][col] == 1)
                return false;
        }
        int x = row, y = col;
        //Check diagonal to the top left
        while (x >= 0 && y >= 0)
            if (board[x--][y--] == 1)
                return false;
        x = row; y = col;
        //Check diagonal to the top right
        while (x >= 0 && y < board.Count)
            if (board[x--][y++] == 1)
                return false;
        return true;
    }
}
