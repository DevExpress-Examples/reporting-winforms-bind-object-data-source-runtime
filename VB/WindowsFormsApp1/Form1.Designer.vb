﻿Namespace WindowsFormsApp1
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
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.SuspendLayout()
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12F)
			Me.simpleButton1.Appearance.Options.UseFont = True
			Me.simpleButton1.Location = New System.Drawing.Point(150, 78)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(172, 34)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Show Report"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(473, 190)
			Me.Controls.Add(Me.simpleButton1)
			Me.Name = "Form1"
			Me.Text = "How to bind a report to an object data source"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

