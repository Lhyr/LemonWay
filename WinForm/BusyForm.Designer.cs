namespace WinForm
{
    partial class BusyForm
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
            this.pgBBusy = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pgBBusy
            // 
            this.pgBBusy.Location = new System.Drawing.Point(-1, 1);
            this.pgBBusy.Name = "pgBBusy";
            this.pgBBusy.Size = new System.Drawing.Size(311, 42);
            this.pgBBusy.Step = 100;
            this.pgBBusy.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgBBusy.TabIndex = 0;
            this.pgBBusy.UseWaitCursor = true;
            // 
            // BusyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(311, 44);
            this.ControlBox = false;
            this.Controls.Add(this.pgBBusy);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusyForm";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Working in progress ...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgBBusy;
    }
}