namespace GVMSAPR
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonIncrease = new System.Windows.Forms.Button();
            this.buttonDecrease = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ReflectX = new System.Windows.Forms.Button();
            this.buttonRotateRight = new System.Windows.Forms.Button();
            this.buttonRotateLeft = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(799, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текущее разрешение изображения";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(808, 72);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(29, 17);
            this.labelX.TabIndex = 6;
            this.labelX.Text = "X =";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelY.Location = new System.Drawing.Point(924, 72);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(29, 17);
            this.labelY.TabIndex = 7;
            this.labelY.Text = "Y =";
            // 
            // buttonIncrease
            // 
            this.buttonIncrease.BackgroundImage = global::GVMSAPR.Properties.Resources.Increase;
            this.buttonIncrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonIncrease.Location = new System.Drawing.Point(715, 194);
            this.buttonIncrease.Name = "buttonIncrease";
            this.buttonIncrease.Size = new System.Drawing.Size(72, 70);
            this.buttonIncrease.TabIndex = 9;
            this.buttonIncrease.UseVisualStyleBackColor = true;
            this.buttonIncrease.Click += new System.EventHandler(this.buttonIncrease_Click);
            // 
            // buttonDecrease
            // 
            this.buttonDecrease.BackgroundImage = global::GVMSAPR.Properties.Resources.Decrease_;
            this.buttonDecrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDecrease.Location = new System.Drawing.Point(637, 194);
            this.buttonDecrease.Name = "buttonDecrease";
            this.buttonDecrease.Size = new System.Drawing.Size(72, 70);
            this.buttonDecrease.TabIndex = 8;
            this.buttonDecrease.UseVisualStyleBackColor = true;
            this.buttonDecrease.Click += new System.EventHandler(this.buttonDecrease_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::GVMSAPR.Properties.Resources.ReflectY;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(715, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 70);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ReflectX
            // 
            this.ReflectX.BackgroundImage = global::GVMSAPR.Properties.Resources.icons8_отразить_по_вертикали_96;
            this.ReflectX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReflectX.Location = new System.Drawing.Point(637, 117);
            this.ReflectX.Name = "ReflectX";
            this.ReflectX.Size = new System.Drawing.Size(72, 70);
            this.ReflectX.TabIndex = 3;
            this.ReflectX.UseVisualStyleBackColor = true;
            this.ReflectX.Click += new System.EventHandler(this.ReflectX_Click);
            // 
            // buttonRotateRight
            // 
            this.buttonRotateRight.BackgroundImage = global::GVMSAPR.Properties.Resources.RotateRight;
            this.buttonRotateRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotateRight.Location = new System.Drawing.Point(715, 40);
            this.buttonRotateRight.Name = "buttonRotateRight";
            this.buttonRotateRight.Size = new System.Drawing.Size(72, 70);
            this.buttonRotateRight.TabIndex = 2;
            this.buttonRotateRight.UseVisualStyleBackColor = true;
            this.buttonRotateRight.Click += new System.EventHandler(this.buttonRotateRight_Click);
            // 
            // buttonRotateLeft
            // 
            this.buttonRotateLeft.BackgroundImage = global::GVMSAPR.Properties.Resources.RotateLeft;
            this.buttonRotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotateLeft.Location = new System.Drawing.Point(637, 40);
            this.buttonRotateLeft.Name = "buttonRotateLeft";
            this.buttonRotateLeft.Size = new System.Drawing.Size(72, 70);
            this.buttonRotateLeft.TabIndex = 1;
            this.buttonRotateLeft.UseVisualStyleBackColor = true;
            this.buttonRotateLeft.Click += new System.EventHandler(this.buttonRotateLeft_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 40);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(572, 491);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(572, 491);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 541);
            this.Controls.Add(this.buttonIncrease);
            this.Controls.Add(this.buttonDecrease);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ReflectX);
            this.Controls.Add(this.buttonRotateRight);
            this.Controls.Add(this.buttonRotateLeft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRotateLeft;
        private System.Windows.Forms.Button buttonRotateRight;
        private System.Windows.Forms.Button ReflectX;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button buttonDecrease;
        private System.Windows.Forms.Button buttonIncrease;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

