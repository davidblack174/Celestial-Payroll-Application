

Public Class RegisterForm

    Private _objUsers As Users 'Class Variable

    'Method Validate Controls Data
    Public Function IsRegisterControlisValid() As Boolean
        Try
            'User Name Validation
            If txtRegisterUserName.Text = "" Then
                MessageBox.Show("Enter Valid User Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRegisterUserName.Focus()
                Return False
            End If

            'Password Validation

            If txtRegisterPassword.Text = "" Then
                MessageBox.Show("Enter Valid Password", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRegisterPassword.Focus()
                Return False
            Else
                'Password Must be at least 8 minimum Character Long
                'Password must contain at least one Upper case Letter
                'Password must contain at least one Lower case Letter
                'Password must contain at least one numeric digit 
                If txtRegisterPassword.Text.Length < 8 And
                CheckUpperCase(txtRegisterPassword.Text.Length < 1) And CheckLowerCase(txtRegisterPassword.Text.Length < 1) AndAlso CheckNumericDegit(txtRegisterPassword.Text.Length < 1) Then

                    MessageBox.Show(
                        $"Please Enter a valid password. {Environment.NewLine} Hint: Password Must be at least 8 minimum Character Long {Environment.NewLine}Hint: Password must contain at least one Upper case Letter {Environment.NewLine} Hint: Password must contain at least one Lower case Letter {Environment.NewLine} Password must contain at least one numeric digit ",
                        "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtRegisterPassword.Focus()
                    Return False

                End If
            End If
            'Confirm Password Validation
            If txtConfirmPassword.Text = "" Then
                MessageBox.Show("Enter Valid Password, Please Try Again", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtConfirmPassword.Focus()
                Return False
            Else
                If Not txtConfirmPassword.Text = txtRegisterPassword.Text Then
                    MessageBox.Show("Both password do not Match, Please Try Again", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtConfirmPassword.Clear()
                    txtConfirmPassword.Focus()
                End If
            End If
            'Role Validation
            If txtRegisterRole.Text = "" Then
                MessageBox.Show("Enter Valid Role", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRegisterRole.Focus()
                Return False
            End If

        Catch ex As Exception
            MsgBox($"The following error occur {ex.Message}")
        End Try
        Return True

    End Function

    Private Function CheckNumericDegit(strPassword As String) As Integer
        'variable to hold numeric digit
        Dim numberofdigit As Integer = 0
        'Count the amount of number present in the Password
        For Each o As Char In strPassword
            'For each number found keep increasing the count by 1
            If Char.IsNumber(o) Then
                numberofdigit += 1
            End If
        Next
        'Finally returning the total number of count
        Return numberofdigit
    End Function


    Private Function CheckLowerCase(strPassword As String) As Integer
        'variable to hold Lower Case
        Dim numberofLowerCase As Integer = 0
        'Count the amount of lower case present in the Password
        For Each o As Char In strPassword
            'For each lower case found keep increasing the count by 1
            If Char.IsLower(o) Then
                numberofLowerCase += 1
            End If
        Next
        'Finally returning the total number of lower case
        Return numberofLowerCase
    End Function

    Private Function CheckUpperCase(strPassword As String) As Integer
        'variable to hold Upper case
        Dim numberofUpperCase As Integer = 0
        'Count the amount of upper case present in the Password
        For Each o As Char In strPassword
            'For each upper case found keep increasing the count by 1
            If Char.IsUpper(o) Then
                numberofUpperCase += 1
            End If
        Next
        'Finally returning the total number of upper case
        Return numberofUpperCase
    End Function


    'Clear Controls Methods
    Private Sub ClearControls()
        txtRegisterPassword.Text = ""
        txtRegisterUserName.Text = ""
        txtConfirmPassword.Text = ""
        txtRegisterRole.Text = ""
        txtRegisterRoleDescription.Text = ""

    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearControls()

    End Sub
    ''' <summary>
    ''' mapping each Property to the textboxes
    ''' </summary>
    Sub UserData()
        _objUsers.Name = txtRegisterUserName.Text
        _objUsers.Password1 = txtRegisterPassword.Text
        _objUsers.Role1 = txtRegisterRole.Text
        _objUsers.Description = txtRegisterRoleDescription.Text

    End Sub

    Private Sub btnRegisterNow_Click(sender As Object, e As EventArgs) Handles btnRegisterNow.Click
        _objUsers = New Users()
        UserData()

        If IsRegisterControlisValid() Then

            _objUsers.AddUser() 'Calling the add user method from users class

        End If
        ClearControls()

        'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet4.Users' table. You can move, or remove it, as needed.
        UsersTableAdapter.Fill(CelestialPayRollDatabaseDataSet4.Users)

    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet4.Users' table. You can move, or remove it, as needed.
        UsersTableAdapter.Fill(CelestialPayRollDatabaseDataSet4.Users)

    End Sub
    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        _objUsers = New Users()
        UserData()

        If IsRegisterControlisValid() Then

            _objUsers.UpdateUser() 'Calling the update user method from users class

        End If
        ClearControls()

        'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet4.Users' table. You can move, or remove it, as needed.
        UsersTableAdapter.Fill(CelestialPayRollDatabaseDataSet4.Users)
    End Sub
    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        'Passing each cell in role into the textboxes
        Dim cell As DataGridViewCellCollection = DataGridView1.CurrentRow.Cells
        txtRegisterUserName.Text = cell(1).Value.ToString 'value on index 1 on the datagridview
        txtRegisterPassword.Text = cell(2).Value.ToString 'value on index 2 on the datagridview
        txtConfirmPassword.Text = cell(2).Value.ToString 'value on index 2 same as password on the datagridview
        txtRegisterRole.Text = cell(3).Value.ToString 'value on index 3 on the datagridview
        txtRegisterRoleDescription.Text = cell(4).Value.ToString 'value on index 4 on the datagridview



    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete the user's record?", "Confirm Record Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            _objUsers = New Users()
            UserData()

            If IsRegisterControlisValid() Then

                _objUsers.DeleteUser() 'Calling the Delete User method from users class

            End If
            ClearControls()

            'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet4.Users' table. You can move, or remove it, as needed.
            UsersTableAdapter.Fill(CelestialPayRollDatabaseDataSet4.Users)


        End If

    End Sub
End Class