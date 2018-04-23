Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing

Namespace WindowsApplication1

	<System.ComponentModel.DesignerCategory(""), UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyButtonEdit
		Inherits RepositoryItemButtonEdit
		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
		End Sub

		Friend Const EditorName As String = "MyButtonEdit"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyButtonEdit), GetType(RepositoryItemMyButtonEdit), GetType(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo), New MyButtonEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property
	End Class
End Namespace