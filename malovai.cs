using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalovaniMalovani
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x;
        int y;
        
        int ether1;
        int ether2;
        int size;
        bool emil;
        string tool;
        bool fill;
        private Pen currentPen = new Pen(Color.Aqua, 1);
        private Brush currentBrush = new SolidBrush(Color.White);


        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            
        }
        
        public void SetSize(int size) 
        {
            Pen aqua = new Pen(Color.Aquamarine, size);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (emil)
            {
              
                g.FillEllipse(currentBrush, e.X-size/2, e.Y - size / 2, size,size);
                g.DrawLine(currentPen, e.X, e.Y,x,y);
                x = e.X;
                y = e.Y;
               
                
                

            }
        }
        
        private void ChangeTool(string tool)
        {
            switch (tool)
            {
                case "aqua":
                    currentPen.Color = Color.Aqua;
                    currentBrush = new SolidBrush(Color.Aqua);
                    break;
                case "purple":
                    currentPen.Color = Color.Purple;
                    currentBrush = new SolidBrush(Color.Purple);
                    break;
                case "red":
                    currentPen.Color = Color.Red;
                    currentBrush = new SolidBrush(Color.Red);
                    break;
                case "blue":
                    currentPen.Color = Color.Blue;
                    currentBrush = new SolidBrush(Color.Blue);
                    break;
                case "black":
                    currentPen.Color = Color.Black;
                    currentBrush = new SolidBrush(Color.Black);
                    break;
                case "yellow":
                    currentPen.Color = Color.Yellow;
                    currentBrush = new SolidBrush(Color.Yellow);
                    break;
                case "white":
                    currentPen.Color = Color.White;
                    currentBrush = new SolidBrush(Color.White);
                    break;
                case "green":
                    currentPen.Color = Color.Green;
                    currentBrush = new SolidBrush(Color.Green);
                    break;
                case "orange":
                    currentPen.Color = Color.Orange;
                    currentBrush = new SolidBrush(Color.Orange);
                    break;
                case "pink":
                    currentPen.Color = Color.Pink;
                    currentBrush = new SolidBrush(Color.Pink);
                    break;
                case "brown":
                    currentPen.Color = Color.Brown;
                    currentBrush = new SolidBrush(Color.Brown);

                    break;
                case "gray":
                    currentPen.Color = Color.Gray;
                    currentBrush = new SolidBrush(Color.Gray);
                    break;
                case "hotpink":
                    currentPen.Color = Color.HotPink;
                    currentBrush = new SolidBrush(Color.HotPink);
                    break;
                case "erase":
                    currentPen.Color = Color.White;
                    currentBrush = new SolidBrush(Color.White);
                    break;

            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBar1.Value;
            size = trackBar1.Value;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            emil = true;
            x = e.X;
            y = e.Y;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            emil = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NEVER GONNA GIVE YOU UP");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool = "aqua";
            ChangeTool(tool);
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            tool = "purple";
            ChangeTool(tool);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tool = "red";
            ChangeTool(tool);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tool = "blue";
            ChangeTool(tool);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            tool = "yellow";
            ChangeTool(tool);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tool = "erase";
            ChangeTool(tool);
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            tool = "black";
            ChangeTool(tool);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tool = "green";
            ChangeTool(tool);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tool = "pink";
            ChangeTool(tool);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tool = "orange";
            ChangeTool(tool);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tool = "brown";
            ChangeTool(tool);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tool = "hotpink";
            ChangeTool(tool);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tool = "gray";
            ChangeTool(tool);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            g.FillRectangle(currentBrush, 0, 0, 500, 500);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                g.FillEllipse(currentBrush, x-size/2,y-size/2, size, size);
            }
            else
            {
                g.DrawEllipse(currentPen, x,y, size, size);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                g.FillRectangle(currentBrush, x, y, size, size);
            }
            else
            {
                g.DrawRectangle(currentPen, x, y, size, size);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                g.FillRectangle(currentBrush, x, y, size, size);
            }
            else
            {
                g.DrawRectangle(currentPen, x, y, size, size);
            }
        }
    }
}
