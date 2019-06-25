using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseProject
{
    public static class Extentions
    {
        public static void SetRow(this Bitmap bitmap, int index, System.Drawing.Color c)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                bitmap.SetPixel(i, index, c);
            }
        }

    }
}
