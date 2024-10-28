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

namespace DVLD_DivideAndConquer.User.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        clsUser _User;
        int _UserID = -1;
        #region
        [Category("User Info")]
        public int UserID
        {
            get
            {
                return _UserID;
            }
        }
        #endregion
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        void _LoadDefaultValues()

        {
            txtUsername.Text = "????";
            txtPassword.Text = "????";
            lblIsActive.Text = "????";
            ctrlPersonCard1.LoadDefaultValues();
        }

        void _FillUsuerInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            txtUsername.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            if (_User.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
        }
      public  void LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);
            if(_User == null)
            {
                MessageBox.Show($"No User with UserID: {UserID} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LoadDefaultValues();
                return;
            }
            _FillUsuerInfo();
        }
    }
}
