using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Notepad__;

namespace Csgo_Command_Viewer
{
    public partial class Main : Form
    {
        string cmdFile = "";
        string[] commands = new string[0];
        string descFile = "";
        string[] descriptions = new string[0];
        string valueFile = "";
        string[] values = new string[0];
        string cheatFile = "";
        string[] cheats = new string[0];

        string selectedCommand = "";
        char bindKey = ' ';
        public static string cfg = "";
        public static bool isAutoexec = false;

        public Main()
        {
            InitializeComponent();

            try
            {
                cmdFile = Properties.Resources.ListofCommands;
                descFile = Properties.Resources.ListofDescriptions;
                valueFile = Properties.Resources.ListofValues;
                cheatFile = Properties.Resources.ListofCheats;

                commands = cmdFile.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                descriptions = descFile.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                values = valueFile.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                cheats = cheatFile.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            }
            catch (Exception)
            {
                MessageBox.Show("An error ocurred while opening a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            for (int i = 0; i < commands.Length; i++)
            {
                listBox1.Items.Add(commands[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool needsCheats = false;
            bool hasValue = false;

            int i = listBox1.SelectedIndex;

            if (!string.IsNullOrEmpty(cheats[i])) needsCheats = true;
            else needsCheats = false;

            if (values[i] != "cmd") hasValue = true;
            else hasValue = false;

            if (!string.IsNullOrEmpty(descriptions[i])) DescriptionTextBox.Text = descriptions[i] + "\n\n";
            else DescriptionTextBox.Text = "A description for this command is not available.\n\n";
            if (hasValue) DescriptionTextBox.Text += $"The default value is {values[i]}.\n\n";
            else DescriptionTextBox.Text += "This command doesn't require any arguments or it doesn't have any default value.\n\n";
            if (needsCheats) DescriptionTextBox.Text += "This command requires sv_cheats 1.\n\n";

            selectedCommand = commands[listBox1.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Please press the key you want to bind";
            this.KeyPreview = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bindKey = e.KeyChar;
            this.KeyPreview = false;

            if (comboBox1.Text == "incrementvar" && (string.IsNullOrEmpty(argsTextBox1.Text) || string.IsNullOrEmpty(argsTextBox2.Text) || string.IsNullOrEmpty(argsTextBox3.Text)))
            {
                MessageBox.Show("Please insert the parmeters for the incrementvar command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.Text == "toggle" && (string.IsNullOrEmpty(argsTextBox1.Text) || string.IsNullOrEmpty(argsTextBox2.Text)))
            {
                MessageBox.Show("Please insert the parmeters for the toggle command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBox1.Text)
            {
                case "default":
                    bindTextBox.Text = $"bind {bindKey} \"{selectedCommand}\";";
                    break;
                case "incrementvar":
                    bindTextBox.Text = $"bind {bindKey} \"incrementvar {selectedCommand} {argsTextBox1.Text} {argsTextBox2.Text} {argsTextBox3.Text}\";";
                    break;
                case "toggle":
                    bindTextBox.Text = $"bind {bindKey} \"toggle {selectedCommand} {argsTextBox1.Text} {argsTextBox2.Text}\";";
                    break;
                default:
                    break;
            }

            button1.Text = "Set Key";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bindTextBox.Text))
            {
                cfg += bindTextBox.Text + "\n";
                MessageBox.Show("Success! Your bind has been added to your .cfg", ".cfg Making", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select a command and bind it to a key.", ".cfg Making", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { cfg += commands[listBox1.SelectedIndex]; }
            catch (Exception) { }

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isAutoexec)
                cfg += "host_writeconfig;";

            Stream fileStream;
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Configuration Files (*.cfg)|*.cfg";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = saveFileDialog.OpenFile()) != null)
                {
                    using (var writer = new StreamWriter(fileStream))
                    {
                        writer.Write(cfg);
                    }
                    fileStream.Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                isAutoexec = true;
            else isAutoexec = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var notepad = new Notepad();
            notepad.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var popularBinds = new Popular_Binds();
            popularBinds.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Vulcan \r\n Special Thanks to Pogo and totalcsgo.com", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
