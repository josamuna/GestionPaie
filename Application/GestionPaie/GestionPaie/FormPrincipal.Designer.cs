namespace DesignClinic
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.men3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblmen3 = new System.Windows.Forms.Label();
            this.men2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblmen2 = new System.Windows.Forms.Label();
            this.MenTriage = new System.Windows.Forms.GroupBox();
            this.lblEntreprise = new System.Windows.Forms.Label();
            this.lblPreconsultation = new System.Windows.Forms.Label();
            this.lblMalade = new System.Windows.Forms.Label();
            this.lblAgent = new System.Windows.Forms.Label();
            this.lblTriage = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.men3.SuspendLayout();
            this.men2.SuspendLayout();
            this.MenTriage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 77);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.men3);
            this.splitContainer1.Panel1.Controls.Add(this.men2);
            this.splitContainer1.Panel1.Controls.Add(this.MenTriage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Size = new System.Drawing.Size(817, 643);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 9;
            // 
            // men3
            // 
            this.men3.BackColor = System.Drawing.Color.Transparent;
            this.men3.BackgroundImage = global::DesignClinic.Properties.Resources.bg;
            this.men3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.men3.Controls.Add(this.label11);
            this.men3.Controls.Add(this.label12);
            this.men3.Controls.Add(this.label13);
            this.men3.Controls.Add(this.label14);
            this.men3.Controls.Add(this.lblmen3);
            this.men3.Location = new System.Drawing.Point(7, 248);
            this.men3.Name = "men3";
            this.men3.Size = new System.Drawing.Size(180, 40);
            this.men3.TabIndex = 6;
            this.men3.TabStop = false;
            // 
            // label11
            // 
            this.label11.Image = global::DesignClinic.Properties.Resources.tab_me_2x1;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(0, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 32);
            this.label11.TabIndex = 4;
            this.label11.Text = "Entreprise de prise en charge";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(0, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 34);
            this.label12.TabIndex = 3;
            this.label12.Text = "            Preconsultation";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(0, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 27);
            this.label13.TabIndex = 2;
            this.label13.Text = "            Malade";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(3, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 27);
            this.label14.TabIndex = 1;
            this.label14.Text = "            Agent";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblmen3
            // 
            this.lblmen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmen3.Location = new System.Drawing.Point(6, 11);
            this.lblmen3.Name = "lblmen3";
            this.lblmen3.Size = new System.Drawing.Size(168, 18);
            this.lblmen3.TabIndex = 0;
            this.lblmen3.Text = "Menu 3";
            this.lblmen3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // men2
            // 
            this.men2.BackColor = System.Drawing.Color.Transparent;
            this.men2.BackgroundImage = global::DesignClinic.Properties.Resources.bg;
            this.men2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.men2.Controls.Add(this.label6);
            this.men2.Controls.Add(this.label7);
            this.men2.Controls.Add(this.label8);
            this.men2.Controls.Add(this.label9);
            this.men2.Controls.Add(this.lblmen2);
            this.men2.Location = new System.Drawing.Point(7, 202);
            this.men2.Name = "men2";
            this.men2.Size = new System.Drawing.Size(180, 40);
            this.men2.TabIndex = 5;
            this.men2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Image = global::DesignClinic.Properties.Resources.tab_me_2x1;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(0, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Entreprise de prise en charge";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(0, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 34);
            this.label7.TabIndex = 3;
            this.label7.Text = "            Preconsultation";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(0, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 27);
            this.label8.TabIndex = 2;
            this.label8.Text = "            Malade";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(3, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "            Agent";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblmen2
            // 
            this.lblmen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmen2.Location = new System.Drawing.Point(6, 11);
            this.lblmen2.Name = "lblmen2";
            this.lblmen2.Size = new System.Drawing.Size(168, 18);
            this.lblmen2.TabIndex = 0;
            this.lblmen2.Text = "Menu 2";
            this.lblmen2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenTriage
            // 
            this.MenTriage.BackColor = System.Drawing.Color.Transparent;
            this.MenTriage.BackgroundImage = global::DesignClinic.Properties.Resources.bg;
            this.MenTriage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenTriage.Controls.Add(this.lblEntreprise);
            this.MenTriage.Controls.Add(this.lblPreconsultation);
            this.MenTriage.Controls.Add(this.lblMalade);
            this.MenTriage.Controls.Add(this.lblAgent);
            this.MenTriage.Controls.Add(this.lblTriage);
            this.MenTriage.Location = new System.Drawing.Point(7, 24);
            this.MenTriage.Name = "MenTriage";
            this.MenTriage.Size = new System.Drawing.Size(180, 186);
            this.MenTriage.TabIndex = 1;
            this.MenTriage.TabStop = false;
            // 
            // lblEntreprise
            // 
            this.lblEntreprise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEntreprise.Image = global::DesignClinic.Properties.Resources.tab_me_2x1;
            this.lblEntreprise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEntreprise.Location = new System.Drawing.Point(3, 143);
            this.lblEntreprise.Name = "lblEntreprise";
            this.lblEntreprise.Size = new System.Drawing.Size(171, 32);
            this.lblEntreprise.TabIndex = 4;
            this.lblEntreprise.Text = "        Entreprise de prise en charge";
            this.lblEntreprise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEntreprise.MouseLeave += new System.EventHandler(this.lblEntreprise_MouseLeave);
            this.lblEntreprise.Click += new System.EventHandler(this.lblEntreprise_Click);
            this.lblEntreprise.MouseEnter += new System.EventHandler(this.lblEntreprise_MouseEnter);
            // 
            // lblPreconsultation
            // 
            this.lblPreconsultation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPreconsultation.Image = ((System.Drawing.Image)(resources.GetObject("lblPreconsultation.Image")));
            this.lblPreconsultation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPreconsultation.Location = new System.Drawing.Point(3, 109);
            this.lblPreconsultation.Name = "lblPreconsultation";
            this.lblPreconsultation.Size = new System.Drawing.Size(171, 34);
            this.lblPreconsultation.TabIndex = 3;
            this.lblPreconsultation.Text = "            Preconsultation";
            this.lblPreconsultation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPreconsultation.MouseLeave += new System.EventHandler(this.lblPreconsultation_MouseLeave);
            this.lblPreconsultation.Click += new System.EventHandler(this.lblPreconsultation_Click);
            this.lblPreconsultation.MouseEnter += new System.EventHandler(this.lblPreconsultation_MouseEnter);
            // 
            // lblMalade
            // 
            this.lblMalade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMalade.Image = ((System.Drawing.Image)(resources.GetObject("lblMalade.Image")));
            this.lblMalade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMalade.Location = new System.Drawing.Point(3, 82);
            this.lblMalade.Name = "lblMalade";
            this.lblMalade.Size = new System.Drawing.Size(171, 27);
            this.lblMalade.TabIndex = 2;
            this.lblMalade.Text = "            Malade";
            this.lblMalade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMalade.MouseLeave += new System.EventHandler(this.lblMalade_MouseLeave);
            this.lblMalade.Click += new System.EventHandler(this.lblMalade_Click);
            this.lblMalade.MouseEnter += new System.EventHandler(this.lblMalade_MouseEnter);
            // 
            // lblAgent
            // 
            this.lblAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAgent.Image = ((System.Drawing.Image)(resources.GetObject("lblAgent.Image")));
            this.lblAgent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgent.Location = new System.Drawing.Point(3, 48);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(171, 27);
            this.lblAgent.TabIndex = 1;
            this.lblAgent.Text = "            Agent";
            this.lblAgent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgent.MouseLeave += new System.EventHandler(this.lblAgent_MouseLeave);
            this.lblAgent.Click += new System.EventHandler(this.lblAgent_Click);
            this.lblAgent.MouseEnter += new System.EventHandler(this.lblAgent_MouseEnter);
            // 
            // lblTriage
            // 
            this.lblTriage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriage.Location = new System.Drawing.Point(6, 9);
            this.lblTriage.Name = "lblTriage";
            this.lblTriage.Size = new System.Drawing.Size(168, 25);
            this.lblTriage.TabIndex = 0;
            this.lblTriage.Text = "Triage";
            this.lblTriage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTriage.Click += new System.EventHandler(this.lblTriage_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 720);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(817, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 53);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 742);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.men3.ResumeLayout(false);
            this.men2.ResumeLayout(false);
            this.MenTriage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox MenTriage;
        private System.Windows.Forms.Label lblTriage;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Label lblEntreprise;
        private System.Windows.Forms.Label lblPreconsultation;
        private System.Windows.Forms.Label lblMalade;
        private System.Windows.Forms.GroupBox men3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblmen3;
        private System.Windows.Forms.GroupBox men2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblmen2;

    }
}

