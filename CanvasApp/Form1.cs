using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanvasApp
{
    public partial class Form1 : Form
    {
        private Color currentColor; // Variable to store the current color

        public Form1()
        {
            InitializeComponent();
            currentColor = Color.Black; // Set the initial color to black
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Check if the left mouse button is pressed
            {
                using (Graphics g = CreateGraphics())
                {
                    g.FillEllipse(new SolidBrush(currentColor), e.X, e.Y, 10, 10); // Draw a filled ellipse at the mouse position with the current color
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void GreenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentColor = Color.Green; // Set the current color to green
        }

        private void BlueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentColor = Color.Blue; // Set the current color to blue
        }
    }
}
