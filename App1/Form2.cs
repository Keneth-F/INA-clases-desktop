using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void factProdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var frm = new Form1();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var frm = new CrearCuenta();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm);
            frm.Show();
        }
    }
}
