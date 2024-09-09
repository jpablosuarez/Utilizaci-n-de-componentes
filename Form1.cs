  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            Web web = new Web();
            web.Show();
        }

        private void btnMp_Click(object sender, EventArgs e)
        {
            MediaPlayer mp = new MediaPlayer();
            mp.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();    
            pdf.Show();
        }
    }
}
