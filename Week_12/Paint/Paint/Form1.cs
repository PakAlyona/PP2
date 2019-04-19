using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public enum Tools
    {
        pen,
        penS,
        erase,
        line,
        rectangle
    }
    public partial class Paint : Form
    {
        Pen pen;
        Pen erase;
        Bitmap bitmap;
        Graphics graphics;
        Point firstP;
        Point secondP;
        Tools tools = Tools.pen;

        public Paint()
        {
            InitializeComponent();
            pen = new Pen(Color.Aquamarine, 8);
            erase = new Pen(Color.White, 20);
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
            //Tools tools = new Tools();
        }


        private void ColorB_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void PenButton_Click(object sender, EventArgs e)
        {
            tools = Tools.pen;
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            tools = Tools.erase;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            firstP = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                secondP = e.Location;
                switch (tools)
                {
                    case Tools.pen:
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
                        graphics.DrawLine(pen, firstP, secondP);
                        firstP = secondP;
                        break;
                    case Tools.penS:
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        graphics.DrawLine(pen, firstP, secondP);
                        firstP = secondP;
                        break;
                    case Tools.erase:
                        erase.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        erase.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        graphics.DrawLine(erase, firstP, secondP);
                        firstP = secondP;
                        break;
                    case Tools.line:
                        break;
                    case Tools.rectangle:
                        break;
                }

            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (tools)
            {
                case Tools.line:
                    secondP = e.Location;
                    graphics.DrawLine(pen, firstP, secondP);
                    pictureBox1.Refresh();
                    break;
                case Tools.rectangle:
                    graphics.DrawRectangle(pen, rectangle(firstP, secondP));
                    break;
            }
        }
        private void PenSB_Click(object sender, EventArgs e)
        {
            tools = Tools.penS;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
            erase.Width = trackBar1.Value;
        }

        private void LineB_Click(object sender, EventArgs e)
        {
            tools = Tools.line;

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (tools)
            {
                case Tools.pen:
                    break;
                case Tools.penS:
                    break;
                case Tools.erase:
                    break;
                case Tools.line:
                    e.Graphics.DrawLine(pen, firstP, secondP);
                    break;
                case Tools.rectangle:
                    e.Graphics.DrawRectangle(pen, rectangle(firstP, secondP));
                    break;
            }
        }

        private void RectangleB_Click(object sender, EventArgs e)
        {
            tools = Tools.rectangle;
        }
        Rectangle rectangle(Point p, Point p2)
        {
            Rectangle result = new Rectangle();
            result.X = Math.Min(p.X, p2.X);
            result.Y = Math.Min(p.Y, p2.Y);
            result.Width = Math.Abs(p.X - p2.X);
            result.Height = Math.Abs(p.Y - p2.Y);
            return result;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            bitmap.Save(saveFileDialog1.FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            bitmap = new Bitmap(openFileDialog1.FileName);
            graphics = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            //pictureBox1.Refresh();
        }
    }
}