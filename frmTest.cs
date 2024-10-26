﻿using DVDL_V0._01.Global_Classes;
using DVLD_DivideAndConquer.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_DivideAndConquer
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.Show();
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(1);
            frm.Show();
        }

        private void txtPersonID_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsTextBoxFilter.txtBoxAcceptOnlyDigits_KeyPress(sender, e);
        }

        private void btnShowPersonInfo_Click(object sender, EventArgs e)
        {
            ctrlPersonCard1.PersonID = Convert.ToInt32(txtPersonID.Text.Trim());
        }
        
        
    }
}
