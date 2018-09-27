namespace DesignClinic
{
    partial class Preconsultation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preconsultation));
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdConsultation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPressionArt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgPreconsultation = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddPreconsult = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshPreconsult = new System.Windows.Forms.ToolStripButton();
            this.btnSavePreconsult = new System.Windows.Forms.ToolStripButton();
            this.btnModifierPreconsult = new System.Windows.Forms.ToolStripButton();
            this.btnDeletePreconsult = new System.Windows.Forms.ToolStripButton();
            this.cboMalade = new System.Windows.Forms.ComboBox();
            this.cboAvenu = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bnvFonction = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnModifier = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPreconsultation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvFonction)).BeginInit();
            this.bnvFonction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(115, 106);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(68, 20);
            this.txtPoids.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Poids :";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(115, 132);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(157, 20);
            this.txtTemp.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Température :";
            // 
            // txtIdConsultation
            // 
            this.txtIdConsultation.Location = new System.Drawing.Point(115, 58);
            this.txtIdConsultation.Name = "txtIdConsultation";
            this.txtIdConsultation.Size = new System.Drawing.Size(68, 20);
            this.txtIdConsultation.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Id:";
            // 
            // txtPressionArt
            // 
            this.txtPressionArt.Location = new System.Drawing.Point(114, 157);
            this.txtPressionArt.Name = "txtPressionArt";
            this.txtPressionArt.Size = new System.Drawing.Size(157, 20);
            this.txtPressionArt.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Pression Arterielle: ";
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(115, 183);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(234, 65);
            this.txtObservation.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Obsevation :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(185, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Kg";
            // 
            // dtgPreconsultation
            // 
            this.dtgPreconsultation.BackgroundColor = System.Drawing.Color.White;
            this.dtgPreconsultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPreconsultation.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgPreconsultation.Location = new System.Drawing.Point(355, 58);
            this.dtgPreconsultation.Name = "dtgPreconsultation";
            this.dtgPreconsultation.Size = new System.Drawing.Size(456, 190);
            this.dtgPreconsultation.TabIndex = 59;
            this.dtgPreconsultation.SelectionChanged += new System.EventHandler(this.dtgPreconsultation_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(12, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Malade :";
            // 
            // btnAddPreconsult
            // 
            this.btnAddPreconsult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddPreconsult.Image = global::DesignClinic.Properties.Resources.navBarAddIcon_2x;
            this.btnAddPreconsult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPreconsult.Name = "btnAddPreconsult";
            this.btnAddPreconsult.Size = new System.Drawing.Size(23, 22);
            this.btnAddPreconsult.Text = "Ajouter";
            // 
            // btnRefreshPreconsult
            // 
            this.btnRefreshPreconsult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshPreconsult.Image = global::DesignClinic.Properties.Resources.update;
            this.btnRefreshPreconsult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshPreconsult.Name = "btnRefreshPreconsult";
            this.btnRefreshPreconsult.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshPreconsult.Text = "Refresh";
            // 
            // btnSavePreconsult
            // 
            this.btnSavePreconsult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSavePreconsult.Image = global::DesignClinic.Properties.Resources.check_2x;
            this.btnSavePreconsult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePreconsult.Name = "btnSavePreconsult";
            this.btnSavePreconsult.Size = new System.Drawing.Size(23, 22);
            this.btnSavePreconsult.Text = "Enregistrer";
            // 
            // btnModifierPreconsult
            // 
            this.btnModifierPreconsult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModifierPreconsult.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierPreconsult.Image")));
            this.btnModifierPreconsult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifierPreconsult.Name = "btnModifierPreconsult";
            this.btnModifierPreconsult.Size = new System.Drawing.Size(23, 22);
            this.btnModifierPreconsult.Text = "Modifier";
            // 
            // btnDeletePreconsult
            // 
            this.btnDeletePreconsult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeletePreconsult.Image = global::DesignClinic.Properties.Resources.mp_delete_md_n_lt_2x;
            this.btnDeletePreconsult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletePreconsult.Name = "btnDeletePreconsult";
            this.btnDeletePreconsult.Size = new System.Drawing.Size(23, 22);
            this.btnDeletePreconsult.Text = "Supprimer";
            // 
            // cboMalade
            // 
            this.cboMalade.FormattingEnabled = true;
            this.cboMalade.Location = new System.Drawing.Point(115, 81);
            this.cboMalade.Name = "cboMalade";
            this.cboMalade.Size = new System.Drawing.Size(234, 21);
            this.cboMalade.TabIndex = 61;
            // 
            // cboAvenu
            // 
            this.cboAvenu.FormattingEnabled = true;
            this.cboAvenu.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cboAvenu.Location = new System.Drawing.Point(675, 9);
            this.cboAvenu.Name = "cboAvenu";
            this.cboAvenu.Size = new System.Drawing.Size(129, 21);
            this.cboAvenu.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(582, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Rechercher :";
            // 
            // bnvFonction
            // 
            this.bnvFonction.AddNewItem = null;
            this.bnvFonction.AutoSize = false;
            this.bnvFonction.BackColor = System.Drawing.Color.Transparent;
            this.bnvFonction.CountItem = null;
            this.bnvFonction.DeleteItem = null;
            this.bnvFonction.Dock = System.Windows.Forms.DockStyle.None;
            this.bnvFonction.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnvFonction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnRefresh,
            this.btnSave,
            this.btnModifier,
            this.btnDelete});
            this.bnvFonction.Location = new System.Drawing.Point(3, 7);
            this.bnvFonction.MoveFirstItem = null;
            this.bnvFonction.MoveLastItem = null;
            this.bnvFonction.MoveNextItem = null;
            this.bnvFonction.MovePreviousItem = null;
            this.bnvFonction.Name = "bnvFonction";
            this.bnvFonction.PositionItem = null;
            this.bnvFonction.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bnvFonction.Size = new System.Drawing.Size(137, 25);
            this.bnvFonction.TabIndex = 72;
            this.bnvFonction.Text = "bindingNavigator1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::DesignClinic.Properties.Resources.navBarAddIcon_2x;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::DesignClinic.Properties.Resources.update;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::DesignClinic.Properties.Resources.check_2x;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Enregistrer";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(23, 22);
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::DesignClinic.Properties.Resources.mp_delete_md_n_lt_2x;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bnvFonction);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cboAvenu);
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 32);
            this.groupBox1.TabIndex = 158;
            this.groupBox1.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(761, -3);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(60, 24);
            this.bindingNavigator1.TabIndex = 159;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DesignClinic.Properties.Resources.Close1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 21);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(389, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 160;
            this.label8.Text = "Préconsultation";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Preconsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::DesignClinic.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboMalade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgPreconsultation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPressionArt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdConsultation);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Preconsultation";
            this.Size = new System.Drawing.Size(819, 259);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPreconsultation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvFonction)).EndInit();
            this.bnvFonction.ResumeLayout(false);
            this.bnvFonction.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdConsultation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPressionArt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgPreconsultation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton btnAddPreconsult;
        private System.Windows.Forms.ToolStripButton btnRefreshPreconsult;
        private System.Windows.Forms.ToolStripButton btnSavePreconsult;
        private System.Windows.Forms.ToolStripButton btnModifierPreconsult;
        private System.Windows.Forms.ToolStripButton btnDeletePreconsult;
        private System.Windows.Forms.ComboBox cboMalade;
        private System.Windows.Forms.ComboBox cboAvenu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingNavigator bnvFonction;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnModifier;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label8;
    }
}
