Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data

Public Class Users

    Private UserName, Password, Role, RoleDescription As String

    'Password Property
    Public Property Password1 As String
        Get
            Return Password
        End Get
        Set
            Password = value
        End Set
    End Property

    'Role Property
    Public Property Role1 As String
        Get
            Return Role
        End Get
        Set
            Role = value
        End Set
    End Property

    'Role Description Property
    Public Property Description As String
        Get
            Return RoleDescription
        End Get
        Set
            RoleDescription = value
        End Set
    End Property

    'UserName Property
    Public Property Name As String
        Get
            Return UserName
        End Get
        Set
            UserName = value
        End Set
    End Property

    'Add User Method
    Public Sub AddUser()
        'connection string
        Dim cs = ConfigurationManager.ConnectionStrings("CelestialPayRoll.My.MySettings.CelestialPayRollDatabaseConnectionString").ConnectionString
        'Creating Connection Object
        Dim objSqlConnnection = New SqlConnection(cs)
        'Creating SQL Command
        Dim objSqlCommand = New SqlCommand("spInsertCommand", objSqlConnnection)
        'The Command Type we are using is store procedure
        objSqlCommand.CommandType = CommandType.StoredProcedure
        'mapping our parameterized commands
        objSqlCommand.Parameters.AddWithValue("@UserName", Name)
        objSqlCommand.Parameters.AddWithValue("@Password", Password1)
        objSqlCommand.Parameters.AddWithValue("@Roles", Role1)
        objSqlCommand.Parameters.AddWithValue("@Description", Description)

        'Executing command using try, catch
        Try
            objSqlConnnection.Open()    'It opens the Connection to the database
            objSqlCommand.ExecuteNonQuery() 'Executing Command

        Catch ex As SqlException
            MessageBox.Show($"Error {ex.Message}", "SQL Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        Finally
            objSqlConnnection.Close()

        End Try
        MessageBox.Show("New User Added Successfully", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub


    'Update User Method
    Public Sub UpdateUser()
        'connection string
        Dim cs = ConfigurationManager.ConnectionStrings("CelestialPayRoll.My.MySettings.CelestialPayRollDatabaseConnectionString").ConnectionString
        'Creating Connection Object
        Dim objSqlConnnection = New SqlConnection(cs)
        'Creating SQL Command
        Dim objSqlCommand = New SqlCommand("spUpdateCommand", objSqlConnnection)
        'The Command Type we are using is store procedure
        objSqlCommand.CommandType = CommandType.StoredProcedure
        'mapping our parameterized commands
        objSqlCommand.Parameters.AddWithValue("@UserName", Name)
        objSqlCommand.Parameters.AddWithValue("@Password", Password1)
        objSqlCommand.Parameters.AddWithValue("@Roles", Role1)
        objSqlCommand.Parameters.AddWithValue("@Description", Description)

        'Executing command using try, catch
        Try
            objSqlConnnection.Open()    'It opens the Connection to the database
            objSqlCommand.ExecuteNonQuery() 'Executing Command

        Catch ex As SqlException
            MessageBox.Show($"Error {ex.Message}", "SQL Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        Finally
            objSqlConnnection.Close()

        End Try
        MessageBox.Show("New User Data Updated Successfully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub


    'Delete User Method
    Public Sub DeleteUser()
        'connection string
        Dim cs = ConfigurationManager.ConnectionStrings("CelestialPayRoll.My.MySettings.CelestialPayRollDatabaseConnectionString").ConnectionString
        'Creating Connection Object
        Dim objSqlConnnection = New SqlConnection(cs)
        'Creating SQL Command
        Dim objSqlCommand = New SqlCommand("spDeleteCommand", objSqlConnnection)
        'The Command Type we are using is store procedure
        objSqlCommand.CommandType = CommandType.StoredProcedure
        'mapping our parameterized commands
        objSqlCommand.Parameters.AddWithValue("@UserName", Name)

        'Executing command using try, catch
        Try
            objSqlConnnection.Open()    'It opens the Connection to the database
            objSqlCommand.ExecuteNonQuery() 'Executing Command

        Catch ex As SqlException
            MessageBox.Show($"Error {ex.Message}", "SQL Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        Finally
            objSqlConnnection.Close()

        End Try
        MessageBox.Show("User Deleted Successfully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    'Authorized User Method
    Public Function AuthorizedUser() As Boolean
        Dim isUserAuthorised = False
        'connection string
        Dim cs = ConfigurationManager.ConnectionStrings("CelestialPayRoll.My.MySettings.CelestialPayRollDatabaseConnectionString").ConnectionString
        'Creating Connection Object
        Dim objSqlConnnection = New SqlConnection(cs)
        'Creating SQL Command
        Dim objSqlCommand = New SqlCommand("spAuthenticateCommand", objSqlConnnection)
        'The Command Type we are using is store procedure
        objSqlCommand.CommandType = CommandType.StoredProcedure
        'mapping our parameterized commands
        objSqlCommand.Parameters.AddWithValue("@UserName", Name)
        objSqlCommand.Parameters.AddWithValue("@Password", Password1)
        objSqlCommand.Parameters.AddWithValue("@Roles", Role1)
        Try
            objSqlConnnection.Open()    'It opens the Connection to the database
            isUserAuthorised = objSqlCommand.ExecuteScalar() 'We are returning one value True or False

        Catch ex As Exception
            MessageBox.Show($"Error {ex.Message}", "User Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objSqlConnnection.Close()
        End Try

        Return isUserAuthorised

    End Function

    ''' <summary>
    ''' Parameterized constructor
    ''' </summary>
    Public Sub Users(userName As String, Pass As String, Role As String, Description As String)
        Me.Name = userName
        Me.Password1 = Pass
        Me.Role1 = Role
        Me.Description = Description
    End Sub


End Class
