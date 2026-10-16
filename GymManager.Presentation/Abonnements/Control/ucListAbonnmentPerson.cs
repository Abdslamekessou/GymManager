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

namespace GymManager.Presentation.Abonnements.Control
{
    public partial class ucListAbonnmentPerson : UserControl
    {
        private string _NamePerson;
        private DataTable _dtListAbonnement;
        public ucListAbonnmentPerson()
        {
            InitializeComponent();
        }

        private void ucListAbonnmentPerson_Load(object sender, EventArgs e)
        {
            dgvAbonnements.CellFormatting -= dgvAbonnements_CellFormatting;
            dgvAbonnements.CellFormatting += dgvAbonnements_CellFormatting;

        }

        public void LoadAbonnementsPersonData(string namePerson)
        {
            _NamePerson = namePerson;

            _dtListAbonnement = clsAbonnement.GetAllAbonnementsWithPerson(_NamePerson);
            dgvAbonnements.DataSource = _dtListAbonnement;

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

        private void cbFilterStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtListAbonnement == null) return;

            string selectedStatut = cbFilterStatut.Text.Trim();

            if (selectedStatut == "Tous" || string.IsNullOrEmpty(selectedStatut))
            {
                _dtListAbonnement.DefaultView.RowFilter = "";
            }
            else
            {
                _dtListAbonnement.DefaultView.RowFilter = string.Format("Statut = '{0}'", selectedStatut.Replace("'", "''"));
            }
        }
    }
}
