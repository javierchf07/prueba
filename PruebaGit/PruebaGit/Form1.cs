using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PruebaGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buSuma_Click(object sender, EventArgs e)
        {
            tbRespuesta.Text = (int.Parse(tbnumero1.Text) + int.Parse(tbNumero2.Text)).ToString();
        }

    }
}
