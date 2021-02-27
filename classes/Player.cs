using System.Collections.Generic;

    public class Player
    {
        private List<Piece> pieces;
        private PieceColour colour;
        private bool lost = false;

        public Player(PieceColour c)
        {
            colour = c;
        }

        public void removePiece(Piece piece)
        {
            pieces.RemoveAt(pieces.IndexOf(piece));
        }

        public void movePiece(Piece piece, int newx, int newy)
        {
            pieces[pieces.IndexOf(piece)].move(newx, newy);
        }

        public void addPiece(int startx, int starty, Piece piece)
        {
            piece.move(startx, starty);
            pieces.Add(piece);
        }

        public Piece[] getPieces()
        {
            return pieces.ToArray();
        }

        public Piece getKing()
        {
            foreach(Piece piece in pieces)
            {
                if(piece.GetType() == typeof(King))
                {
                    return piece;
                }
            }
            return null;
        }

    }