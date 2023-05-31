namespace training4_look_like_notepad_but_no
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnStyle = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 35);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSave.Location = new System.Drawing.Point(128, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnColor.Location = new System.Drawing.Point(244, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(110, 35);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "FontColor";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnStyle
            // 
            this.btnStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnStyle.Location = new System.Drawing.Point(360, 12);
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.Size = new System.Drawing.Size(110, 35);
            this.btnStyle.TabIndex = 3;
            this.btnStyle.Text = "Font Style";
            this.btnStyle.UseVisualStyleBackColor = true;
            this.btnStyle.Click += new System.EventHandler(this.btnStyle_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Exit.Location = new System.Drawing.Point(476, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(110, 35);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.richTextBox.Location = new System.Drawing.Point(12, 96);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(574, 230);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 600);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnStyle);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Notepad--";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnStyle;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

