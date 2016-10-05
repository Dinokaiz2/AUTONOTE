using System.Drawing;

namespace AUTONOTE
{
    partial class HelpForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(259, 236);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.AppendText("Help:\n\n");
            this.richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            this.richTextBox1.AppendText("AUTONOTE won't read my text correctly!\n");
            this.richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            this.richTextBox1.AppendText("AUTONOTE uses OCR, or Ocular Character Recognition, to get text out of images. " +
            "OCR isn't perfect, so zooming in the image before snipping it can improve " +
            "the text output accuracy by a wide margin.\n\n");
            this.richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            this.richTextBox1.AppendText("I've found a problem with AUTONOTE\n");
            this.richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            this.richTextBox1.AppendText("Please submit undocumented problems to https://github.com/Dinokaiz2/AUTONOTE/issues.");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.richTextBox1);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}