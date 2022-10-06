using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class Game_Mode_Selection : Form
    {
        private Bitmap InvertedButton;
        private Color InvertedFontColour;

        public Game_Mode_Selection(ref Bitmap PrevInvertedButton, ref Color PrevInvertedColour)
        {
            InitializeComponent();
            InvertedButton = PrevInvertedButton;
            InvertedFontColour = PrevInvertedColour;
            CenterToScreen();

            Player1RadioButton.Checked = true;
        }

        public void ColourSelect(object sender, EventArgs e)
        {
            // Displays which player is what colour. Radio buttons are used to pass the player colours to the game form.
            switch (Player1RadioButton.Checked)
            {
                case true:
                    if (((Button)sender).BackColor != Player2RadioButton.ForeColor)
                    {
                        Player1RadioButton.ForeColor = ((Button)sender).BackColor;
                    }
                    break;

                case false:
                    if (((Button)sender).BackColor != Player1RadioButton.ForeColor)
                    {
                        Player2RadioButton.ForeColor = ((Button)sender).BackColor;
                    }
                    break;
            }
        }

        public void TwoPlayerSelected(object sender, EventArgs e)
        {
            Game C4 = new Game(ref InvertedButton, ref InvertedFontColour, Player1RadioButton.ForeColor, Player2RadioButton.ForeColor, true) { Owner = this };
            // Passes the inverted UI features across to avoid more UIGraphics objects, also indicates there are no AI players.
            C4.Show();
            Hide();
        }

        public void OnePlayerSelected(object sender, EventArgs e)
        {
            Game C4 = new Game(ref InvertedButton, ref InvertedFontColour, Player1RadioButton.ForeColor, Player2RadioButton.ForeColor, false) { Owner = this };
            // Passes the inverted UI features across to avoid more UIGraphics objects, also indicates there are AI players.
            C4.Show();
            Hide();
        }

        public void PreviousMenu(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        // Takes a button and inverts its image.
        private void InvertButton(ref Button MyButton)
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

        public void InvertOnePlayerButton(object sender, EventArgs e)
        {
            InvertButton(ref OnePlayerButton);
        }

        public void InvertTwoPlayerButton(object sender, EventArgs e)
        {
            InvertButton(ref TwoPlayerButton);
        }

        public void InvertBackButton(object sender, EventArgs e)
        {
            InvertButton(ref BackButton);
        }
    }
}