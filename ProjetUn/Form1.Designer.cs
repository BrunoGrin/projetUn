namespace ProjetUn
{
    partial class Windows
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connexion
            // 
            this.Connexion.Location = new System.Drawing.Point(342, 334);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(85, 23);
            this.Connexion.TabIndex = 0;
            this.Connexion.Text = "Connecter";
            this.Connexion.UseVisualStyleBackColor = true;
            this.Connexion.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Connexion);
            this.Name = "Windows";
            this.Text = "Base de donnée";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connexion;
    }
}

