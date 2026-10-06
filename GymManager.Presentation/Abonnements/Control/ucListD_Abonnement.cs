using GymManager.Business;
using GymManager.Business.GymManager.Business;
using System;
using System.Collections;
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
    public partial class ucListD_Abonnement : UserControl
    {
        private DataTable _dtListAbonnement;

        public ucListD_Abonnement()
        {
            InitializeComponent();
        }

        private void ucListD_Abonnement_Load(object sender, EventArgs e)
        {
            dgvAbonnements.CellFormatting -= dgvAbonnements_CellFormatting;
            dgvAbonnements.CellFormatting += dgvAbonnements_CellFormatting;

            _LoadAbonnementsData();
        }

        private void _LoadAbonnementsData()
        {
            _dtListAbonnement = clsAbonnement.GetAllAbonnements();
            dgvAbonnements.DataSource = _dtListAbonnement;

            if (cbRechercherPar != null && cbRechercherPar.Items.Count > 0)
                cbRechercherPar.SelectedIndex = 0;

            if (cbFilterStatut != null && cbFilterStatut.Items.Count > 0)
                cbFilterStatut.SelectedIndex = 0;

            _FormatDataGridViewColumns();
        }

        private void _FormatDataGridViewColumns()
        {
            if (dgvAbonnements.Columns.Count == 0) return;


            if (dgvAbonnements.Columns.Contains("AbonnementID"))
            {
                dgvAbonnements.Columns["AbonnementID"].HeaderText = "ID";
                dgvAbonnements.Columns["AbonnementID"].Width = 50;
            }


            if (dgvAbonnements.Columns.Contains("Adherent"))
            {
                dgvAbonnements.Columns["Adherent"].HeaderText = "Adhérent";
                dgvAbonnements.Columns["Adherent"].Width = 130;
            }

            if (dgvAbonnements.Columns.Contains("Sport"))
            {
                dgvAbonnements.Columns["Sport"].HeaderText = "Sport";
                dgvAbonnements.Columns["Sport"].Width = 100;
            }

            if (dgvAbonnements.Columns.Contains("Type d'abonnement"))
            {
                dgvAbonnements.Columns["Type d'abonnement"].HeaderText = "Type d'abonnement";
                dgvAbonnements.Columns["Type d'abonnement"].Width = 160;
            }

            if (dgvAbonnements.Columns.Contains("Début"))
            {
                dgvAbonnements.Columns["Début"].HeaderText = "Début";
                dgvAbonnements.Columns["Début"].Width = 90;
                dgvAbonnements.Columns["Début"].DefaultCellStyle.Format = "dd/MM/yy";
            }

            if (dgvAbonnements.Columns.Contains("Fin"))
            {
                dgvAbonnements.Columns["Fin"].HeaderText = "Fin";
                dgvAbonnements.Columns["Fin"].Width = 90;
                dgvAbonnements.Columns["Fin"].DefaultCellStyle.Format = "dd/MM/yy";
            }

            if (dgvAbonnements.Columns.Contains("Prix payé"))
            {
                dgvAbonnements.Columns["Prix payé"].HeaderText = "Prix payé";
                dgvAbonnements.Columns["Prix payé"].Width = 90;
            }

            if (dgvAbonnements.Columns.Contains("Durée"))
            {
                dgvAbonnements.Columns["Durée"].HeaderText = "Durée";
                dgvAbonnements.Columns["Durée"].Width = 70;
            }

            if (dgvAbonnements.Columns.Contains("Séances"))
            {
                dgvAbonnements.Columns["Séances"].HeaderText = "Séances";
                dgvAbonnements.Columns["Séances"].Width = 70;
            }

            if (dgvAbonnements.Columns.Contains("Statut"))
            {
                dgvAbonnements.Columns["Statut"].HeaderText = "Statut";
                dgvAbonnements.Columns["Statut"].Width = 80;
            }
        }

        private void dgvAbonnements_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            string colName = dgvAbonnements.Columns[e.ColumnIndex].Name;

            if (colName == "Prix payé" && e.Value != DBNull.Value)
            {
                e.Value = string.Format("{0} DA", Convert.ToDecimal(e.Value).ToString("0.##"));
                e.FormattingApplied = true;
            }
            else if (colName == "Durée" && e.Value != DBNull.Value)
            {
                e.Value = string.Format("{0} j", e.Value);
                e.FormattingApplied = true;
            }
            else if (colName == "Séances")
            {
                if (e.Value == DBNull.Value)
                {
                    e.Value = "Illimité";
                    e.FormattingApplied = true;
                }
            }
        }


        private void _ApplyFilter()
        {
            if (_dtListAbonnement == null) return;

            List<string> filters = new List<string>();

            if (!string.IsNullOrWhiteSpace(txtValeur.Text))
            {
                string filterColumn = "";

                switch (cbRechercherPar.Text)
                {
                    case "Nom du membre":
                    case "Adhérent":
                        filterColumn = "Adherent";
                        break;

                    case "ID":
                    case "AbonnementID":
                        filterColumn = "AbonnementID";
                        break;
                }

                if (!string.IsNullOrEmpty(filterColumn))
                {
                    if (filterColumn == "AbonnementID")
                    {
                        if (int.TryParse(txtValeur.Text.Trim(), out int id))
                        {
                            filters.Add(string.Format("[{0}] = {1}", filterColumn, id));
                        }
                    }
                    else
                    {
                        string safeSearchText = txtValeur.Text.Trim().Replace("'", "''");
                        filters.Add(string.Format("[{0}] LIKE '{1}%'", filterColumn, safeSearchText));
                    }
                }
            }

            // 2. شرط حالة الاشتراك (إذا لم تكن "Tous" أو فارغة)
            if (cbFilterStatut != null && cbFilterStatut.Text != "Tous" && !string.IsNullOrEmpty(cbFilterStatut.Text))
            {
                filters.Add(string.Format("[Statut] = '{0}'", cbFilterStatut.Text));
            }

            // 3. دمج الشروط باستخدام AND وتطبيقها على الداتا فيو
            if (filters.Count > 0)
            {
                _dtListAbonnement.DefaultView.RowFilter = string.Join(" AND ", filters);
            }
            else
            {
                _dtListAbonnement.DefaultView.RowFilter = "";
            }
        }

        private void cbRechercherPar_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            txtValeur.Text = "";
            txtValeur.Focus();

            if (_dtListAbonnement != null)
                _dtListAbonnement.DefaultView.RowFilter = "";
        }

        private void btnRechercher_Click_1(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cbFilterStatut_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void txtValeur_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValeur.Text) && _dtListAbonnement != null)
                _dtListAbonnement.DefaultView.RowFilter = "";
        }

        private void txtValeur_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbRechercherPar.Text == "ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void btnAjouterAbonnement_Click(object sender, EventArgs e)
        {
            //frmTest frm = new frmTest();
            //frm.ShowDialog();
            //_LoadAbonnementsData();
        }


        private void tsmiAnnuler_Click_1(object sender, EventArgs e)
        {
            if (dgvAbonnements.CurrentRow != null)
            {
                frmAnnuler frm = new frmAnnuler(dgvAbonnements.CurrentRow);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _LoadAbonnementsData();
                }
            }
        }

        private void tsmiRenouveler_Click_1(object sender, EventArgs e)
        {
            if (dgvAbonnements.CurrentRow != null)
            {
                frmRenouveler frm = new frmRenouveler(dgvAbonnements.CurrentRow);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _LoadAbonnementsData();
                }
            }
        }

        private void tsmiDetails_Click_1(object sender, EventArgs e)
        {
            if (dgvAbonnements.CurrentRow != null && dgvAbonnements.Columns.Contains("AbonnementID"))
            {
                int selectedID = Convert.ToInt32(dgvAbonnements.CurrentRow.Cells["AbonnementID"].Value);

                frmDetailsAbonnemnt frm = new frmDetailsAbonnemnt(selectedID);
                frm.ShowDialog();
            }
        }
    }
}
