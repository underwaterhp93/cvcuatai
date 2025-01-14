Imports System.Data.SqlClient
Imports System.Configuration

Namespace Db

    Public Class SqlHelper

        Public strSql As String = ""
        Protected Shared TimeOut As Integer = 10000

#Region "# SQLAuthenticationType #"
        Public Enum SQLAuthenticationType
            WindowsAuthentication = 0
            SQLServerAuthentication = 1
        End Enum
#End Region

#Region "# Property SQL Server  #"

        Protected Shared _ServerName As String = ""
        Protected Shared _DatabaseName As String = ""
        Protected Shared _SqlUserName As String = ""
        Protected Shared _SqlPassword As String = ""
        Protected Shared _Authentication As SQLAuthenticationType = SQLAuthenticationType.SQLServerAuthentication
        Protected Shared _SQLConnectionString As String = ""
        Protected Shared _objSqlConn As SqlConnection = New SqlConnection
        Protected Shared _LoiNgoaiLe As String = ""
        Protected Shared _MaLoi As Integer

        Public Shared Property ServerName() As String
            Get
                Return _ServerName
            End Get
            Set(ByVal value As String)
                _ServerName = value
            End Set
        End Property

        Public Shared Property DatabaseName() As String
            Get
                Return _DatabaseName
            End Get
            Set(ByVal value As String)
                _DatabaseName = value
            End Set
        End Property

        Public Shared Property SqlUserName() As String
            Get
                Return _SqlUserName
            End Get
            Set(ByVal value As String)
                _SqlUserName = value
            End Set
        End Property

        Public Shared Property SqlPassword() As String
            Get
                Return _SqlPassword
            End Get
            Set(ByVal value As String)
                _SqlPassword = value
            End Set
        End Property

        Public Shared Property Authentication() As SQLAuthenticationType
            Get
                Return _Authentication
            End Get
            Set(ByVal value As SQLAuthenticationType)
                _Authentication = value
            End Set
        End Property

        Public Shared Property SQLConnectionString() As String
            Get
                Return _SQLConnectionString
            End Get
            Set(ByVal value As String)
                _SQLConnectionString = value
            End Set
        End Property

        Public Shared Property LoiNgoaiLe() As String
            Get
                Return _LoiNgoaiLe
            End Get
            Set(ByVal value As String)
                _LoiNgoaiLe = value
            End Set
        End Property

        Public Shared Property objSqlConn() As SqlConnection
            Get
                Return _objSqlConn
            End Get
            Set(ByVal value As SqlConnection)
                _objSqlConn = value
            End Set
        End Property

        Public Property MaLoi() As Integer
            Get
                Return _MaLoi
            End Get
            Set(ByVal value As Integer)
                _MaLoi = value
            End Set
        End Property

#End Region

#Region "# Sub New -#"
        Public Sub New(ByVal strServerName As String, ByVal strDatabaseName As String, ByVal strUserNameSQL As String, ByVal strPasswordSQL As String, ByVal SQLAuthentication As SQLAuthenticationType)
            _ServerName = strServerName
            _DatabaseName = strDatabaseName
            _SqlUserName = strUserNameSQL
            _SqlPassword = strPasswordSQL
            _Authentication = SQLAuthentication
        End Sub
        Protected Overridable Overloads Sub Dispose()
            Try
                _objSqlConn.Dispose()
                _objSqlConnWithTrans.Dispose()
            Catch ex As Exception
            End Try
        End Sub
        Protected Overrides Sub Finalize()
            Dispose()
        End Sub
        Public Shared Sub Start(ByVal strServerName As String, ByVal strDatabaseName As String, ByVal strUserNameSQL As String, ByVal strPasswordSQL As String, ByVal SQLAuthentication As SQLAuthenticationType)
            _ServerName = strServerName
            _DatabaseName = strDatabaseName
            _SqlUserName = strUserNameSQL
            _SqlPassword = strPasswordSQL
            _Authentication = SQLAuthentication
        End Sub
#End Region

#Region "Kiểm tra kết nối"
        ''' <remarks>Đăng nhập server trả về connection</remarks>
        Public Shared Function testConnection() As Boolean
            Dim sqlConn As New SqlClient.SqlConnection
            sqlConn.ConnectionString = getSQLConnectionString()
            Try
                sqlConn.Open()
                Return True
            Catch ex As SqlClient.SqlException
                _MaLoi = ex.Number
                Select Case _MaLoi
                    Case 53
                        _LoiNgoaiLe = "Không thể kết nối đến máy chủ SQL SERVER" & vbCrLf
                        _LoiNgoaiLe &= "Vui lòng kiểm tra lại tên máy chủ hoặc xem dịch vụ SQL SERVER đã được START chưa!"
                    Case 18456
                        _LoiNgoaiLe = "Đăng nhập máy chủ SQL SERVER thất bại với tài khoản " & _SqlUserName & vbCrLf
                        _LoiNgoaiLe &= "Vui lòng kiểm tra lại tên hoặc mật khẩu đăng nhập SQL SERVER đã đúng chưa!"
                    Case 4060
                        _LoiNgoaiLe = "Không tìm thấy DATABASE  " & _DatabaseName & " trên máy chủ SQL SERVER" & vbCrLf
                        _LoiNgoaiLe &= "Vui lòng kiểm tra tên cơ sở dữ liệu đã chọn đúng chưa!"
                    Case Else
                        _LoiNgoaiLe = ex.Message
                End Select
                Return False
            Catch ex As Exception
                _MaLoi = -1
                _LoiNgoaiLe = ex.Message
            Finally
                sqlConn.Close()
                sqlConn.Dispose()
            End Try
        End Function
#End Region

#Region "# getSQLConnectionString #"
        Public Shared Function getSQLConnectionString() As String
            Try
                If _Authentication = SQLAuthenticationType.SQLServerAuthentication Then
                    _SQLConnectionString = String.Format("SERVER={0};DATABASE={1};UID={2};PWD={3};", ServerName, DatabaseName, SqlUserName, SqlPassword)
                Else
                    _SQLConnectionString = String.Format("DATA SOURCE={0}; INITIAL CATALOG={1};INTEGRATED SECURITY=SSPI; PERSIST SECURITY INFO=FALSE; TRUSTED_CONNECTION=YES", ServerName, DatabaseName)
                End If
                Return _SQLConnectionString
            Catch ex As Exception
                Return ""
            End Try
        End Function
#End Region

#Region "# AddParameter #"
        Protected Shared _objSqlParamtter As New List(Of SqlParameter)
        Protected Shared _objSqlParamtterWhere As New List(Of SqlParameter)
        Public Shared ReadOnly Property objSqlParamtter() As List(Of SqlParameter)
            Get
                Return _objSqlParamtter
            End Get
        End Property
        Public Shared ReadOnly Property objSqlParamtterWhere() As List(Of SqlParameter)
            Get
                Return _objSqlParamtterWhere
            End Get
        End Property
        Public Shared Sub AddParameter(ByVal parmName As String, ByVal parmValue As Object)
            If Not parmValue Is Nothing Then
                _objSqlParamtter.Add(New SqlParameter(parmName, parmValue))
            Else
                _objSqlParamtter.Add(New SqlParameter(parmName, DBNull.Value))
            End If
        End Sub
        Public Shared Sub AddParameterWhere(ByVal parmName As String, ByVal parmValue As Object)
            If Not parmValue Is Nothing Then
                _objSqlParamtterWhere.Add(New SqlParameter(parmName, parmValue))
            Else
                _objSqlParamtterWhere.Add(New SqlParameter(parmName, DBNull.Value))
            End If
        End Sub
#End Region

#Region "# Transaction #"
        Protected Shared _objTransaction As SqlTransaction = Nothing
        Protected Shared _objSqlConnWithTrans As SqlConnection = Nothing
        Public Shared Function BeginTransaction() As Boolean
            _objSqlConnWithTrans = New SqlConnection(getSQLConnectionString)
            Try
                _objSqlConnWithTrans.Open()
                _objTransaction = _objSqlConnWithTrans.BeginTransaction
                Return True
            Catch ex As Exception
                _LoiNgoaiLe = ex.Message
                Return False
            End Try
        End Function

        Public Shared Function ComitTransaction() As Boolean
            Try
                If _objSqlConnWithTrans Is Nothing Then Return False
                _objTransaction.Commit()
                If _objSqlConnWithTrans.State <> ConnectionState.Closed Then
                    _objSqlConnWithTrans.Close()
                    _objTransaction = Nothing
                    _objSqlConnWithTrans = Nothing
                End If
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Shared Function RollBackTransaction() As Boolean
            Try
                If _objSqlConnWithTrans Is Nothing Then Return False
                _objTransaction.Rollback()
                If _objSqlConnWithTrans.State <> ConnectionState.Closed Then
                    _objSqlConnWithTrans.Close()
                    _objTransaction = Nothing
                    _objSqlConnWithTrans = Nothing
                End If
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
#End Region

#Region "# ExecuteSQLDataTable #"
        Public Shared Function ExecuteSQLDataTable(ByVal sSQL As String) As DataTable
            Dim dt As New DataTable
            Dim _sqlCmd As New SqlCommand
            Try
                _objSqlConn = New SqlConnection(getSQLConnectionString)
                _sqlCmd.CommandText = sSQL
                _sqlCmd.Connection = _objSqlConn
                _sqlCmd.CommandTimeout = TimeOut
                _objSqlConn.Open()
                For Each p As SqlParameter In _objSqlParamtter
                    _sqlCmd.Parameters.Add(p)
                Next
                For Each p As SqlParameter In _objSqlParamtterWhere
                    _sqlCmd.Parameters.Add(p)
                Next
                Dim da As New SqlDataAdapter(_sqlCmd)
                da.Fill(dt)
                Return dt
            Catch ex As Exception
                _LoiNgoaiLe = ex.Message
                Return Nothing
            Finally
                _sqlCmd.Dispose()
                _objSqlParamtter.Clear()
                _objSqlParamtterWhere.Clear()
                If _objSqlConn.State <> ConnectionState.Closed Then
                    _objSqlConn.Close()
                End If
            End Try
        End Function
#End Region

#Region "# ExecuteSQLDataSet #"
        Public Shared Function ExecuteSQLDataSet(ByVal sSQL As String) As DataSet
            Dim ds As New DataSet
            Dim _sqlCmd As New SqlCommand
            Try
                _objSqlConn = New SqlConnection(getSQLConnectionString)
                _sqlCmd.CommandText = sSQL
                _sqlCmd.Connection = _objSqlConn
                _sqlCmd.CommandTimeout = TimeOut
                _objSqlConn.Open()
                For Each p As SqlParameter In _objSqlParamtter
                    _sqlCmd.Parameters.Add(p)
                Next
                For Each p As SqlParameter In _objSqlParamtterWhere
                    _sqlCmd.Parameters.Add(p)
                Next
                Dim da As New SqlDataAdapter(_sqlCmd)
                da.Fill(ds)
                Return ds
            Catch ex As Exception
                _LoiNgoaiLe = ex.Message
                Return Nothing
            Finally
                _sqlCmd.Dispose()
                _objSqlParamtter.Clear()
                _objSqlParamtterWhere.Clear()
                If _objSqlConn.State <> ConnectionState.Closed Then
                    _objSqlConn.Close()
                End If
            End Try
        End Function
#End Region

#Region "# ExecuteSQLNonQuery #"
        Public Shared Function ExecuteSQLNonQuery(ByVal sSQL As String) As Object
            Dim _sqlCmd As New SqlCommand
            Try
                If _objSqlConnWithTrans Is Nothing Then
                    _objSqlConn = New SqlConnection(getSQLConnectionString)
                    _sqlCmd.Connection = _objSqlConn
                    _objSqlConn.Open()
                Else
                    _sqlCmd.Connection = _objSqlConnWithTrans
                    _sqlCmd.Transaction = _objTransaction
                End If
                _sqlCmd.CommandText = sSQL
                For Each p As SqlParameter In _objSqlParamtter
                    _sqlCmd.Parameters.Add(p)
                Next
                For Each p As SqlParameter In _objSqlParamtterWhere
                    _sqlCmd.Parameters.Add(p)
                Next
                Return CType(_sqlCmd.ExecuteNonQuery(), Integer)
            Catch ex As Exception
                LoiNgoaiLe = ex.Message
                Return Nothing
            Finally
                _sqlCmd.Dispose()
                _objSqlParamtter.Clear()
                _objSqlParamtterWhere.Clear()
                If _objSqlConn.State <> ConnectionState.Closed Then
                    _objSqlConn.Close()
                End If
            End Try
        End Function
#End Region

#Region "# ExecuteSQLScalar #"
        Public Shared Function ExecuteSQLScalar(ByVal sSQL As String) As Object
            Dim _sqlCmd As New SqlCommand
            Try
                If _objSqlConnWithTrans Is Nothing Then
                    _objSqlConn = New SqlConnection(getSQLConnectionString)
                    _objSqlConn.Open()
                    _sqlCmd.Connection = _objSqlConn
                    _sqlCmd.CommandTimeout = TimeOut
                Else
                    _sqlCmd.Connection = _objSqlConnWithTrans
                    _sqlCmd.Transaction = _objTransaction
                    _sqlCmd.CommandTimeout = TimeOut
                End If
                _sqlCmd.CommandText = sSQL
                For Each p As SqlParameter In _objSqlParamtter
                    _sqlCmd.Parameters.Add(p)
                Next
                For Each p As SqlParameter In _objSqlParamtterWhere
                    _sqlCmd.Parameters.Add(p)
                Next
                Return _sqlCmd.ExecuteScalar()
            Catch ex As Exception
                LoiNgoaiLe = ex.Message
                Return Nothing
            Finally
                _sqlCmd.Dispose()
                _objSqlParamtter.Clear()
                _objSqlParamtterWhere.Clear()
                If _objSqlConn.State <> ConnectionState.Closed Then
                    _objSqlConn.Close()
                End If
            End Try
        End Function
#End Region

#Region "# ExecutePrcDataTable #"
        Public Shared Function ExecutePrcDataTable(ByVal sSQL As String) As DataTable
            Dim dt As New DataTable
            Dim _sqlCmd As New SqlCommand
            Try
                _objSqlConn = New SqlConnection(getSQLConnectionString)
                _sqlCmd.CommandText = sSQL
                _sqlCmd.CommandType = CommandType.StoredProcedure
                _sqlCmd.Connection = _objSqlConn
                _sqlCmd.CommandTimeout = TimeOut
                _objSqlConn.Open()

                For Each p As SqlParameter In _objSqlParamtter
                    _sqlCmd.Parameters.Add(p)
                Next
                For Each p As SqlParameter In _objSqlParamtterWhere
                    _sqlCmd.Parameters.Add(p)
                Next
                Dim da As New SqlDataAdapter(_sqlCmd)
                da.Fill(dt)
                Return dt
            Catch ex As Exception
                _LoiNgoaiLe = ex.Message
                Return Nothing
            Finally
                _sqlCmd.Dispose()
                _objSqlParamtter.Clear()
                _objSqlParamtterWhere.Clear()
                If _objSqlConn.State <> ConnectionState.Closed Then
                    _objSqlConn.Close()
                End If
            End Try
        End Function
#End Region

#Region "# ExecutePrcDataSet #"
        Public Shared Function ExecutePrcDataSet(ByVal sSQL As String) As DataSet
            Dim ds As New DataSet
            Dim _sqlCmd As New SqlCommand
            Try
                _objSqlConn = New SqlConnection(getSQLConnectionString)
                _sqlCmd.CommandText = sSQL
                _sqlCmd.CommandType = CommandType.StoredProcedure
                _sqlCmd.Connection = _objSqlConn
                _sqlCmd.CommandTimeout = TimeOut
                _objSqlConn.Open()
                For Each p As SqlParameter In _objSqlParamtter
                    _sqlCmd.Parameters.Add(p)
                Next
                For Each p As SqlParameter In _objSqlParamtterWhere
                    _sqlCmd.Parameters.Add(p)
                Next
                Dim da As New SqlDataAdapter(_sqlCmd)
                da.Fill(ds)
                Return ds
            Catch ex As Exception
                _LoiNgoaiLe = ex.Message
                Return Nothing
            Finally
                _sqlCmd.Dispose()
                _objSqlParamtter.Clear()
                _objSqlParamtterWhere.Clear()
                If _objSqlConn.State <> ConnectionState.Closed Then
                    _objSqlConn.Close()
                End If
            End Try
        End Function
#End Region


#Region "# doInsert #"
        Public Shared Function doInsert(ByVal TenBang As String) As Object
            Dim sql As String = "SET DATEFORMAT DMY "
            Dim str1 As String = "" : Dim str2 As String = ""
            For Each p As SqlClient.SqlParameter In SqlHelper.objSqlParamtter
                str1 &= p.ParameterName.Substring(1) & ", "
                str2 &= p.ParameterName & ", "
            Next
            If str1.Length > 2 Then str1 = str1.Substring(0, str1.Length - 2)
            If str2.Length > 2 Then str2 = str2.Substring(0, str2.Length - 2)
            sql &= "INSERT INTO [" & TenBang & "](" & str1 & ") VALUES(" & str2 & "); SELECT SCOPE_IDENTITY();"
            Return ExecuteSQLScalar(sql)
        End Function
#End Region

#Region "# doUpdate #"
        Public Shared Function doUpdate(ByVal TenBang As String, ByVal where As String) As Object
            Dim sql As String = "SET DATEFORMAT DMY UPDATE [" & TenBang & "] "
            Dim str1 As String = ""
            For Each p As SqlClient.SqlParameter In SqlHelper.objSqlParamtter
                str1 &= p.ParameterName.Substring(1) & " = " & p.ParameterName & ", "
            Next
            If str1.Length > 2 Then str1 = str1.Substring(0, str1.Length - 2)
            sql &= "SET " & str1 & " "
            sql &= "WHERE " & where & " "
            Return SqlHelper.ExecuteSQLNonQuery(sql)
        End Function
#End Region

#Region "# doDelete #"
        Public Shared Function doDelete(ByVal TenBang As String, ByVal where As String) As Object
            Dim sql As String = "DELETE FROM [" & TenBang & "] WHERE " & where
            Return SqlHelper.ExecuteSQLNonQuery(sql)
        End Function
#End Region

    End Class

    Public Class ThamSo


        Private _Ten As String
        Public Property Ten() As String
            Get
                Return _Ten
            End Get
            Set(ByVal value As String)
                _Ten = value
            End Set
        End Property


        Private _GiaTri As Object
        Public Property GiaTri() As Object
            Get
                Return _GiaTri
            End Get
            Set(ByVal value As Object)
                _GiaTri = value
            End Set
        End Property


        Public Sub New(ByVal __Ten As String, ByVal __GiaTri As Object)
            Ten = __Ten
            GiaTri = __GiaTri
        End Sub


    End Class


End Namespace