using System;

public class King : Piece{
	public King(PieceColour p) : base(p)
    {
    
	if (p == PieceColour.BLACK)
		this.setSymbol("♚");
	else
		this.setSymbol("♔");
	}
	public override bool isLegitMove(int i0, int j0, int i1, int j1){
        base.isLegitMove(i0, j0, i1, j1);
        if(abs_horizontal + abs_vertical <= 2 && (Board.hasPiece(i1, j1) == false || Board.hasPiece(i1, j1) && Board.getPiece(i1, j1).getColour() != colour))
		{
			return true;
		}
		return false;
	}
}
