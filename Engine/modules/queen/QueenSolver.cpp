#include "QueenSolver.h"

void QueenSolver::_bind_methods() {
	ClassDB::bind_method(D_METHOD("IsSafe", "row", "col", "board"),&QueenSolver::IsSafe);
}

QueenSolver::QueenSolver() {
}
Vector<int> QueenSolver::IsSafe(int row, int col, int board) {
	Vector<int> a;
	return a;
}
