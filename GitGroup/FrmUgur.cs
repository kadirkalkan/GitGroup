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
    public partial class FrmUgur : Form
    {
        int tikTakip = 0;
        public FrmUgur()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            tikTakip++;
            
            if (tikTakip <3)
            {
                listView1.Items.Add("Hocam cugara biz de icek");
            }
            
            else if(tikTakip<6 && tikTakip>3)
            {
                listView1.Items.Add("Hocam cugara");
            }

            else
            {
                listView1.Items.Add("cugara");
            }

          


        }

    }
}
