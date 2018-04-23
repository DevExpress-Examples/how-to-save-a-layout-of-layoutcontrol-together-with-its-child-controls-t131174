Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Collections
Imports System.Reflection
Imports DevExpress.Utils.Serializing
Imports System.Linq
Imports System.IO
Imports DevExpress.XtraLayout
Imports System.Xml.Serialization
Imports CustomSerialization
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils.Paint
Imports DevExpress.XtraGrid.Views.Grid
Imports DXSample.Properties


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private filePath As String = "Layout.xml"
		Private Sub OnSaveLayoutButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			layoutControl1.SaveLayoutExToXml(filePath)
		End Sub

		Private Sub OnRestoreLayoutButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			layoutControl2.RestoreLayoutExFromXml(filePath)
		End Sub
	End Class
End Namespace

