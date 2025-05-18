using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace CryptographyAndImageProcessing
{
    public partial class ExtractedText : Form
    {
        private Image image;
        private string thisText = "";
        public ExtractedText(Image img)
        {
            
            InitializeComponent();
            image = img;

            cbxExtractText.Items.Add("TesseractOnly");
            cbxExtractText.Items.Add("CubeOnly");
            cbxExtractText.Items.Add("TesseractAndCube");
            cbxExtractText.Items.Add("Default");

            cbxExtractText.SelectedIndex = 3;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = img;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExtractText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text extraction started! Please wait...");
            lblChoseOption.Text = "";
            lblChoseOption.Text = "Please wait...";
            try
            {
                var ocr = new TesseractEngine("./tessdata", "eng", (EngineMode)cbxExtractText.SelectedIndex);
                var res = ocr.Process((Bitmap)image);
                string text = res.GetText();

                lblConfidance.Text  = res.GetMeanConfidence().ToString();

                thisText = text;
                rtbExtractedText.Text = text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblChoseOption.Text = "Extraction complete!";
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(thisText);
                }
            }
        }
    }
}
