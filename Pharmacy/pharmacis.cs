using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class pharmacis : Form
    {
        public pharmacis()
        {
            InitializeComponent();
        }

       

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            p_Dashboard1.Visible = true;
            p_Dashboard1.BringToFront();
        }

        private void pharmacis_Load(object sender, EventArgs e)
        {
            p_Dashboard1.Visible = false;
            p_Add_Medicine1.Visible = false;
            p_ViewMedicine1.Visible=false;
            p_ModifyMedicine1.Visible = false;
            p_MedicineValiditycheck1.Visible = false;
            p_SellMedicine1.Visible = false;
            btnDashbord.PerformClick();
        }

        private void btnAdMedicine_Click(object sender, EventArgs e)
        {
            p_Add_Medicine1.Visible = true;
            p_Add_Medicine1.BringToFront();
        }

        private void p_Add_Medicine1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            p_ViewMedicine1.Visible = true;
            p_ViewMedicine1.BringToFront();
        }

        private void p_ViewMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            p_ModifyMedicine1.Visible=true;
            p_ModifyMedicine1.BringToFront();
        }

        private void p_ModifyMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void btnMedValidityCheck_Click(object sender, EventArgs e)
        {
            p_MedicineValiditycheck1.Visible=true;
            p_MedicineValiditycheck1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            p_SellMedicine1.Visible = true;
            p_SellMedicine1.BringToFront();
        }

        private void p_SellMedicine1_Load(object sender, EventArgs e)
        {

        }
    }
}
