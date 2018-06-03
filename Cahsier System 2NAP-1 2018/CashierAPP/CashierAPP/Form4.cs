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
using MaterialSkin.Controls;
using MaterialSkin;

namespace ProjectGUI
{
    public partial class searchproform : MaterialForm
    {
        public searchproform()
        {
            InitializeComponent();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            productdataform obj = new productdataform();
            obj.Show();
        }

        private void searchproform_Load(object sender, EventArgs e)
        {

        }

        private void proidtxbx_TextChanged(object sender, EventArgs e)
        {
            dynamic hasil = new dynamic[5];
            foreach (string file in File.ReadLines("ProductData.txt"))
            {
                hasil = file.Split(',');
                if (hasil[0].Equals(proidtxbx.Text))
                {
                    break;
                }
            }
            if (hasil[0].Equals(proidtxbx.Text))
            {
                if (!string.IsNullOrWhiteSpace(proidtxbx.Text))
                {
                    DataGridViewRow item = dataGridView1.Rows[0];
                    item.Cells[0].Value = hasil[0];
                    item.Cells[1].Value = hasil[1];
                    item.Cells[2].Value = hasil[2];
                    item.Cells[3].Value = hasil[3];


                }
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }
    }
}
