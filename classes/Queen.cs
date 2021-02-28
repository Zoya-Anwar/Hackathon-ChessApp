using System;
public class Queen : Piece
{
  public Queen(PieceColour p) : base(p)
  {
  if (p == PieceColour.BLACK)
    this.setSymbol("♛");
  else
    this.setSymbol("♕");
  }
  public override bool isLegitMove(int i0, int j0, int i1, int j1, Board board){

    if (new Bishop(colour).isLegitMove(i0, j0, i1, j1, board) || new Rook(colour).isLegitMove(i0, j0, i1, j1, board)) //check bishop or rook isLegitMove
    {
      Console.WriteLine((new Bishop(colour).isLegitMove(i0, j0, i1, j1, board)).ToString() + (new Rook(colour).isLegitMove(i0, j0, i1, j1, board)).ToString());
        return true;
    }
    return false;
  }
}

