<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Details))
        Panel1 = New Panel()
        lblEmployeeId = New Label()
        lblDateOfBirthInput = New Label()
        lblEducationInput = New Label()
        lblPositionInput = New Label()
        lblGenderInput = New Label()
        lblPhoneInput = New Label()
        lblAddressInput = New Label()
        lblSecondNameInput = New Label()
        lblFirstNameInput = New Label()
        pbBack = New PictureBox()
        btnRefresh = New Bunifu.Framework.UI.BunifuThinButton2()
        btnPrint = New Bunifu.Framework.UI.BunifuThinButton2()
        lblDateOfBirth = New Label()
        lblEducation = New Label()
        lblPosition = New Label()
        lblGender = New Label()
        lblPhone = New Label()
        lblAddress = New Label()
        lblSecondName = New Label()
        txtEmployeeId = New TextBox()
        lblFirstName = New Label()
        lblDetails = New Label()
        pbDetails = New PictureBox()
        Label18 = New Label()
        lblX = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(pbBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(lblEmployeeId)
        Panel1.Controls.Add(lblDateOfBirthInput)
        Panel1.Controls.Add(lblEducationInput)
        Panel1.Controls.Add(lblPositionInput)
        Panel1.Controls.Add(lblGenderInput)
        Panel1.Controls.Add(lblPhoneInput)
        Panel1.Controls.Add(lblAddressInput)
        Panel1.Controls.Add(lblSecondNameInput)
        Panel1.Controls.Add(lblFirstNameInput)
        Panel1.Controls.Add(pbBack)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnPrint)
        Panel1.Controls.Add(lblDateOfBirth)
        Panel1.Controls.Add(lblEducation)
        Panel1.Controls.Add(lblPosition)
        Panel1.Controls.Add(lblGender)
        Panel1.Controls.Add(lblPhone)
        Panel1.Controls.Add(lblAddress)
        Panel1.Controls.Add(lblSecondName)
        Panel1.Controls.Add(txtEmployeeId)
        Panel1.Controls.Add(lblFirstName)
        Panel1.Location = New Point(0, 100)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(980, 390)
        Panel1.TabIndex = 1
        ' 
        ' lblEmployeeId
        ' 
        lblEmployeeId.AutoSize = True
        lblEmployeeId.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmployeeId.Location = New Point(274, 28)
        lblEmployeeId.Name = "lblEmployeeId"
        lblEmployeeId.Size = New Size(117, 25)
        lblEmployeeId.TabIndex = 27
        lblEmployeeId.Text = "Employee ID"
        ' 
        ' lblDateOfBirthInput
        ' 
        lblDateOfBirthInput.AutoSize = True
        lblDateOfBirthInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateOfBirthInput.ForeColor = Color.Red
        lblDateOfBirthInput.Location = New Point(696, 265)
        lblDateOfBirthInput.Name = "lblDateOfBirthInput"
        lblDateOfBirthInput.Size = New Size(97, 21)
        lblDateOfBirthInput.TabIndex = 26
        lblDateOfBirthInput.Text = "Date of Birth"
        lblDateOfBirthInput.Visible = False
        ' 
        ' lblEducationInput
        ' 
        lblEducationInput.AutoSize = True
        lblEducationInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblEducationInput.ForeColor = Color.Red
        lblEducationInput.Location = New Point(696, 89)
        lblEducationInput.Name = "lblEducationInput"
        lblEducationInput.Size = New Size(78, 21)
        lblEducationInput.TabIndex = 25
        lblEducationInput.Text = "Education"
        lblEducationInput.Visible = False
        ' 
        ' lblPositionInput
        ' 
        lblPositionInput.AutoSize = True
        lblPositionInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblPositionInput.ForeColor = Color.Red
        lblPositionInput.Location = New Point(696, 146)
        lblPositionInput.Name = "lblPositionInput"
        lblPositionInput.Size = New Size(65, 21)
        lblPositionInput.TabIndex = 24
        lblPositionInput.Text = "Position"
        lblPositionInput.Visible = False
        ' 
        ' lblGenderInput
        ' 
        lblGenderInput.AutoSize = True
        lblGenderInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblGenderInput.ForeColor = Color.Red
        lblGenderInput.Location = New Point(696, 206)
        lblGenderInput.Name = "lblGenderInput"
        lblGenderInput.Size = New Size(61, 21)
        lblGenderInput.TabIndex = 23
        lblGenderInput.Text = "Gender"
        lblGenderInput.Visible = False
        ' 
        ' lblPhoneInput
        ' 
        lblPhoneInput.AutoSize = True
        lblPhoneInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblPhoneInput.ForeColor = Color.Red
        lblPhoneInput.Location = New Point(303, 265)
        lblPhoneInput.Name = "lblPhoneInput"
        lblPhoneInput.Size = New Size(54, 21)
        lblPhoneInput.TabIndex = 22
        lblPhoneInput.Text = "Phone"
        lblPhoneInput.Visible = False
        ' 
        ' lblAddressInput
        ' 
        lblAddressInput.AutoSize = True
        lblAddressInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblAddressInput.ForeColor = Color.Red
        lblAddressInput.Location = New Point(303, 206)
        lblAddressInput.Name = "lblAddressInput"
        lblAddressInput.Size = New Size(66, 21)
        lblAddressInput.TabIndex = 21
        lblAddressInput.Text = "Address"
        lblAddressInput.Visible = False
        ' 
        ' lblSecondNameInput
        ' 
        lblSecondNameInput.AutoSize = True
        lblSecondNameInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblSecondNameInput.ForeColor = Color.Red
        lblSecondNameInput.Location = New Point(303, 146)
        lblSecondNameInput.Name = "lblSecondNameInput"
        lblSecondNameInput.Size = New Size(107, 21)
        lblSecondNameInput.TabIndex = 20
        lblSecondNameInput.Text = "Second Name"
        lblSecondNameInput.Visible = False
        ' 
        ' lblFirstNameInput
        ' 
        lblFirstNameInput.AutoSize = True
        lblFirstNameInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblFirstNameInput.ForeColor = Color.Red
        lblFirstNameInput.Location = New Point(303, 89)
        lblFirstNameInput.Name = "lblFirstNameInput"
        lblFirstNameInput.Size = New Size(86, 21)
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
        ' btnRefresh
        ' 
        btnRefresh.ActiveBorderThickness = 1
        btnRefresh.ActiveCornerRadius = 20
        btnRefresh.ActiveFillColor = Color.White
        btnRefresh.ActiveForecolor = Color.FromArgb(CByte(14), CByte(58), CByte(107))
        btnRefresh.ActiveLineColor = Color.White
        btnRefresh.BackColor = Color.White
        btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), Image)
        btnRefresh.ButtonText = "Search"
        btnRefresh.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefresh.ForeColor = Color.SeaGreen
        btnRefresh.IdleBorderThickness = 1
        btnRefresh.IdleCornerRadius = 20
        btnRefresh.IdleFillColor = Color.FromArgb(CByte(14), CByte(58), CByte(107))
        btnRefresh.IdleForecolor = Color.White
        btnRefresh.IdleLineColor = Color.White
        btnRefresh.Location = New Point(607, 21)
        btnRefresh.Margin = New Padding(5)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(100, 40)
        btnRefresh.TabIndex = 18
        btnRefresh.TextAlign = ContentAlignment.MiddleCenter
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
        btnPrint.Location = New Point(441, 330)
        btnPrint.Margin = New Padding(5)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(100, 40)
        btnPrint.TabIndex = 17
        btnPrint.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDateOfBirth
        ' 
        lblDateOfBirth.AutoSize = True
        lblDateOfBirth.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateOfBirth.Location = New Point(566, 265)
        lblDateOfBirth.Name = "lblDateOfBirth"
        lblDateOfBirth.Size = New Size(97, 21)
        lblDateOfBirth.TabIndex = 14
        lblDateOfBirth.Text = "Date of Birth"
        ' 
        ' lblEducation
        ' 
        lblEducation.AutoSize = True
        lblEducation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblEducation.Location = New Point(566, 89)
        lblEducation.Name = "lblEducation"
        lblEducation.Size = New Size(78, 21)
        lblEducation.TabIndex = 12
        lblEducation.Text = "Education"
        ' 
        ' lblPosition
        ' 
        lblPosition.AutoSize = True
        lblPosition.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblPosition.Location = New Point(566, 146)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(65, 21)
        lblPosition.TabIndex = 10
        lblPosition.Text = "Position"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblGender.Location = New Point(566, 206)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(61, 21)
        lblGender.TabIndex = 8
        lblGender.Text = "Gender"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblPhone.Location = New Point(146, 265)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(54, 21)
        lblPhone.TabIndex = 6
        lblPhone.Text = "Phone"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblAddress.Location = New Point(146, 206)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(66, 21)
        lblAddress.TabIndex = 4
        lblAddress.Text = "Address"
        ' 
        ' lblSecondName
        ' 
        lblSecondName.AutoSize = True
        lblSecondName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblSecondName.Location = New Point(146, 146)
        lblSecondName.Name = "lblSecondName"
        lblSecondName.Size = New Size(107, 21)
        lblSecondName.TabIndex = 2
        lblSecondName.Text = "Second Name"
        ' 
        ' txtEmployeeId
        ' 
        txtEmployeeId.Location = New Point(402, 30)
        txtEmployeeId.Name = "txtEmployeeId"
        txtEmployeeId.Size = New Size(179, 23)
        txtEmployeeId.TabIndex = 1
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblFirstName.Location = New Point(146, 89)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(86, 21)
        lblFirstName.TabIndex = 0
        lblFirstName.Text = "First Name"
        ' 
        ' lblDetails
        ' 
        lblDetails.AutoSize = True
        lblDetails.BackColor = Color.Transparent
        lblDetails.Font = New Font("Source Sans Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblDetails.ForeColor = Color.White
        lblDetails.Location = New Point(81, 35)
        lblDetails.Name = "lblDetails"
        lblDetails.Size = New Size(96, 34)
        lblDetails.TabIndex = 10
        lblDetails.Text = "Details"
        ' 
        ' pbDetails
        ' 
        pbDetails.BackColor = Color.Transparent
        pbDetails.Image = My.Resources.Resources.applicant
        pbDetails.Location = New Point(12, 12)
        pbDetails.Name = "pbDetails"
        pbDetails.Size = New Size(63, 63)
        pbDetails.SizeMode = PictureBoxSizeMode.StretchImage
        pbDetails.TabIndex = 9
        pbDetails.TabStop = False
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
        Label18.TabIndex = 27
        Label18.Text = "©  Milan Pumpalovic"
        ' 
        ' lblX
        ' 
        lblX.AutoSize = True
        lblX.BackColor = Color.Transparent
        lblX.Font = New Font("Source Sans Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblX.ForeColor = Color.White
        lblX.Location = New Point(941, 12)
        lblX.Name = "lblX"
        lblX.Size = New Size(28, 34)
        lblX.TabIndex = 28
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
        ' Details
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.splash
        ClientSize = New Size(980, 520)
        Controls.Add(lblX)
        Controls.Add(Label18)
        Controls.Add(lblDetails)
        Controls.Add(pbDetails)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Details"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Details"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbBack, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents btnRefresh As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnPrint As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblEducation As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSecondName As Label
    Friend WithEvents txtEmployeeId As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblDateOfBirthInput As Label
    Friend WithEvents lblEducationInput As Label
    Friend WithEvents lblPositionInput As Label
    Friend WithEvents lblGenderInput As Label
    Friend WithEvents lblPhoneInput As Label
    Friend WithEvents lblAddressInput As Label
    Friend WithEvents lblSecondNameInput As Label
    Friend WithEvents lblFirstNameInput As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents pbDetails As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lblEmployeeId As Label
    Friend WithEvents lblX As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
