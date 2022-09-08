Namespace ObjectDataSource

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
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
            Dim objectConstructorInfo1 As DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo = New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
            Dim parameter1 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupData3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaptionBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable3})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable3
            ' 
            Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable3.Name = "xrTable3"
            Me.xrTable3.OddStyleName = "DetailData3_Odd"
            Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow3})
            Me.xrTable3.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Weight = 11.5R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CommonName]")})
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell6.StyleName = "DetailData3"
            Me.xrTableCell6.Text = "xrTableCell6"
            Me.xrTableCell6.Weight = 0.21888958270733178R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SpeciesName]")})
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell7.StyleName = "DetailData3"
            Me.xrTableCell7.Text = "xrTableCell7"
            Me.xrTableCell7.Weight = 0.29727046086237979R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Notes]")})
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell8.StyleName = "DetailData3"
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.Weight = 0.48383995643028843R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' reportHeaderBand1
            ' 
            Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.reportHeaderBand1.HeightF = 60F
            Me.reportHeaderBand1.Name = "reportHeaderBand1"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(638F, 26F)
            Me.xrLabel1.StyleName = "Title"
            Me.xrLabel1.Text = "Fishes"
            ' 
            ' groupHeaderBand1
            ' 
            Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Category", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.groupHeaderBand1.HeightF = 25F
            Me.groupHeaderBand1.Level = 1
            Me.groupHeaderBand1.Name = "groupHeaderBand1"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.StyleName = "GroupCaption3"
            Me.xrTableCell1.Text = "CATEGORY"
            Me.xrTableCell1.Weight = 0.1076923076923077R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Category]")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.StyleName = "GroupData3"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 0.89230769230769236R
            ' 
            ' groupHeaderBand2
            ' 
            Me.groupHeaderBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel1})
            Me.groupHeaderBand2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.groupHeaderBand2.HeightF = 48F
            Me.groupHeaderBand2.Level = 2
            Me.groupHeaderBand2.Name = "groupHeaderBand2"
            ' 
            ' xrPanel1
            ' 
            Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPanel1.Name = "xrPanel1"
            Me.xrPanel1.SizeF = New System.Drawing.SizeF(650F, 48F)
            Me.xrPanel1.StyleName = "DetailCaptionBackground3"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 20F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 28F)
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell3.StyleName = "DetailCaption3"
            Me.xrTableCell3.Text = "Fish Common Name"
            Me.xrTableCell3.Weight = 0.21888958688318377R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell4.StyleName = "DetailCaption3"
            Me.xrTableCell4.Text = "Fish Species Name"
            Me.xrTableCell4.Weight = 0.2972704626681536R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell5.StyleName = "DetailCaption3"
            Me.xrTableCell5.Text = "Fish Notes"
            Me.xrTableCell5.Weight = 0.48383992697360245R
            ' 
            ' groupFooterBand1
            ' 
            Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2})
            Me.groupFooterBand1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
            Me.groupFooterBand1.HeightF = 6F
            Me.groupFooterBand1.Name = "groupFooterBand1"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(650F, 2.08F)
            Me.xrLabel2.StyleName = "GroupCaption3"
            Me.xrLabel2.StylePriority.UseBorders = False
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Tahoma", 14F)
            Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.Title.Name = "Title"
            ' 
            ' GroupCaption3
            ' 
            Me.GroupCaption3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((137)))))), (CInt(((CByte((137)))))), (CInt(((CByte((137)))))))
            Me.GroupCaption3.BorderColor = System.Drawing.Color.White
            Me.GroupCaption3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupCaption3.BorderWidth = 2F
            Me.GroupCaption3.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.GroupCaption3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((228)))))), (CInt(((CByte((228)))))), (CInt(((CByte((228)))))))
            Me.GroupCaption3.Name = "GroupCaption3"
            Me.GroupCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' GroupData3
            ' 
            Me.GroupData3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((137)))))), (CInt(((CByte((137)))))), (CInt(((CByte((137)))))))
            Me.GroupData3.BorderColor = System.Drawing.Color.White
            Me.GroupData3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupData3.BorderWidth = 2F
            Me.GroupData3.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.GroupData3.ForeColor = System.Drawing.Color.White
            Me.GroupData3.Name = "GroupData3"
            Me.GroupData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailCaption3
            ' 
            Me.DetailCaption3.BackColor = System.Drawing.Color.Transparent
            Me.DetailCaption3.BorderColor = System.Drawing.Color.Transparent
            Me.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailCaption3.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.DetailCaption3.Name = "DetailCaption3"
            Me.DetailCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3
            ' 
            Me.DetailData3.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.DetailData3.ForeColor = System.Drawing.Color.Black
            Me.DetailData3.Name = "DetailData3"
            Me.DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3_Odd
            ' 
            Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((231)))))), (CInt(((CByte((231)))))), (CInt(((CByte((231)))))))
            Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailData3_Odd.BorderWidth = 1F
            Me.DetailData3_Odd.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
            Me.DetailData3_Odd.Name = "DetailData3_Odd"
            Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailCaptionBackground3
            ' 
            Me.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent
            Me.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((206)))))), (CInt(((CByte((206)))))), (CInt(((CByte((206)))))))
            Me.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.DetailCaptionBackground3.BorderWidth = 2F
            Me.DetailCaptionBackground3.Name = "DetailCaptionBackground3"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.PageInfo.Name = "PageInfo"
            Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' objectDataSource1
            ' 
            parameter1.Name = "filePath"
            parameter1.Type = GetType(String)
            parameter1.ValueInfo = "Fishes.txt"
            objectConstructorInfo1.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() {parameter1})
            Me.objectDataSource1.Constructor = objectConstructorInfo1
            Me.objectDataSource1.DataSource = GetType(ObjectDataSource.Fishes)
            Me.objectDataSource1.Name = "objectDataSource1"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.reportHeaderBand1, Me.groupHeaderBand1, Me.groupHeaderBand2, Me.groupFooterBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDataSource1})
            Me.DataSource = Me.objectDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.GroupCaption3, Me.GroupData3, Me.DetailCaption3, Me.DetailData3, Me.DetailData3_Odd, Me.DetailCaptionBackground3, Me.PageInfo})
            Me.Version = "18.1"
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrTable3 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

        Private reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private groupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrPanel1 As DevExpress.XtraReports.UI.XRPanel

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private Title As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupCaption3 As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupData3 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailCaption3 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailData3 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailCaptionBackground3 As DevExpress.XtraReports.UI.XRControlStyle

        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    End Class
End Namespace
