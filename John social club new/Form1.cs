using John_Social_Club_Data.Enums;
using System;
using John_Social_Club_Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using John_social_club_new.Properties;
using John_Social_Club_Data.Data_Model;
using John_Social_Club_Data.DataLayer;

namespace John_social_club_new
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }
      
          private  ClubMemberAccess clubmemberaccess=new ClubMemberAccess();     
  
           private void InitializeResourceString()
        {
            lblName.Text = Resource.lblName;
            lblDateOfBirth.Text = Resource.lblDob;
            lblHealth.Text = Resource.lblHealthstatus;
            lblOccupation.Text = Resource.lblOccupation;
            lblmaritialStatus.Text = Resource.lblMaritalstatus;
            lblSalary.Text = Resource.lblSalary;
            lblNoOfChildren.Text = Resource.lblNoOfChildren;
            btnRegister.Text = Resource.btnRegister;
        }

        private void InitializeDropdown()
        {
            cmbHealth.DataSource = Enum.GetValues(typeof(Health));
            cmbMaritialStatus.DataSource = Enum.GetValues(typeof(MaritialStatus));
            cmbOccupation.DataSource = Enum.GetValues(typeof(Occupation));
        }

        private void ResetAll()
        {
            txtName.Text = string.Empty;
            txtnoOofChildren.Text = string.Empty;
            txtSalary.Text = string.Empty;
            cmbHealth.SelectedIndex = -1;
            cmbMaritialStatus.SelectedIndex = -1;
            cmbOccupation.SelectedIndex = -1;
        }
        private bool Validation()
        {
            if (txtName.Text.Trim() == "" || cmbHealth.SelectedIndex == -1 || cmbMaritialStatus.SelectedIndex == -1 || cmbOccupation.SelectedIndex == -1)
            {
                MessageBox.Show("enter All Fields");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitializeResourceString();
            this.InitializeDropdown();
            this.ResetAll();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try {
                if (this.Validation())
                {
                    ClubMemberModel clubmember = new ClubMemberModel()
                    {
                        Id = 0,
                        Name = txtName.Text.Trim(),
                        DateOfBirth = dtdateTimePicker1.Value,
                        Occupation = (Occupation)cmbOccupation.SelectedValue,
                        Healthstatus = (Health)cmbHealth.SelectedValue,
                        MaritialStatus = (MaritialStatus)cmbMaritialStatus.SelectedValue,
                        NumberOfchildren = txtnoOofChildren.Text.Trim() == string.Empty ? 0 : Convert.ToInt16(txtnoOofChildren.Text),
                        Salary = txtSalary.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtSalary.Text)
                    };

                    var Succes = this.clubmemberaccess.AddMember(clubmember);
                    if (Succes != "0")
                    {
                        MessageBox.Show("Ädded");
                        this.ResetAll();
                    }
                    else
                    {
                        MessageBox.Show(Succes);
                    }
                 
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
