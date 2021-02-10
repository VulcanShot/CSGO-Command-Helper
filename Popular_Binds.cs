using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csgo_Command_Viewer
{
    public partial class Popular_Binds : Form
    {
        string nameFile = "";
        string[] names = new string[0];
        string descFile = "";
        string[] descriptions = new string[0];
        string bindFile = "";
        string[] binds = new string[0];
        string styleFile = "";
        string[] styles = new string[0];

        string selectedBind = "";
        string selectedStyle = "";
        char bindKey = ' ';
        public static string cfg = "";
        public static bool isAutoexec = false;

        public Popular_Binds()
        {
            InitializeComponent();

            try
            {
                nameFile = Properties.Resources.NameofBinds;
                descFile = Properties.Resources.DescriptionofBinds;
                bindFile = Properties.Resources.Binds;
                styleFile = Properties.Resources.HowToBind;

                names = nameFile.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                descriptions = descFile.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                binds = bindFile.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                styles = styleFile.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            }
            catch (Exception)
            {
                MessageBox.Show("An error ocurred while opening a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            for (int i = 0; i < names.Length; i++)
            {
                listBox1.Items.Add(names[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;

            if (!string.IsNullOrEmpty(descriptions[i]))
            {
                DescriptionTextBox.Text = descriptions[i] + "\n\n";
            }
            else DescriptionTextBox.Text = "A description for this bind is not available.";

            if (!string.IsNullOrEmpty(binds[i]))
            {
                bindTextBox.Text = binds[i];
            }
            else bindTextBox.Text = "There was an error loading the bind.";

            selectedBind = binds[listBox1.SelectedIndex];
            selectedStyle = styles[listBox1.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Please press the key you want to bind";
            this.KeyPreview = true;
        }

        private void Popular_Binds_KeyPress(object sender, KeyPressEventArgs e)
        {
            bindKey = e.KeyChar;
            this.KeyPreview = false;

            switch (selectedStyle)
            {
                case "YES":
                    bindTextBox.Text = "bind " + bindKey + " " + selectedBind;
                    break;
                case "NO":
                    MessageBox.Show("This bind doesn't support a custom key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    bindTextBox.Text = selectedBind + "; bind " + bindKey + selectedStyle;
                    break;
            }
            
            button1.Text = "Set Key";
        }
    }
}
