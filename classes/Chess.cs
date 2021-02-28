using System;
using System.Runtime;

namespace Projects.Shared
{
public class Chess {
	private static bool gameEnd = false;
	private bool turn = false;
	private Board board = new Board();

	public Chess()
	{

	}

	public int play(string origin, string destination){
		Piece piece;
		origin = origin.Trim(' ').ToLower();
		destination = destination.Trim(' ').ToLower();
				int j0 = origin[0] - 97;
				int i0 = origin[1] - 49;
				int j1 = destination[0] - 97;
				int i1 = destination[1] - 49;
				piece = board.getPiece(i0, j0);
				switch (piece.GetType().ToString())
				{
					case "King":
						piece = (King)piece;
						break;
					case "Pawn":
						piece = (Pawn)piece;
						break;
					case "Bishop":
						piece = (Bishop)piece;
						break;
					case "Knight":
						piece = (Knight)piece;
						break;
					case "Queen":
						piece = (Queen)piece;
						break;
					case "Rook":
						piece = (Rook)piece;
						break;
				}
				if(!CheckInput.checkCoordinateValidity(origin) || !CheckInput.checkCoordinateValidity(destination))
				{
					return 1;
				}
				if (piece.isLegitMove(i0,j0,i1,j1, board)) {
					if(board.isCheck(i1, j1, piece, (PieceColour)Convert.ToInt32(turn)))
					{
						//moving piece will check own king, or will not stop a current check
						return 2;
					}
					else if(board.isCheck(i1, j1, piece, (PieceColour)Convert.ToInt32(!turn)))
					{
						//moving piece will check other king
						board.movePiece(i0, j0, i1, j1, board.getPiece(i0, j0));
						turn = !turn;
						board.printBoard();
						return 3;
					}
					else
					{
						board.movePiece(i0, j0, i1, j1, board.getPiece(i0, j0));
						turn = !turn;
						board.printBoard();
						return 0;
					}
				}
        board.printBoard();
		return 1;    
	}

	public Square[,] getBoard()
	{
		return board.getBoard();
	}

	public void main()
    {
		board.initialiseBoard();
		board.initialisePlayers();
		board.initialisePieces();
		board.printBoard();
    }
}
}