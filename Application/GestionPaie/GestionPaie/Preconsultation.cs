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
    public partial class Preconsultation : UserControl
    {
        public Preconsultation()
        {
            InitializeComponent();
        }
        PreconsultationClasse preconsult = new PreconsultationClasse();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                preconsult.Id = Factory.Instance.ReNewIdValue(preconsult);
                txtPoids.Clear();
                txtTemp.Clear();
                txtPressionArt.Clear();
                txtObservation.Clear();
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
                dtgPreconsultation.DataSource = Factory.Instance.GetMalades();

                if (dtgPreconsultation.RowCount > 0)
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
                MessageBox.Show("Erreur lors de l'actualisation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (preconsult != null)
                {
                    getAttributs();

                    preconsult.Enregistrer();
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
        private void getAttributs()
        {
            preconsult.Poids = Convert.ToInt32(txtPoids.Text);
            preconsult.Temperature = Convert.ToInt32(txtTemp.Text);
            preconsult.PressionArterielle = txtPressionArt.Text;
            preconsult.Observation = txtObservation.Text;
            preconsult.Id_malade = ((MaladeClasse)cboMalade.SelectedItem).Id;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (preconsult != null)
                {
                    getAttributs();
                    preconsult.Modifier();
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
                    preconsult.Supprimer();
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();

                    if (dtgPreconsultation.RowCount <= 0)
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

        private void dtgPreconsultation_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgPreconsultation.SelectedRows.Count > 0)
                {
                    preconsult = (PreconsultationClasse)dtgPreconsultation.SelectedRows[0].DataBoundItem;
                    txtIdConsultation.Text = preconsult.Id.ToString();
                    txtPoids.Text = preconsult.Poids.ToString();
                    txtTemp.Text = preconsult.Temperature.ToString();
                    txtPressionArt.Text = preconsult.PressionArterielle;
                    txtObservation.Text = preconsult.Observation.ToString();
                    cboMalade.Text = Factory.Instance.GetQualification(preconsult.Id_malade).ToString();
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }
    }
}
