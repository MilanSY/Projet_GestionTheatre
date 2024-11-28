namespace TheatreGUI
{
    partial class AjoutRepresentation
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
            this.lblTarif = new System.Windows.Forms.Label();
            this.cboTarif = new System.Windows.Forms.ComboBox();
            this.lblPiece = new System.Windows.Forms.Label();
            this.cboPiece = new System.Windows.Forms.ComboBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.txtHeure = new System.Windows.Forms.TextBox();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(57, 433);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(110, 44);
            this.btnRetour.TabIndex = 69;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnAjouter.Location = new System.Drawing.Point(669, 406);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(211, 71);
            this.btnAjouter.TabIndex = 68;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarif.Location = new System.Drawing.Point(53, 299);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(126, 20);
            this.lblTarif.TabIndex = 67;
            this.lblTarif.Text = "Tarif à appliquer:";
            // 
            // cboTarif
            // 
            this.cboTarif.FormattingEnabled = true;
            this.cboTarif.Location = new System.Drawing.Point(57, 322);
            this.cboTarif.Name = "cboTarif";
            this.cboTarif.Size = new System.Drawing.Size(383, 21);
            this.cboTarif.TabIndex = 66;
            // 
            // lblPiece
            // 
            this.lblPiece.AutoSize = true;
            this.lblPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiece.Location = new System.Drawing.Point(53, 241);
            this.lblPiece.Name = "lblPiece";
            this.lblPiece.Size = new System.Drawing.Size(95, 20);
            this.lblPiece.TabIndex = 65;
            this.lblPiece.Text = "Piece jouée:";
            // 
            // cboPiece
            // 
            this.cboPiece.FormattingEnabled = true;
            this.cboPiece.Location = new System.Drawing.Point(57, 264);
            this.cboPiece.Name = "cboPiece";
            this.cboPiece.Size = new System.Drawing.Size(383, 21);
            this.cboPiece.TabIndex = 64;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(57, 204);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(383, 20);
            this.txtPlace.TabIndex = 63;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(53, 181);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(343, 20);
            this.lblPlace.TabIndex = 62;
            this.lblPlace.Text = "Nombre de place miximum de la représentation:";
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(57, 146);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(383, 20);
            this.txtLieu.TabIndex = 61;
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLieu.Location = new System.Drawing.Point(53, 120);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(188, 20);
            this.lblLieu.TabIndex = 60;
            this.lblLieu.Text = "Lieu de la représentation:";
            // 
            // txtHeure
            // 
            this.txtHeure.Location = new System.Drawing.Point(497, 146);
            this.txtHeure.Name = "txtHeure";
            this.txtHeure.Size = new System.Drawing.Size(383, 20);
            this.txtHeure.TabIndex = 52;
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeure.Location = new System.Drawing.Point(493, 120);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(202, 20);
            this.lblHeure.TabIndex = 51;
            this.lblHeure.Text = "Heure de la représentation:";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(305, 42);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(333, 31);
            this.lblTitre.TabIndex = 50;
            this.lblTitre.Text = "Ajouter une représentation";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(497, 204);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(383, 20);
            this.dtpDate.TabIndex = 71;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(493, 181);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(193, 20);
            this.lblDate.TabIndex = 70;
            this.lblDate.Text = "Date de la représentation:";
            // 
            // AjoutRepresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 517);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.cboTarif);
            this.Controls.Add(this.lblPiece);
            this.Controls.Add(this.cboPiece);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.txtHeure);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.lblTitre);
            this.Name = "AjoutRepresentation";
            this.Text = "AjoutRepresentation";
            this.Load += new System.EventHandler(this.AjoutRepresentation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.ComboBox cboTarif;
        private System.Windows.Forms.Label lblPiece;
        private System.Windows.Forms.ComboBox cboPiece;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.TextBox txtHeure;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
    }
}