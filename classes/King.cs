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
        
        
		return true;
	}
}
