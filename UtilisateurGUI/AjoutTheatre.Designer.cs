namespace TheatreGUI
{
    partial class AjoutTheatre
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblPublic = new System.Windows.Forms.Label();
            this.lblCompagnie = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.lblDuree = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cboTheme = new System.Windows.Forms.ComboBox();
            this.cboPublic = new System.Windows.Forms.ComboBox();
            this.cboCompagnie = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboAuteur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(30, 401);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(110, 44);
            this.btnRetour.TabIndex = 41;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnAjouter.Location = new System.Drawing.Point(807, 296);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(211, 71);
            this.btnAjouter.TabIndex = 40;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDescription.Location = new System.Drawing.Point(26, 247);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(114, 24);
            this.lblDescription.TabIndex = 39;
            this.lblDescription.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(146, 252);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(337, 115);
            this.txtDescription.TabIndex = 38;
            this.txtDescription.Text = "";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAuteur.Location = new System.Drawing.Point(522, 249);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(154, 24);
            this.lblAuteur.TabIndex = 34;
            this.lblAuteur.Text = "Nom de l\'auteur :";
            // 
            // lblPublic
            // 
            this.lblPublic.AutoSize = true;
            this.lblPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPublic.Location = new System.Drawing.Point(522, 196);
            this.lblPublic.Name = "lblPublic";
            this.lblPublic.Size = new System.Drawing.Size(146, 24);
            this.lblPublic.TabIndex = 32;
            this.lblPublic.Text = "Type de public :";
            // 
            // lblCompagnie
            // 
            this.lblCompagnie.AutoSize = true;
            this.lblCompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCompagnie.Location = new System.Drawing.Point(26, 198);
            this.lblCompagnie.Name = "lblCompagnie";
            this.lblCompagnie.Size = new System.Drawing.Size(207, 24);
            this.lblCompagnie.TabIndex = 30;
            this.lblCompagnie.Text = "Nom de la compagnie :";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTheme.Location = new System.Drawing.Point(522, 153);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(333, 24);
            this.lblTheme.TabIndex = 28;
            this.lblTheme.Text = "Nom du thème de la pièce de théâtre :";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(859, 105);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(159, 20);
            this.txtPrix.TabIndex = 27;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPrix.Location = new System.Drawing.Point(522, 100);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(331, 24);
            this.lblPrix.TabIndex = 26;
            this.lblPrix.Text = "Prix de la pièce de théâtre (en euros) :";
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(403, 153);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(80, 20);
            this.txtDuree.TabIndex = 25;
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDuree.Location = new System.Drawing.Point(26, 148);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(369, 24);
            this.lblDuree.TabIndex = 24;
            this.lblDuree.Text = "Durée de la pièce de théâtre (en minutes) :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(280, 100);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(203, 20);
            this.txtNom.TabIndex = 23;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNom.Location = new System.Drawing.Point(26, 96);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(248, 24);
            this.lblNom.TabIndex = 22;
            this.lblNom.Text = "Nom de la pièce de théâtre :";
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Arial Narrow", 27.75F);
            this.lblTitre.Location = new System.Drawing.Point(331, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(405, 43);
            this.lblTitre.TabIndex = 21;
            this.lblTitre.Text = "Ajouter une pièce de théâtre";
            // 
            // cboTheme
            // 
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Location = new System.Drawing.Point(859, 156);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(159, 21);
            this.cboTheme.TabIndex = 43;
            // 
            // cboPublic
            // 
            this.cboPublic.FormattingEnabled = true;
            this.cboPublic.Location = new System.Drawing.Point(674, 201);
            this.cboPublic.Name = "cboPublic";
            this.cboPublic.Size = new System.Drawing.Size(344, 21);
            this.cboPublic.TabIndex = 44;
            // 
            // cboCompagnie
            // 
            this.cboCompagnie.FormattingEnabled = true;
            this.cboCompagnie.Location = new System.Drawing.Point(239, 201);
            this.cboCompagnie.Name = "cboCompagnie";
            this.cboCompagnie.Size = new System.Drawing.Size(244, 21);
            this.cboCompagnie.TabIndex = 48;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cboAuteur
            // 
            this.cboAuteur.FormattingEnabled = true;
            this.cboAuteur.Location = new System.Drawing.Point(682, 252);
            this.cboAuteur.Name = "cboAuteur";
            this.cboAuteur.Size = new System.Drawing.Size(336, 21);
            this.cboAuteur.TabIndex = 42;
            // 
            // AjoutTheatre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cboAuteur);
            this.Controls.Add(this.cboTheme);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.cboCompagnie);
            this.Controls.Add(this.cboPublic);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblPublic);
            this.Controls.Add(this.lblCompagnie);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTitre);
            this.Name = "AjoutTheatre";
            this.Text = "AjoutTheatre";
            this.Load += new System.EventHandler(this.AjoutTheatre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblPublic;
        private System.Windows.Forms.Label lblCompagnie;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cboTheme;
        private System.Windows.Forms.ComboBox cboPublic;
        private System.Windows.Forms.ComboBox cboCompagnie;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboAuteur;
    }
}