Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Namespace BindWinControl
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub winControlContainer1_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles winControlContainer1.BeforePrint
			Dim control As Button = TryCast((CType(sender, WinControlContainer)).WinControl, Button)
			control.Text = GetCurrentColumnValue("CategoryName").ToString()
		End Sub

	End Class
End Namespace
