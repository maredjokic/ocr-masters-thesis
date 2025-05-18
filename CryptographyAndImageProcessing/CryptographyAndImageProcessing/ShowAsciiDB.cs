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
    public partial class ShowAsciiDB : Form
    {
        string content = "";
        byte[] allData;
        int rowNum;
        int columnNum;
        int startHeight;
        int startWidth;
        string normbazaTXT = "!" + "\"" + "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";

        int currentCharIndex = -1;
        public ShowAsciiDB(string selectedFilePath)
        {
            InitializeComponent();

            rtbAsciiDB.Text = File.ReadAllText(selectedFilePath);

            using (StreamReader sr = new StreamReader(selectedFilePath))
            {
                rowNum = int.Parse(sr.ReadLine());
                columnNum = int.Parse(sr.ReadLine());
                sr.Dispose();
            }

            string[] lines = File.ReadAllLines(selectedFilePath);
            allData = new byte[rowNum * columnNum * 94];

            int currentLineIndex = 3;
            int dataIndex = 0;

            for (int a = 0; a < 94; a++) // Iteracija kroz sve karaktere
            {
                for (int i = 0; i < rowNum; i++) // Iteracija kroz redove
                {
                    string[] rowValues = lines[currentLineIndex].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < columnNum; j++) // Iteracija kroz kolone
                    {
                        // Pretvaranje "0" i "1" u byte vrednosti
                        allData[dataIndex] = rowValues[j] == "0" ? byte.MinValue : byte.MaxValue;
                        dataIndex++;
                    }
                    currentLineIndex++;
                }
                currentLineIndex++; // Preskočimo prazan red između karaktera
            }



            labelRow.Text = rowNum.ToString();
            labelColumn.Text = columnNum.ToString();

            startWidth = this.Width;
            startHeight = this.Height;

            PanelMatrix();
            GetNormalizedCharacter(true);
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
                    p.Location = new Point(700 + j * 15, 55 + i * 15);

                    this.Controls.Add(p);
                }
            }

            if (rowNum < 40)
            {
                this.Height = startHeight;
            }
            else
            {
                this.Height = startHeight + (int)(rowNum - 40) * 14;
            }

            if (columnNum < 30)
            {
                this.Width = startWidth;
            }
            else
            {
                this.Width = startWidth + (int)(columnNum - 30) * 14;
            }
        }

        public void GetNormalizedCharacter(bool rightLeft)// true for right, false for left
        {
            int iterations = 94;

            for (int i = rightLeft ? currentCharIndex + 1 : currentCharIndex - 1; rightLeft ? i < 94 : i > -1; i = rightLeft ? i + 1 : i - 1)
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
            this.Close();
        }

        private void ShowAsciiDB_KeyDown(object sender, KeyEventArgs e)
        {

        }


        #region Move control

        Point start_point = new Point(0, 0);
        bool mouseDown;
        private void ShowAsciiDB_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            start_point = new Point(e.X, e.Y);
        }

        private void ShowAsciiDB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void ShowAsciiDB_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        private void btnRight_Click(object sender, EventArgs e)
        {
            GetNormalizedCharacter(true);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            GetNormalizedCharacter(false);
        }
    }
}
