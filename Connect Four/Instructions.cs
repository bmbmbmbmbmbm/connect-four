using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class Instructions : Form
    {
        // Used for quickly switching button fonts/images when inverting.
        private Bitmap InvertedButton;

        private Color InvertedFontColour;

        public Instructions(ref Bitmap PrevInvertedButton, ref Color PrevInvertedColour)
        {
            InitializeComponent();

            CenterToScreen();

            // The two lines below are used for quickly inverting the buttons.
            InvertedButton = PrevInvertedButton;
            InvertedFontColour = PrevInvertedColour;

            // Used for making sure that the InstructionsLabel goes to multiple lines instead of a single line.
            InstructionsLabel.MaximumSize = new Size(1000, 0);
            InstructionsLabel.AutoSize = true;
            DefaultInstructions();
        }

        public void PreviousMenu(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        // Shows the instructions for the original version of Connect Four.
        private void DefaultInstructions()
        {
            GameModeLabel.Text = "CONNECT FOUR";
            InstructionsLabel.Text = ("Each player has a coloured disk, you must get four of your coloured disks in a line either horizontally, diagonally or vertically. If the board is filled up and no disks can be placed the game ends in a tie").ToUpper();
        }

        // IN PROGRESS: This code is subject to change due to gamemode instruction buttons likely to be
        // implemented. Each button would display their gamemodes instructions.
        //
        // The code below is used for inverting buttons when entered and left.
        public void InvertBackButton(object sender, EventArgs e)
        {
            InvertButton(ref BackButton);
        }

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
    }
}