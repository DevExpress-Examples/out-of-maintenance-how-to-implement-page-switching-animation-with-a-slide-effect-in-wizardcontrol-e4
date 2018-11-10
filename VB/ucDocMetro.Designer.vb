Imports Microsoft.VisualBasic
Imports System
Namespace WizardControlPageSwitching
	Partial Public Class ucDocMetro
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
			Me.components = New System.ComponentModel.Container()
			Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.metroUIView1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.MetroUIView(Me.components)
			Me.pageGroup1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(Me.components)
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.metroUIView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pageGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' documentManager1
			' 
			Me.documentManager1.ContainerControl = Me
			Me.documentManager1.View = Me.metroUIView1
			Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.metroUIView1})
			' 
			' metroUIView1
			' 
			Me.metroUIView1.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() { Me.pageGroup1})
			' 
			' ucDocMetro
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "ucDocMetro"
			Me.Size = New System.Drawing.Size(875, 442)
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.metroUIView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pageGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Friend documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
		Friend metroUIView1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.MetroUIView
		Private pageGroup1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup


	End Class
End Namespace
