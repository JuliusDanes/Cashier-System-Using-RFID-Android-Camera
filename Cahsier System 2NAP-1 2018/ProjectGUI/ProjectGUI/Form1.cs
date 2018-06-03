using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using MaterialSkin;
using MaterialSkin.Controls;
using CashierSimulation;

namespace ProjectGUI
{
    public partial class AdminForm : MaterialForm
    {
        public AdminForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        public CashierSimulation.Form1 frmDanes = new CashierSimulation.Form1();
        private void probutton_Click(object sender, EventArgs e)
        {
            productdataform obj = new productdataform();
            obj.Show();
            this.Close();
        }

        private void exitbutton_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rptbutton_Click(object sender, EventArgs e)
        {
            reportproduct obj = new reportproduct();
            obj.Show();
            this.Close();
        }

        private void empbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDanes.Show();
        }

        private void rptbtn_Click(object sender, EventArgs e)
        {
            reportproduct obj = new reportproduct();
            obj.Show();
            this.Close();
        }
    }
}
