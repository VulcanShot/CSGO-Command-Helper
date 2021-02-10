
namespace Csgo_Command_Viewer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.bindTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.argsTextBox1 = new System.Windows.Forms.TextBox();
            this.argsTextBox2 = new System.Windows.Forms.TextBox();
            this.argsTextBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(81, 37);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 355);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescriptionTextBox.Location = new System.Drawing.Point(459, 37);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(422, 233);
            this.DescriptionTextBox.TabIndex = 2;
            this.DescriptionTextBox.Text = "";
            // 
            // bindTextBox
            // 
            this.bindTextBox.Location = new System.Drawing.Point(192, 456);
            this.bindTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bindTextBox.Name = "bindTextBox";
            this.bindTextBox.ReadOnly = true;
            this.bindTextBox.Size = new System.Drawing.Size(392, 20);
            this.bindTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 356);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(422, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add command to my .cfg (You can add parameters)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(742, 449);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Add bind to my .cfg";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(171, 516);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(556, 33);
            this.button4.TabIndex = 7;
            this.button4.Text = "Export my .cfg";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(81, 525);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Autoexec";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(459, 298);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(422, 33);
            this.button5.TabIndex = 9;
            this.button5.Text = "Preview and edit my .cfg";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "incrementvar",
            "default",
            "toggle"});
            this.comboBox1.Location = new System.Drawing.Point(81, 446);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "default";
            // 
            // argsTextBox1
            // 
            this.argsTextBox1.Location = new System.Drawing.Point(90, 474);
            this.argsTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.argsTextBox1.Name = "argsTextBox1";
            this.argsTextBox1.Size = new System.Drawing.Size(13, 20);
            this.argsTextBox1.TabIndex = 12;
            // 
            // argsTextBox2
            // 
            this.argsTextBox2.Location = new System.Drawing.Point(119, 474);
            this.argsTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.argsTextBox2.Name = "argsTextBox2";
            this.argsTextBox2.Size = new System.Drawing.Size(13, 20);
            this.argsTextBox2.TabIndex = 13;
            // 
            // argsTextBox3
            // 
            this.argsTextBox3.Location = new System.Drawing.Point(148, 474);
            this.argsTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.argsTextBox3.Name = "argsTextBox3";
            this.argsTextBox3.Size = new System.Drawing.Size(13, 20);
            this.argsTextBox3.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(742, 516);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 33);
            this.button6.TabIndex = 15;
            this.button6.Text = "Popular Binds";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(412, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "By Vulcan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1028, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.argsTextBox3);
            this.Controls.Add(this.argsTextBox2);
            this.Controls.Add(this.argsTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = ".cfg Maker";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox bindTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox argsTextBox1;
        private System.Windows.Forms.TextBox argsTextBox2;
        private System.Windows.Forms.TextBox argsTextBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}

