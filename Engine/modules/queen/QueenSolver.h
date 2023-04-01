#ifndef QUEENSOLVER_H
#define QUEENSOLVER_H

#include "core/reference.h"
#include "../../core/list.h"

class QueenSolver : public Reference {
private:
	Vector<int> IsSafe(int row, int col, int board);
	Vector<Vector<int>> ints;

protected:
	static void _bind_methods();

public:
	QueenSolver();

};

#endif // !QUEENSOLVER_H
