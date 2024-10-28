using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_DivideAndConquer.User
{
    public partial class frmAddEditUser : Form
    {
        int _UserID = -1;
        clsUser _User;
        enum enMode {AddNew = 1,Update =2}
        enMode _Mode;
        public int UserID
        {
            set
            {
                _UserID = value;
                _User = clsUser.Find(_UserID);
                if (_User != null)
                {
                    //ctrl
                }

            }
            get
            {
                return _UserID;
            }
        }
        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
           
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }

        void _SetTitle()
        {
            lblTitle.Text = (_Mode == enMode.AddNew) ? "Add User" : "Edit User";
        }

        void _LoadDefaultValues()
        {
            _SetTitle();
            tpLogInInfo.Enabled = false;
            btnSave.Enabled = false;
            btnNext.Enabled = false;
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        void _FillUserInfo()
        {
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            txtUsername.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPW.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            
        }

       
       void  _LoadUserIfo()
        {
            _User = clsUser.Find(_UserID);
            if(_User == null)
            {
                MessageBox.Show($"No User with ID : {_UserID}" , "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }
            ctrlPersonCardWithFilter1.FilterEnable = false;
            tpLogInInfo.Enabled = true;
            btnNext.Enabled = true;
            btnSave.Enabled = true;
            _FillUserInfo();
        }

        void _ValidatePassWord()
        {
            if (txtPassword.Text != txtConfirmPW.Text)
            {
                txtConfirmPW.BackColor = Color.Red;
                txtPassword.BackColor = default;
            }
            else
            {
                txtConfirmPW.BackColor = Color.LightGreen;
                txtPassword.BackColor = Color.LightGreen;
            }
        }

        bool _PassWordMatched()
        {
            return (txtPassword.Text == txtConfirmPW.Text);
        }
        bool _ReadyToSave()
        {
            return (txtUsername.Text.Trim() != string.Empty && _PassWordMatched());
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';

                txtConfirmPW.UseSystemPasswordChar = false;
                txtConfirmPW.PasswordChar = '\0';
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;

                txtConfirmPW.UseSystemPasswordChar = false;
            }
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadDefaultValues();
            if (_Mode == enMode.Update)
                _LoadUserIfo();


        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            _ValidatePassWord();
        }

        private void txtConfirmPW_TextChanged(object sender, EventArgs e)
        {
            _ValidatePassWord();
        }
    }
}
