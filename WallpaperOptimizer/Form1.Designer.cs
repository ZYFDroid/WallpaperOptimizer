namespace WallpaperOptimizer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.imgWallpaper = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBlurWidth = new System.Windows.Forms.Label();
            this.lblBlurAreaSustain = new System.Windows.Forms.Label();
            this.lblBlurBrightness = new System.Windows.Forms.Label();
            this.lblBlurRadius = new System.Windows.Forms.Label();
            this.numBlurAreaSustain = new System.Windows.Forms.TrackBar();
            this.numBlurBrightness = new System.Windows.Forms.TrackBar();
            this.numBlurRadius = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIconLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numBlurWidth = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSetWallpaper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgWallpaper)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlurAreaSustain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlurBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlurRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlurWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // imgWallpaper
            // 
            this.imgWallpaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgWallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgWallpaper.Location = new System.Drawing.Point(8, 8);
            this.imgWallpaper.Name = "imgWallpaper";
            this.imgWallpaper.Size = new System.Drawing.Size(699, 532);
            this.imgWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgWallpaper.TabIndex = 0;
            this.imgWallpaper.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgWallpaper);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(931, 548);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOpenFile);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSetWallpaper);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(707, 8);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(216, 532);
            this.panel2.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpenFile.Location = new System.Drawing.Point(8, 352);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(208, 45);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "打开其它图片";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblBlurWidth);
            this.panel3.Controls.Add(this.lblBlurAreaSustain);
            this.panel3.Controls.Add(this.lblBlurBrightness);
            this.panel3.Controls.Add(this.lblBlurRadius);
            this.panel3.Controls.Add(this.numBlurAreaSustain);
            this.panel3.Controls.Add(this.numBlurBrightness);
            this.panel3.Controls.Add(this.numBlurRadius);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmbIconLocation);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.numBlurWidth);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(8, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 397);
            this.panel3.TabIndex = 3;
            // 
            // lblBlurWidth
            // 
            this.lblBlurWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlurWidth.Location = new System.Drawing.Point(158, 63);
            this.lblBlurWidth.Name = "lblBlurWidth";
            this.lblBlurWidth.Size = new System.Drawing.Size(46, 23);
            this.lblBlurWidth.TabIndex = 7;
            this.lblBlurWidth.Text = "8.00";
            this.lblBlurWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBlurAreaSustain
            // 
            this.lblBlurAreaSustain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlurAreaSustain.Location = new System.Drawing.Point(159, 185);
            this.lblBlurAreaSustain.Name = "lblBlurAreaSustain";
            this.lblBlurAreaSustain.Size = new System.Drawing.Size(46, 23);
            this.lblBlurAreaSustain.TabIndex = 6;
            this.lblBlurAreaSustain.Text = "32";
            this.lblBlurAreaSustain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBlurBrightness
            // 
            this.lblBlurBrightness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlurBrightness.Location = new System.Drawing.Point(159, 144);
            this.lblBlurBrightness.Name = "lblBlurBrightness";
            this.lblBlurBrightness.Size = new System.Drawing.Size(46, 23);
            this.lblBlurBrightness.TabIndex = 6;
            this.lblBlurBrightness.Text = "0";
            this.lblBlurBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBlurRadius
            // 
            this.lblBlurRadius.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlurRadius.Location = new System.Drawing.Point(159, 103);
            this.lblBlurRadius.Name = "lblBlurRadius";
            this.lblBlurRadius.Size = new System.Drawing.Size(46, 23);
            this.lblBlurRadius.TabIndex = 6;
            this.lblBlurRadius.Text = "32";
            this.lblBlurRadius.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numBlurAreaSustain
            // 
            this.numBlurAreaSustain.AutoSize = false;
            this.numBlurAreaSustain.Location = new System.Drawing.Point(6, 185);
            this.numBlurAreaSustain.Maximum = 100;
            this.numBlurAreaSustain.Name = "numBlurAreaSustain";
            this.numBlurAreaSustain.Size = new System.Drawing.Size(156, 23);
            this.numBlurAreaSustain.TabIndex = 5;
            this.numBlurAreaSustain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.numBlurAreaSustain.Value = 32;
            this.numBlurAreaSustain.ValueChanged += new System.EventHandler(this.numBlurRadius_ValueChanged);
            // 
            // numBlurBrightness
            // 
            this.numBlurBrightness.AutoSize = false;
            this.numBlurBrightness.Location = new System.Drawing.Point(6, 144);
            this.numBlurBrightness.Maximum = 128;
            this.numBlurBrightness.Name = "numBlurBrightness";
            this.numBlurBrightness.Size = new System.Drawing.Size(156, 23);
            this.numBlurBrightness.TabIndex = 5;
            this.numBlurBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.numBlurBrightness.Value = 64;
            this.numBlurBrightness.ValueChanged += new System.EventHandler(this.numBlurRadius_ValueChanged);
            // 
            // numBlurRadius
            // 
            this.numBlurRadius.AutoSize = false;
            this.numBlurRadius.Location = new System.Drawing.Point(6, 103);
            this.numBlurRadius.Maximum = 128;
            this.numBlurRadius.Minimum = 2;
            this.numBlurRadius.Name = "numBlurRadius";
            this.numBlurRadius.Size = new System.Drawing.Size(156, 23);
            this.numBlurRadius.TabIndex = 5;
            this.numBlurRadius.TickStyle = System.Windows.Forms.TickStyle.None;
            this.numBlurRadius.Value = 32;
            this.numBlurRadius.ValueChanged += new System.EventHandler(this.numBlurRadius_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Blur area sustain percent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "模糊区域亮度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "模糊半径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "渐变区宽度（百分比宽度）";
            // 
            // cmbIconLocation
            // 
            this.cmbIconLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIconLocation.FormattingEnabled = true;
            this.cmbIconLocation.Items.AddRange(new object[] {
            "左边",
            "顶边",
            "右边",
            "底边"});
            this.cmbIconLocation.Location = new System.Drawing.Point(6, 25);
            this.cmbIconLocation.Name = "cmbIconLocation";
            this.cmbIconLocation.Size = new System.Drawing.Size(198, 20);
            this.cmbIconLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图标位置";
            // 
            // numBlurWidth
            // 
            this.numBlurWidth.AutoSize = false;
            this.numBlurWidth.Location = new System.Drawing.Point(6, 63);
            this.numBlurWidth.Maximum = 10000;
            this.numBlurWidth.Minimum = 200;
            this.numBlurWidth.Name = "numBlurWidth";
            this.numBlurWidth.Size = new System.Drawing.Size(155, 23);
            this.numBlurWidth.TabIndex = 8;
            this.numBlurWidth.TickStyle = System.Windows.Forms.TickStyle.None;
            this.numBlurWidth.Value = 800;
            this.numBlurWidth.ValueChanged += new System.EventHandler(this.numBlurRadius_ValueChanged);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(8, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "优化";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(8, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "便携网络图像|*.png";
            this.saveFileDialog.Title = "另存壁纸为";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "图像文件|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
            // 
            // btnSetWallpaper
            // 
            this.btnSetWallpaper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetWallpaper.Location = new System.Drawing.Point(8, 487);
            this.btnSetWallpaper.Name = "btnSetWallpaper";
            this.btnSetWallpaper.Size = new System.Drawing.Size(208, 45);
            this.btnSetWallpaper.TabIndex = 5;
            this.btnSetWallpaper.Text = "设为壁纸";
            this.btnSetWallpaper.UseVisualStyleBackColor = true;
            this.btnSetWallpaper.Click += new System.EventHandler(this.btnSetWallpaper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "壁纸优化器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgWallpaper)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlurAreaSustain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlurBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlurRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlurWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgWallpaper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbIconLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBlurRadius;
        private System.Windows.Forms.TrackBar numBlurRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBlurBrightness;
        private System.Windows.Forms.TrackBar numBlurBrightness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBlurAreaSustain;
        private System.Windows.Forms.TrackBar numBlurAreaSustain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblBlurWidth;
        private System.Windows.Forms.TrackBar numBlurWidth;
        private System.Windows.Forms.Button btnSetWallpaper;
    }
}

