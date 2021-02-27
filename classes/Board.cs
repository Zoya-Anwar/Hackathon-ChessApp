using System;
public class Board
{
private static Square [,] board = new Square[8, 8];

	//This method should not be edited
	public static void initialiseBoard(){
		for (int i=0; i < board.GetLength(0); i++){
			for (int j=0; j < board.GetLength(1); j++)
					board[i, j]=new Square();
		}		
	}
    
	//This method requires your input	
	public static void initialisePieces(){
		//Black pieces
		Board.setPiece(0,0,new Rook(PieceColour.BLACK));
		Board.setPiece(0,1,new Knight(PieceColour.BLACK));
		Board.setPiece(0,2,new Bishop(PieceColour.BLACK));
		Board.setPiece(0,3,new Queen(PieceColour.BLACK));
		Board.setPiece(0,4,new King(PieceColour.BLACK));
		Board.setPiece(0,5,new Bishop(PieceColour.BLACK));
		Board.setPiece(0,6,new Knight(PieceColour.BLACK));
		Board.setPiece(0,7,new Rook(PieceColour.BLACK));
		Board.setPiece(1,0,new Pawn(PieceColour.BLACK));
		Board.setPiece(1,1,new Pawn(PieceColour.BLACK));
		Board.setPiece(1,2,new Pawn(PieceColour.BLACK));
		Board.setPiece(1,3,new Pawn(PieceColour.BLACK));
		Board.setPiece(1,4,new Pawn(PieceColour.BLACK));
		Board.setPiece(1,5,new Pawn(PieceColour.BLACK));
		Board.setPiece(1,6,new Pawn(PieceColour.BLACK));
		Board.setPiece(1,7,new Pawn(PieceColour.BLACK));

		//White pieces
		Board.setPiece(6,0,new Pawn(PieceColour.WHITE));
		Board.setPiece(6,1,new Pawn(PieceColour.WHITE));
		Board.setPiece(6,2,new Pawn(PieceColour.WHITE));
		Board.setPiece(6,3,new Pawn(PieceColour.WHITE));
		Board.setPiece(6,4,new Pawn(PieceColour.WHITE));
		Board.setPiece(6,5,new Pawn(PieceColour.WHITE));
		Board.setPiece(6,6,new Pawn(PieceColour.WHITE));
		Board.setPiece(6,7,new Pawn(PieceColour.WHITE));
		Board.setPiece(7,0,new Rook(PieceColour.WHITE));
		Board.setPiece(7,1,new Knight(PieceColour.WHITE));
		Board.setPiece(7,2,new Bishop(PieceColour.WHITE));
		Board.setPiece(7,3,new Queen(PieceColour.WHITE));
		Board.setPiece(7,4,new King(PieceColour.WHITE));
		Board.setPiece(7,5,new Bishop(PieceColour.WHITE));
		Board.setPiece(7,6,new Knight(PieceColour.WHITE));
		Board.setPiece(7,7,new Rook(PieceColour.WHITE));
	}
	
	//This method requires your input	
	public static void printBoard(){
        //Somehow pass it back to the razor page so it can be outputted
		Console.Write("\n  a b c d e f g h \n");
		Console.Write("  -----------------\n");		
		for (int i=0; i < board.GetLength(0); i++){
			int row=i+1;
				for (int j=0; j < board.GetLength(1); j++){
					if ((j==0) && Board.hasPiece(i,j))
                    {
						Console.Write(row+" "+Board.getPiece(i,j).getSymbol());	
                    }
					else if ((j==0) && !Board.hasPiece(i,j))
                    {
						Console.Write(row+"  " );
                    }
					else if (Board.hasPiece(i,j))		
                    {			
						Console.Write("|"+Board.getPiece(i,j).getSymbol());
                    }					
					else		
                    {			
						Console.Write("| ");	
                    }	
				}				
				Console.Write("  "+row+"\n");
		}
		Console.Write("  -----------------");
		Console.Write("\n  a b c d e f g h \n");	
	}
	
	//This method requires your input	
	public static bool movePiece(int i0, int j0, int i1, int j1, Piece p){
        board[i1, j1].setPiece(p);
		board[i0, j0].removePiece();
		return false;
	}

	//This method requires your input
	public static void setPiece(int iIn, int jIn, Piece p){
        board[iIn, jIn].setPiece(p);
	}
	
	//This method requires your input
	public static Piece getPiece(int iIn, int jIn){
		return board[iIn, jIn].getPiece();
	}
	
	//This method requires your input
	public static bool hasPiece(int i, int j){		
		return board[i, j].hasPiece();
	}
	public static bool isCheck(int i, int j, PieceColour p){
		//get king position
        //loop through all opp pieces and check if they have legit move to that king coordinate
        //if they can, then check is true

        //needs to be done after every piece is moved, to check whether move is valid i.e. whether putting own king in check
        //also can be used to notify opp that their king is in check after your move
        return false;
	}


}