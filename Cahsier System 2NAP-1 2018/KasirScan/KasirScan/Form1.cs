using MaterialSkin.Controls;
using MaterialSkin;
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

namespace KasirScan
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
            this.materialLabel4.Text = DateTime.Now.ToString();
        }
        public static Random rnd = new Random();
        public string trxid = rnd.Next(100000, 999999).ToString();
        private static string path = "ProductData.txt";
        public static PictureBoxScan frmScan = new PictureBoxScan();
        private void ClearTextBox()
        {
            materialSingleLineTextField1.Clear();
            materialSingleLineTextField2.Clear();
            textBox4.Clear();
            textBox1.Clear();
            materialSingleLineTextField5.Clear();
            textBox2.Clear();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            materialLabel4.Text = DateTime.Now.ToString();
            if (!string.IsNullOrWhiteSpace(frmScan.HasilScan))
            {
                materialSingleLineTextField1.Text = frmScan.HasilScan;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            frmScan.Show();
            
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                ListViewItem item = materialListView1.SelectedItems[0];
                materialSingleLineTextField1.Text = item.SubItems[0].Text;
                materialSingleLineTextField5.Text = item.SubItems[2].Text;
                textBox1.Text = item.SubItems[3].Text;
                textBox2.Text = item.SubItems[4].Text;
                
            }
        }

        private void materialListView1_KeyDown(object sender, KeyEventArgs e)
        {
            {

                if (Keys.Delete == e.KeyCode)
                {
                    foreach (ListViewItem listViewItem in ((ListView)sender).SelectedItems)
                    {
                        listViewItem.Remove();
                    }
                    ClearTextBox();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (materialTabControl1.SelectedIndex == 0)
            {
                if (e.KeyCode == Keys.Up && !string.IsNullOrWhiteSpace(materialSingleLineTextField5.Text))
                {
                    if (Convert.ToInt32(materialSingleLineTextField5.Text) < Convert.ToInt32(textBox4.Text))
                    {
                        materialSingleLineTextField5.Text = (Convert.ToInt32(materialSingleLineTextField5.Text) + 1).ToString();
                    }

                }
                else if (e.KeyCode == Keys.Down && !string.IsNullOrWhiteSpace(materialSingleLineTextField5.Text))
                {
                    materialSingleLineTextField5.Text = (Convert.ToInt32(materialSingleLineTextField5.Text) - 1).ToString();
                    
                    
                }
                else if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(materialSingleLineTextField1.Text) && !string.IsNullOrWhiteSpace(materialSingleLineTextField2.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(materialSingleLineTextField5.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
                {

                    var search = materialListView1.FindItemWithText(materialSingleLineTextField1.Text);
                    if (search != null)
                    {
                        ListViewItem item = materialListView1.Items[Convert.ToInt32(materialListView1.Items.IndexOf(search))];
                        if ((Convert.ToInt32(item.SubItems[2].Text) + Convert.ToInt32(materialSingleLineTextField5.Text)) <= Convert.ToInt32(textBox4.Text))
                        {
                            item.SubItems[2].Text = (Convert.ToInt32(item.SubItems[2].Text) + Convert.ToInt32(materialSingleLineTextField5.Text)).ToString();
                            item.SubItems[4].Text = (Convert.ToInt32(item.SubItems[2].Text) * Convert.ToInt32(item.SubItems[3].Text)).ToString();
                            ClearTextBox();
                            frmScan.textBox1.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Out of stock!");
                        }
                    }
                    else
                    {
                        string[] row = { materialSingleLineTextField1.Text, materialSingleLineTextField2.Text, materialSingleLineTextField5.Text, textBox1.Text, textBox2.Text };
                        var listViewItem = new ListViewItem(row);
                        materialListView1.Items.Add(listViewItem);
                        frmScan.textBox1.Clear();
                        ClearTextBox();
                    }
                }
                else if (e.KeyCode == Keys.U && !string.IsNullOrWhiteSpace(materialSingleLineTextField1.Text) && !string.IsNullOrWhiteSpace(materialSingleLineTextField2.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(materialSingleLineTextField5.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    var search = materialListView1.FindItemWithText(materialSingleLineTextField1.Text);
                    if (search != null)
                    {
                        ListViewItem item = materialListView1.SelectedItems[Convert.ToInt32(materialListView1.Items.IndexOf(search))];
                        item.SubItems[0].Text = materialSingleLineTextField1.Text;
                        item.SubItems[1].Text = materialSingleLineTextField2.Text;
                        item.SubItems[3].Text = textBox1.Text;
                        item.SubItems[2].Text = materialSingleLineTextField5.Text; 
                        item.SubItems[4].Text = textBox2.Text;
                    }
                }

                else if (e.KeyCode == Keys.D1 && e.Alt)
                {
                    materialCheckBox2.Checked = false;
                    materialCheckBox1.Checked = true;
                    comboBox1.SelectedIndex = 0;
                    groupBox4.Visible = true;
                    groupBox2.Visible = false;

                }
                else if (e.KeyCode == Keys.D2 && e.Alt)
                {
                    materialCheckBox1.Checked = false;
                    materialCheckBox2.Checked = true;
                    comboBox1.SelectedIndex = 1;
                    groupBox2.Visible = true;
                    groupBox4.Visible = false;
                }
                else if (e.KeyCode == Keys.F2)
                {
                    if ((!materialCheckBox1.Checked) && (!materialCheckBox2.Checked))
                    {
                        MessageBox.Show("Please choose a payment method");
                    }
                    else
                    {
                        int jumlah = 0;
                        foreach (ListViewItem item in materialListView1.Items)
                        {
                            jumlah += Convert.ToInt32(item.SubItems[4].Text);
                        }
                        textBox3.Text = jumlah.ToString();
                        materialTabControl1.SelectedTab = materialTabControl1.TabPages[1];
                        frmScan.Hide();
                        textBox6.Focus();
                    }
                      
                }
            
            }
            else if(materialTabControl1.SelectedIndex == 1)
            {
                if (e.KeyCode == Keys.F1)
                {
                    materialTabControl1.SelectedTab = materialTabControl1.TabPages[0];
                    frmScan.Show();
                }
                
            }
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            dynamic hasil = new dynamic[5];
            foreach (string file in File.ReadLines(path))
            {
                hasil = file.Split(',');
                if (hasil[0].Equals(materialSingleLineTextField1.Text))
                {
                    break;
                }
            }
            if (hasil[0].Equals(materialSingleLineTextField1.Text))
            {
                if (!string.IsNullOrWhiteSpace(materialSingleLineTextField1.Text))
                {
                    materialSingleLineTextField5.Text = "1";
                    if (!hasil[0].Equals(materialSingleLineTextField1.Text))
                    {
                        MessageBox.Show("Product not found");
                        frmScan.textBox1.Clear();
                        ClearTextBox();
                    }
                    else
                    {
                        materialSingleLineTextField2.Text = hasil[1];
                        textBox4.Text = hasil[2];
                        textBox1.Text = hasil[3];
                        textBox2.Text = hasil[3];
                        materialSingleLineTextField1.Text = hasil[0];
                    }
                }
            }
            else
            {
                frmScan.textBox1.Clear();
                materialSingleLineTextField1.Clear();
                materialSingleLineTextField2.Clear();
                textBox4.Clear();
                textBox1.Clear();
                materialSingleLineTextField5.Clear();
                textBox2.Clear();
            }
        }

        private void materialSingleLineTextField5_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(materialSingleLineTextField5.Text, out a))
            {
                materialSingleLineTextField5.Text = "1";
            }
            else if (Convert.ToInt32(materialSingleLineTextField5.Text) < 1)
            {
                materialSingleLineTextField5.Text = "1";
            }
            else if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(materialSingleLineTextField5.Text))
            {
                textBox2.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(materialSingleLineTextField5.Text)).ToString();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = textBox3.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dynamic hasil = new dynamic[5];
            foreach (string file in File.ReadLines("CardData.txt"))
            {
                hasil = file.Split(',');
                if (hasil[0].Equals(textBox6.Text))
                {
                    break;
                }
            }
            if (hasil[0].Equals(textBox6.Text))
            {
                if (!string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    if (!hasil[0].Equals(textBox6.Text))
                    {
                        MessageBox.Show("Card not found");
                        ClearTextBox();
                    }
                    else
                    {
                        textBox8.Text = hasil[1];
                        textBox7.Text = hasil[2];
                    }
                }
            }
            else
            {
                textBox8.Clear();
                textBox7.Clear();
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                textBox9.Text = (Convert.ToInt32(textBox10.Text) - Convert.ToInt32(textBox5.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please input number only");
                textBox9.Clear();
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox10.Text))
            {
                if ((Convert.ToInt32(textBox10.Text) >= Convert.ToInt32(textBox5.Text)))
                {
                    panel1.Visible = true;
                    label1.Visible = true;
                    label2.Visible = false;
                    materialLabel29.Text = DateTime.Now.ToString();
                    materialLabel25.Text = "TRX"+trxid;
                    materialLabel27.Text = comboBox1.Text;
                    materialLabel23.Text = textBox5.Text;
                    materialLabel28.Text = textBox5.Text;
                    materialLabel26.Text = textBox9.Text;
                    //materialLabel24.Text = "Cashier";
         
                    string a = materialLabel29.Text + "," + materialLabel25.Text + "," + materialLabel27.Text + "," + materialLabel23.Text + "," + materialLabel28.Text + "," + materialLabel26.Text + "," + materialLabel24.Text+",";
                    for (int i = 0; i < materialListView1.Items.Count; i++)
                    {
                        string id = "", qty = "";
                        ListViewItem item = materialListView1.Items[i];
                        id = item.SubItems[0].Text.ToString();
                        qty = item.SubItems[2].Text.ToString();
                        a += id + "@" + qty+ "#";                        
                    }
                    FileStream fs = new FileStream("TRX" + trxid + ".txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.WriteLine(a);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                    DateTime asd = Convert.ToDateTime(materialLabel29.Text);
                    string abcdef = asd.ToShortDateString();
                    fs = new FileStream("TRX-INDEX.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    sw = new StreamWriter(fs);

                    sw.WriteLine(abcdef + "," + materialLabel25.Text + "," + materialLabel27.Text + "," + materialLabel23.Text + "," + materialLabel24.Text);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                    for (int i = 0; i < materialListView1.Items.Count; i++)
                    {
                        string id = "", qty = "";
                        int linecount = 1;
                        ListViewItem item = materialListView1.Items[i];
                        id = item.SubItems[0].Text.ToString();
                        qty = item.SubItems[2].Text.ToString();

                        object[] data = new object[10];
                        foreach (string line in File.ReadLines("ProductData.txt"))
                        {
                            data = line.Split(',');
                            if (data[0].Equals(id))
                            {
                                break;
                            }
                            else
                            {
                                linecount++;
                                continue;
                            }
                        }
                        string[] line_detect = File.ReadAllLines("ProductData.txt");
                        string[] line_specific = line_detect[linecount - 1].Split(',');
                        File.WriteAllText("ProductData.txt", File.ReadAllText("ProductData.txt").Replace(line_detect[linecount - 1], data[0]+","+data[1]+","+ (Convert.ToInt32(data[2]) - Convert.ToInt32(qty))+","+data[3]));
                    }
                }
                else
                {
                    label2.Visible = true;
                    label1.Visible = false;
                    panel1.Visible = false;
                }
            }
            
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            dynamic data = new dynamic[4];
            foreach(string line in File.ReadLines("CardData.txt"))
            {
                data = line.Split(',');
                if(textBox6.Text.Equals(data[0]))
                {
                    break;
                }
            }
            if(textBox6.Text.Equals(data[0]))
            {
                if (!string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    if ((Convert.ToInt32(textBox7.Text) >= Convert.ToInt32(textBox5.Text)) && textBox8.Text.Equals("Active"))
                    {
                        panel1.Visible = true;
                        label1.Visible = true;
                        label2.Visible = false;
                        materialLabel29.Text = DateTime.Now.ToString();
                        materialLabel25.Text = "TRX"+trxid;
                        materialLabel27.Text = comboBox1.Text;
                        materialLabel23.Text = textBox5.Text;
                        materialLabel28.Text = textBox5.Text;
                        materialLabel26.Text = "0";
                        //materialLabel24.Text = "Cashier";
                        string a = materialLabel29.Text + "," + materialLabel25.Text + "," + materialLabel27.Text + "," + materialLabel23.Text + "," + materialLabel28.Text + "," + materialLabel26.Text + "," + materialLabel24.Text + ",";
                        for (int i = 0; i < materialListView1.Items.Count; i++)
                        {
                            string id = "", qty = "";
                            ListViewItem item = materialListView1.Items[i];
                            id = item.SubItems[0].Text.ToString();
                            qty = item.SubItems[2].Text.ToString();
                            a += id + "@" + qty + "#";
                        }
                        FileStream fs = new FileStream("TRX" + trxid + ".txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                        StreamWriter sw = new StreamWriter(fs);

                        sw.WriteLine(a);
                        sw.Flush();
                        sw.Close();
                        fs.Close();
                        DateTime asd = Convert.ToDateTime(materialLabel29.Text);
                        string abcdef = asd.ToShortDateString();
                        fs = new FileStream("TRX-INDEX.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                        sw = new StreamWriter(fs);

                        sw.WriteLine(abcdef + "," + materialLabel25.Text + "," + materialLabel27.Text + "," + materialLabel23.Text + "," + materialLabel24.Text);
                        sw.Flush();
                        sw.Close();
                        fs.Close();
                        for (int i = 0; i < materialListView1.Items.Count; i++)
                        {
                            string id = "", qty = "";
                            int linecount = 1;
                            ListViewItem item = materialListView1.Items[i];
                            id = item.SubItems[0].Text.ToString();
                            qty = item.SubItems[2].Text.ToString();

                            
                            foreach (string line in File.ReadLines("ProductData.txt"))
                            {
                                data = line.Split(',');
                                if (data[0].Equals(id))
                                {
                                    break;
                                }
                                else
                                {
                                    linecount++;
                                    continue;
                                }
                            }
                            string[] line_detect = File.ReadAllLines("ProductData.txt");
                            string[] line_specific = line_detect[linecount - 1].Split(',');
                            File.WriteAllText("ProductData.txt", File.ReadAllText("ProductData.txt").Replace(line_detect[linecount - 1], data[0] + "," + data[1] + "," + (Convert.ToInt32(data[2]) - Convert.ToInt32(qty)) + "," + data[3]));
                        }
                        int baris = 0;
                        dynamic nokartu = new dynamic[4];
                        foreach(string line in File.ReadLines("CardData.txt"))
                        {
                            nokartu = line.Split(',');
                            if(textBox6.Text.Equals(nokartu[0]))
                            {
                                break;
                            }
                            else
                            {
                                baris++;
                            }
                        }
                        if (textBox6.Text.Equals(nokartu[0]))
                        {
                            string[] line_detect = File.ReadAllLines("CardData.txt");
                            string[] line_specific = line_detect[baris].Split(',');
                            File.WriteAllText("CardData.txt", File.ReadAllText("CardData.txt").Replace(line_detect[baris], line_detect[baris].Replace(textBox7.Text, (Convert.ToInt32(textBox7.Text) - Convert.ToInt32(textBox5.Text)).ToString())));
                        }
                    }
                    else
                    {
                        label2.Visible = true;
                        label1.Visible = false;
                        panel1.Visible = false;
                    }
                }
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                materialFlatButton1.PerformClick();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                materialFlatButton2.PerformClick();
            }
        }
        public void InputTransFiltered()
        {
            
            materialListView2.Items.Clear();
            dynamic dataidx = new dynamic[10];
            foreach (string line in File.ReadLines("TRX-INDEX.txt"))
            {
                dataidx = line.Split(',');
                if (materialLabel24.Text.Equals(dataidx[4]))
                {
                    string date1 = dateTimePicker1.Value.ToShortDateString();
                    string date2 = dateTimePicker2.Value.ToShortDateString();
                    if ((Convert.ToDateTime(dataidx[0]) >= Convert.ToDateTime(date1)) && (Convert.ToDateTime(dataidx[0]) <= Convert.ToDateTime(date2)))
                    {
               
                        var listViewItem = new ListViewItem(dataidx);
                        materialListView2.Items.Add(listViewItem);
                        
                    }         
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            InputTransFiltered();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            InputTransFiltered();
        }

        private void materialCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            materialCheckBox4.Checked = false;
            if(materialCheckBox3.Checked)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }

        }

        private void materialCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            materialCheckBox3.Checked = false;
            if (materialCheckBox4.Checked)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                materialListView3.Items.Clear();
                dynamic dataidx = new dynamic[10];
                string[] split1 = new string[10];
                string[] split2 = new string[10];
                foreach (string line in File.ReadLines(textBox11.Text+".txt"))
                {
                    dataidx = line.Split(',');
                    split1 = dataidx[7].Split('#');
                    split1 = split1.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    foreach(string lines in split1)
                    {
                        split2 = lines.Split('@');
                        dynamic cekcekcek = new dynamic[5];
                        foreach(string garis in File.ReadLines("ProductData.txt"))
                        {
                            cekcekcek = garis.Split(',');
                            if(cekcekcek[0].Equals(split2[0]))
                            {
                                break;
                            }
                        }
                        string[] push = new string[4];
                        push[0] = cekcekcek[1];
                        push[1] = split2[1];
                        push[2] = (Convert.ToInt32(split2[1]) * Convert.ToInt32(cekcekcek[3])).ToString();
                        var listViewItem = new ListViewItem(push);
                        materialListView3.Items.Add(listViewItem);
                    }
                    //foreach(string[] produklist in split2)
                    //{
                    //    var listViewItem = new ListViewItem(produklist);
                    //    materialListView3.Items.Add(listViewItem);
                    //}
                }
            }
        }
    }
}
