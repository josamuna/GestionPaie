namespace DesignClinic
{
    partial class Utilisateur
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnValiderUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkInvite = new System.Windows.Forms.RadioButton();
            this.chkAdmin = new System.Windows.Forms.RadioButton();
            this.txtMot_PasseConfirm = new System.Windows.Forms.TextBox();
            this.txtMote_Passe = new System.Windows.Forms.TextBox();
            this.txtNomUse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnModifierCompte = new System.Windows.Forms.Button();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.txtConfirmMot_Passe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNouveauMot_Passe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEncMot_Passe = new System.Windows.Forms.TextBox();
            this.txtNomUserMod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMot_PasseSupUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CboUserSup = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bntAnnuler = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnValiderUser);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtMot_PasseConfirm);
            this.tabPage1.Controls.Add(this.txtMote_Passe);
            this.tabPage1.Controls.Add(this.txtNomUse);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Création des utilisateurs";
            // 
            // btnValiderUser
            // 
            this.btnValiderUser.Location = new System.Drawing.Point(247, 194);
            this.btnValiderUser.Name = "btnValiderUser";
            this.btnValiderUser.Size = new System.Drawing.Size(89, 30);
            this.btnValiderUser.TabIndex = 7;
            this.btnValiderUser.Text = "Valider";
            this.btnValiderUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkInvite);
            this.groupBox1.Controls.Add(this.chkAdmin);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de compte";
            // 
            // chkInvite
            // 
            this.chkInvite.AutoSize = true;
            this.chkInvite.Location = new System.Drawing.Point(236, 32);
            this.chkInvite.Name = "chkInvite";
            this.chkInvite.Size = new System.Drawing.Size(54, 20);
            this.chkInvite.TabIndex = 1;
            this.chkInvite.TabStop = true;
            this.chkInvite.Text = "Invité";
            this.chkInvite.UseVisualStyleBackColor = true;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(28, 32);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(102, 20);
            this.chkAdmin.TabIndex = 0;
            this.chkAdmin.TabStop = true;
            this.chkAdmin.Text = "Administrateur";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // txtMot_PasseConfirm
            // 
            this.txtMot_PasseConfirm.Location = new System.Drawing.Point(157, 76);
            this.txtMot_PasseConfirm.Name = "txtMot_PasseConfirm";
            this.txtMot_PasseConfirm.Size = new System.Drawing.Size(179, 20);
            this.txtMot_PasseConfirm.TabIndex = 5;
            // 
            // txtMote_Passe
            // 
            this.txtMote_Passe.Location = new System.Drawing.Point(157, 50);
            this.txtMote_Passe.Name = "txtMote_Passe";
            this.txtMote_Passe.Size = new System.Drawing.Size(179, 20);
            this.txtMote_Passe.TabIndex = 4;
            // 
            // txtNomUse
            // 
            this.txtNomUse.Location = new System.Drawing.Point(157, 24);
            this.txtNomUse.Name = "txtNomUse";
            this.txtNomUse.Size = new System.Drawing.Size(179, 20);
            this.txtNomUse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confimer Mot de Passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de Passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Utilisateur :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(347, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modification et suppression des utilisateurs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(341, 230);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.btnModifierCompte);
            this.tabPage3.Controls.Add(this.cboUser);
            this.tabPage3.Controls.Add(this.txtConfirmMot_Passe);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtNouveauMot_Passe);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtEncMot_Passe);
            this.tabPage3.Controls.Add(this.txtNomUserMod);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(333, 204);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Modifier un compte";
            // 
            // btnModifierCompte
            // 
            this.btnModifierCompte.Location = new System.Drawing.Point(123, 160);
            this.btnModifierCompte.Name = "btnModifierCompte";
            this.btnModifierCompte.Size = new System.Drawing.Size(75, 26);
            this.btnModifierCompte.TabIndex = 17;
            this.btnModifierCompte.Text = "Modifier";
            this.btnModifierCompte.UseVisualStyleBackColor = true;
            // 
            // cboUser
            // 
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(140, 17);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(185, 21);
            this.cboUser.TabIndex = 16;
            // 
            // txtConfirmMot_Passe
            // 
            this.txtConfirmMot_Passe.Location = new System.Drawing.Point(163, 123);
            this.txtConfirmMot_Passe.Name = "txtConfirmMot_Passe";
            this.txtConfirmMot_Passe.Size = new System.Drawing.Size(162, 20);
            this.txtConfirmMot_Passe.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(7, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Confiormer Mot de Passe :";
            // 
            // txtNouveauMot_Passe
            // 
            this.txtNouveauMot_Passe.Location = new System.Drawing.Point(163, 97);
            this.txtNouveauMot_Passe.Name = "txtNouveauMot_Passe";
            this.txtNouveauMot_Passe.Size = new System.Drawing.Size(162, 20);
            this.txtNouveauMot_Passe.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nouveau Mot de passe :";
            // 
            // txtEncMot_Passe
            // 
            this.txtEncMot_Passe.Location = new System.Drawing.Point(163, 70);
            this.txtEncMot_Passe.Name = "txtEncMot_Passe";
            this.txtEncMot_Passe.Size = new System.Drawing.Size(162, 20);
            this.txtEncMot_Passe.TabIndex = 11;
            // 
            // txtNomUserMod
            // 
            this.txtNomUserMod.Location = new System.Drawing.Point(163, 44);
            this.txtNomUserMod.Name = "txtNomUserMod";
            this.txtNomUserMod.Size = new System.Drawing.Size(162, 20);
            this.txtNomUserMod.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Encien Mot de passe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nom Utilisateur :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Choisir un utilisateur :";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.txtMot_PasseSupUser);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.CboUserSup);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(333, 204);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Suprimmer un Compte";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 21;
            this.button3.Text = "Suprimmer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtMot_PasseSupUser
            // 
            this.txtMot_PasseSupUser.Location = new System.Drawing.Point(146, 92);
            this.txtMot_PasseSupUser.Name = "txtMot_PasseSupUser";
            this.txtMot_PasseSupUser.Size = new System.Drawing.Size(183, 20);
            this.txtMot_PasseSupUser.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Mot de Passe :";
            // 
            // CboUserSup
            // 
            this.CboUserSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboUserSup.FormattingEnabled = true;
            this.CboUserSup.Location = new System.Drawing.Point(142, 57);
            this.CboUserSup.Name = "CboUserSup";
            this.CboUserSup.Size = new System.Drawing.Size(187, 21);
            this.CboUserSup.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Choisir un utilisateur :";
            // 
            // bntAnnuler
            // 
            this.bntAnnuler.Location = new System.Drawing.Point(251, 268);
            this.bntAnnuler.Name = "bntAnnuler";
            this.bntAnnuler.Size = new System.Drawing.Size(89, 27);
            this.bntAnnuler.TabIndex = 1;
            this.bntAnnuler.Text = "Annuler";
            this.bntAnnuler.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(142, 70);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(192, 20);
            this.textBox7.TabIndex = 11;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(142, 44);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(192, 20);
            this.textBox8.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(142, 18);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(192, 20);
            this.textBox9.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Encien Mot de passe :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nom Utilisateur :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Choisir un utilisateur :";
            // 
            // Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 301);
            this.Controls.Add(this.bntAnnuler);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Utilisateur";
            this.Text = "Utilisateur";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntAnnuler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chkInvite;
        private System.Windows.Forms.RadioButton chkAdmin;
        private System.Windows.Forms.TextBox txtMot_PasseConfirm;
        private System.Windows.Forms.TextBox txtMote_Passe;
        private System.Windows.Forms.TextBox txtNomUse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValiderUser;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.TextBox txtConfirmMot_Passe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNouveauMot_Passe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEncMot_Passe;
        private System.Windows.Forms.TextBox txtNomUserMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnModifierCompte;
        private System.Windows.Forms.TextBox txtMot_PasseSupUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CboUserSup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
    }
}