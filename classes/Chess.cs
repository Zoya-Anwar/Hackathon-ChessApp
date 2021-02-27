using System;

namespace Projects.Shared
{
public class Chess {
	private static bool gameEnd = false;

	public Chess()
	{

	}

	public void play(){
		while (!gameEnd){
		string origin, destination;
		Piece piece;
        Console.WriteLine("Enter origin:");
		origin = Console.ReadLine();
		Console.WriteLine("Enter destination:");
		destination = Console.ReadLine();
		if ((CheckInput.checkCoordinateValidity(origin) == true) && (CheckInput.checkCoordinateValidity(destination) == true))
		{
				int i0 = origin[0] - 49;
				int j0 = origin[1] - 97;
				int i1 = destination[0] - 49;
				int j1 = destination[1] - 97;
				piece = Board.getPiece(i0, j0);
				if (piece.isLegitMove(i0,j0,i1,j1) && !Board.isCheck(1, 1, PieceColour.BLACK)) {
					Board.movePiece(i0, j0, i1, j1, Board.getPiece(i0, j0));
					Board.printBoard();
				}
		}
		else 
		{ 
			Console.WriteLine("\nTry again!\n");
		}      
      }
	}


	public void main()
    {
		Board.initialiseBoard();
		Board.initialisePieces();
		Board.printBoard();
		this.play();	
    }
}
}