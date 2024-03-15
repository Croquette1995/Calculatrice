
namespace ApplicationCalculatricePOO
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.btnSomme = new System.Windows.Forms.Button();
            this.btnSoustraction = new System.Windows.Forms.Button();
            this.btnQuotient = new System.Windows.Forms.Button();
            this.btnProduit = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre1
            // 
            this.txtNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre1.ForeColor = System.Drawing.Color.Red;
            this.txtNombre1.Location = new System.Drawing.Point(47, 78);
            this.txtNombre1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(76, 34);
            this.txtNombre1.TabIndex = 1;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre2.ForeColor = System.Drawing.Color.Red;
            this.txtNombre2.Location = new System.Drawing.Point(47, 179);
            this.txtNombre2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(76, 34);
            this.txtNombre2.TabIndex = 2;
            // 
            // btnSomme
            // 
            this.btnSomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomme.Location = new System.Drawing.Point(274, 78);
            this.btnSomme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSomme.Name = "btnSomme";
            this.btnSomme.Size = new System.Drawing.Size(56, 62);
            this.btnSomme.TabIndex = 3;
            this.btnSomme.Text = "+";
            this.btnSomme.UseVisualStyleBackColor = true;
            this.btnSomme.Click += new System.EventHandler(this.btnSomme_Click);
            // 
            // btnSoustraction
            // 
            this.btnSoustraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoustraction.Location = new System.Drawing.Point(335, 78);
            this.btnSoustraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSoustraction.Name = "btnSoustraction";
            this.btnSoustraction.Size = new System.Drawing.Size(56, 62);
            this.btnSoustraction.TabIndex = 4;
            this.btnSoustraction.Text = "-";
            this.btnSoustraction.UseVisualStyleBackColor = true;
            this.btnSoustraction.Click += new System.EventHandler(this.btnSoustraction_Click);
            // 
            // btnQuotient
            // 
            this.btnQuotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuotient.Location = new System.Drawing.Point(274, 145);
            this.btnQuotient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuotient.Name = "btnQuotient";
            this.btnQuotient.Size = new System.Drawing.Size(56, 62);
            this.btnQuotient.TabIndex = 5;
            this.btnQuotient.Text = "/";
            this.btnQuotient.UseVisualStyleBackColor = true;
            this.btnQuotient.Click += new System.EventHandler(this.btnQuotient_Click);
            // 
            // btnProduit
            // 
            this.btnProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduit.Location = new System.Drawing.Point(335, 145);
            this.btnProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(56, 62);
            this.btnProduit.TabIndex = 6;
            this.btnProduit.Text = "*";
            this.btnProduit.UseVisualStyleBackColor = true;
            this.btnProduit.Click += new System.EventHandler(this.btnProduit_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(518, 261);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(73, 29);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Exit";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(518, 295);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 479);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnProduit);
            this.Controls.Add(this.btnQuotient);
            this.Controls.Add(this.btnSoustraction);
            this.Controls.Add(this.btnSomme);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "CalculatricePOO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Button btnSomme;
        private System.Windows.Forms.Button btnSoustraction;
        private System.Windows.Forms.Button btnQuotient;
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnClear;
    }
}

