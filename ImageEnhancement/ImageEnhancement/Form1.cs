using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEnhancement
{
    public partial class ImageEnhancement : Form
    {
        string path = null;
        GetRGB g;
        Bitmap temp;
        public ImageEnhancement()
        {
            InitializeComponent();          
        }
        private void choose_Click(object sender, EventArgs e)
        {
            beforePicture.Image = null;
            afterPicture.Image = null;
            beforeGram.Image = null;
            afterGram.Image = null;
            OpenFileDialog opDialog = new OpenFileDialog();
            opDialog.Title = "选择图片";
            opDialog.Filter = "所有文件|*.*|图片文件|*.jpg;*.bmp;*.png";
            opDialog.InitialDirectory = @"C:\Users\jm\Desktop\新建文件夹 (2)";
            if ((opDialog.ShowDialog()) == DialogResult.OK)
            {
                path = System.IO.Path.GetFullPath(opDialog.FileName);
                Path.Text = path;
                beforePicture.Image = Image.FromFile(path);
                g = new GetRGB(path);
                g.getInitInfo();
                Bitmap b = g.DrawGrams();
                beforeGram.Image = b;
            }
            //else
            //{
            //    MessageBox.Show("请选择图片文件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}        
        }

        private void startEnhance_Click(object sender, EventArgs e)
        {
            Bitmap picture,gram;
            g.Enhance(out picture, out gram);
            afterPicture.Image = temp = picture;
            afterGram.Image = gram;
        }

        private void black_white_Click(object sender, EventArgs e)
        {
            Binarization b = new Binarization(path);
            afterPicture.Image = temp = b.GetBinarization();
        }

        private void graying_Click(object sender, EventArgs e)
        {
            Graying gray = new Graying(path);
            afterPicture.Image = temp = gray.GetGraying();
        }

        private void store_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "图片文件|*.jpg;*.bmp;*.png";
            sd.InitialDirectory = @"C:\Users\jm\Desktop\新建文件夹 (2)\二值化";
            sd.AddExtension = true;
            //sd.CheckFileExists = true;
            sd.Title = "保存图片";
            if ((sd.ShowDialog()) == DialogResult.OK)
            {
                FileStream fs = new FileStream(sd.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                try
                {
                    
                    temp.Save(fs, ImageFormat.Bmp);
                    fs.Flush();
                    fs.Close();
                    fs.Dispose();
                }
                catch(Exception ex)
                {
                    fs.Close();
                    fs.Dispose();
                }
                
                MessageBox.Show("保存成功");
                
            }
        }

    }
}
