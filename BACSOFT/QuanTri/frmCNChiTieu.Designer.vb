﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCNChiTieu
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
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rcbNhom = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.cbNhomChiTieu = New DevExpress.XtraBars.BarEditItem()
        Me.rcbNhomChiTieu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.gdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcbNhom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcbNhomChiTieu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdv
        '
        Me.gdv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdv.Location = New System.Drawing.Point(0, 27)
        Me.gdv.MainView = Me.gdvCT
        Me.gdv.Name = "gdv"
        Me.gdv.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.rcbNhom})
        Me.gdv.Size = New System.Drawing.Size(724, 432)
        Me.gdv.TabIndex = 6
        Me.gdv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvCT})
        '
        'gdvCT
        '
        Me.gdvCT.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gdvCT.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gdvCT.Appearance.FocusedRow.BackColor = System.Drawing.Color.PowderBlue
        Me.gdvCT.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gdvCT.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvCT.Appearance.HeaderPanel.Options.UseFont = True
        Me.gdvCT.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gdvCT.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdvCT.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.PowderBlue
        Me.gdvCT.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gdvCT.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gdvCT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn1, Me.GridColumn3, Me.GridColumn5, Me.GridColumn2})
        Me.gdvCT.FixedLineWidth = 1
        Me.gdvCT.GridControl = Me.gdv
        Me.gdvCT.Name = "gdvCT"
        Me.gdvCT.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused
        Me.gdvCT.OptionsCustomization.AllowColumnMoving = False
        Me.gdvCT.OptionsCustomization.AllowGroup = False
        Me.gdvCT.OptionsLayout.Columns.AddNewColumns = False
        Me.gdvCT.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gdvCT.OptionsView.EnableAppearanceEvenRow = True
        Me.gdvCT.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gdvCT.OptionsView.RowAutoHeight = True
        Me.gdvCT.OptionsView.ShowFooter = True
        Me.gdvCT.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "ID"
        Me.GridColumn4.FieldName = "ID"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "A-Z"
        Me.GridColumn1.FieldName = "Ma"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 54
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn3.Caption = "Chỉ tiêu"
        Me.GridColumn3.FieldName = "NoiDung"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.SummaryItem.DisplayFormat = "{0:N0}"
        Me.GridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 322
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Nhóm"
        Me.GridColumn5.ColumnEdit = Me.rcbNhom
        Me.GridColumn5.FieldName = "IDP"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 223
        '
        'rcbNhom
        '
        Me.rcbNhom.AutoHeight = False
        Me.rcbNhom.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rcbNhom.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoiDung", "Name2")})
        Me.rcbNhom.DisplayMember = "NoiDung"
        Me.rcbNhom.DropDownItemHeight = 22
        Me.rcbNhom.Name = "rcbNhom"
        Me.rcbNhom.NullText = ""
        Me.rcbNhom.ShowHeader = False
        Me.rcbNhom.ValueMember = "ID"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Mã"
        Me.GridColumn2.FieldName = "Diem"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cbNhomChiTieu})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rcbNhomChiTieu})
        '
        'Bar1
        '
        Me.Bar1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Bar1.Appearance.Options.UseFont = True
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cbNhomChiTieu)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'cbNhomChiTieu
        '
        Me.cbNhomChiTieu.Caption = "Nhóm chỉ tiêu"
        Me.cbNhomChiTieu.Edit = Me.rcbNhomChiTieu
        Me.cbNhomChiTieu.Id = 1
        Me.cbNhomChiTieu.Name = "cbNhomChiTieu"
        Me.cbNhomChiTieu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.cbNhomChiTieu.Width = 351
        '
        'rcbNhomChiTieu
        '
        Me.rcbNhomChiTieu.AutoHeight = False
        Me.rcbNhomChiTieu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.rcbNhomChiTieu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoiDung", "Name2")})
        Me.rcbNhomChiTieu.DisplayMember = "NoiDung"
        Me.rcbNhomChiTieu.DropDownItemHeight = 22
        Me.rcbNhomChiTieu.Name = "rcbNhomChiTieu"
        Me.rcbNhomChiTieu.NullText = "[Tất cả]"
        Me.rcbNhomChiTieu.ShowHeader = False
        Me.rcbNhomChiTieu.ValueMember = "ID"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(724, 27)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 459)
        Me.barDockControlBottom.Size = New System.Drawing.Size(724, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 27)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 432)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(724, 27)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 432)
        '
        'frmCNChiTieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 459)
        Me.Controls.Add(Me.gdv)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmCNChiTieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cập nhật chỉ tiêu"
        CType(Me.gdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcbNhom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcbNhomChiTieu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gdv As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvCT As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cbNhomChiTieu As DevExpress.XtraBars.BarEditItem
    Friend WithEvents rcbNhomChiTieu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rcbNhom As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
