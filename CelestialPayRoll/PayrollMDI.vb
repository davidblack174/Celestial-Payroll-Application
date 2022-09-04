Public Class PayrollMdi

    Private Sub ManageEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageEmployeeToolStripMenuItem.Click
        Dim objEmployeeForm = New FormEmployeeForm()
        objEmployeeForm.MdiParent = Me
        objEmployeeForm.Show()
    End Sub

    Private Sub PayRollCalculationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayRollCalculationToolStripMenuItem.Click
        Dim objPayrollForm = New PayRollCalculatorForm
        objPayrollForm.MdiParent = Me
        objPayrollForm.Show()
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click

        For Each childrenForm As Form In MdiChildren
            childrenForm.Close()
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
        Dim objLogInForm = New Login
        objLogInForm.ShowDialog()
    End Sub

    Dim _objEmployeeForm As FormEmployeeForm = Nothing

    Private Sub ManageEmploymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageEmploymentToolStripMenuItem.Click

        If IsNothing(_objEmployeeForm) Then
            _objEmployeeForm = New FormEmployeeForm()
            _objEmployeeForm.MdiParent = Me
            _objEmployeeForm.Visible = True
        Else
            _objEmployeeForm.Activate()
        End If
    End Sub

    Private Sub PayRollCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayRollCalculatorToolStripMenuItem.Click
        PayRollCalculationToolStripMenuItem.PerformClick()
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub ArrangeIconToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrangeIconToolStripMenuItem.Click
        LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub AboutPayRollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutPayRollToolStripMenuItem.Click
        Dim objAbout = New AbouCelestialPayRollApp()
        objAbout.MdiParent = Me
        objAbout.Show()

    End Sub

    Private Sub RegisterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem1.Click
        Dim objRegisterUser As New RegisterForm
        objRegisterUser.MdiParent = Me
        objRegisterUser.Show()

    End Sub

    Private Sub AllEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllEmployeeToolStripMenuItem.Click
        Dim objAllEmployee = New AllEmployee
        objAllEmployee.MdiParent = Me
        objAllEmployee.Visible = True

    End Sub

    Private Sub AllPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllPaymentToolStripMenuItem.Click
        Dim objAllPayment = New AllPaymentForm
        objAllPayment.MdiParent = Me
        objAllPayment.Visible = True

    End Sub

    Private Sub CurrentMonthPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentMonthPaymentToolStripMenuItem.Click
        Dim objCurrentMonthPayment = New CurrentMonthPayment
        objCurrentMonthPayment.MdiParent = Me
        objCurrentMonthPayment.Visible = True

    End Sub

    Private Sub PayrollMdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Disable Warning LocalizableElement
        If Login.cmbRoles.Text = "Admin" Or Login.cmbRoles.Text = "Developer" Then
#Enable Warning LocalizableElement
            RegisterToolStripMenuItem1.Visible = True
        Else
            RegisterToolStripMenuItem1.Visible = False
        End If

    End Sub


End Class