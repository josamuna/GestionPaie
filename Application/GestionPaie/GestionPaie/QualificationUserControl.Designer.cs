namespace DesignClinic
{
    partial class QualificationUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QualificationUserControl));
            this.lstViewAirSante = new System.Windows.Forms.ListView();
            this.txtDesignAirSante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdAirSante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnvFonction = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddFonction = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshFonction = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFonction = new System.Windows.Forms.ToolStripButton();
            this.btnModifierFonction = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteFonction = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bnvFonction)).BeginInit();
            this.bnvFonction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstViewAirSante
            // 
            this.lstViewAirSante.Location = new System.Drawing.Point(244, 35);
            this.lstViewAirSante.Name = "lstViewAirSante";
            this.lstViewAirSante.Size = new System.Drawing.Size(264, 89);
            this.lstViewAirSante.TabIndex = 45;
            this.lstViewAirSante.UseCompatibleStateImageBehavior = false;
            // 
            // txtDesignAirSante
            // 
            this.txtDesignAirSante.Location = new System.Drawing.Point(80, 79);
            this.txtDesignAirSante.Name = "txtDesignAirSante";
            this.txtDesignAirSante.Size = new System.Drawing.Size(157, 20);
            this.txtDesignAirSante.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Désignation:";
            // 
            // txtIdAirSante
            // 
            this.txtIdAirSante.Location = new System.Drawing.Point(80, 53);
            this.txtIdAirSante.Name = "txtIdAirSante";
            this.txtIdAirSante.Size = new System.Drawing.Size(68, 20);
            this.txtIdAirSante.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id:";
            // 
            // bnvFonction
            // 
            this.bnvFonction.AddNewItem = null;
            this.bnvFonction.BackColor = System.Drawing.Color.Transparent;
            this.bnvFonction.CountItem = null;
            this.bnvFonction.DeleteItem = null;
            this.bnvFonction.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnvFonction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFonction,
            this.btnRefreshFonction,
            this.btnSaveFonction,
            this.btnModifierFonction,
            this.btnDeleteFonction,
            this.toolStripButton1});
            this.bnvFonction.Location = new System.Drawing.Point(0, 0);
            this.bnvFonction.MoveFirstItem = null;
            this.bnvFonction.MoveLastItem = null;
            this.bnvFonction.MoveNextItem = null;
            this.bnvFonction.MovePreviousItem = null;
            this.bnvFonction.Name = "bnvFonction";
            this.bnvFonction.PositionItem = null;
            this.bnvFonction.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bnvFonction.Size = new System.Drawing.Size(517, 25);
            this.bnvFonction.TabIndex = 72;
            this.bnvFonction.Text = "bindingNavigator1";
            // 
            // btnAddFonction
            // 
            this.btnAddFonction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFonction.Image = global::DesignClinic.Properties.Resources.navBarAddIcon_2x;
            this.btnAddFonction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFonction.Name = "btnAddFonction";
            this.btnAddFonction.Size = new System.Drawing.Size(23, 22);
            this.btnAddFonction.Text = "Ajouter";
            // 
            // btnRefreshFonction
            // 
            this.btnRefreshFonction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshFonction.Image = global::DesignClinic.Properties.Resources.update;
            this.btnRefreshFonction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshFonction.Name = "btnRefreshFonction";
            this.btnRefreshFonction.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshFonction.Text = "Refresh";
            // 
            // btnSaveFonction
            // 
            this.btnSaveFonction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveFonction.Image = global::DesignClinic.Properties.Resources.check_2x;
            this.btnSaveFonction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveFonction.Name = "btnSaveFonction";
            this.btnSaveFonction.Size = new System.Drawing.Size(23, 22);
            this.btnSaveFonction.Text = "Enregistrer";
            // 
            // btnModifierFonction
            // 
            this.btnModifierFonction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModifierFonction.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierFonction.Image")));
            this.btnModifierFonction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifierFonction.Name = "btnModifierFonction";
            this.btnModifierFonction.Size = new System.Drawing.Size(23, 22);
            this.btnModifierFonction.Text = "Modifier";
            // 
            // btnDeleteFonction
            // 
            this.btnDeleteFonction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteFonction.Image = global::DesignClinic.Properties.Resources.mp_delete_md_n_lt_2x;
            this.btnDeleteFonction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteFonction.Name = "btnDeleteFonction";
            this.btnDeleteFonction.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteFonction.Text = "Supprimer";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DesignClinic.Properties.Resources.Close1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // QualificationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::DesignClinic.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bnvFonction);
            this.Controls.Add(this.lstViewAirSante);
            this.Controls.Add(this.txtDesignAirSante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdAirSante);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "QualificationUserControl";
            this.Size = new System.Drawing.Size(517, 136);
            ((System.ComponentModel.ISupportInitialize)(this.bnvFonction)).EndInit();
            this.bnvFonction.ResumeLayout(false);
            this.bnvFonction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewAirSante;
        private System.Windows.Forms.TextBox txtDesignAirSante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdAirSante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bnvFonction;
        private System.Windows.Forms.ToolStripButton btnAddFonction;
        private System.Windows.Forms.ToolStripButton btnRefreshFonction;
        private System.Windows.Forms.ToolStripButton btnSaveFonction;
        private System.Windows.Forms.ToolStripButton btnModifierFonction;
        private System.Windows.Forms.ToolStripButton btnDeleteFonction;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}
