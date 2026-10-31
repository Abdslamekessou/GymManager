
using GymManager.Business;
using GymManager.Presentation.Types_d_abonnements;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GymManager.Presentation
{
    public partial class ucListTypesAbonnements : UserControl
    {
        private DataTable _dtAllTypesAbonnement;

        public ucListTypesAbonnements()
        {
            InitializeComponent();
        }

        private void ucListTypesAbonnements_Load(object sender, EventArgs e)
        {
            _LoadTypesAbonnements();
        }

        private void _LoadTypesAbonnements()
        {
            _dtAllTypesAbonnement = clsTypeAbonnement.GetAllTypesDabonnements();

            dgvListTypeAbonnement.DataSource = _dtAllTypesAbonnement;

            // Initialize search and status filters
            if (cbFilter.Items.Count > 0)
                cbFilter.SelectedIndex = 0;

            if (cbRechercher.Items.Count > 0)
                cbRechercher.SelectedIndex = 0;

            // Configure columns
            if (dgvListTypeAbonnement.Columns.Count > 0)
            {
                dgvListTypeAbonnement.Columns[0].HeaderText = "ID";
                dgvListTypeAbonnement.Columns[0].Width = 60;

                dgvListTypeAbonnement.Columns[1].HeaderText = "Nom";
                dgvListTypeAbonnement.Columns[1].Width = 320;

                dgvListTypeAbonnement.Columns[2].HeaderText = "Sport";
                dgvListTypeAbonnement.Columns[2].Width = 180;

                dgvListTypeAbonnement.Columns[3].HeaderText = "Durée (jours)";
                dgvListTypeAbonnement.Columns[3].Width = 105;

                dgvListTypeAbonnement.Columns[4].HeaderText = "Prix";
                dgvListTypeAbonnement.Columns[4].Width = 145;

                dgvListTypeAbonnement.Columns[5].HeaderText = "Séances";
                dgvListTypeAbonnement.Columns[5].Width = 135;

                dgvListTypeAbonnement.Columns[6].HeaderText = "Statut";
                dgvListTypeAbonnement.Columns[6].Width = 155;
            }

            _ApplyFilter();
        }

        // Centralized filtering method
        private void _ApplyFilter()
        {
            if (_dtAllTypesAbonnement == null)
                return;

            // Search mode
            if (cbRechercher.Text!="Statut")
            {
                string filterColumn = "";

                switch (cbRechercher.Text)
                {
                    case "Nom du type d'abonnement":
                        filterColumn = "Nom";
                        break;

                    case "ID Type d'abonnement":
                        filterColumn = "ID";
                        break;
                }

                // No search value: show all records
                if (string.IsNullOrWhiteSpace(txtValeur.Text))
                {
                    _dtAllTypesAbonnement.DefaultView.RowFilter = "";
                    return;
                }

                if (filterColumn == "ID")
                {
                    if (int.TryParse(txtValeur.Text.Trim(), out int id))
                    {
                        _dtAllTypesAbonnement.DefaultView.RowFilter =
                            string.Format("[{0}] = {1}", filterColumn, id);
                    }
                    else
                    {
                        _dtAllTypesAbonnement.DefaultView.RowFilter = "[ID] = -1";
                    }
                }
                else if (filterColumn == "Nom")
                {
                    string safeSearchText = txtValeur.Text.Trim()
                        .Replace("'", "''");

                    _dtAllTypesAbonnement.DefaultView.RowFilter =
                        string.Format(
                            "[{0}] LIKE '{1}%'",
                            filterColumn,
                            safeSearchText);
                }
            }
            // Status filter mode
            else
            {
                if (cbFilter.Text == "Actif")
                {
                    _dtAllTypesAbonnement.DefaultView.RowFilter =
                        "[Statut] = 'Actif'";
                }
                else if (cbFilter.Text == "InActif")
                {
                    _dtAllTypesAbonnement.DefaultView.RowFilter =
                        "[Statut] = 'InActif'";
                }
                else
                {
                    _dtAllTypesAbonnement.DefaultView.RowFilter = "";
                }
            }
        }

        private void btnAjouterType_Click(object sender, EventArgs e)
        {
            frmAddUpdateTypeAbonnement frm =
                new frmAddUpdateTypeAbonnement();

            frm.ShowDialog();

            _LoadTypesAbonnements();
        }

        private void voirLesDetailsToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            if (dgvListTypeAbonnement.CurrentRow != null)
            {
                int selectedID = Convert.ToInt32(
                    dgvListTypeAbonnement.CurrentRow.Cells[0].Value);

                frmDetailsTypeAbonnement frmDetails =
                    new frmDetailsTypeAbonnement(selectedID);

                frmDetails.ShowDialog();

                _LoadTypesAbonnements();
            }
        }

        private void modifierToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            if (dgvListTypeAbonnement.CurrentRow != null)
            {
                int selectedID = Convert.ToInt32(
                    dgvListTypeAbonnement.CurrentRow.Cells[0].Value);

                frmAddUpdateTypeAbonnement frm =
                    new frmAddUpdateTypeAbonnement(selectedID);

                frm.ShowDialog();

                _LoadTypesAbonnements();
            }
        }

        private void désactiverToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            if (dgvListTypeAbonnement.CurrentRow == null)
                return;

            if (MessageBox.Show(
                "Êtes-vous sûr de vouloir désactiver ce type d'abonnement",
                "Confirmation de désactivation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                int selectedID = Convert.ToInt32(
                    dgvListTypeAbonnement.CurrentRow.Cells[0].Value);

                if (clsTypeAbonnement.DeactivateTypeAbonnement(selectedID))
                {
                    MessageBox.Show(
                        "Le type d'abonnement a été désactivé avec succès.",
                        "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "L'opération a échoué.",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                _LoadTypesAbonnements();
            }
        }

        // Search criteria changed
        private void cbRechercher_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            txtValeur.Text = "";

            if (cbRechercher.Text == "Statut")
            {
                txtValeur.Enabled = false;
                txtValeur.Visible = false;
                cbFilter.Enabled = true;
                cbFilter.Visible = true;
            }
            else
            {
                txtValeur.Enabled = true;
                txtValeur.Visible = true;

                cbFilter.Enabled = false;
                cbFilter.Visible = false;
                txtValeur.Focus();
            }

            _ApplyFilter();
        }

        // Automatically search while typing
        private void txtValeur_TextChanged(
            object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        // Allow only digits when searching by ID
        private void txtValeur_KeyPress(
            object sender, KeyPressEventArgs e)
        {
            if (cbRechercher.Text == "ID Type d'abonnement")
            {
                e.Handled =
                    !char.IsDigit(e.KeyChar) &&
                    !char.IsControl(e.KeyChar);
            }
        }

        // Status filter changed
        private void cbFilter_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void activerToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            if (dgvListTypeAbonnement.CurrentRow == null)
                return;

            if (MessageBox.Show(
                "Êtes-vous sûr de vouloir activer ce type d'abonnement ?",
                "Confirmation d'activation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                int selectedID = Convert.ToInt32(
                    dgvListTypeAbonnement.CurrentRow.Cells[0].Value);

                if (clsTypeAbonnement.ActivateTypeAbonnement(selectedID))
                {
                    MessageBox.Show(
                        "Le type d'abonnement a été activé avec succès.",
                        "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "L'opération a échoué.",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                _LoadTypesAbonnements();
            }
        }
    }
}
