using System.Drawing;

namespace SlidePuzzle
{
    public static class ImageTransformation
    {
        public static Image Resize(this Image image, int width)
        {
            return image.Resize(width, width);
        }

        public static Image Resize(this Image image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(result);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, width, height);
            g.Dispose();
            return result;
        }

        public static Image DrawMeshLine(this Image image, int line, bool frame = false)
        {
            Bitmap result = (Bitmap)image;
            Graphics g = Graphics.FromImage(result);
            if (frame)
            {
                g.DrawLine(Pens.Black, 0, 0, image.Width, 0);
                g.DrawLine(Pens.Black, 0, 0, 0, image.Height);
                g.DrawLine(Pens.Black, 0, image.Height - 1, image.Width - 1, image.Height - 1);
                g.DrawLine(Pens.Black, image.Width - 1, 0, image.Width - 1, image.Height - 1);
            }
            for (int i = 0; i <= line; i++)
            {
                int point = image.Width / (line + 1) * (i + 1);
                g.DrawLine(Pens.Black, point, 0, point, image.Height);
                g.DrawLine(Pens.Black, 0, point, image.Width, point);
            }
            g.Dispose();
            return result;
        }
    }
}
