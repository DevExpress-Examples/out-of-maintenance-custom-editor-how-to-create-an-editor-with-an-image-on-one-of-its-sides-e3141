Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Drawing
Imports System.Drawing

Namespace WindowsApplication1
	Public Class MyButtonEditPainter
		Inherits ButtonEditPainter

		Public Sub New()

		End Sub

		Protected Overrides Sub DrawButton(ByVal viewInfo As DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo, ByVal info As EditorButtonObjectInfoArgs)
			If "IsImage".Equals(info.Button.Tag) Then
				Dim bounds As Rectangle = info.Bounds
				info.Graphics.FillRectangle(viewInfo.PaintAppearance.GetBackBrush(info.Cache), info.Bounds)
				bounds.Inflate(-3, -3)
				info.Graphics.DrawImage(info.Button.Image, bounds)
			Else
				MyBase.DrawButton(viewInfo, info)
			End If
		End Sub
	End Class
End Namespace
