<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim MetroTileFrame3 As DevComponents.DotNetBar.Metro.MetroTileFrame
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.metroTilePanel1 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.MetroTilePanel2 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.itemContainerAsset = New DevComponents.DotNetBar.ItemContainer()
        Me.metroTileItemJumlahTotalAsset = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.metroTileItemJumlahTotalLokasi = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.metroTileItemGroupElectric = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.metroTileItem9 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.metroTileItem10 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.metroTileItem11 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.metroTileItem4 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.metroTileItem12 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.itemContainerInfoOthers = New DevComponents.DotNetBar.ItemContainer()
        Me.metroTileItem13 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.metroTileItem5 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.metroTileItem6 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        MetroTileFrame3 = New DevComponents.DotNetBar.Metro.MetroTileFrame()
        Me.metroTilePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTileFrame3
        '
        MetroTileFrame3.Image = Global.Explore.My.Resources.Resources.WinDesktop
        MetroTileFrame3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        MetroTileFrame3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        MetroTileFrame3.TitleText = "Others"
        '
        'metroTilePanel1
        '
        '
        '
        '
        Me.metroTilePanel1.BackgroundStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft
        Me.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel"
        Me.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.metroTilePanel1.ContainerControlProcessDialogKey = True
        Me.metroTilePanel1.Controls.Add(Me.MetroTilePanel2)
        Me.metroTilePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.metroTilePanel1.EnableDragDrop = True
        Me.metroTilePanel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metroTilePanel1.Location = New System.Drawing.Point(0, 0)
        Me.metroTilePanel1.Name = "metroTilePanel1"
        Me.metroTilePanel1.Size = New System.Drawing.Size(1175, 566)
        Me.metroTilePanel1.TabIndex = 1
        Me.metroTilePanel1.Text = "metroTilePanel1"
        '
        'MetroTilePanel2
        '
        Me.MetroTilePanel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        '
        '
        '
        Me.MetroTilePanel2.BackgroundStyle.BackgroundImage = CType(resources.GetObject("MetroTilePanel2.BackgroundStyle.BackgroundImage"), System.Drawing.Image)
        Me.MetroTilePanel2.BackgroundStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft
        Me.MetroTilePanel2.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel2.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTilePanel2.EnableDragDrop = True
        Me.MetroTilePanel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTilePanel2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainerAsset, Me.itemContainerInfoOthers})
        Me.MetroTilePanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroTilePanel2.Name = "MetroTilePanel2"
        Me.MetroTilePanel2.Size = New System.Drawing.Size(1175, 566)
        Me.MetroTilePanel2.TabIndex = 1
        Me.MetroTilePanel2.Text = "MetroTilePanel2"
        '
        'itemContainerAsset
        '
        '
        '
        '
        Me.itemContainerAsset.BackgroundStyle.BackgroundImage = CType(resources.GetObject("itemContainerAsset.BackgroundStyle.BackgroundImage"), System.Drawing.Image)
        Me.itemContainerAsset.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itemContainerAsset.ItemSpacing = 8
        Me.itemContainerAsset.MultiLine = True
        Me.itemContainerAsset.Name = "itemContainerAsset"
        Me.itemContainerAsset.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.metroTileItemJumlahTotalAsset, Me.metroTileItemJumlahTotalLokasi, Me.metroTileItemGroupElectric, Me.metroTileItem9, Me.metroTileItem10, Me.metroTileItem11, Me.metroTileItem4, Me.metroTileItem12})
        '
        '
        '
        Me.itemContainerAsset.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itemContainerAsset.TitleStyle.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemContainerAsset.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itemContainerAsset.TitleText = "Informasi Asset"
        '
        'metroTileItemJumlahTotalAsset
        '
        Me.metroTileItemJumlahTotalAsset.Image = Global.Explore.My.Resources.Resources.Computer
        Me.metroTileItemJumlahTotalAsset.ImageIndent = New System.Drawing.Point(0, -6)
        Me.metroTileItemJumlahTotalAsset.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.metroTileItemJumlahTotalAsset.Name = "metroTileItemJumlahTotalAsset"
        Me.metroTileItemJumlahTotalAsset.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItemJumlahTotalAsset.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green
        Me.metroTileItemJumlahTotalAsset.TileSize = New System.Drawing.Size(120, 120)
        '
        '
        '
        Me.metroTileItemJumlahTotalAsset.TileStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.metroTileItemJumlahTotalAsset.TileStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.metroTileItemJumlahTotalAsset.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.metroTileItemJumlahTotalAsset.TileStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metroTileItemJumlahTotalAsset.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.metroTileItemJumlahTotalAsset.TitleText = "30 Total Asset"
        Me.metroTileItemJumlahTotalAsset.TitleTextAlignment = System.Drawing.ContentAlignment.BottomRight
        '
        'metroTileItemJumlahTotalLokasi
        '
        Me.metroTileItemJumlahTotalLokasi.Image = Global.Explore.My.Resources.Resources.BreakingNews
        Me.metroTileItemJumlahTotalLokasi.ImageIndent = New System.Drawing.Point(0, -6)
        Me.metroTileItemJumlahTotalLokasi.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.metroTileItemJumlahTotalLokasi.Name = "metroTileItemJumlahTotalLokasi"
        Me.metroTileItemJumlahTotalLokasi.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItemJumlahTotalLokasi.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green
        Me.metroTileItemJumlahTotalLokasi.TileSize = New System.Drawing.Size(120, 120)
        '
        '
        '
        Me.metroTileItemJumlahTotalLokasi.TileStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.metroTileItemJumlahTotalLokasi.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.metroTileItemJumlahTotalLokasi.TileStyle.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metroTileItemJumlahTotalLokasi.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.metroTileItemJumlahTotalLokasi.TitleText = "12 Lokasi Asset"
        Me.metroTileItemJumlahTotalLokasi.TitleTextAlignment = System.Drawing.ContentAlignment.BottomRight
        '
        'metroTileItemGroupElectric
        '
        Me.metroTileItemGroupElectric.AutoRotateFramesInterval = 4000
        Me.metroTileItemGroupElectric.Image = Global.Explore.My.Resources.Resources.ControlPanel
        Me.metroTileItemGroupElectric.ImageIndent = New System.Drawing.Point(32, 0)
        Me.metroTileItemGroupElectric.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.metroTileItemGroupElectric.Name = "metroTileItemGroupElectric"
        Me.metroTileItemGroupElectric.Stretch = True
        Me.metroTileItemGroupElectric.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItemGroupElectric.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange
        Me.metroTileItemGroupElectric.TileSize = New System.Drawing.Size(248, 120)
        '
        '
        '
        Me.metroTileItemGroupElectric.TileStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.metroTileItemGroupElectric.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.metroTileItemGroupElectric.TileStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metroTileItemGroupElectric.TitleText = "24 Total Asset Electrik"
        Me.metroTileItemGroupElectric.TitleTextAlignment = System.Drawing.ContentAlignment.BottomRight
        '
        'metroTileItem9
        '
        Me.metroTileItem9.AnimationEnabled = False
        Me.metroTileItem9.AutoRotateFramesInterval = 4000
        Me.metroTileItem9.Image = Global.Explore.My.Resources.Resources.IELogo
        Me.metroTileItem9.ImageIndent = New System.Drawing.Point(4, -6)
        Me.metroTileItem9.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.metroTileItem9.Name = "metroTileItem9"
        Me.metroTileItem9.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItem9.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange
        Me.metroTileItem9.TileSize = New System.Drawing.Size(120, 120)
        '
        '
        '
        Me.metroTileItem9.TileStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.metroTileItem9.TileStyle.BackColorGradientAngle = 90
        Me.metroTileItem9.TileStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.metroTileItem9.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.metroTileItem9.TileStyle.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metroTileItem9.TileStyle.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.metroTileItem9.TitleText = "Others"
        Me.metroTileItem9.TitleTextAlignment = System.Drawing.ContentAlignment.BottomRight
        '
        'metroTileItem10
        '
        Me.metroTileItem10.AnimationEnabled = False
        Me.metroTileItem10.AutoRotateFramesInterval = 4000
        Me.metroTileItem10.Image = Global.Explore.My.Resources.Resources.News
        Me.metroTileItem10.ImageIndent = New System.Drawing.Point(4, -6)
        Me.metroTileItem10.ImageTextAlignment = System.Drawing.ContentAlignment.BottomLeft
        Me.metroTileItem10.Name = "metroTileItem10"
        Me.metroTileItem10.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItem10.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue
        Me.metroTileItem10.TileSize = New System.Drawing.Size(248, 120)
        '
        '
        '
        Me.metroTileItem10.TileStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.metroTileItem10.TileStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.metroTileItem10.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.metroTileItem10.TitleText = "Windows Explorer"
        Me.metroTileItem10.TitleTextAlignment = System.Drawing.ContentAlignment.BottomRight
        '
        'metroTileItem11
        '
        Me.metroTileItem11.AnimationEnabled = False
        Me.metroTileItem11.AutoRotateFramesInterval = 4000
        Me.metroTileItem11.Frames.Add(MetroTileFrame3)
        Me.metroTileItem11.Image = Global.Explore.My.Resources.Resources.WinDesktop
        Me.metroTileItem11.Name = "metroTileItem11"
        Me.metroTileItem11.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItem11.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.metroTileItem11.TileSize = New System.Drawing.Size(248, 120)
        Me.metroTileItem11.TitleText = "Others"
        '
        'metroTileItem4
        '
        Me.metroTileItem4.AutoRotateFramesInterval = 4000
        Me.metroTileItem4.Image = Global.Explore.My.Resources.Resources.IELogo
        Me.metroTileItem4.ImageIndent = New System.Drawing.Point(4, 0)
        Me.metroTileItem4.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.metroTileItem4.Name = "metroTileItem4"
        Me.metroTileItem4.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue
        Me.metroTileItem4.TileSize = New System.Drawing.Size(248, 120)
        '
        '
        '
        Me.metroTileItem4.TileStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.metroTileItem4.TileStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.metroTileItem4.TitleText = "Sistem Informasi Asset"
        Me.metroTileItem4.TitleTextAlignment = System.Drawing.ContentAlignment.BottomRight
        '
        'metroTileItem12
        '
        Me.metroTileItem12.AutoRotateFramesInterval = 4000
        Me.metroTileItem12.Image = Global.Explore.My.Resources.Resources.ControlPanel
        Me.metroTileItem12.ImageIndent = New System.Drawing.Point(32, 0)
        Me.metroTileItem12.Name = "metroTileItem12"
        Me.metroTileItem12.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItem12.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal
        Me.metroTileItem12.TileSize = New System.Drawing.Size(248, 120)
        '
        '
        '
        Me.metroTileItem12.TileStyle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.metroTileItem12.TileStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.metroTileItem12.TileStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft
        Me.metroTileItem12.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.metroTileItem12.TileStyle.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.metroTileItem12.TitleText = "Management Asset"
        '
        'itemContainerInfoOthers
        '
        '
        '
        '
        Me.itemContainerInfoOthers.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itemContainerInfoOthers.ItemSpacing = 8
        Me.itemContainerInfoOthers.MultiLine = True
        Me.itemContainerInfoOthers.Name = "itemContainerInfoOthers"
        Me.itemContainerInfoOthers.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.metroTileItem13, Me.metroTileItem5, Me.metroTileItem6})
        '
        '
        '
        Me.itemContainerInfoOthers.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itemContainerInfoOthers.TitleStyle.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemContainerInfoOthers.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itemContainerInfoOthers.TitleText = "User"
        '
        'metroTileItem13
        '
        Me.metroTileItem13.ImageIndent = New System.Drawing.Point(4, -6)
        Me.metroTileItem13.ImageTextAlignment = System.Drawing.ContentAlignment.BottomLeft
        Me.metroTileItem13.Name = "metroTileItem13"
        Me.metroTileItem13.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItem13.Text = "Developer Command Prompt"
        Me.metroTileItem13.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen
        Me.metroTileItem13.TileSize = New System.Drawing.Size(120, 120)
        '
        '
        '
        Me.metroTileItem13.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'metroTileItem5
        '
        Me.metroTileItem5.ImageIndent = New System.Drawing.Point(4, -6)
        Me.metroTileItem5.ImageTextAlignment = System.Drawing.ContentAlignment.BottomLeft
        Me.metroTileItem5.Name = "metroTileItem5"
        Me.metroTileItem5.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItem5.Text = "Remote Debugger"
        Me.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen
        Me.metroTileItem5.TileSize = New System.Drawing.Size(120, 120)
        '
        '
        '
        Me.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'metroTileItem6
        '
        Me.metroTileItem6.ImageIndent = New System.Drawing.Point(0, 8)
        Me.metroTileItem6.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.metroTileItem6.Name = "metroTileItem6"
        Me.metroTileItem6.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItem6.Text = "Remote Desktop"
        Me.metroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive
        Me.metroTileItem6.TileSize = New System.Drawing.Size(120, 120)
        '
        '
        '
        Me.metroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.metroTilePanel1)
        Me.Name = "Home"
        Me.Size = New System.Drawing.Size(1175, 566)
        Me.metroTilePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents metroTilePanel1 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Private WithEvents MetroTilePanel2 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Private WithEvents itemContainerAsset As DevComponents.DotNetBar.ItemContainer
    Private WithEvents metroTileItemJumlahTotalAsset As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents metroTileItemJumlahTotalLokasi As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents metroTileItemGroupElectric As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents metroTileItem9 As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents metroTileItem10 As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents metroTileItem11 As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents metroTileItem4 As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents metroTileItem12 As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents itemContainerInfoOthers As DevComponents.DotNetBar.ItemContainer
    Private WithEvents metroTileItem13 As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents metroTileItem5 As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents metroTileItem6 As DevComponents.DotNetBar.Metro.MetroTileItem

End Class
