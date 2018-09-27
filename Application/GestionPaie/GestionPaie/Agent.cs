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
    public partial class Agent : UserControl
    {
        public Agent()
        {
            InitializeComponent();
        }
        AgentClasse agent = new AgentClasse();
        Personne personne = new Personne();
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblAjouterQualifaction_Click(object sender, EventArgs e)
        {
            QualificationUserControl form = new QualificationUserControl();
            form.Visible=true;
        }

        private void Agent_Load(object sender, EventArgs e)
        {
            try
            {
                listViewAgent.DataSource = Factory.Instance.GetAgents();
                cboFonction.DataSource = Factory.Instance.GetFonctions();
                cboQualifaction.DataSource = Factory.Instance.GetQualifications();
            }
            catch(Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                personne.IdPers = Factory.Instance.ReNewIdValue(personne);
                agent.Id = Factory.Instance.ReNewIdValue(agent);
                agent.Id_personne = personne.IdPers;
                txtMatriculeAgent.Clear();
                txtNomAgent.Clear();
                txtPNomAgent.Clear();
                txtPrenomAgent.Clear();
                txtLieuNaissance.Clear();
                txtDateNaissanceAgent.Text = "";
                txtDateEngagement.Text = "";
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
                listViewAgent.DataSource = Factory.Instance.GetQualifications();

                if (listViewAgent.RowCount > 0)
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
                if (agent != null)
                {
                    getAttributs();

                    agent.Enregistrer();
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
            agent.Matricule = txtMatriculeAgent.Text;
            agent.Nom = txtNomAgent.Text;
            agent.PostNom = txtPNomAgent.Text;
            agent.Prenom = txtPrenomAgent.Text;
            agent.Sexe = cboSexeAgent.Text;
            agent.EtatCivil = cboEtatCivAgent.Text;
            agent.DateNaissance = txtDateNaissanceAgent.Value;
            agent.DateAngagement = txtDateEngagement.Value;
            agent.Id_fonction = ((FonctionClasse)cboFonction.SelectedItem).Id;
            agent.Id_qualification = ((Qualification)cboQualifaction.SelectedItem).Id;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (agent != null)
                {
                    getAttributs();
                    agent.Modifier();
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
                    agent.Supprimer();
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();

                    if (listViewAgent.RowCount <= 0)
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

        private void listViewAgent_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgent.SelectedRows.Count > 0)
                {
                    agent = (AgentClasse)listViewAgent.SelectedRows[0].DataBoundItem;
                    txtMatriculeAgent.Text = agent.Matricule;
                    txtNomAgent.Text = agent.Nom;
                    txtPNomAgent.Text = agent.PostNom;
                    txtPrenomAgent.Text = agent.Prenom;
                    txtDateNaissanceAgent.Text = agent.DateNaissance.ToString();
                    txtDateEngagement.Text = agent.DateAngagement.ToString();
                    cboSexeAgent.Text = agent.Sexe;
                    cboEtatCivAgent.Text = agent.EtatCivil;
                    cboFonction.Text = Factory.Instance.GetFonction(agent.Id_fonction).ToString();
                    cboQualifaction.Text = Factory.Instance.GetQualification(agent.Id_qualification).ToString();
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }

    }
}
