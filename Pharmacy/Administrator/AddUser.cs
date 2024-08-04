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
    public partial class AddUser : UserControl
    {
        function fn = new function();
        string query;
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string role = txtUserRole.Text;
            string name = txtName.Text;
            string dob= txtDob.Text;
            // int mobile = int.Parse(txtMobileNo.Text);
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try

            {
                query = "insert into users(userRole,name,dob,mobile,email,username,pass)values ('"+role+"','"+name+"','"+dob+"','"+mobile+"','"+email+"','"+username+"' ,'"+password+"')";
                fn.setData(query, "Sign Up Successful");
            }
            catch (Exception )
            {
                MessageBox.Show("Username Allready exist ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clesrAll();
        }
        public void clesrAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtEmail.Clear();
            txtMobileNo.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex=-1;
            txtUsername.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username ='"+txtUsername.Text+"'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\Users\pc\Desktop\Project ERP\Pharmacy\image\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\pc\Desktop\Project ERP\Pharmacy\image\no.png";
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
