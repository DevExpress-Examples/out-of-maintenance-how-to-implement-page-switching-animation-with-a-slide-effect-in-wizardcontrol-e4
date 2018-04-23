using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.MetroUI;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using DevExpress.XtraWizard;

namespace WizardControlPageSwitching
{
    public partial class ucDocMetro : UserControl
    {
        public ucDocMetro()
        {
            InitializeComponent();
            metroUIView1.UseSplashScreen = DevExpress.Utils.DefaultBoolean.False;
            this.Load += new EventHandler(DocMetro_Load);
        }

        internal void ActivatePage(int numPage)
        {
            WizardControl wizard = (Parent as ucSlideWizard).WizardControl;
            wizard.Parent = (metroUIView1.Documents[numPage] as Document).Control;
            wizard.SelectedPageIndex = numPage;
            pageGroup1.SetSelected(metroUIView1.Documents[numPage] as Document);
            metroUIView1.Controller.Activate(pageGroup1);
        }

        internal void PopulatePages(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Size size = (Parent as ucSlideWizard).WizardControl.Size;
                metroUIView1.AddDocument(new Control());
                metroUIView1.Documents[i].Control.Parent.Size = size;
                pageGroup1.Items.Add((Document)metroUIView1.Documents[i]);
            }
        }

        void DocMetro_Load(object sender, EventArgs e)
        {
            PopulatePages((Parent as ucSlideWizard).Pages.Count);
            ActivatePage(0);
        }
    }
}
