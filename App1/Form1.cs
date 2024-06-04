﻿using App1.Forms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hola {txtName.Text}");
            var form = new DataTypes();
            form.ShowDialog();
        }

        private void btnConst_Click(object sender, EventArgs e)
        {
            var form = new Constantes();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ValoresCompuestos();
            form.ShowDialog();
        }
    }
}
