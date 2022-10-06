using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class Game : Form
    {
        // Used for quickly switching button fonts/images when inverting.
        private Bitmap InvertedButton;
        private Color InvertedFontColour;

        private GameSkeleton GameLogic;
        private PictureBox[,] BoardUI;
        private Player[] Players;
        private bool TwoPlayers;

        public Game(ref Bitmap PrevInvertedButton, ref Color PrevInvertedColour, Color Player1Colour, Color Player2Colour, bool TwoPlayers)
        {
            InitializeComponent();

            CenterToScreen();

            InvertedButton = PrevInvertedButton;
            InvertedFontColour = PrevInvertedColour;

            // Sets up the games visual side
            BoardUI = new PictureBox[7, 7];
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    BoardUI[x, y] = new PictureBox();
                    BoardUI[x, y].Size = new Size(80, 80);
                    BoardUI[x, y].Location = new Point(XPosition(x), YPosition(y));
                    BoardUI[x, y].Image = Properties.Resources.ColorMapTile;
                    Controls.Add(BoardUI[x, y]);
                    BoardUI[x, y].Click += ColumnClicked;
                }
            }

            // Sets up the games background processes
            GameLogic = new GameSkeleton(TwoPlayers);

            Players = new Player[2];
            Players[0] = new Player(1, Properties.Resources.ColorMapTile, "Player 1");
            Players[1] = new Player(2, Properties.Resources.ColorMapTile, "Player 2");
            Players[0].SetDiskColour(Player1Colour);
            Players[1].SetDiskColour(Player2Colour);

            CurrentPlayerLabel.Text += " 1";
            this.TwoPlayers = TwoPlayers;
        }
        private int YPosition(int y)
        {
            return 560 - 80 * y;
        }
        private int XPosition(int x)
        {
            return (x * 80) + 360;
        }
        public void ColumnClicked(object sender, EventArgs e)
        {
            int X = (((PictureBox)sender).Location.X - 360) / 80; // Used to determine which picture box caused the event. Data later used to find column clicked.
            int WinCondition = GameLogic.Move(X);
            if(WinCondition == 1) // Checks if a player has won.
            {
                PlaceDisk(X);
                if(TwoPlayers == true || GameLogic.GetPlayer == 2)
                {
                    Win(1);
                }
                else if(GameLogic.GetPlayer == 1)
                {
                    Win(2);
                }
            }
            else if(WinCondition == -1) // Checks for a draw
            {
                PlaceDisk(X);
                Draw();
            }
            else if(WinCondition == 0) // Checks to see if game is still ongoing
            {
                PlaceDisk(X);
                GameLogic.NextTurn();
                if (TwoPlayers == true)
                {
                    CurrentPlayerLabel.Text = "CURRENT PLAYER: " + GameLogic.GetPlayer.ToString();
                }
                else
                {
                    WinCondition = GameLogic.AIMove();
                    BoardUI[GameLogic.GetAIPosition.X, GameLogic.GetAIPosition.Y].Image = Players[1].GetDiskImage;
                    if(WinCondition == 1)
                    {
                        Win(2);
                    }
                    else if(WinCondition == -1)
                    {
                        Draw();
                    }
                    GameLogic.NextTurn();
                }
            }
        }
        /// <summary>
        /// Displays the appropriate player image for the piece just placed.
        /// </summary>
        /// <param name="x"></param>
        private void PlaceDisk(int x)
        {
            switch (GameLogic.GetPlayer)
            {
                case 1:

                    BoardUI[x, GameLogic.GetTop(x) - 1].Image = Players[0].GetDiskImage;
                    break;
                case 2:
                    BoardUI[x, GameLogic.GetTop(x) - 1].Image = Players[1].GetDiskImage;
                    break;
            }
        }
        private void Draw()
        {
            if(MessageBox.Show("It's a draw. Play again?", "Game Over", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetBoard();
            }
            else
            {
                Environment.Exit(1);
            }
        }
        private void Win(int Player)
        {
            if(MessageBox.Show("Player " + Player.ToString() + " has won. Play again?", "Game Over", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetBoard();
            }
            else
            {
                Environment.Exit(1);
            }
        }
        private void ResetBoard()
        {
            GameLogic.SetBoard();
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    BoardUI[x, y].Image = Properties.Resources.ColorMapTile;
                }
            }
        }
        /// <summary>
        /// Opens/closes the pause menu via the escape key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TogglePause(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (NavigationPanel.Visible == true)
                {
                    NavigationPanel.Visible = false;
                    NavigationPanel.Enabled = false;
                }
                else
                {
                    NavigationPanel.Visible = true;
                    NavigationPanel.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Closes the pause menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClosePause(object sender, EventArgs e)
        {
            NavigationPanel.Hide();
            NavigationPanel.Enabled = false;
        }

        /// <summary>
        /// Creates an instance of the instructions form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenInstructions(object sender, EventArgs e)
        {
            Instructions MyInstructions = new Instructions(ref InvertedButton, ref InvertedFontColour) { Owner = this };
            MyInstructions.Show();
            Hide();
        }

        /// <summary>
        /// Returns the user to the main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenMainMenu(object sender, EventArgs e)
        {
            MainMenu MyMainMenu = new MainMenu();
            MyMainMenu.Show();
            Close();
        }

        /// <summary>
        /// Closes this and every other associated form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CloseProgram(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        // Takes whichever button was entered/left and inverts it.
        public void InvertButton(ref Button MyButton)
        {
            if (MyButton.ForeColor == InvertedFontColour)
            {
                MyButton.Image = Properties.Resources.Button;
                MyButton.ForeColor = Color.FromArgb(192, 0, 0);
            }
            else
            {
                MyButton.Image = InvertedButton;
                MyButton.ForeColor = InvertedFontColour;
            }
        }

        // Procedures used for inverting their respective buttons.
        public void InvertResume(object sender, EventArgs e)
        {
            InvertButton(ref ResumeButton);
        }

        public void InvertInstructions(object sender, EventArgs e)
        {
            InvertButton(ref InstructionsButton);
        }

        public void InvertMainMenu(object sender, EventArgs e)
        {
            InvertButton(ref MainMenuButton);
        }

        public void InvertExit(object sender, EventArgs e)
        {
            InvertButton(ref ExitButton);
        }
    }
}