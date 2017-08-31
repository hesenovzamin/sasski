using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonn47_Click(object sender, EventArgs e)
        {
            if (buttonn40.Text == " " && button27.Text == " " && buttonn25.Text == " ")
            {
                buttonn47.Text = " ";
            }
            if (buttonn40.Text == "O" && button27.Text == " " && buttonn25.Text == "O")
            {
                buttonn47.Text = "O";
                buttonn11.Text = " ";
                buttonn18.Text = "O";
                buttonn18.ForeColor = Color.Lime;

            }
        }

        private void buttonn40_Click(object sender, EventArgs e)
        {
            if (buttonn47.Text == " " && buttonn38.Text == " ")
            {
                buttonn40.Text = "O";
                buttonn25.Text = "O";
                buttonn25.ForeColor =  Color.Lime;
                buttonn18.Text = " ";
            }
        }

        private void buttonn38_Click(object sender, EventArgs e)
        {
            if (buttonn45.Text == " " && buttonn40.Text == "O" && button27.Text == " " && button29.Text == " ")
            {
                buttonn38.Text = "O";
                buttonn11.Text = " ";
                buttonn18.Text = "O";
                buttonn18.ForeColor = Color.Lime;
            }
        }

        private void buttonn25_Click(object sender, EventArgs e)
        {
            if (buttonn40.Text == "O" && buttonn43.Text == " " && buttonn52.Text == " ")
            {
                buttonn25.Text = "O";
                button2.Text = " ";
                buttonn11.Text = "O";
                buttonn25.ForeColor = Color.White;
                buttonn11.ForeColor = Color.Lime;
            }
        }

        private void buttonn34_Click(object sender, EventArgs e)
        {
            if (buttonn34.Text == "O")
            {
                buttonn34.Text = " ";
            }
            else if (buttonn40.Text == "O" && buttonn25.Text == "O" && buttonn41.Text == " " && button27.Text == " ")
            {
                buttonn34.Text = "O";
                buttonn41.Text = " ";
                buttonn20.Text = " ";
                button27.Text = "O";
                button27.ForeColor = Color.Lime;
            }
  
            else if (buttonn40.Text == "O" && buttonn43.Text == " " && button27.Text == " " && buttonn52.Text == "O")
            {
                buttonn34.Text = " ";
                buttonn25.Text = " ";
                buttonn43.Text = "O";
                buttonn43.ForeColor = Color.Lime;
            }

            else if (buttonn43.Text == "O" && buttonn43.ForeColor == Color.Lime)
            {
                buttonn34.Text = "O";
                buttonn52.Text = " ";
                buttonn43.Text = " ";
                buttonn11.Text = " ";
                buttonn18.Text = "O";
                buttonn18.ForeColor = Color.Lime;
            }
        }

        private void buttonn41_Click(object sender, EventArgs e)
        {
            if (buttonn40.Text == "O" && buttonn25.Text == "O" && buttonn38.Text == " " && button29.Text == " " && button31.Text == " " && buttonn34.Text == " " && buttonn36.Text == " ")
            {
                buttonn41.Text = " ";
                buttonn45.Text = "O";
                buttonn43.Text = "O";
                buttonn54.Text = "O";
            }
         
        }

        private void buttonn20_Click(object sender, EventArgs e)
        {
            if (buttonn34.Text == " " && button27.Text == "O")
            {
                buttonn20.Text = "O";
                buttonn20.ForeColor = Color.White;
                button27.Text = " ";
                buttonn13.Text = " ";
                buttonn20.Text = " ";
                button27.Text = "O";
            }
        }

        private void buttonn43_Click(object sender, EventArgs e)
        {
            if (buttonn40.Text == "O" && buttonn25.Text == "O" && buttonn38.Text == " " && button29.Text == " " && button31.Text == " " && buttonn34.Text == " " && buttonn36.Text == " ")
            {
                buttonn43.Text = " ";
                buttonn41.Text = "O";
                buttonn45.Text = "O";
                buttonn54.Text = "O";
            }
        }

        private void buttonn36_Click(object sender, EventArgs e)
        {
            if (buttonn40.Text == "O" && buttonn43.Text == " " && button27.Text == " " && button29.Text == " " && button31.Text == " " && buttonn34.Text == " " && buttonn38.Text == " ")
            {
                buttonn36.Text = "O";
                buttonn11.Text = " ";
                buttonn18.Text = "O";
                buttonn18.ForeColor = Color.Lime;
            }
            else if (buttonn40.Text == "O" && buttonn45.Text == " " && button27.Text == " " && button29.Text == " " && buttonn34.Text == " " && buttonn38.Text == " ")
            {
                buttonn36.Text = "O";
                buttonn24.Text = " ";
                button31.Text = "O";
                button31.ForeColor = Color.Lime;
            }
            else if (buttonn43.Text == "O" && buttonn43.ForeColor == Color.Lime)
            {
                buttonn36.Text = "O";
                buttonn50.Text = " ";
                buttonn43.Text = " ";
                buttonn20.Text = " ";
                button29.Text = "O";
                button29.ForeColor = Color.Lime;
            }
        }

        private void buttonn45_Click(object sender, EventArgs e)
        {
            if (buttonn40.Text == "O" && button27.Text == " " && button29.Text == " " && buttonn25.Text == " " && button31.Text == " " && buttonn34.Text == " " && buttonn36.Text == " " && buttonn47.Text == " ")
            {
                buttonn45.Text = " ";
                buttonn41.Text = "O";
                buttonn43.Text = "O";
                buttonn54.Text = "O";
            }
        }

        private void buttonn54_Click(object sender, EventArgs e)
        {
            if (buttonn40.Text == "O" && button27.Text == " " && button29.Text == " " && button31.Text == " " && buttonn34.Text == " " && buttonn36.Text == " " && buttonn25.Text == "O")
            {
                buttonn54.Text = " ";
                buttonn41.Text = "O";
                buttonn43.Text = "O";
                buttonn45.Text = "O";
            }
        }

        private void buttonn55_Click(object sender, EventArgs e)
        {

        }

        private void buttonn52_Click(object sender, EventArgs e)
        {
            if (buttonn52.Text == "O")
            {
                buttonn52.Text = " ";
            }
        }
    }
}
