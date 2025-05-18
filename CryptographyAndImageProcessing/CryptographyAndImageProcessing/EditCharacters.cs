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
using System.Threading;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Windows.Forms.VisualStyles;
using System.Data.OleDb;
using Tesseract.Interop;
using Emgu.CV.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CryptographyAndImageProcessing
{
    public partial class EditCharacters : Form
    {
        string fullPath;
        string currentImagesPath;
        string[] subdirectoryEntries;
        string[] imagesInCurrentFolder;
        List<string> imagesInCurrentFolderList;
        int currentCharIndex;
        int currentImageIndex;
        Image currentImage;

        decimal rowNum = 24;
        decimal columnNum = 16;

        string normbazaName = "normbaza1";

        int startWidth;
        int startHeight;

        public EditCharacters(string folderName)
        {
            InitializeComponent();
            lblFileName.Text = folderName;
            currentCharIndex = 0;
            currentImageIndex = 0;
            fullPath = @"C:\\CharacterExtraction\\" + folderName;

            numMatrixI.Value = rowNum;
            numMatrixJ.Value = columnNum;

            imagesInCurrentFolderList = new List<string>();

            tbxFileSave.Text = normbazaName;

            if (!File.Exists(fullPath + "\\" + "dimensions.txt"))
            {
                using (StreamWriter sw = File.CreateText(fullPath + "\\" + "dimensions.txt"))
                {
                    sw.WriteLine(rowNum.ToString());
                    sw.WriteLine(columnNum.ToString());
                }
            }

            GetAllFolders();
            ReadDimension();
            PanelMatrix();
            GetImagesFromFolder();
            ShowCharacterImage();

            labelNxM.Text = rowNum.ToString() + "x" + columnNum.ToString();

            pen = new Pen(Color.Black, 1);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            rbtBlack.Checked = true;

            startWidth = this.Width;
            startHeight = this.Height;

            if (rowNum < 35)
            {
                this.Height = startHeight;
            }
            else
            {
                this.Height = startHeight + (int)(rowNum - 35) * 14;
            }

            if (columnNum < 18)
            {
                this.Width = startWidth;
            }
            else
            {
                this.Width = startWidth + (int)(columnNum - 18) * 14;
            }
        }

        private void ReadDimension()
        {
            try
            {
                //MessageBox.Show(fullPath);

                using (StreamReader sr = new StreamReader(fullPath + "\\" + "dimensions.txt"))
                {
                    rowNum = int.Parse(sr.ReadLine());
                    columnNum = int.Parse(sr.ReadLine());
                    numMatrixI.Value = rowNum;
                    numMatrixJ.Value = columnNum;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void GetAllFolders()
        {
            subdirectoryEntries = Directory.GetDirectories(fullPath);

            for (int i = 0; i < subdirectoryEntries.Length; i++)
            {
                subdirectoryEntries[i] = new DirectoryInfo(subdirectoryEntries[i]).Name;
            }

            var myComparer = new StringLikeNumberComperer();
            Array.Sort(subdirectoryEntries, myComparer);
        }

        private void GetImagesFromFolder()
        {
            imagesInCurrentFolderList = new List<string>();

            currentImagesPath = fullPath + "\\" + subdirectoryEntries[currentCharIndex];

            imagesInCurrentFolder = Directory.GetFiles(currentImagesPath);

            for (int i = 0; i < imagesInCurrentFolder.Length; i++)
            {
                if (imagesInCurrentFolder[i].Contains(".bmp"))
                {
                    string imgNamee = Path.GetFileNameWithoutExtension(imagesInCurrentFolder[i]);
                    imagesInCurrentFolderList.Add(imgNamee);
                }
            }

            imagesInCurrentFolderList.Sort();

            lblImageNumber.Text = (currentImageIndex + 1).ToString() + "/" + imagesInCurrentFolderList.Count.ToString();
        }

        private void ShowCharacterImage()
        {
            lblImageNumber.Text = (currentImageIndex + 1).ToString() + "/" + imagesInCurrentFolderList.Count.ToString();
            lblCurrentCharacter.Text = "Char:";
            tbxCurrentCharacter.Text = Convert.ToChar(int.Parse(subdirectoryEntries[currentCharIndex])).ToString();
            lblCurrentCharacter1.Text = "Ascii: " + int.Parse(subdirectoryEntries[currentCharIndex]).ToString();
            int startIndex = (currentImageIndex / 10) * 10;
            int endIndex;

            if (imagesInCurrentFolderList.Count >= startIndex + 10)
            {
                endIndex = startIndex + 10;
            }
            else
            {
                endIndex = imagesInCurrentFolderList.Count;
            }

            for (int i = 0; i < 10; i++)
            {
                PictureBox pbx = (PictureBox)this.Controls["pbxExtractedCharacter" + (i % 10).ToString()];
                pbx.BorderStyle = BorderStyle.None;
                pbx.BackColor = SystemColors.ActiveCaption;
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                using (FileStream stream = new FileStream(fullPath + "\\" + subdirectoryEntries[currentCharIndex] + "\\" + imagesInCurrentFolderList[i] + ".bmp", FileMode.Open, FileAccess.Read))
                {
                    Image img = Image.FromStream(stream);
                    Bitmap bm = null;
                    bm = new Bitmap((Image)img.Clone());
                    PictureBox pbx = (PictureBox)this.Controls["pbxExtractedCharacter" + (i % 10).ToString()];
                    TextBox tbx = (TextBox)this.Controls["tbxC" + (i % 10).ToString()];
                    tbx.ForeColor = Color.Red;

                    using (StreamReader sr = new StreamReader(fullPath + "\\" + subdirectoryEntries[currentCharIndex] + "\\" + imagesInCurrentFolderList[i]))
                    {
                        tbx.Text = sr.ReadLine();
                    }

                    pbx.Image = (Bitmap)bm.Clone();
                    pbx.SizeMode = PictureBoxSizeMode.CenterImage;

                    if (i == currentImageIndex)
                    {
                        pbx.BorderStyle = BorderStyle.Fixed3D;
                        pbx.BackColor = SystemColors.ActiveBorder;
                    }
                    else
                    {
                        pbx.BorderStyle = BorderStyle.None;
                        pbx.BackColor = SystemColors.ActiveCaption;
                    }
                    bm.Dispose();
                }
            }

            while(endIndex % 10 != 0)
            {
                PictureBox pbx = (PictureBox)this.Controls["pbxExtractedCharacter" + (endIndex % 10).ToString()];
                TextBox tbx1 = (TextBox)this.Controls["tbxC" + (endIndex % 10).ToString()];
                tbx1.Text = "";
                endIndex++;
                pbx.BorderStyle = BorderStyle.None;
                pbx.Image = null;
            }


            using (FileStream stream = new FileStream(fullPath + "\\" + subdirectoryEntries[currentCharIndex] + "\\" + imagesInCurrentFolderList[currentImageIndex] + ".bmp", FileMode.Open, FileAccess.Read))
            {
                Image img = Image.FromStream(stream);
                Bitmap bmp = new Bitmap((Image)img.Clone());
                pbxEdit.Height = bmp.Height;
                pbxEdit.Width = bmp.Width;

                tbxCharacterValue.Text = Convert.ToChar(int.Parse(subdirectoryEntries[currentCharIndex])).ToString();

                currentImage = (Bitmap)bmp.Clone();
                pbxEdit.Image = currentImage;
                trackBar1.Value = 0;


                CompressImage24x16SameRatio((Bitmap)bmp.Clone());
                bmp.Dispose();
            }

        }

        #region close, minimize, maximize...
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnNormalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        #endregion

        private void btnChangeImageLeft_Click(object sender, EventArgs e)
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                ShowCharacterImage();
            }
        }

        private void btnChangeImageRight_Click(object sender, EventArgs e)
        {
            if (currentImageIndex < imagesInCurrentFolderList.Count - 1)
            {
                currentImageIndex++;
                ShowCharacterImage();
            }
        }

        private void btnChangeCharLeft_Click(object sender, EventArgs e)
        {
            if (currentCharIndex > 0)
            {
                currentImageIndex = 0;
                currentCharIndex--;
                GetImagesFromFolder();
                ShowCharacterImage();
            }
        }

        private void btnChangeCharRight_Click(object sender, EventArgs e)
        {
            if (currentCharIndex < subdirectoryEntries.Length - 1)
            {
                currentImageIndex = 0;
                currentCharIndex++;
                GetImagesFromFolder();
                ShowCharacterImage();
            }
        }

        private void btnDeleteChar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                PictureBox pbx = (PictureBox)this.Controls["pbxExtractedCharacter" + i.ToString()];
                //pbx.Image = null;
            }

            try
            {
                if (File.Exists(fullPath + "\\" + subdirectoryEntries[currentCharIndex] + "\\" + imagesInCurrentFolderList[currentImageIndex] + ".bmp"))
                {
                    File.Delete(fullPath + "\\" + subdirectoryEntries[currentCharIndex] + "\\" + imagesInCurrentFolderList[currentImageIndex] + ".bmp");
                    File.Delete(fullPath + "\\" + subdirectoryEntries[currentCharIndex] + "\\" + imagesInCurrentFolderList[currentImageIndex]);
                }
            }
            catch (IOException ioExp)
            {
                MessageBox.Show(ioExp.Message);
            }

            if (Directory.GetFileSystemEntries(fullPath + "\\" + subdirectoryEntries[currentCharIndex]).Length != 0)
            {
                GetImagesFromFolder();

                if (currentImageIndex == imagesInCurrentFolderList.Count)
                    currentImageIndex--;

                ShowCharacterImage();
            }
            else
            {
                Directory.Delete(fullPath + "\\" + subdirectoryEntries[currentCharIndex]);

                GetAllFolders();

                if (currentCharIndex == subdirectoryEntries.Length)
                    currentCharIndex--;

                GetImagesFromFolder();
                ShowCharacterImage();
            }
        }

        #region edit character mouse-move
        Graphics g;
        Pen pen;
        int x = -1, y = -1;
        bool moving = false;

        private void pbxEdit_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void pbxEdit_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void pbxEdit_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                //Image pic = currentImage;
                g = Graphics.FromImage(currentImage);

                if (rbtBlack.Checked)
                {
                    pen = new Pen(Color.Black, (int)numBrushSize.Value);
                }
                else if(rbtWhite.Checked)
                {
                    pen = new Pen(Color.White, (int)numBrushSize.Value);
                }

                int firstX = (currentImage.Width * x) / pbxEdit.Image.Width;

                int firstY = (currentImage.Height * y) / pbxEdit.Image.Height;

                int lastX = (currentImage.Width * e.X) / pbxEdit.Image.Width;

                int lastY = (currentImage.Height * e.Y) / pbxEdit.Image.Height;

                if (firstX < 0)
                    firstX = 0;
                if (firstX > currentImage.Width)
                    firstX = currentImage.Width;

                if (lastX < 0)
                    lastX = 0;
                if (lastX > currentImage.Width)
                    lastX = currentImage.Width;

                if (firstY < 0)
                    firstY=0;
                if (firstY > currentImage.Height)
                    firstY= currentImage.Height;

                if (lastY < 0)
                    lastY = 0;
                if (lastY > currentImage.Height)
                    lastY = currentImage.Height;


                g.DrawLine(pen, new Point(firstX, firstY), new Point(lastX, lastY));

                x = e.X;
                y = e.Y;

                pbxEdit.Image = Zoom((Image)currentImage.Clone(),new Size(trackBar1.Value, trackBar1.Value));
            }
        }
        #endregion

        private void PanelMatrix() // create matrix of panels 16x24 and add event for click
        {
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < columnNum; j++)
                {
                    Panel p = new Panel();
                    p.Size = new Size(13, 13);

                    if ((i + j) % 2 == 0)
                        p.BackColor = Color.White;
                    else
                        p.BackColor = Color.Black;

                    p.Name = i.ToString()+ "_"+ j.ToString();
                    p.Location = new Point(673 + j * 14, 50 + i * 14);
                    p.Click += new System.EventHandler(this.PanelMatrixElementClick);
                    this.Controls.Add(p);

                    //Panel red = new Panel();
                    //red.Size = new Size(1, 14);
                    //red.Location = new Point(673 + j * 14 -1, 50 + i * 14);
                    //red.BackColor = Color.Red;
                    //this.Controls.Add(red);

                    //Panel redA = new Panel();
                    //redA.Size = new Size(14, 1);
                    //redA.Location = new Point(673 + j * 14 - 1, 50 + i * 14 - 1 );
                    //redA.BackColor = Color.Red;
                    //this.Controls.Add(redA);

                    if(i == 23)
                    {
                        //Panel redA1 = new Panel();
                        //redA1.Size = new Size(14, 1);
                        //redA1.Location = new Point(673 + j * 14 - 1, 50 + 24 * 14 - 1);
                        //redA1.BackColor = Color.Red;
                        //this.Controls.Add(redA1);
                    }
                }

                //Panel red1 = new Panel();
                //red1.Size = new Size(1, 14);
                //red1.Location = new Point(673 + 16 * 14 - 1, 50 + i * 14);
                //red1.BackColor = Color.Red;
                //this.Controls.Add(red1);
            }
        }

        void PanelMatrixElementClick(object sender, EventArgs e) //change color if color White to Black and else to White
        {
            Panel currentPanel = (Panel)sender;

            if (currentPanel.BackColor == Color.White)
                currentPanel.BackColor = Color.Black;
            else
                currentPanel.BackColor = Color.White;
        }

        public void CompressImage24x16SameRatio(Image image) // draw compressed image in picture box and panels 16x24
        {
            double resize;

            if (((image.Width * rowNum) / image.Height) <= columnNum)
                resize = (double)image.Height / (double)rowNum;
            else
                resize = (double)image.Width / (double)columnNum;

            int w, h;
            w = (int) ((double)image.Width / resize);
            h = (int)((double)image.Height / resize);

            Bitmap bmp = new Bitmap((int)columnNum, (int)rowNum);

            Brush brush = new SolidBrush(Color.White);

            Graphics gr = Graphics.FromImage(bmp);
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            gr.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);

            if(w== 0 || h == 0)
            {
                w = (int)columnNum; h = (int)rowNum;
            }

            Bitmap objBitmap = new Bitmap((Image)image.Clone(), new Size(w, h));

            objBitmap = BinarizeBitmap(objBitmap, 127);

            gr.DrawImage(objBitmap, 0, (int)rowNum - h, w, h); //24

            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < columnNum; j++)
                {
                    Panel panel = (Panel)this.Controls[i.ToString() + "_" + j.ToString()];
                    panel.BackColor = bmp.GetPixel(j, i);
                }
            }
            objBitmap.Dispose();
            gr.Dispose();
            bmp.Dispose();
        }

        public Bitmap BinarizeBitmap(Bitmap bmp, int treshold)
        {
            Image<Gray, byte> imgBinarize = new Image<Gray, byte>(bmp.Width, bmp.Height, new Gray(0));
            Image<Gray, byte> currentImage = new Image<Gray, byte>(bmp);

            CvInvoke.Threshold(currentImage, imgBinarize, treshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

            return imgBinarize.Bitmap;
        }

        public void CreateFileForSaveBinarizedChar()
        {
            if (Directory.Exists(@"C:\\CharacterExtraction\\" + tbxFileSave.Text))
            {
                // MessageBox.Show("Folder exists.");
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(@"C:\\CharacterExtraction\\" + tbxFileSave.Text);

                using (StreamWriter sw = File.CreateText(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.txt"))
                {
                    string blancs = "";

                    for (int i = 0; i < 94; i++)
                    {
                        blancs += " ";
                    }

                    sw.WriteLine(blancs);
                }

                using (StreamWriter sw = File.CreateText(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "dimensions.txt"))
                {
                    sw.WriteLine(rowNum.ToString());
                    sw.WriteLine(columnNum.ToString());
                }

                using (BinaryWriter bwStream = new BinaryWriter(new FileStream(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.bin", FileMode.Create), Encoding.ASCII))
                {
                    for (int i = 0; i < (rowNum * columnNum * 94); i++) // 94 ascii x 24 x 16
                        bwStream.Write(byte.MinValue);
                }

                // MessageBox.Show("Files normbaza.txt and normbata.bin have been created.");
            }
        }

        private void btnCompressSaveEditedPhoto_Click(object sender, EventArgs e)
        {
            CompressImage24x16SameRatio((Image)currentImage.Clone());
        }

        private void btnShowSaved_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.bin"))
            {
                MessageBox.Show("Generate normalized database first!");
                return;
            }

            try
            {
                ListNormalizedChars listChars = new ListNormalizedChars(tbxFileSave.Text);

                this.Hide();
                listChars.ShowDialog();
                
                this.Show();
                listChars.Dispose();
            }
            catch(Exception)
            {
                MessageBox.Show("Normalized database doesn't exist.");
            }
        }

        #region movable form code
        //movable form
        Point start_point = new Point(0, 0);
        bool mouseDown;
        private void EditCharacters_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            start_point = new Point(e.X, e.Y);
        }

        private void EditCharacters_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void EditCharacters_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void btnGenerateCompleteFont_Click(object sender, EventArgs e)
        {
            bool deleteExistingCharacters = false;

            bool saveCharIfNotExist = false;

            DialogResult result = MessageBox.Show("Do you want to delete already existing characters in the database?", "Delete existing chararacters and save all", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                deleteExistingCharacters = true;
            }
            else
            {
                result = MessageBox.Show("Do you want to save only those characters that do not exist in the database?", "Save character only if not exist", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveCharIfNotExist = true;
                }
            }

            CreateFileForSaveBinarizedChar();
            if (File.Exists(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\normbaza.bin") && File.Exists(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\normbaza.txt"))
            {
                byte[] allData;
                string normbazaTXT;

                using (BinaryReader brReader = new BinaryReader(
                    new FileStream(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.bin", FileMode.Open), Encoding.ASCII))
                {
                    allData = brReader.ReadBytes((int)(rowNum * columnNum * 94));
                }

                using (StreamReader sr = new StreamReader(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.txt"))
                {
                    normbazaTXT = sr.ReadToEnd();
                }

                if (deleteExistingCharacters)//brisemo sve sto postoji
                {
                    for (int i = 0; i < (rowNum * columnNum * 94); i++)
                        allData[i] = byte.MinValue;

                    string blancs = "";

                    for (int i = 0; i < 94; i++)
                    {
                        blancs += " ";
                    }
                    normbazaTXT = blancs;
                }

                for (int i = 0; i < subdirectoryEntries.Length; i++)
                {
                    string[] allFiles = Directory.GetFiles(fullPath + "\\" + subdirectoryEntries[i]);

                    string bestName = "";
                    float score = 0;

                    for (int j = 0; j < allFiles.Length; j++)
                    {
                        if (!allFiles[j].Contains(".bmp"))
                        {
                            string namee = Path.GetFileNameWithoutExtension(allFiles[j]);

                            using (StreamReader file = new StreamReader(fullPath + "\\" + subdirectoryEntries[i] + "\\" + namee))
                            {
                                string thisScore = file.ReadLine();

                                if (float.Parse(thisScore) > score)
                                {
                                    bestName = namee;
                                    score = float.Parse(thisScore);
                                }
                            }
                        }
                    }

                    using (FileStream stream = new FileStream(fullPath + "\\" + subdirectoryEntries[i] + "\\" + bestName + ".bmp", FileMode.Open, FileAccess.Read))
                    {
                        Image imgFromStream = Image.FromStream(stream);
                        Bitmap img = (Bitmap) imgFromStream;

                        double resize;

                        if (((img.Width * (int)rowNum) / img.Height) <= (int)columnNum)
                            resize = (double)img.Height / (double)rowNum;
                        else
                            resize = (double)img.Width / (double)columnNum;

                        int w, h;
                        w = (int)((double)img.Width / resize);
                        h = (int)((double)img.Height / resize);

                        Bitmap bmp = new Bitmap((int)columnNum, (int)rowNum);

                        Brush brush = new SolidBrush(Color.White);

                        Graphics gr = Graphics.FromImage(bmp);
                        gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
                        gr.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);

                        if (w == 0 || h == 0)
                        {
                            w = (int)columnNum; h = (int)rowNum;
                        }

                        Bitmap objBitmap = new Bitmap((Bitmap)img.Clone(), new Size(w, h));

                        objBitmap = BinarizeBitmap(objBitmap, 127);

                        gr.DrawImage(objBitmap, 0, (int)rowNum - h, w, h);//24

                        int asciiNum = int.Parse(subdirectoryEntries[i]);
                        int index = (asciiNum - 33) * (int)(rowNum * columnNum); // 24x16

                        bool isExistInDatabase = false;

                        if (saveCharIfNotExist)
                        {
                            for (int g = index; g < index + (int)(rowNum * columnNum); g++)
                            {
                                if (allData[g] == byte.MinValue)
                                {
                                    isExistInDatabase = true;
                                }
                            }
                        }

                        if (!isExistInDatabase)
                        {
                            for (int k = 0; k < rowNum; k++)
                            {
                                for (int j = 0; j < columnNum; j++)
                                {

                                    if (bmp.GetPixel(j, k).R == byte.MaxValue)
                                    {
                                        allData[index] = byte.MinValue;
                                    }
                                    else if (bmp.GetPixel(j, k).R == byte.MinValue)
                                    {
                                        allData[index] = byte.MaxValue;
                                    }

                                    index++;
                                }
                            }

                            index = asciiNum - 33;
                            char[] array = normbazaTXT.ToCharArray();
                            array[index] = (char)int.Parse(subdirectoryEntries[i]);
                            normbazaTXT = new string(array);
                        }

                        try
                        {
                            if (File.Exists(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + subdirectoryEntries[i] + ".bmp"))
                            {
                                File.Delete(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + subdirectoryEntries[i] + ".bmp");
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Bitmap bbb = new Bitmap(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + subdirectoryEntries[i] + ".bmp");
                            bbb.Dispose();
                        }



                        Bitmap imageForSaving = (Bitmap)img.Clone();

                        imageForSaving.Save(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + subdirectoryEntries[i] + ".bmp");

                        img.Dispose();
                        imageForSaving.Dispose();
                        objBitmap.Dispose();
                        gr.Dispose();
                        bmp.Dispose();
                    }
                }



                File.Delete(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.bin");
                using (BinaryWriter bwStream = new BinaryWriter(
                   new FileStream(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.bin", FileMode.Create), Encoding.Default))
                {
                    bwStream.Write(allData);
                }

                using (StreamWriter sw = File.CreateText(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.txt"))
                {
                    sw.Write(normbazaTXT);
                }

                
                using (StreamWriter sw = File.CreateText(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "dimensions.txt")) // Dimensions MxN
                {
                    sw.WriteLine(numMatrixI.Value);
                    sw.WriteLine(numMatrixJ.Value);
                    sw.Dispose();
                }

                using (StreamWriter sw = File.CreateText(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "asciiDB.txt")) // ascii database
                {
                    sw.WriteLine(rowNum.ToString());
                    sw.WriteLine(columnNum.ToString());
                    sw.WriteLine();

                    for (int a = 0; a < 94; a++)
                    {
                        for (int i = 0; i < rowNum; i++)
                        {
                            for (int j = 0; j < columnNum; j++)
                            {
                                if (allData[(int)(a * rowNum * columnNum + i * columnNum + j)] == byte.MinValue)
                                {
                                    sw.Write("0 ");
                                }
                                else
                                {
                                    sw.Write("1 ");
                                }
                            }
                            sw.WriteLine(); // Dodajemo novi red nakon iteracije kroz columnNum
                        }
                        sw.WriteLine(); // Opcionalno, dodajte prazan red između različitih karaktera
                    }
                    sw.Dispose();
                }

                MessageBox.Show("Complete font was created.");
            }
            else
            {
                MessageBox.Show("Create normalized database first.");
            }
        }

        private void btnSaveCharacterInFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.bin"))
            {
                MessageBox.Show("Generate normalized database first!");
                return;
            }

            byte[] allData;
            string normbazaTXT;

            using (BinaryReader brReader = new BinaryReader( 
                new FileStream(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.bin", FileMode.Open), Encoding.ASCII))
            {
                allData = brReader.ReadBytes((int)(rowNum * columnNum * 94));
            }

            File.Delete(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.bin");
            
            int asciiNum = (int)tbxCharacterValue.Text[0];
            int index = (asciiNum - 33) * (int)(rowNum * columnNum);

            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < columnNum; j++)
                {
                    Panel panel = (Panel)this.Controls[i.ToString() + "_" + j.ToString()];

                    if (panel.BackColor.R == byte.MaxValue)
                    {
                        allData[index] = byte.MinValue;
                    }
                    else if (panel.BackColor.R == byte.MinValue)
                    {
                        allData[index] = byte.MaxValue;
                    }

                    index++;
                }
            }

            using (BinaryWriter bwStream = new BinaryWriter(
                new FileStream(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.bin", FileMode.Create), Encoding.Default))
            {
                bwStream.Write(allData);
            }

            using(StreamReader sr = new StreamReader( @"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.txt" ))
            {
                normbazaTXT = sr.ReadToEnd();
            }

            index = asciiNum - 33;
            char[] array = normbazaTXT.ToCharArray();
            array[index] = (char)tbxCharacterValue.Text[0];
            normbazaTXT = new string(array);

            using (StreamWriter sw = File.CreateText(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + "normbaza.txt"))
            {
                sw.Write(normbazaTXT);
            }

            Image imageForSaving = (Image)currentImage.Clone();

            if(File.Exists(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + ((int)tbxCharacterValue.Text[0]).ToString() + ".bmp"))
            {
                File.Delete(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + ((int)tbxCharacterValue.Text[0]).ToString() + ".bmp");
            }

            imageForSaving.Save(@"C:\\CharacterExtraction\\" + tbxFileSave.Text + "\\" + ((int)tbxCharacterValue.Text[0]).ToString() +".bmp");

            imageForSaving.Dispose();

            MessageBox.Show("Character " + tbxCharacterValue.Text + " is saved!");
        }

        #region zoom

        Image Zoom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap((Image)img.Clone(), img.Width + (img.Width * size.Width / 150), img.Height + (img.Height * size.Height / 150));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void btnCreateAsciiDatabase_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            openFileDialog.InitialDirectory = @"C:\CharacterExtraction";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    ShowAsciiDB showAsciiDB = new ShowAsciiDB(selectedFilePath);

                    this.Hide();
                    showAsciiDB.ShowDialog();
                    this.Show();
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.ToString());
                    MessageBox.Show("Ascii DB error.");
                }
            }
        }

        private void btnChangeFormat_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Characters saved in the previous format will be deleted. Do you want to continue?", "Change format", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                decimal oldRowNum = rowNum;
                decimal oldColumnNum = columnNum;
                for (int i = 0; i < rowNum; i++)
                {
                    for (int j = 0; j < columnNum; j++)
                    {
                        Panel panel = (Panel)this.Controls[i.ToString() + "_" + j.ToString()];
                        this.Controls.Remove(panel);
                    }
                }
                rowNum = numMatrixI.Value;
                columnNum = numMatrixJ.Value;
                labelNxM.Text = numMatrixI.Value.ToString() + "x" + numMatrixJ.Value.ToString();

                if (File.Exists(fullPath + "\\" + "dimensions.txt"))
                {
                    using (StreamWriter sw = File.CreateText(fullPath + "\\" + "dimensions.txt"))
                    {
                        sw.WriteLine(numMatrixI.Value);
                        sw.WriteLine(numMatrixJ.Value);
                        sw.Dispose();
                    }
                }

                PanelMatrix();

                #region Form size
                if (rowNum < 35)
                {
                    this.Height = startHeight;
                }
                else
                {
                    this.Height = startHeight + (int)(rowNum - 35) * 14;
                }

                if (columnNum < 18)
                {
                    this.Width = startWidth;
                }
                else
                {
                    this.Width = startWidth + (int)(columnNum - 18) * 14;
                }
                #endregion

                ShowCharacterImage();
            }
        }

        private void EditCharacters_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rbtGenerateIfNotExist_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (pbxEdit.Image != null && pbxEdit.Image != null)
            {
                pbxEdit.Image = Zoom((Image)currentImage.Clone(), new Size(trackBar1.Value, trackBar1.Value));
            }
        }
        #endregion //not done
    }
}
