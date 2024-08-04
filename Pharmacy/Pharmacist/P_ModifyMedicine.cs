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
    public partial class P_ModifyMedicine : UserControl
    {
        function fn = new function();
        String query;
        public P_ModifyMedicine()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMediID.Text != "")
            {
                query = "select * from medicine where mid ='"+txtMediID.Text+"' ";
                DataSet ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicineName.Text=ds.Tables[0].Rows[0][2].ToString();
                    txtMedicineNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with ID:"+txtMediID.Text+"exitst", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
              clearAll();
            }
          
        }
        private void clearAll()
        {
            txtMediID.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtMDate.ResetText();
            txtEDate.ResetText();
            txtAvailableQuantity.Clear();
            txtPricePerUnit.Clear();
            if(txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mname=txtMedicineName.Text;
            string mnumber = txtMedicineNumber.Text;
            DateTime mdate = txtMDate.Value;
            DateTime edate = txtEDate.Value;
            Int64 quantity = Int64.Parse(txtAvailableQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtPricePerUnit.Text);
            totalQuantity = quantity +addQuantity;
                                                                       //mid,mname,mnumber,mDate,eDate,quantity,perUnit;
            query = "update medicine set mname ='" + mname+"',mnumber='"+mnumber+"',mDate='"+mdate+"',eDate='"+edate+"',quantity="+ totalQuantity + ",perUnit ="+ unitprice + " where mid ='"+txtMediID.Text+"'";
            fn.setData(query, "Medicine Details Updated");
        }

        private void P_ModifyMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
