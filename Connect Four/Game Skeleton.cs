namespace Connect_Four
{
    internal class GameSkeleton
    {
        private int[,] Board;
        private int[] TopIndex; // Used to determine where to place a disk in a column
        private int Player;
        private AI Player2;
        private System.Drawing.Point AIDisk;

        public GameSkeleton(bool TwoPlayers)
        {
            Board = new int[7, 7];
            TopIndex = new int[7];
            SetBoard();
            Player = 1;
            if (TwoPlayers == false)
            {
                Player2 = new AI(1, 2);
            }
        }

        public int Move(int x)
        {
            if (TopIndex[x] != 7) // Checks if the move's out of range, thus invalid
            {
                Board[x, TopIndex[x]] = Player;
                TopIndex[x]++;
            }
            else
            {
                return -2; // Not a value checked by the ColumnClicked procedure, therefore it counts it as invalid.
            }
            return WinCheck();
        }

        public int AIMove()
        {
            AIDisk = Player2.Move(ref Board, ref TopIndex); // Gets the AI Move and its disk position to update the board.
            TopIndex[AIDisk.X]++;
            return WinCheck();
        }

        public void SetBoard() // Puts board into default state
        {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    Board[x, y] = 0;
                }
                TopIndex[x] = 0;
            }
        }

        private int WinCheck()
        {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (NonDiagonalCheck(x, y) == 1) return 1;
                    if (DiagonalCheck(x, y) == 1) return 1;
                }
            }
            return TotalDisks() == 49 ? -1 : 0;
        }

        private int NonDiagonalCheck(int x, int y) // Checks vertically and horizontally for winning moves
        {
            if (x <= 3)
            {
                if (Board[x, y] == Player && Board[x + 1, y] == Player && Board[x + 2, y] == Player && Board[x + 3, y] == Player) return 1;
            }
            if (y >= 3)
            {
                if (Board[x, y] == Player && Board[x, y - 1] == Player && Board[x, y - 2] == Player && Board[x, y - 3] == Player) return 1;
            }
            return 0;
        }

        private int DiagonalCheck(int x, int y) // Checks diagonally for winning moves.
        {
            if (x <= 3 && y <= 3)
            {
                if (Board[x, y] == Player && Board[x + 1, y + 1] == Player && Board[x + 2, y + 2] == Player && Board[x + 3, y + 3] == Player)
                {
                    return 1;
                }
                if (Board[x, y + 3] == Player && Board[x + 1, y + 2] == Player && Board[x + 2, y + 1] == Player && Board[x + 3, y] == Player)
                {
                    return 1;
                }
            }
            return 0;
        }

        private int TotalDisks() // Used to determine a draw, this happens when 49 is returned.
        {
            int sum = 0;
            for (int i = 0; i < 7; i++)
            {
                sum += TopIndex[i];
            }
            return sum;
        }

        public void NextTurn()
        {
            if (Player == 1)
            {
                Player++;
            }
            else
            {
                Player--;
            }
        }

        public int GetPlayer
        {
            get { return Player; }
        }

        public int GetTop(int x)
        {
            return TopIndex[x];
        }

        public System.Drawing.Point GetAIPosition
        {
            get { return AIDisk; }
        }
    }
}