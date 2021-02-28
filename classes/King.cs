using System;

public class King : Piece{
	public King(PieceColour p) : base(p)
    {
    
	if (p == PieceColour.BLACK)
		this.setSymbol("♚");
	else
		this.setSymbol("♔");
	}
	public override bool isLegitMove(int i0, int j0, int i1, int j1, Board board){
        base.isLegitMove(i0, j0, i1, j1, board);
        if(abs_horizontal + abs_vertical <= 2 && (board.hasPiece(i1, j1) == false || board.hasPiece(i1, j1) && board.getPiece(i1, j1).getColour() != colour))
		{
			return true;
		}
		return false;
	}
}
