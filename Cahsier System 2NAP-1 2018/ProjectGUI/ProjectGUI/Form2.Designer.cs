namespace ProjectGUI
{
    partial class productdataform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productdataform));
            this.srcprobutton = new System.Windows.Forms.Button();
            this.updprobutton = new System.Windows.Forms.Button();
            this.addprobutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // srcprobutton
            // 
            this.srcprobutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.srcprobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srcprobutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcprobutton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.srcprobutton.Location = new System.Drawing.Point(586, 158);
            this.srcprobutton.Name = "srcprobutton";
            this.srcprobutton.Size = new System.Drawing.Size(277, 39);
            this.srcprobutton.TabIndex = 5;
            this.srcprobutton.Text = "SEARCH PRODUCT";
            this.srcprobutton.UseVisualStyleBackColor = false;
            this.srcprobutton.Click += new System.EventHandler(this.srcprobutton_Click);
            // 
            // updprobutton
            // 
            this.updprobutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updprobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updprobutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updprobutton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.updprobutton.Location = new System.Drawing.Point(303, 158);
            this.updprobutton.Name = "updprobutton";
            this.updprobutton.Size = new System.Drawing.Size(277, 39);
            this.updprobutton.TabIndex = 4;
            this.updprobutton.Text = "UPDATE PRODUCT";
            this.updprobutton.UseVisualStyleBackColor = false;
            this.updprobutton.Click += new System.EventHandler(this.updprobutton_Click);
            // 
            // addprobutton
            // 
            this.addprobutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addprobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addprobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addprobutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addprobutton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.addprobutton.Location = new System.Drawing.Point(20, 158);
            this.addprobutton.Name = "addprobutton";
            this.addprobutton.Size = new System.Drawing.Size(277, 39);
            this.addprobutton.TabIndex = 3;
            this.addprobutton.Text = "ADD PRODUCT";
            this.addprobutton.UseVisualStyleBackColor = false;
            this.addprobutton.Click += new System.EventHandler(this.addprobutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Red;
            this.closebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.ForeColor = System.Drawing.SystemColors.Info;
            this.closebutton.Location = new System.Drawing.Point(398, 223);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(94, 35);
            this.closebutton.TabIndex = 11;
            this.closebutton.Text = "CLOSE";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(902, 251);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // productdataform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 311);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.srcprobutton);
            this.Controls.Add(this.updprobutton);
            this.Controls.Add(this.addprobutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "productdataform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCT DATA MENU";
            this.Load += new System.EventHandler(this.productdataform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button srcprobutton;
        private System.Windows.Forms.Button updprobutton;
        private System.Windows.Forms.Button addprobutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}