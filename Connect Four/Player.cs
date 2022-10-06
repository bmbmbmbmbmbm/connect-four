using System.Drawing;
using System.Drawing.Imaging;

namespace Connect_Four
{
    internal class Player
    {
        private int DiskValue;
        private Bitmap DiskImage;
        private string PlayerName;

        public Player(int DiskVal, Bitmap PlayerImage, string Name)
        {
            DiskValue = DiskVal;
            PlayerName = Name;
            DiskImage = PlayerImage;
        }

        // Takes a regular board tile image and replaces the disk part with the players colour of choice.
        public void SetDiskColour(Color PlayerColour)
        {
            DiskImage = DiskImage.Clone(new Rectangle(Point.Empty, DiskImage.Size), PixelFormat.Format32bppArgb);
            for (int x = 0; x < DiskImage.Width; x++)
            {
                for (int y = 0; y < DiskImage.Height; y++)
                {
                    if (DiskImage.GetPixel(x, y) == Color.FromArgb(0, 0, 0)) DiskImage.SetPixel(x, y, PlayerColour);
                }
            }
        }

        public Bitmap GetDiskImage
        {
            get { return DiskImage; }
        }

        public int GetDiskValue
        {
            get { return DiskValue; }
        }

        public string GetPlayerName
        {
            get { return PlayerName; }
        }
    }
}