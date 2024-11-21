namespace TheatreGUI
{
    partial class Connexion
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.LblMessageNom = new System.Windows.Forms.Label();
            this.LblMotDePasse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(319, 60);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(143, 31);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Connexion";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(63, 137);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(200, 31);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Nom Utilisateur";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(63, 237);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(184, 31);
            this.lblMDP.TabIndex = 2;
            this.lblMDP.Text = "Mot De Passe";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Info;
            this.txtLogin.Location = new System.Drawing.Point(284, 134);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(244, 38);
            this.txtLogin.TabIndex = 3;
            // 
            // txtMDP
            // 
            this.txtMDP.BackColor = System.Drawing.SystemColors.Info;
            this.txtMDP.Location = new System.Drawing.Point(284, 234);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.PasswordChar = '*';
            this.txtMDP.Size = new System.Drawing.Size(244, 38);
            this.txtMDP.TabIndex = 4;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(284, 329);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(244, 55);
            this.btnConnexion.TabIndex = 5;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // LblMessageNom
            // 
            this.LblMessageNom.AutoSize = true;
            this.LblMessageNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessageNom.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblMessageNom.Location = new System.Drawing.Point(281, 188);
            this.LblMessageNom.Name = "LblMessageNom";
            this.LblMessageNom.Size = new System.Drawing.Size(160, 16);
            this.LblMessageNom.TabIndex = 6;
            this.LblMessageNom.Text = "Nom d\'utilisateur incorrect";
            this.LblMessageNom.Visible = false;
           
            // 
            // LblMotDePasse
            // 
            this.LblMotDePasse.AutoSize = true;
            this.LblMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMotDePasse.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblMotDePasse.Location = new System.Drawing.Point(281, 288);
            this.LblMotDePasse.Name = "LblMotDePasse";
            this.LblMotDePasse.Size = new System.Drawing.Size(143, 16);
            this.LblMotDePasse.TabIndex = 7;
            this.LblMotDePasse.Text = "Mot de passe incorrect";
            this.LblMotDePasse.Visible = false;
          
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMotDePasse);
            this.Controls.Add(this.LblMessageNom);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblTitre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label LblMessageNom;
        private System.Windows.Forms.Label LblMotDePasse;
    }
}