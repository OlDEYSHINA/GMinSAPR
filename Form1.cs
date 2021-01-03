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
        private Bitmap contrastBitmap;

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

        private void buttonRotateLeft_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Image = bitmap;
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

        private void buttonInvert_Click(object sender, EventArgs e)
        {
            for (int Y = 0; Y < bitmap.Height; Y++)
            {
                for (int X = 0; X < bitmap.Width; X++)
                {
                    Color oldColor = bitmap.GetPixel(X, Y);
                    Color newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                    bitmap.SetPixel(X, Y, newColor);
                    pictureBox1.Image = bitmap;
                }
            }
        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {
            float contrastTemp = 0;
            try
            {
                contrastTemp = Convert.ToInt16(textBox1.Text);
            }
            catch (Exception)
            {

            }
            if (contrastTemp > 100 || contrastTemp < -100)
            {
                return;
            }
            float contrast = 1 + (contrastTemp / 200);
            for (int Y = 0; Y < bitmap.Height; Y++)
            {
                for (int X = 0; X < bitmap.Width; X++)
                {
                    Color oldColor = bitmap.GetPixel(X, Y);
                    byte newRed;
                    byte newGreen;
                    byte newBlue;
                    if (oldColor.R * contrast > 255)
                    {
                        newRed = Convert.ToByte(255);
                    }
                    else if (oldColor.R * contrast < 0)
                    {
                        newRed = Convert.ToByte(0);
                    }
                    else
                    {
                        newRed = Convert.ToByte(oldColor.R * contrast);
                    }
                    if (oldColor.G * contrast > 255)
                    {
                        newGreen = Convert.ToByte(255);
                    }
                    else if (oldColor.G * contrast < 0)
                    {
                        newGreen = Convert.ToByte(0);
                    }
                    else
                    {
                        newGreen = Convert.ToByte(oldColor.G * contrast);
                    }
                    if (oldColor.B * contrast > 255)
                    {
                        newBlue = Convert.ToByte(255);
                    }
                    else if (oldColor.B * contrast < 0)
                    {
                        newBlue = Convert.ToByte(0);
                    }
                    else
                    {
                        newBlue = Convert.ToByte(oldColor.B * contrast);
                    }
                    Color newColor = Color.FromArgb(oldColor.A, newRed, newGreen, newBlue);
                    bitmap.SetPixel(X, Y, newColor);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void buttonBlur_Click(object sender, EventArgs e)
        {
            Color newPix;
            int newRed = 0;
            int newGreen = 0;
            int newBlue = 0;
            int countChanges = 0;
            Color oldPix;
            for (int Y = 0; Y < bitmap.Height; Y++)
            {
                for (int X = 0; X < bitmap.Width; X++)
                {
                    if (X > 1)
                    {
                        if (Y > 1)
                        {
                            oldPix = bitmap.GetPixel(X - 1, Y - 1);
                            newRed = newRed + oldPix.R;
                            newGreen = newGreen + oldPix.G;
                            newBlue = newBlue + oldPix.B;
                            countChanges++;
                        }
                        oldPix = bitmap.GetPixel(X - 1, Y);
                        newRed = newRed + oldPix.R;
                        newGreen = newGreen + oldPix.G;
                        newBlue = newBlue + oldPix.B;
                        countChanges++;
                        if(Y<bitmap.Height-1)
                        oldPix = bitmap.GetPixel(X - 1, Y + 1);
                        newRed = newRed + oldPix.R;
                        newGreen = newGreen + oldPix.G;
                        newBlue = newBlue + oldPix.B;
                        countChanges++;
                    }

                    if (Y > 1)
                    {
                        oldPix = bitmap.GetPixel(X, Y - 1);
                        newRed = newRed + oldPix.R;
                        newGreen = newGreen + oldPix.G;
                        newBlue = newBlue + oldPix.B;
                        countChanges++;
                        if (X < bitmap.Width-1)
                        {
                            oldPix = bitmap.GetPixel(X + 1, Y - 1);
                            newRed = newRed + oldPix.R;
                            newGreen = newGreen + oldPix.G;
                            newBlue = newBlue + oldPix.B;
                            countChanges++;
                        }
                    }
                    oldPix = bitmap.GetPixel(X, Y);
                    newRed = newRed + oldPix.R;
                    newGreen = newGreen + oldPix.G;
                    newBlue = newBlue + oldPix.B;
                    countChanges++;
                   
                    if (Y < bitmap.Height-1)
                    {
                        oldPix = bitmap.GetPixel(X, Y + 1);
                        newRed = newRed + oldPix.R;
                        newGreen = newGreen + oldPix.G;
                        newBlue = newBlue + oldPix.B;
                        countChanges++;
                        if (X < bitmap.Width-1)
                        {
                            oldPix = bitmap.GetPixel(X + 1, Y + 1);
                            newRed = newRed + oldPix.R;
                            newGreen = newGreen + oldPix.G;
                            newBlue = newBlue + oldPix.B;
                            countChanges++;
                        }
                    }
                    if (X < bitmap.Width-1)
                    {
                        oldPix = bitmap.GetPixel(X + 1, Y);
                        newRed = newRed + oldPix.R;
                        newGreen = newGreen + oldPix.G;
                        newBlue = newBlue + oldPix.B;
                        countChanges++;
                    }

                    oldPix = bitmap.GetPixel(X, Y);
                    newPix = Color.FromArgb(((oldPix.R*3)+ newRed / countChanges)/4, ((oldPix.B * 3) + newBlue / countChanges) / 4, ((oldPix.G * 3) + newGreen / countChanges) / 4);
                    bitmap.SetPixel(X,Y,newPix);
                }
            }

            pictureBox1.Image = bitmap;
        }
    }
}
