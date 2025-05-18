using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

public class TabControlCustom : TabControl
{
    public TabControlCustom()
    {
        this.DrawMode = TabDrawMode.OwnerDrawFixed;
        this.DrawItem += new DrawItemEventHandler(DrawDarkModeTab);
        this.BackColor = Color.FromArgb(40, 40, 40);
        this.Appearance = TabAppearance.Normal;
    }

    private void DrawDarkModeTab(object sender, DrawItemEventArgs e)
    {
        TabPage tabPage = this.TabPages[e.Index];
        Rectangle tabRect = this.GetTabRect(e.Index);

        // Define dark mode colors
        Color backgroundColor = e.Index == this.SelectedIndex ? Color.DarkSlateGray : Color.FromArgb(40, 40, 40);
        Color textColor = SystemColors.ActiveCaption;
        Color borderColor = Color.FromArgb(40, 40, 40);

        tabRect.Inflate(-2, -2);

        // Draw background
        using (Brush backgroundBrush = new SolidBrush(backgroundColor))
        {
            e.Graphics.FillRectangle(backgroundBrush, tabRect);
        }

        // Draw border
        using (Pen borderPen = new Pen(borderColor))
        {
            e.Graphics.DrawRectangle(borderPen, tabRect);
        }
        e.DrawFocusRectangle();

        // Draw tab text
        TextRenderer.DrawText(e.Graphics, tabPage.Text, this.Font, tabRect, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        base.OnPaint(pe);
        // Set control's background to dark color
        pe.Graphics.Clear(Color.FromArgb(40, 40, 40));

        // Draw the tab control border (you can skip this if you don't want any border)
        Rectangle tabControlBorder = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
        using (Pen borderPen = new Pen(Color.FromArgb(40, 40, 40)))
        {
            pe.Graphics.DrawRectangle(borderPen, tabControlBorder);
        }

        base.OnPaint(pe);
    }
}