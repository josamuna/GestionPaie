namespace DesignClinic
{
    partial class FonctionUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FonctionUserControl));
            this.txtDesignFontion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdFontion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewFonction = new System.Windows.Forms.ListView();
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
            // txtDesignFontion
            // 
            this.txtDesignFontion.Location = new System.Drawing.Point(80, 76);
            this.txtDesignFontion.Name = "txtDesignFontion";
            this.txtDesignFontion.Size = new System.Drawing.Size(157, 20);
            this.txtDesignFontion.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Désignation:";
            // 
            // txtIdFontion
            // 
            this.txtIdFontion.Location = new System.Drawing.Point(80, 50);
            this.txtIdFontion.Name = "txtIdFontion";
            this.txtIdFontion.Size = new System.Drawing.Size(68, 20);
            this.txtIdFontion.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id:";
            // 
            // lstViewFonction
            // 
            this.lstViewFonction.Location = new System.Drawing.Point(244, 32);
            this.lstViewFonction.Name = "lstViewFonction";
            this.lstViewFonction.Size = new System.Drawing.Size(264, 89);
            this.lstViewFonction.TabIndex = 39;
            this.lstViewFonction.UseCompatibleStateImageBehavior = false;
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
            this.bnvFonction.Size = new System.Drawing.Size(518, 25);
            this.bnvFonction.TabIndex = 54;
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
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FonctionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::DesignClinic.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lstViewFonction);
            this.Controls.Add(this.txtDesignFontion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdFontion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnvFonction);
            this.DoubleBuffered = true;
            this.Name = "FonctionUserControl";
            this.Size = new System.Drawing.Size(518, 132);
            ((System.ComponentModel.ISupportInitialize)(this.bnvFonction)).EndInit();
            this.bnvFonction.ResumeLayout(false);
            this.bnvFonction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesignFontion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdFontion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstViewFonction;
        private System.Windows.Forms.BindingNavigator bnvFonction;
        private System.Windows.Forms.ToolStripButton btnRefreshFonction;
        private System.Windows.Forms.ToolStripButton btnSaveFonction;
        private System.Windows.Forms.ToolStripButton btnModifierFonction;
        private System.Windows.Forms.ToolStripButton btnDeleteFonction;
        private System.Windows.Forms.ToolStripButton btnAddFonction;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
