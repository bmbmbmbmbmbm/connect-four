using System;
using System.Collections.Generic;
using System.Drawing;

namespace Connect_Four
{
    internal class AI
    {
        private int OppNo;
        private int AiNo;
        private Random ColumnRange;

        public AI(int OppValue, int AiValue)
        {
            OppNo = OppValue;
            AiNo = AiValue;
            ColumnRange = new Random();
        }
        /// <summary>
        /// Makes the A.I take its turn.
        /// </summary>
        /// <param name="Board"></param>
        /// <param name="Lengths"></param>
        /// <returns>The A.I Disk Position</returns>
        public Point Move(ref int[,] Board, ref int[] Lengths)
        {
            List<Combination> PotentialCombos = new List<Combination>();
            int SubListBound = 0;
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    // Checks for combinations belonging to player or A.I
                    if (Board[x, y] == 1)
                    {
                        int CurrentLength = XLength(ref Board, x, y, OppNo);
                        WorthAdding(ref PotentialCombos, CurrentLength, 0, 1, x, y, OppNo);

                        CurrentLength = YLength(ref Board, x, y, OppNo);
                        WorthAdding(ref PotentialCombos, CurrentLength, 1, 0, x, y, OppNo);

                        CurrentLength = PosGradLineLength(ref Board, x, y, OppNo);
                        WorthAdding(ref PotentialCombos, CurrentLength, 1, 1, x, y, OppNo);

                        CurrentLength = NegGradLineLength(ref Board, x, y, OppNo);
                        WorthAdding(ref PotentialCombos, CurrentLength, -1, 1, x, y, OppNo);
                    }
                    else if (Board[x, y] == 2)
                    {
                        int CurrentLength = XLength(ref Board, x, y, AiNo);
                        WorthAdding(ref PotentialCombos, CurrentLength, 0, 1, x, y, AiNo);

                        CurrentLength = YLength(ref Board, x, y, AiNo);
                        WorthAdding(ref PotentialCombos, CurrentLength, 1, 0, x, y, AiNo);

                        CurrentLength = PosGradLineLength(ref Board, x, y, AiNo);
                        WorthAdding(ref PotentialCombos, CurrentLength, 1, 1, x, y, AiNo);

                        CurrentLength = NegGradLineLength(ref Board, x, y, AiNo);
                        WorthAdding(ref PotentialCombos, CurrentLength, -1, 1, x, y, AiNo);
                    }
                    // Sorts combinations by length priority and then disk priority length three combinations
                    PotentialCombos = InsertionSortByLength(PotentialCombos, ref SubListBound);
                    if (PotentialCombos.Count > SubListBound)
                    {
                        switch (PotentialCombos[SubListBound].GetLength)
                        {
                            case 3:
                                PotentialCombos = InsertionSortByDisk(PotentialCombos, SubListBound);
                                break;

                            default:
                                PotentialCombos = InsertionSortByDisk(PotentialCombos, SubListBound - 1);
                                break;
                        }
                    }
                }
            }
            // Iterates through list for valid combinations.
            for (int i = 0; i < PotentialCombos.Count; i++)
            {
                // Gets first end of combination
                int X = PotentialCombos[i].StartsFrom.X + (PotentialCombos[i].GetLength * PotentialCombos[i].Gradient()[0]);
                int Y = PotentialCombos[i].StartsFrom.Y + (PotentialCombos[i].GetLength * PotentialCombos[i].Gradient()[1]);
                for (int k = 0; k < 2; k++)
                {
                    if (X < 7 && X > -1 && Y < 7 && Y > -1)
                    {
                        if (Board[X, Y] == 0 && Lengths[X] - Y == 0 && Lengths[X] < 7)
                        {
                            Board[X, Y] = AiNo;
                            return new Point(X, Y);
                        }
                    }
                    // Gets second end of combination
                    X = PotentialCombos[i].StartsFrom.X - PotentialCombos[i].Gradient()[0];
                    Y = PotentialCombos[i].StartsFrom.Y - PotentialCombos[i].Gradient()[1];
                }
            }
            // Default move if no combination was valid
            return RandomMove(ref Lengths, ref Board);
        }

        // Finds horizontal combinations
        private int XLength(ref int[,] Board, int x, int y, int Player)
        {
            if (x < 7 && Board[x, y] == OppNo)
            {
                return 1 + XLength(ref Board, x + 1, y, Player);
            }
            return 0;
        }

        // Finds vertical combinations
        private int YLength(ref int[,] Board, int x, int y, int Player)
        {
            if (y < 7 && Board[x, y] == OppNo)
            {
                return 1 + YLength(ref Board, x, y + 1, Player);
            }
            return 0;
        }

        // Finds diagonal combinations with a positive gradient
        private int PosGradLineLength(ref int[,] Board, int x, int y, int Player)
        {
            if (y < 7 && x < 7 && Board[x, y] == OppNo)
            {
                return 1 + PosGradLineLength(ref Board, x + 1, y + 1, Player);
            }
            return 0;
        }

        // Finds diagonal combinations with a negative gradient
        private int NegGradLineLength(ref int[,] Board, int x, int y, int Player)
        {
            if (y > -1 && x < 7 && Board[x, y] == OppNo)
            {
                return 1 + NegGradLineLength(ref Board, x + 1, y - 1, Player);
            }
            return 0;
        }

        private void WorthAdding(ref List<Combination> PotentialCombos, int Length, int dY, int dX, int x, int y, int Player)
        {
            if (Length > 1)
            {
                PotentialCombos.Add(new Combination(new Point(x, y), Length, dX, dY, Player));
            }
        }

        /// <summary>
        /// Forces A.I to make a move if there are no valid combinations
        /// </summary>
        /// <param name="Lengths"></param>
        /// <param name="Board"></param>
        /// <returns>Returns point where A.I placed a disk</returns>
        private Point RandomMove(ref int[] Lengths, ref int[,] Board)
        {
            int X = ColumnRange.Next(0, 6);
            while (Lengths[X] == 7)
            {
                X = ColumnRange.Next(0, 6);
            }
            Board[X, Lengths[X]] = 2;
            return new Point(X, Lengths[X]);
        }

        /// <summary>
        /// Sorts combinations by length
        /// </summary>
        /// <param name="SortMe"></param>
        /// <param name="Length"></param>
        /// <returns>Returns sorted combinations by length</returns>
        private List<Combination> InsertionSortByLength(List<Combination> SortMe, ref int Length)
        {
            for (int i = 0; i < SortMe.Count - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (SortMe[j - 1].GetLength < SortMe[j].GetLength)
                    {
                        Combination temp = SortMe[j - 1];
                        SortMe[j - 1] = SortMe[j];
                        SortMe[j] = temp;
                        Length = j;
                    }
                    j--;
                }
            }
            return SortMe;
        }

        /// <summary>
        /// Sorts length three combinations by disk
        /// </summary>
        /// <param name="SortMe"></param>
        /// <param name="Length"></param>
        /// <returns>Returns sorted combinations by disk</returns>
        private List<Combination> InsertionSortByDisk(List<Combination> SortMe, int Length)
        {
            for (int i = 0; i < Length; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (SortMe[j - 1].GetOwner > SortMe[j].GetOwner)
                    {
                        Combination temp = SortMe[j - 1];
                        SortMe[j - 1] = SortMe[j];
                        SortMe[j] = temp;
                    }
                    j--;
                }
            }
            return SortMe;
        }
    }
}