using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class MainMenu : Form
    {
        // Used for quickly switching button fonts/images when inverting.
        private Bitmap InvertedButton;

        private Color InvertedFontColour;

        public MainMenu()
        {
            InitializeComponent();
            //            PlayMusic();
            CenterToScreen();

            // Code here is used to get visual indicators for buttons and minimize the use of UIGraphics through passing to different forms.
            UIGraphics ObtainInverse = new UIGraphics();
            InvertedButton = ObtainInverse.InvertImage(Properties.Resources.Button);
            InvertedFontColour = ObtainInverse.InvertFont(PlayButton.ForeColor);
        }

        /// <summary>
        /// Generates an instance of the OriginalGame form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenGame(object sender, EventArgs e)
        {
            Game_Mode_Selection GameModes = new Game_Mode_Selection(ref InvertedButton, ref InvertedFontColour) { Owner = this };
            GameModes.Show();
            Hide();
        }

        /// <summary>
        /// Generates instance of the Instructions form.
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
        /// Closes all open forms related to the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CloseProgram(object sender, EventArgs e)
        {
            Environment.Exit(1); //Closes all of the forms associated with the program.
        }

        // Procedures used for inverting their respective buttons.
        public void InvertPlay(object sender, EventArgs e)
        {
            InvertButton(ref PlayButton);
        }

        public void InvertInstructions(object sender, EventArgs e)
        {
            InvertButton(ref InstructionsButton);
        }

        public void InvertExit(object sender, EventArgs e)
        {
            InvertButton(ref ExitButton);
        }

        // Takes whichever button was entered/left and inverts it.
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
    }
}