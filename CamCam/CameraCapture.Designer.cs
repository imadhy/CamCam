namespace CamCam
{
    partial class CameraCapture
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReloadImg = new System.Windows.Forms.Button();
            this.detScale = new System.Windows.Forms.Label();
            this.minNeigh = new System.Windows.Forms.Label();
            this.textBoxDetScale = new System.Windows.Forms.TextBox();
            this.comboBoxMinNeigh = new System.Windows.Forms.ComboBox();
            this.comboBoxScaleRate = new System.Windows.Forms.ComboBox();
            this.scaleRate = new System.Windows.Forms.Label();
            this.browsePic = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbExtractedFaces = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtractedFaces)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(350, 323);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 43);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Video";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(12, 12);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(508, 305);
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nb of Face Detected";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReloadImg);
            this.groupBox1.Controls.Add(this.detScale);
            this.groupBox1.Controls.Add(this.minNeigh);
            this.groupBox1.Controls.Add(this.textBoxDetScale);
            this.groupBox1.Controls.Add(this.comboBoxMinNeigh);
            this.groupBox1.Controls.Add(this.comboBoxScaleRate);
            this.groupBox1.Controls.Add(this.scaleRate);
            this.groupBox1.Location = new System.Drawing.Point(543, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 162);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detection Parameters";
            // 
            // buttonReloadImg
            // 
            this.buttonReloadImg.Location = new System.Drawing.Point(7, 129);
            this.buttonReloadImg.Name = "buttonReloadImg";
            this.buttonReloadImg.Size = new System.Drawing.Size(196, 23);
            this.buttonReloadImg.TabIndex = 6;
            this.buttonReloadImg.Text = "Reload Image";
            this.buttonReloadImg.UseVisualStyleBackColor = true;
            this.buttonReloadImg.Click += new System.EventHandler(this.buttonReloadImg_Click);
            // 
            // detScale
            // 
            this.detScale.AutoSize = true;
            this.detScale.Location = new System.Drawing.Point(6, 98);
            this.detScale.Name = "detScale";
            this.detScale.Size = new System.Drawing.Size(106, 13);
            this.detScale.TabIndex = 5;
            this.detScale.Text = "Min Detection Scale:";
            // 
            // minNeigh
            // 
            this.minNeigh.AutoSize = true;
            this.minNeigh.Location = new System.Drawing.Point(6, 70);
            this.minNeigh.Name = "minNeigh";
            this.minNeigh.Size = new System.Drawing.Size(78, 13);
            this.minNeigh.TabIndex = 4;
            this.minNeigh.Text = "Min Neighbors:";
            // 
            // textBoxDetScale
            // 
            this.textBoxDetScale.Location = new System.Drawing.Point(135, 95);
            this.textBoxDetScale.Name = "textBoxDetScale";
            this.textBoxDetScale.Size = new System.Drawing.Size(68, 20);
            this.textBoxDetScale.TabIndex = 3;
            this.textBoxDetScale.Text = "25";
            // 
            // comboBoxMinNeigh
            // 
            this.comboBoxMinNeigh.FormattingEnabled = true;
            this.comboBoxMinNeigh.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxMinNeigh.Location = new System.Drawing.Point(135, 67);
            this.comboBoxMinNeigh.Name = "comboBoxMinNeigh";
            this.comboBoxMinNeigh.Size = new System.Drawing.Size(68, 21);
            this.comboBoxMinNeigh.TabIndex = 2;
            this.comboBoxMinNeigh.Text = "4";
            // 
            // comboBoxScaleRate
            // 
            this.comboBoxScaleRate.FormattingEnabled = true;
            this.comboBoxScaleRate.Items.AddRange(new object[] {
            "1.1",
            "1.2",
            "1.3",
            "1.4"});
            this.comboBoxScaleRate.Location = new System.Drawing.Point(135, 39);
            this.comboBoxScaleRate.Name = "comboBoxScaleRate";
            this.comboBoxScaleRate.Size = new System.Drawing.Size(68, 21);
            this.comboBoxScaleRate.TabIndex = 1;
            this.comboBoxScaleRate.Text = "1.4";
            // 
            // scaleRate
            // 
            this.scaleRate.AutoSize = true;
            this.scaleRate.Location = new System.Drawing.Point(6, 42);
            this.scaleRate.Name = "scaleRate";
            this.scaleRate.Size = new System.Drawing.Size(107, 13);
            this.scaleRate.TabIndex = 0;
            this.scaleRate.Text = "Scale Increase Rate:";
            // 
            // browsePic
            // 
            this.browsePic.Location = new System.Drawing.Point(445, 323);
            this.browsePic.Name = "browsePic";
            this.browsePic.Size = new System.Drawing.Size(75, 43);
            this.browsePic.TabIndex = 7;
            this.browsePic.Text = "Browse Image";
            this.browsePic.UseVisualStyleBackColor = true;
            this.browsePic.Click += new System.EventHandler(this.browsePic_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // pbExtractedFaces
            // 
            this.pbExtractedFaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExtractedFaces.Location = new System.Drawing.Point(543, 180);
            this.pbExtractedFaces.Name = "pbExtractedFaces";
            this.pbExtractedFaces.Size = new System.Drawing.Size(112, 137);
            this.pbExtractedFaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExtractedFaces.TabIndex = 8;
            this.pbExtractedFaces.TabStop = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(543, 323);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 43);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(607, 322);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 43);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 371);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.pbExtractedFaces);
            this.Controls.Add(this.browsePic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CamImageBox);
            this.Controls.Add(this.btnStart);
            this.Name = "CameraCapture";
            this.Text = "Camera Output";
            this.Load += new System.EventHandler(this.CameraCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtractedFaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxScaleRate;
        private System.Windows.Forms.Label scaleRate;
        private System.Windows.Forms.Label minNeigh;
        private System.Windows.Forms.TextBox textBoxDetScale;
        private System.Windows.Forms.ComboBox comboBoxMinNeigh;
        private System.Windows.Forms.Label detScale;
        private System.Windows.Forms.Button browsePic;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonReloadImg;
        private System.Windows.Forms.PictureBox pbExtractedFaces;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
    }
}

