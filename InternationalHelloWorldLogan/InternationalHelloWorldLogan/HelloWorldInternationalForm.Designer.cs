namespace InternationalHelloWorldLogan
{
    partial class FrmHelloWorldInternational
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
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radItalian = new System.Windows.Forms.RadioButton();
            this.gbxLanguages = new System.Windows.Forms.GroupBox();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.gbxLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(9, 19);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Location = new System.Drawing.Point(100, 19);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(58, 17);
            this.radFrench.TabIndex = 1;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "French";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.radFrench_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Location = new System.Drawing.Point(191, 19);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(63, 17);
            this.radSpanish.TabIndex = 2;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Spanish";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.radSpanish_CheckedChanged);
            // 
            // radItalian
            // 
            this.radItalian.AutoSize = true;
            this.radItalian.Location = new System.Drawing.Point(282, 19);
            this.radItalian.Name = "radItalian";
            this.radItalian.Size = new System.Drawing.Size(53, 17);
            this.radItalian.TabIndex = 3;
            this.radItalian.TabStop = true;
            this.radItalian.Text = "Italian";
            this.radItalian.UseVisualStyleBackColor = true;
            this.radItalian.CheckedChanged += new System.EventHandler(this.radItalian_CheckedChanged);
            // 
            // gbxLanguages
            // 
            this.gbxLanguages.Controls.Add(this.radEnglish);
            this.gbxLanguages.Controls.Add(this.radItalian);
            this.gbxLanguages.Controls.Add(this.radFrench);
            this.gbxLanguages.Controls.Add(this.radSpanish);
            this.gbxLanguages.Location = new System.Drawing.Point(132, 192);
            this.gbxLanguages.Name = "gbxLanguages";
            this.gbxLanguages.Size = new System.Drawing.Size(370, 53);
            this.gbxLanguages.TabIndex = 4;
            this.gbxLanguages.TabStop = false;
            this.gbxLanguages.Text = "Language";
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(128, 78);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(374, 76);
            this.lblHelloWorld.TabIndex = 5;
            this.lblHelloWorld.Text = "Hello World";
            this.lblHelloWorld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHelloWorldInternational
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 353);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.gbxLanguages);
            this.Name = "FrmHelloWorldInternational";
            this.Text = "Hello World International Logan C";
            this.gbxLanguages.ResumeLayout(false);
            this.gbxLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radItalian;
        private System.Windows.Forms.GroupBox gbxLanguages;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

