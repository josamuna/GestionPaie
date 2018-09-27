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
    public partial class Malade : UserControl
    {
        public Malade()
        {
            InitializeComponent();
        }
        MaladeClasse malade = new MaladeClasse();
        Personne personne = new Personne();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                personne.IdPers = Factory.Instance.ReNewIdValue(personne);
                malade.Id = Factory.Instance.ReNewIdValue(malade);
                malade.Id_personne = personne.IdPers;
                txtNumeroMalade.Clear();
                txtNomMalade.Clear();
                txtPNomMalade.Clear();
                txtPrenomMalade.Clear();
                txtDateNaissanceMalade.Text = "";
                btnSave.Enabled = true;
            }
            catch (Exception) { btnSave.Enabled = false; }
        }

        private void btnRefreh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            try
            {
                listViewMalde.DataSource = Factory.Instance.GetMalades();

                if (listViewMalde.RowCount > 0)
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
                if (malade != null)
                {
                    getAttributs();

                    malade.Enregistrer();
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
            malade.Numero = txtNumeroMalade.Text;
            malade.Nom = txtNomMalade.Text;
            malade.PostNom = txtPNomMalade.Text;
            malade.Prenom = txtPrenomMalade.Text;
            malade.Sexe = cboSexeMalade.Text;
            malade.EtatCivil = cboEtatCivMalade.Text;
            malade.DateNaissance = txtDateNaissanceMalade.Value;
            malade.Id_AireDeSante = ((AireDeSante)cboAireSante.SelectedItem).Id;
            malade.Id_categorieMalade  = ((CategorieMaladeClasse)cboCategorieMalade.SelectedItem).Id;
            malade.Id_EtablissementPriseEnCharge = ((EtablissementPriseEnCharge)cboEtablissement.SelectedItem).Id;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (malade != null)
                {
                    getAttributs();
                    malade.Modifier();
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
                    malade.Supprimer();
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();

                    if (listViewMalde.RowCount <= 0)
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

        private void Malade_Load(object sender, EventArgs e)
        {
            try
            {
                listViewMalde.DataSource = Factory.Instance.GetMalades();
                cboCategorieMalade.DataSource = Factory.Instance.GetCategorieMalades();
                cboEtablissement.DataSource = Factory.Instance.GetEtablissementPriseEnCharges();
                cboAireSante.DataSource = Factory.Instance.GetAireDeSantes();
            }
            catch (Exception)
            {
            }
        }

        private void listViewMalde_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewMalde.SelectedRows.Count > 0)
                {
                    malade = (MaladeClasse)listViewMalde.SelectedRows[0].DataBoundItem;
                    txtNumeroMalade.Text = malade.Numero;
                    txtNomMalade.Text = malade.Nom;
                    txtPNomMalade.Text = malade.PostNom;
                    txtPrenomMalade.Text = malade.Prenom;
                    txtDateNaissanceMalade.Text = malade.DateNaissance.ToString();
                    cboSexeMalade.Text = malade.Sexe;
                    cboEtatCivMalade.Text = malade.EtatCivil;
                    cboCategorieMalade.Text = Factory.Instance.getCategorieMalade(malade.Id_categorieMalade).ToString();
                    cboEtablissement.Text = Factory.Instance.GetQualification(malade.Id_EtablissementPriseEnCharge).ToString();
                    cboAireSante.Text = Factory.Instance.GetQualification(malade.Id_AireDeSante).ToString();
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }
    }
}
