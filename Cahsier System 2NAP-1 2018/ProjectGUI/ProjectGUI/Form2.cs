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
using MaterialSkin.Controls;
using MaterialSkin;

namespace ProjectGUI
{
    public partial class productdataform : MaterialForm
    {
        public productdataform()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void addprobutton_Click(object sender, EventArgs e)
        {
            addproform obj = new addproform();
            obj.Show();
            this.Hide();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm obj = new AdminForm();
            obj.Show();

        }

        private void updprobutton_Click(object sender, EventArgs e)
        {
            updateproform obj = new updateproform();
            obj.Show();
            this.Hide();
        }

        private void srcprobutton_Click(object sender, EventArgs e)
        {
            searchproform obj = new searchproform();
            obj.Show();
            this.Hide();
        }

        private void productdataform_Load(object sender, EventArgs e)
        {

        }
    }
}
