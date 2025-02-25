namespace WindowsFormsDI
{
    partial class MainForm
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
            this.btnOpenChild = new System.Windows.Forms.Button();
            this.btnOpenTabContainerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenChild
            // 
            this.btnOpenChild.Location = new System.Drawing.Point(352, 188);
            this.btnOpenChild.Name = "btnOpenChild";
            this.btnOpenChild.Size = new System.Drawing.Size(75, 23);
            this.btnOpenChild.TabIndex = 0;
            this.btnOpenChild.Text = "Open Child";
            this.btnOpenChild.UseVisualStyleBackColor = true;
            this.btnOpenChild.Click += new System.EventHandler(this.btnOpenChild_Click);
            // 
            // btnOpenTabContainerForm
            // 
            this.btnOpenTabContainerForm.Location = new System.Drawing.Point(315, 217);
            this.btnOpenTabContainerForm.Name = "btnOpenTabContainerForm";
            this.btnOpenTabContainerForm.Size = new System.Drawing.Size(154, 23);
            this.btnOpenTabContainerForm.TabIndex = 1;
            this.btnOpenTabContainerForm.Text = "Open TabContainerForm";
            this.btnOpenTabContainerForm.UseVisualStyleBackColor = true;
            this.btnOpenTabContainerForm.Click += new System.EventHandler(this.btnOpenTabContainerForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenTabContainerForm);
            this.Controls.Add(this.btnOpenChild);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenChild;
        private System.Windows.Forms.Button btnOpenTabContainerForm;
    }
}

