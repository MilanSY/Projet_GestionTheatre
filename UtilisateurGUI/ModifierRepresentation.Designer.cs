namespace TheatreGUI
{
    partial class ModifierRepresentation
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.txtHeure = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.cboPiece = new System.Windows.Forms.ComboBox();
            this.lblPiece = new System.Windows.Forms.Label();
            this.lblTarif = new System.Windows.Forms.Label();
            this.cboTarif = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(302, 24);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(319, 31);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Modifier la représentation";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeure.Location = new System.Drawing.Point(474, 89);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(202, 20);
            this.lblHeure.TabIndex = 1;
            this.lblHeure.Text = "Heure de la représentation:";
            // 
            // txtHeure
            // 
            this.txtHeure.Location = new System.Drawing.Point(478, 115);
            this.txtHeure.Name = "txtHeure";
            this.txtHeure.Size = new System.Drawing.Size(383, 20);
            this.txtHeure.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(474, 150);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(193, 20);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date de la représentation:";
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(38, 115);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(383, 20);
            this.txtLieu.TabIndex = 11;
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLieu.Location = new System.Drawing.Point(34, 89);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(188, 20);
            this.lblLieu.TabIndex = 10;
            this.lblLieu.Text = "Lieu de la représentation:";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(38, 173);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(383, 20);
            this.txtPlace.TabIndex = 13;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(34, 150);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(343, 20);
            this.lblPlace.TabIndex = 12;
            this.lblPlace.Text = "Nombre de place miximum de la représentation:";
            // 
            // cboPiece
            // 
            this.cboPiece.FormattingEnabled = true;
            this.cboPiece.Location = new System.Drawing.Point(38, 233);
            this.cboPiece.Name = "cboPiece";
            this.cboPiece.Size = new System.Drawing.Size(383, 21);
            this.cboPiece.TabIndex = 44;
            // 
            // lblPiece
            // 
            this.lblPiece.AutoSize = true;
            this.lblPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiece.Location = new System.Drawing.Point(34, 210);
            this.lblPiece.Name = "lblPiece";
            this.lblPiece.Size = new System.Drawing.Size(95, 20);
            this.lblPiece.TabIndex = 45;
            this.lblPiece.Text = "Piece jouée:";
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarif.Location = new System.Drawing.Point(34, 268);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(126, 20);
            this.lblTarif.TabIndex = 47;
            this.lblTarif.Text = "Tarif à appliquer:";
            // 
            // cboTarif
            // 
            this.cboTarif.FormattingEnabled = true;
            this.cboTarif.Location = new System.Drawing.Point(38, 291);
            this.cboTarif.Name = "cboTarif";
            this.cboTarif.Size = new System.Drawing.Size(383, 21);
            this.cboTarif.TabIndex = 46;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnModifier.Location = new System.Drawing.Point(650, 375);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(211, 71);
            this.btnModifier.TabIndex = 48;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(38, 402);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(110, 44);
            this.btnRetour.TabIndex = 49;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(478, 173);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(383, 20);
            this.dtpDate.TabIndex = 50;
            // 
            // ModifierRepresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 504);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.cboTarif);
            this.Controls.Add(this.lblPiece);
            this.Controls.Add(this.cboPiece);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtHeure);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.lblTitre);
            this.Name = "ModifierRepresentation";
            this.Text = "ModifierRepresentation";
            this.Load += new System.EventHandler(this.ModifierRepresentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.TextBox txtHeure;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.ComboBox cboPiece;
        private System.Windows.Forms.Label lblPiece;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.ComboBox cboTarif;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}