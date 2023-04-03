#include "QueenSolver.h"

void QueenSolver::_bind_methods() {
	ClassDB::bind_method(D_METHOD("SolveNQueens", "n"), &QueenSolver::SolveNQueens);
}

QueenSolver::QueenSolver() {
}
bool QueenSolver::IsSafe(int row, int col, vector<vector<int>> &board) {
	for (int i = 0; i < board.size(); i++) {
		if (board[i][col] == 1)
			return false;
	}
	int i = row, j = col;
	while (i >= 0 && j >= 0)
		if (board[i--][j--] == 1)
			return false;
	i = row, j = col;
	while (i >= 0 && j < board.size())
		if (board[i--][j++] == 1)
			return false;
	return true;
}

void QueenSolver::Rec(vector<vector<int>> board, int row) {
	if (row == board.size()) {
		answer.push_back(board);
		return;
	}
	for (int i = 0; i < board.size(); i++) {
		// for each position check if it is safe and if it
		// safe make a recursive call with
		// row+1,board[i][j]='Q' and then revert the change
		// in board that is make the board[i][j]='.' again to
		// generate more solutions
		//auto ptr = board[0].p;
		if (IsSafe(row, i, board)) {
			//(&ptr[row][i]) = 1;
			//board[row][i] = 1;
			Rec(board, row + 1);
			//board[row][i] = 0;
		}
	}
	return;
}
//void QueenSolver::_ready() {
	//SolveNQueens(4);
//}

void QueenSolver::SolveNQueens(int n) {
	vector<int> newArr(n, 0);

	// vector of string will make our board which is
	// initially all empty
	//vector<vector<int>> board(n, newArr);
	vector<vector<int>> board;
	Rec(board, 0);

	
}
