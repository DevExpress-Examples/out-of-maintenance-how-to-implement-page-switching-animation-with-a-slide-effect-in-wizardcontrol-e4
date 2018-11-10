Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraWizard
Imports DevExpress.XtraEditors

Namespace WizardControlPageSwitching
	Partial Public Class ucSlideWizard
		Inherits UserControl
		Private selectedIndex As Integer = 0
		Private ucDocMetro1 As ucDocMetro

		Public Sub New()
			InitializeComponent()
			ucDocMetro1 = New ucDocMetro()
			Me.Controls.Add(ucDocMetro1)
			ucDocMetro1.Dock = DockStyle.Fill
			backgroundWorker1.WorkerReportsProgress = True
			backgroundWorker1.WorkerSupportsCancellation = True
		End Sub

		Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			selectedIndex += 1
			If selectedIndex < 2 Then
				btnBack.Enabled = True
			End If
			ucDocMetro1.ActivatePage(selectedIndex)
			If selectedIndex = wizardControl1.Pages.Count - 1 Then
				btnNext.Visible = False
				btnFinish.Visible = True
			End If
			If selectedIndex = 1 AndAlso textEdit1.EditValue Is Nothing Then ' destination folder
				btnNext.Enabled = False
			End If
			If selectedIndex = 2 Then ' setup progress
				btnNext.Enabled = False
			End If
		End Sub

		Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
			selectedIndex -= 1
			btnNext.Visible = True
			btnFinish.Visible = False
			ucDocMetro1.ActivatePage(selectedIndex)
			If selectedIndex = 0 Then
				btnBack.Enabled = False
				btnNext.Enabled = True
			End If
			If selectedIndex = 1 Then
				btnNext.Enabled = True
			End If
		End Sub

		Public ReadOnly Property Pages() As WizardPageCollection
			Get
				Return wizardControl1.Pages
			End Get
		End Property

		Private Sub wizardControl1_CustomizeCommandButtons(ByVal sender As Object, ByVal e As CustomizeCommandButtonsEventArgs) Handles wizardControl1.CustomizeCommandButtons
			e.CancelButton.Visible = False
			e.FinishButton.Visible = False
			e.HelpButton.Visible = False
			e.NextButton.Visible = False
			e.PrevButton.Visible = False
		End Sub

		Public ReadOnly Property WizardControl() As WizardControl
			Get
				Return wizardControl1
			End Get
		End Property

		Public ReadOnly Property NextButton() As SimpleButton
			Get
				Return Me.btnNext
			End Get
		End Property

		Public ReadOnly Property BackButton() As SimpleButton
			Get
				Return Me.btnBack
			End Get
		End Property

		Public ReadOnly Property CancelButton() As SimpleButton
			Get
				Return Me.btnCancel
			End Get
		End Property

		Public ReadOnly Property FinishButton() As SimpleButton
			Get
				Return Me.btnFinish
			End Get
		End Property

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click ' browse
			If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
				textEdit1.EditValue = folderBrowserDialog1.SelectedPath
			End If
		End Sub

		Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
			If selectedIndex = 2 Then
				backgroundWorker1.CancelAsync()
			End If
			MessageBox.Show("Installation was terminated")
			TryCast(Me.Parent, Form1).Close()
		End Sub

		Private Sub btnFinish_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFinish.Click
			TryCast(Me.Parent, Form1).Close()
		End Sub

		Private Sub textEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textEdit1.EditValueChanged
			If textEdit1.EditValue IsNot Nothing Then
				btnNext.Enabled = True
				labelControl1.Text = "Destination folder: " & textEdit1.EditValue
			End If
		End Sub

		' backGroundWorker
		Private Sub btnStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStart.Click
			If backgroundWorker1.IsBusy <> True Then
				backgroundWorker1.RunWorkerAsync()
			End If
			btnBack.Enabled = False
			btnStart.Enabled = False
		End Sub

		Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles backgroundWorker1.DoWork
			Dim worker As BackgroundWorker = TryCast(sender, BackgroundWorker)
			Dim rand As New Random()

			For i As Integer = 1 To 25
				If worker.CancellationPending = True Then
					e.Cancel = True
					Exit For
				Else
					System.Threading.Thread.Sleep(rand.Next(400) + 100)
					worker.ReportProgress(i)
				End If
			Next i
		End Sub

		Private Sub backgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles backgroundWorker1.ProgressChanged
			progressBar1.Value = progressBar1.Value + 4
		End Sub

		Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles backgroundWorker1.RunWorkerCompleted
			If e.Cancelled <> True AndAlso e.Error Is Nothing Then
				btnNext.Enabled = True
				btnCancel.Enabled = False
			End If
		End Sub
	End Class
End Namespace
