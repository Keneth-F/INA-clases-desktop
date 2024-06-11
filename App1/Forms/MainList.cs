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
using System.Xml.Linq;

namespace App1.Forms
{
    public partial class MainList : MaterialForm
    {
        double totalProduct = 0;
        List<string> products = new List<string>();
        List<int> amounts = new List<int>();
        List<double> prices = new List<double>();
        List<double> totals = new List<double>();
        public MainList()
        {
            InitializeComponent();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            var product = txtProduct.Text;
            if (!IsDouble(txtPrice.Text))
            {
                MessageBox.Show("Cantidad Invalida");
                txtPrice.Clear();
                return;

            }
            if (string.IsNullOrEmpty(product))
            {
                MessageBox.Show("Producto Invalida");
                return;
            }
            if (totalProduct <= 0)
            {
                MessageBox.Show("No ha agregado productos");
                return;
            }
            var price = Double.Parse(txtPrice.Text);
            var amount = SlAmount.Value;
            totalProduct = GetTotal(price, amount);
            products.Add(product);
            amounts.Add(amount);
            prices.Add(price);
            totals.Add(totalProduct);
            DtProducts.Rows.Add(new object[] { product, amount, price, totalProduct });
        }

        private bool IsDouble(string text)
        {
            return double.TryParse(text, out _);
        }

        private double GetTotal(double price, int amount)
        {
            return price * amount;
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (!IsDouble(txtPrice.Text))
            {
                MessageBox.Show("Cantidad Invalida");
                txtPrice.Clear();
                return;

            }
            totalProduct = GetTotal(Double.Parse(txtPrice.Text), SlAmount.Value);
            if (totalProduct <= 0)
            {
                MessageBox.Show("No ha agregado productos");
                return;
            }
            LblTotal.Text = "Total: " + totalProduct.ToString();
        }

        private void SlAmount_onValueChanged(object sender, int newValue)
        {
            if (!IsDouble(txtPrice.Text))
            {
                MessageBox.Show("Cantidad Invalida");
                txtPrice.Clear();
                return;

            }
            totalProduct = GetTotal(Double.Parse(txtPrice.Text), SlAmount.Value);
            if (totalProduct <= 0)
            {
                MessageBox.Show("No ha agregado productos");
                return;
            }
            LblTotal.Text = "Total: " + totalProduct.ToString();

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DtProducts.SelectedCells == null)
            {
                MessageBox.Show("No ha seleccionado producto");
                return;
            }
            var idx = DtProducts.SelectedCells[0].RowIndex;
            txtProduct.Text = (string)DtProducts.Rows[idx].Cells[0].Value;
            txtPrice.Text = DtProducts.Rows[idx].Cells[1].Value.ToString();
            SlAmount.Value =int.Parse(DtProducts.Rows[idx].Cells[2].Value.ToString());
            LblTotal.Text = DtProducts.Rows[idx].Cells[3].Value.ToString();
        }

        private void DtProducts_Leave(object sender, EventArgs e)
        {

        }
    }
}
