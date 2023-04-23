#ifndef QUEENSOLVER_H
#define QUEENSOLVER_H

#include "scene/main/node.h"
#include <vector>
#include <string.h>
#include <sstream>
#include "scene/2d/sprite.h"

using namespace std;

class QueenSolver : public Node {
	GDCLASS(QueenSolver, Node);

private:
	bool IsSafe(int row, int col, vector<vector<int>>& board);
	void Rec(vector<vector<int>> board,int row);

	vector<vector<vector<int>>> answer;

protected:
	static void _bind_methods();
	void _notification(int p_notification);

public:
	void _ready();
	void SolveNPrint(int n);
	QueenSolver();
	void SolveNQueens(int n);
};

#endif // !QUEENSOLVER_H
