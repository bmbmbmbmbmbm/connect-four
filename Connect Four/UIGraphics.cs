using System.Drawing;
using System.Drawing.Imaging;

namespace Connect_Four
{
    internal class UIGraphics
    {
        public Bitmap InvertImage(Bitmap OriginalImage)
        {
            OriginalImage = OriginalImage.Clone(new Rectangle(Point.Empty, OriginalImage.Size), PixelFormat.Format32bppArgb);

            Graphics G = Graphics.FromImage(OriginalImage);
            ColorMatrix MyMatrix = new ColorMatrix(
                new float[][]
                {
                    new float[] {-1, 0, 0, 0, 0},
                    new float[] {0, -1, 0, 0, 0},
                    new float[] {0, 0, -1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {1, 1, 1, 0, 1}
                }
                );
            ImageAttributes iAttributes = new ImageAttributes();
            iAttributes.SetColorMatrix(MyMatrix);
            G.DrawImage(OriginalImage, new Rectangle(0, 0, OriginalImage.Width, OriginalImage.Height), 0, 0, OriginalImage.Width, OriginalImage.Height, GraphicsUnit.Pixel, iAttributes);
            G.Dispose();
            return OriginalImage;
        }

        public Color InvertFont(Color CurrentColour)
        {
            return Color.FromArgb(255 - CurrentColour.R, 255 - CurrentColour.G, 255 - CurrentColour.B);
        }
    }
}