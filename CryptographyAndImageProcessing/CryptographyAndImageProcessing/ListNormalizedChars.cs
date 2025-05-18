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

namespace CryptographyAndImageProcessing
{
    public partial class ListNormalizedChars : Form
    {
        byte[] allData;
        string normbazaTXT;
        string currentChar;
        int currentCharIndex = -1;
        string folder;

        int startWidth;
        int startHeight;
        decimal rowNum = 24;
        decimal columnNum = 16;

        public ListNormalizedChars(string folder)
        {
            ReadDimension(folder);

            InitializeComponent();

            pbxImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxZoomImage.SizeMode = PictureBoxSizeMode.Zoom;

            this.folder = folder;

            // MessageBox.Show(folder);

            startWidth = this.Width;
            startHeight = this.Height;
            PanelMatrix();

            using (BinaryReader brReader = new BinaryReader(
                new FileStream(@"C:\\CharacterExtraction\\" + folder + "\\" + "normbaza.bin", FileMode.Open), Encoding.Default))
            {
                allData = brReader.ReadBytes((int)(94 * rowNum * columnNum));
            }

            using (StreamReader sr = new StreamReader(@"C:\\CharacterExtraction\\" + folder + "\\" + "normbaza.txt"))
            {
                normbazaTXT = sr.ReadToEnd();
            }

            label1.Text = normbazaTXT.Replace(" ", "-");


            GetNormalizedCharacter(true);
        }

        private void ReadDimension(string folder)
        {
            try
            {
                // MessageBox.Show(folder);

                using (StreamReader sr = new StreamReader(@"C:\\CharacterExtraction\\" + folder + "\\" + "dimensions.txt"))
                {
                    rowNum = int.Parse(sr.ReadLine());
                    columnNum = int.Parse(sr.ReadLine());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetNormalizedCharacter(bool rightLeft)// true for right, false for left
        {
            int iterations = 94;

            for (int i = rightLeft ? currentCharIndex + 1 : currentCharIndex - 1; rightLeft ? i < 94 : i > -1; i = rightLeft ? i + 1 : i - 1 )
            {
                if (normbazaTXT[i].ToString() != " ")
                {
                    label1.Text = normbazaTXT.Replace(normbazaTXT[i].ToString(), "[" + normbazaTXT[i].ToString() + "]").Replace(" ", "-");
                    currentCharIndex = i;

                    int index = i * (int)(rowNum * columnNum);

                    for (int k = 0; k < rowNum; k++)
                    {
                        for (int j = 0; j < columnNum; j++)
                        {
                            Panel panel = (Panel)this.Controls[k.ToString() + "_" + j.ToString()];

                            if (allData[index] == byte.MinValue)
                            {
                                panel.BackColor = Color.White;
                            }
                            else if (allData[index] == byte.MaxValue)
                            {
                                panel.BackColor = Color.Black;
                            }

                            index++;
                        }
                    }

                    using (FileStream stream = new FileStream(@"C:\\CharacterExtraction\\" + folder + "\\" + ((int)normbazaTXT[i]).ToString() + ".bmp", FileMode.Open, FileAccess.Read))
                    {
                        Image bmp = Image.FromStream(stream);
                        pbxImage.Image = (Bitmap)bmp.Clone();
                        pbxZoomImage.Image = (Bitmap)bmp.Clone();
                        bmp.Dispose();
                    }

                    break;
                }
                else
                {
                    iterations--;
                    if (iterations == 0)//if characters doesnt exists
                    {
                        break;
                    }
                }
                
                if (rightLeft && i == 93)
                    i = -1;

                if (!rightLeft && i == 0)
                    i = 94;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (pbxImage.Image != null)
            {
                pbxImage.Image.Dispose();
                pbxImage.Dispose();
            }

            if (pbxZoomImage.Image != null)
            {
                pbxZoomImage.Image.Dispose();
                pbxZoomImage.Dispose();
            }

            this.Dispose();
            this.Close();
        }

        private void PanelMatrix() // create matrix of panels 16x24 and add event for click
        {
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < columnNum; j++)
                {
                    Panel p = new Panel();
                    p.Size = new Size(14, 14);

                    if ((i + j) % 2 == 0)
                        p.BackColor = Color.White;
                    else
                        p.BackColor = Color.Black;

                    p.Name = i.ToString() + "_" + j.ToString();
                    p.Location = new Point(30 + j * 15, 65 + i * 15);

                    this.Controls.Add(p);
                }
            }

            if (rowNum < 23)
            {
                this.Height = startHeight;
            }
            else
            {
                this.Height = startHeight + (int)(rowNum - 23) * 14;
            }

            if (columnNum < 15)
            {
                this.Width = startWidth;
            }
            else
            {
                this.Width = startWidth + (int)(columnNum - 15) * 14;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            GetNormalizedCharacter(false);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            GetNormalizedCharacter(true);
        }

        #region movable form code
        //movable form
        Point start_point = new Point(0, 0);
        bool mouseDown;
        private void ListNormalizedChars_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            start_point = new Point(e.X, e.Y);
        }

        private void ListNormalizedChars_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void ListNormalizedChars_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void ListNormalizedChars_Load(object sender, EventArgs e)
        {

        }
    }


}
