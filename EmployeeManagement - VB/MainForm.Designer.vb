<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Panel1 = New Panel()
        lblHeadline = New Label()
        lblSalary = New Label()
        lblDetails = New Label()
        lblEmployee = New Label()
        pbSalary = New PictureBox()
        pbDetails = New PictureBox()
        pbEmployee = New PictureBox()
        pbHome = New PictureBox()
        lblHome = New Label()
        lblLogout = New Label()
        pbLogout = New PictureBox()
        Label7 = New Label()
        lblX = New Label()
        Panel1.SuspendLayout()
        CType(pbSalary, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDetails, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbEmployee, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbHome, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbLogout, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(lblHeadline)
        Panel1.Controls.Add(lblSalary)
        Panel1.Controls.Add(lblDetails)
        Panel1.Controls.Add(lblEmployee)
        Panel1.Controls.Add(pbSalary)
        Panel1.Controls.Add(pbDetails)
        Panel1.Controls.Add(pbEmployee)
        Panel1.ForeColor = SystemColors.ControlLightLight
        Panel1.Location = New Point(0, 100)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(980, 390)
        Panel1.TabIndex = 0
        ' 
        ' lblHeadline
        ' 
        lblHeadline.AutoSize = True
        lblHeadline.BackColor = Color.Transparent
        lblHeadline.Font = New Font("Source Sans Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeadline.ForeColor = Color.Turquoise
        lblHeadline.Location = New Point(303, 24)
        lblHeadline.Name = "lblHeadline"
        lblHeadline.Size = New Size(383, 34)
        lblHeadline.TabIndex = 11
        lblHeadline.Text = "Employee Management System"
        ' 
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.BackColor = Color.Transparent
        lblSalary.Font = New Font("Source Sans Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblSalary.ForeColor = Color.Turquoise
        lblSalary.Location = New Point(709, 262)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(88, 34)
        lblSalary.TabIndex = 10
        lblSalary.Text = "Salary"
        ' 
        ' lblDetails
        ' 
        lblDetails.AutoSize = True
        lblDetails.BackColor = Color.Transparent
        lblDetails.Font = New Font("Source Sans Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblDetails.ForeColor = Color.Turquoise
        lblDetails.Location = New Point(440, 262)
        lblDetails.Name = "lblDetails"
        lblDetails.Size = New Size(96, 34)
        lblDetails.TabIndex = 9
        lblDetails.Text = "Details"
        ' 
        ' lblEmployee
        ' 
        lblEmployee.AutoSize = True
        lblEmployee.BackColor = Color.Transparent
        lblEmployee.Font = New Font("Source Sans Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmployee.ForeColor = Color.Turquoise
        lblEmployee.Location = New Point(162, 262)
        lblEmployee.Name = "lblEmployee"
        lblEmployee.Size = New Size(131, 34)
        lblEmployee.TabIndex = 8
        lblEmployee.Text = "Employee"
        ' 
        ' pbSalary
        ' 
        pbSalary.BackColor = Color.Transparent
        pbSalary.Image = My.Resources.Resources.cash
        pbSalary.Location = New Point(687, 129)
        pbSalary.Name = "pbSalary"
        pbSalary.Size = New Size(131, 130)
        pbSalary.TabIndex = 7
        pbSalary.TabStop = False
        ' 
        ' pbDetails
        ' 
        pbDetails.BackColor = Color.Transparent
        pbDetails.Image = My.Resources.Resources.report
        pbDetails.Location = New Point(424, 129)
        pbDetails.Name = "pbDetails"
        pbDetails.Size = New Size(131, 130)
        pbDetails.TabIndex = 6
        pbDetails.TabStop = False
        ' 
        ' pbEmployee
        ' 
        pbEmployee.BackColor = Color.Transparent
        pbEmployee.Image = My.Resources.Resources.user__1_
        pbEmployee.Location = New Point(162, 129)
        pbEmployee.Name = "pbEmployee"
        pbEmployee.Size = New Size(131, 130)
        pbEmployee.TabIndex = 5
        pbEmployee.TabStop = False
        ' 
        ' pbHome
        ' 
        pbHome.BackColor = Color.Transparent
        pbHome.Image = My.Resources.Resources.home_button
        pbHome.Location = New Point(12, 32)
        pbHome.Name = "pbHome"
        pbHome.Size = New Size(63, 63)
        pbHome.TabIndex = 1
        pbHome.TabStop = False
        ' 
        ' lblHome
        ' 
        lblHome.AutoSize = True
        lblHome.BackColor = Color.Transparent
        lblHome.Font = New Font("Source Sans Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblHome.ForeColor = Color.White
        lblHome.Location = New Point(81, 55)
        lblHome.Name = "lblHome"
        lblHome.Size = New Size(85, 34)
        lblHome.TabIndex = 2
        lblHome.Text = "Home"
        ' 
        ' lblLogout
        ' 
        lblLogout.AutoSize = True
        lblLogout.BackColor = Color.Transparent
        lblLogout.Font = New Font("Source Sans Pro Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblLogout.ForeColor = Color.White
        lblLogout.Location = New Point(887, 66)
        lblLogout.Name = "lblLogout"
        lblLogout.Size = New Size(78, 27)
        lblLogout.TabIndex = 4
        lblLogout.Text = "Logout"
        ' 
        ' pbLogout
        ' 
        pbLogout.BackColor = Color.Transparent
        pbLogout.Image = My.Resources.Resources.shutdown
        pbLogout.Location = New Point(860, 68)
        pbLogout.Name = "pbLogout"
        pbLogout.Size = New Size(27, 27)
        pbLogout.TabIndex = 3
        pbLogout.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Source Sans Pro Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(845, 495)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 17)
        Label7.TabIndex = 5
        Label7.Text = "©  Milan Pumpalovic"
        ' 
        ' lblX
        ' 
        lblX.AutoSize = True
        lblX.BackColor = Color.Transparent
        lblX.Font = New Font("Source Sans Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblX.ForeColor = Color.White
        lblX.Location = New Point(941, 9)
        lblX.Name = "lblX"
        lblX.Size = New Size(28, 34)
        lblX.TabIndex = 11
        lblX.Text = "x"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.splash
        ClientSize = New Size(980, 520)
        Controls.Add(lblX)
        Controls.Add(Label7)
        Controls.Add(lblLogout)
        Controls.Add(pbLogout)
        Controls.Add(lblHome)
        Controls.Add(pbHome)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbSalary, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDetails, ComponentModel.ISupportInitialize).EndInit()
        CType(pbEmployee, ComponentModel.ISupportInitialize).EndInit()
        CType(pbHome, ComponentModel.ISupportInitialize).EndInit()
        CType(pbLogout, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbHome As PictureBox
    Friend WithEvents lblHome As Label
    Friend WithEvents pbEmployee As PictureBox
    Friend WithEvents lblLogout As Label
    Friend WithEvents pbLogout As PictureBox
    Friend WithEvents lblEmployee As Label
    Friend WithEvents pbSalary As PictureBox
    Friend WithEvents pbDetails As PictureBox
    Friend WithEvents lblHeadline As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblX As Label
End Class
