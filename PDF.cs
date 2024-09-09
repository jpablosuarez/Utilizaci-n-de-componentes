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
    public partial class PDF : Form
    {
        public PDF()
        {
            InitializeComponent();
        }

        private void PDF_Load(object sender, EventArgs e)
        {
            String pdfpaPath = @"C:\Users\Juan Pablo\Downloads\WindowsFormsApp1\WindowsFormsApp1\Hola mundo.pdf";

            axPDF1.src = pdfpaPath;
        }
    }
}
