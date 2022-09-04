<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayrollMdi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayrollMdi))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayRollCalculationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegisterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageEmploymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayRollCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentMonthPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutPayRollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManageEmploymentToolStripMenuItem, Me.PayRollCalculatorToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.ReportingToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.WindowsToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(711, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageEmployeeToolStripMenuItem, Me.PayRollCalculationToolStripMenuItem, Me.ToolStripMenuItem1, Me.RegisterToolStripMenuItem1, Me.CloseAllToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ManageEmployeeToolStripMenuItem
        '
        Me.ManageEmployeeToolStripMenuItem.Name = "ManageEmployeeToolStripMenuItem"
        Me.ManageEmployeeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ManageEmployeeToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ManageEmployeeToolStripMenuItem.Text = "&Manage Employee"
        '
        'PayRollCalculationToolStripMenuItem
        '
        Me.PayRollCalculationToolStripMenuItem.Name = "PayRollCalculationToolStripMenuItem"
        Me.PayRollCalculationToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PayRollCalculationToolStripMenuItem.Text = "&PayRoll Calculation"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(210, 6)
        '
        'RegisterToolStripMenuItem1
        '
        Me.RegisterToolStripMenuItem1.Name = "RegisterToolStripMenuItem1"
        Me.RegisterToolStripMenuItem1.Size = New System.Drawing.Size(213, 22)
        Me.RegisterToolStripMenuItem1.Text = "Register"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CloseAllToolStripMenuItem.Text = "&Close All"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ManageEmploymentToolStripMenuItem
        '
        Me.ManageEmploymentToolStripMenuItem.Name = "ManageEmploymentToolStripMenuItem"
        Me.ManageEmploymentToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.ManageEmploymentToolStripMenuItem.Text = "&Manage Employment"
        '
        'PayRollCalculatorToolStripMenuItem
        '
        Me.PayRollCalculatorToolStripMenuItem.Name = "PayRollCalculatorToolStripMenuItem"
        Me.PayRollCalculatorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PayRollCalculatorToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.PayRollCalculatorToolStripMenuItem.Text = "&PayRoll Calculator"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LayoutToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.WindowsToolStripMenuItem.Text = "&Windows"
        '
        'LayoutToolStripMenuItem
        '
        Me.LayoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TileHorizontalToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.ArrangeIconToolStripMenuItem})
        Me.LayoutToolStripMenuItem.Name = "LayoutToolStripMenuItem"
        Me.LayoutToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.LayoutToolStripMenuItem.Text = "Layout"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile Horizontal"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile Vertical"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CascadeToolStripMenuItem.Text = "Cascade"
        '
        'ArrangeIconToolStripMenuItem
        '
        Me.ArrangeIconToolStripMenuItem.Name = "ArrangeIconToolStripMenuItem"
        Me.ArrangeIconToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ArrangeIconToolStripMenuItem.Text = "Arrange Icon"
        '
        'ReportingToolStripMenuItem
        '
        Me.ReportingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllEmployeeToolStripMenuItem, Me.AllPaymentToolStripMenuItem, Me.CurrentMonthPaymentToolStripMenuItem})
        Me.ReportingToolStripMenuItem.Name = "ReportingToolStripMenuItem"
        Me.ReportingToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ReportingToolStripMenuItem.Text = "&Reporting"
        '
        'AllEmployeeToolStripMenuItem
        '
        Me.AllEmployeeToolStripMenuItem.Name = "AllEmployeeToolStripMenuItem"
        Me.AllEmployeeToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AllEmployeeToolStripMenuItem.Text = "All Employee"
        '
        'AllPaymentToolStripMenuItem
        '
        Me.AllPaymentToolStripMenuItem.Name = "AllPaymentToolStripMenuItem"
        Me.AllPaymentToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AllPaymentToolStripMenuItem.Text = "All Payment"
        '
        'CurrentMonthPaymentToolStripMenuItem
        '
        Me.CurrentMonthPaymentToolStripMenuItem.Name = "CurrentMonthPaymentToolStripMenuItem"
        Me.CurrentMonthPaymentToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CurrentMonthPaymentToolStripMenuItem.Text = "Current Month Payment"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutPayRollToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutPayRollToolStripMenuItem
        '
        Me.AboutPayRollToolStripMenuItem.Name = "AboutPayRollToolStripMenuItem"
        Me.AboutPayRollToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AboutPayRollToolStripMenuItem.Text = "About PayRoll Application"
        '
        'PayrollMdi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PayrollMdi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payrol lMDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayRollCalculationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageEmploymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayRollCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutPayRollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AllEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentMonthPaymentToolStripMenuItem As ToolStripMenuItem
End Class
