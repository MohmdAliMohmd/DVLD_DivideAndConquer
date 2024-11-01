﻿using DVLD_DivideAndConquer.Applications.ApplicationTypes;
using DVLD_DivideAndConquer.Drivers;
using DVLD_DivideAndConquer.People;
using DVLD_DivideAndConquer.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.LogIn;

namespace DVLD_DivideAndConquer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogIn());
            //Application.Run(new frmTest());
            //Application.Run(new frmAddEditUser());
            //Application.Run(new frmChangePassword(1));
            Application.Run(new frmPeopleList());
            Application.Run(new frmDriversList());
            Application.Run(new frmApplicationTypesList());
        }
    }
}
