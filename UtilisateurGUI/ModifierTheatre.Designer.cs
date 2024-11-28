namespace TheatreGUI
{
    partial class ModifierTheatre
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
            this.lblTitreModifTheatre = new System.Windows.Forms.Label();
            this.lblNomPieceeTheatre = new System.Windows.Forms.Label();
            this.txtNomPieceDeTheatre = new System.Windows.Forms.TextBox();
            this.txtDureePieceDeTheatre = new System.Windows.Forms.TextBox();
            this.lblDureePieceDeTheatre = new System.Windows.Forms.Label();
            this.txtPrixPieceDeTheatre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompagnie = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.cboCompagnie = new System.Windows.Forms.ComboBox();
            this.cboAuteur = new System.Windows.Forms.ComboBox();
            this.cboTheme = new System.Windows.Forms.ComboBox();
            this.cboPublic = new System.Windows.Forms.ComboBox();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblPublic = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitreModifTheatre
            // 
            this.lblTitreModifTheatre.Font = new System.Drawing.Font("Arial Narrow", 27.75F);
            this.lblTitreModifTheatre.Location = new System.Drawing.Point(190, 51);
            this.lblTitreModifTheatre.Name = "lblTitreModifTheatre";
            this.lblTitreModifTheatre.Size = new System.Drawing.Size(646, 43);
            this.lblTitreModifTheatre.TabIndex = 0;
            this.lblTitreModifTheatre.Text = "Modifier les informations de la pièce de théâtre";
            // 
            // lblNomPieceeTheatre
            // 
            this.lblNomPieceeTheatre.AutoSize = true;
            this.lblNomPieceeTheatre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNomPieceeTheatre.Location = new System.Drawing.Point(38, 138);
            this.lblNomPieceeTheatre.Name = "lblNomPieceeTheatre";
            this.lblNomPieceeTheatre.Size = new System.Drawing.Size(248, 24);
            this.lblNomPieceeTheatre.TabIndex = 1;
            this.lblNomPieceeTheatre.Text = "Nom de la pièce de théâtre :";
            // 
            // txtNomPieceDeTheatre
            // 
            this.txtNomPieceDeTheatre.Location = new System.Drawing.Point(292, 142);
            this.txtNomPieceDeTheatre.Name = "txtNomPieceDeTheatre";
            this.txtNomPieceDeTheatre.Size = new System.Drawing.Size(203, 20);
            this.txtNomPieceDeTheatre.TabIndex = 2;
            // 
            // txtDureePieceDeTheatre
            // 
            this.txtDureePieceDeTheatre.Location = new System.Drawing.Point(415, 200);
            this.txtDureePieceDeTheatre.Name = "txtDureePieceDeTheatre";
            this.txtDureePieceDeTheatre.Size = new System.Drawing.Size(80, 20);
            this.txtDureePieceDeTheatre.TabIndex = 4;
            // 
            // lblDureePieceDeTheatre
            // 
            this.lblDureePieceDeTheatre.AutoSize = true;
            this.lblDureePieceDeTheatre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDureePieceDeTheatre.Location = new System.Drawing.Point(38, 195);
            this.lblDureePieceDeTheatre.Name = "lblDureePieceDeTheatre";
            this.lblDureePieceDeTheatre.Size = new System.Drawing.Size(369, 24);
            this.lblDureePieceDeTheatre.TabIndex = 3;
            this.lblDureePieceDeTheatre.Text = "Durée de la pièce de théâtre (en minutes) :";
            // 
            // txtPrixPieceDeTheatre
            // 
            this.txtPrixPieceDeTheatre.Location = new System.Drawing.Point(871, 147);
            this.txtPrixPieceDeTheatre.Name = "txtPrixPieceDeTheatre";
            this.txtPrixPieceDeTheatre.Size = new System.Drawing.Size(159, 20);
            this.txtPrixPieceDeTheatre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(534, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prix de la pièce de théâtre (en euros) :";
            // 
            // lblCompagnie
            // 
            this.lblCompagnie.AutoSize = true;
            this.lblCompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCompagnie.Location = new System.Drawing.Point(38, 240);
            this.lblCompagnie.Name = "lblCompagnie";
            this.lblCompagnie.Size = new System.Drawing.Size(207, 24);
            this.lblCompagnie.TabIndex = 9;
            this.lblCompagnie.Text = "Nom de la compagnie :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(158, 294);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(337, 125);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(38, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Description :";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnModifier.Location = new System.Drawing.Point(825, 348);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(205, 71);
            this.btnModifier.TabIndex = 19;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            this.btnModifier.Validating += new System.ComponentModel.CancelEventHandler(this.btnModifier_Validating);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(42, 443);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(110, 44);
            this.btnRetour.TabIndex = 20;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // cboCompagnie
            // 
            this.cboCompagnie.FormattingEnabled = true;
            this.cboCompagnie.Location = new System.Drawing.Point(251, 243);
            this.cboCompagnie.Name = "cboCompagnie";
            this.cboCompagnie.Size = new System.Drawing.Size(244, 21);
            this.cboCompagnie.TabIndex = 49;
            // 
            // cboAuteur
            // 
            this.cboAuteur.FormattingEnabled = true;
            this.cboAuteur.Location = new System.Drawing.Point(694, 294);
            this.cboAuteur.Name = "cboAuteur";
            this.cboAuteur.Size = new System.Drawing.Size(336, 21);
            this.cboAuteur.TabIndex = 55;
            // 
            // cboTheme
            // 
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Location = new System.Drawing.Point(871, 198);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(159, 21);
            this.cboTheme.TabIndex = 56;
            // 
            // cboPublic
            // 
            this.cboPublic.FormattingEnabled = true;
            this.cboPublic.Location = new System.Drawing.Point(686, 243);
            this.cboPublic.Name = "cboPublic";
            this.cboPublic.Size = new System.Drawing.Size(344, 21);
            this.cboPublic.TabIndex = 57;
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAuteur.Location = new System.Drawing.Point(534, 291);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(154, 24);
            this.lblAuteur.TabIndex = 54;
            this.lblAuteur.Text = "Nom de l\'auteur :";
            // 
            // lblPublic
            // 
            this.lblPublic.AutoSize = true;
            this.lblPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPublic.Location = new System.Drawing.Point(534, 238);
            this.lblPublic.Name = "lblPublic";
            this.lblPublic.Size = new System.Drawing.Size(146, 24);
            this.lblPublic.TabIndex = 53;
            this.lblPublic.Text = "Type de public :";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTheme.Location = new System.Drawing.Point(534, 195);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(333, 24);
            this.lblTheme.TabIndex = 52;
            this.lblTheme.Text = "Nom du thème de la pièce de théâtre :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModifierTheatre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1075, 516);
            this.Controls.Add(this.cboAuteur);
            this.Controls.Add(this.cboTheme);
            this.Controls.Add(this.cboPublic);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblPublic);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.cboCompagnie);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCompagnie);
            this.Controls.Add(this.txtPrixPieceDeTheatre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDureePieceDeTheatre);
            this.Controls.Add(this.lblDureePieceDeTheatre);
            this.Controls.Add(this.txtNomPieceDeTheatre);
            this.Controls.Add(this.lblNomPieceeTheatre);
            this.Controls.Add(this.lblTitreModifTheatre);
            this.Name = "ModifierTheatre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierTheatre";
            this.Load += new System.EventHandler(this.ModifierTheatre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreModifTheatre;
        private System.Windows.Forms.Label lblNomPieceeTheatre;
        private System.Windows.Forms.TextBox txtNomPieceDeTheatre;
        private System.Windows.Forms.TextBox txtDureePieceDeTheatre;
        private System.Windows.Forms.Label lblDureePieceDeTheatre;
        private System.Windows.Forms.TextBox txtPrixPieceDeTheatre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCompagnie;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboCompagnie;
        private System.Windows.Forms.ComboBox cboAuteur;
        private System.Windows.Forms.ComboBox cboTheme;
        private System.Windows.Forms.ComboBox cboPublic;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblPublic;
        private System.Windows.Forms.Label lblTheme;
    }
}