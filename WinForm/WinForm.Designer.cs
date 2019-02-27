namespace WinForm
{
    partial class WinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.btnCvrtXML2JSon = new System.Windows.Forms.Button();
            this.txtFibonacci = new System.Windows.Forms.TextBox();
            this.txtXML2JSon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFibonacci.Location = new System.Drawing.Point(748, 12);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(262, 82);
            this.btnFibonacci.TabIndex = 0;
            this.btnFibonacci.Text = "Compute Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.BtnFibonacci_Click);
            // 
            // btnCvrtXML2JSon
            // 
            this.btnCvrtXML2JSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCvrtXML2JSon.Location = new System.Drawing.Point(748, 330);
            this.btnCvrtXML2JSon.Name = "btnCvrtXML2JSon";
            this.btnCvrtXML2JSon.Size = new System.Drawing.Size(262, 82);
            this.btnCvrtXML2JSon.TabIndex = 1;
            this.btnCvrtXML2JSon.Text = "Convert XML to JSon";
            this.btnCvrtXML2JSon.UseVisualStyleBackColor = true;
            this.btnCvrtXML2JSon.Click += new System.EventHandler(this.BtnCvrtXML2JSon_Click);
            // 
            // txtFibonacci
            // 
            this.txtFibonacci.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtFibonacci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFibonacci.CausesValidation = false;
            this.txtFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFibonacci.Location = new System.Drawing.Point(79, 40);
            this.txtFibonacci.Name = "txtFibonacci";
            this.txtFibonacci.Size = new System.Drawing.Size(484, 29);
            this.txtFibonacci.TabIndex = 2;
            this.txtFibonacci.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFibonacci.TextChanged += new System.EventHandler(this.TxtFibonacci_TextChanged);
            // 
            // txtXML2JSon
            // 
            this.txtXML2JSon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtXML2JSon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXML2JSon.CausesValidation = false;
            this.txtXML2JSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXML2JSon.Location = new System.Drawing.Point(79, 225);
            this.txtXML2JSon.Multiline = true;
            this.txtXML2JSon.Name = "txtXML2JSon";
            this.txtXML2JSon.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXML2JSon.Size = new System.Drawing.Size(484, 270);
            this.txtXML2JSon.TabIndex = 3;
            this.txtXML2JSon.TextChanged += new System.EventHandler(this.TxtXML2JSon_TextChanged);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1125, 507);
            this.Controls.Add(this.txtXML2JSon);
            this.Controls.Add(this.txtFibonacci);
            this.Controls.Add(this.btnCvrtXML2JSon);
            this.Controls.Add(this.btnFibonacci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnFibonacci;
        public System.Windows.Forms.Button btnCvrtXML2JSon;
        private System.Windows.Forms.TextBox txtFibonacci;
        private System.Windows.Forms.TextBox txtXML2JSon;
    }
}

