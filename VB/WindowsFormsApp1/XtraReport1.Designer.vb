Namespace WindowsFormsApp1
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
			Me.components = New System.ComponentModel.Container()
			Dim objectConstructorInfo1 As New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
			Dim parameter1 As New DevExpress.DataAccess.ObjectBinding.Parameter()
			Dim parameter2 As New DevExpress.DataAccess.ObjectBinding.Parameter()
			Me.department = New DevExpress.XtraReports.Parameters.Parameter()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.table1 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.table2 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.table3 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupData1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupFooterBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			DirectCast(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' department
			' 
			Me.department.Description = "Department"
			Me.department.Name = "department"
			Me.department.ValueInfo = "Management"
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.pageInfo1, Me.pageInfo2})
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label1})
			Me.ReportHeader.HeightF = 60F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table1})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Position", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader1.HeightF = 27F
			Me.GroupHeader1.Level = 1
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' GroupHeader2
			' 
			Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table2})
			Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader2.HeightF = 28F
			Me.GroupHeader2.Level = 2
			Me.GroupHeader2.Name = "GroupHeader2"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table3})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			' 
			' GroupFooter1
			' 
			Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label2})
			Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
			Me.GroupFooter1.HeightF = 6F
			Me.GroupFooter1.Name = "GroupFooter1"
			' 
			' pageInfo1
			' 
			Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.pageInfo1.Name = "pageInfo1"
			Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.pageInfo1.SizeF = New System.Drawing.SizeF(325F, 23F)
			Me.pageInfo1.StyleName = "PageInfo"
			' 
			' pageInfo2
			' 
			Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(325F, 0F)
			Me.pageInfo2.Name = "pageInfo2"
			Me.pageInfo2.SizeF = New System.Drawing.SizeF(325F, 23F)
			Me.pageInfo2.StyleName = "PageInfo"
			Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.pageInfo2.TextFormatString = "Page {0} of {1}"
			' 
			' label1
			' 
			Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.label1.Name = "label1"
			Me.label1.SizeF = New System.Drawing.SizeF(650F, 24.19433F)
			Me.label1.StyleName = "Title"
			Me.label1.Text = "Employees"
			' 
			' table1
			' 
			Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2F)
			Me.table1.Name = "table1"
			Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow1})
			Me.table1.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' tableRow1
			' 
			Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell1, Me.tableCell2})
			Me.tableRow1.Name = "tableRow1"
			Me.tableRow1.Weight = 1R
			' 
			' tableCell1
			' 
			Me.tableCell1.Name = "tableCell1"
			Me.tableCell1.StyleName = "GroupCaption1"
			Me.tableCell1.Text = "POSITION"
			Me.tableCell1.Weight = 1028127.3125R
			' 
			' tableCell2
			' 
			Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Position]")})
			Me.tableCell2.Name = "tableCell2"
			Me.tableCell2.StyleName = "GroupData1"
			Me.tableCell2.Weight = 9621472R
			' 
			' table2
			' 
			Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table2.Name = "table2"
			Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow2})
			Me.table2.SizeF = New System.Drawing.SizeF(650F, 28F)
			' 
			' tableRow2
			' 
			Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell3})
			Me.tableRow2.Name = "tableRow2"
			Me.tableRow2.Weight = 1R
			' 
			' tableCell3
			' 
			Me.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell3.Name = "tableCell3"
			Me.tableCell3.StyleName = "DetailCaption1"
			Me.tableCell3.StylePriority.UseBorders = False
			Me.tableCell3.Text = "Name"
			Me.tableCell3.Weight = 1R
			' 
			' table3
			' 
			Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table3.Name = "table3"
			Me.table3.OddStyleName = "DetailData3_Odd"
			Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow3})
			Me.table3.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' tableRow3
			' 
			Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell4})
			Me.tableRow3.Name = "tableRow3"
			Me.tableRow3.Weight = 11.5R
			' 
			' tableCell4
			' 
			Me.tableCell4.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Name]")})
			Me.tableCell4.Name = "tableCell4"
			Me.tableCell4.StyleName = "DetailData1"
			Me.tableCell4.StylePriority.UseBorders = False
			Me.tableCell4.Weight = 1R
			' 
			' label2
			' 
			Me.label2.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.label2.Name = "label2"
			Me.label2.SizeF = New System.Drawing.SizeF(650F, 2.08F)
			Me.label2.StyleName = "GroupFooterBackground3"
			Me.label2.StylePriority.UseBorders = False
			' 
			' objectDataSource1
			' 
			parameter1.Name = "department"
			parameter1.Type = GetType(DevExpress.DataAccess.Expression)
			parameter1.Value = New DevExpress.DataAccess.Expression("?department", GetType(String))
			objectConstructorInfo1.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() { parameter1})
			Me.objectDataSource1.Constructor = objectConstructorInfo1
			Me.objectDataSource1.DataMember = "GetEmployeeList"
			Me.objectDataSource1.DataSource = GetType(EmployeeDataSource)
			Me.objectDataSource1.Name = "objectDataSource1"
			parameter2.Name = "recordCount"
			parameter2.Type = GetType(Integer)
			parameter2.ValueInfo = "4"
			Me.objectDataSource1.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() { parameter2})
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.Transparent
			Me.Title.BorderColor = System.Drawing.Color.Black
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1F
			Me.Title.Font = New System.Drawing.Font("Arial", 14.25F)
			Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.Title.Name = "Title"
			Me.Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			' 
			' GroupCaption1
			' 
			Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.GroupCaption1.BorderColor = System.Drawing.Color.White
			Me.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupCaption1.BorderWidth = 2F
			Me.GroupCaption1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(228)))), (CInt((CByte(228)))), (CInt((CByte(228)))))
			Me.GroupCaption1.Name = "GroupCaption1"
			Me.GroupCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GroupData1
			' 
			Me.GroupData1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.GroupData1.BorderColor = System.Drawing.Color.White
			Me.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupData1.BorderWidth = 2F
			Me.GroupData1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupData1.ForeColor = System.Drawing.Color.White
			Me.GroupData1.Name = "GroupData1"
			Me.GroupData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailCaption1
			' 
			Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.DetailCaption1.BorderColor = System.Drawing.Color.White
			Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailCaption1.BorderWidth = 2F
			Me.DetailCaption1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.DetailCaption1.ForeColor = System.Drawing.Color.White
			Me.DetailCaption1.Name = "DetailCaption1"
			Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData1
			' 
			Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailData1.BorderWidth = 2F
			Me.DetailData1.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData1.ForeColor = System.Drawing.Color.Black
			Me.DetailData1.Name = "DetailData1"
			Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GroupFooterBackground3
			' 
			Me.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(131)))), (CInt((CByte(131)))), (CInt((CByte(131)))))
			Me.GroupFooterBackground3.BorderColor = System.Drawing.Color.White
			Me.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupFooterBackground3.BorderWidth = 2F
			Me.GroupFooterBackground3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(228)))), (CInt((CByte(228)))), (CInt((CByte(228)))))
			Me.GroupFooterBackground3.Name = "GroupFooterBackground3"
			Me.GroupFooterBackground3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData3_Odd
			' 
			Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
			Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DetailData3_Odd.BorderWidth = 1F
			Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
			Me.DetailData3_Odd.Name = "DetailData3_Odd"
			Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' PageInfo
			' 
			Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.PageInfo.Name = "PageInfo"
			Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2, Me.Detail, Me.GroupFooter1})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.objectDataSource1})
			Me.DataSource = Me.objectDataSource1
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.department})
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.GroupCaption1, Me.GroupData1, Me.DetailCaption1, Me.DetailData1, Me.GroupFooterBackground3, Me.DetailData3_Odd, Me.PageInfo})
			Me.Version = "22.1"
			DirectCast(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private department As DevExpress.XtraReports.Parameters.Parameter
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private label1 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private table1 As DevExpress.XtraReports.UI.XRTable
		Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private table2 As DevExpress.XtraReports.UI.XRTable
		Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private table3 As DevExpress.XtraReports.UI.XRTable
		Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private label2 As DevExpress.XtraReports.UI.XRLabel
		Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
		Private Title As DevExpress.XtraReports.UI.XRControlStyle
		Private GroupCaption1 As DevExpress.XtraReports.UI.XRControlStyle
		Private GroupData1 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData1 As DevExpress.XtraReports.UI.XRControlStyle
		Private GroupFooterBackground3 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
		Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace
