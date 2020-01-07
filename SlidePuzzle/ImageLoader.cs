using System.Drawing;

namespace SlidePuzzle
{
    public static class ImageLoader
    {
        public static Image Resource(string path)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            return new Bitmap(assembly.GetManifestResourceStream("SlidePuzzle.Images." + path));
        }

        public static Image Scanner()
        {
            return null;
        }
    }
}
