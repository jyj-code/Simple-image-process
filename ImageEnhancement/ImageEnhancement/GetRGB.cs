using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEnhancement
{
    class GetRGB
    {
        public Bitmap source;
        double totalSize = 0;
        int height = 0;
        int width = 0;
        int[,] dest_R;
        int[,] dest_G;
        int[,] dest_B;
        int[] counter_R = new int[256];
        int[] counter_G = new int[256];
        int[] counter_B = new int[256];
        double[] Rate_source_R = new double[256];
        double[] Rate_source_G = new double[256];
        double[] Rate_source_B = new double[256];
        double[] Added_R = new double[256];
        double[] Added_G = new double[256];
        double[] Added_B = new double[256];
        double[] Rate_dest_R = new double[256];
        double[] Rate_dest_G = new double[256];
        double[] Rate_dest_B = new double[256];
        int[] map_R = new int[256];
        int[] map_G = new int[256];
        int[] map_B = new int[256];
        const int L = 256;
        public GetRGB(string path)
        {
            source = new Bitmap(path);
            this.height = source.Height;
            this.width = source.Width;
            dest_R = new int[width, height];
            dest_G = new int[width, height];
            dest_B = new int[width, height];
            totalSize = height * width;
        }
        public void getInitInfo()
        {
            int temp_R=0;
            int temp_G=0;
            int temp_B=0;
            for(int i =0;i<width;i++)
            {
                for(int j =0;j<height;j++)
                {
                    temp_R = dest_R[i, j] = source.GetPixel(i, j).R;
                    counter_R[temp_R]++;
                    temp_G = dest_G[i, j] = source.GetPixel(i, j).G;
                    counter_G[temp_G]++;
                    temp_B = dest_B[i, j] = source.GetPixel(i, j).B;
                    counter_B[temp_B]++;
                }
            }
            for (int i = 0; i < 256; i++)
            {
                Rate_source_R[i] = counter_R[i] / totalSize;
                Rate_source_G[i] = counter_G[i] / totalSize;
                Rate_source_B[i] = counter_B[i] / totalSize;
            }
            for (int i = 0; i < 256; i++)
            {
                if (i == 0)
                {
                    Added_R[i] = Rate_source_R[i];
                    Added_G[i] = Rate_source_G[i];
                    Added_B[i] = Rate_source_B[i];
                }
                else
                {
                    Added_R[i] = Added_R[i - 1] + Rate_source_R[i];
                    Added_G[i] = Added_G[i - 1] + Rate_source_G[i];
                    Added_B[i] = Added_B[i - 1] + Rate_source_B[i];
                }
            }

        }

        public void Enhance(out Bitmap picture,out Bitmap gram)
        {
            for (int i = 0; i < 256; i++)
            {
                map_R[i] = (int)Math.Floor(255 * Added_R[i]);
                map_G[i] = (int)Math.Floor(255 * Added_G[i]);
                map_B[i] = (int)Math.Floor(255 * Added_B[i]);
            }
            Bitmap b = new Bitmap(width, height);
            Color c ;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    c= Color.FromArgb(map_R[dest_R[i,j]],map_G[dest_G[i,j]],map_B[dest_B[i,j]]);
                    b.SetPixel(i, j, c);
                }
            }
            picture = b;
            for (int i = 0; i < 256; i++)
            {          
                for(int j=0;j<256;j++)
                {
                    if(map_R[j]==i)
                    {
                        Rate_dest_R[i] += Rate_source_R[j];
                    }
                    if (map_G[j] == i)
                    {
                        Rate_dest_G[i] += Rate_source_G[j];
                    }
                    if (map_B[j] == i)
                    {
                        Rate_dest_B[i] += Rate_source_B[j];
                    }
                     
                }
            }
            Bitmap chart = DrawPicture(Rate_dest_R, Rate_dest_G, Rate_dest_B);
            gram = chart;
        }
        public Bitmap DrawGrams()
        {
            return DrawPicture(Rate_source_R, Rate_source_G, Rate_source_B);
        }

        public Bitmap DrawPicture(double[] data1, double[] data2, double[] data3)
        {
            Bitmap gram = new Bitmap(512, 210);
            Graphics g = Graphics.FromImage(gram);
            Pen pen1 = new Pen(Color.FromArgb(200,255, 0, 0));
            Pen pen2 = new Pen(Color.FromArgb(150, 0, 255, 0));
            Pen pen3 = new Pen(Color.FromArgb(90, 0, 0, 255));
            for (int i = 0; i < 256; i++)
            {
                g.DrawLine(pen1, i * 2, 210 - (int)(5000 * data1[i]), i * 2, 210);
                g.DrawLine(pen2, i * 2, 210 - (int)(5000 * data2[i]), i * 2, 210);
                g.DrawLine(pen3, i * 2, 210 - (int)(5000 * data3[i]), i * 2, 210);
            }
            return gram;
        }
    }
}
