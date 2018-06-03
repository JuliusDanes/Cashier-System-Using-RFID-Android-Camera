using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ProjectGUI;
using KasirScan;
using System.IO;

namespace CashierAPP
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public ProjectGUI.AdminForm frmAji = new ProjectGUI.AdminForm();
        public KasirScan.Form1 frmAdi = new KasirScan.Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            dynamic liness = new dynamic[10];
            foreach (string line in File.ReadLines("EmployeeData.txt"))
            {
                liness = line.Split('#');
                if ((liness[8].Equals(textBox1.Text)) && (liness[9].Equals(textBox2.Text)))
                {
                    break;
                }
            }
            if ((liness[8].Equals(textBox1.Text)) && (liness[9].Equals(textBox2.Text)))
            {
                MessageBox.Show("Login success!");
                this.Hide();
                frmAdi.materialLabel30.Text = "Login as " + textBox1.Text;
                frmAdi.materialLabel24.Text = textBox1.Text;
                frmAdi.Show();
            }
            else if ((textBox1.Text == "superadmin") && (textBox2.Text == "superadmin"))
            {
                MessageBox.Show("Login success!");
                this.Hide();
                frmAji.Show();
            }
            else
            {
                MessageBox.Show("Login fail!");
            }
            
            
            
        }


        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
