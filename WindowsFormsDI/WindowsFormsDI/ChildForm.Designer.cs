﻿namespace WindowsFormsDI
{
    partial class ChildForm
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
            this.btnRunService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRunService
            // 
            this.btnRunService.Location = new System.Drawing.Point(341, 190);
            this.btnRunService.Name = "btnRunService";
            this.btnRunService.Size = new System.Drawing.Size(75, 23);
            this.btnRunService.TabIndex = 0;
            this.btnRunService.Text = "Run Service";
            this.btnRunService.UseVisualStyleBackColor = true;
            this.btnRunService.Click += new System.EventHandler(this.btnRunService_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRunService);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunService;
    }
}