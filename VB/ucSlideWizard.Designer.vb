Imports Microsoft.VisualBasic
Imports System
Namespace WizardControlPageSwitching
	Partial Public Class ucSlideWizard
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
			Me.btnNext = New DevExpress.XtraEditors.SimpleButton()
			Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.btnFinish = New DevExpress.XtraEditors.SimpleButton()
			Me.wizardControl1 = New DevExpress.XtraWizard.WizardControl()
			Me.welcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
			Me.wizardPage1 = New DevExpress.XtraWizard.WizardPage()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.completionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
			Me.wizardPage2 = New DevExpress.XtraWizard.WizardPage()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.btnStart = New DevExpress.XtraEditors.SimpleButton()
			Me.progressBar1 = New System.Windows.Forms.ProgressBar()
			Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
			Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
			Me.panel1.SuspendLayout()
			CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.wizardControl1.SuspendLayout()
			Me.wizardPage1.SuspendLayout()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.wizardPage2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' btnBack
			' 
			Me.btnBack.Enabled = False
			Me.btnBack.Location = New System.Drawing.Point(461, 1)
			Me.btnBack.Name = "btnBack"
			Me.btnBack.Size = New System.Drawing.Size(125, 43)
			Me.btnBack.TabIndex = 1
			Me.btnBack.Text = "< Back"
'			Me.btnBack.Click += New System.EventHandler(Me.btnBack_Click);
			' 
			' btnNext
			' 
			Me.btnNext.Location = New System.Drawing.Point(586, 1)
			Me.btnNext.Name = "btnNext"
			Me.btnNext.Size = New System.Drawing.Size(125, 43)
			Me.btnNext.TabIndex = 2
			Me.btnNext.Text = "Next >"
'			Me.btnNext.Click += New System.EventHandler(Me.btnNext_Click);
			' 
			' btnCancel
			' 
			Me.btnCancel.Location = New System.Drawing.Point(711, 1)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(125, 43)
			Me.btnCancel.TabIndex = 3
			Me.btnCancel.Text = "Cancel"
'			Me.btnCancel.Click += New System.EventHandler(Me.btnCancel_Click);
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.btnFinish)
			Me.panel1.Controls.Add(Me.btnNext)
			Me.panel1.Controls.Add(Me.btnCancel)
			Me.panel1.Controls.Add(Me.btnBack)
			Me.panel1.Location = New System.Drawing.Point(3, 3)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(845, 45)
			Me.panel1.TabIndex = 4
			' 
			' btnFinish
			' 
			Me.btnFinish.Location = New System.Drawing.Point(586, 1)
			Me.btnFinish.Name = "btnFinish"
			Me.btnFinish.Size = New System.Drawing.Size(125, 43)
			Me.btnFinish.TabIndex = 5
			Me.btnFinish.Text = "Finish"
			Me.btnFinish.UseWaitCursor = True
			Me.btnFinish.Visible = False
'			Me.btnFinish.Click += New System.EventHandler(Me.btnFinish_Click);
			' 
			' wizardControl1
			' 
			Me.wizardControl1.AllowTransitionAnimation = False
			Me.wizardControl1.AnimationInterval = 10
			Me.wizardControl1.Controls.Add(Me.welcomeWizardPage1)
			Me.wizardControl1.Controls.Add(Me.wizardPage1)
			Me.wizardControl1.Controls.Add(Me.completionWizardPage1)
			Me.wizardControl1.Controls.Add(Me.wizardPage2)
			Me.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.wizardControl1.Location = New System.Drawing.Point(0, 0)
			Me.wizardControl1.Name = "wizardControl1"
			Me.wizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() { Me.welcomeWizardPage1, Me.wizardPage1, Me.wizardPage2, Me.completionWizardPage1})
			Me.wizardControl1.Size = New System.Drawing.Size(864, 419)
'			Me.wizardControl1.CustomizeCommandButtons += New DevExpress.XtraWizard.WizardCustomizeCommandButtonsEventHandler(Me.wizardControl1_CustomizeCommandButtons);
			' 
			' welcomeWizardPage1
			' 
			Me.welcomeWizardPage1.IntroductionText = "Hello. Follow next steps to finish this installation."
			Me.welcomeWizardPage1.Name = "welcomeWizardPage1"
			Me.welcomeWizardPage1.Size = New System.Drawing.Size(647, 286)
			Me.welcomeWizardPage1.Text = "Welcome to the test setup wizard"
			' 
			' wizardPage1
			' 
			Me.wizardPage1.Controls.Add(Me.textEdit1)
			Me.wizardPage1.Controls.Add(Me.simpleButton1)
			Me.wizardPage1.DescriptionText = "Click Browse to choose destination folder."
			Me.wizardPage1.Name = "wizardPage1"
			Me.wizardPage1.Size = New System.Drawing.Size(832, 274)
			Me.wizardPage1.Text = "Destination folder"
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(17, 133)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(637, 20)
			Me.textEdit1.TabIndex = 2
'			Me.textEdit1.EditValueChanged += New System.EventHandler(Me.textEdit1_EditValueChanged);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(660, 133)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(89, 20)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Browse..."
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' completionWizardPage1
			' 
			Me.completionWizardPage1.FinishText = "This was an example."
			Me.completionWizardPage1.Name = "completionWizardPage1"
			Me.completionWizardPage1.Size = New System.Drawing.Size(647, 286)
			Me.completionWizardPage1.Text = "The installation was successful!"
			' 
			' wizardPage2
			' 
			Me.wizardPage2.Controls.Add(Me.labelControl1)
			Me.wizardPage2.Controls.Add(Me.btnStart)
			Me.wizardPage2.Controls.Add(Me.progressBar1)
			Me.wizardPage2.DescriptionText = "Setup is performing the requested operations."
			Me.wizardPage2.Name = "wizardPage2"
			Me.wizardPage2.Size = New System.Drawing.Size(832, 274)
			Me.wizardPage2.Text = "Setup status"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(118, 89)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(0, 13)
			Me.labelControl1.TabIndex = 2
			' 
			' btnStart
			' 
			Me.btnStart.Location = New System.Drawing.Point(356, 163)
			Me.btnStart.Name = "btnStart"
			Me.btnStart.Size = New System.Drawing.Size(101, 32)
			Me.btnStart.TabIndex = 1
			Me.btnStart.Text = "Install"
'			Me.btnStart.Click += New System.EventHandler(Me.btnStart_Click);
			' 
			' progressBar1
			' 
			Me.progressBar1.Location = New System.Drawing.Point(118, 119)
			Me.progressBar1.Name = "progressBar1"
			Me.progressBar1.Size = New System.Drawing.Size(566, 38)
			Me.progressBar1.TabIndex = 0
			' 
			' backgroundWorker1
			' 
'			Me.backgroundWorker1.DoWork += New System.ComponentModel.DoWorkEventHandler(Me.backgroundWorker1_DoWork);
'			Me.backgroundWorker1.ProgressChanged += New System.ComponentModel.ProgressChangedEventHandler(Me.backgroundWorker1_ProgressChanged);
'			Me.backgroundWorker1.RunWorkerCompleted += New System.ComponentModel.RunWorkerCompletedEventHandler(Me.backgroundWorker1_RunWorkerCompleted);
			' 
			' ucSlideWizard
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.wizardControl1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "ucSlideWizard"
			Me.Size = New System.Drawing.Size(864, 419)
			Me.panel1.ResumeLayout(False)
			CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.wizardControl1.ResumeLayout(False)
			Me.wizardPage1.ResumeLayout(False)
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.wizardPage2.ResumeLayout(False)
			Me.wizardPage2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnNext As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents btnFinish As DevExpress.XtraEditors.SimpleButton
		Private WithEvents wizardControl1 As DevExpress.XtraWizard.WizardControl
		Private welcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
		Private wizardPage1 As DevExpress.XtraWizard.WizardPage
		Private completionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
		Private wizardPage2 As DevExpress.XtraWizard.WizardPage
		Private progressBar1 As System.Windows.Forms.ProgressBar
		Private WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents btnStart As DevExpress.XtraEditors.SimpleButton
		Private WithEvents textEdit1 As DevExpress.XtraEditors.TextEdit
	End Class
End Namespace
