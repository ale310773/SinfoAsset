<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerifikasi
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
        Me.txtHashString = New System.Windows.Forms.TextBox()
        Me.lblHashString = New System.Windows.Forms.Label()
        Me.lblTeksBiasa = New System.Windows.Forms.Label()
        Me.txtBiasa = New System.Windows.Forms.TextBox()
        Me.btnVerifikasi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHashString
        '
        Me.txtHashString.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHashString.Location = New System.Drawing.Point(327, 232)
        Me.txtHashString.Name = "txtHashString"
        Me.txtHashString.Size = New System.Drawing.Size(751, 38)
        Me.txtHashString.TabIndex = 2
        '
        'lblHashString
        '
        Me.lblHashString.AutoSize = True
        Me.lblHashString.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHashString.Location = New System.Drawing.Point(36, 235)
        Me.lblHashString.Name = "lblHashString"
        Me.lblHashString.Size = New System.Drawing.Size(259, 31)
        Me.lblHashString.TabIndex = 6
        Me.lblHashString.Text = "KEY CHARACTER"
        '
        'lblTeksBiasa
        '
        Me.lblTeksBiasa.AutoSize = True
        Me.lblTeksBiasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeksBiasa.Location = New System.Drawing.Point(36, 107)
        Me.lblTeksBiasa.Name = "lblTeksBiasa"
        Me.lblTeksBiasa.Size = New System.Drawing.Size(117, 31)
        Me.lblTeksBiasa.TabIndex = 5
        Me.lblTeksBiasa.Text = "SERIAL"
        '
        'txtBiasa
        '
        Me.txtBiasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiasa.Location = New System.Drawing.Point(327, 104)
        Me.txtBiasa.Name = "txtBiasa"
        Me.txtBiasa.Size = New System.Drawing.Size(751, 38)
        Me.txtBiasa.TabIndex = 1
        '
        'btnVerifikasi
        '
        Me.btnVerifikasi.Location = New System.Drawing.Point(42, 368)
        Me.btnVerifikasi.Name = "btnVerifikasi"
        Me.btnVerifikasi.Size = New System.Drawing.Size(1036, 60)
        Me.btnVerifikasi.TabIndex = 3
        Me.btnVerifikasi.Text = "VERIFIKASI"
        Me.btnVerifikasi.UseVisualStyleBackColor = True
        '
        'frmVerifikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 479)
        Me.Controls.Add(Me.btnVerifikasi)
        Me.Controls.Add(Me.txtHashString)
        Me.Controls.Add(Me.lblHashString)
        Me.Controls.Add(Me.lblTeksBiasa)
        Me.Controls.Add(Me.txtBiasa)
        Me.Name = "frmVerifikasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRASI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHashString As System.Windows.Forms.TextBox
    Friend WithEvents lblHashString As System.Windows.Forms.Label
    Friend WithEvents lblTeksBiasa As System.Windows.Forms.Label
    Friend WithEvents txtBiasa As System.Windows.Forms.TextBox
    Friend WithEvents btnVerifikasi As System.Windows.Forms.Button
End Class
