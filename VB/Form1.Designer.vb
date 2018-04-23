Imports Microsoft.VisualBasic
Imports System
Namespace WizardControlPageSwitching
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.usSlideWizard1 = New WizardControlPageSwitching.ucSlideWizard()
			Me.SuspendLayout()
			' 
			' usSlideWizard1
			' 
			Me.usSlideWizard1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.usSlideWizard1.Location = New System.Drawing.Point(0, 0)
			Me.usSlideWizard1.Name = "usSlideWizard1"
			Me.usSlideWizard1.Size = New System.Drawing.Size(875, 421)
			Me.usSlideWizard1.TabIndex = 5
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(875, 421)
			Me.Controls.Add(Me.usSlideWizard1)
			Me.IsMdiContainer = True
			Me.Name = "Form1"
			Me.Text = "page"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private usSlideWizard1 As ucSlideWizard













	End Class
End Namespace

