
namespace Csgo_Command_Viewer
{
    partial class Popular_Binds
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bindTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(422, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add command to my .cfg";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Set Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescriptionTextBox.Location = new System.Drawing.Point(351, 59);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(422, 165);
            this.DescriptionTextBox.TabIndex = 7;
            this.DescriptionTextBox.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 355);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bindTextBox
            // 
            this.bindTextBox.Location = new System.Drawing.Point(351, 253);
            this.bindTextBox.Multiline = true;
            this.bindTextBox.Name = "bindTextBox";
            this.bindTextBox.ReadOnly = true;
            this.bindTextBox.Size = new System.Drawing.Size(422, 39);
            this.bindTextBox.TabIndex = 10;
            // 
            // Popular_Binds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(891, 493);
            this.Controls.Add(this.bindTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "Popular_Binds";
            this.Text = "Popular Binds";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Popular_Binds_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox bindTextBox;
    }
}