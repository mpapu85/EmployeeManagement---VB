<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        lblHeadline = New Label()
        Label2 = New Label()
        MyProgress = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        pbUser = New PictureBox()
        Timer1 = New Timer(components)
        MyProgress.SuspendLayout()
        CType(pbUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeadline
        ' 
        lblHeadline.AutoSize = True
        lblHeadline.BackColor = Color.Transparent
        lblHeadline.Font = New Font("Source Sans Pro Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeadline.ForeColor = Color.White
        lblHeadline.Location = New Point(123, 29)
        lblHeadline.Name = "lblHeadline"
        lblHeadline.Size = New Size(268, 24)
        lblHeadline.TabIndex = 0
        lblHeadline.Text = "Employee Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Source Sans Pro", 9.75F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(204, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 17)
        Label2.TabIndex = 1
        Label2.Text = "Milan Pumpalovic"
        ' 
        ' MyProgress
        ' 
        MyProgress.BackColor = Color.Transparent
        MyProgress.Controls.Add(pbUser)
        MyProgress.FillColor = Color.FromArgb(CByte(200), CByte(213), CByte(218), CByte(223))
        MyProgress.FillThickness = 10
        MyProgress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MyProgress.ForeColor = Color.White
        MyProgress.Location = New Point(192, 74)
        MyProgress.Minimum = 0
        MyProgress.Name = "MyProgress"
        MyProgress.ProgressColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        MyProgress.ProgressColor2 = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        MyProgress.ProgressThickness = 10
        MyProgress.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        MyProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        MyProgress.Size = New Size(130, 130)
        MyProgress.TabIndex = 2
        MyProgress.Text = "Guna2CircleProgressBar1"
        ' 
        ' pbUser
        ' 
        pbUser.Image = My.Resources.Resources.user
        pbUser.Location = New Point(31, 30)
        pbUser.Name = "pbUser"
        pbUser.Size = New Size(68, 67)
        pbUser.SizeMode = PictureBoxSizeMode.StretchImage
        pbUser.TabIndex = 3
        pbUser.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.splash
        ClientSize = New Size(500, 250)
        Controls.Add(MyProgress)
        Controls.Add(Label2)
        Controls.Add(lblHeadline)
        FormBorderStyle = FormBorderStyle.None
        Name = "Splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MyProgress.ResumeLayout(False)
        CType(pbUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeadline As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MyProgress As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
