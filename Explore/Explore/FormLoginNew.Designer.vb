<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoginNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoginNew))
        Me.PanelUserLogin = New System.Windows.Forms.Panel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Ok = New System.Windows.Forms.Button()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PasswordTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.UsernameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CircularProgressLoading = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressRun = New DevComponents.DotNetBar.Command(Me.components)
        Me.PanelUserLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelUserLogin
        '
        Me.PanelUserLogin.BackColor = System.Drawing.Color.Transparent
        Me.PanelUserLogin.BackgroundImage = Global.Explore.My.Resources.Resources.WinDesktop
        Me.PanelUserLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelUserLogin.Controls.Add(Me.Cancel)
        Me.PanelUserLogin.Controls.Add(Me.Ok)
        Me.PanelUserLogin.Controls.Add(Me.LabelX2)
        Me.PanelUserLogin.Controls.Add(Me.LabelX1)
        Me.PanelUserLogin.Controls.Add(Me.PasswordTextBox)
        Me.PanelUserLogin.Controls.Add(Me.UsernameTextBox)
        Me.PanelUserLogin.Location = New System.Drawing.Point(989, 180)
        Me.PanelUserLogin.Name = "PanelUserLogin"
        Me.PanelUserLogin.Size = New System.Drawing.Size(277, 180)
        Me.PanelUserLogin.TabIndex = 8
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Black
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cancel.Location = New System.Drawing.Point(186, 125)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 26)
        Me.Cancel.TabIndex = 11
        Me.Cancel.Text = "EXIT"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Ok
        '
        Me.Ok.BackColor = System.Drawing.Color.Black
        Me.Ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ok.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ok.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Ok.Location = New System.Drawing.Point(109, 125)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(75, 27)
        Me.Ok.TabIndex = 10
        Me.Ok.Text = "LOGIN"
        Me.Ok.UseVisualStyleBackColor = False
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(16, 69)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "Password"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(38, 33)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(44, 23)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = "User"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.PasswordTextBox.Border.Class = "TextBoxBorder"
        Me.PasswordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PasswordTextBox.Border.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(105, 72)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(155, 20)
        Me.PasswordTextBox.TabIndex = 7
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.UsernameTextBox.Border.Class = "TextBoxBorder"
        Me.UsernameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.UsernameTextBox.Border.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(105, 34)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(156, 20)
        Me.UsernameTextBox.TabIndex = 6
        '
        'CircularProgressLoading
        '
        Me.CircularProgressLoading.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CircularProgressLoading.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgressLoading.Location = New System.Drawing.Point(332, 106)
        Me.CircularProgressLoading.Name = "CircularProgressLoading"
        Me.CircularProgressLoading.ProgressColor = System.Drawing.Color.Blue
        Me.CircularProgressLoading.ProgressText = "Silahkan Tunggu Sedang Loading Aplikasi"
        Me.CircularProgressLoading.ProgressTextColor = System.Drawing.Color.DarkBlue
        Me.CircularProgressLoading.Size = New System.Drawing.Size(340, 313)
        Me.CircularProgressLoading.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgressLoading.TabIndex = 9
        '
        'Timer1
        '
        '
        'ProgressRun
        '
        Me.ProgressRun.Checked = True
        Me.ProgressRun.Name = "ProgressRun"
        '
        'FormLoginNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1251, 623)
        Me.Controls.Add(Me.CircularProgressLoading)
        Me.Controls.Add(Me.PanelUserLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLoginNew"
        Me.Text = "MANAGEMENT ASSET VER 2.2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelUserLogin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelUserLogin As System.Windows.Forms.Panel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PasswordTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents UsernameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Ok As System.Windows.Forms.Button
    Friend WithEvents CircularProgressLoading As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents ProgressRun As DevComponents.DotNetBar.Command
End Class
