<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoAssetoSusut
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblKodeItem = New System.Windows.Forms.Label()
        Me.txtnamaitem = New System.Windows.Forms.TextBox()
        Me.txtKodeItem = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DataGridViewPenyusutanAsset = New System.Windows.Forms.DataGridView()
        Me.colTahunPerolehan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHargaPerolehan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAkumulasiSusut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNilaiBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbebanpenyusutan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblNamaItem = New System.Windows.Forms.Label()
        CType(Me.DataGridViewPenyusutanAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nilai Buku"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 19)
        Me.Label1.TabIndex = 277
        Me.Label1.Text = "INFO PENYUSUTAN ASSET"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Beban Penyusutan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Akumulasi Penyusutan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Beban Penyusutan"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'lblKodeItem
        '
        Me.lblKodeItem.AutoSize = True
        Me.lblKodeItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeItem.Location = New System.Drawing.Point(18, 65)
        Me.lblKodeItem.Name = "lblKodeItem"
        Me.lblKodeItem.Size = New System.Drawing.Size(79, 19)
        Me.lblKodeItem.TabIndex = 281
        Me.lblKodeItem.Text = "Kode Item"
        '
        'txtnamaitem
        '
        Me.txtnamaitem.BackColor = System.Drawing.Color.LightBlue
        Me.txtnamaitem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamaitem.Location = New System.Drawing.Point(109, 100)
        Me.txtnamaitem.Name = "txtnamaitem"
        Me.txtnamaitem.Size = New System.Drawing.Size(616, 27)
        Me.txtnamaitem.TabIndex = 280
        '
        'txtKodeItem
        '
        Me.txtKodeItem.BackColor = System.Drawing.Color.LightBlue
        Me.txtKodeItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeItem.Location = New System.Drawing.Point(109, 63)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.Size = New System.Drawing.Size(616, 27)
        Me.txtKodeItem.TabIndex = 279
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Harga Perolehan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tahun"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'colIndex
        '
        Me.colIndex.HeaderText = "Index"
        Me.colIndex.Name = "colIndex"
        Me.colIndex.Width = 70
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(671, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 278
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DataGridViewPenyusutanAsset
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPenyusutanAsset.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPenyusutanAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPenyusutanAsset.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIndex, Me.colTahunPerolehan, Me.colHargaPerolehan, Me.colAkumulasiSusut, Me.colNilaiBuku, Me.colbebanpenyusutan})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewPenyusutanAsset.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewPenyusutanAsset.Location = New System.Drawing.Point(21, 139)
        Me.DataGridViewPenyusutanAsset.Name = "DataGridViewPenyusutanAsset"
        Me.DataGridViewPenyusutanAsset.Size = New System.Drawing.Size(706, 402)
        Me.DataGridViewPenyusutanAsset.TabIndex = 276
        '
        'colTahunPerolehan
        '
        Me.colTahunPerolehan.HeaderText = "Tahun"
        Me.colTahunPerolehan.Name = "colTahunPerolehan"
        '
        'colHargaPerolehan
        '
        Me.colHargaPerolehan.HeaderText = "Harga Perolehan"
        Me.colHargaPerolehan.Name = "colHargaPerolehan"
        '
        'colAkumulasiSusut
        '
        Me.colAkumulasiSusut.HeaderText = "Akumulasi Penyusutan"
        Me.colAkumulasiSusut.Name = "colAkumulasiSusut"
        '
        'colNilaiBuku
        '
        Me.colNilaiBuku.HeaderText = "Nilai Buku"
        Me.colNilaiBuku.Name = "colNilaiBuku"
        '
        'colbebanpenyusutan
        '
        Me.colbebanpenyusutan.HeaderText = "Beban Penyusutan"
        Me.colbebanpenyusutan.Name = "colbebanpenyusutan"
        Me.colbebanpenyusutan.Width = 200
        '
        'lblNamaItem
        '
        Me.lblNamaItem.AutoSize = True
        Me.lblNamaItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaItem.Location = New System.Drawing.Point(18, 102)
        Me.lblNamaItem.Name = "lblNamaItem"
        Me.lblNamaItem.Size = New System.Drawing.Size(84, 19)
        Me.lblNamaItem.TabIndex = 282
        Me.lblNamaItem.Text = "Nama Item"
        '
        'frmInfoAssetoSusut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 549)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblKodeItem)
        Me.Controls.Add(Me.txtnamaitem)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.DataGridViewPenyusutanAsset)
        Me.Controls.Add(Me.lblNamaItem)
        Me.Name = "frmInfoAssetoSusut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInfoAssetoSusut"
        CType(Me.DataGridViewPenyusutanAsset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblKodeItem As System.Windows.Forms.Label
    Friend WithEvents txtnamaitem As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeItem As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIndex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents DataGridViewPenyusutanAsset As System.Windows.Forms.DataGridView
    Friend WithEvents colTahunPerolehan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHargaPerolehan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAkumulasiSusut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNilaiBuku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colbebanpenyusutan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblNamaItem As System.Windows.Forms.Label
End Class
