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
    public partial class updateproform : MaterialForm
    {
        public static string path = @"" + Environment.CurrentDirectory + "\\";
        public updateproform()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            productdataform obj = new productdataform();
            obj.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
        private static int indexRow = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow item = dataGridView1.Rows[e.RowIndex];
            proidtxbx.Text = item.Cells[0].Value.ToString();
            pronametxbx.Text = item.Cells[1].Value.ToString();
            stocktxbx.Text = item.Cells[2].Value.ToString();
            pricetxbx.Text = item.Cells[3].Value.ToString();

        }

        private void updateproform_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var lines = File.ReadAllLines("ProductData.txt");
            if (lines.Count() > 0)
            {
                foreach (var CellArray in lines)
                {
                    var cell = CellArray.Split(',');
                    if (cell.Length == dataGridView1.Columns.Count) dataGridView1.Rows.Add(cell);
                }
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            DataGridViewRow item = dataGridView1.Rows[indexRow];
            item.Cells[0].Value = proidtxbx.Text;
            item.Cells[1].Value = pronametxbx.Text;
            item.Cells[2].Value = stocktxbx.Text;
            item.Cells[3].Value = pricetxbx.Text;

            int linecount = 1;
            object[] data = new object[10];
            foreach (string line in File.ReadLines(path + "ProductData.txt"))
            {
                data = line.Split(',');
                if (data[0].Equals(proidtxbx.Text))
                {
                    break;
                }
                else
                {
                    linecount++;
                    continue;
                }
            }
            string[] line_detect = File.ReadAllLines(path + "ProductData.txt");
            string[] line_specific = line_detect[linecount - 1].Split(',');
            File.WriteAllText(path + "ProductData.txt", File.ReadAllText(path + "ProductData.txt").Replace(line_detect[linecount - 1], proidtxbx.Text + "," + pronametxbx.Text + "," + stocktxbx.Text + "," + pricetxbx.Text));
            var rmv_empty_line = File.ReadAllLines(path + "ProductData.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines(path + "ProductData.txt", rmv_empty_line);

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int linecount = 1;
            object[] data = new object[10];
            foreach (string line in File.ReadLines(path + "ProductData.txt"))
            {
                data = line.Split(',');
                if (data[0].Equals(proidtxbx.Text))
                {
                    break;
                }
                else
                {
                    linecount++;
                    continue;
                }
            }
            string[] line_detect = File.ReadAllLines(path + "ProductData.txt");
            string[] line_specific = line_detect[linecount - 1].Split(',');
            File.WriteAllText(path + "ProductData.txt", File.ReadAllText(path + "ProductData.txt").Replace(line_detect[linecount - 1],""));
            var rmv_empty_line = File.ReadAllLines(path + "ProductData.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines(path + "ProductData.txt", rmv_empty_line);
            display();
        }
        public void display()
        {
            dataGridView1.Rows.Clear();
            var lines = File.ReadAllLines("ProductData.txt");
            if (lines.Count() > 0)
            {
                foreach (var CellArray in lines)
                {
                    var cell = CellArray.Split(',');
                    if (cell.Length == dataGridView1.Columns.Count) dataGridView1.Rows.Add(cell);
                }
            }
        }
    }
}
