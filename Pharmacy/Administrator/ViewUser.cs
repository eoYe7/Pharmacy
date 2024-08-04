using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Administrator
{
    public partial class ViewUser : UserControl
    {
        function fn = new function();
        String query;
        String CurrentUser="null";
        public ViewUser()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { CurrentUser = value; }
        }
        private void ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
           DataSet ds= fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query="select * from users where username like '"+txtUserName.Text+"%'";//%
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        String username;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              username=guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure!", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (CurrentUser != username)
                {
                    query = "delete from users where username='" + username + "'";
                    fn.setData(query, "user Record Deleted");
                    ViewUser_Load(this,null);
                }
                else
                {
                    MessageBox.Show("You are trying to delete \n Your own Profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            ViewUser_Load(this,null);
        }
    }
}
