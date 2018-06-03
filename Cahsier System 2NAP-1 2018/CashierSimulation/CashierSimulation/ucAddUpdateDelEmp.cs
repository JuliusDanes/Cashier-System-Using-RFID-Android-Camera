using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CashierSimulation
{
    public partial class ucAddUpdateDelEmp : UserControl
    {
        public static string path = @"" + Environment.CurrentDirectory + "\\" + "EmployeeData.txt";
        private static Regex rgxstr = new Regex("^[a-zA-Z ]+$");
        private static Regex rgxint = new Regex("^[0-9]+$");
        private static Regex rgxmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
        private static Regex rgxpass = new Regex("^[A-Za-z0-9 ]+$");
        private static Regex rgxadrs = new Regex("^[a-zA-Z0-9 ,./-]+$");
        private static Regex rgxuname = new Regex("^[A-Za-z0-9]+$");
        private static int ActvMenu = 0;
        private static DateTime now = DateTime.Parse(DateTime.Now.ToShortDateString());

        public ucAddUpdateDelEmp()
        {
            InitializeComponent();
            MS objMS = new MS();
        }

        public partial class MS : MaterialSkin.Controls.MaterialForm
        {
            public MS()
            {
                MaterialSkin.MaterialSkinManager m = MaterialSkin.MaterialSkinManager.Instance;
                m.AddFormToManage(this);
                m.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
                m.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600,
                                    MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green300,
                                    MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            }
        }

        private void ResetData()
        {
            tbxSearch.Text = "Search"; tbxEID.Text = "Employee ID"; tbxName.Text = "Full Name"; switchGender.Value = true; lblGender.Text = "Male";
            tbxPOB.Text = "Place of Birth"; dwnDOB.Value = System.DateTime.Now; lblDOB.Visible = true; dwnPosition.selectedIndex = -1; lblPosition.Visible = true;
            tbxAddress.Text = "Address"; tbxPhoneNum.Text = "Phone Number"; tbxUsername.Text = "Username"; tbxPassword.Text = ""; lblPassword.Visible = true;
            tbxConfirmPassword.Text = ""; lblConfirmPassword.Visible = true; ChkConfirm.Checked = false;
            lblPosition.BackColor = Color.SeaGreen; lblPassword.ForeColor = Color.White; lblConfirmPassword.ForeColor = Color.White;
        }

        public static void ActiveMenu(int ActvMenu_p)
        {
            ActvMenu = ActvMenu_p;
        }

        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "Search")
            {
                tbxSearch.ResetText();
            }
        }

        private void tbxSearch_Leave(object sender, EventArgs e)
        {
            if (tbxSearch.Text.Length == 0)
            {
                tbxSearch.Text = "Search";
            }
        }

        private void tbxName_Enter(object sender, EventArgs e)
        {
            if (tbxName.Text == "Full Name")
            {
                tbxName.ResetText();
            }
        }

        private void tbxName_Leave(object sender, EventArgs e)
        {
            if ((tbxName.Text.Length == 0))
            {
                tbxName.Text = "Full Name";
                MessageBox.Show("Name can not be emptied!");
            }
            else if (!rgxstr.IsMatch(tbxName.Text))
            {
                tbxName.Text = "Full Name";
                MessageBox.Show("Please enter a valid name, can not contain numbers & symbols!");
            }
        }

        private void switchGender_OnValueChange(object sender, EventArgs e)
        {
            if (switchGender.Value == true)
            {
                lblGender.Text = "Male";
            }
            else if (switchGender.Value == false)
            {
                lblGender.Text = "Female";
            }
        }

        private void tbxPOB_Enter(object sender, EventArgs e)
        {
            if (tbxPOB.Text == "Place of Birth")
            {
                tbxPOB.ResetText();
            }
        }

        private void tbxPOB_Leave(object sender, EventArgs e)
        {
            if ((tbxPOB.Text.Length == 0))
            {
                tbxPOB.Text = "Place of Birth";
                MessageBox.Show("Place of birth can not be emptied!");
            }
            else if (!rgxstr.IsMatch(tbxPOB.Text))
            {
                tbxPOB.Text = "Place of Birth";
                MessageBox.Show("Please enter a valid place of birth, can not contain numbers & symbols!");
            }
        }

        private void dwnDOB_onValueChanged(object sender, EventArgs e)
        {
            lblDOB.Visible = false;
        }

        private void dwnDOB_Leave(object sender, EventArgs e)
        {
            lblDOB.Visible = true;
            if (dwnDOB.Value == now)
            {
                MessageBox.Show("Date of birth can not be emptied!");
            }
        }

        private void dwnPosition_onItemSelected(object sender, EventArgs e)
        {
            if (dwnPosition.selectedIndex != -1)
            {
                lblPosition.Visible = false;
            }
        }

        private void dwnPosition_Leave(object sender, EventArgs e)
        {
            if (dwnPosition.selectedIndex == -1)
            {
                MessageBox.Show("Position can not be emptied!");
            }
        }

        private void tbxAddress_Enter(object sender, EventArgs e)
        {
            if (tbxAddress.Text == "Address")
            {
                tbxAddress.ResetText();
            }
        }

        private void tbxAddress_Leave(object sender, EventArgs e)
        {
            if ((tbxAddress.Text.Length == 0))
            {
                tbxAddress.Text = "Address";
                MessageBox.Show("Address can not be emptied!");
            }
            else if (!rgxadrs.IsMatch(tbxAddress.Text))
            {
                tbxAddress.Text = "Address";
                MessageBox.Show("Please enter a valid name, can not contain numbers & symbols!");
            }
        }

        private void tbxPhoneNum_Enter(object sender, EventArgs e)
        {
            if (tbxPhoneNum.Text == "Phone Number")
            {
                tbxPhoneNum.ResetText();
            }
        }

        private void tbxPhoneNum_Leave(object sender, EventArgs e)
        {
            if ((tbxPhoneNum.Text.Length == 0))
            {
                tbxPhoneNum.Text = "Phone Number";
                MessageBox.Show("Phone number can not be emptied!");
            }
            else if ((!rgxint.IsMatch(tbxPhoneNum.Text)) || ((tbxPhoneNum.Text.Length <= 7) || (tbxPhoneNum.Text.Length >= 14)))
            {
                tbxPhoneNum.Text = "Phone Number";
                MessageBox.Show("Please enter a valid phone number (range 8-13 digits), may not contain letters & symbols!");
            }
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "Username")
            {
                tbxUsername.ResetText();
            }
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if ((tbxUsername.Text.Length == 0))
            {
                tbxUsername.Text = "Username";
                MessageBox.Show("Username can not be emptied!");
            }
            else if (!rgxuname.IsMatch(tbxUsername.Text))
            {
                tbxUsername.Text = "Username";
                MessageBox.Show("Please enter a valid username, can not contain symbols!");
            }
            else if (tbxUsername.Text.Length != 0)
            {
                var dbEmp = File.ReadAllLines(path);
                dynamic ary;
                foreach (string data in dbEmp)
                {
                    ary = data.Split('#');
                    if (ary[8].Equals(tbxUsername.Text))
                    {
                        MessageBox.Show("Username already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (lblPassword.Visible == true)
            {
                lblPassword.Visible = false;
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if ((tbxPassword.Text.Length == 0))
            {
                tbxPassword.Text = "";
                lblPassword.Visible = true;
                MessageBox.Show("Password can not be emptied!");
            }
            else if ((!rgxpass.IsMatch(tbxPassword.Text)) || (tbxPassword.Text.Length <= 5))
            {
                tbxPassword.Text = "";
                lblPassword.Visible = true;
                MessageBox.Show("Please enter a combination of at least six numbers, letters, and punctuation marks (e.g.! And &)!");
            }
        }

        private void tbxConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (lblConfirmPassword.Visible == true)
            {
                lblConfirmPassword.Visible = false;
            }
        }

        private void tbxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if ((tbxConfirmPassword.Text.Length == 0))
            {
                tbxConfirmPassword.Text = "";
                lblConfirmPassword.Visible = true;
                MessageBox.Show("Confirm password can not be emptied!");
            }
            else if ((!rgxpass.IsMatch(tbxConfirmPassword.Text)) || (tbxConfirmPassword.Text.Length <= 5))
            {
                tbxConfirmPassword.Text = "";
                lblConfirmPassword.Visible = true;
                MessageBox.Show("Please enter a combination of at least six numbers, letters, and punctuation marks (e.g.! And &)!");
            }
            else if (tbxConfirmPassword.Text != tbxPassword.Text)
            {
                tbxConfirmPassword.Text = "";
                lblConfirmPassword.Visible = true;
                MessageBox.Show("The password does not match!");
            }
        }

        private void lblPassword_MouseDown(object sender, MouseEventArgs e)
        {
            lblPassword.Visible = false;
        }

        private void lblConfirmPassword_MouseDown(object sender, MouseEventArgs e)
        {
            lblConfirmPassword.Visible = false;
        }

        private void btnNextStep1_Click(object sender, EventArgs e)
        {
            tcAddUpdateDelEmp.SelectedIndex = 1;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                bool chk = false;
                ///  1 XOR 2 => Check Validation Rule
                MessageBox.Show("wkwkwkwk 2");
                if ((tbxUsername.Text.Length != 0) && (ActvMenu == 1))
                {
                    var dbEmp = File.ReadAllLines(path);
                    dynamic ary;
                    foreach (string data in dbEmp)
                    {
                        ary = data.Split('#');
                        if (ary[8].Equals(tbxUsername.Text))
                        {
                            MessageBox.Show("Username already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                if ((tbxName.Text.Length == 0) || (tbxName.Text == "Full Name"))
                {
                    MessageBox.Show("Name can not be emptied!");
                }
                else if ((tbxPOB.Text.Length == 0) || (tbxPOB.Text == "Place of Birth"))
                {
                    MessageBox.Show("Place of birth can not be emptied!");
                }
                else if (dwnDOB.Value == now)
                {
                    MessageBox.Show("Date of birth can not be emptied!");
                }
                else if (dwnPosition.selectedIndex == -1)
                {
                    MessageBox.Show("Position can not be emptied!");
                }
                else if ((tbxAddress.Text.Length == 0) || (tbxAddress.Text == "Address"))
                {
                    MessageBox.Show("Address can not be emptied!");
                }
                else if ((tbxPhoneNum.Text.Length == 0) || (tbxPhoneNum.Text == "Phone Number"))
                {
                    MessageBox.Show("Phone number can not be emptied!");
                }
                else if ((tbxUsername.Text.Length == 0) || (tbxUsername.Text == "Username"))
                {
                    MessageBox.Show("Username can not be emptied!");
                }
                else if ((tbxPassword.Text.Length == 0) || (tbxPassword.Text == ""))
                {
                    MessageBox.Show("Password can not be emptied!");
                }
                else if ((tbxConfirmPassword.Text.Length == 0) || (tbxConfirmPassword.Text == ""))
                {
                    MessageBox.Show("Confirm password can not be emptied!");
                }
                else if (ChkConfirm.Checked == false)
                {
                    MessageBox.Show("You must checked!");
                    tcAddUpdateDelEmp.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("True");
                    chk = true;
                }

                if (chk)
                {
                    /// 1 => Add Employee
                    if (ActvMenu == 1)
                    {
                        MessageBox.Show("wkwkwkwk 0");
                        FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(tbxEID.Text.Trim() + "#" + tbxName.Text.Trim() + "#" + lblGender.Text.Trim() + "#" + tbxPOB.Text.Trim() + "#" + dwnDOB.Value.ToShortDateString() +
                                    "#" + dwnPosition.selectedValue.Trim() + "#" + tbxAddress.Text.Trim() + "#" + tbxPhoneNum.Text.Trim() + "#" + tbxUsername.Text.Trim() + "#" + tbxPassword.Text.Trim());
                        sw.Flush();
                        sw.Close();
                        fs.Close();
                        MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetData();
                        tcAddUpdateDelEmp.SelectedIndex = 0;
                        //Display();
                        ActiveMenu(1);

                    }
                    /// 2 => Update Employee
                    else if (ActvMenu == 2)
                    {
                        int linecount = 1;
                        object[] data = new object[10];
                        foreach (string line in File.ReadLines(path))
                        {
                            data = line.Split('#');
                            if (data[0].Equals(tbxEID.Text))
                            {
                                break;
                            }
                            else
                            {
                                linecount++;
                                continue;
                            }
                        }
                        string[] line_detect = File.ReadAllLines(path);
                        string[] line_specific = line_detect[linecount - 1].Split('#');
                        File.WriteAllText(path, File.ReadAllText(path).Replace(line_detect[linecount - 1], tbxEID.Text.Trim() + "#" + tbxName.Text.Trim() + "#" + lblGender.Text.Trim() + "#" + tbxPOB.Text.Trim() + "#" + dwnDOB.Value.ToShortDateString() + "#" + dwnPosition.selectedValue.Trim() + "#" + tbxAddress.Text.Trim() + "#" + tbxPhoneNum.Text.Trim() + "#" + tbxUsername.Text.Trim() + "#" + tbxPassword.Text.Trim()));
                        MessageBox.Show("Data update successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetData();
                        tcAddUpdateDelEmp.SelectedIndex = 0;
                        //Display();
                        ActiveMenu(2);
                    }
                    /// 3 => Delete Employee
                    else if (ActvMenu == 3)
                    {
                        int linecount = 1;
                        object[] data = new object[10];
                        foreach (string line in File.ReadLines(path))
                        {
                            data = line.Split('#');
                            if (data[0].Equals(tbxEID.Text))
                            {
                                break;
                            }
                            else
                            {
                                linecount++;
                                continue;
                            }
                        }
                        string[] line_detect = File.ReadAllLines(path);
                        string[] line_specific = line_detect[linecount - 1].Split('#');
                        File.WriteAllText(path, File.ReadAllText(path).Replace(line_detect[linecount - 1], ""));
                        var rmv_empty_line = File.ReadAllLines(path).Where(arg => !string.IsNullOrWhiteSpace(arg));
                        File.WriteAllLines(path, rmv_empty_line);
                        MessageBox.Show("Data Delete successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetData();
                        tcAddUpdateDelEmp.SelectedIndex = 0;
                        //Display();
                        ActiveMenu(3);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (File.Exists(path))
                    {
                        var dbEmployee = File.ReadAllLines(path);
                        if (dbEmployee.Count() > 0)
                        {
                            dynamic cell = new dynamic[10];
                            foreach (var cellArray in dbEmployee)
                            {
                                cell = cellArray.Split('#');
                                if (cell[0].ToLower().Equals(tbxSearch.Text.ToLower()))
                                {
                                    break;
                                }
                            }

                            if (cell[0].ToLower().Equals(tbxSearch.Text.ToLower()))
                            {
                                /// 1 => Add Employee
                                if (ActvMenu == 1)
                                {
                                    /// Not used for Add Employee
                                }
                                /// 2 => Update Employee
                                else if (ActvMenu == 2)
                                {
                                    tbxSearch.Enabled = true;   /**/ tbxEID.Enabled = false;      /**/ tbxName.Enabled = true;      /**/ switchGender.Enabled = true;       /**/
                                    tbxPOB.Enabled = true;      /**/ dwnDOB.Enabled = true;       /**/ dwnPosition.Enabled = true;  /**/ tbxAddress.Enabled = true;         /**/
                                    tbxPhoneNum.Enabled = true; /**/ tbxUsername.Enabled = false; /**/ tbxPassword.Enabled = true;  /**/ tbxConfirmPassword.Enabled = true; /**/
                                    lblDOB.Visible = false;     /**/ lblPosition.Visible = false; /**/ lblPassword.Visible = false; /**/ lblConfirmPassword.Visible = true; /**/
                                    ChkConfirm.Enabled = true;
                                }
                                /// 3 => Delete Employee
                                else if (ActvMenu == 3)
                                {
                                    tbxConfirmPassword.Enabled = true; /**/ ChkConfirm.Enabled = true;
                                    lblDOB.Visible = false;     /**/ lblPosition.Visible = false; /**/ lblPassword.Visible = false; /**/ lblConfirmPassword.Visible = true; /**/
                                }

                                tbxEID.Text = cell[0];
                                tbxName.Text = cell[1];
                                lblGender.Text = cell[2];
                                if (lblGender.Text == "Male")
                                {
                                    switchGender.Value = true;
                                }
                                else
                                {
                                    switchGender.Value = false;
                                }
                                tbxPOB.Text = cell[3];
                                dwnDOB.Value = DateTime.Parse(cell[4]);
                                dwnPosition.selectedIndex = 0;
                                tbxAddress.Text = cell[6];
                                tbxPhoneNum.Text = cell[7];
                                tbxUsername.Text = cell[8];
                                tbxPassword.Text = cell[9];
                                tbxConfirmPassword.ResetText();
                            }
                            else
                            {
                                MessageBox.Show("Data Not Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActvMenu1_Click(object sender, EventArgs e)
        {
            /// 1 => Add Employee
            ActiveMenu(1);
            ResetData();
            tcAddUpdateDelEmp.SelectedIndex = 0;
            string EID = "";
            if (File.Exists(path))
            {
                var dbEmployee = File.ReadAllLines(path);
                if (dbEmployee.Count() > 0)
                {
                    Array.Reverse(dbEmployee);
                    foreach (string line in dbEmployee)
                    {
                        var data = line.Split('#');
                        EID = Convert.ToString(int.Parse(data[0].Substring(data[0].Length - 4)) + 1);
                        break;
                    }
                    if (int.Parse(EID) < 10)
                    {
                        EID = "E000" + EID;
                    }
                    else if (int.Parse(EID) < 100)
                    {
                        EID = "E00" + EID;
                    }
                    else if (int.Parse(EID) < 1000)
                    {
                        EID = "E0" + EID;
                    }
                    else if (int.Parse(EID) < 10000)
                    {
                        EID = "E" + EID;
                    }
                    else
                    {
                        EID = "Employee ID Full";
                        EID = null;
                    }
                }
            }
            else
            {
                EID = "E0001";
            }
            tbxEID.Text = EID;

            tbxSearch.Enabled = true;  /**/ tbxEID.Enabled = false;     /**/ tbxName.Enabled = true;     /**/ switchGender.Enabled = true;       /**/
            tbxPOB.Enabled = true;      /**/ dwnDOB.Enabled = true;      /**/ dwnPosition.Enabled = true; /**/ tbxAddress.Enabled = true;         /**/
            tbxPhoneNum.Enabled = true; /**/ tbxUsername.Enabled = true; /**/ tbxPassword.Enabled = true; /**/ tbxConfirmPassword.Enabled = true; /**/
            ChkConfirm.Enabled = true;
            btnSaveData.Text = "Add Data";
        }

        private void btnActvMenu2_Click(object sender, EventArgs e)
        {
            /// 2 => Update Employee
            ActiveMenu(2);
            ResetData();
            tcAddUpdateDelEmp.SelectedIndex = 0;
            tbxSearch.Enabled = true;    /**/ tbxEID.Enabled = false;      /**/ tbxName.Enabled = false;     /**/ switchGender.Enabled = false;       /**/
            tbxPOB.Enabled = false;      /**/ dwnDOB.Enabled = false;      /**/ dwnPosition.Enabled = false; /**/ tbxAddress.Enabled = false;         /**/
            tbxPhoneNum.Enabled = false; /**/ tbxUsername.Enabled = false; /**/ tbxPassword.Enabled = false; /**/ tbxConfirmPassword.Enabled = false; /**/
            ChkConfirm.Enabled = false;
            lblPosition.BackColor = Color.FromArgb(128, 128, 128); lblPassword.ForeColor = Color.FromArgb(85, 88, 92); lblConfirmPassword.ForeColor = Color.FromArgb(85, 88, 92);
            btnSaveData.Text = "Update Data";
        }

        private void btnActvMenu3_Click(object sender, EventArgs e)
        {
            /// 3 => Delete Employee
            ActiveMenu(3);
            ResetData();
            tcAddUpdateDelEmp.SelectedIndex = 0;
            tbxSearch.Enabled = true;    /**/ tbxEID.Enabled = false;      /**/ tbxName.Enabled = false;     /**/ switchGender.Enabled = false;      /**/
            tbxPOB.Enabled = false;      /**/ dwnDOB.Enabled = false;      /**/ dwnPosition.Enabled = false; /**/ tbxAddress.Enabled = false;        /**/
            tbxPhoneNum.Enabled = false; /**/ tbxUsername.Enabled = false; /**/ tbxPassword.Enabled = false; /**/ tbxConfirmPassword.Enabled = true; /**/
            ChkConfirm.Enabled = false;
            lblPosition.BackColor = Color.FromArgb(128, 128, 128); lblPassword.ForeColor = Color.FromArgb(85, 88, 92); lblConfirmPassword.ForeColor = Color.FromArgb(85, 88, 92);
            btnSaveData.Text = "Remove Data";
        }

        private void ChkConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkConfirm.Checked == true)
            {
                dynamic chkVal;
                if ((ActvMenu == 1) || (ActvMenu == 2))
                {
                    chkVal = MessageBox.Show("Are you sure the data is correct? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    chkVal = MessageBox.Show("Are you sure you want to delete the employee data " + tbxEID.Text + " [" + tbxName.Text + "] ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }

                if (chkVal.ToString() == "Yes")
                {
                    ChkConfirm.Checked = true;
                }
                else
                {
                    ChkConfirm.Checked = false;
                }
            }
        }
    }
}
