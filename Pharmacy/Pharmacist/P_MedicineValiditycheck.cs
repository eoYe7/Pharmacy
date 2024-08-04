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
    public partial class P_MedicineValiditycheck : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        public P_MedicineValiditycheck()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCheck.SelectedIndex == 0)
            {
                query = "select * from medicine where ISDATE(eDate) >= TRY_convert(datetime,getdate())";
                ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLable.Text = "Valid Medicines";
                SetLable.ForeColor = Color.Black;
            }else if(txtCheck.SelectedIndex == 1)
            {
                query = "select * from medicine where ISDATE(eDate) <= TRY_convert(datetime,getdate());";
                ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLable.Text = "Expires Medicines";
                SetLable.ForeColor = Color.Black;
            }else if (txtCheck.SelectedIndex == 2)
            {
                query = "select * from medicine";
                ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                SetLable.Text = "";
                SetLable.ForeColor = Color.Black;
            }

        }


        private void P_MedicineValiditycheck_Load(object sender, EventArgs e)
        {

        }
    }
}
