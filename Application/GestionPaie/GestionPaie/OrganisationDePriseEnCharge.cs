using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionClinic_LIB;

namespace DesignClinic
{
    public partial class OrganisationDePriseEnCharge : UserControl
    {
        public OrganisationDePriseEnCharge()
        {
            InitializeComponent();
        }
        EtablissementPriseEnCharge etablisement = new EtablissementPriseEnCharge();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                etablisement.Id = Factory.Instance.ReNewIdValue(etablisement);
                txtDenomination.Clear();
                txtAdresse.Clear();
                txtTelephone.Clear();
                btnSave.Enabled = true;
            }
            catch (Exception) { btnSave.Enabled = false; }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            try
            {
                lstViewOrganisation.DataSource = Factory.Instance.GetEtablissementPriseEnCharges();

                if (lstViewOrganisation.RowCount > 0)
                {
                    btnModifier.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnModifier.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'actualisation des Fonctions", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void getAttributs()
        {
            etablisement.Id = Convert.ToInt32(txtIdOrganisation.Text);
            etablisement.Denomination = txtDenomination.Text;
            etablisement.Adresse = txtAdresse.Text;
            etablisement.Telephone = txtTelephone.Text;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (etablisement != null)
                {
                    getAttributs();

                    etablisement.Enregistrer();
                    btnSave.Enabled = false;
                    MessageBox.Show("Enregistrement éffectué", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de l'enregistrement " + ex.Message, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (etablisement != null)
                {
                    getAttributs();
                    etablisement .Modifier();
                    MessageBox.Show("Modification effectuée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la modification " + ex.Message, "Modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez - vous vraiment supprimer cet enregistrement ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    etablisement.Id = Convert.ToInt32(txtIdOrganisation.Text);
                    etablisement.Supprimer();
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();

                    if (lstViewOrganisation.RowCount <= 0)
                    {
                        btnSave.Enabled = false;
                        btnModifier.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la suppression " + ex.Message, "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void OrganisationDePriseEnCharge_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void lstViewOrganisation_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstViewOrganisation.SelectedRows.Count > 0)
                {
                    etablisement = (EtablissementPriseEnCharge)lstViewOrganisation.SelectedRows[0].DataBoundItem;
                    txtIdOrganisation.Text = etablisement.Id.ToString();
                    txtDenomination.Text = etablisement.Denomination.ToString();
                    txtAdresse.Text = etablisement.Adresse.ToString();
                    txtTelephone.Text = etablisement.Telephone.ToString();
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }
    }
}
