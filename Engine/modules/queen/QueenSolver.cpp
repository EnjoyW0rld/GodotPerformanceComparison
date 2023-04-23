#include "QueenSolver.h"

void QueenSolver::_bind_methods() {
	ClassDB::bind_method(D_METHOD("SolveNQueens", "n"), &QueenSolver::SolveNQueens);
	ClassDB::bind_method(D_METHOD("SolveNPrint", "n"), &QueenSolver::SolveNPrint);
	ClassDB::bind_method(D_METHOD("_ready"), &QueenSolver::_ready);
	ClassDB::bind_method(D_METHOD("_notification", "p_notification"), &QueenSolver::_notification);
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

		if (IsSafe(row, i, board)) {
			board[row][i] = 1;
			Rec(board, row + 1);
			board[row][i] = 0;
		}
	}
	return;
}
void QueenSolver::SolveNPrint(int n) {
	clock_t start, end;

	start = clock();
	SolveNQueens(n);
	end = clock();

	double time_taken = double(end - start) / double(CLOCKS_PER_SEC);
	//notification()
	ostringstream s;
	s << time_taken;
	string str = s.str();
	const char *rr = str.c_str();
	String ss = rr; //String::copy_from(rr);

	//print_line();
	print_line(ss);
}

void QueenSolver::_ready() {

	//float f = 3/ 0;
	//set_process(true);
	for (int i = 1; i <= 13; i++) {
		clock_t start, end;

		start = clock();
		SolveNQueens(i);
		end = clock();

		double time_taken = double(end - start) / double(CLOCKS_PER_SEC);
		//notification()
		ostringstream s;
		s << time_taken;
		string str = s.str();
		const char *rr = str.c_str();
		String ss = rr; //String::copy_from(rr);

		//print_line();
		print_line(ss);

	}
	//Godot::print()
}
void QueenSolver::_notification(int p_notification) {
	switch (p_notification) {
		case NOTIFICATION_PROCESS:
			print_line("process");
			break;
		case NOTIFICATION_ENTER_TREE:
			print_line("entered tree");
			//_ready();
			break;
		case NOTIFICATION_INSTANCED:
			print_line("instanced");
			break;
	}
	Node::_notification(p_notification);
}


void QueenSolver::SolveNQueens(int n) {
	/*
	Vector<int> newArr;
	newArr.resize(n);
	newArr.fill(0);
	Vector<Vector<int>> board; //(n, newArr);
	board.resize(n);
	board.fill(newArr);
	*/
	print_line("started solving");
	vector<int> newArr(n, 0);
	vector<vector<int>> board (n, newArr);
	Rec(board, 0);
}
