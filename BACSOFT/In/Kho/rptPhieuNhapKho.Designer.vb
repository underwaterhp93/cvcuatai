﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptPhieuNhapKho
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPhieuNhapKho))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.tbDetail = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.cellSTTCT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellTenVTCT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.CellHangSXCT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellMaVTCT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellDVTCT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellSLCT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.tbHeader = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.cellSTT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellTenVT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellHangSX = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellMaVT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellDVT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cellSL = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        CType(Me.tbDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tbDetail})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'tbDetail
        '
        Me.tbDetail.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.tbDetail.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.tbDetail.LocationFloat = New DevExpress.Utils.PointFloat(35.45829!, 0.0!)
        Me.tbDetail.Name = "tbDetail"
        Me.tbDetail.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.tbDetail.SizeF = New System.Drawing.SizeF(725.0001!, 25.0!)
        Me.tbDetail.StylePriority.UseBorders = False
        Me.tbDetail.StylePriority.UseFont = False
        Me.tbDetail.StylePriority.UseTextAlignment = False
        Me.tbDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.cellSTTCT, Me.cellTenVTCT, Me.CellHangSXCT, Me.cellMaVTCT, Me.cellDVTCT, Me.cellSLCT})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'cellSTTCT
        '
        Me.cellSTTCT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table1.STT")})
        Me.cellSTTCT.Name = "cellSTTCT"
        Me.cellSTTCT.Text = "STT"
        Me.cellSTTCT.Weight = 0.16597514576895833R
        '
        'cellTenVTCT
        '
        Me.cellTenVTCT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table1.TenVT")})
        Me.cellTenVTCT.Name = "cellTenVTCT"
        Me.cellTenVTCT.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.cellTenVTCT.StylePriority.UsePadding = False
        Me.cellTenVTCT.StylePriority.UseTextAlignment = False
        Me.cellTenVTCT.Text = "Tên vật tư"
        Me.cellTenVTCT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.cellTenVTCT.Weight = 0.99585112787172392R
        '
        'CellHangSXCT
        '
        Me.CellHangSXCT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table1.TenHang")})
        Me.CellHangSXCT.Name = "CellHangSXCT"
        Me.CellHangSXCT.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.CellHangSXCT.StylePriority.UsePadding = False
        Me.CellHangSXCT.StylePriority.UseTextAlignment = False
        Me.CellHangSXCT.Text = "Hãng SX"
        Me.CellHangSXCT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.CellHangSXCT.Weight = 0.49792543730687483R
        '
        'cellMaVTCT
        '
        Me.cellMaVTCT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table1.Model")})
        Me.cellMaVTCT.Name = "cellMaVTCT"
        Me.cellMaVTCT.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.cellMaVTCT.StylePriority.UsePadding = False
        Me.cellMaVTCT.StylePriority.UseTextAlignment = False
        Me.cellMaVTCT.Text = "Mã vật tư"
        Me.cellMaVTCT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.cellMaVTCT.Weight = 0.788381942402552R
        '
        'cellDVTCT
        '
        Me.cellDVTCT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table1.TenDVT")})
        Me.cellDVTCT.Name = "cellDVTCT"
        Me.cellDVTCT.Text = "ĐVT"
        Me.cellDVTCT.Weight = 0.26970935861658346R
        '
        'cellSLCT
        '
        Me.cellSLCT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table1.SoLuong")})
        Me.cellSLCT.Name = "cellSLCT"
        Me.cellSLCT.Text = "Số lượng"
        Me.cellSLCT.Weight = 0.29045675835365092R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 17.70833!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.BottomMargin.HeightF = 46.875!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(660.4586!, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(270.6586!, 106.525!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(246.9!, 30.29997!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "PHIẾU NHẬP KHO"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(62.25834!, 20.74998!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(158.3334!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "NHÀ CUNG CẤP"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(543.3!, 20.74998!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(198.9583!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "CTY CP DVKT BẢO AN"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel4})
        Me.ReportFooter.HeightF = 132.2917!
        Me.ReportFooter.KeepTogether = True
        Me.ReportFooter.Name = "ReportFooter"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel14, Me.XrLine3, Me.pLogo, Me.XrLabel3, Me.tbHeader, Me.XrLabel12, Me.XrLabel11, Me.XrLine2, Me.XrLine1, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel1})
        Me.ReportHeader.HeightF = 285.8333!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'tbHeader
        '
        Me.tbHeader.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.tbHeader.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.tbHeader.LocationFloat = New DevExpress.Utils.PointFloat(35.4586!, 260.8333!)
        Me.tbHeader.Name = "tbHeader"
        Me.tbHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.tbHeader.SizeF = New System.Drawing.SizeF(725.0!, 25.0!)
        Me.tbHeader.StylePriority.UseBorders = False
        Me.tbHeader.StylePriority.UseFont = False
        Me.tbHeader.StylePriority.UseTextAlignment = False
        Me.tbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.cellSTT, Me.cellTenVT, Me.cellHangSX, Me.cellMaVT, Me.cellDVT, Me.cellSL})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'cellSTT
        '
        Me.cellSTT.Name = "cellSTT"
        Me.cellSTT.Text = "STT"
        Me.cellSTT.Weight = 0.16597514576895833R
        '
        'cellTenVT
        '
        Me.cellTenVT.Name = "cellTenVT"
        Me.cellTenVT.Text = "Tên vật tư"
        Me.cellTenVT.Weight = 0.99585087461375R
        '
        'cellHangSX
        '
        Me.cellHangSX.Name = "cellHangSX"
        Me.cellHangSX.Text = "Hãng SX"
        Me.cellHangSX.Weight = 0.49792543730687489R
        '
        'cellMaVT
        '
        Me.cellMaVT.Name = "cellMaVT"
        Me.cellMaVT.Text = "Mã vật tư"
        Me.cellMaVT.Weight = 0.788381942402552R
        '
        'cellDVT
        '
        Me.cellDVT.Name = "cellDVT"
        Me.cellDVT.Text = "ĐVT"
        Me.cellDVT.Weight = 0.26970961187455728R
        '
        'cellSL
        '
        Me.cellSL.Name = "cellSL"
        Me.cellSL.Text = "Số lượng"
        Me.cellSL.Weight = 0.29045650509567711R
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.PhieuNhap")})
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(463.3751!, 225.6!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(297.0834!, 23.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.DatHang")})
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(35.45829!, 225.6!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(414.5834!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(35.45829!, 248.5999!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(725.0001!, 2.0!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(35.45833!, 223.5999!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(725.0!, 2.0!)
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.NguoiNhap")})
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(463.3751!, 200.6!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(297.0835!, 23.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel10"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.ChucDanh")})
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(35.45833!, 200.6!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(414.5833!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "XrLabel9"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.Kho")})
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(463.3751!, 177.5999!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(297.0835!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.DaiDien")})
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(35.45833!, 177.5999!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(414.5833!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.Ngay")})
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(463.3751!, 154.5999!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(297.0835!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "XrLabel6"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Table.TenNCC")})
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(35.45833!, 154.5999!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(414.5833!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'pLogo
        '
        Me.pLogo.LocationFloat = New DevExpress.Utils.PointFloat(35.4586!, 10.0!)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.SizeF = New System.Drawing.SizeF(159.2001!, 70.0!)
        Me.pLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(194.6586!, 10.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(547.5999!, 28.20834!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "CÔNG TY CỔ PHẦN DỊCH VỤ KỸ THUẬT BẢO AN"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(270.6586!, 38.20834!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(419.7584!, 50.675!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Địa chỉ: Vân Tra - An Đồng - An Dương - Hải Phòng" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tell: 0313.797877/ 78/ 79" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Fax" & _
    ": 0313.686182" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Website: www.baoanjsc.com.vn" & Global.Microsoft.VisualBasic.ChrW(9) & "Email: baoanjsc@gmail.com"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(35.4586!, 88.90002!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(724.9998!, 2.0!)
        '
        'rptPhieuNhapKho
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter, Me.ReportHeader})
        Me.DataMember = "Table1"
        Me.DataSourceSchema = resources.GetString("$this.DataSourceSchema")
        Me.DrawGrid = False
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Margins = New System.Drawing.Printing.Margins(18, 27, 18, 47)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.RequestParameters = False
        Me.ShowPrintMarginsWarning = False
        Me.SnapGridSize = 0.1!
        Me.Version = "10.2"
        CType(Me.tbDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tbHeader As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents cellSTT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellTenVT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellHangSX As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellMaVT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellDVT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellSL As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tbDetail As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents cellSTTCT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellTenVTCT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CellHangSXCT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellMaVTCT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellDVTCT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cellSLCT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents pLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
End Class
