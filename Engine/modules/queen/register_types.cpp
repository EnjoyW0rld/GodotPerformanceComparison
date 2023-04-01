#include "register_types.h"

#include "core/class_db.h"
#include "QueenSolver.h"

void register_queen_types() {
	ClassDB::register_class<QueenSolver>();
}
void unregister_queen_types() {
}
