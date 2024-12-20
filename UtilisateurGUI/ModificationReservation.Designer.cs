namespace TheatreGUI
{
    partial class ModificationReservation
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

        private void InitializeComponent()
        {
            this.lblTitreForm = new System.Windows.Forms.Label();
            this.lblNbPlace = new System.Windows.Forms.Label();
            this.lblRepresentation = new System.Windows.Forms.Label();
            this.cboRepresentation = new System.Windows.Forms.ComboBox();
            this.txtNbPlace = new System.Windows.Forms.TextBox();
            this.lblTarifPersonne = new System.Windows.Forms.Label();
            this.lblTarifTotal = new System.Windows.Forms.Label();
            this.lblPieceDeTheatre = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblPrixPersonneAffichage = new System.Windows.Forms.Label();
            this.lblPrixTotalAffichage = new System.Windows.Forms.Label();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.txtPieceDeTheatre = new System.Windows.Forms.TextBox();
            this.lblClientEnregistrer = new System.Windows.Forms.Label();
            this.cboClientEnregistrer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitreForm
            // 
            this.lblTitreForm.AutoSize = true;
            this.lblTitreForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTitreForm.Location = new System.Drawing.Point(330, 72);
            this.lblTitreForm.Name = "lblTitreForm";
            this.lblTitreForm.Size = new System.Drawing.Size(304, 31);
            this.lblTitreForm.TabIndex = 0;
            this.lblTitreForm.Text = "Modifier une réservation";
            // 
            // lblNbPlace
            // 
            this.lblNbPlace.AutoSize = true;
            this.lblNbPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbPlace.Location = new System.Drawing.Point(486, 215);
            this.lblNbPlace.Name = "lblNbPlace";
            this.lblNbPlace.Size = new System.Drawing.Size(218, 20);
            this.lblNbPlace.TabIndex = 2;
            this.lblNbPlace.Text = "Nombre de places réservées :";
            // 
            // lblRepresentation
            // 
            this.lblRepresentation.AutoSize = true;
            this.lblRepresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRepresentation.Location = new System.Drawing.Point(66, 212);
            this.lblRepresentation.Name = "lblRepresentation";
            this.lblRepresentation.Size = new System.Drawing.Size(127, 20);
            this.lblRepresentation.TabIndex = 3;
            this.lblRepresentation.Text = "Répresentation :";
            // 
            // cboRepresentation
            // 
            this.cboRepresentation.FormattingEnabled = true;
            this.cboRepresentation.Location = new System.Drawing.Point(199, 214);
            this.cboRepresentation.Name = "cboRepresentation";
            this.cboRepresentation.Size = new System.Drawing.Size(269, 21);
            this.cboRepresentation.TabIndex = 7;
            // 
            // txtNbPlace
            // 
            this.txtNbPlace.Location = new System.Drawing.Point(710, 215);
            this.txtNbPlace.Name = "txtNbPlace";
            this.txtNbPlace.Size = new System.Drawing.Size(247, 20);
            this.txtNbPlace.TabIndex = 8;
            // 
            // lblTarifPersonne
            // 
            this.lblTarifPersonne.AutoSize = true;
            this.lblTarifPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTarifPersonne.Location = new System.Drawing.Point(66, 265);
            this.lblTarifPersonne.Name = "lblTarifPersonne";
            this.lblTarifPersonne.Size = new System.Drawing.Size(146, 20);
            this.lblTarifPersonne.TabIndex = 13;
            this.lblTarifPersonne.Text = "Tarif par personne :";
            // 
            // lblTarifTotal
            // 
            this.lblTarifTotal.AutoSize = true;
            this.lblTarifTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTarifTotal.Location = new System.Drawing.Point(66, 297);
            this.lblTarifTotal.Name = "lblTarifTotal";
            this.lblTarifTotal.Size = new System.Drawing.Size(83, 20);
            this.lblTarifTotal.TabIndex = 14;
            this.lblTarifTotal.Text = "Tarif total :";
            // 
            // lblPieceDeTheatre
            // 
            this.lblPieceDeTheatre.AutoSize = true;
            this.lblPieceDeTheatre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPieceDeTheatre.Location = new System.Drawing.Point(66, 174);
            this.lblPieceDeTheatre.Name = "lblPieceDeTheatre";
            this.lblPieceDeTheatre.Size = new System.Drawing.Size(133, 20);
            this.lblPieceDeTheatre.TabIndex = 15;
            this.lblPieceDeTheatre.Text = "Pièce de théâtre :";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnModifier.Location = new System.Drawing.Point(728, 468);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(173, 37);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnRetour.Location = new System.Drawing.Point(34, 468);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(165, 37);
            this.btnRetour.TabIndex = 18;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblPrixPersonneAffichage
            // 
            this.lblPrixPersonneAffichage.AutoSize = true;
            this.lblPrixPersonneAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPrixPersonneAffichage.Location = new System.Drawing.Point(218, 263);
            this.lblPrixPersonneAffichage.Name = "lblPrixPersonneAffichage";
            this.lblPrixPersonneAffichage.Size = new System.Drawing.Size(56, 20);
            this.lblPrixPersonneAffichage.TabIndex = 19;
            this.lblPrixPersonneAffichage.Text = "0 euro";
            // 
            // lblPrixTotalAffichage
            // 
            this.lblPrixTotalAffichage.AutoSize = true;
            this.lblPrixTotalAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPrixTotalAffichage.Location = new System.Drawing.Point(156, 297);
            this.lblPrixTotalAffichage.Name = "lblPrixTotalAffichage";
            this.lblPrixTotalAffichage.Size = new System.Drawing.Size(56, 20);
            this.lblPrixTotalAffichage.TabIndex = 20;
            this.lblPrixTotalAffichage.Text = "0 euro";
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(70, 329);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(142, 29);
            this.btnCalculer.TabIndex = 21;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // txtPieceDeTheatre
            // 
            this.txtPieceDeTheatre.Location = new System.Drawing.Point(199, 174);
            this.txtPieceDeTheatre.Name = "txtPieceDeTheatre";
            this.txtPieceDeTheatre.Size = new System.Drawing.Size(269, 20);
            this.txtPieceDeTheatre.TabIndex = 22;
            // 
            // lblClientEnregistrer
            // 
            this.lblClientEnregistrer.AutoSize = true;
            this.lblClientEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClientEnregistrer.Location = new System.Drawing.Point(486, 177);
            this.lblClientEnregistrer.Name = "lblClientEnregistrer";
            this.lblClientEnregistrer.Size = new System.Drawing.Size(205, 20);
            this.lblClientEnregistrer.TabIndex = 23;
            this.lblClientEnregistrer.Text = "Liste des clients enregistré :";
            // 
            // cboClientEnregistrer
            // 
            this.cboClientEnregistrer.FormattingEnabled = true;
            this.cboClientEnregistrer.Location = new System.Drawing.Point(697, 176);
            this.cboClientEnregistrer.Name = "cboClientEnregistrer";
            this.cboClientEnregistrer.Size = new System.Drawing.Size(260, 21);
            this.cboClientEnregistrer.TabIndex = 24;
            // 
            // ModificationReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 517);
            this.Controls.Add(this.cboClientEnregistrer);
            this.Controls.Add(this.lblClientEnregistrer);
            this.Controls.Add(this.txtPieceDeTheatre);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.lblPrixTotalAffichage);
            this.Controls.Add(this.lblPrixPersonneAffichage);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblPieceDeTheatre);
            this.Controls.Add(this.lblTarifTotal);
            this.Controls.Add(this.lblTarifPersonne);
            this.Controls.Add(this.txtNbPlace);
            this.Controls.Add(this.cboRepresentation);
            this.Controls.Add(this.lblRepresentation);
            this.Controls.Add(this.lblNbPlace);
            this.Controls.Add(this.lblTitreForm);
            this.Name = "ModificationReservation";
            this.Text = "ModificationReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreForm;
        private System.Windows.Forms.Label lblNbPlace;
        private System.Windows.Forms.Label lblRepresentation;
        private System.Windows.Forms.ComboBox cboRepresentation;
        private System.Windows.Forms.TextBox txtNbPlace;
        private System.Windows.Forms.Label lblTarifPersonne;
        private System.Windows.Forms.Label lblTarifTotal;
        private System.Windows.Forms.Label lblPieceDeTheatre;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblPrixPersonneAffichage;
        private System.Windows.Forms.Label lblPrixTotalAffichage;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.TextBox txtPieceDeTheatre;
        private System.Windows.Forms.Label lblClientEnregistrer;
        private System.Windows.Forms.ComboBox cboClientEnregistrer;
    }
}
