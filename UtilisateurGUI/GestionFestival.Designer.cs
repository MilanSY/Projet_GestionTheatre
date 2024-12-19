namespace TheatreGUI
{
    partial class GestionFestival
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
            this.gboFiltres = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblAu = new System.Windows.Forms.Label();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.lblDates = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gboFiltres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gboFiltres
            // 
            this.gboFiltres.Controls.Add(this.btnRechercher);
            this.gboFiltres.Controls.Add(this.lblAu);
            this.gboFiltres.Controls.Add(this.dtpDate2);
            this.gboFiltres.Controls.Add(this.dtpDate1);
            this.gboFiltres.Controls.Add(this.lblDates);
            this.gboFiltres.Location = new System.Drawing.Point(84, 57);
            this.gboFiltres.Name = "gboFiltres";
            this.gboFiltres.Size = new System.Drawing.Size(1063, 63);
            this.gboFiltres.TabIndex = 14;
            this.gboFiltres.TabStop = false;
            this.gboFiltres.Text = "Filtres";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(973, 23);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 46;
            this.btnRechercher.Text = "rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblAu
            // 
            this.lblAu.AutoSize = true;
            this.lblAu.Location = new System.Drawing.Point(297, 28);
            this.lblAu.Name = "lblAu";
            this.lblAu.Size = new System.Drawing.Size(20, 13);
            this.lblAu.TabIndex = 3;
            this.lblAu.Text = "Au";
            // 
            // dtpDate2
            // 
            this.dtpDate2.Location = new System.Drawing.Point(333, 28);
            this.dtpDate2.Name = "dtpDate2";
            this.dtpDate2.Size = new System.Drawing.Size(200, 20);
            this.dtpDate2.TabIndex = 2;
            // 
            // dtpDate1
            // 
            this.dtpDate1.Location = new System.Drawing.Point(82, 28);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(200, 20);
            this.dtpDate1.TabIndex = 1;
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Location = new System.Drawing.Point(20, 28);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(56, 13);
            this.lblDates.TabIndex = 0;
            this.lblDates.Text = "Dates:  du";
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(84, 163);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(120, 32);
            this.btnRetour.TabIndex = 13;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafraichir.Location = new System.Drawing.Point(1027, 163);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(120, 32);
            this.btnRafraichir.TabIndex = 11;
            this.btnRafraichir.Text = "Rafraîchir ⟳";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(84, 201);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1063, 371);
            this.dgv.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTitle.Location = new System.Drawing.Point(411, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 31);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Liste des Informations du festival";
            // 
            // GestionFestival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 591);
            this.Controls.Add(this.gboFiltres);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblTitle);
            this.Name = "GestionFestival";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionFestival";
            this.Load += new System.EventHandler(this.GestionFestival_Load);
            this.gboFiltres.ResumeLayout(false);
            this.gboFiltres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboFiltres;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblAu;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblTitle;
    }
}