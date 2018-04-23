Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.myButtonEdit1 = New WindowsApplication1.MyButtonEdit()
			Me.myButtonEdit2 = New WindowsApplication1.MyButtonEdit()
			Me.myButtonEdit3 = New WindowsApplication1.MyButtonEdit()
			CType(Me.myButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myButtonEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myButtonEdit1
			' 
			Me.myButtonEdit1.Location = New System.Drawing.Point(21, 12)
			Me.myButtonEdit1.Name = "myButtonEdit1"
			Me.myButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myButtonEdit1.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "IsImage", Nothing, True)})
			Me.myButtonEdit1.Size = New System.Drawing.Size(202, 22)
			Me.myButtonEdit1.TabIndex = 0
			' 
			' myButtonEdit2
			' 
			Me.myButtonEdit2.Location = New System.Drawing.Point(21, 62)
			Me.myButtonEdit2.Name = "myButtonEdit2"
			Me.myButtonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myButtonEdit2.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "IsImage", Nothing, True)})
			Me.myButtonEdit2.Size = New System.Drawing.Size(202, 22)
			Me.myButtonEdit2.TabIndex = 1
			' 
			' myButtonEdit3
			' 
			Me.myButtonEdit3.Location = New System.Drawing.Point(21, 116)
			Me.myButtonEdit3.Name = "myButtonEdit3"
			Me.myButtonEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myButtonEdit3.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "IsImage", Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.myButtonEdit3.Size = New System.Drawing.Size(202, 22)
			Me.myButtonEdit3.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(714, 316)
			Me.Controls.Add(Me.myButtonEdit3)
			Me.Controls.Add(Me.myButtonEdit2)
			Me.Controls.Add(Me.myButtonEdit1)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myButtonEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myButtonEdit1 As MyButtonEdit
		Private myButtonEdit2 As MyButtonEdit
		Private myButtonEdit3 As MyButtonEdit

	End Class
End Namespace

