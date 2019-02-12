namespace SchoolAppLoganC
{
    partial class frmSchoolApp
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
            this.lblMacSaints = new System.Windows.Forms.Label();
            this.mnuSchoolApp = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSchoolApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMacSaints
            // 
            this.lblMacSaints.AutoSize = true;
            this.lblMacSaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacSaints.Location = new System.Drawing.Point(31, 39);
            this.lblMacSaints.Name = "lblMacSaints";
            this.lblMacSaints.Size = new System.Drawing.Size(523, 69);
            this.lblMacSaints.TabIndex = 0;
            this.lblMacSaints.Text = "Immaculata Saints";
            // 
            // mnuSchoolApp
            // 
            this.mnuSchoolApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnuSchoolApp.Location = new System.Drawing.Point(0, 0);
            this.mnuSchoolApp.Name = "mnuSchoolApp";
            this.mnuSchoolApp.Size = new System.Drawing.Size(586, 24);
            this.mnuSchoolApp.TabIndex = 1;
            this.mnuSchoolApp.Text = "menuStrip1";
            // 
            // mniProgram
            // 
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            this.mniProgram.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmSchoolApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 125);
            this.Controls.Add(this.lblMacSaints);
            this.Controls.Add(this.mnuSchoolApp);
            this.MainMenuStrip = this.mnuSchoolApp;
            this.Name = "frmSchoolApp";
            this.Text = "School App Logan C";
            this.mnuSchoolApp.ResumeLayout(false);
            this.mnuSchoolApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMacSaints;
        private System.Windows.Forms.MenuStrip mnuSchoolApp;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

