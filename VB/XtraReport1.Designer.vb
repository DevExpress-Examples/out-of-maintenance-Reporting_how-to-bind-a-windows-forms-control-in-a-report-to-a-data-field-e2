Imports Microsoft.VisualBasic
Imports System
Namespace BindWinControl
	Partial Public Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.winControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer()
			Me.button1 = New System.Windows.Forms.Button()
			Me.nwindDataSet1 = New BindWinControl.nwindDataSet()
			Me.categoriesTableAdapter = New BindWinControl.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.winControlContainer1})
			Me.Detail.HeightF = 57F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' winControlContainer1
			' 
			Me.winControlContainer1.LocationFloat = New DevExpress.Utils.PointFloat(8F, 8F)
			Me.winControlContainer1.Name = "winControlContainer1"
			Me.winControlContainer1.SizeF = New System.Drawing.SizeF(167F, 42F)
			Me.winControlContainer1.WinControl = Me.button1
'			Me.winControlContainer1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.winControlContainer1_BeforePrint);
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(0, 0)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(160, 40)
			Me.button1.TabIndex = 0
			Me.button1.Text = "button1"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.DataAdapter = Me.categoriesTableAdapter
			Me.DataMember = "Categories"
			Me.DataSource = Me.nwindDataSet1
			Me.Version = "12.2"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As BindWinControl.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private WithEvents winControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
		Private button1 As System.Windows.Forms.Button
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
	End Class
End Namespace
