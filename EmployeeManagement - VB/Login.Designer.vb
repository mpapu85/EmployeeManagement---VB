<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        txtUserId = New TextBox()
        txtPassword = New TextBox()
        lblClose = New Label()
        lblUserId = New Label()
        lblPassword = New Label()
        btnLogin = New Button()
        lblHeadLine = New Label()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' txtUserId
        ' 
        txtUserId.BackColor = Color.White
        txtUserId.BorderStyle = BorderStyle.None
        txtUserId.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUserId.ForeColor = Color.Black
        txtUserId.Location = New Point(239, 91)
        txtUserId.Name = "txtUserId"
        txtUserId.Size = New Size(203, 18)
        txtUserId.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(239, 147)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(203, 18)
        txtPassword.TabIndex = 3
        ' 
        ' lblClose
        ' 
        lblClose.AutoSize = True
        lblClose.BackColor = Color.Transparent
        lblClose.Font = New Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblClose.ForeColor = Color.White
        lblClose.Location = New Point(469, 9)
        lblClose.Name = "lblClose"
        lblClose.Size = New Size(19, 23)
        lblClose.TabIndex = 4
        lblClose.Text = "x"
        ' 
        ' lblUserId
        ' 
        lblUserId.AutoSize = True
        lblUserId.BackColor = Color.Transparent
        lblUserId.Font = New Font("Source Sans Pro Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblUserId.ForeColor = Color.White
        lblUserId.Location = New Point(239, 67)
        lblUserId.Name = "lblUserId"
        lblUserId.Size = New Size(49, 17)
        lblUserId.TabIndex = 5
        lblUserId.Text = "User Id"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Source Sans Pro Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(239, 125)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(64, 17)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Transparent
        btnLogin.FlatAppearance.BorderColor = Color.White
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.ForeColor = Color.White
        btnLogin.Image = My.Resources.Resources.log_in__1_
        btnLogin.Location = New Point(239, 190)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(82, 31)
        btnLogin.TabIndex = 7
        btnLogin.Text = "   Login"
        btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblHeadLine
        ' 
        lblHeadLine.AutoSize = True
        lblHeadLine.BackColor = Color.Transparent
        lblHeadLine.Font = New Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeadLine.ForeColor = Color.White
        lblHeadLine.Location = New Point(110, 33)
        lblHeadLine.Name = "lblHeadLine"
        lblHeadLine.Size = New Size(268, 24)
        lblHeadLine.TabIndex = 8
        lblHeadLine.Text = "Employee Management System"
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Transparent
        btnReset.FlatAppearance.BorderColor = Color.White
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.ForeColor = Color.White
        btnReset.Image = My.Resources.Resources.restart
        btnReset.Location = New Point(360, 190)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(82, 31)
        btnReset.TabIndex = 9
        btnReset.Text = "   Reset"
        btnReset.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.login_background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(500, 250)
        Controls.Add(btnReset)
        Controls.Add(lblHeadLine)
        Controls.Add(btnLogin)
        Controls.Add(lblPassword)
        Controls.Add(lblUserId)
        Controls.Add(lblClose)
        Controls.Add(txtPassword)
        Controls.Add(txtUserId)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblClose As Label
    Friend WithEvents lblUserId As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblHeadLine As Label
    Friend WithEvents btnReset As Button
End Class
