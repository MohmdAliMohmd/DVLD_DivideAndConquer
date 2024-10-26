namespace DVLD_DivideAndConquer
{
    partial class frmTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.tcTestPersonControls = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new DVLD_DivideAndConquer.People.Controls.ctrlPersonCard();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.btnShowPersonInfo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new DVLD_DivideAndConquer.People.Controls.ctrlPersonCardWithFilter();
            this.tcTestPersonControls.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(31, 15);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(178, 68);
            this.btnAddPerson.TabIndex = 0;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(214, 15);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(178, 68);
            this.btnEditPerson.TabIndex = 1;
            this.btnEditPerson.Text = "Edit Person";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // tcTestPersonControls
            // 
            this.tcTestPersonControls.Controls.Add(this.tabPage1);
            this.tcTestPersonControls.Controls.Add(this.tabPage2);
            this.tcTestPersonControls.Location = new System.Drawing.Point(31, 89);
            this.tcTestPersonControls.Name = "tcTestPersonControls";
            this.tcTestPersonControls.SelectedIndex = 0;
            this.tcTestPersonControls.Size = new System.Drawing.Size(1059, 492);
            this.tcTestPersonControls.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Test Person Card";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ctrlPersonCard1);
            this.groupBox1.Controls.Add(this.txtPersonID);
            this.groupBox1.Controls.Add(this.btnShowPersonInfo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 437);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Person Info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "PersonID: ";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCard1.Location = new System.Drawing.Point(16, 84);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.PersonID = -1;
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1048, 344);
            this.ctrlPersonCard1.TabIndex = 6;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonID.Location = new System.Drawing.Point(329, 33);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(109, 32);
            this.txtPersonID.TabIndex = 5;
            this.txtPersonID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowPersonInfo
            // 
            this.btnShowPersonInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPersonInfo.Location = new System.Drawing.Point(17, 23);
            this.btnShowPersonInfo.Name = "btnShowPersonInfo";
            this.btnShowPersonInfo.Size = new System.Drawing.Size(206, 52);
            this.btnShowPersonInfo.TabIndex = 4;
            this.btnShowPersonInfo.Text = "Show Person info";
            this.btnShowPersonInfo.UseVisualStyleBackColor = true;
            this.btnShowPersonInfo.Click += new System.EventHandler(this.btnShowPersonInfo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TestPerson Card With Filter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.FilterEnable = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(20, 23);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPersonBTN = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(1011, 422);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 689);
            this.Controls.Add(this.tcTestPersonControls);
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.btnAddPerson);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.tcTestPersonControls.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.TabControl tcTestPersonControls;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Button btnShowPersonInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}