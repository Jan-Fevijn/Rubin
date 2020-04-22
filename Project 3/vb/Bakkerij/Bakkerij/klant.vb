Imports MySql.Data.MySqlClient
Public Class klant
    Private connStr As String = "server=localhost;user=root;password=usbw;port=3306;database=bakkerij;"
    Private conn As New MySqlConnection(connStr)
    Private _dob As Date
    Private _idKlant As Integer
    Private _klantcode As String
    Private _naam As String
    Private _voornaam As String
    Public Sub New()
    End Sub
    Public Sub New(dob As Date, idKlant As Integer, klantcode As String, naam As String, voornaam As String)
        Me.dob = dob
        Me.idKlant = idKlant
        Me.klantcode = klantcode
        Me.naam = naam
        Me.voornaam = voornaam
    End Sub
    Public Property dob() As Date
        Get
            Return _dob
        End Get
        Set(ByVal value As Date)
            _dob = value
        End Set
    End Property
    Public Property id() As Integer
        Get
            Return _idKlant
        End Get
        Set(ByVal value As Integer)
            _idKlant = value
        End Set
    End Property
    Public Property klantcode() As String
        Get
            Return _klantcode
        End Get
        Set(ByVal value As String)
            _klantcode = value
        End Set
    End Property
    Public Property naam() As String
        Get
            Return _naam
        End Get
        Set(ByVal value As String)
            _naam = value
        End Set
    End Property
    Public Property voornaam() As String
        Get
            Return _voornaam
        End Get
        Set(ByVal value As String)
            _voornaam = value
        End Set
    End Property
    Public Sub Add()
        Using conn = New MySqlConnection(connStr)
            Dim query = "INSERT INTO klant(dob,idKlant,klantcode,naam,voornaam) VALUES(@dob,@idKlant,@klantcode,@naam,@voornaam)"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@dob", dob())
                    cmd.Parameters.AddWithValue("@idKlant", idKlant())
                    cmd.Parameters.AddWithValue("@klantcode", klantcode())
                    cmd.Parameters.AddWithValue("@naam", naam())
                    cmd.Parameters.AddWithValue("@voornaam", voornaam())
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
            Dim query As String = "Update klant SET dob=@dob,klantcode=@klantcode,naam=@naam,voornaam=@voornaam WHERE idKlant = @idKlant"
            Conn.Open()
            Try
                Using cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@dob", dob())
                    cmd.Parameters.AddWithValue("@idKlant", idKlant())
                    cmd.Parameters.AddWithValue("@klantcode", klantcode())
                    cmd.Parameters.AddWithValue("@naam", naam())
                    cmd.Parameters.AddWithValue("@voornaam", voornaam())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            Conn.Close()
        End Using
    End Sub
    Public Shared Function GetOne(ByVal ID As Integer) As klant
        Dim myObj As New klant()
        Using conn = New MySqlConnection("server=localhost;user=root;password=usbw;port=3306;database=bakkerij;")
            Dim query As String = "SELECT * FROM klant WHERE idKlant = @idKlant"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idKlant", ID)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        If reader.Read() Then
                            myObj.dob = reader("dob").ToString()
                            myObj.idKlant = Convert.ToInt32(reader("idKlant"))
                            myObj.klantcode = reader("klantcode").ToString()
                            myObj.naam = reader("naam").ToString()
                            myObj.voornaam = reader("voornaam").ToString()
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
            Dim query As String = "SELECT * FROM klant"
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
