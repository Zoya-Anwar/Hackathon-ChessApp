using System;
public class Queen : Piece
{
  public Queen(PieceColour p, int id) : base(p)
  {
    this.id = id;
  if (p == PieceColour.BLACK)
    this.setSymbol("♛");
  else
    this.setSymbol("♕");
  }
  public override bool isLegitMove(int i0, int j0, int i1, int j1, Board board){

    if (new Bishop(colour, 0).isLegitMove(i0, j0, i1, j1, board) || new Rook(colour, 0).isLegitMove(i0, j0, i1, j1, board)) //check bishop or rook isLegitMove
    {
        return true;
    }
    return false;
  }
}

