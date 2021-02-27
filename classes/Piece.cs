using System;

public class Piece {
    protected string symbol;
    protected PieceColour colour;
  	protected int abs_vertical;
  	protected int abs_horizontal;
    protected int vertical;
    protected int horizontal;
    protected int xcoord;
    protected int ycoord;

    public Piece(PieceColour p)
    {
        colour = p;
    }

    public string getSymbol() {
        return symbol;
    }
    public void setSymbol(string s){
        symbol=s;
    }
     public PieceColour getColour(){
        return colour;
    }
    
    public void move(int newx, int newy)
    {
        xcoord = newx;
        ycoord = newy;
    }

    public virtual bool isLegitMove(int i0, int j0, int i1, int j1){
        abs_vertical = Math.Abs(i1 - i0); //get vert spaces moving
        abs_horizontal = Math.Abs(j1 - j0); //get horiz spaces moving
        vertical = i1 - i0; //get vert spaces and direction moving
        horizontal = j1 - j0; //get horiz spaces and direction moving
        return false;
    }
}