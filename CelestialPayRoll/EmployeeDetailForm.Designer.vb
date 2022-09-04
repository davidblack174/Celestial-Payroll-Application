<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployeeForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmployeeForm))
        Me.btnShowGrid = New System.Windows.Forms.GroupBox()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.chkTeachingStaff = New System.Windows.Forms.CheckBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.gpbMaritalStatus = New System.Windows.Forms.GroupBox()
        Me.rdbSingle = New System.Windows.Forms.RadioButton()
        Me.rdbMarried = New System.Windows.Forms.RadioButton()
        Me.gpbGender = New System.Windows.Forms.GroupBox()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.txtSSNITNo = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblSSNITNo = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSNITNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarritalStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsTeachingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CelestialPayRollDatabaseDataSet = New CelestialPayRoll.CelestialPayRollDatabaseDataSet()
        Me.EmployeeTableAdapter = New CelestialPayRoll.CelestialPayRollDatabaseDataSetTableAdapters.EmployeeTableAdapter()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDeleteEmployee = New System.Windows.Forms.Button()
        Me.btnUpdateEmployee = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.btnShowGrid.SuspendLayout()
        Me.grpEmployeeInfo.SuspendLayout()
        Me.gpbMaritalStatus.SuspendLayout()
        Me.gpbGender.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CelestialPayRollDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShowGrid
        '
        Me.btnShowGrid.Controls.Add(Me.cmbCountry)
        Me.btnShowGrid.Controls.Add(Me.txtNote)
        Me.btnShowGrid.Controls.Add(Me.lblNote)
        Me.btnShowGrid.Controls.Add(Me.txtEmail)
        Me.btnShowGrid.Controls.Add(Me.lblEmail)
        Me.btnShowGrid.Controls.Add(Me.Label8)
        Me.btnShowGrid.Controls.Add(Me.txtPhoneNumber)
        Me.btnShowGrid.Controls.Add(Me.lblPhoneNumber)
        Me.btnShowGrid.Controls.Add(Me.txtRegion)
        Me.btnShowGrid.Controls.Add(Me.lblRegion)
        Me.btnShowGrid.Controls.Add(Me.txtCity)
        Me.btnShowGrid.Controls.Add(Me.lblCity)
        Me.btnShowGrid.Controls.Add(Me.txtAddress)
        Me.btnShowGrid.Controls.Add(Me.Label4)
        Me.btnShowGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowGrid.ForeColor = System.Drawing.SystemColors.Window
        Me.btnShowGrid.Location = New System.Drawing.Point(497, 20)
        Me.btnShowGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowGrid.Name = "btnShowGrid"
        Me.btnShowGrid.Padding = New System.Windows.Forms.Padding(4)
        Me.btnShowGrid.Size = New System.Drawing.Size(366, 481)
        Me.btnShowGrid.TabIndex = 31
        Me.btnShowGrid.TabStop = False
        Me.btnShowGrid.Text = "Employee Contact"
        '
        'cmbCountry
        '
        Me.cmbCountry.AllowDrop = True
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Austrian Empire", "Azerbaijan", "Baden*", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Bavaria*", "Belarus", "Belgium", "Belize", "Benin (Dahomey)", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Brunswick and Lüneburg", "Bulgaria", "Burkina Faso (Upper Volta)", "Burma", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Cayman Islands, The", "Central African Republic", "Central American Federation*", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo Free State, The", "Costa Rica", "Cote d’Ivoire (Ivory Coast)", "Croatia", "Cuba", "Cyprus", "Czechia", "Czechoslovakia", "Democratic Republic of the Congo", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Duchy of Parma, The*", "East Germany (German Democratic Republic)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Federal Government of Germany (1848-49)*", "Fiji", "Finland", "France", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Grand Duchy of Tuscany, The*", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Hanover*", "Hanseatic Republics*", "Hawaii*", "Hesse*", "Holy See", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kingdom of Serbia/Yugoslavia*", "Kiribati", "Korea", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Lew Chew (Loochoo)*", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mecklenburg-Schwerin*", "Mecklenburg-Strelitz*", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Namibia", "Nassau*", "Nauru", "Nepal", "Netherlands, The", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North German Confederation*", "North German Union*", "North Macedonia", "Norway", "Oldenburg*", "Oman", "Orange Free State*", "Pakistan", "Palau", "Panama", "Papal States*", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Piedmont-Sardinia*", "Poland", "Portugal", "Qatar", "Republic of Genoa*", "Republic of Korea (South Korea)", "Republic of the Congo", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Schaumburg-Lippe*", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands, The", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Tajikistan", "Tanzania", "Texas*", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Two Sicilies*", "Uganda", "Ukraine", "Union of Soviet Socialist Republics*", "United Arab Emirates, The", "United Kingdom, The", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Württemberg*", "Yemen", "Zambia", "Zimbabwe"})
        Me.cmbCountry.Location = New System.Drawing.Point(109, 155)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(187, 24)
        Me.cmbCountry.Sorted = True
        Me.cmbCountry.TabIndex = 3
        Me.cmbCountry.Text = "Select Contry"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(109, 272)
        Me.txtNote.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(187, 154)
        Me.txtNote.TabIndex = 6
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(19, 276)
        Me.lblNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(52, 17)
        Me.lblNote.TabIndex = 0
        Me.lblNote.Text = "Note: "
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(109, 233)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(187, 23)
        Me.txtEmail.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(19, 237)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 17)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 159)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Country"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(109, 194)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(187, 23)
        Me.txtPhoneNumber.TabIndex = 4
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(19, 198)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(94, 17)
        Me.lblPhoneNumber.TabIndex = 0
        Me.lblPhoneNumber.Text = "Phone No.: "
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(109, 116)
        Me.txtRegion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(187, 23)
        Me.txtRegion.TabIndex = 2
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(19, 120)
        Me.lblRegion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(59, 17)
        Me.lblRegion.TabIndex = 0
        Me.lblRegion.Text = "Region"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(109, 77)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(187, 23)
        Me.txtCity.TabIndex = 1
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(19, 81)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(35, 17)
        Me.lblCity.TabIndex = 0
        Me.lblCity.Text = "City"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(109, 38)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(187, 23)
        Me.txtAddress.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Address"
        '
        'grpEmployeeInfo
        '
        Me.grpEmployeeInfo.Controls.Add(Me.chkTeachingStaff)
        Me.grpEmployeeInfo.Controls.Add(Me.dtpDOB)
        Me.grpEmployeeInfo.Controls.Add(Me.gpbMaritalStatus)
        Me.grpEmployeeInfo.Controls.Add(Me.gpbGender)
        Me.grpEmployeeInfo.Controls.Add(Me.txtSSNITNo)
        Me.grpEmployeeInfo.Controls.Add(Me.txtLastName)
        Me.grpEmployeeInfo.Controls.Add(Me.txtFirstName)
        Me.grpEmployeeInfo.Controls.Add(Me.Label1)
        Me.grpEmployeeInfo.Controls.Add(Me.lblDOB)
        Me.grpEmployeeInfo.Controls.Add(Me.lblSSNITNo)
        Me.grpEmployeeInfo.Controls.Add(Me.txtEmployeeID)
        Me.grpEmployeeInfo.Controls.Add(Me.lblLastName)
        Me.grpEmployeeInfo.Controls.Add(Me.lblFirstName)
        Me.grpEmployeeInfo.Controls.Add(Me.lblEmployeeID)
        Me.grpEmployeeInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpEmployeeInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEmployeeInfo.ForeColor = System.Drawing.SystemColors.Window
        Me.grpEmployeeInfo.Location = New System.Drawing.Point(97, 20)
        Me.grpEmployeeInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpEmployeeInfo.Name = "grpEmployeeInfo"
        Me.grpEmployeeInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpEmployeeInfo.Size = New System.Drawing.Size(366, 481)
        Me.grpEmployeeInfo.TabIndex = 30
        Me.grpEmployeeInfo.TabStop = False
        Me.grpEmployeeInfo.Text = "Employee Information"
        '
        'chkTeachingStaff
        '
        Me.chkTeachingStaff.AutoSize = True
        Me.chkTeachingStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkTeachingStaff.Location = New System.Drawing.Point(128, 381)
        Me.chkTeachingStaff.Name = "chkTeachingStaff"
        Me.chkTeachingStaff.Size = New System.Drawing.Size(15, 14)
        Me.chkTeachingStaff.TabIndex = 6
        Me.chkTeachingStaff.UseVisualStyleBackColor = True
        '
        'dtpDOB
        '
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(114, 251)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(125, 20)
        Me.dtpDOB.TabIndex = 5
        '
        'gpbMaritalStatus
        '
        Me.gpbMaritalStatus.Controls.Add(Me.rdbSingle)
        Me.gpbMaritalStatus.Controls.Add(Me.rdbMarried)
        Me.gpbMaritalStatus.ForeColor = System.Drawing.SystemColors.Window
        Me.gpbMaritalStatus.Location = New System.Drawing.Point(25, 299)
        Me.gpbMaritalStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbMaritalStatus.Name = "gpbMaritalStatus"
        Me.gpbMaritalStatus.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbMaritalStatus.Size = New System.Drawing.Size(274, 56)
        Me.gpbMaritalStatus.TabIndex = 26
        Me.gpbMaritalStatus.TabStop = False
        Me.gpbMaritalStatus.Text = "Marrital Status"
        '
        'rdbSingle
        '
        Me.rdbSingle.AutoSize = True
        Me.rdbSingle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbSingle.Location = New System.Drawing.Point(175, 21)
        Me.rdbSingle.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbSingle.Name = "rdbSingle"
        Me.rdbSingle.Size = New System.Drawing.Size(60, 17)
        Me.rdbSingle.TabIndex = 1
        Me.rdbSingle.TabStop = True
        Me.rdbSingle.Text = "Single"
        Me.rdbSingle.UseVisualStyleBackColor = True
        '
        'rdbMarried
        '
        Me.rdbMarried.AutoSize = True
        Me.rdbMarried.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbMarried.Location = New System.Drawing.Point(87, 21)
        Me.rdbMarried.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbMarried.Name = "rdbMarried"
        Me.rdbMarried.Size = New System.Drawing.Size(67, 17)
        Me.rdbMarried.TabIndex = 0
        Me.rdbMarried.TabStop = True
        Me.rdbMarried.Text = "Married"
        Me.rdbMarried.UseVisualStyleBackColor = True
        '
        'gpbGender
        '
        Me.gpbGender.Controls.Add(Me.rdbFemale)
        Me.gpbGender.Controls.Add(Me.rdbMale)
        Me.gpbGender.ForeColor = System.Drawing.SystemColors.Window
        Me.gpbGender.Location = New System.Drawing.Point(25, 138)
        Me.gpbGender.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbGender.Name = "gpbGender"
        Me.gpbGender.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbGender.Size = New System.Drawing.Size(274, 56)
        Me.gpbGender.TabIndex = 25
        Me.gpbGender.TabStop = False
        Me.gpbGender.Text = "Gender"
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbFemale.Location = New System.Drawing.Point(185, 22)
        Me.rdbFemale.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(65, 17)
        Me.rdbFemale.TabIndex = 1
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbMale.Location = New System.Drawing.Point(87, 22)
        Me.rdbMale.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(52, 17)
        Me.rdbMale.TabIndex = 0
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'txtSSNITNo
        '
        Me.txtSSNITNo.Location = New System.Drawing.Point(112, 212)
        Me.txtSSNITNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSSNITNo.Name = "txtSSNITNo"
        Me.txtSSNITNo.Size = New System.Drawing.Size(187, 20)
        Me.txtSSNITNo.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(112, 104)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(187, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(112, 71)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(187, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 382)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Teaching Staff: "
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(22, 257)
        Me.lblDOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(85, 13)
        Me.lblDOB.TabIndex = 0
        Me.lblDOB.Text = "Date Of Birth:"
        '
        'lblSSNITNo
        '
        Me.lblSSNITNo.AutoSize = True
        Me.lblSSNITNo.Location = New System.Drawing.Point(22, 216)
        Me.lblSSNITNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSSNITNo.Name = "lblSSNITNo"
        Me.lblSSNITNo.Size = New System.Drawing.Size(68, 13)
        Me.lblSSNITNo.TabIndex = 0
        Me.lblSSNITNo.Text = "SSNIT No:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(112, 38)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(127, 20)
        Me.txtEmployeeID.TabIndex = 0
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(22, 108)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(71, 13)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(22, 75)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(75, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name: "
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(22, 42)
        Me.lblEmployeeID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(86, 13)
        Me.lblEmployeeID.TabIndex = 0
        Me.lblEmployeeID.Text = "Employee ID: "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.SSNITNumberDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.MarritalStatusDataGridViewTextBoxColumn, Me.IsTeachingDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.RegionDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(0, 556)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1021, 177)
        Me.DataGridView1.TabIndex = 33
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'SSNITNumberDataGridViewTextBoxColumn
        '
        Me.SSNITNumberDataGridViewTextBoxColumn.DataPropertyName = "SSNITNumber"
        Me.SSNITNumberDataGridViewTextBoxColumn.HeaderText = "SSNITNumber"
        Me.SSNITNumberDataGridViewTextBoxColumn.Name = "SSNITNumberDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'MarritalStatusDataGridViewTextBoxColumn
        '
        Me.MarritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MarritalStatus"
        Me.MarritalStatusDataGridViewTextBoxColumn.HeaderText = "MarritalStatus"
        Me.MarritalStatusDataGridViewTextBoxColumn.Name = "MarritalStatusDataGridViewTextBoxColumn"
        '
        'IsTeachingDataGridViewTextBoxColumn
        '
        Me.IsTeachingDataGridViewTextBoxColumn.DataPropertyName = "IsTeaching"
        Me.IsTeachingDataGridViewTextBoxColumn.HeaderText = "IsTeaching"
        Me.IsTeachingDataGridViewTextBoxColumn.Name = "IsTeachingDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'RegionDataGridViewTextBoxColumn
        '
        Me.RegionDataGridViewTextBoxColumn.DataPropertyName = "Region"
        Me.RegionDataGridViewTextBoxColumn.HeaderText = "Region"
        Me.RegionDataGridViewTextBoxColumn.Name = "RegionDataGridViewTextBoxColumn"
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "Note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "Note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.CelestialPayRollDatabaseDataSet
        '
        'CelestialPayRollDatabaseDataSet
        '
        Me.CelestialPayRollDatabaseDataSet.DataSetName = "CelestialPayRollDatabaseDataSet"
        Me.CelestialPayRollDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'btnExit
        '
        Me.btnExit.Image = Global.CelestialPayRoll.My.Resources.Resources.Button___Close__2_
        Me.btnExit.Location = New System.Drawing.Point(765, 508)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 42)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.ImageKey = "(none)"
        Me.btnPreview.Location = New System.Drawing.Point(633, 508)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnPreview.Size = New System.Drawing.Size(90, 42)
        Me.btnPreview.TabIndex = 32
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Image = Global.CelestialPayRoll.My.Resources.Resources.Restricted__14_
        Me.btnReset.Location = New System.Drawing.Point(501, 508)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 42)
        Me.btnReset.TabIndex = 32
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDeleteEmployee
        '
        Me.btnDeleteEmployee.Image = Global.CelestialPayRoll.My.Resources.Resources.Disk_Cleanup
        Me.btnDeleteEmployee.Location = New System.Drawing.Point(369, 508)
        Me.btnDeleteEmployee.Name = "btnDeleteEmployee"
        Me.btnDeleteEmployee.Size = New System.Drawing.Size(90, 42)
        Me.btnDeleteEmployee.TabIndex = 32
        Me.btnDeleteEmployee.Text = "Delete"
        Me.btnDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteEmployee.UseVisualStyleBackColor = True
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.Image = Global.CelestialPayRoll.My.Resources.Resources.Update
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(237, 508)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(90, 42)
        Me.btnUpdateEmployee.TabIndex = 32
        Me.btnUpdateEmployee.Text = "Update"
        Me.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateEmployee.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Image = Global.CelestialPayRoll.My.Resources.Resources.Address_Book__3_
        Me.btnAddEmployee.Location = New System.Drawing.Point(105, 508)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(90, 42)
        Me.btnAddEmployee.TabIndex = 32
        Me.btnAddEmployee.Text = "Add "
        Me.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'FormEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1021, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDeleteEmployee)
        Me.Controls.Add(Me.btnUpdateEmployee)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.btnShowGrid)
        Me.Controls.Add(Me.grpEmployeeInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.btnShowGrid.ResumeLayout(False)
        Me.btnShowGrid.PerformLayout()
        Me.grpEmployeeInfo.ResumeLayout(False)
        Me.grpEmployeeInfo.PerformLayout()
        Me.gpbMaritalStatus.ResumeLayout(False)
        Me.gpbMaritalStatus.PerformLayout()
        Me.gpbGender.ResumeLayout(False)
        Me.gpbGender.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CelestialPayRollDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowGrid As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCountry As System.Windows.Forms.ComboBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtRegion As System.Windows.Forms.TextBox
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpEmployeeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents chkTeachingStaff As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents gpbMaritalStatus As System.Windows.Forms.GroupBox
    Friend WithEvents rdbSingle As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMarried As System.Windows.Forms.RadioButton
    Friend WithEvents gpbGender As System.Windows.Forms.GroupBox
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtSSNITNo As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents lblSSNITNo As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeID As System.Windows.Forms.Label
    Friend WithEvents btnAddEmployee As System.Windows.Forms.Button
    Friend WithEvents btnUpdateEmployee As System.Windows.Forms.Button
    Friend WithEvents btnDeleteEmployee As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CelestialPayRollDatabaseDataSet As CelestialPayRoll.CelestialPayRollDatabaseDataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As CelestialPayRoll.CelestialPayRollDatabaseDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSNITNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarritalStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsTeachingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
