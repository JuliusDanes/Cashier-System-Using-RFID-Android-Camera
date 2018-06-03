namespace ProjectGUI
{
    partial class updateproform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateproform));
            this.closebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatebutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.stocktxbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricetxbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pronametxbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proidtxbx = new System.Windows.Forms.TextBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Red;
            this.closebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.ForeColor = System.Drawing.SystemColors.Info;
            this.closebutton.Location = new System.Drawing.Point(161, 273);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(94, 35);
            this.closebutton.TabIndex = 21;
            this.closebutton.Text = "CLOSE";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPro,
            this.ProName,
            this.Stock,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(398, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 216);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.updatebutton.Location = new System.Drawing.Point(19, 234);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(188, 33);
            this.updatebutton.TabIndex = 19;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "STOCK";
            // 
            // stocktxbx
            // 
            this.stocktxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocktxbx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.stocktxbx.Location = new System.Drawing.Point(181, 156);
            this.stocktxbx.Name = "stocktxbx";
            this.stocktxbx.Size = new System.Drawing.Size(201, 22);
            this.stocktxbx.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "PRICE";
            // 
            // pricetxbx
            // 
            this.pricetxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxbx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pricetxbx.Location = new System.Drawing.Point(181, 198);
            this.pricetxbx.Name = "pricetxbx";
            this.pricetxbx.Size = new System.Drawing.Size(201, 22);
            this.pricetxbx.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "PRODUCT NAME";
            // 
            // pronametxbx
            // 
            this.pronametxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pronametxbx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pronametxbx.Location = new System.Drawing.Point(181, 114);
            this.pronametxbx.Name = "pronametxbx";
            this.pronametxbx.Size = new System.Drawing.Size(201, 22);
            this.pronametxbx.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "PRODUCT ID";
            // 
            // proidtxbx
            // 
            this.proidtxbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.proidtxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proidtxbx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.proidtxbx.Location = new System.Drawing.Point(181, 70);
            this.proidtxbx.Name = "proidtxbx";
            this.proidtxbx.Size = new System.Drawing.Size(201, 22);
            this.proidtxbx.TabIndex = 11;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.deletebutton.Location = new System.Drawing.Point(213, 234);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(169, 33);
            this.deletebutton.TabIndex = 22;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(902, 256);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // updateproform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 311);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stocktxbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricetxbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pronametxbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proidtxbx);
            this.Controls.Add(this.pictureBox1);
            this.Name = "updateproform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPDATE PRODUCT";
            this.Load += new System.EventHandler(this.updateproform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stocktxbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricetxbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pronametxbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proidtxbx;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}