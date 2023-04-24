<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Salary))
        Label18 = New Label()
        txtSalary = New Label()
        pbSalary = New PictureBox()
        Panel1 = New Panel()
        btnPrint = New Bunifu.Framework.UI.BunifuThinButton2()
        txtWorkDays = New TextBox()
        lblWorkDays = New Label()
        rtbSalary = New RichTextBox()
        lblEmployeeId = New Label()
        lblPositionInput = New Label()
        lblSecondNameInput = New Label()
        lblFirstNameInput = New Label()
        pbBack = New PictureBox()
        btnFatchData = New Bunifu.Framework.UI.BunifuThinButton2()
        btnView = New Bunifu.Framework.UI.BunifuThinButton2()
        lblPosition = New Label()
        lblSecondName = New Label()
        txtEmployeeId = New TextBox()
        lblFirstName = New Label()
        lblX = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(pbSalary, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(pbBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Source Sans Pro Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.ForeColor = Color.White
        Label18.Location = New Point(845, 495)
        Label18.Name = "Label18"
        Label18.Size = New Size(124, 17)
        Label18.TabIndex = 31
        Label18.Text = "©  Milan Pumpalovic"
        ' 
        ' txtSalary
        ' 
        txtSalary.AutoSize = True
        txtSalary.BackColor = Color.Transparent
        txtSalary.Font = New Font("Source Sans Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtSalary.ForeColor = Color.White
        txtSalary.Location = New Point(81, 35)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(88, 34)
        txtSalary.TabIndex = 30
        txtSalary.Text = "Salary"
        ' 
        ' pbSalary
        ' 
        pbSalary.BackColor = Color.Transparent
        pbSalary.Image = My.Resources.Resources.salary__1_
        pbSalary.Location = New Point(12, 12)
        pbSalary.Name = "pbSalary"
        pbSalary.Size = New Size(63, 63)
        pbSalary.SizeMode = PictureBoxSizeMode.StretchImage
        pbSalary.TabIndex = 29
        pbSalary.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnPrint)
        Panel1.Controls.Add(txtWorkDays)
        Panel1.Controls.Add(lblWorkDays)
        Panel1.Controls.Add(rtbSalary)
        Panel1.Controls.Add(lblEmployeeId)
        Panel1.Controls.Add(lblPositionInput)
        Panel1.Controls.Add(lblSecondNameInput)
        Panel1.Controls.Add(lblFirstNameInput)
        Panel1.Controls.Add(pbBack)
        Panel1.Controls.Add(btnFatchData)
        Panel1.Controls.Add(btnView)
        Panel1.Controls.Add(lblPosition)
        Panel1.Controls.Add(lblSecondName)
        Panel1.Controls.Add(txtEmployeeId)
        Panel1.Controls.Add(lblFirstName)
        Panel1.Location = New Point(0, 100)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(980, 390)
        Panel1.TabIndex = 28
        ' 
        ' btnPrint
        ' 
        btnPrint.ActiveBorderThickness = 1
        btnPrint.ActiveCornerRadius = 20
        btnPrint.ActiveFillColor = Color.White
        btnPrint.ActiveForecolor = Color.FromArgb(CByte(14), CByte(58), CByte(107))
        btnPrint.ActiveLineColor = Color.White
        btnPrint.BackColor = Color.White
        btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), Image)
        btnPrint.ButtonText = "Print"
        btnPrint.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPrint.ForeColor = Color.SeaGreen
        btnPrint.IdleBorderThickness = 1
        btnPrint.IdleCornerRadius = 20
        btnPrint.IdleFillColor = Color.FromArgb(CByte(14), CByte(58), CByte(107))
        btnPrint.IdleForecolor = Color.White
        btnPrint.IdleLineColor = Color.White
        btnPrint.Location = New Point(646, 346)
        btnPrint.Margin = New Padding(5)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(100, 40)
        btnPrint.TabIndex = 31
        btnPrint.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtWorkDays
        ' 
        txtWorkDays.Location = New Point(161, 284)
        txtWorkDays.Name = "txtWorkDays"
        txtWorkDays.Size = New Size(129, 23)
        txtWorkDays.TabIndex = 30
        ' 
        ' lblWorkDays
        ' 
        lblWorkDays.AutoSize = True
        lblWorkDays.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblWorkDays.Location = New Point(161, 256)
        lblWorkDays.Name = "lblWorkDays"
        lblWorkDays.Size = New Size(101, 25)
        lblWorkDays.TabIndex = 29
        lblWorkDays.Text = "Work Days"
        ' 
        ' rtbSalary
        ' 
        rtbSalary.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        rtbSalary.Location = New Point(435, 13)
        rtbSalary.Name = "rtbSalary"
        rtbSalary.Size = New Size(519, 334)
        rtbSalary.TabIndex = 28
        rtbSalary.Text = ""
        ' 
        ' lblEmployeeId
        ' 
        lblEmployeeId.AutoSize = True
        lblEmployeeId.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmployeeId.Location = New Point(25, 76)
        lblEmployeeId.Name = "lblEmployeeId"
        lblEmployeeId.Size = New Size(117, 25)
        lblEmployeeId.TabIndex = 27
        lblEmployeeId.Text = "Employee ID"
        ' 
        ' lblPositionInput
        ' 
        lblPositionInput.AutoSize = True
        lblPositionInput.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblPositionInput.ForeColor = Color.Red
        lblPositionInput.Location = New Point(25, 286)
        lblPositionInput.Name = "lblPositionInput"
        lblPositionInput.Size = New Size(79, 25)
        lblPositionInput.TabIndex = 24
        lblPositionInput.Text = "Position"
        lblPositionInput.Visible = False
        ' 
        ' lblSecondNameInput
        ' 
        lblSecondNameInput.AutoSize = True
        lblSecondNameInput.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSecondNameInput.ForeColor = Color.Red
        lblSecondNameInput.Location = New Point(161, 205)
        lblSecondNameInput.Name = "lblSecondNameInput"
        lblSecondNameInput.Size = New Size(129, 25)
        lblSecondNameInput.TabIndex = 20
        lblSecondNameInput.Text = "Second Name"
        lblSecondNameInput.Visible = False
        ' 
        ' lblFirstNameInput
        ' 
        lblFirstNameInput.AutoSize = True
        lblFirstNameInput.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblFirstNameInput.ForeColor = Color.Red
        lblFirstNameInput.Location = New Point(25, 205)
        lblFirstNameInput.Name = "lblFirstNameInput"
        lblFirstNameInput.Size = New Size(102, 25)
        lblFirstNameInput.TabIndex = 19
        lblFirstNameInput.Text = "First Name"
        lblFirstNameInput.Visible = False
        ' 
        ' pbBack
        ' 
        pbBack.BackColor = Color.Transparent
        pbBack.Image = My.Resources.Resources.previous
        pbBack.Location = New Point(12, 13)
        pbBack.Name = "pbBack"
        pbBack.Size = New Size(41, 40)
        pbBack.SizeMode = PictureBoxSizeMode.StretchImage
        pbBack.TabIndex = 10
        pbBack.TabStop = False
        ' 
        ' btnFatchData
        ' 
        btnFatchData.ActiveBorderThickness = 1
        btnFatchData.ActiveCornerRadius = 20
        btnFatchData.ActiveFillColor = Color.White
        btnFatchData.ActiveForecolor = Color.FromArgb(CByte(14), CByte(58), CByte(107))
        btnFatchData.ActiveLineColor = Color.White
        btnFatchData.BackColor = Color.White
        btnFatchData.BackgroundImage = CType(resources.GetObject("btnFatchData.BackgroundImage"), Image)
        btnFatchData.ButtonText = "Fatch Data"
        btnFatchData.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnFatchData.ForeColor = Color.SeaGreen
        btnFatchData.IdleBorderThickness = 1
        btnFatchData.IdleCornerRadius = 20
        btnFatchData.IdleFillColor = Color.FromArgb(CByte(14), CByte(58), CByte(107))
        btnFatchData.IdleForecolor = Color.White
        btnFatchData.IdleLineColor = Color.White
        btnFatchData.Location = New Point(162, 96)
        btnFatchData.Margin = New Padding(5)
        btnFatchData.Name = "btnFatchData"
        btnFatchData.Size = New Size(129, 40)
        btnFatchData.TabIndex = 18
        btnFatchData.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnView
        ' 
        btnView.ActiveBorderThickness = 1
        btnView.ActiveCornerRadius = 20
        btnView.ActiveFillColor = Color.White
        btnView.ActiveForecolor = Color.FromArgb(CByte(14), CByte(58), CByte(107))
        btnView.ActiveLineColor = Color.White
        btnView.BackColor = Color.White
        btnView.BackgroundImage = CType(resources.GetObject("btnView.BackgroundImage"), Image)
        btnView.ButtonText = "View"
        btnView.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnView.ForeColor = Color.SeaGreen
        btnView.IdleBorderThickness = 1
        btnView.IdleCornerRadius = 20
        btnView.IdleFillColor = Color.FromArgb(CByte(14), CByte(58), CByte(107))
        btnView.IdleForecolor = Color.White
        btnView.IdleLineColor = Color.White
        btnView.Location = New Point(121, 346)
        btnView.Margin = New Padding(5)
        btnView.Name = "btnView"
        btnView.Size = New Size(100, 40)
        btnView.TabIndex = 17
        btnView.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPosition
        ' 
        lblPosition.AutoSize = True
        lblPosition.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblPosition.Location = New Point(25, 256)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(79, 25)
        lblPosition.TabIndex = 10
        lblPosition.Text = "Position"
        ' 
        ' lblSecondName
        ' 
        lblSecondName.AutoSize = True
        lblSecondName.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSecondName.Location = New Point(161, 170)
        lblSecondName.Name = "lblSecondName"
        lblSecondName.Size = New Size(129, 25)
        lblSecondName.TabIndex = 2
        lblSecondName.Text = "Second Name"
        ' 
        ' txtEmployeeId
        ' 
        txtEmployeeId.Location = New Point(26, 107)
        txtEmployeeId.Name = "txtEmployeeId"
        txtEmployeeId.Size = New Size(128, 23)
        txtEmployeeId.TabIndex = 1
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblFirstName.Location = New Point(24, 170)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(102, 25)
        lblFirstName.TabIndex = 0
        lblFirstName.Text = "First Name"
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
        lblX.TabIndex = 32
        lblX.Text = "x"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Salary
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.splash
        ClientSize = New Size(980, 520)
        Controls.Add(lblX)
        Controls.Add(Label18)
        Controls.Add(txtSalary)
        Controls.Add(pbSalary)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Salary"
        Text = "Salary"
        CType(pbSalary, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label18 As Label
    Friend WithEvents txtSalary As Label
    Friend WithEvents pbSalary As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEmployeeId As Label
    Friend WithEvents lblPositionInput As Label
    Friend WithEvents lblSecondNameInput As Label
    Friend WithEvents lblFirstNameInput As Label
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents btnFatchData As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnView As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblSecondName As Label
    Friend WithEvents txtEmployeeId As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblWorkDays As Label
    Friend WithEvents rtbSalary As RichTextBox
    Friend WithEvents btnPrint As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtWorkDays As TextBox
    Friend WithEvents lblX As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
