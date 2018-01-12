namespace John_social_club_new
{
    partial class Form1
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbOccupation = new System.Windows.Forms.ComboBox();
            this.cmbHealth = new System.Windows.Forms.ComboBox();
            this.cmbMaritialStatus = new System.Windows.Forms.ComboBox();
            this.lblNoOfChildren = new MaterialSkin.Controls.MaterialLabel();
            this.lblHealth = new MaterialSkin.Controls.MaterialLabel();
            this.lblmaritialStatus = new MaterialSkin.Controls.MaterialLabel();
            this.txtSalary = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnoOofChildren = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSalary = new MaterialSkin.Controls.MaterialLabel();
            this.lblOccupation = new MaterialSkin.Controls.MaterialLabel();
            this.lblDateOfBirth = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchOccupation = new System.Windows.Forms.ComboBox();
            this.cmbOperand = new System.Windows.Forms.ComboBox();
            this.cmbSearchMaritialStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(9, 123);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1338, 613);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnRegister);
            this.tabPage1.Controls.Add(this.dtdateTimePicker1);
            this.tabPage1.Controls.Add(this.cmbOccupation);
            this.tabPage1.Controls.Add(this.cmbHealth);
            this.tabPage1.Controls.Add(this.cmbMaritialStatus);
            this.tabPage1.Controls.Add(this.lblNoOfChildren);
            this.tabPage1.Controls.Add(this.lblHealth);
            this.tabPage1.Controls.Add(this.lblmaritialStatus);
            this.tabPage1.Controls.Add(this.txtSalary);
            this.tabPage1.Controls.Add(this.txtnoOofChildren);
            this.tabPage1.Controls.Add(this.lblSalary);
            this.tabPage1.Controls.Add(this.lblOccupation);
            this.tabPage1.Controls.Add(this.lblDateOfBirth);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register ";
            // 
            // btnRegister
            // 
            this.btnRegister.Depth = 0;
            this.btnRegister.Location = new System.Drawing.Point(666, 265);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Primary = true;
            this.btnRegister.Size = new System.Drawing.Size(145, 45);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "materialRaisedButton1";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dtdateTimePicker1
            // 
            this.dtdateTimePicker1.Location = new System.Drawing.Point(171, 83);
            this.dtdateTimePicker1.Name = "dtdateTimePicker1";
            this.dtdateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dtdateTimePicker1.TabIndex = 14;
            // 
            // cmbOccupation
            // 
            this.cmbOccupation.FormattingEnabled = true;
            this.cmbOccupation.Location = new System.Drawing.Point(171, 141);
            this.cmbOccupation.Name = "cmbOccupation";
            this.cmbOccupation.Size = new System.Drawing.Size(121, 24);
            this.cmbOccupation.TabIndex = 13;
            // 
            // cmbHealth
            // 
            this.cmbHealth.FormattingEnabled = true;
            this.cmbHealth.Location = new System.Drawing.Point(666, 80);
            this.cmbHealth.Name = "cmbHealth";
            this.cmbHealth.Size = new System.Drawing.Size(121, 24);
            this.cmbHealth.TabIndex = 12;
            // 
            // cmbMaritialStatus
            // 
            this.cmbMaritialStatus.FormattingEnabled = true;
            this.cmbMaritialStatus.Location = new System.Drawing.Point(666, 28);
            this.cmbMaritialStatus.Name = "cmbMaritialStatus";
            this.cmbMaritialStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbMaritialStatus.TabIndex = 11;
            // 
            // lblNoOfChildren
            // 
            this.lblNoOfChildren.AutoSize = true;
            this.lblNoOfChildren.Depth = 0;
            this.lblNoOfChildren.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNoOfChildren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoOfChildren.Location = new System.Drawing.Point(481, 139);
            this.lblNoOfChildren.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoOfChildren.Name = "lblNoOfChildren";
            this.lblNoOfChildren.Size = new System.Drawing.Size(136, 24);
            this.lblNoOfChildren.TabIndex = 10;
            this.lblNoOfChildren.Text = "materialLabel7";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Depth = 0;
            this.lblHealth.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHealth.Location = new System.Drawing.Point(481, 82);
            this.lblHealth.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(136, 24);
            this.lblHealth.TabIndex = 9;
            this.lblHealth.Text = "materialLabel6";
            // 
            // lblmaritialStatus
            // 
            this.lblmaritialStatus.AutoSize = true;
            this.lblmaritialStatus.Depth = 0;
            this.lblmaritialStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblmaritialStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblmaritialStatus.Location = new System.Drawing.Point(481, 30);
            this.lblmaritialStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblmaritialStatus.Name = "lblmaritialStatus";
            this.lblmaritialStatus.Size = new System.Drawing.Size(136, 24);
            this.lblmaritialStatus.TabIndex = 8;
            this.lblmaritialStatus.Text = "materialLabel5";
            // 
            // txtSalary
            // 
            this.txtSalary.Depth = 0;
            this.txtSalary.Hint = "";
            this.txtSalary.Location = new System.Drawing.Point(171, 199);
            this.txtSalary.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.Size = new System.Drawing.Size(178, 28);
            this.txtSalary.TabIndex = 7;
            this.txtSalary.Text = "textboxname";
            this.txtSalary.UseSystemPasswordChar = false;
            // 
            // txtnoOofChildren
            // 
            this.txtnoOofChildren.Depth = 0;
            this.txtnoOofChildren.Hint = "";
            this.txtnoOofChildren.Location = new System.Drawing.Point(666, 135);
            this.txtnoOofChildren.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnoOofChildren.Name = "txtnoOofChildren";
            this.txtnoOofChildren.PasswordChar = '\0';
            this.txtnoOofChildren.SelectedText = "";
            this.txtnoOofChildren.SelectionLength = 0;
            this.txtnoOofChildren.SelectionStart = 0;
            this.txtnoOofChildren.Size = new System.Drawing.Size(121, 28);
            this.txtnoOofChildren.TabIndex = 6;
            this.txtnoOofChildren.Text = "textboxname";
            this.txtnoOofChildren.UseSystemPasswordChar = false;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Depth = 0;
            this.lblSalary.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalary.Location = new System.Drawing.Point(7, 203);
            this.lblSalary.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(136, 24);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "materialLabel4";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Depth = 0;
            this.lblOccupation.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOccupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOccupation.Location = new System.Drawing.Point(7, 143);
            this.lblOccupation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(136, 24);
            this.lblOccupation.TabIndex = 3;
            this.lblOccupation.Text = "materialLabel3";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Depth = 0;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDateOfBirth.Location = new System.Drawing.Point(7, 82);
            this.lblDateOfBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(136, 24);
            this.lblDateOfBirth.TabIndex = 2;
            this.lblDateOfBirth.Text = "materialLabel2";
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(171, 26);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(178, 28);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "textboxname";
            this.txtName.UseSystemPasswordChar = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(7, 26);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "materialLabel1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1330, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-8, 65);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1366, 52);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialRaisedButton2);
            this.groupBox1.Controls.Add(this.materialRaisedButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbSearchMaritialStatus);
            this.groupBox1.Controls.Add(this.cmbOperand);
            this.groupBox1.Controls.Add(this.cmbSearchOccupation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1317, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Occupation";
            // 
            // cmbSearchOccupation
            // 
            this.cmbSearchOccupation.FormattingEnabled = true;
            this.cmbSearchOccupation.Location = new System.Drawing.Point(105, 85);
            this.cmbSearchOccupation.Name = "cmbSearchOccupation";
            this.cmbSearchOccupation.Size = new System.Drawing.Size(132, 24);
            this.cmbSearchOccupation.TabIndex = 1;
            // 
            // cmbOperand
            // 
            this.cmbOperand.FormattingEnabled = true;
            this.cmbOperand.Location = new System.Drawing.Point(299, 85);
            this.cmbOperand.Name = "cmbOperand";
            this.cmbOperand.Size = new System.Drawing.Size(60, 24);
            this.cmbOperand.TabIndex = 2;
            // 
            // cmbSearchMaritialStatus
            // 
            this.cmbSearchMaritialStatus.FormattingEnabled = true;
            this.cmbSearchMaritialStatus.Location = new System.Drawing.Point(422, 84);
            this.cmbSearchMaritialStatus.Name = "cmbSearchMaritialStatus";
            this.cmbSearchMaritialStatus.Size = new System.Drawing.Size(223, 24);
            this.cmbSearchMaritialStatus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maritial Status";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(683, 75);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(136, 34);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Search";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(883, 75);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(108, 33);
            this.materialRaisedButton2.TabIndex = 6;
            this.materialRaisedButton2.Text = "Refresh";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 764);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegister;
        private System.Windows.Forms.DateTimePicker dtdateTimePicker1;
        private System.Windows.Forms.ComboBox cmbOccupation;
        private System.Windows.Forms.ComboBox cmbHealth;
        private System.Windows.Forms.ComboBox cmbMaritialStatus;
        private MaterialSkin.Controls.MaterialLabel lblNoOfChildren;
        private MaterialSkin.Controls.MaterialLabel lblHealth;
        private MaterialSkin.Controls.MaterialLabel lblmaritialStatus;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSalary;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnoOofChildren;
        private MaterialSkin.Controls.MaterialLabel lblSalary;
        private MaterialSkin.Controls.MaterialLabel lblOccupation;
        private MaterialSkin.Controls.MaterialLabel lblDateOfBirth;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearchMaritialStatus;
        private System.Windows.Forms.ComboBox cmbOperand;
        private System.Windows.Forms.ComboBox cmbSearchOccupation;
    }
}

