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
    public partial class P_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public P_SellMedicine()
        {
            InitializeComponent();
        }

       

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicine.Items.Clear();
            query = "select count(mname) from medicine where eDate >= getdate()";
          //  query = "select mname from medicine where eDate >=getdate() and quantity >'0'";
            ds=fn.getData(query);
            for(int i=0; i < ds.Tables[0].Rows.Count;i++)
            {
                listBoxMedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            P_SellMedicine_Load(this,null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicine.Items.Clear ();
            query = "select mname from medicine where mname like '" + txtSearch.Text + "%'and ISDATE(eDate) >= TRY_convert(datetime,getdate())";
         //   query = "select mname from where mname like '" + txtSearch.Text + "%'and eDate >=getdate() and quantity >'0'";
            ds =fn.getData(query);
            for(int i=0;i<ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicine.Items.Add(ds.Tables[0].Rows [i][0].ToString());
            }
        }
    }
}
