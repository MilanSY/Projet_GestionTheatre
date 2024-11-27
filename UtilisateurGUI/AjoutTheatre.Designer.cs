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
            this.cbxAuteur = new System.Windows.Forms.ComboBox();
            this.cbxTheme = new System.Windows.Forms.ComboBox();
            this.cbxPublic = new System.Windows.Forms.ComboBox();
            this.lblErreurNom = new System.Windows.Forms.Label();
            this.lblErreurDuree = new System.Windows.Forms.Label();
            this.lblErreurCompagnie = new System.Windows.Forms.Label();
            this.cbxCompagnie = new System.Windows.Forms.ComboBox();
            this.lblErreurPrix = new System.Windows.Forms.Label();
            this.lblErreurTheme = new System.Windows.Forms.Label();
            this.lblErreurPublic = new System.Windows.Forms.Label();
            this.lblErreurAuteur = new System.Windows.Forms.Label();
            this.lblErreurDescription = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
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
            this.lblTitre.Location = new System.Drawing.Point(178, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(646, 43);
            this.lblTitre.TabIndex = 21;
            this.lblTitre.Text = "Modifier les informations de la pièce de théâtre";
            // 
            // cbxAuteur
            // 
            this.cbxAuteur.FormattingEnabled = true;
            this.cbxAuteur.Location = new System.Drawing.Point(682, 252);
            this.cbxAuteur.Name = "cbxAuteur";
            this.cbxAuteur.Size = new System.Drawing.Size(336, 21);
            this.cbxAuteur.TabIndex = 42;
            // 
            // cbxTheme
            // 
            this.cbxTheme.FormattingEnabled = true;
            this.cbxTheme.Location = new System.Drawing.Point(859, 156);
            this.cbxTheme.Name = "cbxTheme";
            this.cbxTheme.Size = new System.Drawing.Size(159, 21);
            this.cbxTheme.TabIndex = 43;
            // 
            // cbxPublic
            // 
            this.cbxPublic.FormattingEnabled = true;
            this.cbxPublic.Location = new System.Drawing.Point(674, 201);
            this.cbxPublic.Name = "cbxPublic";
            this.cbxPublic.Size = new System.Drawing.Size(344, 21);
            this.cbxPublic.TabIndex = 44;
            // 
            // lblErreurNom
            // 
            this.lblErreurNom.AutoSize = true;
            this.lblErreurNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblErreurNom.ForeColor = System.Drawing.Color.Red;
            this.lblErreurNom.Location = new System.Drawing.Point(27, 120);
            this.lblErreurNom.Name = "lblErreurNom";
            this.lblErreurNom.Size = new System.Drawing.Size(140, 17);
            this.lblErreurNom.TabIndex = 45;
            this.lblErreurNom.Text = "Le nom est incorecte";
            this.lblErreurNom.Visible = false;
            // 
            // lblErreurDuree
            // 
            this.lblErreurDuree.AutoSize = true;
            this.lblErreurDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblErreurDuree.ForeColor = System.Drawing.Color.Red;
            this.lblErreurDuree.Location = new System.Drawing.Point(27, 172);
            this.lblErreurDuree.Name = "lblErreurDuree";
            this.lblErreurDuree.Size = new System.Drawing.Size(150, 17);
            this.lblErreurDuree.TabIndex = 46;
            this.lblErreurDuree.Text = "Le durée est incorecte";
            this.lblErreurDuree.Visible = false;
            // 
            // lblErreurCompagnie
            // 
            this.lblErreurCompagnie.AutoSize = true;
            this.lblErreurCompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblErreurCompagnie.ForeColor = System.Drawing.Color.Red;
            this.lblErreurCompagnie.Location = new System.Drawing.Point(27, 222);
            this.lblErreurCompagnie.Name = "lblErreurCompagnie";
            this.lblErreurCompagnie.Size = new System.Drawing.Size(182, 17);
            this.lblErreurCompagnie.TabIndex = 47;
            this.lblErreurCompagnie.Text = "La compagnie est incorecte";
            this.lblErreurCompagnie.Visible = false;
            // 
            // cbxCompagnie
            // 
            this.cbxCompagnie.FormattingEnabled = true;
            this.cbxCompagnie.Location = new System.Drawing.Point(239, 201);
            this.cbxCompagnie.Name = "cbxCompagnie";
            this.cbxCompagnie.Size = new System.Drawing.Size(244, 21);
            this.cbxCompagnie.TabIndex = 48;
            // 
            // lblErreurPrix
            // 
            this.lblErreurPrix.AutoSize = true;
            this.lblErreurPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblErreurPrix.ForeColor = System.Drawing.Color.Red;
            this.lblErreurPrix.Location = new System.Drawing.Point(523, 120);
            this.lblErreurPrix.Name = "lblErreurPrix";
            this.lblErreurPrix.Size = new System.Drawing.Size(135, 17);
            this.lblErreurPrix.TabIndex = 49;
            this.lblErreurPrix.Text = "Le prix est incorecte";
            this.lblErreurPrix.Visible = false;
            // 
            // lblErreurTheme
            // 
            this.lblErreurTheme.AutoSize = true;
            this.lblErreurTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblErreurTheme.ForeColor = System.Drawing.Color.Red;
            this.lblErreurTheme.Location = new System.Drawing.Point(523, 172);
            this.lblErreurTheme.Name = "lblErreurTheme";
            this.lblErreurTheme.Size = new System.Drawing.Size(135, 17);
            this.lblErreurTheme.TabIndex = 50;
            this.lblErreurTheme.Text = "Le prix est incorecte";
            this.lblErreurTheme.Visible = false;
            // 
            // lblErreurPublic
            // 
            this.lblErreurPublic.AutoSize = true;
            this.lblErreurPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblErreurPublic.ForeColor = System.Drawing.Color.Red;
            this.lblErreurPublic.Location = new System.Drawing.Point(523, 220);
            this.lblErreurPublic.Name = "lblErreurPublic";
            this.lblErreurPublic.Size = new System.Drawing.Size(201, 17);
            this.lblErreurPublic.TabIndex = 51;
            this.lblErreurPublic.Text = "Le type de public est incorecte";
            this.lblErreurPublic.Visible = false;
            // 
            // lblErreurAuteur
            // 
            this.lblErreurAuteur.AutoSize = true;
            this.lblErreurAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblErreurAuteur.ForeColor = System.Drawing.Color.Red;
            this.lblErreurAuteur.Location = new System.Drawing.Point(523, 276);
            this.lblErreurAuteur.Name = "lblErreurAuteur";
            this.lblErreurAuteur.Size = new System.Drawing.Size(145, 17);
            this.lblErreurAuteur.TabIndex = 52;
            this.lblErreurAuteur.Text = "L\'auteur est incorecte";
            this.lblErreurAuteur.Visible = false;
            // 
            // lblErreurDescription
            // 
            this.lblErreurDescription.AutoSize = true;
            this.lblErreurDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblErreurDescription.ForeColor = System.Drawing.Color.Red;
            this.lblErreurDescription.Location = new System.Drawing.Point(32, 370);
            this.lblErreurDescription.Name = "lblErreurDescription";
            this.lblErreurDescription.Size = new System.Drawing.Size(145, 17);
            this.lblErreurDescription.TabIndex = 53;
            this.lblErreurDescription.Text = "L\'auteur est incorecte";
            this.lblErreurDescription.Visible = false;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblResultat.ForeColor = System.Drawing.Color.Red;
            this.lblResultat.Location = new System.Drawing.Point(523, 350);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(60, 17);
            this.lblResultat.TabIndex = 54;
            this.lblResultat.Text = "Resultat";
            this.lblResultat.Visible = false;
            // 
            // AjoutTheatre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblErreurDescription);
            this.Controls.Add(this.lblErreurAuteur);
            this.Controls.Add(this.cbxAuteur);
            this.Controls.Add(this.cbxTheme);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.cbxCompagnie);
            this.Controls.Add(this.cbxPublic);
            this.Controls.Add(this.lblErreurPublic);
            this.Controls.Add(this.lblErreurTheme);
            this.Controls.Add(this.lblErreurPrix);
            this.Controls.Add(this.lblErreurCompagnie);
            this.Controls.Add(this.lblErreurDuree);
            this.Controls.Add(this.lblErreurNom);
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
        private System.Windows.Forms.ComboBox cbxAuteur;
        private System.Windows.Forms.ComboBox cbxTheme;
        private System.Windows.Forms.ComboBox cbxPublic;
        private System.Windows.Forms.Label lblErreurNom;
        private System.Windows.Forms.Label lblErreurDuree;
        private System.Windows.Forms.Label lblErreurCompagnie;
        private System.Windows.Forms.ComboBox cbxCompagnie;
        private System.Windows.Forms.Label lblErreurPrix;
        private System.Windows.Forms.Label lblErreurTheme;
        private System.Windows.Forms.Label lblErreurPublic;
        private System.Windows.Forms.Label lblErreurAuteur;
        private System.Windows.Forms.Label lblErreurDescription;
        private System.Windows.Forms.Label lblResultat;
    }
}