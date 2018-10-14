using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Zadanie_rekrutacyjne
{
    class Drawer
    {
        public List<Pixel> pixels;
        public WriteableBitmap bitmap;

        int maxX, maxY;
        public Drawer(string path)
        {
            pixels = new List<Pixel>();
            var lfile = File.ReadAllLines(path);
            var llist = new List<string>(lfile);
            FillPixellist(llist);
            FillBitmap(maxX, maxY);
        }
        private void FillPixellist(List<string> values)
        {
            string[] temparray;
            char[] delimiters = new char[] { ':', ',' };
            maxY = 0;
            maxX = 0;
            for(int i = 0; i < values.Count; i++)
            {
                Pixel lpix = new Pixel();
                temparray = values[i].Split(delimiters);
                lpix.X = Int32.Parse(temparray[0]);
                lpix.Y = Int32.Parse(temparray[1]);
                lpix.R = Byte.Parse(temparray[2]);
                lpix.G = Byte.Parse(temparray[3]);
                lpix.B = Byte.Parse(temparray[4]);
                
                if (lpix.X > maxX)
                    maxX = lpix.X;
                if (lpix.Y > maxY)
                    maxY = lpix.Y;
                pixels.Add(lpix);
            }
        }
        private void FillBitmap(int width, int height)
        {
            bitmap = new WriteableBitmap(width,height,96,96, PixelFormats.Bgra32, null);
            byte[,,] pixelsarray = new byte[width, height, 4];
            foreach (var pixel in pixels)
            {
                pixelsarray[pixel.X - 1, pixel.Y - 1, 0] = pixel.B;
                pixelsarray[pixel.X - 1, pixel.Y - 1, 1] = pixel.G;
                pixelsarray[pixel.X - 1, pixel.Y - 1, 2] = pixel.R;
                pixelsarray[pixel.X - 1, pixel.Y - 1, 3] = 255;
            }

            byte[] pixels1d = new byte[height * width * 4];
            int index = 0;
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    for (int i = 0; i < 4; i++)
                        pixels1d[index++] = pixelsarray[col, row, i];
                }
            }
            

            Int32Rect rect = new Int32Rect(0, 0, width, height);
            int stride = 4 * width;
            bitmap.WritePixels(rect, pixels1d, stride, 0);
        }
    }
}
