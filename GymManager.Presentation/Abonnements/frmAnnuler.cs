using GymManager.Business.GymManager.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation.Abonnements
{
    public partial class frmAnnuler : Form
    {
        private int _abonnementID = -1;
        private DataGridViewRow _selectedRow = null;

        public frmAnnuler(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            _selectedRow = selectedRow;
            if (_selectedRow != null && _selectedRow.Cells["AbonnementID"].Value != null)
            {
                _abonnementID = Convert.ToInt32(_selectedRow.Cells["AbonnementID"].Value);
            }
        }

        private void frmAnnuler_Load(object sender, EventArgs e)
        {
            _LoadAbonnementDetails();
        }

        private void _LoadAbonnementDetails()
        {
            if (_selectedRow != null)
            {
                lblIDValue.Text = _selectedRow.Cells["AbonnementID"].Value?.ToString() ?? "N/A";

                if (_selectedRow.DataGridView.Columns.Contains("Adherent"))
                    lblAdherentValue.Text = _selectedRow.Cells["Adherent"].Value?.ToString() ?? "N/A";

                if (_selectedRow.DataGridView.Columns.Contains("Sport"))
                    lblSportValue.Text = _selectedRow.Cells["Sport"].Value?.ToString() ?? "N/A";

                if (_selectedRow.DataGridView.Columns.Contains("Type d'abonnement"))
                    lblTypeValue.Text = _selectedRow.Cells["Type d'abonnement"].Value?.ToString() ?? "N/A";

                if (_selectedRow.DataGridView.Columns.Contains("Début") && _selectedRow.Cells["Début"].Value is DateTime dtDebut)
                    lblDebutValue.Text = dtDebut.ToString("dd/MM/yyyy");

                if (_selectedRow.DataGridView.Columns.Contains("Fin") && _selectedRow.Cells["Fin"].Value is DateTime dtFin)
                    lblFinValue.Text = dtFin.ToString("dd/MM/yyyy");

                if (_selectedRow.DataGridView.Columns.Contains("Prix payé"))
                    lblPrixValue.Text = (_selectedRow.Cells["Prix payé"].Value?.ToString() ?? "0") + " DA";

                if (_selectedRow.DataGridView.Columns.Contains("Séances"))
                {
                    var seancesValue = _selectedRow.Cells["Séances"].Value;

                    if (seancesValue == null || seancesValue == DBNull.Value || string.IsNullOrWhiteSpace(seancesValue.ToString()))
                    {
                        lblSeancesValue.Text = "Illimité";
                    }
                    else
                    {
                        lblSeancesValue.Text = seancesValue.ToString();
                    }
                }
            }
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnulerConfirm_Click(object sender, EventArgs e)
        {
            if (_abonnementID != -1)
            {
                if (clsAbonnement.CancelAbonnement(_abonnementID))
                {
                    MessageBox.Show("L'abonnement a été annulé avec succès.", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Échec de l'annulation de l'abonnement.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
