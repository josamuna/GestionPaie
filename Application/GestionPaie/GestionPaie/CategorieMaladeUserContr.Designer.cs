namespace DesignClinic
{
    partial class CategorieMaladeUserContr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorieMaladeUserContr));
            this.lstViewCategorieMalade = new System.Windows.Forms.ListView();
            this.txtDesignCategorieMalade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCategorieMalade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Taux = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bnvCateg = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddCateg = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshCateg = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCateg = new System.Windows.Forms.ToolStripButton();
            this.btnModifierCateg = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCateg = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bnvCateg)).BeginInit();
            this.bnvCateg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstViewCategorieMalade
            // 
            this.lstViewCategorieMalade.Location = new System.Drawing.Point(251, 32);
            this.lstViewCategorieMalade.Name = "lstViewCategorieMalade";
            this.lstViewCategorieMalade.Size = new System.Drawing.Size(264, 89);
            this.lstViewCategorieMalade.TabIndex = 45;
            this.lstViewCategorieMalade.UseCompatibleStateImageBehavior = false;
            // 
            // txtDesignCategorieMalade
            // 
            this.txtDesignCategorieMalade.Location = new System.Drawing.Point(87, 102);
            this.txtDesignCategorieMalade.Name = "txtDesignCategorieMalade";
            this.txtDesignCategorieMalade.Size = new System.Drawing.Size(157, 20);
            this.txtDesignCategorieMalade.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Désignation:";
            // 
            // txtIdCategorieMalade
            // 
            this.txtIdCategorieMalade.Location = new System.Drawing.Point(87, 50);
            this.txtIdCategorieMalade.Name = "txtIdCategorieMalade";
            this.txtIdCategorieMalade.Size = new System.Drawing.Size(68, 20);
            this.txtIdCategorieMalade.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id:";
            // 
            // Taux
            // 
            this.Taux.Location = new System.Drawing.Point(87, 76);
            this.Taux.Name = "Taux";
            this.Taux.Size = new System.Drawing.Size(68, 20);
            this.Taux.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Taux :";
            // 
            // bnvCateg
            // 
            this.bnvCateg.AddNewItem = null;
            this.bnvCateg.BackColor = System.Drawing.Color.Transparent;
            this.bnvCateg.CountItem = null;
            this.bnvCateg.DeleteItem = null;
            this.bnvCateg.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnvCateg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCateg,
            this.btnRefreshCateg,
            this.btnSaveCateg,
            this.btnModifierCateg,
            this.btnDeleteCateg,
            this.toolStripButton1});
            this.bnvCateg.Location = new System.Drawing.Point(0, 0);
            this.bnvCateg.MoveFirstItem = null;
            this.bnvCateg.MoveLastItem = null;
            this.bnvCateg.MoveNextItem = null;
            this.bnvCateg.MovePreviousItem = null;
            this.bnvCateg.Name = "bnvCateg";
            this.bnvCateg.PositionItem = null;
            this.bnvCateg.Size = new System.Drawing.Size(521, 25);
            this.bnvCateg.TabIndex = 54;
            this.bnvCateg.Text = "bindingNavigator1";
            // 
            // btnAddCateg
            // 
            this.btnAddCateg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCateg.Image = global::DesignClinic.Properties.Resources.navBarAddIcon_2x;
            this.btnAddCateg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCateg.Name = "btnAddCateg";
            this.btnAddCateg.Size = new System.Drawing.Size(23, 22);
            this.btnAddCateg.Text = "Ajouter";
            // 
            // btnRefreshCateg
            // 
            this.btnRefreshCateg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshCateg.Image = global::DesignClinic.Properties.Resources.update;
            this.btnRefreshCateg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshCateg.Name = "btnRefreshCateg";
            this.btnRefreshCateg.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshCateg.Text = "Refresh";
            // 
            // btnSaveCateg
            // 
            this.btnSaveCateg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveCateg.Image = global::DesignClinic.Properties.Resources.check_2x;
            this.btnSaveCateg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCateg.Name = "btnSaveCateg";
            this.btnSaveCateg.Size = new System.Drawing.Size(23, 22);
            this.btnSaveCateg.Text = "Enregistrer";
            // 
            // btnModifierCateg
            // 
            this.btnModifierCateg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModifierCateg.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierCateg.Image")));
            this.btnModifierCateg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifierCateg.Name = "btnModifierCateg";
            this.btnModifierCateg.Size = new System.Drawing.Size(23, 22);
            this.btnModifierCateg.Text = "Modifier";
            // 
            // btnDeleteCateg
            // 
            this.btnDeleteCateg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteCateg.Image = global::DesignClinic.Properties.Resources.mp_delete_md_n_lt_2x;
            this.btnDeleteCateg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCateg.Name = "btnDeleteCateg";
            this.btnDeleteCateg.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteCateg.Text = "Supprimer";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DesignClinic.Properties.Resources.Close1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Fermer";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // CategorieMaladeUserContr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::DesignClinic.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Taux);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstViewCategorieMalade);
            this.Controls.Add(this.txtDesignCategorieMalade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCategorieMalade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnvCateg);
            this.DoubleBuffered = true;
            this.Name = "CategorieMaladeUserContr";
            this.Size = new System.Drawing.Size(521, 132);
            ((System.ComponentModel.ISupportInitialize)(this.bnvCateg)).EndInit();
            this.bnvCateg.ResumeLayout(false);
            this.bnvCateg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewCategorieMalade;
        private System.Windows.Forms.TextBox txtDesignCategorieMalade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCategorieMalade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Taux;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingNavigator bnvCateg;
        private System.Windows.Forms.ToolStripButton btnAddCateg;
        private System.Windows.Forms.ToolStripButton btnRefreshCateg;
        private System.Windows.Forms.ToolStripButton btnSaveCateg;
        private System.Windows.Forms.ToolStripButton btnModifierCateg;
        private System.Windows.Forms.ToolStripButton btnDeleteCateg;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
