Imports MySql.Data.MySqlClient
Public Class brood
    Private connStr As String = "server=localhost;user=root;password=usbw;port=3306;database=bakkerij;"
    Private conn As New MySqlConnection(connStr)
    Private _id As Integer
    Private _typeBrood As String
    Public Sub New()
    End Sub
    Public Sub New(id As Integer, typeBrood As String)
        Me.id = id
        Me.typeBrood = typeBrood
    End Sub
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property typeBrood() As String
        Get
            Return _typeBrood
        End Get
        Set(ByVal value As String)
            _typeBrood = value
        End Set
    End Property
    Public Sub Add()
        Using conn = New MySqlConnection(connStr)
            Dim query = "INSERT INTO brood(id,typeBrood) VALUES(@id,@typeBrood)"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id())
                    cmd.Parameters.AddWithValue("@typeBrood", typeBrood())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            conn.Close()
        End Using
    End Sub
    Public Sub Update()
        Using Conn = New MySqlConnection(connStr)
            Dim query As String = "Update brood SET typeBrood=@typeBrood WHERE id = @id"
            Conn.Open()
            Try
                Using cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@id", id())
                    cmd.Parameters.AddWithValue("@typeBrood", typeBrood())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            Conn.Close()
        End Using
    End Sub
    Public Shared Function GetOne(ByVal ID As Integer) As brood
        Dim myObj As New brood()
        Using conn = New MySqlConnection("server=localhost;user=root;password=usbw;port=3306;database=bakkerij;")
            Dim query As String = "SELECT * FROM brood WHERE id = @id"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", ID)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        If reader.Read() Then
                            myObj.id = Convert.ToInt32(reader("id"))
                            myObj.typeBrood = reader("typeBrood").ToString()
                        End If
                    End Using
                End Using
                Return myObj
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Using
    End Function
    Public Shared Function GetAll() As DataTable
        Using conn = New MySqlConnection("server=localhost;user=root;password=usbw;port=3306;database=bakkerij;")
            conn.Open()
            Dim datatable As New DataTable()
            Dim query As String = "SELECT * FROM brood"
            Try
                Using cmd = New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        datatable.Load(reader)
                    End Using
                    Return datatable
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Using
    End Function
End Class
