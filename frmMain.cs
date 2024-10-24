using DVDL_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.LogIn;
namespace DVLD_DivideAndConquer
{
    public partial class frmMain : Form
    {
        frmLogIn _LoginForm;
        public frmMain(frmLogIn loginForm)
        {
            InitializeComponent();
            _LoginForm = loginForm; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _LoginForm.Show();
            this.Close();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _LoginForm.Show();
            this.Close();
        }
    }
}
