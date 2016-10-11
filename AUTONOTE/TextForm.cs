using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTONOTE
{
    public partial class TextForm : Form
    {
        Image image;

        public TextForm(Image img)
        {
            image = img;
            if(!OCR.IsInited()) { OCR.Init(); }
            string text = OCR.ImageToText((Bitmap)img);
            InitializeComponent(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageForm imageForm = new ImageForm(image);
            imageForm.Show();
        }
    }
}
