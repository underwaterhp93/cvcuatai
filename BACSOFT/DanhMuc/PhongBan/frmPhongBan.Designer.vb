﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhongBan
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btTim = New DevExpress.XtraBars.BarButtonItem()
        Me.btAn = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnPhanQuyen = New DevExpress.XtraBars.BarButtonItem()
        Me.mThem = New DevExpress.XtraBars.BarButtonItem()
        Me.mPhanQuyen = New DevExpress.XtraBars.BarButtonItem()
        Me.mXoa = New DevExpress.XtraBars.BarButtonItem()
        Me.mNgungSD = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.gdv = New DevExpress.XtraGrid.GridControl()
        Me.gdvChiTiet = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btXoa = New DevExpress.XtraBars.BarButtonItem()
        Me.btSua = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem2, Me.btTim, Me.btAn, Me.BarEditItem1, Me.btnPhanQuyen, Me.mThem, Me.mPhanQuyen, Me.mXoa, Me.mNgungSD})
        Me.BarManager1.MaxItemId = 17
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit1})
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(749, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 466)
        Me.barDockControlBottom.Size = New System.Drawing.Size(749, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 466)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(749, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 466)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem2.Appearance.Options.UseFont = True
        Me.BarButtonItem2.Caption = "Sửa"
        Me.BarButtonItem2.Glyph = Global.BACSOFT.My.Resources.Resources.Edit_18
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btTim
        '
        Me.btTim.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btTim.Appearance.Options.UseFont = True
        Me.btTim.Caption = "Tìm"
        Me.btTim.Glyph = Global.BACSOFT.My.Resources.Resources.Search_18
        Me.btTim.Id = 8
        Me.btTim.Name = "btTim"
        Me.btTim.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btAn
        '
        Me.btAn.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btAn.Appearance.Options.UseFont = True
        Me.btAn.Caption = "Ẩn"
        Me.btAn.Glyph = Global.BACSOFT.My.Resources.Resources.close_18
        Me.btAn.Id = 9
        Me.btAn.Name = "btAn"
        Me.btAn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemLookUpEdit1
        Me.BarEditItem1.Id = 10
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 183
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'btnPhanQuyen
        '
        Me.btnPhanQuyen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPhanQuyen.Appearance.Options.UseFont = True
        Me.btnPhanQuyen.Caption = "Phân quyền"
        Me.btnPhanQuyen.Id = 11
        Me.btnPhanQuyen.Name = "btnPhanQuyen"
        Me.btnPhanQuyen.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'mThem
        '
        Me.mThem.Caption = "Thêm"
        Me.mThem.Glyph = Global.BACSOFT.My.Resources.Resources.AddNew_18
        Me.mThem.Id = 13
        Me.mThem.Name = "mThem"
        '
        'mPhanQuyen
        '
        Me.mPhanQuyen.Caption = "Phân quyền"
        Me.mPhanQuyen.Glyph = Global.BACSOFT.My.Resources.Resources.GroupKey_18
        Me.mPhanQuyen.Id = 14
        Me.mPhanQuyen.Name = "mPhanQuyen"
        '
        'mXoa
        '
        Me.mXoa.Caption = "Xóa"
        Me.mXoa.Glyph = Global.BACSOFT.My.Resources.Resources.Delete_18
        Me.mXoa.Id = 15
        Me.mXoa.Name = "mXoa"
        '
        'mNgungSD
        '
        Me.mNgungSD.Caption = "Ngừng sử dụng"
        Me.mNgungSD.Glyph = Global.BACSOFT.My.Resources.Resources.warning_18
        Me.mNgungSD.Id = 16
        Me.mNgungSD.Name = "mNgungSD"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mPhanQuyen), New DevExpress.XtraBars.LinkPersistInfo(Me.mXoa)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'gdv
        '
        Me.gdv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdv.Location = New System.Drawing.Point(0, 0)
        Me.gdv.MainView = Me.gdvChiTiet
        Me.gdv.MenuManager = Me.BarManager1
        Me.gdv.Name = "gdv"
        Me.gdv.Size = New System.Drawing.Size(749, 466)
        Me.gdv.TabIndex = 4
        Me.gdv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvChiTiet})
        '
        'gdvChiTiet
        '
        Me.gdvChiTiet.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gdvChiTiet.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gdvChiTiet.Appearance.FocusedRow.BackColor = System.Drawing.Color.PowderBlue
        Me.gdvChiTiet.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gdvChiTiet.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvChiTiet.Appearance.HeaderPanel.Options.UseFont = True
        Me.gdvChiTiet.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gdvChiTiet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdvChiTiet.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.PowderBlue
        Me.gdvChiTiet.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gdvChiTiet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.gdvChiTiet.FixedLineWidth = 1
        Me.gdvChiTiet.GridControl = Me.gdv
        Me.gdvChiTiet.Name = "gdvChiTiet"
        Me.gdvChiTiet.OptionsBehavior.Editable = False
        Me.gdvChiTiet.OptionsCustomization.AllowColumnMoving = False
        Me.gdvChiTiet.OptionsCustomization.AllowGroup = False
        Me.gdvChiTiet.OptionsLayout.Columns.AddNewColumns = False
        Me.gdvChiTiet.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gdvChiTiet.OptionsView.EnableAppearanceEvenRow = True
        Me.gdvChiTiet.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gdvChiTiet.OptionsView.ShowFooter = True
        Me.gdvChiTiet.OptionsView.ShowGroupPanel = False
        Me.gdvChiTiet.RowHeight = 23
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Mã"
        Me.GridColumn2.FieldName = "ID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 119
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Phòng ban"
        Me.GridColumn3.FieldName = "Ten"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.SummaryItem.DisplayFormat = "{0:N0}"
        Me.GridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 138
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "ID"
        Me.GridColumn4.FieldName = "ID2"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btXoa
        '
        Me.btXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btXoa.Appearance.Options.UseFont = True
        Me.btXoa.Caption = "Xóa"
        Me.btXoa.Glyph = Global.BACSOFT.My.Resources.Resources.Delete_18
        Me.btXoa.Id = 6
        Me.btXoa.Name = "btXoa"
        Me.btXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btSua
        '
        Me.btSua.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btSua.Appearance.Options.UseFont = True
        Me.btSua.Caption = "Phân quyền"
        Me.btSua.Glyph = Global.BACSOFT.My.Resources.Resources.GroupKey_18
        Me.btSua.Id = 2
        Me.btSua.Name = "btSua"
        Me.btSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'frmPhongBan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gdv)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmPhongBan"
        Me.BarManager1.SetPopupContextMenu(Me, Me.PopupMenu1)
        Me.Size = New System.Drawing.Size(749, 466)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btTim As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btAn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gdv As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvChiTiet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnPhanQuyen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mThem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mPhanQuyen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mXoa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mNgungSD As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btXoa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btSua As DevExpress.XtraBars.BarButtonItem

End Class
