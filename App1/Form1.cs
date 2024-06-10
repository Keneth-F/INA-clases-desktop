using App1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Green400, Primary.Green400,
            //     Primary.Green400,Accent.Green400, TextShade.WHITE
            //    );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hola {txtName.Text}");
            var form = new DataTypes();
            form.ShowDialog();
        }

        private void btnConst_Click(object sender, EventArgs e)
        {
            Constantes form = new Constantes();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ValoresCompuestos();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new EstructuraControl();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var form = new Main();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog();
        }
    }
}
