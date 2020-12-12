using System;
using System.Drawing;
using System.Windows.Forms;

namespace GVMSAPR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private Bitmap bitmap;
        private void buttonRotateLeft_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Image = bitmap;
            }


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы изображений| *.bmp; *.png;* .jpg; |Все файлы|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                bitmap = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                saveFileDialog1.FileName = openFileDialog1.FileName;
                pictureBox1.Image = bitmap;
                labelY.Text = "Y=" + bitmap.Size.Width;
                labelX.Text = "X=" + bitmap.Size.Height;

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void buttonRotateRight_Click(object sender, EventArgs e)
        {
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = bitmap;
        }

        private void ReflectX_Click(object sender, EventArgs e)
        {
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = bitmap;
        }

        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(bitmap, bitmap.Size.Width / 3 * 2, bitmap.Size.Height / 3 * 2);
                pictureBox1.Image = bitmap;
                labelY.Text = "Y=" + bitmap.Size.Width;
                labelX.Text = "X=" + bitmap.Size.Height;
            }
            catch
            {

            }
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            if (bitmap.Size.Width < 5000 && bitmap.Size.Height < 5000)
            {
                try
                {
                    bitmap = new Bitmap(bitmap, bitmap.Size.Width * 3 / 2, bitmap.Size.Height * 3 / 2);
                    pictureBox1.Image = bitmap;
                    labelY.Text = "Y=" + bitmap.Size.Width;
                    labelX.Text = "X=" + bitmap.Size.Height;
                }
                catch
                {

                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var bitmapSave = bitmap;
                bitmapSave.Save(saveFileDialog1.FileName);
            }
            catch (Exception NullReferenceException)
            {
               
            }
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Файлы изображений| *.bmp; *.png;* .jpg; |Все файлы|*.*";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            bitmap.Save(saveFileDialog1.FileName);
        }
    }
}
