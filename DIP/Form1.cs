using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using ImageProcessing;
using AForge.Imaging.Filters;
using IPLab;

namespace DIP
{
    public partial class Main : Form
    {
        FIP.FIP FIPfilter = new FIP.FIP();
        Image file;
        Bitmap newBitmap;
        private Bitmap _currentBitmap;
        Bitmap org;
        int size;
        Boolean opened = false;
        ImageHandler imageHandler = new ImageHandler();
        string setFormat = "JPEG";
        bool startPaint = false;
        Graphics g;
        int? initX = null;
        int? initY = null;
        public Main()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            
        }
        private void ImageDoc(IDocumentsHost host)
        {
            this.host = host;

        }


        private void Open_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                newBitmap = new Bitmap(openFileDialog1.FileName);
                org = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = file;
                label1.Text = file.Width.ToString();
                label3.Text = file.Height.ToString();
                //label18.Text = file.HorizontalResolution.ToString();
                //label19.Text = file.VerticalResolution.ToString();
                opened = true;
                //button33.Enabled = true;
                //button2.Enabled = true;
                //button34.Enabled = true;

                imageHandler.CurrentBitmap = new Bitmap(openFileDialog1.FileName);
                //imageHandler.BitmapPath = oDlg.FileName;
                this.AutoScroll = true;
                //this.AutoScrollMinSize = new Size(Convert.ToInt32(imageHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(imageHandler.CurrentBitmap.Height * zoomFactor));
                this.Invalidate();
            }


        }

        private void Save_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (opened)
                {
                    //if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "bmp")
                    //{

                    //    newBitmap.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                    //}
                    //if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "jpg")
                    //{
                    //    pictureBox1.Image = newBitmap;
                    //    pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                    //}
                    //if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "png")
                    //{
                    //    pictureBox1.Image = newBitmap;
                    //    pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
                    //}
                    //if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "gif")
                    //{
                    //    pictureBox1.Image = newBitmap;
                    //    pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Gif);
                    //}
                    pictureBox1.Image = newBitmap;
                    
                    pictureBox1.Image.Save(saveFileDialog1.FileName.Substring(0, saveFileDialog1.FileName.Length - 3).ToLower() + setFormat);
                }

                else
                {
                    MessageBox.Show("الرجاء اختيار صورة");
                }
            }
        }

        private void تدويرلليمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = newBitmap;
        }

        private void تدويرلليسارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = newBitmap;
        }

        private void سلبيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newBitmap = FIPfilter.NegativeImageColor(newBitmap);
            pictureBox1.Image = newBitmap;
        }

        private void تراجعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newBitmap = org;
            pictureBox1.Image = org;
        }

        private void aaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            newBitmap = FIPfilter.HistoramEqualization(newBitmap);
            pictureBox1.Image = newBitmap;
        }

        private void sobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newBitmap = FIPfilter.ImageSobelFilterColor(newBitmap);
            pictureBox1.Image = newBitmap;
        }

        private void احمرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            imageHandler.RestorePrevious();
            imageHandler.SetColorFilter(ImageHandler.ColorFilterTypes.Red);
            this.Invalidate();
            this.Cursor = Cursors.Default;
            newBitmap = imageHandler.CurrentBitmap;
            pictureBox1.Image = newBitmap;
        }

        private void اخضرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            imageHandler.RestorePrevious();
            imageHandler.SetColorFilter(ImageHandler.ColorFilterTypes.Green);
            this.Invalidate();
            this.Cursor = Cursors.Default;
            newBitmap = imageHandler.CurrentBitmap;
            pictureBox1.Image = newBitmap;
        }

        private void ازرقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            imageHandler.RestorePrevious();
            imageHandler.SetColorFilter(ImageHandler.ColorFilterTypes.Blue);
            this.Invalidate();
            this.Cursor = Cursors.Default;
            newBitmap = imageHandler.CurrentBitmap;
            pictureBox1.Image = newBitmap;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void مرآهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = org;
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            Invalidate();
            pictureBox1.Image = image;
        }


        private void التعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void القائمهالرئيسيهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setFormat = "bmp";
        }

        private void pngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setFormat = "png";
        }

        private void gifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setFormat = "gif";
        }

        private void تحويلالصيغةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = newBitmap;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    
        private void سابياToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newBitmap = FIPfilter.ToGreyscale(newBitmap);
            pictureBox1.Image = newBitmap;
        
        }
        private void سلسلةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newBitmap = FIPfilter.ImageErosionFilterGS(newBitmap);
            pictureBox1.Image = newBitmap;

        }
        private void dDDDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newBitmap = FIPfilter.ImagePrewittFilterColor(newBitmap);
            pictureBox1.Image = newBitmap;
        
        }
        private void ادخالنصToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*InsertTextForm frm = new InsertTextForm();
            frm.Show();*/
            
        }
        public void InsertText(string text, int xPosition, int yPosition, string fontName, float fontSize, string fontStyle, string colorName1, string colorName2)
        {
            Bitmap temp = (Bitmap)_currentBitmap;
            newBitmap = (Bitmap)temp.Clone();
            Graphics gr = Graphics.FromImage(newBitmap);
            if (string.IsNullOrEmpty(fontName))
                fontName = "Times New Roman";
            if (fontSize.Equals(null))
                fontSize = 10.0F;
            Font font = new Font(fontName, fontSize);
            if (!string.IsNullOrEmpty(fontStyle))
            {
                FontStyle fStyle = FontStyle.Regular;
                switch (fontStyle.ToLower())
                {
                    case "bold":
                        fStyle = FontStyle.Bold;
                        break;
                    case "italic":
                        fStyle = FontStyle.Italic;
                        break;
                    case "underline":
                        fStyle = FontStyle.Underline;
                        break;
                    case "strikeout":
                        fStyle = FontStyle.Strikeout;
                        break;

                }
                font = new Font(fontName, fontSize, fStyle);
            }
            if (string.IsNullOrEmpty(colorName1))
                colorName1 = "Black";
            if (string.IsNullOrEmpty(colorName2))
                colorName2 = colorName1;
            Color color1 = Color.FromName(colorName1);
            Color color2 = Color.FromName(colorName2);
            int gW = (int)(text.Length * fontSize);
            gW = gW == 0 ? 10 : gW;
            System.Drawing.Drawing2D.LinearGradientBrush LGBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, gW, (int)fontSize), color1, color2, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            gr.DrawString(text, font, LGBrush, xPosition, yPosition);
            _currentBitmap = (Bitmap)newBitmap.Clone();
            newBitmap = imageHandler.CurrentBitmap;
            pictureBox1.Image = newBitmap;
  
        }


        public void InsertText(string text, int xPosition, int yPosition)
        {
            Bitmap temp = (Bitmap)_currentBitmap;
            Bitmap bmap = (Bitmap)temp.Clone();
            Graphics gr = Graphics.FromImage(bmap);
            string fontName="", fontStyle="",colorName1="", colorName2="";
            float fontSize=0;

            if (string.IsNullOrEmpty(fontName))
                fontName = "Times New Roman";
            if (fontSize.Equals(null))
                fontSize = 10.0F;
            Font font = new Font(fontName, fontSize);
            if (!string.IsNullOrEmpty(fontStyle))
            {
                FontStyle fStyle = FontStyle.Regular;
                switch (fontStyle.ToLower())
                {
                    case "bold":
                        fStyle = FontStyle.Bold;
                        break;
                    case "italic":
                        fStyle = FontStyle.Italic;
                        break;
                    case "underline":
                        fStyle = FontStyle.Underline;
                        break;
                    case "strikeout":
                        fStyle = FontStyle.Strikeout;
                        break;

                }
                font = new Font(fontName, fontSize, fStyle);
            }
            
            if (string.IsNullOrEmpty(colorName1))
                colorName1 = "Black";
            if (string.IsNullOrEmpty(colorName2))
                colorName2 = colorName1;
            Color color1 = Color.FromName(colorName1);
            Color color2 = Color.FromName(colorName2);
            int gW = (int)(text.Length * fontSize);
            gW = gW == 0 ? 10 : gW;
            System.Drawing.Drawing2D.LinearGradientBrush LGBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, gW, (int)fontSize), color1, color2, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            gr.DrawString(text, font, LGBrush, xPosition, yPosition);
            _currentBitmap = (Bitmap)bmap.Clone();
            newBitmap = imageHandler.CurrentBitmap;
            pictureBox1.Image = newBitmap;

            }
            public void InsertImage(string imagePath, int xPosition, int yPosition)
            {
                Bitmap temp = (Bitmap)_currentBitmap;
                Bitmap bmap = (Bitmap)temp.Clone();
                Graphics gr = Graphics.FromImage(bmap);
                if (!string.IsNullOrEmpty(imagePath))
                {
                    Bitmap i_bitmap = (Bitmap)Bitmap.FromFile(imagePath);
                    Rectangle rect = new Rectangle(xPosition, yPosition, i_bitmap.Width, i_bitmap.Height);
                    gr.DrawImage(Bitmap.FromFile(imagePath), rect);
                }
                _currentBitmap = (Bitmap)bmap.Clone();
                newBitmap = imageHandler.CurrentBitmap;
                pictureBox1.Image = newBitmap;
  
   
        
            }

            private void عكسالصورةToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void ffToolStripMenuItem_Click(object sender, EventArgs e)
            {
                newBitmap = FIPfilter.ContrastStretching(newBitmap);
                pictureBox1.Image = newBitmap;
        
            }

            private void قلمToolStripMenuItem_Click(object sender, EventArgs e)
            {
                System.Drawing.Graphics graphicsobj;
                graphicsobj = this.CreateGraphics();
                Pen mypen = new Pen(System.Drawing.Color.Red, 5);
                mypen.Color = System.Drawing.Color.RoyalBlue;
                mypen.Width = 3;
                mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                mypen.Color = System.Drawing.Color.RoyalBlue;
 
            }

            private void Main_Load(object sender, EventArgs e)
            {

            }

            private void oooToolStripMenuItem_Click(object sender, EventArgs e)
            {
                DialogResult dr = saveFileDialog1.ShowDialog();
              if (dr == DialogResult.OK)
                  {
            if (opened)
            {
            if
         (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length -3).ToLower() == "bmp")
          {
            file.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
          }
            if
            (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length -
            3).ToLower() == "jpg")
            {
                file.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
            if
            (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length -
            3).ToLower() == "png")
            {
                file.Save(saveFileDialog1.FileName, ImageFormat.Png);
            }
            if
            (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length -
            3).ToLower() == "gif")
            {
                file.Save(saveFileDialog1.FileName, ImageFormat.Gif);
            }
            }
            else
            {
                MessageBox.Show("enter an image first!!");
            }
                  }

            }

            private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
            {
                if (startPaint)
                {
                    g = pictureBox1.CreateGraphics();
                    SolidBrush MysolidBrush = new SolidBrush(Color.Black);
                    float newX = (float)pictureBox1.Image.Size.Width / (float)pictureBox1.Size.Width;
                    float newY = (float)pictureBox1.Image.Size.Height / (float)pictureBox1.Size.Height;
                    g = Graphics.FromImage(pictureBox1.Image);
                    
                    g.FillEllipse(MysolidBrush, e.X * newX, e.Y * newY, Convert.ToInt32("5"), Convert.ToInt32("5"));
                    pictureBox1.Refresh();
                    /*
                    //Setting the Pen BackColor and line Width
                    Pen p = new Pen(Color.Black, float.Parse("6"));
                    //Drawing the line.
                    g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                    initX = e.X;
                    initY = e.Y;
                     * */
                }
            }

            private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
            {
                startPaint = true;
                
                    //Use Solid Brush for filling the graphic shapes
             //       SolidBrush sb = new SolidBrush(Color.Black);
                    //setting the width and height same for creating square.
                    //Getting the width and Heigt value from Textbox(txt_ShapeSize)
             //       g.FillRectangle(sb, e.X, e.Y, int.Parse("9"), int.Parse("9"));
                    //setting startPaint and drawSquare value to false for creating one graphic on one click.
                    //startPaint = false;
            }

            private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
            {
                startPaint = false;
                initX = null;
                initY = null;
                
                newBitmap = (Bitmap)pictureBox1.Image;
                pictureBox1.Image = newBitmap;
            }
        }
 }
