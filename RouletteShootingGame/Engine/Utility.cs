using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteShootingGame.Engine
{
    public class Utility
    {
        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image != null)
            {
                //create a new empty bitmap to hold rotated image
                Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
                rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                //make a graphics object from the empty bitmap
                Graphics g = Graphics.FromImage(rotatedBmp);

                //Put the rotation point in the center of the image
                g.TranslateTransform(150, 150);

                //rotate the image
                g.RotateTransform(angle);

                //move the image back
                g.TranslateTransform(-150, -150);

                //draw passed in image onto graphics object
                g.DrawImage(image, new PointF(0, 0));

                return rotatedBmp;
            }
            return null;
        }
    }
}
