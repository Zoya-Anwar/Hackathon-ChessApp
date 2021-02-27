using System;
public class Pawn : Piece{
	public Pawn(PieceColour p) : base(p)
	{
	if (p == PieceColour.BLACK)
		this.setSymbol("♟︎");
	else
		this.setSymbol("♙");
	}
	public override bool isLegitMove(int i0, int j0, int i1, int j1)
	{
		base.isLegitMove(i0, j0, i1, j1);

	//check pawn not moving in wrong direction 
        if ((((int)this.getColour() == 0) && vertical >= 0) || ((int)this.getColour() == 1 && vertical <= 0)) {
			if (abs_horizontal == 0 && Board.hasPiece(i1, j1) == false){ //check not moving horizontally and piece isn't in way
				if (i0 == 6 || i0 == 1){ //if in starting position, can move up to 2 squares
					if (abs_vertical == 1) 
					{ 
						return true; 
					}
					else if (vertical == 2 && Board.hasPiece(i0 + 1, j0))
                    {
						return true;
					}
					else if (vertical == 2 && Board.hasPiece(i0 - 1, j0))
                    {
						return true;
					}
					else
					{
						return false;
					}
				}
				else if (abs_vertical == 1) //if not in starting position, can move 1 square max
				{
						return true; 
				}
			}
			// If pawn takes a piece that is not the same colour as it let it take it 
			else if (abs_horizontal == 1 && abs_vertical == 1 && (Board.hasPiece(i1, j1) && (Board.getPiece(i1,j1).getColour() != this.getColour()))){
				return true;
			}
        }
		return false;
	}
}
