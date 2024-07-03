using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace App1.Forms
{
    public partial class EstructuraControl : MaterialForm
    {
        public EstructuraControl()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink100, Primary.Pink100,
                 Primary.Pink100, Accent.Pink100, TextShade.WHITE
                );
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 100;
            if (x > 50)
            {
                MessageBox.Show("Test");
            }
            else if (x < 50)
            {
                MessageBox.Show("Test1");
            }
            else
            {
                if (x < 50)
                {
                    MessageBox.Show("Test1");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int y = 100;
            switch (y)
            {
                case 0:
                    Console.WriteLine("0");
                    break;
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                default:
                    Console.WriteLine(y);
                    break;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            int[] nums = {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9
            };
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
        int i = 0;
        string[] dias = new string[100];
        private void EstructuraControl_Load(object sender, EventArgs e)
        { }
        private void button4_Click(object sender, EventArgs e)
        {
            string d = textBox1.Text;
            if (!Array.Exists(dias, _d => _d == d) && !string.IsNullOrEmpty(d))
            {
                dias[i++] = d;
                dataGridView1.Rows.Add(d);
            }
            textBox1.Clear();
            Console.WriteLine();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.SaveClose();
            if (dataGridView1.SelectedCells[0] != null && !String.IsNullOrEmpty((string)dataGridView1.SelectedCells[0].Value))
            {
                DialogResult opcionUsuario = MessageBox.Show($"Desea eliminar el dia {dataGridView1.SelectedCells[0].Value}?", "Advertencia", MessageBoxButtons.YesNo);
                switch (opcionUsuario)
                {
                    case DialogResult.Yes:
                        for (int i = 0; i < dias.Length - 1; i++)
                        {
                            int idx = dataGridView1.SelectedCells[0].RowIndex;
                            if (i >= idx)
                            {
                                dias[i] = dias[i + 1];
                            }
                        }
                        Array.Resize(ref dias, dias.Length - 1);
                        dataGridView1.Rows.Clear();
                        foreach (var item in dias)
                        {
                            dataGridView1.Rows.Add(item);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (textBox2.Text != "")
            {
                for (int _i = 0; _i < i - 1; _i++)
                {
                    if (dias[_i].Contains(textBox2.Text))
                    {
                        dataGridView1.Rows.Add(dias[_i]);
                    }
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
                for (int _i = 0; _i < i - 1; _i++)
                {
                    dataGridView1.Rows.Add(dias[_i]);
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = false;
            Console.WriteLine(dataGridView1.SelectedCells[0]);
        }
    }
}