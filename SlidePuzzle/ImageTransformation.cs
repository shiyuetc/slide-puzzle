using System.Drawing;

namespace SlidePuzzle
{
    /// <summary>
    /// 画像を加工する拡張クラス
    /// </summary>
    public static class ImageTransformation
    {
        /// <summary>
        /// 画像のサイズを変更する
        /// </summary>
        /// <param name="image">対象の画像</param>
        /// <param name="width">幅のサイズ</param>
        /// <returns>サイズ変更した画像を返す</returns>
        public static Image Resize(this Image image, int width)
        {
            return image.Resize(width, width);
        }

        /// <summary>
        /// 画像のサイズを変更する
        /// </summary>
        /// <param name="image">対象の画像</param>
        /// <param name="width">横幅のサイズ</param>
        /// <param name="height">縦幅のサイズ</param>
        /// <returns>サイズ変更した画像を返す</returns>
        public static Image Resize(this Image image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(result);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, width, height);
            g.Dispose();
            return result;
        }

        /// <summary>
        /// 画像に線を描画する
        /// </summary>
        /// <param name="image">対象の画像</param>
        /// <param name="line">描画する線の数</param>
        /// <param name="frame">枠を描画するかどうか</param>
        /// <returns>線を描画した画像を返す</returns>
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

        /// <summary>
        /// 画像の切り取りをする
        /// </summary>
        /// <param name="image">対象の画像</param>
        /// <param name="width">切り取る幅のサイズ</param>
        /// <param name="left">X軸の切り取り開始位置</param>
        /// <param name="top">Y軸の切り取り開始位置</param>
        /// <returns>切り取りを行った画像を返す</returns>
        public static Image Trim(this Image image,int width, int left, int top)
        {
            Bitmap result = new Bitmap(width, width);
            Graphics g = Graphics.FromImage(result);
            Rectangle srcRect = new Rectangle(left, top, width, width);
            g.DrawImage(image, new Rectangle(0, 0, width, width), srcRect, GraphicsUnit.Pixel);
            g.Dispose();
            return result;
        }
    }
}
