using AxWMPLib;
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
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void MediaPlayer_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string audioFilePath = @"C:\Users\Juan Pablo\Downloads\WindowsFormsApp1\WindowsFormsApp1\Wsound.mp3";

            axMPCancion.URL = audioFilePath;
            axMPCancion.Ctlcontrols.play();
        }
    }
}
