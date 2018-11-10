namespace ImageEnhancement
{
    partial class ImageEnhancement
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageEnhancement));
            this.afterPicture = new System.Windows.Forms.PictureBox();
            this.beforePicture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.beforeGram = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.afterGram = new System.Windows.Forms.PictureBox();
            this.Path = new System.Windows.Forms.TextBox();
            this.choose = new System.Windows.Forms.Button();
            this.startEnhance = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.black_white = new System.Windows.Forms.Button();
            this.graying = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.store = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.afterPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforePicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforeGram)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterGram)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // afterPicture
            // 
            this.afterPicture.Location = new System.Drawing.Point(4, 25);
            this.afterPicture.Name = "afterPicture";
            this.afterPicture.Size = new System.Drawing.Size(640, 480);
            this.afterPicture.TabIndex = 0;
            this.afterPicture.TabStop = false;
            // 
            // beforePicture
            // 
            this.beforePicture.Location = new System.Drawing.Point(4, 25);
            this.beforePicture.Name = "beforePicture";
            this.beforePicture.Size = new System.Drawing.Size(640, 480);
            this.beforePicture.TabIndex = 1;
            this.beforePicture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.beforePicture);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 520);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原始图像";
            // 
            // groupBox2
            // 
            this.groupBox2.ContextMenuStrip = this.MenuStrip;
            this.groupBox2.Controls.Add(this.afterPicture);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(709, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 520);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "增强图像";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.beforeGram);
            this.groupBox3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(51, 610);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 240);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "原直方图";
            // 
            // beforeGram
            // 
            this.beforeGram.Location = new System.Drawing.Point(18, 25);
            this.beforeGram.Name = "beforeGram";
            this.beforeGram.Size = new System.Drawing.Size(512, 210);
            this.beforeGram.TabIndex = 0;
            this.beforeGram.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.afterGram);
            this.groupBox4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(779, 610);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(545, 240);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "新直方图";
            // 
            // afterGram
            // 
            this.afterGram.Location = new System.Drawing.Point(15, 25);
            this.afterGram.Name = "afterGram";
            this.afterGram.Size = new System.Drawing.Size(512, 210);
            this.afterGram.TabIndex = 1;
            this.afterGram.TabStop = false;
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(226, 25);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(430, 21);
            this.Path.TabIndex = 6;
            // 
            // choose
            // 
            this.choose.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choose.Location = new System.Drawing.Point(713, 16);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(93, 33);
            this.choose.TabIndex = 7;
            this.choose.Text = "选择图像";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // startEnhance
            // 
            this.startEnhance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startEnhance.Location = new System.Drawing.Point(835, 16);
            this.startEnhance.Name = "startEnhance";
            this.startEnhance.Size = new System.Drawing.Size(97, 33);
            this.startEnhance.TabIndex = 8;
            this.startEnhance.Text = "开始增强";
            this.startEnhance.UseVisualStyleBackColor = true;
            this.startEnhance.Click += new System.EventHandler(this.startEnhance_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // black_white
            // 
            this.black_white.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.black_white.Location = new System.Drawing.Point(963, 16);
            this.black_white.Name = "black_white";
            this.black_white.Size = new System.Drawing.Size(86, 33);
            this.black_white.TabIndex = 9;
            this.black_white.Text = "二值化";
            this.black_white.UseVisualStyleBackColor = true;
            this.black_white.Click += new System.EventHandler(this.black_white_Click);
            // 
            // graying
            // 
            this.graying.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.graying.Location = new System.Drawing.Point(1073, 16);
            this.graying.Name = "graying";
            this.graying.Size = new System.Drawing.Size(88, 33);
            this.graying.TabIndex = 10;
            this.graying.Text = "灰度化";
            this.graying.UseVisualStyleBackColor = true;
            this.graying.Click += new System.EventHandler(this.graying_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.store});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // store
            // 
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(152, 22);
            this.store.Text = "另存为";
            this.store.Click += new System.EventHandler(this.store_Click);
            // 
            // ImageEnhancement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 862);
            this.Controls.Add(this.graying);
            this.Controls.Add(this.black_white);
            this.Controls.Add(this.startEnhance);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 900);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "ImageEnhancement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageEnhancement V1.0.0.1";
            ((System.ComponentModel.ISupportInitialize)(this.afterPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforePicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beforeGram)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.afterGram)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox afterPicture;
        private System.Windows.Forms.PictureBox beforePicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Button startEnhance;
        private System.Windows.Forms.PictureBox beforeGram;
        private System.Windows.Forms.PictureBox afterGram;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button black_white;
        private System.Windows.Forms.Button graying;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem store;
    }
}

