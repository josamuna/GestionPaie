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
    public partial class CategorieMalade : Form
    {
        public CategorieMalade()
        {
            InitializeComponent();
        }
        CategorieMaladeClasse catMalade = new CategorieMaladeClasse();
        private void btnAddCateg_Click(object sender, EventArgs e)
        {
            try
            {
                catMalade.Id = Factory.Instance.ReNewIdValue(catMalade);
                txtIdCategorieMalade.Clear();
                txtDesignCategorieMalade.Clear();
                txtTaux.Clear();
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
                lstViewCategorieMalade.DataSource = Factory.Instance.GetCategorieMalades();

                if (lstViewCategorieMalade.RowCount > 0)
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
                if (catMalade != null)
                {
                    getAttributs();

                    catMalade.Enregistrer();
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
            catMalade.Id = Convert.ToInt32(txtIdCategorieMalade.Text);
            catMalade.Designation = txtDesignCategorieMalade.Text;
            catMalade.Taux = Convert.ToInt32(txtTaux.Text);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (catMalade != null)
                {
                    getAttributs();
                    catMalade.Modifier();
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
                    catMalade.Id = Convert.ToInt32(txtIdCategorieMalade.Text);
                    catMalade.Supprimer();
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();

                    if (lstViewCategorieMalade.RowCount <= 0)
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

        private void CategorieMalade_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void lstViewCategorieMalade_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstViewCategorieMalade.SelectedRows.Count > 0)
                {
                    catMalade = (CategorieMaladeClasse)lstViewCategorieMalade.SelectedRows[0].DataBoundItem;
                    txtIdCategorieMalade.Text = catMalade.Id.ToString();
                    txtDesignCategorieMalade.Text = catMalade.Designation.ToString();
                    txtTaux.Text = catMalade.Taux.ToString();
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }
    }
}
