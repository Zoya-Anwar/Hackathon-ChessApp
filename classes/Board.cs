using System;


public class Board
{
private Square [,] board = new Square[8, 8];
private Player player1;
private Player player2;

	//This method should not be edited
	public void initialiseBoard(){
		for (int i=0; i < board.GetLength(0); i++){
			for (int j=0; j < board.GetLength(1); j++)
					board[i, j]=new Square();
		}		
	}
    
	public void initialisePlayers()
	{
		player1 =  new Player(PieceColour.BLACK);
		player2 =  new Player(PieceColour.WHITE);
	}

	//This method requires your input	
	public void initialisePieces(){

		//Black pieces
		setPiece(0,0,new Rook(PieceColour.BLACK, 1));
		setPiece(0,1,new Knight(PieceColour.BLACK, 2));
		setPiece(0,2,new Bishop(PieceColour.BLACK, 3));
		setPiece(0,3,new Queen(PieceColour.BLACK, 4));
		setPiece(0,4,new King(PieceColour.BLACK, 5));
		setPiece(0,5,new Bishop(PieceColour.BLACK, 6));
		setPiece(0,6,new Knight(PieceColour.BLACK, 7));
		setPiece(0,7,new Rook(PieceColour.BLACK, 8));
		setPiece(1,0,new Pawn(PieceColour.BLACK, 9));
		setPiece(1,1,new Pawn(PieceColour.BLACK, 10));
		setPiece(1,2,new Pawn(PieceColour.BLACK, 11));
		setPiece(1,3,new Pawn(PieceColour.BLACK, 12));
		setPiece(1,4,new Pawn(PieceColour.BLACK, 13));
		setPiece(1,5,new Pawn(PieceColour.BLACK, 14));
		setPiece(1,6,new Pawn(PieceColour.BLACK, 15));
		setPiece(1,7,new Pawn(PieceColour.BLACK, 16));

		player2.addPiece(0,0,new Rook(PieceColour.BLACK, 1));
		player2.addPiece(0,1,new Knight(PieceColour.BLACK, 2));
		player2.addPiece(0,2,new Bishop(PieceColour.BLACK, 3));
		player2.addPiece(0,3,new Queen(PieceColour.BLACK, 4));
		player2.addPiece(0,4,new King(PieceColour.BLACK, 5));
		player2.addPiece(0,5,new Bishop(PieceColour.BLACK, 6));
		player2.addPiece(0,6,new Knight(PieceColour.BLACK, 7));
		player2.addPiece(0,7,new Rook(PieceColour.BLACK, 8));
		player2.addPiece(1,0,new Pawn(PieceColour.BLACK, 9));
		player2.addPiece(1,1,new Pawn(PieceColour.BLACK, 10));
		player2.addPiece(1,2,new Pawn(PieceColour.BLACK, 11));
		player2.addPiece(1,3,new Pawn(PieceColour.BLACK, 12));
		player2.addPiece(1,4,new Pawn(PieceColour.BLACK, 13));
		player2.addPiece(1,5,new Pawn(PieceColour.BLACK, 14));
		player2.addPiece(1,6,new Pawn(PieceColour.BLACK, 15));
		player2.addPiece(1,7,new Pawn(PieceColour.BLACK, 16));

		//White pieces
		setPiece(6,0,new Pawn(PieceColour.WHITE, 1));
		setPiece(6,1,new Pawn(PieceColour.WHITE, 2));
		setPiece(6,2,new Pawn(PieceColour.WHITE, 3));
		setPiece(6,3,new Pawn(PieceColour.WHITE, 4));
		setPiece(6,4,new Pawn(PieceColour.WHITE, 5));
		setPiece(6,5,new Pawn(PieceColour.WHITE, 6));
		setPiece(6,6,new Pawn(PieceColour.WHITE, 7));
		setPiece(6,7,new Pawn(PieceColour.WHITE, 8));
		setPiece(7,0,new Rook(PieceColour.WHITE, 9));
		setPiece(7,1,new Knight(PieceColour.WHITE, 10));
		setPiece(7,2,new Bishop(PieceColour.WHITE, 11));
		setPiece(7,3,new Queen(PieceColour.WHITE, 12));
		setPiece(7,4,new King(PieceColour.WHITE, 13));
		setPiece(7,5,new Bishop(PieceColour.WHITE, 14));
		setPiece(7,6,new Knight(PieceColour.WHITE, 15));
		setPiece(7,7,new Rook(PieceColour.WHITE, 16));

		player1.addPiece(6,0,new Pawn(PieceColour.WHITE, 1));
		player1.addPiece(6,1,new Pawn(PieceColour.WHITE, 2));
		player1.addPiece(6,2,new Pawn(PieceColour.WHITE, 3));
		player1.addPiece(6,3,new Pawn(PieceColour.WHITE, 4));
		player1.addPiece(6,4,new Pawn(PieceColour.WHITE, 5));
		player1.addPiece(6,5,new Pawn(PieceColour.WHITE, 6));
		player1.addPiece(6,6,new Pawn(PieceColour.WHITE, 7));
		player1.addPiece(6,7,new Pawn(PieceColour.WHITE, 8));
		player1.addPiece(7,0,new Rook(PieceColour.WHITE, 9));
		player1.addPiece(7,1,new Knight(PieceColour.WHITE, 10));
		player1.addPiece(7,2,new Bishop(PieceColour.WHITE, 11));
		player1.addPiece(7,3,new Queen(PieceColour.WHITE, 12));
		player1.addPiece(7,4,new King(PieceColour.WHITE, 13));
		player1.addPiece(7,5,new Bishop(PieceColour.WHITE, 14));
		player1.addPiece(7,6,new Knight(PieceColour.WHITE, 15));
		player1.addPiece(7,7,new Rook(PieceColour.WHITE, 16));
	}
	
	//This method requires your input	
	public void printBoard(){
        //Somehow pass it back to the razor page so it can be outputted
		Console.Write("\n  a b c d e f g h \n");
		Console.Write("  -----------------\n");		
		for (int i=0; i < board.GetLength(0); i++){
			int row=i+1;
				for (int j=0; j < board.GetLength(1); j++){
					if ((j==0) && hasPiece(i,j))
                    {
						Console.Write(row+" "+getPiece(i,j).getSymbol());	
                    }
					else if ((j==0) && !hasPiece(i,j))
                    {
						Console.Write(row+"  " );
                    }
					else if (hasPiece(i,j))		
                    {			
						Console.Write("|"+getPiece(i,j).getSymbol());
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

	public Square[,] getBoard()
	{
		return board;
	}
	
	//This method requires your input	
	public bool movePiece(int i0, int j0, int i1, int j1, Piece p)
	{
		Piece[] pieces;
		PieceColour pc = p.getColour();
		if(pc == 0)
		{
			pieces = player1.getPieces();
			foreach (var playerPiece in pieces)
			{
				if(playerPiece.getx() == j0 && playerPiece.gety() == i0)
				{
					player1.movePiece(playerPiece, j1, i1);
				}
				break;
			}
			pieces = player2.getPieces();
			foreach (var playerPiece in pieces)
			{
				if(playerPiece.getx() == j1 && playerPiece.gety() == i1)
				{
					player2.removePiece(playerPiece);
				}
				break;
			}
		}
		else
		{
			pieces = player2.getPieces();
			foreach (var playerPiece in pieces)
			{
				if(playerPiece.getx() == j0 && playerPiece.gety() == i0)
				{
					player2.movePiece(playerPiece, j1, i1);
				}
				break;
			}
			pieces = player1.getPieces();
			foreach (var playerPiece in pieces)
			{
				if(playerPiece.getx() == j1 && playerPiece.gety() == i1)
				{
					player1.removePiece(playerPiece);
				}
				break;
			}
		}
        board[i1, j1].setPiece(p);
		board[i0, j0].removePiece();
		return false;
	}

	//This method requires your input
	public void setPiece(int iIn, int jIn, Piece p){
        board[iIn, jIn].setPiece(p);
	}
	
	//This method requires your input
	public Piece getPiece(int iIn, int jIn){
		return board[iIn, jIn].getPiece();
	}
	
	//This method requires your input
	public bool hasPiece(int i, int j){		
		return board[i, j].hasPiece();
	}
	public bool isCheck(int i, int j, Piece moving, PieceColour p){
		int oldx = moving.getx();
		int oldy = moving.gety();
		King tempKing;
		Piece saved = null;
		bool incheck = false;
		Console.WriteLine(p.ToString());
		if((int)p == 0)
		{
			if(moving.getColour() == p)
			{
				player1.movePiece(moving, j, i);
				if(hasPiece(i, j))
				{
					saved = getPiece(i, j);
				}
				movePiece(oldy, oldx, i, j, moving);
			}
			else
			{
				player2.movePiece(moving, j, i);
				if(hasPiece(i, j))
				{
					saved = getPiece(i, j);
				}
				movePiece(oldy, oldx, i, j, moving);
			}
			Console.WriteLine("Got to start!");
			tempKing = player1.getKing();
			Piece[] playerPieces = player2.getPieces();
			foreach(Piece playerPiece in playerPieces)
			{
				if(!(playerPiece.getx() == j && playerPiece.gety() == i))
				{
					if(playerPiece.isLegitMove(playerPiece.gety(),playerPiece.getx(),tempKing.gety(),tempKing.getx(),this))
					{
						incheck = true;
						Console.WriteLine("In Check!");
						break;
					}
				}
			}
			Console.WriteLine("Passed!");
			if(moving.getColour() == p)
			{
				player1.movePiece(moving, oldx, oldy);
				if(saved != null)
				{
					movePiece(i, j, oldy, oldx, moving);
					setPiece(i, j, saved);
				}
			}
			else
			{
				player2.movePiece(moving, oldx, oldy);
				if(saved != null)
				{
					movePiece(i, j, oldy, oldx, moving);
					setPiece(i, j, saved);
				}
			}
			return incheck;
		}
		else if((int)p == 1)
		{
			if(moving.getColour() == p)
			{
				player2.movePiece(moving, j, i);
				if(hasPiece(i, j))
				{
					saved = getPiece(i, j);
				}
				movePiece(oldy, oldx, i, j, moving);
			}
			else
			{
				player1.movePiece(moving, j, i);
				if(hasPiece(i, j))
				{
					saved = getPiece(i, j);
				}
				movePiece(oldy, oldx, i, j, moving);
			}
			Console.WriteLine("Got to start!");
			tempKing = player2.getKing();
			Piece[] playerPieces = player1.getPieces();
			foreach(Piece playerPiece in playerPieces)
			{
				if(!(playerPiece.getx() == j && playerPiece.gety() == i))
					{
					if(playerPiece.isLegitMove(playerPiece.gety(),playerPiece.getx(),tempKing.gety(),tempKing.getx(),this))
					{
						incheck = true;
						Console.WriteLine("In Check!");
						break;
					}
				}
			}
			Console.WriteLine("Passed!");
			if(moving.getColour() == p)
			{
				player2.movePiece(moving, oldx, oldy);
				if(saved != null)
				{
					movePiece(i, j, oldy, oldx, moving);
					setPiece(i, j, saved);
				}
			}
			else
			{
				player1.movePiece(moving, oldx, oldy);
				if(saved != null)
				{
					movePiece(i, j, oldy, oldx, moving);
					setPiece(i, j, saved);
				}
			}
			return incheck;
		}
		return incheck;

		//get king position

        //loop through all opp pieces and check if they have legit move to that king coordinate
        //if they can, then check is true

        //needs to be done after every piece is moved, to check whether move is valid i.e. whether putting own king in check
        //also can be used to notify opp that their king is in check after your move
	}

}