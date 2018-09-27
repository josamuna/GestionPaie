namespace DesignClinic
{
    partial class CategorieMalade
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorieMalade));
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnModifier = new System.Windows.Forms.ToolStripButton();
            this.txtTaux = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesignCategorieMalade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCategorieMalade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnvCateg = new System.Windows.Forms.BindingNavigator(this.components);
            this.lstViewCategorieMalade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bnvCateg)).BeginInit();
            this.bnvCateg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstViewCategorieMalade)).BeginInit();
            this.SuspendLayout();
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
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::DesignClinic.Properties.Resources.navBarAddIcon_2x;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.Click += new System.EventHandler(this.btnAddCateg_Click);
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
            // txtTaux
            // 
            this.txtTaux.Location = new System.Drawing.Point(82, 62);
            this.txtTaux.Name = "txtTaux";
            this.txtTaux.Size = new System.Drawing.Size(68, 20);
            this.txtTaux.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(10, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Taux :";
            // 
            // txtDesignCategorieMalade
            // 
            this.txtDesignCategorieMalade.Location = new System.Drawing.Point(82, 88);
            this.txtDesignCategorieMalade.Name = "txtDesignCategorieMalade";
            this.txtDesignCategorieMalade.Size = new System.Drawing.Size(157, 20);
            this.txtDesignCategorieMalade.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Désignation:";
            // 
            // txtIdCategorieMalade
            // 
            this.txtIdCategorieMalade.Location = new System.Drawing.Point(82, 36);
            this.txtIdCategorieMalade.Name = "txtIdCategorieMalade";
            this.txtIdCategorieMalade.Size = new System.Drawing.Size(68, 20);
            this.txtIdCategorieMalade.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Id:";
            // 
            // bnvCateg
            // 
            this.bnvCateg.AddNewItem = null;
            this.bnvCateg.BackColor = System.Drawing.Color.Transparent;
            this.bnvCateg.CountItem = null;
            this.bnvCateg.DeleteItem = null;
            this.bnvCateg.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnvCateg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnRefresh,
            this.btnSave,
            this.btnModifier,
            this.btnDelete});
            this.bnvCateg.Location = new System.Drawing.Point(0, 0);
            this.bnvCateg.MoveFirstItem = null;
            this.bnvCateg.MoveLastItem = null;
            this.bnvCateg.MoveNextItem = null;
            this.bnvCateg.MovePreviousItem = null;
            this.bnvCateg.Name = "bnvCateg";
            this.bnvCateg.PositionItem = null;
            this.bnvCateg.Size = new System.Drawing.Size(518, 25);
            this.bnvCateg.TabIndex = 62;
            this.bnvCateg.Text = "bindingNavigator1";
            // 
            // lstViewCategorieMalade
            // 
            this.lstViewCategorieMalade.BackgroundColor = System.Drawing.Color.White;
            this.lstViewCategorieMalade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstViewCategorieMalade.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.lstViewCategorieMalade.Location = new System.Drawing.Point(245, 17);
            this.lstViewCategorieMalade.Name = "lstViewCategorieMalade";
            this.lstViewCategorieMalade.Size = new System.Drawing.Size(264, 90);
            this.lstViewCategorieMalade.TabIndex = 63;
            this.lstViewCategorieMalade.SelectionChanged += new System.EventHandler(this.lstViewCategorieMalade_SelectionChanged);
            // 
            // CategorieMalade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 114);
            this.Controls.Add(this.lstViewCategorieMalade);
            this.Controls.Add(this.txtTaux);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesignCategorieMalade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCategorieMalade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnvCateg);
            this.Name = "CategorieMalade";
            this.Text = "CategorieMalade";
            this.Load += new System.EventHandler(this.CategorieMalade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvCateg)).EndInit();
            this.bnvCateg.ResumeLayout(false);
            this.bnvCateg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstViewCategorieMalade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnModifier;
        private System.Windows.Forms.TextBox txtTaux;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesignCategorieMalade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCategorieMalade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bnvCateg;
        private System.Windows.Forms.DataGridView lstViewCategorieMalade;
    }
}