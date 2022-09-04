Public Class PreviewForm


    Public Sub PreviewEmployeeData(EmployeeID As Integer, FirstName As String, LastName As String, Gender As String, SSNITNO As String, DOB As String, MaritalStatus As String, isTeaching As Boolean, Address As String, City As String, Region As String, Country As String, PhoneNumber As String, EmailAddress As String, Note As String)

        _lblEmployeeID1.Text = Convert.ToString(EmployeeID)
        _lblFirstName1.Text = FirstName
        _lblLastName1.Text = LastName
        _lblGender1.Text = Gender
        _lblSSNITNo1.Text = SSNITNO
        _lblDOB1.Text = DOB
        _lblMaritalStatus1.Text = MaritalStatus
        _lblTeachingStaff1.Text = isTeaching.ToString()
        _lblAddress1.Text = Address
        _lblCity1.Text = City
        _lblRegion1.Text = Region
        _lblCountry1.Text = Country
        _lblPhoneNo1.Text = PhoneNumber
        _lblEmailAddress1.Text = EmailAddress
        _lblNote1.Text = Note + Environment.NewLine
        
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class