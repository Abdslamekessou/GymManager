using GymManager.Business;
using GymManager.Presentation.Personnes.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation.Members.Controls
{
    public partial class ucMemberCardWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnMemberSelected;

        // Create a protected method to raise the event with a parameter
        protected virtual void MemberSelected(int MemberID)
        {
            Action<int> handler = OnMemberSelected;
            if (handler != null)
            {
                handler(MemberID); // Raise the event with the parameter
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }
        public ucMemberCardWithFilter()
        {
            InitializeComponent();
        }

        private int _MemberID = -1;

        public int MemberID
        {
            get { return ucMemberCard1.MemberID; }
        }

        public clsMember SelectedMemberInfo
        {
            get { return ucMemberCard1.SelectedMemberInfo; }
        }

        public void LoadMemberInfo(int MemberID)
        {

            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = MemberID.ToString();
            FindNow();

        }

        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Membre ID":
                    ucMemberCard1.LoadMemberInfo(int.Parse(txtFilterValue.Text));

                    break;
                default:
                    break;
            }

            if (OnMemberSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnMemberSelected(ucMemberCard1.MemberID);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }

        private void ucMemberCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "Ce champ est obligatoir!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if person id is selected
            if (cbFilterBy.Text == "Membre ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }


    }


}
