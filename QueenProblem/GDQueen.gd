extends QueenSolver


# Declare member variables here. Examples:
# var a = 2
# var b = "text"
var printed = false;

# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.

func _input(event):
	if event is InputEventKey and event.scancode == KEY_K and printed == false:
		SolveNPrint(10);
		printed = true;
	if event is InputEventKey and event.scancode == KEY_M:
		printed = false;
		#SolveNQueens(10);
		#print("pressed");

# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	if(InputEvent)
	
