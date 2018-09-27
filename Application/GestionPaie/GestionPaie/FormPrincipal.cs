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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTriage_Click(object sender, EventArgs e)
        {
            if (MenTriage.Height == 36)
            {
                MenTriage.Size = new System.Drawing.Size(180, 184);
                men2.Location = new System.Drawing.Point(7, 216);
                men3.Location = new System.Drawing.Point(7, 260);
            }
            else 
            {
                MenTriage.Size = new System.Drawing.Size(180, 36);
                men2.Location = new System.Drawing.Point(7, 65);
                men3.Location = new System.Drawing.Point(7, 111);
            }
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.splitContainer1.SplitterDistance = 190;
            MenTriage.Size = new System.Drawing.Size(180, 36);
            men2.Location = new System.Drawing.Point(7, 65);
            men3.Location = new System.Drawing.Point(7, 111);
            Factory.Instance.VerifieDoConnect(null,@"CPGSOFT-PC\SQLEXPRESS","GestionClinic","sa","cpg",1);
                //Data Source=CPGSOFT-PC\SQLEXPRESS;Initial Catalog=GestionClinic;Persist Security Info=True;User ID=sa
        }

        private void lblAgent_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Agent frm = new Agent();
            frm.Parent = this.splitContainer1.Panel2;
            this.splitContainer1.Panel2.Controls.Add(frm);
        }

        private void lblMalade_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Malade frm = new Malade();
            frm.Parent = this.splitContainer1.Panel2;
            this.splitContainer1.Panel2.Controls.Add(frm);
        }

        private void lblPreconsultation_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Preconsultation frm = new Preconsultation();
            frm.Parent = this.splitContainer1.Panel2;
            this.splitContainer1.Panel2.Controls.Add(frm);
        }

        private void lblEntreprise_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            OrganisationDePriseEnCharge frm = new OrganisationDePriseEnCharge();
            frm.Parent = this.splitContainer1.Panel2;
            this.splitContainer1.Panel2.Controls.Add(frm);
        }

        private void lblAgent_MouseEnter(object sender, EventArgs e)
        {
            ((Control)lblAgent).ForeColor = Color.WhiteSmoke;
            ((Control)lblAgent).BackColor = Color.FromArgb(163, 185, 207);
           
        }

        private void lblAgent_MouseLeave(object sender, EventArgs e)
        {
            ((Control)lblAgent).BackColor = Color.Empty;
            ((Control)lblAgent).ForeColor = Color.Black;
        }

        private void lblMalade_MouseEnter(object sender, EventArgs e)
        {
            ((Control)lblMalade).BackColor = Color.FromArgb(163, 185, 207);
            ((Control)lblMalade).ForeColor = Color.WhiteSmoke;
        }

        private void lblMalade_MouseLeave(object sender, EventArgs e)
        {
            ((Control)lblMalade).BackColor = Color.Empty ;
            ((Control)lblMalade).ForeColor = Color.Black ;

        }

        private void lblPreconsultation_MouseEnter(object sender, EventArgs e)
        {
            ((Control)lblPreconsultation).BackColor = Color.FromArgb(163, 185, 207);
            ((Control)lblPreconsultation).ForeColor = Color.WhiteSmoke;

        }

        private void lblPreconsultation_MouseLeave(object sender, EventArgs e)
        {
            ((Control)lblPreconsultation).BackColor = Color.Empty;
            ((Control)lblPreconsultation).ForeColor = Color.Black ;
        }

        private void lblEntreprise_MouseEnter(object sender, EventArgs e)
        {
            ((Control)lblEntreprise).BackColor = Color.FromArgb(163, 185, 207);
            ((Control)lblEntreprise).ForeColor = Color.WhiteSmoke;

        }

        private void lblEntreprise_MouseLeave(object sender, EventArgs e)
        {
            ((Control)lblEntreprise).BackColor = Color.Empty;
            ((Control)lblEntreprise).ForeColor = Color.Black;


        }

    }
}
