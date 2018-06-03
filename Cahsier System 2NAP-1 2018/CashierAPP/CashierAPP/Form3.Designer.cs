namespace ProjectGUI
{
    partial class addproform
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
            this.proidtxbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pronametxbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricetxbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stocktxbx = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.DGVProduct = new System.Windows.Forms.DataGridView();
            this.IDPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // proidtxbx
            // 
            this.proidtxbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.proidtxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proidtxbx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.proidtxbx.Location = new System.Drawing.Point(186, 77);
            this.proidtxbx.Name = "proidtxbx";
            this.proidtxbx.Size = new System.Drawing.Size(201, 22);
            this.proidtxbx.TabIndex = 0;
            this.proidtxbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUCT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRODUCT NAME";
            // 
            // pronametxbx
            // 
            this.pronametxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pronametxbx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pronametxbx.Location = new System.Drawing.Point(186, 121);
            this.pronametxbx.Name = "pronametxbx";
            this.pronametxbx.Size = new System.Drawing.Size(201, 22);
            this.pronametxbx.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRICE";
            // 
            // pricetxbx
            // 
            this.pricetxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxbx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pricetxbx.Location = new System.Drawing.Point(186, 161);
            this.pricetxbx.Name = "pricetxbx";
            this.pricetxbx.Size = new System.Drawing.Size(201, 22);
            this.pricetxbx.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "STOCK";
            // 
            // stocktxbx
            // 
            this.stocktxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocktxbx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.stocktxbx.Location = new System.Drawing.Point(186, 202);
            this.stocktxbx.Name = "stocktxbx";
            this.stocktxbx.Size = new System.Drawing.Size(201, 22);
            this.stocktxbx.TabIndex = 6;
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.savebutton.Location = new System.Drawing.Point(24, 230);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(363, 33);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // DGVProduct
            // 
            this.DGVProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPro,
            this.ProName,
            this.Stock,
            this.Price});
            this.DGVProduct.Location = new System.Drawing.Point(403, 75);
            this.DGVProduct.Name = "DGVProduct";
            this.DGVProduct.Size = new System.Drawing.Size(471, 222);
            this.DGVProduct.TabIndex = 9;
            // 
            // IDPro
            // 
            this.IDPro.HeaderText = "Product ID";
            this.IDPro.Name = "IDPro";
            // 
            // ProName
            // 
            this.ProName.HeaderText = "Name";
            this.ProName.Name = "ProName";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Red;
            this.closebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.ForeColor = System.Drawing.SystemColors.Info;
            this.closebutton.Location = new System.Drawing.Point(156, 269);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(94, 35);
            this.closebutton.TabIndex = 10;
            this.closebutton.Text = "CLOSE";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // addproform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 311);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.DGVProduct);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stocktxbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricetxbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pronametxbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proidtxbx);
            this.Name = "addproform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD PRODUCT";
            this.Load += new System.EventHandler(this.addproform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox proidtxbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pronametxbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricetxbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stocktxbx;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.DataGridView DGVProduct;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}