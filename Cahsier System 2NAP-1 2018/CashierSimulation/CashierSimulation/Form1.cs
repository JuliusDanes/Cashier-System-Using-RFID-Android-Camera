using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CashierSimulation
{
    public partial class Form1 : Form
    {
        public static string path = @"" + Environment.CurrentDirectory + "\\" + "EmployeeData.txt";
        //public static string path = @"C:\Users\Nio\Documents\Visual Studio 2015\Projects\CashierAPP\CashierAPP\bin\Debug\EmployeeData.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close(); ///close form
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 80)
            {
                ///EXPAND
                /// 1. Expand the panel
                /// 2. Show logo

                sideMenu.Visible = false;
                sideMenu.Width = 280;
                PanelAnimatorShow.ShowSync(sideMenu);
                LogoAnimator.ShowSync(icon);
                dgvEmp.Visible = false;
            }
            else
            {
                ///MINIMIZE
                /// 1. Hide the logo
                /// 2. Slide the panel
                LogoAnimator.HideSync(icon);
                sideMenu.Visible = false;
                sideMenu.Width = 80;
                PanelAnimatorHide.ShowSync(sideMenu);
                dgvEmp.Visible = true;
            }
        }

        public static int ActvMenu;

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            ActvMenu = 1; /// 1 => Add Employee
            ucAddUpdateDelEmp.ActiveMenu(ActvMenu);
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            ActvMenu = 2; /// 2 => Update Emfployee
            ucAddUpdateDelEmp.ActiveMenu(ActvMenu);
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            ActvMenu = 3; /// 3 => Delete Employee
            ucAddUpdateDelEmp.ActiveMenu(ActvMenu);
        }

        private void bunifuCustomDataGrid1_VisibleChanged(object sender, EventArgs e)
        {
            dgvEmp.Rows.Clear();
            var lines = File.ReadAllLines(path);
            if (lines.Count() > 0)
            {
                foreach (var CellArray in lines)
                {
                    var cell = CellArray.Split('#');
                    if (cell.Length == dgvEmp.Columns.Count)
                    {
                        dgvEmp.Rows.Add(cell);
                    }
                }
            }
        }
    }
}
