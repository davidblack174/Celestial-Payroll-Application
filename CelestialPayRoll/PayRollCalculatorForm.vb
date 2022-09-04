
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Text
Imports System.Globalization

Public Class PayRollCalculatorForm
    Private Const Response As String = "Please Enter Employee ID Re-enter"

    Function ValidateDeductionControl() As Boolean
        If Not IsNumeric(txttax.Text) Or txttax.Text = "" Then
            MessageBox.Show($"Please check Your Entry on Tax Contribution {Environment.NewLine} Hint:{Environment.NewLine} It must not be Empty. {Environment.NewLine} It must only be Numbers for Calculation", "Data Entry Error", MessageBoxButtons.OK)
            txttax.Focus()
            txttax.BackColor = Color.Silver
            Return False
        End If

        If Not IsNumeric(txtSSNITContribution.Text) Or txtSSNITContribution.Text = "" Then
            MessageBox.Show($"Please check Your Entry on SSNIT Contribution {Environment.NewLine} Hint:{Environment.NewLine} It must not be Empty. {Environment.NewLine} It must only be Numbers for Calculation", "Data Entry Error", MessageBoxButtons.OK)
            txtSSNITContribution.Focus()
            txtSSNITContribution.BackColor = Color.Silver
            Return False
        End If
        If Not IsNumeric(txtGrossSalary.Text) And txtGrossSalary.Text = Nothing Then
            MessageBox.Show($"Please check Your Entry on Basic Salary {Environment.NewLine} Hint:{Environment.NewLine} It must not be Empty. {Environment.NewLine} It must only be Numbers for Calculation ", "Data Entry Error", MessageBoxButtons.OK)
            txtGrossSalary.Focus()
            txtGrossSalary.BackColor = Color.Silver
            Return False
        End If
        Return True
    End Function

    Private Sub ListofMonth()
        Dim months = New String() _
                {"Select A Month---------", "January", "Februay", "March", "April", "May", "June", "July", "August",
                 "September", "October", "November", "December"}
        'Looping through the month array
        For Each month As Object In months
            cmbPayMonth.Items.Add(month)
            cmbPayMonth.SelectedIndex = 0
            cmbSearchPayMonth.Items.Add(month)
            cmbSearchPayMonth.SelectedIndex = 0

        Next
        txtTotalDeduction.Text = Format("GHC 0.00")
        txtNetPay.Text = Format("GHC 0.00")
    End Sub

    Sub ResetControls()
        txtEmployeeID.Text = ""
        txtFullName.Text = ""
        dtpPayDate.Value = DateTime.Now
        cmbPayMonth.SelectedIndex = 0
        txtSSNITNumber.Text = ""
        txtServiceLoanComapanyName.Text = ""
        txtSLCDeduction.Text = ""
        txttax.Text = ""
        txtSSNITContribution.Text = ""
        txtGrossSalary.Text = ""
        txtTotalDeduction.Text = Format("GHC 0.00")
        txtNetPay.Text = Format("GHC 0.00")
    End Sub

    Function ValidateControls() As Boolean

        'Validate TextBox Employee ID
        If txtEmployeeID.Text = "" Then
            MessageBox.Show(Response, "Data Entry Errror")
            txtEmployeeID.Focus()
            txtEmployeeID.BackColor = Color.Silver
            Return False
        End If
        'Validate Pay Month Employee ID
        If cmbPayMonth.SelectedIndex = 0 Then
            MessageBox.Show("Please Select Pay Month", "Data Entry Error", MessageBoxButtons.OK)
            cmbPayMonth.Focus()
            cmbPayMonth.BackColor = Color.Silver
            Return False
        End If

        Return True
    End Function

    Private Sub PayRollCalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet6.PayRecord' table. You can move, or remove it, as needed.
        Me.PayRecordTableAdapter1.Fill(Me.CelestialPayRollDatabaseDataSet6.PayRecord)
        ListofMonth()
        Timer1.Start()
        ResetControls()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        ValidateControls()
        'Connection String
        Dim connection =
                New SqlConnection(
                    "Data Source=DAVID-DEVELOPME\SQLEXPRESS;Initial Catalog=CelestialPayRollDatabase;Integrated Security=True")
        'Selecting String Values
        Dim selectCommand = "select FirstName, LastName, SSNITNumber from Employee where EmployeeID = @EmployeeID"

        connection.Open()

        Try
            'Instantiating SQL command and pass in commandText and connection Object
            Using objSqlCommand = New SqlCommand(selectCommand, connection)
                'Make Primary key Parameterized
                objSqlCommand.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text)
                Dim dr As SqlDataReader = objSqlCommand.ExecuteReader()
                If dr.Read() Then
                    'Assigning Table Content to Textboxes
                    txtSSNITNumber.Text = dr(2).ToString()
                    txtFullName.Text = dr(1).ToString() + ", " + dr(0).ToString()
                Else
                    MessageBox.Show("There's no such records as " + txtEmployeeID.Text, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                dr.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message, "Error Message")
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnComputePayment_Click(sender As Object, e As EventArgs) Handles btnComputePayment.Click
        Try
            If ValidateDeductionControl() Then
                If IsNumeric(txttax.Text) And IsNumeric(txtSSNITContribution.Text) Or IsNumeric(txtSLCDeduction.Text) Then
                    If txtSLCDeduction.Text = Nothing Then
                        txtSLCDeduction.Text = 0
                    End If
                    'Since i Want each monetary value to have GHC append to them then i will make each value assign
                    Dim tax = Convert.ToDouble(txttax.Text)
                    Dim ssnitContribution = Convert.ToDouble(txtSSNITContribution.Text)
                    Dim slcDeduction = Convert.ToDouble(txtSLCDeduction.Text)
                    txtTotalDeduction.Text = tax + ssnitContribution + slcDeduction
                    Dim totalDeduction = Convert.ToDouble(txtTotalDeduction.Text)

                    Dim basicSalary = Convert.ToDouble(txtGrossSalary.Text)
                    Dim hume = basicSalary - totalDeduction
                    'Appending the currency value to each text box  value
                    txtNetPay.Text = hume.ToString("GHC #0.00")
                    txtTotalDeduction.Text = totalDeduction.ToString("GHC #0.00")
                    txttax.Text = tax.ToString("GHC #0.00")
                    txtSLCDeduction.Text = slcDeduction.ToString("GHC #0.00")
                    txtSSNITContribution.Text = ssnitContribution.ToString("GHC #0.00")
                    txtGrossSalary.Text = basicSalary.ToString("GHC #0.00")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnSavePayment_Click(sender As Object, e As EventArgs) Handles btnSavePayment.Click
        Dim cs As String =
                ConfigurationManager.ConnectionStrings("CelestialPayRoll.My.MySettings.CelestialPayRollDatabaseConnectionString").ConnectionString
        Dim objSqlConnection = New SqlConnection(cs)
        Dim insertString As String = "insert into PayRecord  " + "(EmployeeID,FullName,SSNITNumber,PayDate,PayMonth,ServiceLoanCompanyName,TaxDeduction,SSNITContribution,SLCDeduction,Gross,TotalDeduction,NetPay)" + " values (@EmployeeID,@FullName,@SSNITNumber,@PayDate,@PayMonth,@ServiceLoanCompanyName,@TaxDeduction,@SSNITContribution,@SLCDeduction,@Gross,@TotalDeduction,@NetPay)"
        Dim objInsertCommands = New SqlCommand(insertString, objSqlConnection)
        'Adding Parameters to objInserCommands using addwithvalue from the text control
        objInsertCommands.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.ToString())
        objInsertCommands.Parameters.AddWithValue("@FullName", txtFullName.Text.ToString())
        objInsertCommands.Parameters.AddWithValue("@SSNITNumber", txtSSNITNumber.Text.ToString())
        objInsertCommands.Parameters.AddWithValue("@PayDate", Convert.ToString(dtpPayDate.Value))
        objInsertCommands.Parameters.AddWithValue("@PayMonth", cmbPayMonth.SelectedItem.ToString())
        objInsertCommands.Parameters.AddWithValue("@ServiceLoanCompanyName", txtServiceLoanComapanyName.Text.ToString())
        objInsertCommands.Parameters.AddWithValue("@TaxDeduction", Convert.ToString(txttax.Text))
        objInsertCommands.Parameters.AddWithValue("@SSNITContribution", Convert.ToString(txtSSNITContribution.Text))
        objInsertCommands.Parameters.AddWithValue("@SLCDeduction", Convert.ToString(txtSLCDeduction.Text))
        objInsertCommands.Parameters.AddWithValue("@Gross", txtGrossSalary.Text.ToString())
        objInsertCommands.Parameters.AddWithValue("@TotalDeduction", Convert.ToString(txtTotalDeduction.Text))
        objInsertCommands.Parameters.AddWithValue("@NetPay", Convert.ToString(txtNetPay.Text))

        'Opening My connection string in try catch error handling
        Try
            objSqlConnection.Open()
            objInsertCommands.ExecuteNonQuery()

            MessageBox.Show(txtEmployeeID.Text + "  ID Payment Saved Successfully ", "Data Entry Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As SqlException
            MessageBox.Show("The following error Occur: " + ex.Message, "Query Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objSqlConnection.Close()
        End Try
        ResetControls()
        'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet6.PayRecord' table. You can move, or remove it, as needed.
        Me.PayRecordTableAdapter1.Fill(Me.CelestialPayRollDatabaseDataSet6.PayRecord)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetControls()
        MsgBox("Reset Successful")
    End Sub

    Private Sub btnGeneratePayslip_Click(sender As Object, e As EventArgs) Handles btnGeneratePayslip.Click
        Try
            Dim objPrint As New PrintPreviewDialog
            objPrint.Document = PrintDocument1
            objPrint.Show()
        Catch ex As Exception
            MessageBox.Show("The following Error Occur: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        PrintPreviewDialog1.BringToFront()
    End Sub

    Private Sub btnPrintPayslips_Click(sender As Object, e As EventArgs) Handles btnPrintPayslips.Click
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchStatement As New StringBuilder
            'Payment ID
            If txtSearchPaymentID.Text.Length > 0 Then
                If searchStatement.Length > 0 Then
                    searchStatement.Append("and")
                End If
                searchStatement.Append("Convert(PaymentID,'System.String') like '%" + txtSearchPaymentID.Text + "%'")
            End If
            'Employee ID
            If txtSearchEmployeeID.Text.Length > 0 Then

                If searchStatement.Length > 0 Then
                    searchStatement.Append("and")
                End If

                searchStatement.Append("Conver(EmployeeID,'System.String') like '%" + txtSearchEmployeeID.Text + "%'")
            End If
            'Full Name ID
            If txtSearchFullName.Text.Length > 0 Then
                If searchStatement.Length > 0 Then
                    searchStatement.Append("and")

                End If
                searchStatement.Append("FullName like '%" + txtSearchFullName.Text + "%'")
            End If
            'SSNIT Number
            If txtSearchSSNITNumber.Text.Length > 0 Then
                If searchStatement.Length > 0 Then
                    searchStatement.Append("and")
                End If
                searchStatement.Append("SSNITNumber like '%" + txtSearchSSNITNumber.Text + "%'")
            End If
            'Pay Date
            If txtPayDate.Text.Length > 0 Then
                If searchStatement.Length > 0 Then
                    searchStatement.Append("and")
                End If
                searchStatement.Append("PayDate like '%" + txtPayDate.Text + "%'")
            End If
            'SSNIT Number
            If cmbSearchPayMonth.SelectedIndex > 0 Then
                If searchStatement.Length > 0 Then
                    searchStatement.Append("and")
                End If
                searchStatement.Append("PayMonth like '%" + cmbSearchPayMonth.Text + "%'")
            End If
            PayRecordsBindingSource.Filter = searchStatement.ToString()
        Catch ex As Exception
            MessageBox.Show("The following error occur : " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearchEmployeeID.Text = ""
        txtSearchFullName.Text = ""
        txtSearchPaymentID.Text = ""
        txtSearchSSNITNumber.Text = ""
        cmbSearchPayMonth.SelectedIndex = 0
        txtPayDate.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dt As DateTime = DateTime.Now
        btnTime.Text = dt.ToString("HH:mm:ss")
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Drawing On the Print to show Print Preview Dialogue
        Dim objImage = Image.FromFile("C:\Users\David-Development PC\Documents\Visual Studio 2017\Projects\CelestialPayRoll\CelestialPayRoll\Resources\CSC.jpg")
        Dim font As Font = New Font("Arial", 24, FontStyle.Bold)
        Dim newfont As Font = New Font("Arial", 14, FontStyle.Regular)
        Dim Pen = New Pen((Color.DarkBlue), 4)
        e.Graphics.DrawLine(Pen, 60, 90, 800, 90) 'We have point x and y cordinate. x1,y1,x2,y2
        e.Graphics.DrawImage(objImage, 60, 100)
        e.Graphics.DrawLine(Pen, 60, 230, 800, 230)
        e.Graphics.DrawString("Celestial Payroll Application", font, Brushes.DarkBlue, New Point(200, 100))

        'Drawing Pay Date
        e.Graphics.DrawString("Pay Date: " + dtpPayDate.Value.ToString("d"), New Font("Arial", 14, FontStyle.Regular), Brushes.DarkBlue, New Point(600, 200))

        'Drawing Employee Details 
        e.Graphics.DrawRectangle(Pen, 60, 240, 740, 80)
        e.Graphics.DrawString($"Employee ID {txtEmployeeID.Text.ToString()} {Environment.NewLine}Name:  {txtFullName.Text.ToString()}   {Environment.NewLine}SSNIT:  {txtSSNITNumber.Text.ToString()}", newfont, Brushes.DarkBlue, New Point(62, 245))

        'Drawing Header for Payment Details 
        e.Graphics.DrawLine(Pen, 60, 370, 800, 370) 'We have point x and y cordinate. x1,y1,x2,y2
        e.Graphics.DrawString("EARNINGS", newfont, Brushes.DarkBlue, New Point(60, 345))
        e.Graphics.DrawString("AMOUNT", newfont, Brushes.DarkBlue, New Point(260, 345))
        e.Graphics.DrawString("SLC NAME", newfont, Brushes.DarkBlue, New Point(370, 345))
        e.Graphics.DrawString("DEDUCTION", newfont, Brushes.DarkBlue, New Point(500, 345))
        e.Graphics.DrawString("AMOUNT", newfont, Brushes.DarkBlue, New Point(650, 345))

        'Drawing Payment For Basic Salaries Details 
        e.Graphics.DrawString("BASIC SALARY", newfont, Brushes.DarkBlue, New Point(60, 380))
        e.Graphics.DrawString(txtGrossSalary.Text.ToString(), newfont, Brushes.DarkBlue, New Point(245, 380))
        e.Graphics.DrawString("TAX:", newfont, Brushes.DarkBlue, New Point(520, 380))
        e.Graphics.DrawString(txtServiceLoanComapanyName.Text.ToString(), newfont, Brushes.DarkBlue, New Point(380, 380))
        e.Graphics.DrawString($"{txttax.Text.ToString()}", newfont, Brushes.DarkBlue, New Point(670, 380))

        'Drawing Deduction Details 
        e.Graphics.DrawString("SSNIT: ", newfont, Brushes.DarkBlue, New Point(520, 400))
        e.Graphics.DrawString($"{txtSSNITContribution.Text.ToString()}", newfont, Brushes.DarkBlue, New Point(668, 400))
        e.Graphics.DrawString("SLC: ", newfont, Brushes.DarkBlue, New Point(520, 420))
        e.Graphics.DrawString($"{txtSLCDeduction.Text.ToString()}", newfont, Brushes.DarkBlue, New Point(670, 420))

        'Drawing Line for Total Deduction Details 
        e.Graphics.DrawLine(Pen, 60, 450, 800, 450)

        'Drawing Total Deduction Details 
        e.Graphics.DrawString("TOTAL Ded.:", newfont, Brushes.DarkBlue, New Point(520, 470))
        e.Graphics.DrawString($"{txtTotalDeduction.Text.ToString()}", newfont, Brushes.DarkBlue, New Point(660, 470))

        'Drawing Rectangle for Net Pay 
        e.Graphics.DrawRectangle(Pen, 60, 510, 740, 60)

        'Drawing String for Net Pay Details 
        e.Graphics.DrawString("NET PAY:", newfont, Brushes.DarkBlue, New Point(520, 530))
        e.Graphics.DrawString($"{txtNetPay.Text.ToString()}", newfont, Brushes.DarkBlue, New Point(660, 530))


    End Sub


End Class