using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionClinic_LIB;

namespace DesignClinic
{
    public partial class Fonction : Form
    {
        public Fonction()
        {
            InitializeComponent();
        }
        FonctionClasse fonction = new FonctionClasse();
        private void btnAddFonction_Click(object sender, EventArgs e)
        {
            try
            {
                fonction.Id = Factory.Instance.ReNewIdValue(fonction);
                txtIdFontion.Clear();
                txtDesignFontion.Clear();
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
                lstViewFonction.DataSource = Factory.Instance.GetFonctions();

                if (lstViewFonction.RowCount > 0)
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
                if (fonction!= null)
                {
                    getAttributs();

                    fonction.Enregistrer();
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
            fonction.Id = Convert.ToInt32(txtIdFontion.Text);
            fonction.Designation = txtDesignFontion.Text;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (fonction!= null)
                {
                    getAttributs();
                    fonction.Modifier();
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
                    fonction.Id = Convert.ToInt32(txtIdFontion.Text);
                    fonction.Supprimer();
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();

                    if (lstViewFonction.RowCount <= 0)
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

        private void Fonction_Load(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void lstViewFonction_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstViewFonction.SelectedRows.Count > 0)
                {
                    fonction = (FonctionClasse)lstViewFonction.SelectedRows[0].DataBoundItem;
                    txtIdFontion.Text = fonction.Id.ToString();
                    txtDesignFontion.Text = fonction.Designation.ToString();
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }
    }
}
