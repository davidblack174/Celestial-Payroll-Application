<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayRollCalculatorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayRollCalculatorForm))
        Me.btnShowGrid = New System.Windows.Forms.GroupBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.txtTotalDeduction = New System.Windows.Forms.TextBox()
        Me.txtServiceLoanComapanyName = New System.Windows.Forms.TextBox()
        Me.txtGrossSalary = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSLCDeduction = New System.Windows.Forms.TextBox()
        Me.txtSSNITContribution = New System.Windows.Forms.TextBox()
        Me.txttax = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.cmbPayMonth = New System.Windows.Forms.ComboBox()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpPayDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtSSNITNumber = New System.Windows.Forms.TextBox()
        Me.lblSSNITNumber = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PaymentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSNITNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSNITContributionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayMonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayRecordBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CelestialPayRollDatabaseDataSet6 = New CelestialPayRoll.CelestialPayRollDatabaseDataSet6()
        Me.PayRecordsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CelestialPayRollDatabaseDataSet2 = New CelestialPayRoll.CelestialPayRollDatabaseDataSet2()
        Me.PayRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CelestialPayRollDatabaseDataSet3 = New CelestialPayRoll.CelestialPayRollDatabaseDataSet3()
        Me.PayRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CelestialPayRollDatabaseDataSet1 = New CelestialPayRoll.CelestialPayRollDatabaseDataSet1()
        Me.PayRecordsTableAdapter = New CelestialPayRoll.CelestialPayRollDatabaseDataSet1TableAdapters.PayRecordsTableAdapter()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.grpSearchPayment = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.cmbSearchPayMonth = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtPayDate = New System.Windows.Forms.TextBox()
        Me.txtSearchSSNITNumber = New System.Windows.Forms.TextBox()
        Me.txtSearchFullName = New System.Windows.Forms.TextBox()
        Me.txtSearchEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtSearchPaymentID = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PayRecordsTableAdapter1 = New CelestialPayRoll.CelestialPayRollDatabaseDataSet2TableAdapters.PayRecordsTableAdapter()
        Me.PayRecordTableAdapter = New CelestialPayRoll.CelestialPayRollDatabaseDataSet3TableAdapters.PayRecordTableAdapter()
        Me.btnComputePayment = New System.Windows.Forms.Button()
        Me.btnSavePayment = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPrintPayslips = New System.Windows.Forms.Button()
        Me.btnGeneratePayslip = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PayRecordTableAdapter1 = New CelestialPayRoll.CelestialPayRollDatabaseDataSet6TableAdapters.PayRecordTableAdapter()
        Me.btnShowGrid.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayRecordBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CelestialPayRollDatabaseDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayRecordsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CelestialPayRollDatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CelestialPayRollDatabaseDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CelestialPayRollDatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShowGrid
        '
        Me.btnShowGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnShowGrid.Controls.Add(Me.txtNetPay)
        Me.btnShowGrid.Controls.Add(Me.txtTotalDeduction)
        Me.btnShowGrid.Controls.Add(Me.txtServiceLoanComapanyName)
        Me.btnShowGrid.Controls.Add(Me.txtGrossSalary)
        Me.btnShowGrid.Controls.Add(Me.Label7)
        Me.btnShowGrid.Controls.Add(Me.GroupBox1)
        Me.btnShowGrid.Controls.Add(Me.cmbPayMonth)
        Me.btnShowGrid.Controls.Add(Me.btnGet)
        Me.btnShowGrid.Controls.Add(Me.Label6)
        Me.btnShowGrid.Controls.Add(Me.Label5)
        Me.btnShowGrid.Controls.Add(Me.Label3)
        Me.btnShowGrid.Controls.Add(Me.dtpPayDate)
        Me.btnShowGrid.Controls.Add(Me.Label8)
        Me.btnShowGrid.Controls.Add(Me.lblPhoneNumber)
        Me.btnShowGrid.Controls.Add(Me.txtSSNITNumber)
        Me.btnShowGrid.Controls.Add(Me.lblSSNITNumber)
        Me.btnShowGrid.Controls.Add(Me.txtFullName)
        Me.btnShowGrid.Controls.Add(Me.lblFullName)
        Me.btnShowGrid.Controls.Add(Me.txtEmployeeID)
        Me.btnShowGrid.Controls.Add(Me.Label4)
        Me.btnShowGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowGrid.ForeColor = System.Drawing.SystemColors.Window
        Me.btnShowGrid.Location = New System.Drawing.Point(100, 25)
        Me.btnShowGrid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnShowGrid.Name = "btnShowGrid"
        Me.btnShowGrid.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnShowGrid.Size = New System.Drawing.Size(366, 459)
        Me.btnShowGrid.TabIndex = 32
        Me.btnShowGrid.TabStop = False
        Me.btnShowGrid.Text = "Employee Contact"
        '
        'txtNetPay
        '
        Me.txtNetPay.Cursor = System.Windows.Forms.Cursors.No
        Me.txtNetPay.Enabled = False
        Me.txtNetPay.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetPay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNetPay.Location = New System.Drawing.Point(233, 426)
        Me.txtNetPay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(105, 23)
        Me.txtNetPay.TabIndex = 11
        Me.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDeduction
        '
        Me.txtTotalDeduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDeduction.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTotalDeduction.Enabled = False
        Me.txtTotalDeduction.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDeduction.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalDeduction.Location = New System.Drawing.Point(233, 395)
        Me.txtTotalDeduction.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTotalDeduction.Name = "txtTotalDeduction"
        Me.txtTotalDeduction.ReadOnly = True
        Me.txtTotalDeduction.ShortcutsEnabled = False
        Me.txtTotalDeduction.Size = New System.Drawing.Size(105, 23)
        Me.txtTotalDeduction.TabIndex = 9
        Me.txtTotalDeduction.TabStop = False
        Me.txtTotalDeduction.Text = "GHC 0.00"
        Me.txtTotalDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtServiceLoanComapanyName
        '
        Me.txtServiceLoanComapanyName.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceLoanComapanyName.Location = New System.Drawing.Point(156, 215)
        Me.txtServiceLoanComapanyName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtServiceLoanComapanyName.Name = "txtServiceLoanComapanyName"
        Me.txtServiceLoanComapanyName.Size = New System.Drawing.Size(182, 23)
        Me.txtServiceLoanComapanyName.TabIndex = 6
        '
        'txtGrossSalary
        '
        Me.txtGrossSalary.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossSalary.Location = New System.Drawing.Point(233, 364)
        Me.txtGrossSalary.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtGrossSalary.Name = "txtGrossSalary"
        Me.txtGrossSalary.Size = New System.Drawing.Size(105, 23)
        Me.txtGrossSalary.TabIndex = 8
        Me.txtGrossSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 218)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "SLC Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSLCDeduction)
        Me.GroupBox1.Controls.Add(Me.txtSSNITContribution)
        Me.GroupBox1.Controls.Add(Me.txttax)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(22, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 115)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deduction"
        '
        'txtSLCDeduction
        '
        Me.txtSLCDeduction.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSLCDeduction.Location = New System.Drawing.Point(211, 79)
        Me.txtSLCDeduction.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSLCDeduction.Name = "txtSLCDeduction"
        Me.txtSLCDeduction.Size = New System.Drawing.Size(105, 23)
        Me.txtSLCDeduction.TabIndex = 2
        Me.txtSLCDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSSNITContribution
        '
        Me.txtSSNITContribution.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSNITContribution.Location = New System.Drawing.Point(211, 48)
        Me.txtSSNITContribution.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSSNITContribution.Name = "txtSSNITContribution"
        Me.txtSSNITContribution.Size = New System.Drawing.Size(105, 23)
        Me.txtSSNITContribution.TabIndex = 1
        Me.txtSSNITContribution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttax
        '
        Me.txttax.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttax.Location = New System.Drawing.Point(211, 16)
        Me.txttax.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txttax.Name = "txttax"
        Me.txttax.Size = New System.Drawing.Size(105, 23)
        Me.txttax.TabIndex = 0
        Me.txttax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tax Deduction:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SLC Deduction:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(18, 51)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(151, 17)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "SSNIT Contribution:"
        '
        'cmbPayMonth
        '
        Me.cmbPayMonth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayMonth.FormattingEnabled = True
        Me.cmbPayMonth.Location = New System.Drawing.Point(156, 177)
        Me.cmbPayMonth.Name = "cmbPayMonth"
        Me.cmbPayMonth.Size = New System.Drawing.Size(121, 24)
        Me.cmbPayMonth.TabIndex = 5
        '
        'btnGet
        '
        Me.btnGet.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnGet.FlatAppearance.BorderSize = 0
        Me.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGet.ForeColor = System.Drawing.SystemColors.Window
        Me.btnGet.Location = New System.Drawing.Point(233, 17)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(75, 32)
        Me.btnGet.TabIndex = 1
        Me.btnGet.Text = "Get"
        Me.btnGet.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 429)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Net Pay"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 399)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Deduction:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 368)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Basic Salary:"
        '
        'dtpPayDate
        '
        Me.dtpPayDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPayDate.Location = New System.Drawing.Point(156, 136)
        Me.dtpPayDate.MinDate = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.Size = New System.Drawing.Size(121, 23)
        Me.dtpPayDate.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 141)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Pay Date:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(19, 179)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(84, 17)
        Me.lblPhoneNumber.TabIndex = 0
        Me.lblPhoneNumber.Text = "Pay Month"
        '
        'txtSSNITNumber
        '
        Me.txtSSNITNumber.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSNITNumber.Location = New System.Drawing.Point(156, 99)
        Me.txtSSNITNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSSNITNumber.Name = "txtSSNITNumber"
        Me.txtSSNITNumber.Size = New System.Drawing.Size(164, 23)
        Me.txtSSNITNumber.TabIndex = 3
        '
        'lblSSNITNumber
        '
        Me.lblSSNITNumber.AutoSize = True
        Me.lblSSNITNumber.Location = New System.Drawing.Point(19, 103)
        Me.lblSSNITNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSSNITNumber.Name = "lblSSNITNumber"
        Me.lblSSNITNumber.Size = New System.Drawing.Size(114, 17)
        Me.lblSSNITNumber.TabIndex = 0
        Me.lblSSNITNumber.Text = "SSNIT Number"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(156, 63)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(164, 23)
        Me.txtFullName.TabIndex = 2
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(19, 67)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(85, 17)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeID.Location = New System.Drawing.Point(156, 27)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(70, 23)
        Me.txtEmployeeID.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "EmployeeID:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentIDDataGridViewTextBoxColumn, Me.EMployeeIDDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.SSNITNumberDataGridViewTextBoxColumn, Me.SSNITContributionDataGridViewTextBoxColumn, Me.PayDateDataGridViewTextBoxColumn, Me.PayMonthDataGridViewTextBoxColumn, Me.NetPayDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PayRecordBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 535)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(932, 178)
        Me.DataGridView1.TabIndex = 1
        '
        'PaymentIDDataGridViewTextBoxColumn
        '
        Me.PaymentIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentID"
        Me.PaymentIDDataGridViewTextBoxColumn.HeaderText = "PaymentID"
        Me.PaymentIDDataGridViewTextBoxColumn.Name = "PaymentIDDataGridViewTextBoxColumn"
        Me.PaymentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMployeeIDDataGridViewTextBoxColumn
        '
        Me.EMployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EMployeeID"
        Me.EMployeeIDDataGridViewTextBoxColumn.HeaderText = "EMployeeID"
        Me.EMployeeIDDataGridViewTextBoxColumn.Name = "EMployeeIDDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'SSNITNumberDataGridViewTextBoxColumn
        '
        Me.SSNITNumberDataGridViewTextBoxColumn.DataPropertyName = "SSNITNumber"
        Me.SSNITNumberDataGridViewTextBoxColumn.HeaderText = "SSNITNumber"
        Me.SSNITNumberDataGridViewTextBoxColumn.Name = "SSNITNumberDataGridViewTextBoxColumn"
        '
        'SSNITContributionDataGridViewTextBoxColumn
        '
        Me.SSNITContributionDataGridViewTextBoxColumn.DataPropertyName = "SSNITContribution"
        Me.SSNITContributionDataGridViewTextBoxColumn.HeaderText = "SSNITContribution"
        Me.SSNITContributionDataGridViewTextBoxColumn.Name = "SSNITContributionDataGridViewTextBoxColumn"
        '
        'PayDateDataGridViewTextBoxColumn
        '
        Me.PayDateDataGridViewTextBoxColumn.DataPropertyName = "PayDate"
        Me.PayDateDataGridViewTextBoxColumn.HeaderText = "PayDate"
        Me.PayDateDataGridViewTextBoxColumn.Name = "PayDateDataGridViewTextBoxColumn"
        '
        'PayMonthDataGridViewTextBoxColumn
        '
        Me.PayMonthDataGridViewTextBoxColumn.DataPropertyName = "PayMonth"
        Me.PayMonthDataGridViewTextBoxColumn.HeaderText = "PayMonth"
        Me.PayMonthDataGridViewTextBoxColumn.Name = "PayMonthDataGridViewTextBoxColumn"
        '
        'NetPayDataGridViewTextBoxColumn
        '
        Me.NetPayDataGridViewTextBoxColumn.DataPropertyName = "NetPay"
        Me.NetPayDataGridViewTextBoxColumn.HeaderText = "NetPay"
        Me.NetPayDataGridViewTextBoxColumn.Name = "NetPayDataGridViewTextBoxColumn"
        '
        'PayRecordBindingSource1
        '
        Me.PayRecordBindingSource1.DataMember = "PayRecord"
        Me.PayRecordBindingSource1.DataSource = Me.CelestialPayRollDatabaseDataSet6
        '
        'CelestialPayRollDatabaseDataSet6
        '
        Me.CelestialPayRollDatabaseDataSet6.DataSetName = "CelestialPayRollDatabaseDataSet6"
        Me.CelestialPayRollDatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PayRecordsBindingSource1
        '
        Me.PayRecordsBindingSource1.DataMember = "PayRecords"
        Me.PayRecordsBindingSource1.DataSource = Me.CelestialPayRollDatabaseDataSet2
        '
        'CelestialPayRollDatabaseDataSet2
        '
        Me.CelestialPayRollDatabaseDataSet2.DataSetName = "CelestialPayRollDatabaseDataSet2"
        Me.CelestialPayRollDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PayRecordBindingSource
        '
        Me.PayRecordBindingSource.DataMember = "PayRecord"
        Me.PayRecordBindingSource.DataSource = Me.CelestialPayRollDatabaseDataSet3
        '
        'CelestialPayRollDatabaseDataSet3
        '
        Me.CelestialPayRollDatabaseDataSet3.DataSetName = "CelestialPayRollDatabaseDataSet3"
        Me.CelestialPayRollDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PayRecordsBindingSource
        '
        Me.PayRecordsBindingSource.DataMember = "PayRecords"
        Me.PayRecordsBindingSource.DataSource = Me.CelestialPayRollDatabaseDataSet1
        '
        'CelestialPayRollDatabaseDataSet1
        '
        Me.CelestialPayRollDatabaseDataSet1.DataSetName = "CelestialPayRollDatabaseDataSet1"
        Me.CelestialPayRollDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PayRecordsTableAdapter
        '
        Me.PayRecordsTableAdapter.ClearBeforeFill = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'grpSearchPayment
        '
        Me.grpSearchPayment.Controls.Add(Me.btnSearch)
        Me.grpSearchPayment.Controls.Add(Me.btnClearSearch)
        Me.grpSearchPayment.Controls.Add(Me.cmbSearchPayMonth)
        Me.grpSearchPayment.Controls.Add(Me.Label34)
        Me.grpSearchPayment.Controls.Add(Me.Label33)
        Me.grpSearchPayment.Controls.Add(Me.Label32)
        Me.grpSearchPayment.Controls.Add(Me.txtPayDate)
        Me.grpSearchPayment.Controls.Add(Me.txtSearchSSNITNumber)
        Me.grpSearchPayment.Controls.Add(Me.txtSearchFullName)
        Me.grpSearchPayment.Controls.Add(Me.txtSearchEmployeeID)
        Me.grpSearchPayment.Controls.Add(Me.txtSearchPaymentID)
        Me.grpSearchPayment.Controls.Add(Me.Label31)
        Me.grpSearchPayment.Controls.Add(Me.Label30)
        Me.grpSearchPayment.Controls.Add(Me.Label29)
        Me.grpSearchPayment.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchPayment.ForeColor = System.Drawing.SystemColors.Window
        Me.grpSearchPayment.Location = New System.Drawing.Point(498, 158)
        Me.grpSearchPayment.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpSearchPayment.Name = "grpSearchPayment"
        Me.grpSearchPayment.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpSearchPayment.Size = New System.Drawing.Size(269, 326)
        Me.grpSearchPayment.TabIndex = 0
        Me.grpSearchPayment.TabStop = False
        Me.grpSearchPayment.Text = "Search Payment Record"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Lime
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnSearch.Image = Global.CelestialPayRoll.My.Resources.Resources.Pinture_Zoom
        Me.btnSearch.Location = New System.Drawing.Point(138, 25)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(114, 38)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "   Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClearSearch
        '
        Me.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClearSearch.Image = Global.CelestialPayRoll.My.Resources.Resources.Update
        Me.btnClearSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClearSearch.Location = New System.Drawing.Point(18, 25)
        Me.btnClearSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClearSearch.Size = New System.Drawing.Size(107, 38)
        Me.btnClearSearch.TabIndex = 7
        Me.btnClearSearch.Text = "   Clear"
        Me.btnClearSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearSearch.UseVisualStyleBackColor = False
        '
        'cmbSearchPayMonth
        '
        Me.cmbSearchPayMonth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchPayMonth.FormattingEnabled = True
        Me.cmbSearchPayMonth.Location = New System.Drawing.Point(125, 285)
        Me.cmbSearchPayMonth.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbSearchPayMonth.Name = "cmbSearchPayMonth"
        Me.cmbSearchPayMonth.Size = New System.Drawing.Size(126, 24)
        Me.cmbSearchPayMonth.TabIndex = 6
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(11, 290)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(78, 16)
        Me.Label34.TabIndex = 42
        Me.Label34.Text = "Pay Month"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(11, 248)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(68, 16)
        Me.Label33.TabIndex = 42
        Me.Label33.Text = "Pay Date"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(11, 208)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(77, 16)
        Me.Label32.TabIndex = 42
        Me.Label32.Text = "SSNIT No:"
        '
        'txtPayDate
        '
        Me.txtPayDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayDate.Location = New System.Drawing.Point(125, 244)
        Me.txtPayDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPayDate.Name = "txtPayDate"
        Me.txtPayDate.Size = New System.Drawing.Size(123, 23)
        Me.txtPayDate.TabIndex = 5
        '
        'txtSearchSSNITNumber
        '
        Me.txtSearchSSNITNumber.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchSSNITNumber.Location = New System.Drawing.Point(125, 204)
        Me.txtSearchSSNITNumber.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSearchSSNITNumber.Name = "txtSearchSSNITNumber"
        Me.txtSearchSSNITNumber.Size = New System.Drawing.Size(123, 23)
        Me.txtSearchSSNITNumber.TabIndex = 4
        '
        'txtSearchFullName
        '
        Me.txtSearchFullName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchFullName.Location = New System.Drawing.Point(125, 165)
        Me.txtSearchFullName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSearchFullName.Name = "txtSearchFullName"
        Me.txtSearchFullName.Size = New System.Drawing.Size(123, 23)
        Me.txtSearchFullName.TabIndex = 3
        '
        'txtSearchEmployeeID
        '
        Me.txtSearchEmployeeID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchEmployeeID.Location = New System.Drawing.Point(125, 124)
        Me.txtSearchEmployeeID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSearchEmployeeID.Name = "txtSearchEmployeeID"
        Me.txtSearchEmployeeID.Size = New System.Drawing.Size(123, 23)
        Me.txtSearchEmployeeID.TabIndex = 2
        '
        'txtSearchPaymentID
        '
        Me.txtSearchPaymentID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchPaymentID.Location = New System.Drawing.Point(125, 84)
        Me.txtSearchPaymentID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSearchPaymentID.Name = "txtSearchPaymentID"
        Me.txtSearchPaymentID.Size = New System.Drawing.Size(123, 23)
        Me.txtSearchPaymentID.TabIndex = 1
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(11, 168)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(71, 16)
        Me.Label31.TabIndex = 42
        Me.Label31.Text = "Full Name"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(11, 126)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(89, 16)
        Me.Label30.TabIndex = 42
        Me.Label30.Text = "Employee ID"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(11, 85)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(90, 16)
        Me.Label29.TabIndex = 42
        Me.Label29.Text = "Payment ID:"
        '
        'btnTime
        '
        Me.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTime.ForeColor = System.Drawing.SystemColors.Window
        Me.btnTime.Location = New System.Drawing.Point(546, 42)
        Me.btnTime.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(200, 69)
        Me.btnTime.TabIndex = 34
        Me.btnTime.Text = "00:00:00"
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PayRecordsTableAdapter1
        '
        Me.PayRecordsTableAdapter1.ClearBeforeFill = True
        '
        'PayRecordTableAdapter
        '
        Me.PayRecordTableAdapter.ClearBeforeFill = True
        '
        'btnComputePayment
        '
        Me.btnComputePayment.BackColor = System.Drawing.Color.Khaki
        Me.btnComputePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComputePayment.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputePayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnComputePayment.Image = Global.CelestialPayRoll.My.Resources.Resources.Calculator__4_
        Me.btnComputePayment.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnComputePayment.Location = New System.Drawing.Point(37, 490)
        Me.btnComputePayment.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnComputePayment.Name = "btnComputePayment"
        Me.btnComputePayment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnComputePayment.Size = New System.Drawing.Size(106, 38)
        Me.btnComputePayment.TabIndex = 1
        Me.btnComputePayment.Text = "Compute Payment"
        Me.btnComputePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnComputePayment.UseVisualStyleBackColor = False
        '
        'btnSavePayment
        '
        Me.btnSavePayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSavePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePayment.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSavePayment.Image = CType(resources.GetObject("btnSavePayment.Image"), System.Drawing.Image)
        Me.btnSavePayment.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSavePayment.Location = New System.Drawing.Point(189, 490)
        Me.btnSavePayment.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSavePayment.Name = "btnSavePayment"
        Me.btnSavePayment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSavePayment.Size = New System.Drawing.Size(106, 38)
        Me.btnSavePayment.TabIndex = 2
        Me.btnSavePayment.Text = "Save Payment"
        Me.btnSavePayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSavePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSavePayment.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReset.Image = Global.CelestialPayRoll.My.Resources.Resources.Restricted__14_1
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnReset.Location = New System.Drawing.Point(341, 490)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReset.Size = New System.Drawing.Size(106, 38)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "  Reset"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnPrintPayslips
        '
        Me.btnPrintPayslips.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrintPayslips.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintPayslips.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPayslips.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPrintPayslips.Image = Global.CelestialPayRoll.My.Resources.Resources.Printer__15_
        Me.btnPrintPayslips.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPrintPayslips.Location = New System.Drawing.Point(653, 490)
        Me.btnPrintPayslips.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnPrintPayslips.Name = "btnPrintPayslips"
        Me.btnPrintPayslips.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrintPayslips.Size = New System.Drawing.Size(114, 38)
        Me.btnPrintPayslips.TabIndex = 5
        Me.btnPrintPayslips.Text = "Print Payslip"
        Me.btnPrintPayslips.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrintPayslips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintPayslips.UseVisualStyleBackColor = False
        '
        'btnGeneratePayslip
        '
        Me.btnGeneratePayslip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGeneratePayslip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneratePayslip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneratePayslip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGeneratePayslip.Image = Global.CelestialPayRoll.My.Resources.Resources.Folder___Printer
        Me.btnGeneratePayslip.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnGeneratePayslip.Location = New System.Drawing.Point(493, 490)
        Me.btnGeneratePayslip.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGeneratePayslip.Name = "btnGeneratePayslip"
        Me.btnGeneratePayslip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGeneratePayslip.Size = New System.Drawing.Size(114, 38)
        Me.btnGeneratePayslip.TabIndex = 4
        Me.btnGeneratePayslip.Text = "Generate Payslips"
        Me.btnGeneratePayslip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGeneratePayslip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGeneratePayslip.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Image = Global.CelestialPayRoll.My.Resources.Resources.Button___Close__2_
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExit.Location = New System.Drawing.Point(813, 490)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(106, 38)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "   Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PayRecordTableAdapter1
        '
        Me.PayRecordTableAdapter1.ClearBeforeFill = True
        '
        'PayRollCalculatorForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(932, 713)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.grpSearchPayment)
        Me.Controls.Add(Me.btnComputePayment)
        Me.Controls.Add(Me.btnSavePayment)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPrintPayslips)
        Me.Controls.Add(Me.btnGeneratePayslip)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnShowGrid)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PayRollCalculatorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PayRollCalculatorForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.btnShowGrid.ResumeLayout(False)
        Me.btnShowGrid.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayRecordBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CelestialPayRollDatabaseDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayRecordsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CelestialPayRollDatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CelestialPayRollDatabaseDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CelestialPayRollDatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchPayment.ResumeLayout(False)
        Me.grpSearchPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowGrid As System.Windows.Forms.GroupBox
    Friend WithEvents btnGet As System.Windows.Forms.Button
    Friend WithEvents dtpPayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSSNITContribution As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttax As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtSSNITNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblSSNITNumber As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbPayMonth As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDeduction As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CelestialPayRollDatabaseDataSet1 As CelestialPayRoll.CelestialPayRollDatabaseDataSet1
    Friend WithEvents PayRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PayRecordsTableAdapter As CelestialPayRoll.CelestialPayRollDatabaseDataSet1TableAdapters.PayRecordsTableAdapter
    Friend WithEvents txtServiceLoanComapanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PaymentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMployeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSNITNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSNITContributionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayMonthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NetPayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnComputePayment As Button
    Friend WithEvents btnSavePayment As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnGeneratePayslip As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrintPayslips As Button
    Friend WithEvents txtSLCDeduction As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents grpSearchPayment As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents cmbSearchPayMonth As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtPayDate As TextBox
    Friend WithEvents txtSearchSSNITNumber As TextBox
    Friend WithEvents txtSearchFullName As TextBox
    Friend WithEvents txtSearchEmployeeID As TextBox
    Friend WithEvents txtSearchPaymentID As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btnTime As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CelestialPayRollDatabaseDataSet2 As CelestialPayRollDatabaseDataSet2
    Friend WithEvents PayRecordsBindingSource1 As BindingSource
    Friend WithEvents PayRecordsTableAdapter1 As CelestialPayRollDatabaseDataSet2TableAdapters.PayRecordsTableAdapter
    Friend WithEvents CelestialPayRollDatabaseDataSet3 As CelestialPayRollDatabaseDataSet3
    Friend WithEvents PayRecordBindingSource As BindingSource
    Friend WithEvents PayRecordTableAdapter As CelestialPayRollDatabaseDataSet3TableAdapters.PayRecordTableAdapter
    Friend WithEvents CelestialPayRollDatabaseDataSet6 As CelestialPayRollDatabaseDataSet6
    Friend WithEvents PayRecordBindingSource1 As BindingSource
    Friend WithEvents PayRecordTableAdapter1 As CelestialPayRollDatabaseDataSet6TableAdapters.PayRecordTableAdapter
End Class
