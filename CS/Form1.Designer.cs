namespace WizardControlPageSwitching
{
    partial class Form1
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
            this.usSlideWizard1 = new WizardControlPageSwitching.ucSlideWizard();
            this.SuspendLayout();
            // 
            // usSlideWizard1
            // 
            this.usSlideWizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usSlideWizard1.Location = new System.Drawing.Point(0, 0);
            this.usSlideWizard1.Name = "usSlideWizard1";
            this.usSlideWizard1.Size = new System.Drawing.Size(875, 421);
            this.usSlideWizard1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 421);
            this.Controls.Add(this.usSlideWizard1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "page";
            this.ResumeLayout(false);

        }

        #endregion

        private ucSlideWizard usSlideWizard1;













    }
}

