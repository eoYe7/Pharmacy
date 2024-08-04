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
    public partial class Admin : Form
    {
        string user = "";
        public Admin()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public Admin(String username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;
            viewUser1.ID = ID;
            profile1.ID = ID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
               dashbord1.Visible = true;
            dashbord1.BringToFront();//عند الانتقال الى صفحة المستخدم او غيرة و اريد الرجوع لصفحة الداش فهذا الكود يقوم بهذا العمل //
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dashbord1.Visible = false;
            addUser1.Visible = false;
            viewUser1.Visible = false;
            profile1.Visible = false;
            btnDashbord.PerformClick();// يجعل الداش بورد يظهر تلقائي عندما يتم تسجيل الدخول بدون الضغط على الداش بورد //
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addUser1.Visible=true;
            addUser1.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            viewUser1.Visible=true;
            viewUser1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profile1.Visible=true;
            profile1.BringToFront();
        }

        private void profile1_Load(object sender, EventArgs e)
        {

        }
    }
}
