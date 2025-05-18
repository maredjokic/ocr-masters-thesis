namespace CryptographyAndImageProcessing
{
    partial class ExtractedText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractedText));
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbExtractedText = new System.Windows.Forms.RichTextBox();
            this.cbxExtractText = new System.Windows.Forms.ComboBox();
            this.btnExtractText = new System.Windows.Forms.Button();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfidance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChoseOption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(1206, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 36;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 690);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // rtbExtractedText
            // 
            this.rtbExtractedText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtbExtractedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExtractedText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbExtractedText.Location = new System.Drawing.Point(597, 56);
            this.rtbExtractedText.Name = "rtbExtractedText";
            this.rtbExtractedText.Size = new System.Drawing.Size(575, 646);
            this.rtbExtractedText.TabIndex = 38;
            this.rtbExtractedText.Text = "";
            // 
            // cbxExtractText
            // 
            this.cbxExtractText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxExtractText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxExtractText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxExtractText.FormattingEnabled = true;
            this.cbxExtractText.Location = new System.Drawing.Point(597, 29);
            this.cbxExtractText.Name = "cbxExtractText";
            this.cbxExtractText.Size = new System.Drawing.Size(125, 21);
            this.cbxExtractText.TabIndex = 43;
            // 
            // btnExtractText
            // 
            this.btnExtractText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExtractText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractText.Location = new System.Drawing.Point(746, 12);
            this.btnExtractText.Name = "btnExtractText";
            this.btnExtractText.Size = new System.Drawing.Size(80, 38);
            this.btnExtractText.TabIndex = 44;
            this.btnExtractText.Text = "Extract Text";
            this.btnExtractText.UseVisualStyleBackColor = false;
            this.btnExtractText.Click += new System.EventHandler(this.btnExtractText_Click);
            // 
            // btnSaveText
            // 
            this.btnSaveText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveText.Location = new System.Drawing.Point(981, 12);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(80, 38);
            this.btnSaveText.TabIndex = 45;
            this.btnSaveText.Text = "Save Text in file";
            this.btnSaveText.UseVisualStyleBackColor = false;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Confidance:";
            // 
            // lblConfidance
            // 
            this.lblConfidance.AutoSize = true;
            this.lblConfidance.Location = new System.Drawing.Point(926, 37);
            this.lblConfidance.Name = "lblConfidance";
            this.lblConfidance.Size = new System.Drawing.Size(18, 13);
            this.lblConfidance.TabIndex = 47;
            this.lblConfidance.Text = "-/-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Method:";
            // 
            // lblChoseOption
            // 
            this.lblChoseOption.AutoSize = true;
            this.lblChoseOption.Location = new System.Drawing.Point(855, 12);
            this.lblChoseOption.Name = "lblChoseOption";
            this.lblChoseOption.Size = new System.Drawing.Size(80, 13);
            this.lblChoseOption.TabIndex = 49;
            this.lblChoseOption.Text = "Choose options";
            // 
            // ExtractedText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1237, 714);
            this.Controls.Add(this.lblChoseOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblConfidance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveText);
            this.Controls.Add(this.btnExtractText);
            this.Controls.Add(this.cbxExtractText);
            this.Controls.Add(this.rtbExtractedText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtractedText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtractedText";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtbExtractedText;
        private System.Windows.Forms.ComboBox cbxExtractText;
        private System.Windows.Forms.Button btnExtractText;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfidance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChoseOption;
    }
}