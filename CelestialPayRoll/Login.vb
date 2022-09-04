Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data

Public Class Login
    Private objUser As New Users

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetRoles()
    End Sub

    Private Sub UserData()
        objUser.Name = txtUserName.Text
        objUser.Password1 = txtPassword.Text
        objUser.Role1 = cmbRoles.Text
    End Sub
    Private Sub ResetControls()
        UserData()
        txtUserName.Text = ""
        txtPassword.Text = ""
        cmbRoles.Text = ""

    End Sub

    Private Sub GetRoles()
        'connection string
        Dim cs = ConfigurationManager.ConnectionStrings("CelestialPayRoll.My.MySettings.CelestialPayRollDatabaseConnectionString").ConnectionString
        'Creating Connection Object
        Dim objSqlConnnection = New SqlConnection(cs)
        'Creating SQL Command
        Dim objSqlCommand = New SqlCommand("spAllUsers", objSqlConnnection)
        'The Command Type we are using is store procedure
        objSqlCommand.CommandType = CommandType.StoredProcedure
        Try
            objSqlConnnection.Open()    'It opens the Connection to the database
            Dim objDataReader As SqlDataReader = objSqlCommand.ExecuteReader 'Reading data to Executes Commands
            ''While Loop to use data reader to add items to our combo box
            While objDataReader.Read
                cmbRoles.Items.Add(objDataReader(3))
            End While
            objDataReader.Close()
        Catch ex As Exception
            MessageBox.Show($"Error {ex.Message}", "SQL Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objSqlConnnection.Close()
            cmbRoles.SelectedIndex = 0
        End Try

    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        objUser = New Users
        UserData()
        Try
            If objUser.AuthorizedUser Then
                'If the user is authorized then the folloeing code will run
                Dim objPayRollMdi As New PayrollMdi
                Me.Hide()
                objPayRollMdi.Show()
            Else
                MessageBox.Show("UnAuthorised Credentials", "Login Access", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error {ex.Message}", "Login Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub
End Class