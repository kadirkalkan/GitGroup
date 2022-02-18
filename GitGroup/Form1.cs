using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitGroup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Form frm = default;
            switch (btn.Tag.ToString())
            {
                case "oguz":
                    frm = new FrmOguz();
                    break;
                case "ugur":
                    frm = new FrmUgur();
                    break;
                case "sinan":
                    frm = new FrmSinan();
                    break;
            }
            frm.ShowDialog();
        }
    }
}
