namespace CryptographyAndImageProcessing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.documentShow = new System.Windows.Forms.PictureBox();
            this.btnSelectArea = new System.Windows.Forms.Button();
            this.btnCropArea = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.pictureBoxCrop = new System.Windows.Forms.PictureBox();
            this.pictureBoxCharacter = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblImgNum = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.binarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageInFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllOriginalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noiseRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forAllImagesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allThisFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forAllImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBinarization = new System.Windows.Forms.Button();
            this.cbxThreshold = new System.Windows.Forms.ComboBox();
            this.btnExtractText = new System.Windows.Forms.Button();
            this.cbxExtractText = new System.Windows.Forms.ComboBox();
            this.lblChar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Extraction = new System.Windows.Forms.GroupBox();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.numLineSize = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxExtractText1 = new System.Windows.Forms.ComboBox();
            this.cbxOneOrAllExtract = new System.Windows.Forms.ComboBox();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblExtractionIndex = new System.Windows.Forms.Label();
            this.lblExtractionResponse = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCharForSave = new System.Windows.Forms.TextBox();
            this.btnSaveCroped = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.conf = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackBarTreshold = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTryTreshold = new System.Windows.Forms.Button();
            this.rbtnTresholdAll = new System.Windows.Forms.RadioButton();
            this.rbtnForThisImage = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnShowInForm = new System.Windows.Forms.Button();
            this.rbtSaveText = new System.Windows.Forms.RadioButton();
            this.rbtShowText = new System.Windows.Forms.RadioButton();
            this.btnEditChars = new System.Windows.Forms.Button();
            this.tbxFolderName = new System.Windows.Forms.TextBox();
            this.tbxFolderCharacterDatabase = new System.Windows.Forms.TextBox();
            this.btnCharacterDatabase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timerTesseractExt = new System.Windows.Forms.Timer(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRotateImage = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.numRotateAngle = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.documentShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Extraction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLineSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTreshold)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRotateAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // documentShow
            // 
            this.documentShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.documentShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.documentShow.Location = new System.Drawing.Point(3, 1);
            this.documentShow.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.documentShow.Name = "documentShow";
            this.documentShow.Size = new System.Drawing.Size(690, 670);
            this.documentShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.documentShow.TabIndex = 2;
            this.documentShow.TabStop = false;
            this.documentShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.documentShow_MouseDown_1);
            this.documentShow.MouseEnter += new System.EventHandler(this.documentShow_MouseEnter_1);
            this.documentShow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.documentShow_MouseMove_1);
            // 
            // btnSelectArea
            // 
            this.btnSelectArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectArea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectArea.Location = new System.Drawing.Point(37, 183);
            this.btnSelectArea.Name = "btnSelectArea";
            this.btnSelectArea.Size = new System.Drawing.Size(91, 28);
            this.btnSelectArea.TabIndex = 5;
            this.btnSelectArea.Text = "Select area";
            this.btnSelectArea.UseVisualStyleBackColor = false;
            this.btnSelectArea.Click += new System.EventHandler(this.btnSelectArea_Click);
            // 
            // btnCropArea
            // 
            this.btnCropArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCropArea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCropArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCropArea.Location = new System.Drawing.Point(146, 183);
            this.btnCropArea.Name = "btnCropArea";
            this.btnCropArea.Size = new System.Drawing.Size(91, 28);
            this.btnCropArea.TabIndex = 6;
            this.btnCropArea.Text = "Crop area";
            this.btnCropArea.UseVisualStyleBackColor = false;
            this.btnCropArea.Click += new System.EventHandler(this.btnCropArea_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimize.Location = new System.Drawing.Point(1147, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 24);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaximize.Location = new System.Drawing.Point(1172, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(38, 25);
            this.btnMaximize.TabIndex = 8;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // lblDimensions
            // 
            this.lblDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.BackColor = System.Drawing.Color.Transparent;
            this.lblDimensions.Location = new System.Drawing.Point(97, 214);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(64, 13);
            this.lblDimensions.TabIndex = 10;
            this.lblDimensions.Text = "Dimensions:";
            // 
            // pictureBoxCrop
            // 
            this.pictureBoxCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCrop.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCrop.Location = new System.Drawing.Point(19, 19);
            this.pictureBoxCrop.Name = "pictureBoxCrop";
            this.pictureBoxCrop.Size = new System.Drawing.Size(229, 160);
            this.pictureBoxCrop.TabIndex = 11;
            this.pictureBoxCrop.TabStop = false;
            // 
            // pictureBoxCharacter
            // 
            this.pictureBoxCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCharacter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxCharacter.Location = new System.Drawing.Point(15, 19);
            this.pictureBoxCharacter.Name = "pictureBoxCharacter";
            this.pictureBoxCharacter.Size = new System.Drawing.Size(188, 165);
            this.pictureBoxCharacter.TabIndex = 12;
            this.pictureBoxCharacter.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.documentShow);
            this.panel1.Location = new System.Drawing.Point(244, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 679);
            this.panel1.TabIndex = 17;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrevious.Location = new System.Drawing.Point(13, 44);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(61, 30);
            this.btnPrevious.TabIndex = 27;
            this.btnPrevious.Text = "<-";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNext.Location = new System.Drawing.Point(86, 44);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 30);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "->";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblImgNum
            // 
            this.lblImgNum.AutoSize = true;
            this.lblImgNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgNum.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblImgNum.Location = new System.Drawing.Point(181, 49);
            this.lblImgNum.Name = "lblImgNum";
            this.lblImgNum.Size = new System.Drawing.Size(31, 20);
            this.lblImgNum.TabIndex = 29;
            this.lblImgNum.Text = "0/0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarizationToolStripMenuItem,
            this.editToolStripMenuItem,
            this.customFiltersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1237, 25);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // binarizationToolStripMenuItem
            // 
            this.binarizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getImagesToolStripMenuItem,
            this.saveImageInFileToolStripMenuItem});
            this.binarizationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.binarizationToolStripMenuItem.Name = "binarizationToolStripMenuItem";
            this.binarizationToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.binarizationToolStripMenuItem.Text = "File";
            // 
            // getImagesToolStripMenuItem
            // 
            this.getImagesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getImagesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.getImagesToolStripMenuItem.Name = "getImagesToolStripMenuItem";
            this.getImagesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.getImagesToolStripMenuItem.Text = "Get images";
            this.getImagesToolStripMenuItem.Click += new System.EventHandler(this.getImagesToolStripMenuItem_Click);
            // 
            // saveImageInFileToolStripMenuItem
            // 
            this.saveImageInFileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveImageInFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveImageInFileToolStripMenuItem.Name = "saveImageInFileToolStripMenuItem";
            this.saveImageInFileToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveImageInFileToolStripMenuItem.Text = "Save image in file";
            this.saveImageInFileToolStripMenuItem.Click += new System.EventHandler(this.saveImageInFileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropImageToolStripMenuItem,
            this.dropAllToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.getOriginalToolStripMenuItem,
            this.getAllOriginalsToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // dropImageToolStripMenuItem
            // 
            this.dropImageToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropImageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dropImageToolStripMenuItem.Name = "dropImageToolStripMenuItem";
            this.dropImageToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.dropImageToolStripMenuItem.Text = "Drop image";
            this.dropImageToolStripMenuItem.Click += new System.EventHandler(this.dropImageToolStripMenuItem_Click);
            // 
            // dropAllToolStripMenuItem
            // 
            this.dropAllToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropAllToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dropAllToolStripMenuItem.Name = "dropAllToolStripMenuItem";
            this.dropAllToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.dropAllToolStripMenuItem.Text = "Drop all";
            this.dropAllToolStripMenuItem.Click += new System.EventHandler(this.dropAllToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveImageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.saveImageToolStripMenuItem.Text = "Save image in app";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveAllToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.saveAllToolStripMenuItem.Text = "Save all in app";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // getOriginalToolStripMenuItem
            // 
            this.getOriginalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getOriginalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.getOriginalToolStripMenuItem.Name = "getOriginalToolStripMenuItem";
            this.getOriginalToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.getOriginalToolStripMenuItem.Text = "Get original from app";
            this.getOriginalToolStripMenuItem.Click += new System.EventHandler(this.getOriginalToolStripMenuItem_Click);
            // 
            // getAllOriginalsToolStripMenuItem
            // 
            this.getAllOriginalsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getAllOriginalsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.getAllOriginalsToolStripMenuItem.Name = "getAllOriginalsToolStripMenuItem";
            this.getAllOriginalsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.getAllOriginalsToolStripMenuItem.Text = "Get all originals from app";
            this.getAllOriginalsToolStripMenuItem.Click += new System.EventHandler(this.getAllOriginalsToolStripMenuItem_Click);
            // 
            // customFiltersToolStripMenuItem
            // 
            this.customFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayScaleToolStripMenuItem,
            this.binarisationToolStripMenuItem,
            this.noiseRemovalToolStripMenuItem,
            this.allThisFiltersToolStripMenuItem});
            this.customFiltersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.customFiltersToolStripMenuItem.Name = "customFiltersToolStripMenuItem";
            this.customFiltersToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.customFiltersToolStripMenuItem.Text = "Custom filters";
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grayScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forAllToolStripMenuItem});
            this.grayScaleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.grayScaleToolStripMenuItem.Text = "Gray scale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // forAllToolStripMenuItem
            // 
            this.forAllToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.forAllToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.forAllToolStripMenuItem.Name = "forAllToolStripMenuItem";
            this.forAllToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.forAllToolStripMenuItem.Text = "For all images";
            this.forAllToolStripMenuItem.Click += new System.EventHandler(this.forAllToolStripMenuItem_Click);
            // 
            // binarisationToolStripMenuItem
            // 
            this.binarisationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.binarisationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forAllToolStripMenuItem1});
            this.binarisationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.binarisationToolStripMenuItem.Name = "binarisationToolStripMenuItem";
            this.binarisationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.binarisationToolStripMenuItem.Text = "Binarisation";
            this.binarisationToolStripMenuItem.Click += new System.EventHandler(this.binarisationToolStripMenuItem_Click);
            // 
            // forAllToolStripMenuItem1
            // 
            this.forAllToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.forAllToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.forAllToolStripMenuItem1.Name = "forAllToolStripMenuItem1";
            this.forAllToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.forAllToolStripMenuItem1.Text = "For all images";
            this.forAllToolStripMenuItem1.Click += new System.EventHandler(this.forAllToolStripMenuItem1_Click);
            // 
            // noiseRemovalToolStripMenuItem
            // 
            this.noiseRemovalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.noiseRemovalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forAllImagesToolStripMenuItem1});
            this.noiseRemovalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.noiseRemovalToolStripMenuItem.Name = "noiseRemovalToolStripMenuItem";
            this.noiseRemovalToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.noiseRemovalToolStripMenuItem.Text = "Noise removal";
            this.noiseRemovalToolStripMenuItem.Click += new System.EventHandler(this.noiseRemovalToolStripMenuItem_Click);
            // 
            // forAllImagesToolStripMenuItem1
            // 
            this.forAllImagesToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.forAllImagesToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.forAllImagesToolStripMenuItem1.Name = "forAllImagesToolStripMenuItem1";
            this.forAllImagesToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.forAllImagesToolStripMenuItem1.Text = "For all images";
            this.forAllImagesToolStripMenuItem1.Click += new System.EventHandler(this.forAllImagesToolStripMenuItem1_Click);
            // 
            // allThisFiltersToolStripMenuItem
            // 
            this.allThisFiltersToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.allThisFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forAllImagesToolStripMenuItem});
            this.allThisFiltersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.allThisFiltersToolStripMenuItem.Name = "allThisFiltersToolStripMenuItem";
            this.allThisFiltersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.allThisFiltersToolStripMenuItem.Text = "All this filters";
            this.allThisFiltersToolStripMenuItem.Click += new System.EventHandler(this.allThisFiltersToolStripMenuItem_Click);
            // 
            // forAllImagesToolStripMenuItem
            // 
            this.forAllImagesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.forAllImagesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.forAllImagesToolStripMenuItem.Name = "forAllImagesToolStripMenuItem";
            this.forAllImagesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.forAllImagesToolStripMenuItem.Text = "For all images";
            this.forAllImagesToolStripMenuItem.Click += new System.EventHandler(this.forAllImagesToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(1207, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 24);
            this.btnExit.TabIndex = 35;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnBinarization
            // 
            this.btnBinarization.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBinarization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBinarization.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinarization.Location = new System.Drawing.Point(71, 180);
            this.btnBinarization.Name = "btnBinarization";
            this.btnBinarization.Size = new System.Drawing.Size(89, 38);
            this.btnBinarization.TabIndex = 36;
            this.btnBinarization.Text = "Save changes";
            this.btnBinarization.UseVisualStyleBackColor = false;
            this.btnBinarization.Click += new System.EventHandler(this.btnBinarization_Click);
            // 
            // cbxThreshold
            // 
            this.cbxThreshold.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxThreshold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxThreshold.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxThreshold.FormattingEnabled = true;
            this.cbxThreshold.Location = new System.Drawing.Point(15, 32);
            this.cbxThreshold.Name = "cbxThreshold";
            this.cbxThreshold.Size = new System.Drawing.Size(120, 21);
            this.cbxThreshold.TabIndex = 38;
            this.cbxThreshold.SelectedIndexChanged += new System.EventHandler(this.cbxThreshold_SelectedIndexChanged);
            // 
            // btnExtractText
            // 
            this.btnExtractText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExtractText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExtractText.Location = new System.Drawing.Point(21, 89);
            this.btnExtractText.Name = "btnExtractText";
            this.btnExtractText.Size = new System.Drawing.Size(80, 38);
            this.btnExtractText.TabIndex = 41;
            this.btnExtractText.Text = "Extract Text";
            this.btnExtractText.UseVisualStyleBackColor = false;
            this.btnExtractText.Click += new System.EventHandler(this.btnExtractText_Click);
            // 
            // cbxExtractText
            // 
            this.cbxExtractText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxExtractText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxExtractText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxExtractText.FormattingEnabled = true;
            this.cbxExtractText.Location = new System.Drawing.Point(45, 29);
            this.cbxExtractText.Name = "cbxExtractText";
            this.cbxExtractText.Size = new System.Drawing.Size(125, 21);
            this.cbxExtractText.TabIndex = 42;
            // 
            // lblChar
            // 
            this.lblChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChar.AutoSize = true;
            this.lblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChar.Location = new System.Drawing.Point(33, 203);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(44, 31);
            this.lblChar.TabIndex = 43;
            this.lblChar.Text = "__";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(125, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 45;
            this.button1.Text = "Stop extraction";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Extraction
            // 
            this.Extraction.Controls.Add(this.numDelay);
            this.Extraction.Controls.Add(this.numLineSize);
            this.Extraction.Controls.Add(this.label14);
            this.Extraction.Controls.Add(this.label13);
            this.Extraction.Controls.Add(this.label12);
            this.Extraction.Controls.Add(this.cbxExtractText1);
            this.Extraction.Controls.Add(this.cbxOneOrAllExtract);
            this.Extraction.Controls.Add(this.numHeight);
            this.Extraction.Controls.Add(this.numWidth);
            this.Extraction.Controls.Add(this.label6);
            this.Extraction.Controls.Add(this.label5);
            this.Extraction.Controls.Add(this.label4);
            this.Extraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Extraction.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Extraction.Location = new System.Drawing.Point(9, 4);
            this.Extraction.Name = "Extraction";
            this.Extraction.Size = new System.Drawing.Size(219, 173);
            this.Extraction.TabIndex = 46;
            this.Extraction.TabStop = false;
            this.Extraction.Text = "Parameters";
            this.Extraction.Enter += new System.EventHandler(this.Extraction_Enter);
            // 
            // numDelay
            // 
            this.numDelay.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numDelay.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.numDelay.Location = new System.Drawing.Point(128, 144);
            this.numDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(43, 20);
            this.numDelay.TabIndex = 68;
            // 
            // numLineSize
            // 
            this.numLineSize.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numLineSize.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.numLineSize.Location = new System.Drawing.Point(128, 120);
            this.numLineSize.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numLineSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLineSize.Name = "numLineSize";
            this.numLineSize.Size = new System.Drawing.Size(43, 20);
            this.numLineSize.TabIndex = 67;
            this.numLineSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Delay in ms:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Line size in px:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Extraction mode:";
            // 
            // cbxExtractText1
            // 
            this.cbxExtractText1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxExtractText1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxExtractText1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxExtractText1.FormattingEnabled = true;
            this.cbxExtractText1.Location = new System.Drawing.Point(45, 29);
            this.cbxExtractText1.Name = "cbxExtractText1";
            this.cbxExtractText1.Size = new System.Drawing.Size(125, 21);
            this.cbxExtractText1.TabIndex = 60;
            // 
            // cbxOneOrAllExtract
            // 
            this.cbxOneOrAllExtract.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxOneOrAllExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOneOrAllExtract.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxOneOrAllExtract.FormattingEnabled = true;
            this.cbxOneOrAllExtract.Location = new System.Drawing.Point(39, 96);
            this.cbxOneOrAllExtract.Name = "cbxOneOrAllExtract";
            this.cbxOneOrAllExtract.Size = new System.Drawing.Size(137, 21);
            this.cbxOneOrAllExtract.TabIndex = 55;
            // 
            // numHeight
            // 
            this.numHeight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numHeight.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.numHeight.Location = new System.Drawing.Point(153, 73);
            this.numHeight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(32, 20);
            this.numHeight.TabIndex = 54;
            // 
            // numWidth
            // 
            this.numWidth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numWidth.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.numWidth.Location = new System.Drawing.Point(67, 72);
            this.numWidth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(32, 20);
            this.numWidth.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Minimum character size in px:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(32, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 38);
            this.button2.TabIndex = 63;
            this.button2.Text = "Start extraction";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblExtractionIndex
            // 
            this.lblExtractionIndex.AutoSize = true;
            this.lblExtractionIndex.Location = new System.Drawing.Point(102, 238);
            this.lblExtractionIndex.Name = "lblExtractionIndex";
            this.lblExtractionIndex.Size = new System.Drawing.Size(24, 13);
            this.lblExtractionIndex.TabIndex = 56;
            this.lblExtractionIndex.Text = "0/0";
            // 
            // lblExtractionResponse
            // 
            this.lblExtractionResponse.AutoSize = true;
            this.lblExtractionResponse.Location = new System.Drawing.Point(40, 222);
            this.lblExtractionResponse.Name = "lblExtractionResponse";
            this.lblExtractionResponse.Size = new System.Drawing.Size(129, 13);
            this.lblExtractionResponse.TabIndex = 47;
            this.lblExtractionResponse.Text = "No extractions in progress";
            this.lblExtractionResponse.Click += new System.EventHandler(this.lblExtractionResponse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxCharForSave);
            this.groupBox1.Controls.Add(this.btnSaveCroped);
            this.groupBox1.Controls.Add(this.pictureBoxCrop);
            this.groupBox1.Controls.Add(this.btnSelectArea);
            this.groupBox1.Controls.Add(this.btnCropArea);
            this.groupBox1.Controls.Add(this.lblDimensions);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(959, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 288);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crop character";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Choose character:";
            // 
            // tbxCharForSave
            // 
            this.tbxCharForSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCharForSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxCharForSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCharForSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCharForSave.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxCharForSave.Location = new System.Drawing.Point(155, 226);
            this.tbxCharForSave.MaxLength = 1;
            this.tbxCharForSave.Name = "tbxCharForSave";
            this.tbxCharForSave.Size = new System.Drawing.Size(39, 26);
            this.tbxCharForSave.TabIndex = 51;
            // 
            // btnSaveCroped
            // 
            this.btnSaveCroped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCroped.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveCroped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCroped.Location = new System.Drawing.Point(94, 255);
            this.btnSaveCroped.Name = "btnSaveCroped";
            this.btnSaveCroped.Size = new System.Drawing.Size(100, 28);
            this.btnSaveCroped.TabIndex = 14;
            this.btnSaveCroped.Text = "Save character";
            this.btnSaveCroped.UseVisualStyleBackColor = false;
            this.btnSaveCroped.Click += new System.EventHandler(this.btnSaveCroped_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.conf);
            this.groupBox2.Controls.Add(this.pictureBoxCharacter);
            this.groupBox2.Controls.Add(this.lblChar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(7, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 251);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(124, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Confidance:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Char:";
            // 
            // conf
            // 
            this.conf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.conf.AutoSize = true;
            this.conf.Location = new System.Drawing.Point(137, 221);
            this.conf.Name = "conf";
            this.conf.Size = new System.Drawing.Size(37, 13);
            this.conf.TabIndex = 44;
            this.conf.Text = "_____";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackBarTreshold);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnTryTreshold);
            this.groupBox3.Controls.Add(this.rbtnTresholdAll);
            this.groupBox3.Controls.Add(this.rbtnForThisImage);
            this.groupBox3.Controls.Add(this.cbxThreshold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 171);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Binarization";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // trackBarTreshold
            // 
            this.trackBarTreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarTreshold.LargeChange = 10;
            this.trackBarTreshold.Location = new System.Drawing.Point(1, 72);
            this.trackBarTreshold.Maximum = 255;
            this.trackBarTreshold.Name = "trackBarTreshold";
            this.trackBarTreshold.Size = new System.Drawing.Size(217, 45);
            this.trackBarTreshold.TabIndex = 60;
            this.trackBarTreshold.TickFrequency = 20;
            this.trackBarTreshold.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Treshold param 0-255:";
            // 
            // btnTryTreshold
            // 
            this.btnTryTreshold.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTryTreshold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryTreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryTreshold.Location = new System.Drawing.Point(15, 117);
            this.btnTryTreshold.Name = "btnTryTreshold";
            this.btnTryTreshold.Size = new System.Drawing.Size(83, 38);
            this.btnTryTreshold.TabIndex = 41;
            this.btnTryTreshold.Text = "Try on this image";
            this.btnTryTreshold.UseVisualStyleBackColor = false;
            this.btnTryTreshold.Click += new System.EventHandler(this.btnTryTreshold_Click);
            // 
            // rbtnTresholdAll
            // 
            this.rbtnTresholdAll.AutoSize = true;
            this.rbtnTresholdAll.Location = new System.Drawing.Point(124, 140);
            this.rbtnTresholdAll.Name = "rbtnTresholdAll";
            this.rbtnTresholdAll.Size = new System.Drawing.Size(89, 17);
            this.rbtnTresholdAll.TabIndex = 40;
            this.rbtnTresholdAll.TabStop = true;
            this.rbtnTresholdAll.Text = "For all images";
            this.rbtnTresholdAll.UseVisualStyleBackColor = true;
            // 
            // rbtnForThisImage
            // 
            this.rbtnForThisImage.AutoSize = true;
            this.rbtnForThisImage.Location = new System.Drawing.Point(123, 117);
            this.rbtnForThisImage.Name = "rbtnForThisImage";
            this.rbtnForThisImage.Size = new System.Drawing.Size(90, 17);
            this.rbtnForThisImage.TabIndex = 39;
            this.rbtnForThisImage.TabStop = true;
            this.rbtnForThisImage.Text = "For this image";
            this.rbtnForThisImage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnShowInForm);
            this.groupBox4.Controls.Add(this.rbtSaveText);
            this.groupBox4.Controls.Add(this.rbtShowText);
            this.groupBox4.Controls.Add(this.btnExtractText);
            this.groupBox4.Controls.Add(this.cbxExtractText);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 133);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extract text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Extraction mode:";
            // 
            // btnShowInForm
            // 
            this.btnShowInForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowInForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInForm.Location = new System.Drawing.Point(125, 89);
            this.btnShowInForm.Name = "btnShowInForm";
            this.btnShowInForm.Size = new System.Drawing.Size(80, 38);
            this.btnShowInForm.TabIndex = 45;
            this.btnShowInForm.Text = "Show in form";
            this.btnShowInForm.UseVisualStyleBackColor = false;
            this.btnShowInForm.Click += new System.EventHandler(this.btnShowInForm_Click);
            // 
            // rbtSaveText
            // 
            this.rbtSaveText.AutoSize = true;
            this.rbtSaveText.Location = new System.Drawing.Point(11, 71);
            this.rbtSaveText.Name = "rbtSaveText";
            this.rbtSaveText.Size = new System.Drawing.Size(77, 17);
            this.rbtSaveText.TabIndex = 44;
            this.rbtSaveText.TabStop = true;
            this.rbtSaveText.Text = "Save in file";
            this.rbtSaveText.UseVisualStyleBackColor = true;
            // 
            // rbtShowText
            // 
            this.rbtShowText.AutoSize = true;
            this.rbtShowText.Location = new System.Drawing.Point(11, 53);
            this.rbtShowText.Name = "rbtShowText";
            this.rbtShowText.Size = new System.Drawing.Size(148, 17);
            this.rbtShowText.TabIndex = 43;
            this.rbtShowText.TabStop = true;
            this.rbtShowText.Text = "Show text in message box";
            this.rbtShowText.UseVisualStyleBackColor = true;
            // 
            // btnEditChars
            // 
            this.btnEditChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditChars.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditChars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditChars.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditChars.Location = new System.Drawing.Point(9, 545);
            this.btnEditChars.Name = "btnEditChars";
            this.btnEditChars.Size = new System.Drawing.Size(217, 27);
            this.btnEditChars.TabIndex = 54;
            this.btnEditChars.Text = "Edit extracted characters";
            this.btnEditChars.UseVisualStyleBackColor = false;
            this.btnEditChars.Click += new System.EventHandler(this.btnEditChars_Click);
            // 
            // tbxFolderName
            // 
            this.tbxFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFolderName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxFolderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFolderName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxFolderName.Location = new System.Drawing.Point(9, 521);
            this.tbxFolderName.Name = "tbxFolderName";
            this.tbxFolderName.Size = new System.Drawing.Size(217, 20);
            this.tbxFolderName.TabIndex = 55;
            // 
            // tbxFolderCharacterDatabase
            // 
            this.tbxFolderCharacterDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFolderCharacterDatabase.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxFolderCharacterDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFolderCharacterDatabase.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxFolderCharacterDatabase.Location = new System.Drawing.Point(966, 645);
            this.tbxFolderCharacterDatabase.Name = "tbxFolderCharacterDatabase";
            this.tbxFolderCharacterDatabase.Size = new System.Drawing.Size(257, 20);
            this.tbxFolderCharacterDatabase.TabIndex = 56;
            // 
            // btnCharacterDatabase
            // 
            this.btnCharacterDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCharacterDatabase.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCharacterDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharacterDatabase.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCharacterDatabase.Location = new System.Drawing.Point(967, 670);
            this.btnCharacterDatabase.Name = "btnCharacterDatabase";
            this.btnCharacterDatabase.Size = new System.Drawing.Size(257, 27);
            this.btnCharacterDatabase.TabIndex = 57;
            this.btnCharacterDatabase.Text = "Show character database";
            this.btnCharacterDatabase.UseVisualStyleBackColor = false;
            this.btnCharacterDatabase.Click += new System.EventHandler(this.btnCharacterDatabase_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(34, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Document selection";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 15;
            this.trackBar1.Location = new System.Drawing.Point(957, 58);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = -140;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(267, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 59;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(1041, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(950, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 24);
            this.label10.TabIndex = 61;
            this.label10.Text = "-";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(1214, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 24);
            this.label11.TabIndex = 62;
            this.label11.Text = "+";
            // 
            // timerTesseractExt
            // 
            this.timerTesseractExt.Interval = 1000;
            this.timerTesseractExt.Tick += new System.EventHandler(this.timerTesseractExt_Tick);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Location = new System.Drawing.Point(10, 505);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(218, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "Folder for save and edit extracted characers:";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label18.Location = new System.Drawing.Point(967, 629);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(188, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "Folder with saved character database:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(108, 18);
            this.tabControl1.Location = new System.Drawing.Point(2, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(243, 613);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage1.Controls.Add(this.Extraction);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lblExtractionResponse);
            this.tabPage1.Controls.Add(this.lblExtractionIndex);
            this.tabPage1.Controls.Add(this.tbxFolderName);
            this.tabPage1.Controls.Add(this.btnEditChars);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(235, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Character Extraction";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnBinarization);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(235, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tresholding";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(235, 587);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Extract text";
            // 
            // btnRotateImage
            // 
            this.btnRotateImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRotateImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRotateImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRotateImage.BackgroundImage")));
            this.btnRotateImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRotateImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotateImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRotateImage.Location = new System.Drawing.Point(969, 98);
            this.btnRotateImage.Name = "btnRotateImage";
            this.btnRotateImage.Size = new System.Drawing.Size(36, 32);
            this.btnRotateImage.TabIndex = 65;
            this.btnRotateImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRotateImage.UseVisualStyleBackColor = false;
            this.btnRotateImage.Click += new System.EventHandler(this.btnRotateImage_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.Location = new System.Drawing.Point(1010, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 20);
            this.label19.TabIndex = 67;
            this.label19.Text = "Rotation angle";
            // 
            // numRotateAngle
            // 
            this.numRotateAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numRotateAngle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numRotateAngle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.numRotateAngle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRotateAngle.Location = new System.Drawing.Point(1125, 105);
            this.numRotateAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numRotateAngle.Name = "numRotateAngle";
            this.numRotateAngle.Size = new System.Drawing.Size(45, 20);
            this.numRotateAngle.TabIndex = 68;
            this.numRotateAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label20.Location = new System.Drawing.Point(962, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 20);
            this.label20.TabIndex = 69;
            this.label20.Text = "Zoom in/out";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1237, 714);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.numRotateAngle);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnRotateImage);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCharacterDatabase);
            this.Controls.Add(this.tbxFolderCharacterDatabase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblImgNum);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography/Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.documentShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Extraction.ResumeLayout(false);
            this.Extraction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLineSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTreshold)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRotateAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox documentShow;
        private System.Windows.Forms.Button btnSelectArea;
        private System.Windows.Forms.Button btnCropArea;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.PictureBox pictureBoxCrop;
        private System.Windows.Forms.PictureBox pictureBoxCharacter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblImgNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem binarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noiseRemovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allThisFiltersToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem getOriginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAllOriginalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageInFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem forAllImagesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem forAllImagesToolStripMenuItem;
        private System.Windows.Forms.Button btnBinarization;
        private System.Windows.Forms.ComboBox cbxThreshold;
        private System.Windows.Forms.Button btnExtractText;
        private System.Windows.Forms.ComboBox cbxExtractText;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Extraction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveCroped;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtSaveText;
        private System.Windows.Forms.RadioButton rbtShowText;
        private System.Windows.Forms.TextBox tbxCharForSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExtractionResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Button btnEditChars;
        private System.Windows.Forms.TextBox tbxFolderName;
        private System.Windows.Forms.RadioButton rbtnTresholdAll;
        private System.Windows.Forms.RadioButton rbtnForThisImage;
        private System.Windows.Forms.ComboBox cbxOneOrAllExtract;
        private System.Windows.Forms.Label lblExtractionIndex;
        private System.Windows.Forms.Button btnTryTreshold;
        private System.Windows.Forms.Label conf;
        private System.Windows.Forms.TextBox tbxFolderCharacterDatabase;
        private System.Windows.Forms.Button btnCharacterDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnShowInForm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxExtractText1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Timer timerTesseractExt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.NumericUpDown numLineSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRotateImage;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numRotateAngle;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar trackBarTreshold;
        private System.Windows.Forms.Label label2;
    }
}

