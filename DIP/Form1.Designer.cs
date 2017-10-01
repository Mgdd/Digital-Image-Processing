using IPLab;
using System;
using System.Drawing;
namespace DIP
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.القائمهالرئيسيهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.oooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تدويرلليمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تدويرلليسارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تراجعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المؤثراتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سلبيToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سابياToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.الوانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.احمرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اخضرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ازرقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سابياToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مرآهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تحويلالصيغةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jpgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادخالنصToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.سلسلةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDDDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.كتابةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قلمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(234, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.القائمهالرئيسيهToolStripMenuItem,
            this.التعديلToolStripMenuItem,
            this.المؤثراتToolStripMenuItem,
            this.الوانToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.تحويلالصيغةToolStripMenuItem,
            this.اضافةToolStripMenuItem,
            this.كتابةToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 136;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // القائمهالرئيسيهToolStripMenuItem
            // 
            this.القائمهالرئيسيهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Save,
            this.oooToolStripMenuItem});
            this.القائمهالرئيسيهToolStripMenuItem.Name = "القائمهالرئيسيهToolStripMenuItem";
            this.القائمهالرئيسيهToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.القائمهالرئيسيهToolStripMenuItem.Text = "القائمه الرئيسيه";
            this.القائمهالرئيسيهToolStripMenuItem.Click += new System.EventHandler(this.القائمهالرئيسيهToolStripMenuItem_Click);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(167, 22);
            this.Open.Text = "فتح";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(167, 22);
            this.Save.Text = "حفظ";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // oooToolStripMenuItem
            // 
            this.oooToolStripMenuItem.Name = "oooToolStripMenuItem";
            this.oooToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.oooToolStripMenuItem.Text = "حفظ بالصيغة الجديدة";
            this.oooToolStripMenuItem.Click += new System.EventHandler(this.oooToolStripMenuItem_Click);
            // 
            // التعديلToolStripMenuItem
            // 
            this.التعديلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تدويرلليمينToolStripMenuItem,
            this.تدويرلليسارToolStripMenuItem,
            this.تراجعToolStripMenuItem});
            this.التعديلToolStripMenuItem.Name = "التعديلToolStripMenuItem";
            this.التعديلToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.التعديلToolStripMenuItem.Text = "التعديل";
            this.التعديلToolStripMenuItem.Click += new System.EventHandler(this.التعديلToolStripMenuItem_Click);
            // 
            // تدويرلليمينToolStripMenuItem
            // 
            this.تدويرلليمينToolStripMenuItem.Name = "تدويرلليمينToolStripMenuItem";
            this.تدويرلليمينToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.تدويرلليمينToolStripMenuItem.Text = "تدوير لليمين";
            this.تدويرلليمينToolStripMenuItem.Click += new System.EventHandler(this.تدويرلليمينToolStripMenuItem_Click);
            // 
            // تدويرلليسارToolStripMenuItem
            // 
            this.تدويرلليسارToolStripMenuItem.Name = "تدويرلليسارToolStripMenuItem";
            this.تدويرلليسارToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.تدويرلليسارToolStripMenuItem.Text = "تدوير لليسار";
            this.تدويرلليسارToolStripMenuItem.Click += new System.EventHandler(this.تدويرلليسارToolStripMenuItem_Click);
            // 
            // تراجعToolStripMenuItem
            // 
            this.تراجعToolStripMenuItem.Name = "تراجعToolStripMenuItem";
            this.تراجعToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.تراجعToolStripMenuItem.Text = "تراجع";
            this.تراجعToolStripMenuItem.Click += new System.EventHandler(this.تراجعToolStripMenuItem_Click);
            // 
            // المؤثراتToolStripMenuItem
            // 
            this.المؤثراتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.سلبيToolStripMenuItem,
            this.aaToolStripMenuItem,
            this.sobleToolStripMenuItem,
            this.سابياToolStripMenuItem1});
            this.المؤثراتToolStripMenuItem.Name = "المؤثراتToolStripMenuItem";
            this.المؤثراتToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.المؤثراتToolStripMenuItem.Text = "المؤثرات";
            // 
            // سلبيToolStripMenuItem
            // 
            this.سلبيToolStripMenuItem.Name = "سلبيToolStripMenuItem";
            this.سلبيToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.سلبيToolStripMenuItem.Text = "سلبي";
            this.سلبيToolStripMenuItem.Click += new System.EventHandler(this.سلبيToolStripMenuItem_Click);
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.aaToolStripMenuItem.Text = "histrogam";
            this.aaToolStripMenuItem.Click += new System.EventHandler(this.aaToolStripMenuItem_Click_1);
            // 
            // sobleToolStripMenuItem
            // 
            this.sobleToolStripMenuItem.Name = "sobleToolStripMenuItem";
            this.sobleToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sobleToolStripMenuItem.Text = "soble";
            this.sobleToolStripMenuItem.Click += new System.EventHandler(this.sobleToolStripMenuItem_Click);
            // 
            // سابياToolStripMenuItem1
            // 
            this.سابياToolStripMenuItem1.Name = "سابياToolStripMenuItem1";
            this.سابياToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            // 
            // الوانToolStripMenuItem
            // 
            this.الوانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.احمرToolStripMenuItem,
            this.اخضرToolStripMenuItem,
            this.ازرقToolStripMenuItem,
            this.سابياToolStripMenuItem});
            this.الوانToolStripMenuItem.Name = "الوانToolStripMenuItem";
            this.الوانToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.الوانToolStripMenuItem.Text = "الوان";
            // 
            // احمرToolStripMenuItem
            // 
            this.احمرToolStripMenuItem.Name = "احمرToolStripMenuItem";
            this.احمرToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.احمرToolStripMenuItem.Text = "احمر";
            this.احمرToolStripMenuItem.Click += new System.EventHandler(this.احمرToolStripMenuItem_Click);
            // 
            // اخضرToolStripMenuItem
            // 
            this.اخضرToolStripMenuItem.Name = "اخضرToolStripMenuItem";
            this.اخضرToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.اخضرToolStripMenuItem.Text = "اخضر";
            this.اخضرToolStripMenuItem.Click += new System.EventHandler(this.اخضرToolStripMenuItem_Click);
            // 
            // ازرقToolStripMenuItem
            // 
            this.ازرقToolStripMenuItem.Name = "ازرقToolStripMenuItem";
            this.ازرقToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.ازرقToolStripMenuItem.Text = "ازرق";
            this.ازرقToolStripMenuItem.Click += new System.EventHandler(this.ازرقToolStripMenuItem_Click);
            // 
            // سابياToolStripMenuItem
            // 
            this.سابياToolStripMenuItem.Name = "سابياToolStripMenuItem";
            this.سابياToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.سابياToolStripMenuItem.Text = "رمادي";
            this.سابياToolStripMenuItem.Click += new System.EventHandler(this.سابياToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مرآهToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.viewToolStripMenuItem.Text = "الإنعكاس";
            // 
            // مرآهToolStripMenuItem
            // 
            this.مرآهToolStripMenuItem.Name = "مرآهToolStripMenuItem";
            this.مرآهToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.مرآهToolStripMenuItem.Text = "مرآه";
            this.مرآهToolStripMenuItem.Click += new System.EventHandler(this.مرآهToolStripMenuItem_Click);
            // 
            // تحويلالصيغةToolStripMenuItem
            // 
            this.تحويلالصيغةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmpToolStripMenuItem,
            this.jpgToolStripMenuItem,
            this.pngToolStripMenuItem,
            this.gifToolStripMenuItem});
            this.تحويلالصيغةToolStripMenuItem.Name = "تحويلالصيغةToolStripMenuItem";
            this.تحويلالصيغةToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.تحويلالصيغةToolStripMenuItem.Text = "تحويل الصيغة";
            this.تحويلالصيغةToolStripMenuItem.Click += new System.EventHandler(this.تحويلالصيغةToolStripMenuItem_Click);
            // 
            // bmpToolStripMenuItem
            // 
            this.bmpToolStripMenuItem.Name = "bmpToolStripMenuItem";
            this.bmpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.bmpToolStripMenuItem.Text = "bmp";
            this.bmpToolStripMenuItem.Click += new System.EventHandler(this.bmpToolStripMenuItem_Click);
            // 
            // jpgToolStripMenuItem
            // 
            this.jpgToolStripMenuItem.Name = "jpgToolStripMenuItem";
            this.jpgToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.jpgToolStripMenuItem.Text = "jpg";
            // 
            // pngToolStripMenuItem
            // 
            this.pngToolStripMenuItem.Name = "pngToolStripMenuItem";
            this.pngToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.pngToolStripMenuItem.Text = "png";
            this.pngToolStripMenuItem.Click += new System.EventHandler(this.pngToolStripMenuItem_Click);
            // 
            // gifToolStripMenuItem
            // 
            this.gifToolStripMenuItem.Name = "gifToolStripMenuItem";
            this.gifToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.gifToolStripMenuItem.Text = "gif";
            this.gifToolStripMenuItem.Click += new System.EventHandler(this.gifToolStripMenuItem_Click);
            // 
            // اضافةToolStripMenuItem
            // 
            this.اضافةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ادخالنصToolStripMenuItem1,
            this.سلسلةToolStripMenuItem,
            this.dDDDDToolStripMenuItem,
            this.ffToolStripMenuItem});
            this.اضافةToolStripMenuItem.Name = "اضافةToolStripMenuItem";
            this.اضافةToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.اضافةToolStripMenuItem.Text = "اضافة";
            // 
            // ادخالنصToolStripMenuItem1
            // 
            this.ادخالنصToolStripMenuItem1.Name = "ادخالنصToolStripMenuItem1";
            this.ادخالنصToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.ادخالنصToolStripMenuItem1.Text = "ادخال نص";
            this.ادخالنصToolStripMenuItem1.Click += new System.EventHandler(this.ادخالنصToolStripMenuItem1_Click);
            // 
            // سلسلةToolStripMenuItem
            // 
            this.سلسلةToolStripMenuItem.Name = "سلسلةToolStripMenuItem";
            this.سلسلةToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.سلسلةToolStripMenuItem.Text = "ايروسن";
            this.سلسلةToolStripMenuItem.Click += new System.EventHandler(this.سلسلةToolStripMenuItem_Click);
            // 
            // dDDDDToolStripMenuItem
            // 
            this.dDDDDToolStripMenuItem.Name = "dDDDDToolStripMenuItem";
            this.dDDDDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dDDDDToolStripMenuItem.Text = "بري وايت";
            this.dDDDDToolStripMenuItem.Click += new System.EventHandler(this.dDDDDToolStripMenuItem_Click);
            // 
            // ffToolStripMenuItem
            // 
            this.ffToolStripMenuItem.Name = "ffToolStripMenuItem";
            this.ffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ffToolStripMenuItem.Text = "كونتراست";
            this.ffToolStripMenuItem.Click += new System.EventHandler(this.ffToolStripMenuItem_Click);
            // 
            // كتابةToolStripMenuItem
            // 
            this.كتابةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.قلمToolStripMenuItem});
            this.كتابةToolStripMenuItem.Name = "كتابةToolStripMenuItem";
            this.كتابةToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.كتابةToolStripMenuItem.Text = "كتابة";
            // 
            // قلمToolStripMenuItem
            // 
            this.قلمToolStripMenuItem.Name = "قلمToolStripMenuItem";
            this.قلمToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.قلمToolStripMenuItem.Text = "قلم";
            this.قلمToolStripMenuItem.Click += new System.EventHandler(this.قلمToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 137;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 21);
            this.label2.TabIndex = 138;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 139;
            this.label3.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1074, 398);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.Text = "معالجة الصور الرقمية";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Bitmap backup = null;
        private System.Drawing.Bitmap image = null;
        private string fileName = null;
       private float zoom = 1;
        private IDocumentsHost host = null;

        private bool cropping = false;
        private bool dragging = false;
        private Point start, end, startW, endW;
        public event EventHandler DocumentChanged;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem القائمهالرئيسيهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem التعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تدويرلليمينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تدويرلليسارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المؤثراتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سلبيToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تراجعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الوانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem احمرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اخضرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ازرقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مرآهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تحويلالصيغةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jpgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سابياToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ادخالنصToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem سابياToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem سلسلةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDDDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem كتابةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قلمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oooToolStripMenuItem;
    }
}

