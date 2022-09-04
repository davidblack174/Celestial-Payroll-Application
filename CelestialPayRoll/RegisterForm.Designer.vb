<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gpbRegisterUser = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRegisterRoleDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRegisterRole = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRegisterPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRegisterUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.gpbRegisteredUser = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CelestialPayRollDatabaseDataSet4 = New CelestialPayRoll.CelestialPayRollDatabaseDataSet4()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.btnRegisterNow = New System.Windows.Forms.Button()
        Me.UsersTableAdapter = New CelestialPayRoll.CelestialPayRollDatabaseDataSet4TableAdapters.UsersTableAdapter()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbRegisterUser.SuspendLayout()
        Me.gpbRegisteredUser.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CelestialPayRollDatabaseDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbRegisterUser
        '
        Me.gpbRegisterUser.Controls.Add(Me.GroupBox2)
        Me.gpbRegisterUser.Controls.Add(Me.txtRegisterRoleDescription)
        Me.gpbRegisterUser.Controls.Add(Me.Label4)
        Me.gpbRegisterUser.Controls.Add(Me.txtRegisterRole)
        Me.gpbRegisterUser.Controls.Add(Me.Label3)
        Me.gpbRegisterUser.Controls.Add(Me.txtConfirmPassword)
        Me.gpbRegisterUser.Controls.Add(Me.Label2)
        Me.gpbRegisterUser.Controls.Add(Me.txtRegisterPassword)
        Me.gpbRegisterUser.Controls.Add(Me.Label1)
        Me.gpbRegisterUser.Controls.Add(Me.txtRegisterUserName)
        Me.gpbRegisterUser.Controls.Add(Me.lblUserName)
        Me.gpbRegisterUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegisterUser.ForeColor = System.Drawing.SystemColors.Window
        Me.gpbRegisterUser.Location = New System.Drawing.Point(44, 13)
        Me.gpbRegisterUser.Name = "gpbRegisterUser"
        Me.gpbRegisterUser.Size = New System.Drawing.Size(289, 467)
        Me.gpbRegisterUser.TabIndex = 0
        Me.gpbRegisterUser.TabStop = False
        Me.gpbRegisterUser.Text = "Register User"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(0, 473)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(725, 49)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'txtRegisterRoleDescription
        '
        Me.txtRegisterRoleDescription.Location = New System.Drawing.Point(95, 331)
        Me.txtRegisterRoleDescription.Multiline = True
        Me.txtRegisterRoleDescription.Name = "txtRegisterRoleDescription"
        Me.txtRegisterRoleDescription.Size = New System.Drawing.Size(174, 109)
        Me.txtRegisterRoleDescription.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 34)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Role " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Desciption"
        '
        'txtRegisterRole
        '
        Me.txtRegisterRole.Location = New System.Drawing.Point(96, 256)
        Me.txtRegisterRole.Name = "txtRegisterRole"
        Me.txtRegisterRole.Size = New System.Drawing.Size(173, 23)
        Me.txtRegisterRole.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Role:"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(95, 181)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(174, 23)
        Me.txtConfirmPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 34)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Confirm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password:"
        '
        'txtRegisterPassword
        '
        Me.txtRegisterPassword.Location = New System.Drawing.Point(95, 106)
        Me.txtRegisterPassword.Name = "txtRegisterPassword"
        Me.txtRegisterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegisterPassword.Size = New System.Drawing.Size(174, 23)
        Me.txtRegisterPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password:"
        '
        'txtRegisterUserName
        '
        Me.txtRegisterUserName.Location = New System.Drawing.Point(95, 31)
        Me.txtRegisterUserName.Name = "txtRegisterUserName"
        Me.txtRegisterUserName.Size = New System.Drawing.Size(174, 23)
        Me.txtRegisterUserName.TabIndex = 0
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(6, 37)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(93, 17)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "User Name:"
        '
        'gpbRegisteredUser
        '
        Me.gpbRegisteredUser.Controls.Add(Me.DataGridView1)
        Me.gpbRegisteredUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegisteredUser.ForeColor = System.Drawing.SystemColors.Window
        Me.gpbRegisteredUser.Location = New System.Drawing.Point(352, 13)
        Me.gpbRegisteredUser.Name = "gpbRegisteredUser"
        Me.gpbRegisteredUser.Size = New System.Drawing.Size(443, 467)
        Me.gpbRegisteredUser.TabIndex = 0
        Me.gpbRegisteredUser.TabStop = False
        Me.gpbRegisteredUser.Text = "Registered User"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.RolesDataGridViewTextBoxColumn, Me.RoleDescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UsersBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.WindowText
        Me.DataGridView1.Location = New System.Drawing.Point(22, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(395, 403)
        Me.DataGridView1.TabIndex = 0
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.CelestialPayRollDatabaseDataSet4
        '
        'CelestialPayRollDatabaseDataSet4
        '
        Me.CelestialPayRollDatabaseDataSet4.DataSetName = "CelestialPayRollDatabaseDataSet4"
        Me.CelestialPayRollDatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 551)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnReset)
        Me.GroupBox3.Controls.Add(Me.btnUpdateUser)
        Me.GroupBox3.Controls.Add(Me.btnRegisterNow)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox3.Location = New System.Drawing.Point(31, 481)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(751, 60)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnDelete.Location = New System.Drawing.Point(580, 16)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(144, 30)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnReset.Location = New System.Drawing.Point(390, 16)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(144, 30)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdateUser.FlatAppearance.BorderSize = 0
        Me.btnUpdateUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdateUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateUser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnUpdateUser.Location = New System.Drawing.Point(200, 16)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(144, 30)
        Me.btnUpdateUser.TabIndex = 6
        Me.btnUpdateUser.Text = "Update User"
        Me.btnUpdateUser.UseVisualStyleBackColor = False
        '
        'btnRegisterNow
        '
        Me.btnRegisterNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegisterNow.FlatAppearance.BorderSize = 0
        Me.btnRegisterNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterNow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnRegisterNow.Location = New System.Drawing.Point(10, 16)
        Me.btnRegisterNow.Name = "btnRegisterNow"
        Me.btnRegisterNow.Size = New System.Drawing.Size(144, 30)
        Me.btnRegisterNow.TabIndex = 5
        Me.btnRegisterNow.Text = "Register Now"
        Me.btnRegisterNow.UseVisualStyleBackColor = False
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UserIDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UserNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PasswordDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'RolesDataGridViewTextBoxColumn
        '
        Me.RolesDataGridViewTextBoxColumn.DataPropertyName = "Roles"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RolesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.RolesDataGridViewTextBoxColumn.HeaderText = "Roles"
        Me.RolesDataGridViewTextBoxColumn.Name = "RolesDataGridViewTextBoxColumn"
        '
        'RoleDescriptionDataGridViewTextBoxColumn
        '
        Me.RoleDescriptionDataGridViewTextBoxColumn.DataPropertyName = "RoleDescription"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RoleDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.RoleDescriptionDataGridViewTextBoxColumn.HeaderText = "RoleDescription"
        Me.RoleDescriptionDataGridViewTextBoxColumn.Name = "RoleDescriptionDataGridViewTextBoxColumn"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 565)
        Me.Controls.Add(Me.gpbRegisteredUser)
        Me.Controls.Add(Me.gpbRegisterUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        Me.gpbRegisterUser.ResumeLayout(False)
        Me.gpbRegisterUser.PerformLayout()
        Me.gpbRegisteredUser.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CelestialPayRollDatabaseDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbRegisterUser As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtRegisterRoleDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRegisterRole As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRegisterPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRegisterUserName As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents gpbRegisteredUser As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents btnRegisterNow As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CelestialPayRollDatabaseDataSet4 As CelestialPayRollDatabaseDataSet4
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As CelestialPayRollDatabaseDataSet4TableAdapters.UsersTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
