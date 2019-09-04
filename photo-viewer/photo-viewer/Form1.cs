using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photo_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /* Code shows Open File Dialog. Loads user's choice when OK is clicked. */
                pctImage.Load(openFileDialog1.FileName);
            }
        }

        private void chkStretch_CheckedChanged(object sender, EventArgs e)
        {
            /* When selected, changes SizeMode property to "Stretch". When cleared, changes to "Normal". */
            if (chkStretch.Checked)
                pctImage.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pctImage.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
