namespace App1.Forms
{
    partial class MainList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRemove = new MaterialSkin.Controls.MaterialButton();
            this.BtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.SlAmount = new MaterialSkin.Controls.MaterialSlider();
            this.BtnReturn = new MaterialSkin.Controls.MaterialButton();
            this.DtProducts = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSell = new MaterialSkin.Controls.MaterialButton();
            this.LblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRemove);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.SlAmount);
            this.panel1.Controls.Add(this.BtnReturn);
            this.panel1.Controls.Add(this.DtProducts);
            this.panel1.Controls.Add(this.BtnSell);
            this.panel1.Controls.Add(this.LblTotal);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 383);
            this.panel1.TabIndex = 0;
            // 
            // BtnRemove
            // 
            this.BtnRemove.AutoSize = false;
            this.BtnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnRemove.Depth = 0;
            this.BtnRemove.HighEmphasis = true;
            this.BtnRemove.Icon = global::App1.Properties.Resources.trash;
            this.BtnRemove.Location = new System.Drawing.Point(736, 60);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnRemove.Size = new System.Drawing.Size(40, 36);
            this.BtnRemove.TabIndex = 8;
            this.BtnRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnRemove.UseAccentColor = false;
            this.BtnRemove.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoSize = false;
            this.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnEdit.Depth = 0;
            this.BtnEdit.HighEmphasis = true;
            this.BtnEdit.Icon = global::App1.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(736, 12);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnEdit.Size = new System.Drawing.Size(40, 36);
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnEdit.UseAccentColor = false;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // SlAmount
            // 
            this.SlAmount.Depth = 0;
            this.SlAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SlAmount.Location = new System.Drawing.Point(27, 193);
            this.SlAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.SlAmount.Name = "SlAmount";
            this.SlAmount.Size = new System.Drawing.Size(196, 40);
            this.SlAmount.TabIndex = 6;
            this.SlAmount.Text = "Cant.";
            this.SlAmount.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.SlAmount_onValueChanged);
            // 
            // BtnReturn
            // 
            this.BtnReturn.AutoSize = false;
            this.BtnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnReturn.Depth = 0;
            this.BtnReturn.HighEmphasis = true;
            this.BtnReturn.Icon = global::App1.Properties.Resources.arrow_left;
            this.BtnReturn.Location = new System.Drawing.Point(27, 341);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnReturn.Size = new System.Drawing.Size(122, 36);
            this.BtnReturn.TabIndex = 5;
            this.BtnReturn.Text = "Regresar";
            this.BtnReturn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnReturn.UseAccentColor = false;
            this.BtnReturn.UseVisualStyleBackColor = true;
            // 
            // DtProducts
            // 
            this.DtProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.price,
            this.amount,
            this.total});
            this.DtProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtProducts.Location = new System.Drawing.Point(237, 12);
            this.DtProducts.MultiSelect = false;
            this.DtProducts.Name = "DtProducts";
            this.DtProducts.ReadOnly = true;
            this.DtProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DtProducts.Size = new System.Drawing.Size(475, 368);
            this.DtProducts.TabIndex = 4;
            this.DtProducts.Leave += new System.EventHandler(this.DtProducts_Leave);
            // 
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product.HeaderText = "Producto";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // price
            // 
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // amount
            // 
            this.amount.HeaderText = "Cantidad";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BtnSell
            // 
            this.BtnSell.AutoSize = false;
            this.BtnSell.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSell.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSell.Depth = 0;
            this.BtnSell.HighEmphasis = true;
            this.BtnSell.Icon = global::App1.Properties.Resources.shopping_cart;
            this.BtnSell.Location = new System.Drawing.Point(27, 293);
            this.BtnSell.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSell.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSell.Name = "BtnSell";
            this.BtnSell.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSell.Size = new System.Drawing.Size(122, 36);
            this.BtnSell.TabIndex = 3;
            this.BtnSell.Text = "Vender";
            this.BtnSell.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSell.UseAccentColor = false;
            this.BtnSell.UseVisualStyleBackColor = true;
            this.BtnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Depth = 0;
            this.LblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblTotal.Location = new System.Drawing.Point(24, 268);
            this.LblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(55, 19);
            this.LblTotal.TabIndex = 2;
            this.LblTotal.Text = "Total: 0";
            // 
            // txtPrice
            // 
            this.txtPrice.AnimateReadOnly = false;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Depth = 0;
            this.txtPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.Hint = "Precio";
            this.txtPrice.LeadingIcon = null;
            this.txtPrice.Location = new System.Drawing.Point(27, 114);
            this.txtPrice.MaxLength = 50;
            this.txtPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(180, 50);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Text = "";
            this.txtPrice.TrailingIcon = null;
            this.txtPrice.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // txtProduct
            // 
            this.txtProduct.AnimateReadOnly = false;
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProduct.Depth = 0;
            this.txtProduct.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProduct.Hint = "Nombre del Producto";
            this.txtProduct.LeadingIcon = null;
            this.txtProduct.Location = new System.Drawing.Point(27, 26);
            this.txtProduct.MaxLength = 50;
            this.txtProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProduct.Multiline = false;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(180, 50);
            this.txtProduct.TabIndex = 0;
            this.txtProduct.Text = "";
            this.txtProduct.TrailingIcon = null;
            // 
            // MainList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainList";
            this.Text = "MainList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtPrice;
        private MaterialSkin.Controls.MaterialTextBox txtProduct;
        private MaterialSkin.Controls.MaterialLabel LblTotal;
        private MaterialSkin.Controls.MaterialButton BtnSell;
        private MaterialSkin.Controls.MaterialButton BtnReturn;
        private System.Windows.Forms.DataGridView DtProducts;
        private MaterialSkin.Controls.MaterialSlider SlAmount;
        private MaterialSkin.Controls.MaterialButton BtnRemove;
        private MaterialSkin.Controls.MaterialButton BtnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}