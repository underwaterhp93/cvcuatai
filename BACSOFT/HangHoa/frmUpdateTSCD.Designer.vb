﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateTSCD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateTSCD))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbTenVT = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmHangSX = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbDVT = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtModel = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenHoaDon = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btGhiVaDuaVaoHD = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGhiVaThemMoiVT = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbNhonVatTu = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.cmbTenVT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmHangSX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDVT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenHoaDon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNhonVatTu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 21)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tên vật tư"
        '
        'cmbTenVT
        '
        Me.cmbTenVT.Location = New System.Drawing.Point(96, 19)
        Me.cmbTenVT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTenVT.Name = "cmbTenVT"
        Me.cmbTenVT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTenVT.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ten", "Name2")})
        Me.cmbTenVT.Properties.DisplayMember = "ten"
        Me.cmbTenVT.Properties.DropDownItemHeight = 25
        Me.cmbTenVT.Properties.DropDownRows = 10
        Me.cmbTenVT.Properties.ImmediatePopup = True
        Me.cmbTenVT.Properties.NullText = "[Chọn tên vật tư]"
        Me.cmbTenVT.Properties.ShowHeader = False
        Me.cmbTenVT.Properties.ShowLines = False
        Me.cmbTenVT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbTenVT.Properties.ValueMember = "Id"
        Me.cmbTenVT.Size = New System.Drawing.Size(308, 20)
        Me.cmbTenVT.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 89)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Hãng sản xuất"
        '
        'cmHangSX
        '
        Me.cmHangSX.Location = New System.Drawing.Point(96, 85)
        Me.cmHangSX.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmHangSX.Name = "cmHangSX"
        Me.cmHangSX.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmHangSX.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN", "Name2")})
        Me.cmHangSX.Properties.DisplayMember = "TEN"
        Me.cmHangSX.Properties.DropDownItemHeight = 25
        Me.cmHangSX.Properties.DropDownRows = 10
        Me.cmHangSX.Properties.ImmediatePopup = True
        Me.cmHangSX.Properties.NullText = "[Chọn hãng sản xuất]"
        Me.cmHangSX.Properties.ShowHeader = False
        Me.cmHangSX.Properties.ShowLines = False
        Me.cmHangSX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmHangSX.Properties.ValueMember = "ID"
        Me.cmHangSX.Size = New System.Drawing.Size(134, 20)
        Me.cmHangSX.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(235, 89)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Đơn vị tính"
        '
        'cmbDVT
        '
        Me.cmbDVT.Location = New System.Drawing.Point(297, 85)
        Me.cmbDVT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDVT.Name = "cmbDVT"
        Me.cmbDVT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDVT.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN", "Name2")})
        Me.cmbDVT.Properties.DisplayMember = "TEN"
        Me.cmbDVT.Properties.DropDownItemHeight = 25
        Me.cmbDVT.Properties.DropDownRows = 10
        Me.cmbDVT.Properties.ImmediatePopup = True
        Me.cmbDVT.Properties.NullText = "[Chọn ĐVT]"
        Me.cmbDVT.Properties.ShowHeader = False
        Me.cmbDVT.Properties.ShowLines = False
        Me.cmbDVT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbDVT.Properties.ValueMember = "ID"
        Me.cmbDVT.Size = New System.Drawing.Size(107, 20)
        Me.cmbDVT.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(10, 125)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Model"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(96, 121)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(309, 20)
        Me.txtModel.TabIndex = 7
        '
        'txtTenHoaDon
        '
        Me.txtTenHoaDon.Location = New System.Drawing.Point(96, 153)
        Me.txtTenHoaDon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTenHoaDon.Name = "txtTenHoaDon"
        Me.txtTenHoaDon.Size = New System.Drawing.Size(309, 64)
        Me.txtTenHoaDon.TabIndex = 8
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(10, 156)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Tên hóa đơn"
        '
        'btGhiVaDuaVaoHD
        '
        Me.btGhiVaDuaVaoHD.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btGhiVaDuaVaoHD.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.btGhiVaDuaVaoHD.Appearance.Options.UseFont = True
        Me.btGhiVaDuaVaoHD.Appearance.Options.UseForeColor = True
        Me.btGhiVaDuaVaoHD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGhiVaDuaVaoHD.Image = CType(resources.GetObject("btGhiVaDuaVaoHD.Image"), System.Drawing.Image)
        Me.btGhiVaDuaVaoHD.Location = New System.Drawing.Point(259, 231)
        Me.btGhiVaDuaVaoHD.Name = "btGhiVaDuaVaoHD"
        Me.btGhiVaDuaVaoHD.Size = New System.Drawing.Size(145, 30)
        Me.btGhiVaDuaVaoHD.TabIndex = 10
        Me.btGhiVaDuaVaoHD.Text = "Ghi lại và đóng"
        '
        'btnGhiVaThemMoiVT
        '
        Me.btnGhiVaThemMoiVT.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGhiVaThemMoiVT.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.btnGhiVaThemMoiVT.Appearance.Options.UseFont = True
        Me.btnGhiVaThemMoiVT.Appearance.Options.UseForeColor = True
        Me.btnGhiVaThemMoiVT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGhiVaThemMoiVT.Image = CType(resources.GetObject("btnGhiVaThemMoiVT.Image"), System.Drawing.Image)
        Me.btnGhiVaThemMoiVT.Location = New System.Drawing.Point(95, 231)
        Me.btnGhiVaThemMoiVT.Name = "btnGhiVaThemMoiVT"
        Me.btnGhiVaThemMoiVT.Size = New System.Drawing.Size(159, 30)
        Me.btnGhiVaThemMoiVT.TabIndex = 11
        Me.btnGhiVaThemMoiVT.Text = "Ghi lại và thêm mới"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 55)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "Nhóm vật tư"
        '
        'cmbNhonVatTu
        '
        Me.cmbNhonVatTu.Location = New System.Drawing.Point(96, 51)
        Me.cmbNhonVatTu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbNhonVatTu.Name = "cmbNhonVatTu"
        Me.cmbNhonVatTu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNhonVatTu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ten", "Name2")})
        Me.cmbNhonVatTu.Properties.DisplayMember = "ten"
        Me.cmbNhonVatTu.Properties.DropDownItemHeight = 25
        Me.cmbNhonVatTu.Properties.DropDownRows = 10
        Me.cmbNhonVatTu.Properties.ImmediatePopup = True
        Me.cmbNhonVatTu.Properties.NullText = "[Chọn nhóm vật tư]"
        Me.cmbNhonVatTu.Properties.ShowHeader = False
        Me.cmbNhonVatTu.Properties.ShowLines = False
        Me.cmbNhonVatTu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbNhonVatTu.Properties.ValueMember = "Id"
        Me.cmbNhonVatTu.Size = New System.Drawing.Size(308, 20)
        Me.cmbNhonVatTu.TabIndex = 13
        '
        'frmUpdateTSCD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 277)
        Me.Controls.Add(Me.cmbNhonVatTu)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.btnGhiVaThemMoiVT)
        Me.Controls.Add(Me.btGhiVaDuaVaoHD)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtTenHoaDon)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cmbDVT)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cmHangSX)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmbTenVT)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateTSCD"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tài sản cố định"
        CType(Me.cmbTenVT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmHangSX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDVT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenHoaDon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNhonVatTu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbTenVT As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmHangSX As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDVT As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtModel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenHoaDon As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btGhiVaDuaVaoHD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGhiVaThemMoiVT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbNhonVatTu As DevExpress.XtraEditors.LookUpEdit
End Class
