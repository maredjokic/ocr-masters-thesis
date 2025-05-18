using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyAndImageProcessing
{
    class SmoothingClass
    {
        public static Bitmap Execute(Bitmap image)
        {
            Bitmap temp = new Bitmap(image.Width, image.Height);
            temp = image;
            image = GrayScale(temp);
            temp = image;
            image = Binary(temp);
            temp = image;
            image = NoiseRemoval(temp);
            return image;
        }//end of function
        public static Bitmap GrayScale(Bitmap image)
        {
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);   
            int stride = bmData.Stride;//length of the line
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                int nOffset = stride - image.Width * 3;

                byte red, green, blue;

                for (int y = 0; y < image.Height; ++y)
                {
                    for (int x = 0; x < image.Width; ++x)
                    {
                        blue = p[0];
                        green = p[1];
                        red = p[2];

                        p[0] = p[1] = p[2] = (byte)(.299 * red
                            + .587 * green
                            + .114 * blue);
                        p += 3;
                    }//end of inner Loop
                    p += nOffset;
                }//end of for loop
            }//end of unsafe
            image.UnlockBits(bmData);
            return image;
        }//end of function

        public static Bitmap Binary(Bitmap image)
        {
            bool flag = true;
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
             ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;

            System.IntPtr Scan0 = bmData.Scan0;
            int Threshold = 220;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                int nOffset = stride - image.Width * 3;

                byte red, green, blue;
                byte binary;

                for (int y = 0; y < image.Height; ++y)
                {
                    for (int x = 0; x < image.Width; ++x)
                    {
                        blue = p[0];
                        green = p[1];
                        red = p[2];

                        binary = (byte)(.299 * red
                            + .587 * green
                            + .114 * blue);

                        if (binary < Threshold && flag)
                            p[0] = p[1] = p[2] = 0;
                        else
                            if (binary >= Threshold && flag)
                            p[0] = p[1] = p[2] = 255;
                        else
                                if (binary < Threshold && !flag)
                            p[0] = p[1] = p[2] = 255;
                        else
                            p[0] = p[1] = p[2] = 0;
                        p += 3;
                    }//end of inner for loop
                    p += nOffset;
                }//end of for loop
            }//end of unsafe
            image.UnlockBits(bmData);
            return image;
        }//end of function

        public static Bitmap NoiseRemoval(Bitmap IntensityImage)
        {
            Bitmap b2 = (Bitmap)IntensityImage.Clone();
            byte val;

            BitmapData bmData = IntensityImage.LockBits(new Rectangle(0, 0, IntensityImage.Width, IntensityImage.Height),
                 ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmData2 = b2.LockBits(new Rectangle(0, 0, IntensityImage.Width, IntensityImage.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan02 = bmData2.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan02;

                int nOffset = stride - IntensityImage.Width * 3;
                int nWidth = IntensityImage.Width * 3;

                //int nPixel=0;

                p += stride;
                p2 += stride;
                //int val;
                for (int y = 1; y < IntensityImage.Height - 1; ++y)
                {
                    p += 3;
                    p2 += 3;

                    for (int x = 3; x < nWidth - 3; ++x)
                    {
                        val = p2[0];
                        if (val == 0)
                            if ((p2 + 3)[0] == 0 || (p2 - 3)[0] == 0 || (p2 + stride)[0] == 0 || (p2 - stride)[0] == 0 || (p2 + stride + 3)[0] == val || (p2 + stride - 3)[0] == 0 || (p2 - stride - 3)[0] == 0 || (p2 + stride + 3)[0] == 0)
                                p[0] = val;
                            else
                                p[0] = 255;

                        ++p;
                        ++p2;
                    }

                    p += nOffset + 3;
                    p2 += nOffset + 3;
                }
            }

            IntensityImage.UnlockBits(bmData);
            b2.UnlockBits(bmData2);
            return b2;


        }//end of function
    }
}
