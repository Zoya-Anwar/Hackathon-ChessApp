public class Knight : Piece{
  public Knight(PieceColour p) : base(p)
  {
    if (p == PieceColour.BLACK)
        this.setSymbol("♞");
    else
        this.setSymbol("♘");
  }
  public override bool isLegitMove(int i0, int j0, int i1, int j1){
    base.isLegitMove(i0, j0, i1, j1);

    if ((abs_horizontal == 2 && abs_vertical == 1) || (abs_vertical == 2 & abs_horizontal == 1)){ 
       if ((Board.hasPiece(i1, j1) && (Board.getPiece(i1,j1).getColour() != this.getColour())) || Board.hasPiece(i1,j1) == false ){
            return true;
        }
    } 
    return false;
  }
}
