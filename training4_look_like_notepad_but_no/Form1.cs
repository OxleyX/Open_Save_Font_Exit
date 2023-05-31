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

namespace training4_look_like_notepad_but_no
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"Desktop";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileContents = File.ReadAllText(filePath);
                richTextBox.Text = fileContents;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.DefaultExt = "rtf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                if (saveFileDialog1.FilterIndex == 1)
                {
                    richTextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }
                else if (saveFileDialog1.FilterIndex == 2)
                {
                    richTextBox.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;
            colorDialog1.AnyColor = true;
            colorDialog1.Color = richTextBox.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.ForeColor = colorDialog1.Color;
            }
        }

        private void btnStyle_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox.Font;
            fontDialog1.Color = richTextBox.ForeColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Font = fontDialog1.Font;
                richTextBox.ForeColor = fontDialog1.Color;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
