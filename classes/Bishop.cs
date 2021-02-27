using System;
public class Bishop : Piece{
  public Bishop(PieceColour p) : base(p)
  {
    if (p == PieceColour.BLACK) {
        this.setSymbol("♝");
    }
    else {
        this.setSymbol("♗");
    }

  }
   public override bool isLegitMove(int i0, int j0, int i1, int j1){
       	base.isLegitMove(i0, j0, i1, j1);
        
        if (horizontal == vertical && vertical>0){ //check diagonal 1
            for (int x=1; x < abs_vertical; x++){
                if (Board.hasPiece(i0+x,j0+x)){
                    return false;
                }
            }
            if (((Board.hasPiece(i1, j1) && (Board.getPiece(i1,j1).getColour() != this.getColour())) || Board.hasPiece(i1,j1) == false )){
                return true;
            }
        }
        else if ((-horizontal == vertical) && vertical>0){ //check diagonal 2
            for (int x=1; x < abs_vertical; x++){
                if (Board.hasPiece(i0+x,j0-x)){
                    return false;
                }
            }
            if (((Board.hasPiece(i1, j1) && (Board.getPiece(i1,j1).getColour() != this.getColour())) || Board.hasPiece(i1,j1) == false )){
                return true;
            }
        }
        else if ((horizontal == -vertical) && vertical<0){ //check diagonal 3
            for (int x=1; x < abs_horizontal; x++){
                if (Board.hasPiece(i0-x,j0+x)){
                    return false;
                }
            }
            if (((Board.hasPiece(i1, j1) && (Board.getPiece(i1,j1).getColour() != this.getColour())) || Board.hasPiece(i1,j1) == false )){
                return true;
            }
        }
         else if ((horizontal == vertical)&& vertical<0){ //check diagonal 4
            for (int x=1; x < abs_horizontal; x++){
                if (Board.hasPiece(i0-x,j0-x)){
                    return false;
                }
            }
            if (((Board.hasPiece(i1, j1) && (Board.getPiece(i1,j1).getColour() != this.getColour())) || Board.hasPiece(i1,j1) == false )){
                return true;
            }
        }
        return false;
    }
  }

