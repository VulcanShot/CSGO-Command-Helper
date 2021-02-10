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
using Csgo_Command_Viewer;

namespace Notepad__
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fontDialog1.Font = mainTextBox.Font;
            fontDialog1.Color = mainTextBox.ForeColor;
            mainTextBox.Text = Main.cfg;
        }

        private void wordWrapOption_CheckedChanged(object sender, EventArgs e)
        {
            if (wordWrapOption.Checked)
            {
                mainTextBox.WordWrap = true;
            }
            else
            {
                mainTextBox.WordWrap = false;
            }
        }

        private void exitToolItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newFileItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
            StatusLabel1.Text = "New file created succesfully";
            saveFileItem.Enabled = false;
        }

        private void saveFileItem_Click(object sender, EventArgs e)
        {
            Main.cfg = mainTextBox.Text;

            saveFileItem.Enabled = false;
            StatusLabel1.Text = ".cfg updated succesfully";
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            saveFileItem.Enabled = true;
        }

        private void changeFontMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.Font = fontDialog1.Font;
                mainTextBox.ForeColor = fontDialog1.Color;
            }
        }
        private void timeDateMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "host_writeconfig";
        }
    }
}
