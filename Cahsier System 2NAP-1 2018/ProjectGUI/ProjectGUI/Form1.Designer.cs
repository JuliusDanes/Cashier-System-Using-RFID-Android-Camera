namespace ProjectGUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.empbutton = new System.Windows.Forms.Button();
            this.probutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.rptbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // empbutton
            // 
            this.empbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.empbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.empbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empbutton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.empbutton.Location = new System.Drawing.Point(19, 157);
            this.empbutton.Name = "empbutton";
            this.empbutton.Size = new System.Drawing.Size(277, 39);
            this.empbutton.TabIndex = 0;
            this.empbutton.Text = "EMPLOYEE DATA";
            this.empbutton.UseVisualStyleBackColor = false;
            this.empbutton.Click += new System.EventHandler(this.empbutton_Click);
            // 
            // probutton
            // 
            this.probutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.probutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.probutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probutton.Location = new System.Drawing.Point(302, 157);
            this.probutton.Name = "probutton";
            this.probutton.Size = new System.Drawing.Size(277, 39);
            this.probutton.TabIndex = 1;
            this.probutton.Text = "PRODUCT DATA";
            this.probutton.UseVisualStyleBackColor = false;
            this.probutton.Click += new System.EventHandler(this.probutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Red;
            this.exitbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.SystemColors.Info;
            this.exitbutton.Location = new System.Drawing.Point(384, 244);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(94, 35);
            this.exitbutton.TabIndex = 13;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_click);
            // 
            // rptbtn
            // 
            this.rptbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rptbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rptbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptbtn.Location = new System.Drawing.Point(585, 157);
            this.rptbtn.Name = "rptbtn";
            this.rptbtn.Size = new System.Drawing.Size(277, 39);
            this.rptbtn.TabIndex = 14;
            this.rptbtn.Text = "REPORT";
            this.rptbtn.UseVisualStyleBackColor = false;
            this.rptbtn.Click += new System.EventHandler(this.rptbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(902, 247);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(884, 311);
            this.Controls.Add(this.rptbtn);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.probutton);
            this.Controls.Add(this.empbutton);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPER SU#";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button empbutton;
        private System.Windows.Forms.Button probutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button rptbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

