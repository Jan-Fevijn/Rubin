Imports MySql.Data.MySqlClient
Public Class klant
    Private connStr As String = "server=localhost;user=root;port=3306;password=usbw;database=bakkerij;"
    Private conn As New MySqlConnection(connStr)
    Private _dob As Date
    Private _klantcode As String
    Private _naam As String
    Private _saldo As String
    Private _voornaam As String
    Public Sub New()
    End Sub
    Public Sub New(dob As Date, klantcode As String, naam As String, saldo As String, voornaam As String)
        Me.dob = dob
        Me.id = klantcode
        Me.naam = naam
        Me.saldo = saldo
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
    Public Property id() As String
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
    Public Property saldo() As Decimal
        Get
            Return _saldo
        End Get
        Set(ByVal value As Decimal)
            _saldo = value
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
    Public Sub Update()
        Using Conn = New MySqlConnection(connStr)
            Dim query As String = "Update klant SET dob=@dob,naam=@naam,saldo=@saldo,voornaam=@voornaam WHERE klantcode = @klantcode"
            Conn.Open()
            Try
                Using cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@dob", dob())
                    cmd.Parameters.AddWithValue("@klantcode", id())
                    cmd.Parameters.AddWithValue("@naam", naam())
                    cmd.Parameters.AddWithValue("@saldo", saldo())
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
        Using conn = New MySqlConnection("server=localhost;user=root;port=3306;password=usbw;database=bakkerij;")
            Dim query As String = "SELECT * FROM klant WHERE klantcode = @klantcode"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@klantcode", ID)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        If reader.HasRows() Then
                            reader.Read()
                            myObj.dob = reader("dob").ToString()
                            myObj.id = reader("klantcode").ToString()
                            myObj.naam = reader("naam").ToString()
                            myObj.saldo = CDec(reader("saldo"))
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
End Class
