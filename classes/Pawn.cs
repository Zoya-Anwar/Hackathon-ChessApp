using System;
public class Pawn : Piece{
	public Pawn(PieceColour p, int id) : base(p)
	{
		this.id = id;
	if (p == PieceColour.BLACK)
		this.setSymbol("♟︎");
	else
		this.setSymbol("♙");
	}
	public override bool isLegitMove(int i0, int j0, int i1, int j1, Board board)
	{
		base.isLegitMove(i0, j0, i1, j1, board);

	//check pawn not moving in wrong direction 
        if ((((int)this.getColour() == 1) && vertical >= 0) || ((int)this.getColour() == 0 && vertical <= 0)) {
			if (abs_horizontal == 0 && board.hasPiece(i1, j1) == false){ //check not moving horizontally and piece isn't in way
				if (i0 == 6 || i0 == 1){ //if in starting position, can move up to 2 squares
					if((abs_vertical == 2) && (board.hasPiece(i0 + vertical/2, j0) == false))
                    {
						return true;
					}
				}
				if (abs_vertical == 1) //if not in starting position, can move 1 square max
				{
						return true;
				}
			}
			// If pawn takes a piece that is not the same colour as it let it take it 
			else if (abs_horizontal == 1 && abs_vertical == 1 && (board.hasPiece(i1, j1) && (board.getPiece(i1,j1).getColour() != this.getColour()))){
				return true;
			}
        }
		return false;
	}
}
