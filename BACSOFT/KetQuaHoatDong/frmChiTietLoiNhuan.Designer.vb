﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietLoiNhuan
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gdv = New DevExpress.XtraGrid.GridControl()
        Me.gdvCT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.rpopupFile = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.gdvBCThuTien = New DevExpress.XtraGrid.GridControl()
        Me.gdvBCThuTienCT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDuyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.mDuyetDiem = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btTaiLai = New DevExpress.XtraEditors.LabelControl()
        CType(Me.gdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpopupFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.gdvBCThuTien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvBCThuTienCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdv
        '
        Me.gdv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdv.Location = New System.Drawing.Point(2, 22)
        Me.gdv.MainView = Me.gdvCT
        Me.gdv.Name = "gdv"
        Me.gdv.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.rpopupFile, Me.RepositoryItemHyperLinkEdit1})
        Me.gdv.Size = New System.Drawing.Size(1000, 294)
        Me.gdv.TabIndex = 7
        Me.gdv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvCT})
        '
        'gdvCT
        '
        Me.gdvCT.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gdvCT.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gdvCT.Appearance.FocusedRow.BackColor = System.Drawing.Color.PowderBlue
        Me.gdvCT.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gdvCT.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvCT.Appearance.GroupFooter.Options.UseFont = True
        Me.gdvCT.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gdvCT.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gdvCT.Appearance.GroupRow.Options.UseFont = True
        Me.gdvCT.Appearance.GroupRow.Options.UseForeColor = True
        Me.gdvCT.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvCT.Appearance.HeaderPanel.Options.UseFont = True
        Me.gdvCT.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gdvCT.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdvCT.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.PowderBlue
        Me.gdvCT.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gdvCT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn6, Me.GridColumn14, Me.GridColumn4, Me.GridColumn5, Me.GridColumn12, Me.GridColumn13, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11})
        Me.gdvCT.GridControl = Me.gdv
        Me.gdvCT.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.gdvCT.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienThu", Me.GridColumn6, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienChietKhau", Me.GridColumn13, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LoiNhuanKD", Me.GridColumn9, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LoiNhuanKT", Me.GridColumn10, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Ngay", Me.GridColumn1, "{0:N0}")})
        Me.gdvCT.Name = "gdvCT"
        Me.gdvCT.OptionsBehavior.AutoExpandAllGroups = True
        Me.gdvCT.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused
        Me.gdvCT.OptionsBehavior.ReadOnly = True
        Me.gdvCT.OptionsFind.AllowFindPanel = False
        Me.gdvCT.OptionsView.ColumnAutoWidth = False
        Me.gdvCT.OptionsView.EnableAppearanceEvenRow = True
        Me.gdvCT.OptionsView.RowAutoHeight = True
        Me.gdvCT.OptionsView.ShowAutoFilterRow = True
        Me.gdvCT.OptionsView.ShowFooter = True
        Me.gdvCT.RowHeight = 22
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Ngày"
        Me.GridColumn1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Ngay"
        Me.GridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 85
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.Caption = "Mã KH"
        Me.GridColumn2.FieldName = "ttcMa"
        Me.GridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 125
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Phiếu XK"
        Me.GridColumn3.FieldName = "SoPhieuXK"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.SummaryItem.DisplayFormat = "{0:N0}"
        Me.GridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tiền thu"
        Me.GridColumn6.DisplayFormat.FormatString = "N0"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "TienThu"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.SummaryItem.DisplayFormat = "{0:N0}"
        Me.GridColumn6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 103
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Số ngày"
        Me.GridColumn14.FieldName = "SoNgay"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "PhieuCG"
        Me.GridColumn4.FieldName = "SoPhieuCG"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Số YC"
        Me.GridColumn5.FieldName = "MaSoDatHang"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 6
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "CT"
        Me.GridColumn12.FieldName = "CongTrinh"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 7
        Me.GridColumn12.Width = 32
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Tiền chiết khấu"
        Me.GridColumn13.DisplayFormat.FormatString = "N0"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "TienChietKhau"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 8
        Me.GridColumn13.Width = 96
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tỷ suất LN"
        Me.GridColumn7.DisplayFormat.FormatString = "N2"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "TySuatLN"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 9
        Me.GridColumn7.Width = 68
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "HSLN KD"
        Me.GridColumn8.DisplayFormat.FormatString = "N2"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "HSLNKD"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 10
        Me.GridColumn8.Width = 57
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Lợi nhuận KD"
        Me.GridColumn9.DisplayFormat.FormatString = "N0"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "LoiNhuanKD"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.SummaryItem.DisplayFormat = "{0:N0}"
        Me.GridColumn9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 11
        Me.GridColumn9.Width = 101
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Lợi nhuận KT"
        Me.GridColumn10.DisplayFormat.FormatString = "N0"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "LoiNhuanKT"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.SummaryItem.DisplayFormat = "{0:N0}"
        Me.GridColumn10.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 12
        Me.GridColumn10.Width = 100
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "TakeCare"
        Me.GridColumn11.FieldName = "TakeCare"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 13
        Me.GridColumn11.Width = 139
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'rpopupFile
        '
        Me.rpopupFile.AutoHeight = False
        Me.rpopupFile.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpopupFile.Name = "rpopupFile"
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1004, 702)
        Me.SplitContainerControl1.SplitterPosition = 318
        Me.SplitContainerControl1.TabIndex = 8
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btTaiLai)
        Me.GroupControl1.Controls.Add(Me.gdv)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1004, 318)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Chi tiết phiếu thu trên hệ thống"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.gdvBCThuTien)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.BarManager1.SetPopupContextMenu(Me.GroupControl2, Me.PopupMenu1)
        Me.GroupControl2.Size = New System.Drawing.Size(1004, 379)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Chi tiết báo cáo thu tiền của nhân viên"
        '
        'gdvBCThuTien
        '
        Me.gdvBCThuTien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdvBCThuTien.Location = New System.Drawing.Point(2, 22)
        Me.gdvBCThuTien.MainView = Me.gdvBCThuTienCT
        Me.gdvBCThuTien.Name = "gdvBCThuTien"
        Me.gdvBCThuTien.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemHyperLinkEdit2})
        Me.gdvBCThuTien.Size = New System.Drawing.Size(1000, 355)
        Me.gdvBCThuTien.TabIndex = 8
        Me.gdvBCThuTien.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvBCThuTienCT})
        '
        'gdvBCThuTienCT
        '
        Me.gdvBCThuTienCT.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gdvBCThuTienCT.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gdvBCThuTienCT.Appearance.FocusedRow.BackColor = System.Drawing.Color.PowderBlue
        Me.gdvBCThuTienCT.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gdvBCThuTienCT.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvBCThuTienCT.Appearance.GroupFooter.Options.UseFont = True
        Me.gdvBCThuTienCT.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gdvBCThuTienCT.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gdvBCThuTienCT.Appearance.GroupRow.Options.UseFont = True
        Me.gdvBCThuTienCT.Appearance.GroupRow.Options.UseForeColor = True
        Me.gdvBCThuTienCT.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvBCThuTienCT.Appearance.HeaderPanel.Options.UseFont = True
        Me.gdvBCThuTienCT.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gdvBCThuTienCT.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdvBCThuTienCT.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.PowderBlue
        Me.gdvBCThuTienCT.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gdvBCThuTienCT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.colDuyet, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25})
        Me.gdvBCThuTienCT.GridControl = Me.gdvBCThuTien
        Me.gdvBCThuTienCT.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.gdvBCThuTienCT.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NgayBaoCao", Me.GridColumn15, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", Me.GridColumn20, "{0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KhoiLuong", Me.GridColumn21, "{0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Diem", Me.GridColumn22, "{0:N2}")})
        Me.gdvBCThuTienCT.Name = "gdvBCThuTienCT"
        Me.gdvBCThuTienCT.OptionsBehavior.AutoExpandAllGroups = True
        Me.gdvBCThuTienCT.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused
        Me.gdvBCThuTienCT.OptionsFind.AllowFindPanel = False
        Me.gdvBCThuTienCT.OptionsView.ColumnAutoWidth = False
        Me.gdvBCThuTienCT.OptionsView.EnableAppearanceEvenRow = True
        Me.gdvBCThuTienCT.OptionsView.RowAutoHeight = True
        Me.gdvBCThuTienCT.OptionsView.ShowAutoFilterRow = True
        Me.gdvBCThuTienCT.OptionsView.ShowFooter = True
        Me.gdvBCThuTienCT.RowHeight = 22
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "Ngày báo cáo"
        Me.GridColumn15.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "NgayBaoCao"
        Me.GridColumn15.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.SummaryItem.DisplayFormat = "{0:N0}"
        Me.GridColumn15.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        Me.GridColumn15.Width = 85
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn16.AppearanceCell.Options.UseFont = True
        Me.GridColumn16.Caption = "Nhân viên"
        Me.GridColumn16.FieldName = "NhanVien"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 9
        Me.GridColumn16.Width = 146
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "Phiếu XK"
        Me.GridColumn17.FieldName = "SoPhieu"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 2
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Nội dung báo cáo"
        Me.GridColumn18.FieldName = "NoiDungBC"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 5
        Me.GridColumn18.Width = 207
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Chi tiết"
        Me.GridColumn19.FieldName = "ChiTiet"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 1
        Me.GridColumn19.Width = 222
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Số lượng"
        Me.GridColumn20.DisplayFormat.FormatString = "N2"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn20.FieldName = "SoLuong"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.ReadOnly = True
        Me.GridColumn20.SummaryItem.DisplayFormat = "{0:N2}"
        Me.GridColumn20.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 6
        Me.GridColumn20.Width = 57
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Khối lượng"
        Me.GridColumn21.DisplayFormat.FormatString = "N2"
        Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn21.FieldName = "KhoiLuong"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        Me.GridColumn21.SummaryItem.DisplayFormat = "{0:N2}"
        Me.GridColumn21.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 3
        Me.GridColumn21.Width = 100
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Điểm"
        Me.GridColumn22.DisplayFormat.FormatString = "N2"
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn22.FieldName = "Diem"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.ReadOnly = True
        Me.GridColumn22.SummaryItem.DisplayFormat = "{0:N2}"
        Me.GridColumn22.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 7
        Me.GridColumn22.Width = 76
        '
        'colDuyet
        '
        Me.colDuyet.Caption = "Duyệt"
        Me.colDuyet.FieldName = "Duyet"
        Me.colDuyet.Name = "colDuyet"
        Me.colDuyet.Visible = True
        Me.colDuyet.VisibleIndex = 8
        Me.colDuyet.Width = 44
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "ID"
        Me.GridColumn23.FieldName = "ID"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Modify"
        Me.GridColumn24.FieldName = "Modify"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Số ngày"
        Me.GridColumn25.FieldName = "SoNgay"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 4
        Me.GridColumn25.Width = 55
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        '
        'RepositoryItemHyperLinkEdit2
        '
        Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mDuyetDiem})
        Me.BarManager1.MaxItemId = 1
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mDuyetDiem)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'mDuyetDiem
        '
        Me.mDuyetDiem.Caption = "Duyệt điểm"
        Me.mDuyetDiem.Glyph = Global.BACSOFT.My.Resources.Resources.Accept_18
        Me.mDuyetDiem.Id = 0
        Me.mDuyetDiem.Name = "mDuyetDiem"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1004, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 702)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1004, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 702)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1004, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 702)
        '
        'btTaiLai
        '
        Me.btTaiLai.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btTaiLai.Appearance.Image = Global.BACSOFT.My.Resources.Resources.refresh_18
        Me.btTaiLai.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btTaiLai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btTaiLai.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btTaiLai.Location = New System.Drawing.Point(173, 0)
        Me.btTaiLai.Name = "btTaiLai"
        Me.btTaiLai.Size = New System.Drawing.Size(56, 22)
        Me.btTaiLai.TabIndex = 8
        Me.btTaiLai.Text = "Tải lại"
        '
        'frmChiTietLoiNhuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 702)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmChiTietLoiNhuan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chi tiết lợi nhuận"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpopupFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.gdvBCThuTien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvBCThuTienCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gdv As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvCT As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rpopupFile As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdvBCThuTien As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvBCThuTienCT As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mDuyetDiem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btTaiLai As DevExpress.XtraEditors.LabelControl
End Class
