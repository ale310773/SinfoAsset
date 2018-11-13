<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchMasterItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchMasterItem))
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblSearchAnggota = New System.Windows.Forms.Label()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Nama Kategori"
        '
        'btnSelect
        '
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Location = New System.Drawing.Point(44, 89)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(814, 23)
        Me.btnSelect.TabIndex = 15
        Me.btnSelect.Text = "SELECT"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icon_Asset.ico")
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 2
        Me.ColumnHeader7.Text = "Kode Kategori"
        Me.ColumnHeader7.Width = 96
        '
        'ToolTip3
        '
        Me.ToolTip3.AutoPopDelay = 5000
        Me.ToolTip3.InitialDelay = 100
        Me.ToolTip3.IsBalloon = True
        Me.ToolTip3.ReshowDelay = 100
        Me.ToolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 6
        Me.ColumnHeader6.Text = "Limit Umur"
        Me.ColumnHeader6.Width = 165
        '
        'ToolTip2
        '
        Me.ToolTip2.AutoPopDelay = 5000
        Me.ToolTip2.InitialDelay = 100
        Me.ToolTip2.IsBalloon = True
        Me.ToolTip2.ReshowDelay = 100
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 5
        Me.ColumnHeader5.Text = "Barcode"
        Me.ColumnHeader5.Width = 98
        '
        'lblSearchAnggota
        '
        Me.lblSearchAnggota.AutoSize = True
        Me.lblSearchAnggota.BackColor = System.Drawing.Color.Transparent
        Me.lblSearchAnggota.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchAnggota.ForeColor = System.Drawing.Color.White
        Me.lblSearchAnggota.Location = New System.Drawing.Point(28, 43)
        Me.lblSearchAnggota.Name = "lblSearchAnggota"
        Me.lblSearchAnggota.Size = New System.Drawing.Size(145, 17)
        Me.lblSearchAnggota.TabIndex = 17
        Me.lblSearchAnggota.Text = "Kode Item / Nama Item"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 4
        Me.ColumnHeader4.Text = "Keterangan"
        Me.ColumnHeader4.Width = 85
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(182, 43)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(642, 20)
        Me.txtSearch.TabIndex = 14
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(44, 119)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(814, 337)
        Me.ListView1.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.ListView1, "Silahkan double klik dengan mouse untuk memilih data")
        Me.ToolTip3.SetToolTip(Me.ListView1, "Silahkan double klik dengan mouse untuk memilih data")
        Me.ToolTip2.SetToolTip(Me.ListView1, "Silahkan double klik dengan mouse untuk memilih data")
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode Item"
        Me.ColumnHeader1.Width = 128
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Item"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 3
        Me.ColumnHeader3.Text = "Group"
        Me.ColumnHeader3.Width = 185
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(826, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSearchMasterItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Explore.My.Resources.Resources.WinDesktop
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblSearchAnggota)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmSearchMasterItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSearchMasterItem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblSearchAnggota As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
