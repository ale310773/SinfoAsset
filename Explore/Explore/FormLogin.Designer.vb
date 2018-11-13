<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.PanelUserLogin = New System.Windows.Forms.Panel()
        Me.Cancel = New DevComponents.DotNetBar.ButtonX()
        Me.OK = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PasswordTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.UsernameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelUserLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelUserLogin
        '
        Me.PanelUserLogin.BackColor = System.Drawing.Color.Transparent
        Me.PanelUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelUserLogin.Controls.Add(Me.Cancel)
        Me.PanelUserLogin.Controls.Add(Me.OK)
        Me.PanelUserLogin.Controls.Add(Me.LabelX2)
        Me.PanelUserLogin.Controls.Add(Me.LabelX1)
        Me.PanelUserLogin.Controls.Add(Me.PasswordTextBox)
        Me.PanelUserLogin.Controls.Add(Me.UsernameTextBox)
        Me.PanelUserLogin.Location = New System.Drawing.Point(972, 213)
        Me.PanelUserLogin.Name = "PanelUserLogin"
        Me.PanelUserLogin.Size = New System.Drawing.Size(291, 180)
        Me.PanelUserLogin.TabIndex = 7
        '
        'Cancel
        '
        Me.Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Cancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(172, 120)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(113, 23)
        Me.Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Cancel.TabIndex = 11
        Me.Cancel.Text = "Exit"
        '
        'OK
        '
        Me.OK.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.OK.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(59, 121)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(109, 23)
        Me.OK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.OK.TabIndex = 10
        Me.OK.Text = "Login"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.LabelX1.Location = New System.Drawing.Point(38, 33)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(44, 23)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = "User"
        '
        'PasswordTextBox
        '
        '
        '
        '
        Me.PasswordTextBox.Border.Class = "TextBoxBorder"
        Me.PasswordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PasswordTextBox.Border.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(105, 72)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(155, 20)
        Me.PasswordTextBox.TabIndex = 7
        '
        'UsernameTextBox
        '
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
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1265, 638)
        Me.Controls.Add(Me.PanelUserLogin)
        Me.DoubleBuffered = True
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelUserLogin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelUserLogin As System.Windows.Forms.Panel
    Friend WithEvents Cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PasswordTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents UsernameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
End Class
