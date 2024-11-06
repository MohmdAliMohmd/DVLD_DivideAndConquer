using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Business;
using System.Windows.Forms;

namespace DVLD_DivideAndConquer.Applications.Local_Driving_License.Controls
{
    public partial class ctrlLocalDrivingLicenseInfo : UserControl
    {
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        int _LocalDrivingLicenseApplicationID = -1;
        int _LicenseID = -1;

        #region
        [Category("Local Driving License Info")]
        public int LocalDrivingLicenseID
        {
            get
            {
                return _LocalDrivingLicenseApplicationID;
            }
        }
        #endregion
        public ctrlLocalDrivingLicenseInfo()
        {
            InitializeComponent();
        }

        void _LoadDefaultValue()
        {
            ctrlApplicationBasicInfo1.LoadDefaultValues();
            llblViewLicenseInfo.Enabled = false;
            lblID.Text = "[????]";
            lblAppliedFor.Text = "[????]";
            lblPassedTests.Text = "0";
        }

        //void _FillLocalDrivingLicenseInfo()
        //{
            
        //    _LicenseID = _LocalDrivingLicenseApplication.
            
            
            

        //}
    }
}
