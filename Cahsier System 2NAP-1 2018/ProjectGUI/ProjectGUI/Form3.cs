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
    public partial class addproform : MaterialForm
    {
        Regex rgxint = new Regex("^[0-9]+$");
        public addproform()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void display()
        {
            DGVProduct.Rows.Clear();
            var lines = File.ReadAllLines("ProductData.txt");
            if (lines.Count() > 0)
            {
                foreach (var CellArray in lines)
                {
                    var cell = CellArray.Split(',');
                    if (cell.Length == DGVProduct.Columns.Count) DGVProduct.Rows.Add(cell);
                }
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string[] ary = new string[5];
            var dbProd = File.ReadAllLines("ProductData.txt");
            foreach (string data in dbProd)
            {
                ary = data.Split(',');
                if (ary[0].Equals(proidtxbx.Text))
                {
                    MessageBox.Show("Product ID already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            if (!ary[0].Equals(proidtxbx.Text))
            {
                if ((proidtxbx.Text.Length == 0) || (pronametxbx.Text.Length == 0) || (pricetxbx.Text.Length == 0) || (stocktxbx.Text.Length == 0))
                {
                    MessageBox.Show("Invalid Product, Please Enter Valid Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if ((!rgxint.IsMatch(pricetxbx.Text)) || (!rgxint.IsMatch(stocktxbx.Text)) || (!rgxint.IsMatch(proidtxbx.Text)))
                {
                    MessageBox.Show("Invalid Price and Stock, Please Enter Valid Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!Convert.ToBoolean(proidtxbx.Text.Length == 10))
                {
                    MessageBox.Show("Product ID Only 10 Digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    try
                    {
                        FileStream fs = new FileStream("ProductData.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                        StreamWriter sw = new StreamWriter(fs);

                        sw.WriteLine(proidtxbx.Text.Trim() + "," + pronametxbx.Text.Trim() + "," + stocktxbx.Text.Trim() + "," + pricetxbx.Text.Trim());
                        sw.Flush();
                        sw.Close();
                        fs.Close();
                        MessageBox.Show("Data Saved successfuly!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        display();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
            display();
              
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            productdataform obj = new productdataform();
            obj.Show();
        }

        private void addproform_Load(object sender, EventArgs e)
        {
            display();
        }
    }
}
