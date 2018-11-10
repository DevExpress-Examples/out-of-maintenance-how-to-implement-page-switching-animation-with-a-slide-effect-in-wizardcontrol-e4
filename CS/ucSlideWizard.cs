using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraWizard;
using DevExpress.XtraEditors;

namespace WizardControlPageSwitching
{
    public partial class ucSlideWizard : UserControl
    {
        int selectedIndex = 0;
        ucDocMetro ucDocMetro1;

        public ucSlideWizard()
        {
            InitializeComponent();
            ucDocMetro1 = new ucDocMetro();
            this.Controls.Add(ucDocMetro1);
            ucDocMetro1.Dock = DockStyle.Fill;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            selectedIndex++;
            if (selectedIndex < 2)
                btnBack.Enabled = true;
            ucDocMetro1.ActivatePage(selectedIndex);
            if (selectedIndex == wizardControl1.Pages.Count - 1)
            {
                btnNext.Visible = false;
                btnFinish.Visible = true;
            }
            if (selectedIndex == 1 && textEdit1.EditValue == null) // destination folder
                btnNext.Enabled = false;
            if (selectedIndex == 2) // setup progress
                btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            selectedIndex--;
            btnNext.Visible = true;
            btnFinish.Visible = false;
            ucDocMetro1.ActivatePage(selectedIndex);
            if (selectedIndex == 0)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = true;
            }
            if (selectedIndex == 1) btnNext.Enabled = true;
        }

        public WizardPageCollection Pages
        { get { return wizardControl1.Pages; } }

        private void wizardControl1_CustomizeCommandButtons(object sender, CustomizeCommandButtonsEventArgs e)
        {
            e.CancelButton.Visible = false;
            e.FinishButton.Visible = false;
            e.HelpButton.Visible = false;
            e.NextButton.Visible = false;
            e.PrevButton.Visible = false;
        }

        public WizardControl WizardControl
        { get { return wizardControl1; } }

        public SimpleButton NextButton
        { get { return this.btnNext; } }

        public SimpleButton BackButton
        { get { return this.btnBack; } }

        public SimpleButton CancelButton
        { get { return this.btnCancel; } }

        public SimpleButton FinishButton
        { get { return this.btnFinish; } }

        private void simpleButton1_Click(object sender, EventArgs e) // browse
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textEdit1.EditValue = folderBrowserDialog1.SelectedPath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (selectedIndex == 2)
                backgroundWorker1.CancelAsync();
            MessageBox.Show("Installation was terminated");
            (this.Parent as Form1).Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            (this.Parent as Form1).Close();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit1.EditValue != null)
            {
                btnNext.Enabled = true;
                labelControl1.Text = "Destination folder: " + textEdit1.EditValue;
            }
        }

        // backGroundWorker
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            btnBack.Enabled = false;
            btnStart.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Random rand = new Random();

            for (int i = 1; i <= 25; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(rand.Next(400) + 100);
                    worker.ReportProgress(i);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 4;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled != true && e.Error == null)
            {
                btnNext.Enabled = true;
                btnCancel.Enabled = false;
            }
        }
    }
}
