﻿Imports BACSOFT.Db.SqlHelper

Public Class frmCNNhomChiTieu

    Private Sub frmCNNhomChiTieu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadDS()
    End Sub

    Public Sub loadDS()
        AddParameterWhere("@Loai", LoaiTuDien.NhomChiTieu)
        Dim dt As DataTable = ExecuteSQLDataTable("SELECT ID,NoiDung,Ma FROM tblTuDien WHERE Loai=@Loai ORDER BY Ma")
        If Not dt Is Nothing Then
            gdv.DataSource = dt
        Else
            ShowBaoLoi(LoiNgoaiLe)
        End If
    End Sub


    Private Sub gdvCT_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gdvCT.CellValueChanged
        If e.Column.FieldName = "ID" Then Exit Sub
        If Not IsDBNull(gdvCT.GetFocusedRowCellValue("ID")) Or gdvCT.GetFocusedRowCellValue("ID") Is Nothing Then
            If Not KiemTraQuyenSuDung("Menu", Me.Tag, DanhMucQuyen.QuyenThem) Then Exit Sub
        Else
            If Not KiemTraQuyenSuDung("Menu", Me.Tag, DanhMucQuyen.QuyenSua) Then Exit Sub
        End If

        AddParameter("@NoiDung", gdvCT.GetFocusedRowCellValue("NoiDung"))
        AddParameter("@Loai", LoaiTuDien.NhomChiTieu)
        AddParameter("@Ma", gdvCT.GetFocusedRowCellValue("Ma"))
        If Not IsDBNull(gdvCT.GetFocusedRowCellValue("ID")) Or gdvCT.GetFocusedRowCellValue("ID") Is Nothing Then
            AddParameterWhere("@ID", gdvCT.GetFocusedRowCellValue("ID"))
            If doUpdate("tblTuDien", "ID=@ID") Is Nothing Then
                ShowBaoLoi(LoiNgoaiLe)
                loadDS()
            Else
                ShowAlert("Đã cập nhật nhóm chỉ tiêu !")
            End If
        Else
            objID = doInsert("tblTuDien")
            If objID Is Nothing Then
                ShowBaoLoi(LoiNgoaiLe)
                gdvCT.DeleteSelectedRows()
                loadDS()
            Else
                ShowAlert("Đã thêm nhóm chỉ tiêu !")
                gdvCT.SetFocusedRowCellValue("ID", objID)
            End If
        End If
    End Sub


    Private Sub gdvCT_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gdvCT.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Not KiemTraQuyenSuDung("Menu", Me.Tag, DanhMucQuyen.QuyenXoa) Then Exit Sub
            If ShowCauHoi("Xóa: " & gdvCT.GetFocusedRowCellValue("NoiDung") & " ?") Then
                AddParameterWhere("@ID", gdvCT.GetFocusedRowCellValue("ID"))
                If doDelete("tblTuDien", "ID=@ID") Is Nothing Then
                    ShowBaoLoi(LoiNgoaiLe)
                Else
                    gdvCT.DeleteSelectedRows()
                    ShowAlert("Đã xoá!")
                End If
            End If
        End If
    End Sub

    Private Sub frmNhomCongViec_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        fCNChiTieu.loadDSNhomChiTieu()
    End Sub
End Class