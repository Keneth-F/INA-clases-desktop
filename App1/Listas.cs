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
    public partial class Listas : Form
    {
        List<int> nums = new List<int>();
        List<int> nums1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
        public Listas()
        {
            InitializeComponent();
            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            nums1.Add(int.Parse(materialTextBox1.Text));
            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            nums1.Remove(int.Parse(materialTextBox1.Text));
            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Exist(int.Parse(materialTextBox1.Text)));
            Agregar(int.Parse(materialTextBox1.Text));

        }

        /// <summary>
        /// añade
        /// </summary>
        /// <param name="v">nuevo valor</param>
        private void Agregar(int v)
        {
            nums1.Add(v);
        }

        /// <summary>
        /// no la probe
        /// </summary>
        /// <param name="v">valor a buscar</param>
        /// <returns>true si existe v / false si  no existe v</returns>
        private bool Exist(int v)
        {
            return nums.Contains(v);
        }
    }
}

