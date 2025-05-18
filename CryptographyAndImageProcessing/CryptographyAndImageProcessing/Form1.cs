using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Tesseract;
using System.Runtime.ExceptionServices;

namespace CryptographyAndImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initialize();

            // Pretpostavimo da tvoja forma već ima TabControl koji se zove "tabControl1"
            // Zamenimo ga sa DarkModeTabControl

            TabControlCustom darkModeTabControl = new TabControlCustom();
            darkModeTabControl.Location = this.tabControl1.Location;
            darkModeTabControl.Size = this.tabControl1.Size;
            darkModeTabControl.Anchor = this.tabControl1.Anchor;
            darkModeTabControl.Dock = this.tabControl1.Dock;

            // Kopiramo sve TabPages iz postojećeg tabControl-a u novi darkModeTabControl
            foreach (TabPage tabPage in this.tabControl1.TabPages)
            {
                darkModeTabControl.TabPages.Add(tabPage);
            }

            // Uklonimo stari tabControl i dodamo novi
            this.Controls.Remove(this.tabControl1);
            this.Controls.Add(darkModeTabControl);
        }

        public void Initialize()
        {
            if (!System.IO.Directory.Exists(@"C:\\CharacterExtraction"))
                System.IO.Directory.CreateDirectory(@"C:\\CharacterExtraction"); 

            cbxThreshold.Items.Add("Binary");
            cbxThreshold.Items.Add("BinaryInv");
            cbxThreshold.Items.Add("Mask");
            cbxThreshold.Items.Add("Otsu");
            cbxThreshold.Items.Add("ToZero");
            cbxThreshold.Items.Add("ToZeroInv");
            cbxThreshold.Items.Add("Triangle");
            cbxThreshold.Items.Add("Trunc");

            cbxThreshold.SelectedIndex = 0;
            trackBarTreshold.Value = 0;

            cbxExtractText.Items.Add("TesseractOnly");
            cbxExtractText.Items.Add("CubeOnly");
            cbxExtractText.Items.Add("TesseractAndCube");
            cbxExtractText.Items.Add("Default");

            cbxExtractText.SelectedIndex = 2;

            cbxExtractText1.Items.Add("TesseractOnly");
            cbxExtractText1.Items.Add("CubeOnly");
            cbxExtractText1.Items.Add("TesseractAndCube");
            cbxExtractText1.Items.Add("Default");

            cbxExtractText1.SelectedIndex = 2;

            cbxOneOrAllExtract.Items.Add("From current document");
            cbxOneOrAllExtract.Items.Add("From all documents");

            cbxOneOrAllExtract.SelectedIndex = 0;

            rbtShowText.Checked = true;
            rbtnForThisImage.Checked = true;

            folderName = "Extraction1";
            tbxFolderName.Text = folderName;
            tbxFolderCharacterDatabase.Text = "normbaza1";
        }

        string folderName;
        List<Image> originalImages;
        List<Image> modifiedImages;
        List<Image<Gray, byte>> grayImages;
        List<Image<Gray, byte>> binarizeImages;

        int trackBarValue=0;

        int imageIndex = -1; //indeks slike koja je prikazana
        bool extractionStarted = false;

        #region Close, Minimize, Maximize...
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //variable for crop cordinates 
        int crpX, crpY, rectW, rectH;
        //crop pen for cropping image 
        public Pen crpPen = new Pen(Color.Red);
        bool cropArea = false;

        Image<Bgr, byte> imgInput;
        Bitmap img;

        #region crop image

        private void btnSelectArea_Click(object sender, EventArgs e)
        {
            if (modifiedImages != null)
            {
                cropArea = true;
            }
            else
            {
                MessageBox.Show("You have to add images first!");
            }
        }

        private void btnCropArea_Click(object sender, EventArgs e)
        {
            if(cropArea == false)
            {
                MessageBox.Show("Select area first!");
                return;
            }

            if (cropArea == true && modifiedImages != null && modifiedImages.Count != 0)
            {
                Cursor = Cursors.Default;

                //draw cropped image 
                Bitmap bmp2 = new Bitmap(documentShow.Width, documentShow.Height);
                documentShow.DrawToBitmap(bmp2, documentShow.ClientRectangle);

                int Left = (int)Math.Round((float)(modifiedImages[imageIndex].Width * crpX) / (float)documentShow.Width);
                int Right = (int)Math.Round((float)(modifiedImages[imageIndex].Width * (crpX + rectW)) / (float)documentShow.Width);

                int Top = (int)Math.Round((float)(modifiedImages[imageIndex].Height * crpY) / (float)documentShow.Height);
                int Bottom = (int)Math.Round((float)(modifiedImages[imageIndex].Height * (crpY + rectH)) / (float)documentShow.Height);

                if (Left < 0)
                    Left++;
                if (Right > modifiedImages[imageIndex].Width)
                    Right--;
                if (Top < 0)
                    Top++;
                if (Bottom > modifiedImages[imageIndex].Height)
                    Bottom--;

                int cropedWidth = Right - Left;
                int cropedHeight = Bottom - Top;

                lblDimensions.Text = "Dimensions :" + cropedWidth.ToString() + "," + cropedHeight.ToString();

                Bitmap crpImg = new Bitmap(cropedWidth, cropedHeight);

                bmp2 = new Bitmap(modifiedImages[imageIndex]);

                for (int i = 0; i < cropedWidth; i++)
                {
                    for (int j = 0; j < cropedHeight; j++)
                    {
                        Color pxlclr = bmp2.GetPixel(Left + i, Top + j);
                        crpImg.SetPixel(i, j, pxlclr);
                    }
                }

                pictureBoxCrop.Image = (Image)crpImg;
                pictureBoxCrop.SizeMode = PictureBoxSizeMode.CenterImage;
                bmp2.Dispose();
                cropArea = false;
            }
            else
            {
                MessageBox.Show("You have to add images first!");
            }
        }

        private void documentShow_MouseDown_1(object sender, MouseEventArgs e)//nova
        {   
            if (cropArea)
            {
                base.OnMouseDown(e);

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Cursor = Cursors.Cross;
                    crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    //set initial X,Y coordinates for crop rectangle
                    //this is where we firstly click on image
                    crpX = e.X;
                    crpY = e.Y;
                }
            }
        }

        private void documentShow_MouseMove_1(object sender, MouseEventArgs e)//nova
        {
            if (cropArea)
            {
                base.OnMouseMove(e);

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    documentShow.Refresh();
                    //set width and height for crop rectangle 
                    rectW = e.X - crpX;
                    rectH = e.Y - crpY;
                    Graphics g = documentShow.CreateGraphics();
                    g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                    g.Dispose();
                }
            }
        }

        private void documentShow_MouseEnter_1(object sender, EventArgs e)
        {
            if (cropArea)
            {
                base.OnMouseEnter(e);
                Cursor = Cursors.Cross;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (cropArea)
            {
                base.OnMouseEnter(e);
                Cursor = Cursors.Default;
            }
        }

        #endregion

        #region zoom

        Image Zoom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 150), img.Height + (img.Height * size.Height / 150));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (documentShow.Image != null && modifiedImages[imageIndex] != null)
            {
                trackBarValue = trackBar1.Value;
                documentShow.Image = Zoom(modifiedImages[imageIndex], new Size(trackBar1.Value, trackBar1.Value));
            }
        }
        #endregion //not done

        #region <- previous/next image ->
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            documentShow.Image = modifiedImages[-- imageIndex];

            if(imageIndex == 0)
            {
                btnPrevious.Enabled = false;
            }

            btnNext.Enabled = true;
            lblImgNum.Text = (imageIndex + 1).ToString() + "/" + modifiedImages.Count.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            documentShow.Image = modifiedImages[++ imageIndex];

            if (modifiedImages.Count == (imageIndex + 1))
            {
                btnNext.Enabled = false;
            }

            btnPrevious.Enabled = true;
            lblImgNum.Text = (imageIndex + 1).ToString() + "/" + modifiedImages.Count.ToString();
        }
        #endregion

        private void getImagesToolStripMenuItem_Click(object sender, EventArgs e)//get image
        {
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            try
            {
                originalImages = new List<Image>();
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;
                dialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    String[] imageLocations = dialog.FileNames; //return location of images, add filter!

                    Bitmap bmp;
                    foreach (String imageLocation in imageLocations)
                    {
                        bmp = new Bitmap(imageLocation);

                        originalImages.Add((Image)bmp);
                    }

                    Image firstImage = originalImages.First();
                    imageIndex = 0;

                    if (originalImages.Count > 1)
                    {
                        btnNext.Enabled = true;
                    }

                    modifiedImages = new List<Image>();
                    foreach (Image i in originalImages)
                    {
                        modifiedImages.Add((Image) i.Clone());
                    }

                    //modifiedImages = new List<Image>(originalImages);
                    documentShow.Width = firstImage.Width;
                    documentShow.Height = firstImage.Height;
                    documentShow.Image = modifiedImages.First();

                    lblImgNum.Text = (imageIndex + 1).ToString() + "/" + modifiedImages.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Choose file in image format!" + ex.Message);
            }
        }

        #region custom filters
        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (modifiedImages != null)
            {
                modifiedImages[imageIndex] = SmoothingClass.GrayScale((Bitmap)modifiedImages[imageIndex]);
                documentShow.Image = modifiedImages[imageIndex];
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }
        }

        private void binarisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifiedImages != null)
            {
                modifiedImages[imageIndex] = SmoothingClass.Binary((Bitmap)modifiedImages[imageIndex]);
                documentShow.Image = modifiedImages[imageIndex];
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }
        }

        private void noiseRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifiedImages != null)
            {
                modifiedImages[imageIndex] = SmoothingClass.NoiseRemoval((Bitmap)modifiedImages[imageIndex]);
                documentShow.Image = modifiedImages[imageIndex];
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }
        }

        private void allThisFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifiedImages != null)
            {
                modifiedImages[imageIndex] = SmoothingClass.Execute((Bitmap)modifiedImages[imageIndex]);
                documentShow.Image = modifiedImages[imageIndex];
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }
        }

        private void forAllToolStripMenuItem_Click(object sender, EventArgs e)// gray scale allimages
        {
            if (modifiedImages != null)
            {
                for (int i = 0; i < modifiedImages.Count; i++ )
                    modifiedImages[i] = SmoothingClass.GrayScale((Bitmap)modifiedImages[i]);

                documentShow.Image = modifiedImages[imageIndex];
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }
        }

        private void forAllToolStripMenuItem1_Click(object sender, EventArgs e)//binarisation all images
        {
            if (modifiedImages != null)
            {
                for (int i = 0; i < modifiedImages.Count; i++)
                    modifiedImages[i] = SmoothingClass.Binary((Bitmap)modifiedImages[i]);

                documentShow.Image = modifiedImages[imageIndex];
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }
        }

        private void forAllImagesToolStripMenuItem1_Click(object sender, EventArgs e)//noise removal all images
        {
            if (modifiedImages != null)
            {
                for (int i = 0; i < modifiedImages.Count; i++)
                    modifiedImages[i] = SmoothingClass.NoiseRemoval((Bitmap)modifiedImages[i]);

                documentShow.Image = modifiedImages[imageIndex];
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }
        }

        private void forAllImagesToolStripMenuItem_Click(object sender, EventArgs e)//all this filters all images
        {
            if (modifiedImages != null)
            {
                for (int i = 0; i < modifiedImages.Count; i++)
                    modifiedImages[i] = SmoothingClass.Execute((Bitmap)modifiedImages[i]);

                documentShow.Image = modifiedImages[imageIndex];
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }
        }
        #endregion

        #region get original , drop all, save in originals, 

        private void getOriginalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifiedImages != null)
            {
                modifiedImages[imageIndex] = (Image)originalImages.ElementAt(imageIndex).Clone();
                documentShow.Image = modifiedImages.ElementAt(imageIndex);
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }
        }

        private void getAllOriginalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(modifiedImages != null && modifiedImages.Count != 0)
            {
                modifiedImages = new List<Image>();

                foreach (Image i in originalImages)
                {
                    modifiedImages.Add((Image)i.Clone());
                }
                documentShow.Image = modifiedImages[imageIndex];
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }
        }

        private void dropImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifiedImages != null)
            {
                modifiedImages.Remove(modifiedImages[imageIndex]);
                originalImages.Remove(originalImages[imageIndex]);

                if (modifiedImages.Count == 0)
                {
                    documentShow.Image = null;
                    imageIndex = -1;

                    documentShow.Width = 690;
                    documentShow.Height = 670;
                }
                else
                {
                    imageIndex = 0;
                    documentShow.Image = modifiedImages[imageIndex];
                }

                lblImgNum.Text = (imageIndex + 1).ToString() + "/" + modifiedImages.Count.ToString();
            }
            else
            {
                MessageBox.Show("Image doesn't exists.");
            }
        }

        private void dropAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifiedImages == null)
            {
                MessageBox.Show("Images doesn't exists.");
            }
            modifiedImages = null;
            originalImages = null;
            documentShow.Image = null;
            imageIndex = -1;
            lblImgNum.Text = (imageIndex + 1).ToString() + "/" + 0;
            documentShow.Width = 690;
            documentShow.Height = 670;
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifiedImages != null && modifiedImages.Count != 0)
            {
                originalImages[imageIndex] = (Image)modifiedImages[imageIndex].Clone();
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }

        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifiedImages != null && modifiedImages.Count != 0)
            {
                originalImages = new List<Image>();

                foreach (Image i in modifiedImages)
                {
                    originalImages.Add((Image)i.Clone());
                }
            }
            else
            {
                MessageBox.Show("You have to add images first in application!");
            }
        }

        #endregion

        private void btnBinarization_Click(object sender, EventArgs e)
        {
            if(modifiedImages!=null && modifiedImages.Count!=0)
            {
                grayImages = new List<Image<Gray, byte>>();
                binarizeImages = new List<Image<Gray, byte>>();

                for (int i = 0; i < modifiedImages.Count; i++)
                {
                    Image<Bgr, byte> imgEdit = new Image<Bgr, byte>(new Bitmap(modifiedImages.ElementAt(i)));
                    grayImages.Add(imgEdit.Convert<Gray, byte>());

                    //binarization thresholding
                    Image<Gray, byte> imgBinarize = new Image<Gray, byte>(grayImages[i].Width, grayImages[i].Height, new Gray(0));

                    CvInvoke.Threshold(grayImages.ElementAt(i), imgBinarize, (double)trackBarTreshold.Value, 255, (Emgu.CV.CvEnum.ThresholdType)cbxThreshold.SelectedIndex);

                    binarizeImages.Add(imgBinarize);
                }

                if (rbtnForThisImage.Checked)
                {
                    modifiedImages[imageIndex] = binarizeImages[imageIndex].Bitmap;
                    documentShow.Image = Zoom(modifiedImages[imageIndex], new Size(trackBar1.Value, trackBar1.Value));
                }
                else if (rbtnTresholdAll.Checked)
                {
                    for (int i = 0; i < modifiedImages.Count; i++)
                    {
                        modifiedImages[i] = binarizeImages[i].Bitmap;
                    }
                    documentShow.Image = Zoom(modifiedImages[imageIndex], new Size(trackBar1.Value, trackBar1.Value));
                }
                MessageBox.Show("Tresholding images succeed!");
            }
            else
            {
                MessageBox.Show("You have to add images first!");
            }
        }

        private void btnExtractText_Click(object sender, EventArgs e)   //not done create file and write in file
        {
            if (modifiedImages !=null && modifiedImages.Count != 0)
            {
                try 
                {
                    var ocr = new TesseractEngine("./tessdata", "eng", (EngineMode)cbxExtractText.SelectedIndex);
                    var res = ocr.Process((Bitmap)modifiedImages[imageIndex]);
                    string text = res.GetText();

                    if (rbtShowText.Checked)
                    {
                        MessageBox.Show(text);
                    }
                    else if (rbtSaveText.Checked)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                            using (StreamWriter sw = new StreamWriter(s))
                            {
                                sw.Write(text);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You have to add images first!");
            }
}

        private void btnTryTreshold_Click(object sender, EventArgs e)
        {
            if (modifiedImages != null && modifiedImages.Count != 0)
            {
                grayImages = new List<Image<Gray, byte>>();
                binarizeImages = new List<Image<Gray, byte>>();

                for (int i = 0; i < modifiedImages.Count; i++)
                {
                    Image<Bgr, byte> imgEdit = new Image<Bgr, byte>(new Bitmap(modifiedImages.ElementAt(i)));
                    grayImages.Add(imgEdit.Convert<Gray, byte>());

                    //binarization thresholding
                    Image<Gray, byte> imgBinarize = new Image<Gray, byte>(grayImages[i].Width, grayImages[i].Height, new Gray(0));

                    CvInvoke.Threshold(grayImages.ElementAt(i), imgBinarize, (double)trackBarTreshold.Value, 255, (Emgu.CV.CvEnum.ThresholdType)cbxThreshold.SelectedIndex);

                    binarizeImages.Add(imgBinarize);
                }

                documentShow.Image = Zoom(binarizeImages[imageIndex].Bitmap, new Size(trackBar1.Value, trackBar1.Value));
            }
            else
            {
                MessageBox.Show("You have to add images first!");
            }
        }

        #region movable form code
        //movable form
        Point start_point = new Point(0, 0);
        bool mouseDown;
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            start_point = new Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void btnSaveCroped_Click(object sender, EventArgs e)
        {
            if (modifiedImages != null)
            {
                Bitmap cropedImage;

                if (pictureBoxCrop.Image != null && tbxCharForSave.Text != null && tbxCharForSave.Text.Length == 1 && ((int)(tbxCharForSave.Text[0]) > 32) && ((int)(tbxCharForSave.Text[0]) < 127))
                {
                    cropedImage = new Bitmap(pictureBoxCrop.Image);

                    if (!System.IO.Directory.Exists(@"C:\\CharacterExtraction\\" + tbxFolderName.Text + "\\" + ((int)tbxCharForSave.Text[0]).ToString()))
                    {
                        System.IO.Directory.CreateDirectory(@"C:\\CharacterExtraction\\" + tbxFolderName.Text + "\\" + ((int)tbxCharForSave.Text[0]).ToString());
                    }

                    string[] filePaths = Directory.GetFiles(@"C:\\CharacterExtraction\\" + tbxFolderName.Text + "\\" + ((int)tbxCharForSave.Text[0]).ToString());

                    bool exist = true;
                    int i = 1;

                    while (exist)
                    {
                        if (!filePaths.Contains(
                            @"C:\\CharacterExtraction\\" + tbxFolderName.Text + "\\" + ((int)tbxCharForSave.Text[0]).ToString() + "\\" + i.ToString() + "a.bmp"))
                        {
                            cropedImage.Save(
                                @"C:\\CharacterExtraction\\" + tbxFolderName.Text + "\\" + ((int)tbxCharForSave.Text[0]).ToString() + "\\" + i.ToString() + "a.bmp");
                            exist = false; // can be something like -while(true)- and -break-

                            using (StreamWriter file =
                                            File.CreateText(@"C:\\CharacterExtraction\\" + tbxFolderName.Text + "\\" + ((int)tbxCharForSave.Text[0]).ToString() + "\\" + i.ToString() + "a"))
                            {
                                file.WriteLine(100.0);
                            }
                        }
                        else
                        {
                            i++;
                        }
                    }
                    MessageBox.Show("Croped image is saved!");
                    cropedImage.Dispose();
                }
                else
                {
                    MessageBox.Show("You have to crop image first!");
                }
            }
            else
            {
                MessageBox.Show("You have to add images first and crop image!");
            }
        }

        private void button1_Click(object sender, EventArgs e)// stop extraction!
        {
            extractionStarted = false;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if(modifiedImages != null && modifiedImages.Count != 0)
            {
                timerTesseractExt.Enabled = true;
                timerTesseractExt.Start();

                Task taskA = new Task(() => CharacterExtractionTesseract());


                taskA.Start();//parallel task

                timerTesseractExt.Enabled = false;
                timerTesseractExt.Stop();
            }
            else
            {
                MessageBox.Show("You have to add images first!");
            }
        }

        private async Task CharacterExtractionTesseract()
        {
            MessageBox.Show("Tesseract extraction started. Please wait few minutes.");
            extractionStarted = true;
            List<Bitmap> bitmapsForExtracting = new List<Bitmap>();

            if (cbxOneOrAllExtract.InvokeRequired)
            {
                cbxOneOrAllExtract.Invoke((MethodInvoker)delegate
                {
                    if (cbxOneOrAllExtract.SelectedIndex == 0)
                    {
                        bitmapsForExtracting.Add((Bitmap)modifiedImages[imageIndex].Clone());
                    }
                    else
                    {
                        foreach (var image in modifiedImages)
                        {
                            bitmapsForExtracting.Add((Bitmap)image.Clone());
                        }
                    }
                });
            }

            int imageIndexExt = 1;
            foreach (var bitmapImage in bitmapsForExtracting)
            {
                if (lblExtractionResponse.InvokeRequired)
                {
                    lblExtractionResponse.Invoke((MethodInvoker)delegate
                    {
                        lblExtractionResponse.Text = "Extraction in progress, please wait...";
                    });
                }
                if (lblExtractionIndex.InvokeRequired)
                {
                    lblExtractionIndex.Invoke((MethodInvoker)delegate
                    {
                        lblExtractionIndex.Text = imageIndexExt.ToString() + "/" + bitmapsForExtracting.Count.ToString();
                    });
                }
                imageIndexExt++;

                int x = 0;
                int y = 0;
                bool start = false;
                EngineMode engineMode = 0;
                if (cbxExtractText.InvokeRequired)
                {
                    cbxExtractText.Invoke((MethodInvoker)delegate
                    {
                        engineMode = (EngineMode)cbxExtractText.SelectedIndex;
                    });
                }
                else
                {
                    engineMode = (EngineMode)cbxExtractText.SelectedIndex;
                }

                var ocr = new TesseractEngine("./tessdata", "eng", engineMode);
                Tesseract.Page res = ocr.Process(bitmapImage, PageSegMode.Auto);
                Bitmap EditableImg = new Bitmap(bitmapImage);

                decimal numWidthValue = 0;
                if (numWidth.InvokeRequired)
                {
                    numWidth.Invoke((MethodInvoker)delegate
                    {
                        numWidthValue = numWidth.Value;
                    });
                }

                decimal numHeightValue = 0;
                if (numHeight.InvokeRequired)
                {
                    numHeight.Invoke((MethodInvoker)delegate
                    {
                        numHeightValue = numHeight.Value;
                    });
                }

                string tbxFolderNameText = "";
                if (tbxFolderName.InvokeRequired)
                {
                    tbxFolderName.Invoke((MethodInvoker)delegate
                    {
                        tbxFolderNameText = tbxFolderName.Text;
                    });
                }

                decimal numLineSizeValue = 0;

                if (numLineSize.InvokeRequired)
                {
                    numLineSize.Invoke((MethodInvoker)delegate
                    {
                        numLineSizeValue = numLineSize.Value;
                    });
                }

                decimal numDelayValue = 0;

                if (numDelay.InvokeRequired)
                {
                    numDelay.Invoke((MethodInvoker)delegate
                    {
                        numDelayValue = numDelay.Value;
                    });
                }

                int trackBar1Value = 0;

                if (trackBar1.InvokeRequired)
                {
                    trackBar1.Invoke((MethodInvoker)delegate
                    {
                        trackBar1Value = trackBar1.Value;
                    });
                }


                using (var iter = res.GetIterator())
                {
                    do
                    {
                        try
                        {
                            Rect symbolBounds;
                            if (iter.TryGetBoundingBox(PageIteratorLevel.Symbol, out symbolBounds))
                            {
                                if (symbolBounds.Width >= numWidthValue && symbolBounds.Height >= numHeightValue)
                                {
                                    char tackaZarez = iter.GetText(PageIteratorLevel.Symbol)[0];

                                    Rectangle r;

                                    if (tackaZarez == '.' || tackaZarez == ',')
                                    {
                                        r = new Rectangle(symbolBounds.X1, symbolBounds.Y1 - (int)(symbolBounds.Height * 1.6), (int)(symbolBounds.Width * 2.6), (int)(symbolBounds.Height * 2.6));
                                    }
                                    else
                                    {
                                        r = new Rectangle(symbolBounds.X1, symbolBounds.Y1, symbolBounds.Width, symbolBounds.Height);
                                    }
                                    using (Image cropedImage = cropImage(bitmapImage, r))
                                    {

                                        using (Graphics g = Graphics.FromImage(EditableImg))
                                        {
                                            Color customColor = Color.Red;
                                            Pen penn = new Pen(customColor, (float)numLineSizeValue);
                                            g.DrawRectangle(penn, r);

                                            if (trackBar1.InvokeRequired)
                                            {
                                                trackBar1.Invoke((MethodInvoker)delegate
                                                {
                                                    trackBar1Value = trackBar1.Value;
                                                });
                                            }

                                            if (documentShow.InvokeRequired)
                                            {
                                                documentShow.Invoke((MethodInvoker)delegate
                                                {
                                                    documentShow.Image = Zoom(EditableImg, new Size(trackBar1Value, trackBar1Value));
                                                });
                                            }
                                            await Task.Delay((int)numDelayValue);
                                        }
                                        if (conf.InvokeRequired)
                                        {
                                            conf.Invoke((MethodInvoker)delegate
                                            {
                                                conf.Text = iter.GetConfidence(PageIteratorLevel.Symbol).ToString();
                                            });
                                        }
                                        float thisCharConfidance = iter.GetConfidence(PageIteratorLevel.Symbol);
                                        if (lblChar.InvokeRequired)
                                        {
                                            lblChar.Invoke((MethodInvoker)delegate
                                            {
                                                lblChar.Text = iter.GetText(PageIteratorLevel.Symbol);
                                            });
                                        }
                                        char thisChar = iter.GetText(PageIteratorLevel.Symbol)[0];

                                        if (pictureBoxCharacter.InvokeRequired)
                                        {
                                            pictureBoxCharacter.Invoke((MethodInvoker)delegate
                                            {
                                                lock (pictureBoxCharacter)
                                                {
                                                    pictureBoxCharacter.SizeMode = PictureBoxSizeMode.CenterImage;
                                                    pictureBoxCharacter.Image = (Image)cropedImage.Clone();
                                                }
                                            });
                                        }
                                        else
                                        {
                                            lock (pictureBoxCharacter)
                                            {
                                                pictureBoxCharacter.SizeMode = PictureBoxSizeMode.CenterImage;
                                                pictureBoxCharacter.Image = (Image)cropedImage.Clone();
                                            }
                                        }

                                        if (thisChar.ToString() != "" && thisChar.ToString() != " " && thisChar.ToString() != null)
                                        {
                                            if ((int)thisChar >= 33 && (int)thisChar <= 126)
                                            {
                                                if (!System.IO.Directory.Exists(@"C:\\CharacterExtraction\\" + tbxFolderNameText + "\\" + ((int)thisChar).ToString()))
                                                {
                                                    System.IO.Directory.CreateDirectory(@"C:\\CharacterExtraction\\" + tbxFolderNameText + "\\" + ((int)thisChar).ToString());
                                                }

                                                string[] filePaths = Directory.GetFiles(@"C:\\CharacterExtraction\\" + tbxFolderNameText + "\\" + ((int)thisChar).ToString());

                                                List<string> listPats = new List<string>(filePaths);

                                                int ind = 0;
                                                while (true)
                                                {
                                                    if (listPats.Contains(@"C:\\CharacterExtraction\\" + tbxFolderNameText + "\\" + ((int)thisChar).ToString() + "\\" + ind.ToString() + ".bmp"))
                                                    {
                                                        ind++;
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }

                                                cropedImage.Save(@"C:\\CharacterExtraction\\" + tbxFolderNameText + "\\" + ((int)thisChar).ToString() + "\\" + ind.ToString() + ".bmp");

                                                cropedImage.Dispose();

                                                using (StreamWriter file =
                                                    File.CreateText(@"C:\\CharacterExtraction\\" + tbxFolderNameText + "\\" + ((int)thisChar).ToString() + "\\" + ind.ToString()))
                                                {
                                                    file.WriteLine(thisCharConfidance.ToString());
                                                }
                                            }
                                        }
                                    }
                                }

                                if (start == false)
                                {
                                    x = symbolBounds.X1;
                                    y = symbolBounds.Y1;
                                    start = true;
                                }
                                else
                                {
                                    if (symbolBounds.X1 == x && symbolBounds.Y1 == y)
                                        break;
                                }
                            }
                            if (extractionStarted == false)
                            {
                                if (pictureBoxCharacter.InvokeRequired)
                                {
                                    pictureBoxCharacter.Invoke((MethodInvoker)delegate
                                    {
                                        lock (pictureBoxCharacter)
                                        {
                                            pictureBoxCharacter.SizeMode = PictureBoxSizeMode.Normal;
                                            pictureBoxCharacter.Image.Dispose();
                                            pictureBoxCharacter.Image = null;

                                        }
                                    });
                                }
                                else
                                {
                                    lock (pictureBoxCharacter)
                                    {
                                        pictureBoxCharacter.SizeMode = PictureBoxSizeMode.Normal;
                                        pictureBoxCharacter.Image.Dispose();
                                        pictureBoxCharacter.Image = null;
                                    }
                                }
                                if (lblExtractionResponse.InvokeRequired)
                                {
                                    lblExtractionResponse.Invoke((MethodInvoker)delegate
                                    {
                                        lblExtractionResponse.Text = "Extraction stopped.";
                                    });
                                }
                                return;
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    } while (iter.Next(PageIteratorLevel.Symbol));
                }
            }

            if (lblExtractionResponse.InvokeRequired)
            {
                lblExtractionResponse.Invoke((MethodInvoker)delegate
                {
                    lblExtractionResponse.Text = "Extraction done!";
                });
            }
            if (pictureBoxCharacter.InvokeRequired)
            {
                pictureBoxCharacter.Invoke((MethodInvoker)delegate
                {
                    pictureBoxCharacter.SizeMode = PictureBoxSizeMode.Normal;
                    pictureBoxCharacter.Image.Dispose();
                    pictureBoxCharacter.Image = null;
                });
            }
            else
            {
                pictureBoxCharacter.SizeMode = PictureBoxSizeMode.Normal;
                pictureBoxCharacter.Image.Dispose();
                pictureBoxCharacter.Image = null;
            }
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

        private static Image cropImage(Bitmap img, Rectangle cropArea)
        {
            return img.Clone(cropArea, img.PixelFormat);
        }

        private void timerTesseractExt_Tick(object sender, EventArgs e)
        {

        }

        private void saveImageInFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                }
                modifiedImages[imageIndex].Save(sfd.FileName, format);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblExtractionResponse_Click(object sender, EventArgs e)
        {

        }

        private void Extraction_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cbxThreshold_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRotateImage_Click(object sender, EventArgs e)
        {
            if (imageIndex != -1) {
                originalImages[imageIndex] = (Image)RotateImage(new Bitmap(originalImages[imageIndex]), (int)numRotateAngle.Value);
                modifiedImages[imageIndex] = originalImages[imageIndex];
                documentShow.Image = originalImages[imageIndex];
            }
            else
            {
                MessageBox.Show("Add image first.");
            }
        }

        private Bitmap RotateImage(Bitmap bmp, float angle)
        {
            // Calculate the new width and height based on the rotation angle
            float radians = angle * (float)Math.PI / 180.0f;
            double cos = Math.Abs(Math.Cos(radians));
            double sin = Math.Abs(Math.Sin(radians));
            int newWidth = (int)(bmp.Width * cos + bmp.Height * sin);
            int newHeight = (int)(bmp.Width * sin + bmp.Height * cos);

            Bitmap rotatedImage = new Bitmap(newWidth, newHeight);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(newWidth / 2, newHeight / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            try
            {
                if (modifiedImages != null && modifiedImages.Count != 0)
                {
                    grayImages = new List<Image<Gray, byte>>();
                    binarizeImages = new List<Image<Gray, byte>>();

                    try
                    {
                        for (int i = 0; i < modifiedImages.Count; i++)
                        {
                            using (Bitmap bitmap = new Bitmap(modifiedImages.ElementAt(i))) // Bitmap is disposed automatically
                                using (Image<Bgr, byte> imgEdit = new Image<Bgr, byte>(bitmap))  // Image<Bgr, byte> is disposed automatically
                                {
                                    grayImages.Add(imgEdit.Convert<Gray, byte>());

                                    //binarization thresholding
                                    Image<Gray, byte> imgBinarize = new Image<Gray, byte>(grayImages[i].Width, grayImages[i].Height, new Gray(0));

                                    CvInvoke.Threshold(grayImages.ElementAt(i), imgBinarize, (double)trackBarTreshold.Value, 255, (Emgu.CV.CvEnum.ThresholdType)cbxThreshold.SelectedIndex);

                                    binarizeImages.Add(imgBinarize);
                                }
                        }

                        documentShow.Image = Zoom(binarizeImages[imageIndex].Bitmap, new Size(trackBar1.Value, trackBar1.Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("You have to add images first!");
                }
            }
            catch(Exception)
            {

            }
        }

        #region open different forms
        private void btnCharacterDatabase_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\\CharacterExtraction\\" + tbxFolderCharacterDatabase.Text + "\\" + "normbaza.bin"))
            {
                MessageBox.Show("Generate normalized database first!");
                return;
            }
            try
            {
                ListNormalizedChars listChars = new ListNormalizedChars(tbxFolderCharacterDatabase.Text);

                this.Hide();
                listChars.ShowDialog();
                this.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Database doesn't exist.");
            }
        }

        private void btnEditChars_Click(object sender, EventArgs e) //open form for editing character database
        {
            try
            {
                EditCharacters editCharacters = new EditCharacters(tbxFolderName.Text);

                this.Hide();
                editCharacters.ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Folder with characters doesn't exist.");
            }
        }

        private void btnShowInForm_Click(object sender, EventArgs e)
        {
            if (modifiedImages != null && modifiedImages.Count != 0)
            {
                ExtractedText extractedText = new ExtractedText(modifiedImages[imageIndex]);

                this.Hide();
                extractedText.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("You have to add images first!");
            }
        }
        #endregion
    }
}
