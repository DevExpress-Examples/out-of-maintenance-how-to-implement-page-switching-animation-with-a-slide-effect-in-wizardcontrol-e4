Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views.MetroUI
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraEditors
Imports DevExpress.XtraWizard

Namespace WizardControlPageSwitching
	Partial Public Class ucDocMetro
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			metroUIView1.UseSplashScreen = DevExpress.Utils.DefaultBoolean.False
			AddHandler Load, AddressOf DocMetro_Load
		End Sub

		Friend Sub ActivatePage(ByVal numPage As Integer)
			Dim wizard As WizardControl = (TryCast(Parent, ucSlideWizard)).WizardControl
			wizard.Parent = (TryCast(metroUIView1.Documents(numPage), Document)).Control
			wizard.SelectedPageIndex = numPage
			pageGroup1.SetSelected(TryCast(metroUIView1.Documents(numPage), Document))
			metroUIView1.Controller.Activate(pageGroup1)
		End Sub

		Friend Sub PopulatePages(ByVal count As Integer)
			For i As Integer = 0 To count - 1
				Dim size As Size = (TryCast(Parent, ucSlideWizard)).WizardControl.Size
				metroUIView1.AddDocument(New Control())
				metroUIView1.Documents(i).Control.Parent.Size = size
				pageGroup1.Items.Add(CType(metroUIView1.Documents(i), Document))
			Next i
		End Sub

		Private Sub DocMetro_Load(ByVal sender As Object, ByVal e As EventArgs)
			PopulatePages((TryCast(Parent, ucSlideWizard)).Pages.Count)
			ActivatePage(0)
		End Sub
	End Class
End Namespace
