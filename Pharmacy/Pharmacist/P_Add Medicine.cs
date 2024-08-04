using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Pharmacist
{
    public partial class P_Add_Medicine : UserControl
    {
        function fn = new function();
        string query;
        public P_Add_Medicine()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMediName.Text !=""&& txtExpireDate.Value!= null&& txtManufacturingDate.Value != null && txtMediID.Text != "" && txtMediNumber.Text != "" && txtPricePerUnit.Text != "" && txtQuantity.Text!= "")
            {
                string mid = txtMediID.Text;
                string mname = txtMediName.Text;
                string mnumber=txtMediNumber.Text;
                DateTime mDate = txtManufacturingDate.Value;
                DateTime eDate= txtExpireDate.Value;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perUnit = Int64.Parse(txtPricePerUnit.Text);
                query = "insert into medicine (mid,mname,mnumber,mDate,eDate,quantity,perUnit)values('"+ mid + "','"+ mname  + "','"+ mnumber + "','"+mDate + "','"+ eDate + "','"+ quantity +"','"+ perUnit+"')";
                fn.setData(query,"Medicine Added to Database");
            }
            else
            {
                MessageBox.Show("Enter all Data","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
          clearAll();
        }
        public void clearAll()
        {
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtMediNumber.Clear();
            txtMediName.Clear();
            txtMediID.Clear();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
        }

        private void P_Add_Medicine_Load(object sender, EventArgs e)
        {

        }

        private void txtExpireDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
