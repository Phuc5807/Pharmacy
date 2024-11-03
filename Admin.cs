using Pharmacy.UC_Admin;
using System;
using Wisej.Web;

namespace Pharmacy
{
    public partial class Admin : Form
    {
        UC_Dashboard dashboard = new UC_Dashboard();
        UC_AddUser addUser = new UC_AddUser();
        UC_ViewUser viewUser = new UC_ViewUser();
        UC_UpdateUser updateUser = new UC_UpdateUser();
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            Window1 fm = new Window1();
            fm.Show();
            this.Hide();

        }
        
        private void btnDashboard_Click(object sender, EventArgs e)
        {
           //Show
            panel2.Controls.Add(dashboard);
            dashboard.Show();
            //Hide
            addUser.Hide();
            updateUser.Hide();
            viewUser.Hide();
            

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
          //Show
            panel2.Controls.Add(addUser);
            addUser.Show();
            //Hide
            dashboard.Hide();
            viewUser.Hide();
            updateUser.Hide();
        }

        private void btnViewUser_Click_1(object sender, EventArgs e)
        {
           //Show
            panel2.Controls.Add(viewUser);
            viewUser.Show();
            //Hide
            dashboard.Hide();
            updateUser.Hide();
            addUser.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
          //show
            panel2.Controls.Add(updateUser);
            updateUser.Show();

            //hide
            dashboard.Hide();
            addUser.Hide();
            viewUser.Hide();
        }


    }
}
