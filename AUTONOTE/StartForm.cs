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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bmp = SnipForm.Snip();
            TextForm textForm = new TextForm(bmp);
            textForm.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCollection allForms = Application.OpenForms;
            for (int i = allForms.Count-1; i >= 0; i--)
            {
                Form form = allForms[i];
                if(form.GetType() != typeof(StartForm))
                {
                    form.Close();
                }
            }
        }
    }
}
