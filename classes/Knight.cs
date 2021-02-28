public class Knight : Piece{
  public Knight(PieceColour p, int id) : base(p)
  {
    this.id = id;
    if (p == PieceColour.BLACK)
        this.setSymbol("♞");
    else
        this.setSymbol("♘");
  }
  public override bool isLegitMove(int i0, int j0, int i1, int j1, Board board){
    base.isLegitMove(i0, j0, i1, j1, board);

    if ((abs_horizontal == 2 && abs_vertical == 1) || (abs_vertical == 2 & abs_horizontal == 1)){ 
       if ((board.hasPiece(i1, j1) && (board.getPiece(i1,j1).getColour() != this.getColour())) || board.hasPiece(i1,j1) == false ){
            return true;
        }
    } 
    return false;
  }
}
