namespace WizardControlPageSwitching
{
    partial class ucDocMetro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.metroUIView1 = new DevExpress.XtraBars.Docking2010.Views.MetroUI.MetroUIView(this.components);
            this.pageGroup1 = new DevExpress.XtraBars.Docking2010.Views.MetroUI.PageGroup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.metroUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.metroUIView1});
            // 
            // metroUIView1
            // 
            this.metroUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.MetroUI.IContentContainer[] {
            this.pageGroup1});
            // 
            // ucDocMetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucDocMetro";
            this.Size = new System.Drawing.Size(875, 442);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        internal DevExpress.XtraBars.Docking2010.Views.MetroUI.MetroUIView metroUIView1;
        private DevExpress.XtraBars.Docking2010.Views.MetroUI.PageGroup pageGroup1;


    }
}
