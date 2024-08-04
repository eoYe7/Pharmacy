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
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void btnSgin_Click(object sender, EventArgs e)
        {
            query = "select * from users";
             ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUser.Text == "root" && txtPass.Text == "root")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username ='" + txtUser.Text + "'and pass='" + txtPass.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {
                        Admin admin = new Admin(txtUser.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacist")
                    {
                        pharmacis pharm = new pharmacis();
                        pharm.Show();
                        this.Hide();
                    }
                    //else if (role == "Customer")
                    //{
                       
                    //}
                }
                else 
                {
                    MessageBox.Show("Worng Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
           


            //if (txtUser.Text=="abdulrazzaq" && txtPass.Text == "pass")
            //{
            //    Admin a = new Admin();
            //    a.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Worng username or paasword","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
