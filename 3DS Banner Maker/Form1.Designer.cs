namespace _3DS_Banner_Maker
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.previewBox = new System.Windows.Forms.GroupBox();
            this.bannerPreview = new System.Windows.Forms.PictureBox();
            this.icon48Preview = new System.Windows.Forms.PictureBox();
            this.icon24Preview = new System.Windows.Forms.PictureBox();
            this.loadBox = new System.Windows.Forms.GroupBox();
            this.loadBannerBtt = new System.Windows.Forms.Button();
            this.loadIcon48Btt = new System.Windows.Forms.Button();
            this.loadIcon24Btt = new System.Windows.Forms.Button();
            this.optionBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBox = new System.Windows.Forms.GroupBox();
            this.exportBannerBtt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.previewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon48Preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon24Preview)).BeginInit();
            this.loadBox.SuspendLayout();
            this.optionBox.SuspendLayout();
            this.infoBox.SuspendLayout();
            this.saveBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewBox
            // 
            this.previewBox.Controls.Add(this.icon24Preview);
            this.previewBox.Controls.Add(this.icon48Preview);
            this.previewBox.Controls.Add(this.bannerPreview);
            this.previewBox.Location = new System.Drawing.Point(12, 12);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(353, 175);
            this.previewBox.TabIndex = 0;
            this.previewBox.TabStop = false;
            this.previewBox.Text = "Preview:";
            // 
            // bannerPreview
            // 
            this.bannerPreview.Location = new System.Drawing.Point(19, 28);
            this.bannerPreview.Name = "bannerPreview";
            this.bannerPreview.Size = new System.Drawing.Size(256, 128);
            this.bannerPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bannerPreview.TabIndex = 0;
            this.bannerPreview.TabStop = false;
            // 
            // icon48Preview
            // 
            this.icon48Preview.Location = new System.Drawing.Point(281, 28);
            this.icon48Preview.Name = "icon48Preview";
            this.icon48Preview.Size = new System.Drawing.Size(48, 48);
            this.icon48Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon48Preview.TabIndex = 1;
            this.icon48Preview.TabStop = false;
            // 
            // icon24Preview
            // 
            this.icon24Preview.Location = new System.Drawing.Point(291, 93);
            this.icon24Preview.Name = "icon24Preview";
            this.icon24Preview.Size = new System.Drawing.Size(24, 24);
            this.icon24Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon24Preview.TabIndex = 2;
            this.icon24Preview.TabStop = false;
            // 
            // loadBox
            // 
            this.loadBox.Controls.Add(this.loadIcon24Btt);
            this.loadBox.Controls.Add(this.loadIcon48Btt);
            this.loadBox.Controls.Add(this.loadBannerBtt);
            this.loadBox.Location = new System.Drawing.Point(12, 204);
            this.loadBox.Name = "loadBox";
            this.loadBox.Size = new System.Drawing.Size(161, 144);
            this.loadBox.TabIndex = 1;
            this.loadBox.TabStop = false;
            this.loadBox.Text = "Load Images:";
            // 
            // loadBannerBtt
            // 
            this.loadBannerBtt.Location = new System.Drawing.Point(9, 19);
            this.loadBannerBtt.Name = "loadBannerBtt";
            this.loadBannerBtt.Size = new System.Drawing.Size(143, 35);
            this.loadBannerBtt.TabIndex = 0;
            this.loadBannerBtt.Text = "Load Banner Image";
            this.loadBannerBtt.UseVisualStyleBackColor = true;
            this.loadBannerBtt.Click += new System.EventHandler(this.loadBannerBtt_Click);
            // 
            // loadIcon48Btt
            // 
            this.loadIcon48Btt.Location = new System.Drawing.Point(9, 60);
            this.loadIcon48Btt.Name = "loadIcon48Btt";
            this.loadIcon48Btt.Size = new System.Drawing.Size(143, 35);
            this.loadIcon48Btt.TabIndex = 1;
            this.loadIcon48Btt.Text = "Load Icon (48x48)";
            this.loadIcon48Btt.UseVisualStyleBackColor = true;
            this.loadIcon48Btt.Click += new System.EventHandler(this.loadIcon48Btt_Click);
            // 
            // loadIcon24Btt
            // 
            this.loadIcon24Btt.Location = new System.Drawing.Point(9, 101);
            this.loadIcon24Btt.Name = "loadIcon24Btt";
            this.loadIcon24Btt.Size = new System.Drawing.Size(143, 35);
            this.loadIcon24Btt.TabIndex = 2;
            this.loadIcon24Btt.Text = "Load Icon (24x24)";
            this.loadIcon24Btt.UseVisualStyleBackColor = true;
            this.loadIcon24Btt.Click += new System.EventHandler(this.loadIcon24Btt_Click);
            // 
            // optionBox
            // 
            this.optionBox.Controls.Add(this.checkBox9);
            this.optionBox.Controls.Add(this.checkBox10);
            this.optionBox.Controls.Add(this.checkBox5);
            this.optionBox.Controls.Add(this.checkBox6);
            this.optionBox.Controls.Add(this.checkBox7);
            this.optionBox.Controls.Add(this.checkBox8);
            this.optionBox.Controls.Add(this.checkBox3);
            this.optionBox.Controls.Add(this.checkBox4);
            this.optionBox.Controls.Add(this.checkBox2);
            this.optionBox.Controls.Add(this.checkBox1);
            this.optionBox.Location = new System.Drawing.Point(386, 12);
            this.optionBox.Name = "optionBox";
            this.optionBox.Size = new System.Drawing.Size(143, 257);
            this.optionBox.TabIndex = 2;
            this.optionBox.TabStop = false;
            this.optionBox.Text = "Options:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(17, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "visibility";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "autoBoot";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(17, 97);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "requireEULA";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(17, 74);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(57, 17);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "use3D";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(17, 189);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(91, 17);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "useSaveData";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(17, 166);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(88, 17);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "gameRatings";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(17, 143);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(104, 17);
            this.checkBox7.TabIndex = 5;
            this.checkBox7.Text = "extendedBanner";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(17, 120);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(103, 17);
            this.checkBox8.TabIndex = 4;
            this.checkBox8.Text = "autoSaveOnExit";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(17, 235);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(99, 17);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Text = "disableSaveBU";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(17, 212);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(106, 17);
            this.checkBox10.TabIndex = 8;
            this.checkBox10.Text = "recordAppUsage";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.textBox3);
            this.infoBox.Controls.Add(this.label3);
            this.infoBox.Controls.Add(this.textBox2);
            this.infoBox.Controls.Add(this.label2);
            this.infoBox.Controls.Add(this.textBox1);
            this.infoBox.Controls.Add(this.label1);
            this.infoBox.Location = new System.Drawing.Point(180, 204);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(200, 144);
            this.infoBox.TabIndex = 3;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Long Title:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Short Title:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publisher:";
            // 
            // saveBox
            // 
            this.saveBox.Controls.Add(this.exportBannerBtt);
            this.saveBox.Location = new System.Drawing.Point(386, 270);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(143, 78);
            this.saveBox.TabIndex = 4;
            this.saveBox.TabStop = false;
            this.saveBox.Text = "Save:";
            // 
            // exportBannerBtt
            // 
            this.exportBannerBtt.Location = new System.Drawing.Point(6, 19);
            this.exportBannerBtt.Name = "exportBannerBtt";
            this.exportBannerBtt.Size = new System.Drawing.Size(131, 51);
            this.exportBannerBtt.TabIndex = 0;
            this.exportBannerBtt.Text = "Export Icon and Banner";
            this.exportBannerBtt.UseVisualStyleBackColor = true;
            this.exportBannerBtt.Click += new System.EventHandler(this.exportBannerBtt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "*.png|";
            this.openFileDialog1.InitialDirectory = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 360);
            this.Controls.Add(this.saveBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.optionBox);
            this.Controls.Add(this.loadBox);
            this.Controls.Add(this.previewBox);
            this.Name = "Form1";
            this.Text = "3DS Banner Maker";
            this.previewBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bannerPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon48Preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon24Preview)).EndInit();
            this.loadBox.ResumeLayout(false);
            this.optionBox.ResumeLayout(false);
            this.optionBox.PerformLayout();
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.saveBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox previewBox;
        private System.Windows.Forms.PictureBox icon24Preview;
        private System.Windows.Forms.PictureBox icon48Preview;
        private System.Windows.Forms.PictureBox bannerPreview;
        private System.Windows.Forms.GroupBox loadBox;
        private System.Windows.Forms.Button loadIcon24Btt;
        private System.Windows.Forms.Button loadIcon48Btt;
        private System.Windows.Forms.Button loadBannerBtt;
        private System.Windows.Forms.GroupBox optionBox;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox saveBox;
        private System.Windows.Forms.Button exportBannerBtt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

