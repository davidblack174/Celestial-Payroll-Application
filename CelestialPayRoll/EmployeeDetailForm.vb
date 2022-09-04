

Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class FormEmployeeForm

    Private objGender, objMaritalStarus As String
    Private objisTeachingStaff As Boolean
#Region "Operations and Function"
    'The Checked Methods for all Checkbox
    Sub CheckMember()
        'For Gender
        If rdbMale.Checked Then
            objGender = "Male"
        Else
            objGender = "Female"
        End If

        'For Marital Status
        If rdbMarried.Checked Then
            objMaritalStarus = "Married"
        Else
            objMaritalStarus = "Single"
        End If

        'For Teaching Staff
        If chkTeachingStaff.Checked Then
            objisTeachingStaff = True
        Else
            objisTeachingStaff = False
        End If

    End Sub
    Private Function IsExplicieValidation() As Boolean
        'Regular Expression to limit user text restriction
        ' Dim objEmployeeID As Regex = New Regex("[0-9]{3,4}")'This will enable user to type into the EmployeeID textbox 3 to 4 digits and numbers ranging from 0 to 9

        Dim objFirstName As Regex = New Regex("^[A-Z]{1}[a-zA-Z]*$") 'This Expession will enable the first letter be initial capital letter beteen A to Z and the other with mixture of letters ranging beteen a to z either capital letter or small letter

        Dim objLastName As Regex = New Regex("^[A-Z]{1}[a-zA-Z]*$") 'This Expession will enable the First letter be initial capital letter beteen A to Z and the other with mixture of letters ranging beteen a to z either capital letter or small letter

        'Format for SSNIT Number [S231245690981]
        Dim objSsnitNumber As Regex = New Regex("^[A-Z]{1}[0-9]{12}$") 'The expression address the first letter in Capital Letter A to Z and Selecting only 1 (which is in {}) and also select 12 (which is in {}) digits ranges from 0 to 9 

        'Email Format [davidblack174@gmail.com]
        Dim objEmailAddress As Regex = New Regex("[a-zA-Z0-9]{1,100}@[a-zA-Z0-9]{1,30}[a-zA-Z]{2,3}") 'The expression validates the email address by confirming the input in considering any of the format a-zA-Z0-9 ranges from 1 to 100. Using @ as email standard the same format follow by the same partern with . as standard format together ith only letters 2 to 3 digits


        'Validation for Employee ID
        If Convert.ToInt32(txtEmployeeID.Text.Length) < 1 Then
            MessageBox.Show("Please Enter a Employee ID in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmployeeID.Focus()
            txtEmployeeID.BackColor = Color.Silver
            Return False
        ElseIf Not Regex.IsMatch(txtEmployeeID.Text, "^[\d]{3,4}$") Then 'This will enable user to type into the EmployeeID textbox 3 to 4 digits and numbers ranging from 0 to 9
            MessageBox.Show("Please Enter a Valid Employee ID in this format Example: 111 or NOT More than 9999", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmployeeID.Focus()
            txtEmployeeID.BackColor = Color.Silver
            Return False
        Else
            txtEmployeeID.BackColor = Color.White
        End If

        'First Name Validation
        If txtFirstName.Text = "" Then
            MessageBox.Show("Please Enter a First Name in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstName.Focus()
            txtFirstName.BackColor = Color.Silver
            Return False

        ElseIf Not objFirstName.IsMatch(txtFirstName.Text) Then
            MessageBox.Show("Please Enter First Name in this Format Example: James ", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstName.Focus()
            txtFirstName.BackColor = Color.Silver
            Return False

        Else
            txtFirstName.BackColor = Color.White
        End If

        'Last Name Validation
        If txtLastName.Text = "" Then
            MessageBox.Show("Please Enter a Last Name in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLastName.Focus()
            txtLastName.BackColor = Color.Silver
            Return False
        ElseIf Not objLastName.IsMatch(txtLastName.Text) Then
            MessageBox.Show("Please Enter a Valid Last Name in the Box in this Format[Example: Smith]", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLastName.Focus()
            txtLastName.BackColor = Color.Silver
            Return False
        Else
            txtLastName.BackColor = Color.White
        End If

        'Gender Validation
        If Not rdbMale.Checked Or rdbFemale.Checked = True Then
            MessageBox.Show("Please Select a Gender in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            gpbGender.Focus()
            rdbFemale.BackColor = Color.YellowGreen
            rdbMale.BackColor = Color.YellowGreen
            Return False
       
        End If

        'SSNIT Number Validation
        If txtSSNITNo.Text = "" Then
            MessageBox.Show("Please Enter a SSNIT Number in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSSNITNo.Focus()
            txtSSNITNo.BackColor = Color.Silver
            Return False
        ElseIf Not objSsnitNumber.IsMatch(txtSSNITNo.Text) Then ' Using ismach method to confirm our text restrictions which we define 
            MessageBox.Show("Please Enter a Valid SSNIT Number in the Box in this format Example: A232123456543", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSSNITNo.Focus()
            txtSSNITNo.BackColor = Color.Silver
            Return False
        Else
            txtSSNITNo.BackColor = Color.White
        End If

        'Marrital Status Validation
        If Not rdbMarried.Checked Or rdbSingle.Checked = True Then
            MessageBox.Show("Please Select any Marrital Status in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            gpbGender.Focus()
            rdbMarried.BackColor = Color.YellowGreen
            rdbSingle.BackColor = Color.YellowGreen
            Return False
        
        End If

        'Address Validation
        If txtAddress.Text = "" Then
            MessageBox.Show("Please Enter a Address in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAddress.Focus()
            txtAddress.BackColor = Color.Silver
            Return False
        Else
            txtAddress.BackColor = Color.White
        End If

        'City Validation
        If txtCity.Text = "" Then
            MessageBox.Show("Please Enter a City in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCity.Focus()
            txtCity.BackColor = Color.Silver
            Return False
        Else
            txtCity.BackColor = Color.White
        End If

        'Region  Validation
        If txtRegion.Text = "" Then
            MessageBox.Show("Please Enter a Region in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRegion.Focus()
            txtRegion.BackColor = Color.Silver
            Return False
        Else
            txtRegion.BackColor = Color.White
        End If

        'Country Validation
        If cmbCountry.SelectedIndex = -1 Then
            MessageBox.Show("Please Select a Country in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbCountry.Focus()
            cmbCountry.BackColor = Color.Silver
            Return False
        Else
            cmbCountry.BackColor = Color.White
        End If

        'Phone Number Validation
        If txtPhoneNumber.Text.Length = 0 Then
            MessageBox.Show("Please Enter a Correct Entry in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPhoneNumber.Focus()
            txtPhoneNumber.BackColor = Color.Silver
            Return False
        Else
            txtPhoneNumber.BackColor = Color.White
        End If

        ' Email Validation
        If txtEmail.Text = "" Then
            MessageBox.Show("Please Enter a Email Address in the Box", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            txtEmail.BackColor = Color.Silver
            Return False
        ElseIf Not objEmailAddress.IsMatch(txtEmail.Text) Then
            MessageBox.Show("Please Enter a Valid Email Address in the Box in this Format Example: jamessmith123@gmail.com", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            txtEmail.BackColor = Color.Silver
            Return False
        Else
            txtEmail.BackColor = Color.White
        End If

        ' Note Validation
        If txtNote.Text.Length > 100 Then
            MessageBox.Show("Too much text! Please, enter feer text  ", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNote.Focus()
            txtNote.BackColor = Color.Silver
            Return False
        Else
            txtNote.BackColor = Color.White
        End If
        Return True

    End Function


#End Region

#Region "Inplicite Validation"


    Private Sub txtEmployeeID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmployeeID.KeyPress
        'User Validation that Only Accept Numbers and BackSpace With Textbox
        Dim Isnumericordigit As Boolean = False
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = vbBack Then
            Isnumericordigit = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        'User Validation that Only Accept Numbers and BackSpace With Textbox
        Dim Isnumericordigit As Boolean = False
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = vbBack Then
            Isnumericordigit = True
        Else
            e.Handled = True
        End If

    End Sub
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.CelestialPayRollDatabaseDataSet.Employee)

    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        CheckMember()

        If IsExplicieValidation() Then
            'Connection String
            Dim connection = New SqlConnection("Data Source=DAVID-DEVELOPME\SQLEXPRESS;Initial Catalog=CelestialPayRollDatabase;Integrated Security=True")

            Try
                'Inserting String Values
                Dim InsertCommand As String = "INSERT INTO Employee VALUES (@EmployeeID,@FirstName,@LastName,@Gender,@SSNITNo,@DOB,@MaritalStatus,@TeachingStaff,@Address,@City,@Region,@Country,@PhoneNumber,@Email,@Note)"


                connection.Open()
                'Instantiating SQL command and pass in commandText and connection Object
                Using objSqlCommand As SqlCommand = New SqlCommand(InsertCommand, connection)

                    'Adding Parameters to Table
                    objSqlCommand.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(txtEmployeeID.Text))
                    objSqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    objSqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    objSqlCommand.Parameters.AddWithValue("@Gender", objGender)
                    objSqlCommand.Parameters.AddWithValue("@SSNITNo", txtSSNITNo.Text)
                    objSqlCommand.Parameters.AddWithValue("@DOB", dtpDOB.Value.ToString("MM/dd/yyyy"))
                    objSqlCommand.Parameters.AddWithValue("@MaritalStatus", objMaritalStarus)
                    objSqlCommand.Parameters.AddWithValue("@TeachingStaff", objisTeachingStaff)
                    objSqlCommand.Parameters.AddWithValue("@Address", txtAddress.Text)
                    objSqlCommand.Parameters.AddWithValue("@City", txtCity.Text)
                    objSqlCommand.Parameters.AddWithValue("@Region", txtRegion.Text)
                    objSqlCommand.Parameters.AddWithValue("@Country", cmbCountry.SelectedItem)
                    objSqlCommand.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                    objSqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text)
                    objSqlCommand.Parameters.AddWithValue("@Note", txtNote.Text)

                    'Opening SqlCommand object for this Program

                    objSqlCommand.ExecuteNonQuery()

                    'Display Added Message
                    MessageBox.Show("Employee with " + txtEmployeeID.Text + " has been added Successfully", "Data Entry Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

            Catch ex As Exception
                MessageBox.Show("The following error occured : " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.CelestialPayRollDatabaseDataSet.Employee)

        btnReset.PerformClick()
    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        'For Gender
        If objGender = "Male" Then
            rdbMale.Checked = True
            rdbFemale.Checked = False
        Else
            rdbMale.Checked = False
            rdbFemale.Checked = True
        End If

        'For Marital Status
        If objMaritalStarus = "Married" Then
            rdbMarried.Checked = True
            rdbSingle.Checked = False
        Else
            rdbMarried.Checked = False
            rdbSingle.Checked = True
        End If

        'For Teaching Staff
        If objisTeachingStaff = True Then
            chkTeachingStaff.Checked = True
        Else
            chkTeachingStaff.Checked = False
        End If

        If IsExplicieValidation() Then
            'Connection String
            Dim connection As SqlConnection = New SqlConnection("Data Source=DAVID-DEVELOPME\SQLEXPRESS;Initial Catalog=CelestialPayRollDatabase;Integrated Security=True")

            Try
                'Updating String Values
                Dim UpdateCommand As String = "update tblEmployee set FirstName= @FirstName,LastName= @LastName,Gender= @Gender,SSNITNumber= @SSNITNo,DateOfBirth= @DOB,MaritalStatus= @MaritalStatus,isTeaching= @isTeachingStaff,Address= @Address ,City= @City,Region= @Region,Country= @Country, PhoneNumber= @PhoneNumber,Email= @Email,Notes= @Note  WHERE EmployeeID= @EmployeeID"


                connection.Open()
                'Instantiating SQL command and pass in commandText and connection Object
                Using objSqlCommand As SqlCommand = New SqlCommand(UpdateCommand, connection)

                    'Adding Parameters to Table

                    objSqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    objSqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    objSqlCommand.Parameters.AddWithValue("@Gender", objGender)
                    objSqlCommand.Parameters.AddWithValue("@SSNITNo", txtSSNITNo.Text)
                    objSqlCommand.Parameters.AddWithValue("@DOB", dtpDOB.Value.ToString("MM/dd/yyyy"))
                    objSqlCommand.Parameters.AddWithValue("@MaritalStatus", objMaritalStarus)
                    objSqlCommand.Parameters.AddWithValue("@isTeachingStaff", objisTeachingStaff)
                    objSqlCommand.Parameters.AddWithValue("@Address", txtAddress.Text)
                    objSqlCommand.Parameters.AddWithValue("@City", txtCity.Text)
                    objSqlCommand.Parameters.AddWithValue("@Region", txtRegion.Text)
                    objSqlCommand.Parameters.AddWithValue("@Country", cmbCountry.SelectedItem)
                    objSqlCommand.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                    objSqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text)
                    objSqlCommand.Parameters.AddWithValue("@Note", txtNote.Text)
                    objSqlCommand.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(txtEmployeeID.Text))

                    'Opening SqlCommand object for this Program

                    objSqlCommand.ExecuteNonQuery()

                    'Display Added Message
                    MessageBox.Show("Employee with " + txtEmployeeID.Text + " has been updated Successfully", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                 'closing the connection after opening
                    connection.Close()
                End Using

            Catch ex As Exception
                MessageBox.Show("The following error occured : " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
        'resetting the textboxes
        btnReset.PerformClick()

        'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.CelestialPayRollDatabaseDataSet.Employee)
    End Sub
    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click
        Dim objDialogueResult As New DialogResult
        objDialogueResult = MessageBox.Show("Are you sure you want to Permanently delete this Employee Records?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If objDialogueResult = DialogResult.Yes Then

            CheckMember()

            If IsExplicieValidation() Then
                'Connection String
                Dim connection As SqlConnection = New SqlConnection("Data Source=DAVID-DEVELOPME\SQLEXPRESS;Initial Catalog=CelestialPayRollDatabase;Integrated Security=True")

                Try
                    'Deleting String Values
                    Dim DeleteCommand As String = "delete from tblEmployee where EmployeeID= @EmployeeID "


                    connection.Open()
                    'Instantiating SQL command and pass in commandText and connection Object
                    Using objSqlCommand As SqlCommand = New SqlCommand(DeleteCommand, connection)

                        'Deletion using Parameters of Table
                        objSqlCommand.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(txtEmployeeID.Text))

                        'Opening SqlCommand object for this Program
                        objSqlCommand.ExecuteNonQuery()

                        'Display Added Message
                        MessageBox.Show("Employee with " + txtEmployeeID.Text + " has been deleted Successfully", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                     'closing the connection after opening
                        connection.Close()
                    End Using

                Catch ex As Exception
                    MessageBox.Show("The following error occured : " + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
            'resetting the textboxes
            btnReset.PerformClick()
        End If
        'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.CelestialPayRollDatabaseDataSet.Employee)
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtEmployeeID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtCity.Clear()
        txtNote.Clear()
        txtPhoneNumber.Clear()
        txtSSNITNo.Clear()
        rdbMale.Checked = False
        rdbFemale.Checked = False
        rdbMarried.Checked = False
        rdbSingle.Checked = False
        cmbCountry.Text = "Select Country"
        dtpDOB.Value = New DateTime(2020, 6, 15)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
        
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
      IsExplicieValidation()
        CheckMember()
        Dim objPreview As PreviewForm = New PreviewForm()
        objPreview.PreviewEmployeeData(Convert.ToString(txtEmployeeID.Text), txtFirstName.Text, txtLastName.Text, objGender, txtSSNITNo.Text, dtpDOB.Text, objMaritalStarus, objisTeachingStaff, txtAddress.Text, txtCity.Text, txtRegion.Text, cmbCountry.SelectedItem.ToString(), txtPhoneNumber.Text, txtEmail.Text, txtNote.Text)
        objPreview.Show()

    End Sub


    'Datagrid Cell Click Event
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            'Chowing details on the main Employee form
            Dim view As New FormEmployeeForm
            txtEmployeeID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).FormattedValue.ToString()
            txtFirstName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).FormattedValue.ToString()
            txtLastName.Text = DataGridView1.Rows(e.RowIndex).Cells(2).FormattedValue.ToString()
            objGender = DataGridView1.Rows(e.RowIndex).Cells(3).FormattedValue.ToString()
            txtSSNITNo.Text = DataGridView1.Rows(e.RowIndex).Cells(4).FormattedValue.ToString()
            dtpDOB.Text = DataGridView1.Rows(e.RowIndex).Cells(5).FormattedValue.ToString()
            objMaritalStarus = DataGridView1.Rows(e.RowIndex).Cells(6).FormattedValue.ToString()
            objisTeachingStaff = DataGridView1.Rows(e.RowIndex).Cells(7).FormattedValue.ToString()
            txtAddress.Text = DataGridView1.Rows(e.RowIndex).Cells(8).FormattedValue.ToString()
            txtCity.Text = DataGridView1.Rows(e.RowIndex).Cells(9).FormattedValue.ToString()
            txtRegion.Text = DataGridView1.Rows(e.RowIndex).Cells(10).FormattedValue.ToString()
            cmbCountry.Text = DataGridView1.Rows(e.RowIndex).Cells(11).FormattedValue.ToString()
            txtPhoneNumber.Text = DataGridView1.Rows(e.RowIndex).Cells(12).FormattedValue.ToString()
            txtEmail.Text = DataGridView1.Rows(e.RowIndex).Cells(13).FormattedValue.ToString()
            txtNote.Text = DataGridView1.Rows(e.RowIndex).Cells(14).FormattedValue.ToString()

            'For Gender
            If objGender = "Male" Then
                rdbMale.Checked = True
                rdbFemale.Checked = False
            Else
                rdbMale.Checked = False
                rdbFemale.Checked = True
            End If

            'For Marital Status
            If objMaritalStarus = "Married" Then
                rdbMarried.Checked = True
                rdbSingle.Checked = False
            Else
                rdbMarried.Checked = False
                rdbSingle.Checked = True
            End If

            'For Teaching Staff
            If objisTeachingStaff = True Then
                chkTeachingStaff.Checked = True
            Else
                chkTeachingStaff.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub
End Class
