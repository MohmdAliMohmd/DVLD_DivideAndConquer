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
    }
}
