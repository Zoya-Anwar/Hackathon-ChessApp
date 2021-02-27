public class Square {
	private bool piece;
	private Piece p;
	public bool hasPiece(){
		return piece;
	}
	public void setPiece(Piece pIn){
		p=pIn;
		piece = true;
	}
	public Piece getPiece(){
		return p;
	}
	public void removePiece(){
		piece = false;
	}
}
