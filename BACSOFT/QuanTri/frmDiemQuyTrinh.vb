﻿Imports BACSOFT.Db.SqlHelper

Public Class frmDiemQuyTrinh

    Private Sub frmDiemQuyTrinh_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        loadDSPhong()
        LoadDS()
    End Sub

    Public Sub loadDSPhong()
        Dim tb As DataTable = ExecuteSQLDataTable("SELECT ID,Ten FROM DEPATMENT")
        If Not tb Is Nothing Then
            rcbPhong.DataSource = tb
        Else
            ShowBaoLoi(LoiNgoaiLe)
        End If
    End Sub

    Public Sub LoadDS()
        Dim sql As String = ""
        sql &= " SELECT NHANSU.IDDepatment, tblDiemQuyTrinh.ID, tblDiemQuyTrinh.ChiTiet,IDNhanVien,NHANSU.Ten AS NhanVien,IDQuyTrinh, NLTen.Ten AS QuyTrinh,"
        sql &= " 	((tblDiemQuyTrinh.Diem/100)*NLDanhSach.Diem)Diem,NLDanhSach.Diem AS DiemChuan,NgayThi,tblDiemQuyTrinh.FileDinhKem "
        sql &= " FROM tblDiemQuyTrinh"
        sql &= " 	LEFT JOIN NHANSU ON NHANSU.ID=tblDiemQuyTrinh.IDNhanVien "
        sql &= " 	LEFT JOIN NLDanhSach ON NLDanhSach.ID=tblDiemQuyTrinh.IDQuyTrinh"
        sql &= " 	LEFT JOIN NLTen ON NLDanhSach.IDTen=NLTen.ID"
        sql &= " ORDER BY QuyTrinh,NhanVien,NgayThi DESC"
        Dim dt As DataTable = ExecuteSQLDataTable(sql)
        If Not dt Is Nothing Then
            gdv.DataSource = dt
        Else
            ShowBaoLoi(LoiNgoaiLe)
        End If

    End Sub

    Private Sub btThem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btThem.ItemClick, mThem.ItemClick
        If Not KiemTraQuyenSuDung("Menu", Me.Parent.Tag, DanhMucQuyen.QuyenThem) Then Exit Sub
        Dim f As New frmCNDiemQuyTrinh
        TrangThai.isAddNew = True
        f.ShowDialog()
    End Sub

    Private Sub btSua_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btSua.ItemClick, mSua.ItemClick
        If Not KiemTraQuyenSuDung("Menu", Me.Parent.Tag, DanhMucQuyen.QuyenSua) Then Exit Sub
        If gdvCT.FocusedRowHandle < 0 Then Exit Sub
        Dim index As Integer = gdvCT.FocusedRowHandle
        TrangThai.isUpdate = True
        objID = gdvCT.GetFocusedRowCellValue("ID")
        Dim f As New frmCNDiemQuyTrinh
        f.ShowDialog()
        gdvCT.FocusedRowHandle = index
    End Sub

    Private Sub btXoa_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btXoa.ItemClick, mXoa.ItemClick
        If Not KiemTraQuyenSuDung("Menu", Me.Parent.Tag, DanhMucQuyen.QuyenXoa) Then Exit Sub
        If gdvCT.FocusedRowHandle < 0 Then Exit Sub
        If ShowCauHoi("Xoá mục được chọn ?") Then
            AddParameterWhere("@ID", gdvCT.GetFocusedRowCellValue("ID"))
            If doDelete("tblDiemQuyTrinh", "ID=@ID") Is Nothing Then
                ShowBaoLoi(LoiNgoaiLe)
            Else
                ShowAlert("Đã xoá !")
                LoadDS()
            End If
        End If


    End Sub
End Class
