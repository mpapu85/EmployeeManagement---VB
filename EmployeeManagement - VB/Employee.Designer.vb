<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Employee))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        pbBack = New PictureBox()
        btnDelete = New Bunifu.Framework.UI.BunifuThinButton2()
        btnEdit = New Bunifu.Framework.UI.BunifuThinButton2()
        btnAdd = New Bunifu.Framework.UI.BunifuThinButton2()
        dtpDateOfBirth = New DateTimePicker()
        txtDateOfBirth = New Label()
        cbEducation = New ComboBox()
        lblEducation = New Label()
        cbPosition = New ComboBox()
        lblPosition = New Label()
        cbGender = New ComboBox()
        lblGender = New Label()
        txtPhone = New TextBox()
        lblPhone = New Label()
        txtAddress = New TextBox()
        lblAddress = New Label()
        txtSecondName = New TextBox()
        lblSecondName = New Label()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        Label7 = New Label()
        lblEmployee = New Label()
        pbEmployee = New PictureBox()
        dgvTableView = New Guna.UI2.WinForms.Guna2DataGridView()
        lblX = New Label()
        Panel1.SuspendLayout()
        CType(pbBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbEmployee, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(pbBack)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(dtpDateOfBirth)
        Panel1.Controls.Add(txtDateOfBirth)
        Panel1.Controls.Add(cbEducation)
        Panel1.Controls.Add(lblEducation)
        Panel1.Controls.Add(cbPosition)
        Panel1.Controls.Add(lblPosition)
        Panel1.Controls.Add(cbGender)
        Panel1.Controls.Add(lblGender)
        Panel1.Controls.Add(txtPhone)
        Panel1.Controls.Add(lblPhone)
        Panel1.Controls.Add(txtAddress)
        Panel1.Controls.Add(lblAddress)
        Panel1.Controls.Add(txtSecondName)
        Panel1.Controls.Add(lblSecondName)
        Panel1.Controls.Add(txtFirstName)
        Panel1.Controls.Add(lblFirstName)
        Panel1.Location = New Point(12, 100)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(410, 390)
        Panel1.TabIndex = 0
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
        ' btnDelete
        ' 
        btnDelete.ActiveBorderThickness = 1
        btnDelete.ActiveCornerRadius = 20
        btnDelete.ActiveFillColor = Color.White
        btnDelete.ActiveForecolor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnDelete.ActiveLineColor = Color.White
        btnDelete.BackColor = Color.White
        btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), Image)
        btnDelete.ButtonText = "Delete"
        btnDelete.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.IdleBorderThickness = 1
        btnDelete.IdleCornerRadius = 20
        btnDelete.IdleFillColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnDelete.IdleForecolor = Color.White
        btnDelete.IdleLineColor = Color.White
        btnDelete.Location = New Point(294, 337)
        btnDelete.Margin = New Padding(5)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 40)
        btnDelete.TabIndex = 18
        btnDelete.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnEdit
        ' 
        btnEdit.ActiveBorderThickness = 1
        btnEdit.ActiveCornerRadius = 20
        btnEdit.ActiveFillColor = Color.White
        btnEdit.ActiveForecolor = Color.SeaGreen
        btnEdit.ActiveLineColor = Color.White
        btnEdit.BackColor = Color.White
        btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), Image)
        btnEdit.ButtonText = "Edit"
        btnEdit.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.ForeColor = Color.White
        btnEdit.IdleBorderThickness = 1
        btnEdit.IdleCornerRadius = 20
        btnEdit.IdleFillColor = Color.SeaGreen
        btnEdit.IdleForecolor = Color.White
        btnEdit.IdleLineColor = Color.White
        btnEdit.Location = New Point(154, 337)
        btnEdit.Margin = New Padding(5)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(100, 40)
        btnEdit.TabIndex = 17
        btnEdit.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnAdd
        ' 
        btnAdd.ActiveBorderThickness = 1
        btnAdd.ActiveCornerRadius = 20
        btnAdd.ActiveFillColor = Color.White
        btnAdd.ActiveForecolor = Color.FromArgb(CByte(14), CByte(58), CByte(107))
        btnAdd.ActiveLineColor = Color.White
        btnAdd.BackColor = Color.White
        btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), Image)
        btnAdd.ButtonText = "Add"
        btnAdd.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.White
        btnAdd.IdleBorderThickness = 1
        btnAdd.IdleCornerRadius = 20
        btnAdd.IdleFillColor = Color.FromArgb(CByte(14), CByte(58), CByte(107))
        btnAdd.IdleForecolor = Color.White
        btnAdd.IdleLineColor = Color.White
        btnAdd.Location = New Point(12, 337)
        btnAdd.Margin = New Padding(5)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(100, 40)
        btnAdd.TabIndex = 16
        btnAdd.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtpDateOfBirth
        ' 
        dtpDateOfBirth.CustomFormat = "dd.mm.yyyy"
        dtpDateOfBirth.Format = DateTimePickerFormat.Short
        dtpDateOfBirth.Location = New Point(215, 275)
        dtpDateOfBirth.Name = "dtpDateOfBirth"
        dtpDateOfBirth.Size = New Size(179, 23)
        dtpDateOfBirth.TabIndex = 15
        ' 
        ' txtDateOfBirth
        ' 
        txtDateOfBirth.AutoSize = True
        txtDateOfBirth.Location = New Point(215, 257)
        txtDateOfBirth.Name = "txtDateOfBirth"
        txtDateOfBirth.Size = New Size(73, 15)
        txtDateOfBirth.TabIndex = 14
        txtDateOfBirth.Text = "Date of Birth"
        ' 
        ' cbEducation
        ' 
        cbEducation.FormattingEnabled = True
        cbEducation.Items.AddRange(New Object() {"Primary education", "Lower secondary education", "Upper secondary education", "Post secondary non tertiary education", "Short cycle tertiary education", "Bachelor or equivalent level", "Master or equivalent level", "Doctoral or equivalent level"})
        cbEducation.Location = New Point(12, 151)
        cbEducation.Name = "cbEducation"
        cbEducation.Size = New Size(179, 23)
        cbEducation.TabIndex = 5
        ' 
        ' lblEducation
        ' 
        lblEducation.AutoSize = True
        lblEducation.Location = New Point(12, 133)
        lblEducation.Name = "lblEducation"
        lblEducation.Size = New Size(60, 15)
        lblEducation.TabIndex = 4
        lblEducation.Text = "Education"
        ' 
        ' cbPosition
        ' 
        cbPosition.FormattingEnabled = True
        cbPosition.Items.AddRange(New Object() {"Manager", "Security", "Cleaner", "Accountant", "IT"})
        cbPosition.Location = New Point(215, 151)
        cbPosition.Name = "cbPosition"
        cbPosition.Size = New Size(179, 23)
        cbPosition.TabIndex = 7
        ' 
        ' lblPosition
        ' 
        lblPosition.AutoSize = True
        lblPosition.Location = New Point(215, 133)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(50, 15)
        lblPosition.TabIndex = 6
        lblPosition.Text = "Position"
        ' 
        ' cbGender
        ' 
        cbGender.FormattingEnabled = True
        cbGender.Items.AddRange(New Object() {"Male", "Female"})
        cbGender.Location = New Point(307, 211)
        cbGender.Name = "cbGender"
        cbGender.Size = New Size(87, 23)
        cbGender.TabIndex = 11
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(307, 193)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(45, 15)
        lblGender.TabIndex = 10
        lblGender.Text = "Gender"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(12, 275)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(179, 23)
        txtPhone.TabIndex = 13
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(12, 257)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(41, 15)
        lblPhone.TabIndex = 12
        lblPhone.Text = "Phone"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(12, 211)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(270, 23)
        txtAddress.TabIndex = 9
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(12, 193)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(49, 15)
        lblAddress.TabIndex = 8
        lblAddress.Text = "Address"
        ' 
        ' txtSecondName
        ' 
        txtSecondName.Location = New Point(215, 89)
        txtSecondName.Name = "txtSecondName"
        txtSecondName.Size = New Size(179, 23)
        txtSecondName.TabIndex = 3
        ' 
        ' lblSecondName
        ' 
        lblSecondName.AutoSize = True
        lblSecondName.Location = New Point(215, 71)
        lblSecondName.Name = "lblSecondName"
        lblSecondName.Size = New Size(81, 15)
        lblSecondName.TabIndex = 2
        lblSecondName.Text = "Second Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(12, 89)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(179, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(12, 71)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(64, 15)
        lblFirstName.TabIndex = 0
        lblFirstName.Text = "First Name"
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
        Label7.TabIndex = 6
        Label7.Text = "©  Milan Pumpalovic"
        ' 
        ' lblEmployee
        ' 
        lblEmployee.AutoSize = True
        lblEmployee.BackColor = Color.Transparent
        lblEmployee.Font = New Font("Source Sans Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmployee.ForeColor = Color.White
        lblEmployee.Location = New Point(81, 35)
        lblEmployee.Name = "lblEmployee"
        lblEmployee.Size = New Size(131, 34)
        lblEmployee.TabIndex = 8
        lblEmployee.Text = "Employee"
        ' 
        ' pbEmployee
        ' 
        pbEmployee.BackColor = Color.Transparent
        pbEmployee.Image = My.Resources.Resources.user1
        pbEmployee.Location = New Point(12, 12)
        pbEmployee.Name = "pbEmployee"
        pbEmployee.Size = New Size(63, 63)
        pbEmployee.SizeMode = PictureBoxSizeMode.StretchImage
        pbEmployee.TabIndex = 7
        pbEmployee.TabStop = False
        ' 
        ' dgvTableView
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvTableView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTableView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTableView.ColumnHeadersHeight = 30
        dgvTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvTableView.DefaultCellStyle = DataGridViewCellStyle3
        dgvTableView.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTableView.Location = New Point(430, 100)
        dgvTableView.Name = "dgvTableView"
        dgvTableView.RowHeadersVisible = False
        dgvTableView.Size = New Size(540, 390)
        dgvTableView.TabIndex = 9
        dgvTableView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvTableView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvTableView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvTableView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvTableView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvTableView.ThemeStyle.BackColor = Color.White
        dgvTableView.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTableView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvTableView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvTableView.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dgvTableView.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvTableView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvTableView.ThemeStyle.HeaderStyle.Height = 30
        dgvTableView.ThemeStyle.ReadOnly = False
        dgvTableView.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvTableView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTableView.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvTableView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvTableView.ThemeStyle.RowsStyle.Height = 22
        dgvTableView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTableView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' lblX
        ' 
        lblX.AutoSize = True
        lblX.BackColor = Color.Transparent
        lblX.Font = New Font("Source Sans Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblX.ForeColor = Color.White
        lblX.Location = New Point(940, 9)
        lblX.Name = "lblX"
        lblX.Size = New Size(28, 34)
        lblX.TabIndex = 10
        lblX.Text = "x"
        ' 
        ' Employee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.splash
        ClientSize = New Size(980, 520)
        Controls.Add(lblX)
        Controls.Add(dgvTableView)
        Controls.Add(lblEmployee)
        Controls.Add(pbEmployee)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Employee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Eployee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbBack, ComponentModel.ISupportInitialize).EndInit()
        CType(pbEmployee, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblEmployee As Label
    Friend WithEvents pbEmployee As PictureBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtSecondName As TextBox
    Friend WithEvents lblSecondName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents cbEducation As ComboBox
    Friend WithEvents lblEducation As Label
    Friend WithEvents cbPosition As ComboBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents txtDateOfBirth As Label
    Friend WithEvents dgvTableView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnDelete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnEdit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents lblX As Label
End Class
