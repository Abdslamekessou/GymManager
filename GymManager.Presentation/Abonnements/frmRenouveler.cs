using GymManager.Business.GymManager.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation.Abonnements
{
    public partial class frmRenouveler : Form
    {
        private int _abonnementID = -1;
        private DataGridViewRow _selectedRow = null;
        private int _dureeJours = 30; 

        public frmRenouveler(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            _selectedRow = selectedRow;

            if (_selectedRow != null && _selectedRow.Cells["AbonnementID"].Value != null)
            {
                _abonnementID = Convert.ToInt32(_selectedRow.Cells["AbonnementID"].Value);
            }
        }

        private void frmRenouveler_Load(object sender, EventArgs e)
        {
            _LoadDetails();
        }

        private void _LoadDetails()
        {
            if (_selectedRow == null) return;

            lblIDValue.Text = _selectedRow.Cells["AbonnementID"].Value?.ToString() ?? "N/A";

            if (_selectedRow.DataGridView.Columns.Contains("Adherent"))
                lblAdherentValue.Text = _selectedRow.Cells["Adherent"].Value?.ToString() ?? "N/A";

            if (_selectedRow.DataGridView.Columns.Contains("Sport"))
                lblSportValue.Text = _selectedRow.Cells["Sport"].Value?.ToString() ?? "N/A";

            if (_selectedRow.DataGridView.Columns.Contains("Type d'abonnement"))
                lblTypeValue.Text = _selectedRow.Cells["Type d'abonnement"].Value?.ToString() ?? "N/A";


            string dureeStr = _selectedRow.DataGridView.Columns.Contains("Durée")
                ? _selectedRow.Cells["Durée"].Value?.ToString() : "30 j";

            lblDureeValue.Text = string.IsNullOrWhiteSpace(dureeStr) ? "30 j" : dureeStr;


            _dureeJours = _ExtractDaysFromText(dureeStr);

            if (_selectedRow.DataGridView.Columns.Contains("Prix payé"))
            {
                object prixObj = _selectedRow.Cells["Prix payé"].Value;
                if (prixObj != null && decimal.TryParse(prixObj.ToString(), out decimal prix))
                {
                    lblPrixValue.Text = prix.ToString("0.00") + " DA";
                }
            }


            if (_selectedRow.DataGridView.Columns.Contains("Séances"))
            {
                var seancesVal = _selectedRow.Cells["Séances"].Value;
                if (seancesVal == null || seancesVal == DBNull.Value || string.IsNullOrWhiteSpace(seancesVal.ToString()))
                {
                    lblSeancesValue.Text = "Illimité";
                }
                else
                {
                    lblSeancesValue.Text = seancesVal.ToString();
                }
            }

            DateTime nouvelleFin = DateTime.Now.AddDays(_dureeJours);
            lblNouvelleFinValue.Text = nouvelleFin.ToString("dd/MM/yyyy");
        }

        private int _ExtractDaysFromText(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 30;

            Match match = Regex.Match(text, @"\d+");
            if (match.Success && int.TryParse(match.Value, out int days))
            {
                return days;
            }

            return 30;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (_abonnementID != -1)
            {
                if (clsAbonnement.RenewAbonnement(_abonnementID, _dureeJours))
                {
                    MessageBox.Show("L'abonnement a été renouvelé avec succès.", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Échec du renouvellement de l'abonnement.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}