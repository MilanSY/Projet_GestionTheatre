namespace TheatreGUI
{
    partial class GestionRepresentation
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
            this.lblTitleRepresentation = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.gboFiltres = new System.Windows.Forms.GroupBox();
            this.ckbDates = new System.Windows.Forms.CheckBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.cboPiece = new System.Windows.Forms.ComboBox();
            this.lblPiece = new System.Windows.Forms.Label();
            this.lblAu = new System.Windows.Forms.Label();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.lblDates = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gboFiltres.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleRepresentation
            // 
            this.lblTitleRepresentation.AutoSize = true;
            this.lblTitleRepresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTitleRepresentation.Location = new System.Drawing.Point(231, 9);
            this.lblTitleRepresentation.Name = "lblTitleRepresentation";
            this.lblTitleRepresentation.Size = new System.Drawing.Size(598, 31);
            this.lblTitleRepresentation.TabIndex = 0;
            this.lblTitleRepresentation.Text = "Liste des représentations des pièces de théâtres";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(26, 201);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1063, 371);
            this.dgv.TabIndex = 1;
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafraichir.Location = new System.Drawing.Point(843, 163);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(120, 32);
            this.btnRafraichir.TabIndex = 5;
            this.btnRafraichir.Text = "Rafraîchir ⟳";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(969, 163);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(120, 32);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(26, 163);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(120, 32);
            this.btnRetour.TabIndex = 7;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // gboFiltres
            // 
            this.gboFiltres.Controls.Add(this.ckbDates);
            this.gboFiltres.Controls.Add(this.btnRechercher);
            this.gboFiltres.Controls.Add(this.cboPiece);
            this.gboFiltres.Controls.Add(this.lblPiece);
            this.gboFiltres.Controls.Add(this.lblAu);
            this.gboFiltres.Controls.Add(this.dtpDate2);
            this.gboFiltres.Controls.Add(this.dtpDate1);
            this.gboFiltres.Controls.Add(this.lblDates);
            this.gboFiltres.Location = new System.Drawing.Point(26, 57);
            this.gboFiltres.Name = "gboFiltres";
            this.gboFiltres.Size = new System.Drawing.Size(1063, 89);
            this.gboFiltres.TabIndex = 8;
            this.gboFiltres.TabStop = false;
            this.gboFiltres.Text = "Filtres";
            // 
            // ckbDates
            // 
            this.ckbDates.AutoSize = true;
            this.ckbDates.Location = new System.Drawing.Point(20, 59);
            this.ckbDates.Name = "ckbDates";
            this.ckbDates.Size = new System.Drawing.Size(149, 17);
            this.ckbDates.TabIndex = 47;
            this.ckbDates.Text = "Recherche sans les dates";
            this.ckbDates.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(982, 36);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 46;
            this.btnRechercher.Text = "rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // cboPiece
            // 
            this.cboPiece.FormattingEnabled = true;
            this.cboPiece.Location = new System.Drawing.Point(629, 36);
            this.cboPiece.Name = "cboPiece";
            this.cboPiece.Size = new System.Drawing.Size(322, 21);
            this.cboPiece.TabIndex = 45;
            // 
            // lblPiece
            // 
            this.lblPiece.AutoSize = true;
            this.lblPiece.Location = new System.Drawing.Point(557, 34);
            this.lblPiece.Name = "lblPiece";
            this.lblPiece.Size = new System.Drawing.Size(66, 13);
            this.lblPiece.TabIndex = 4;
            this.lblPiece.Text = "Piece jouée:";
            // 
            // lblAu
            // 
            this.lblAu.AutoSize = true;
            this.lblAu.Location = new System.Drawing.Point(294, 34);
            this.lblAu.Name = "lblAu";
            this.lblAu.Size = new System.Drawing.Size(20, 13);
            this.lblAu.TabIndex = 3;
            this.lblAu.Text = "Au";
            // 
            // dtpDate2
            // 
            this.dtpDate2.Location = new System.Drawing.Point(330, 34);
            this.dtpDate2.Name = "dtpDate2";
            this.dtpDate2.Size = new System.Drawing.Size(200, 20);
            this.dtpDate2.TabIndex = 2;
            // 
            // dtpDate1
            // 
            this.dtpDate1.Location = new System.Drawing.Point(79, 34);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(200, 20);
            this.dtpDate1.TabIndex = 1;
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Location = new System.Drawing.Point(17, 34);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(56, 13);
            this.lblDates.TabIndex = 0;
            this.lblDates.Text = "Dates:  du";
            // 
            // GestionRepresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 584);
            this.Controls.Add(this.gboFiltres);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblTitleRepresentation);
            this.Name = "GestionRepresentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionRepresentation";
            this.Load += new System.EventHandler(this.GestionRepresentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gboFiltres.ResumeLayout(false);
            this.gboFiltres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleRepresentation;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.GroupBox gboFiltres;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblAu;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.Label lblPiece;
        private System.Windows.Forms.ComboBox cboPiece;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.CheckBox ckbDates;
    }
}