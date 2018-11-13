<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransBeli
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransBeli))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Button_Add = New System.Windows.Forms.ToolStripButton()
        Me.Button_Edit = New System.Windows.Forms.ToolStripButton()
        Me.Button_Save = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.Button_Delete = New System.Windows.Forms.ToolStripButton()
        Me.Button_Copy = New System.Windows.Forms.ToolStripButton()
        Me.Button_Search = New System.Windows.Forms.ToolStripButton()
        Me.Button_Print = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button_Cancel = New System.Windows.Forms.ToolStripButton()
        Me.Button_Load = New System.Windows.Forms.ToolStripButton()
        Me.ItemPanelPencarianData = New DevComponents.DotNetBar.ItemPanel()
        Me.txtSearch = New DevComponents.DotNetBar.TextBoxItem()
        Me.ButtonItemSearch = New DevComponents.DotNetBar.ButtonItem()
        Me.TabControl = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnCalcAssetRp = New DevComponents.DotNetBar.ButtonX()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.txtHarga = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtketerangan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtstatusbarang = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtsumberdana = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.DateTimePickertglbeli = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblMerk = New DevComponents.DotNetBar.LabelX()
        Me.txtcaraperolehan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblnamaitem = New DevComponents.DotNetBar.LabelX()
        Me.btnSearchkodeitem = New DevComponents.DotNetBar.ButtonX()
        Me.grouppanelRecored = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtmodifiedby = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtlastmodified = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcreateby = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcreatedate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.lblKodeGroup = New DevComponents.DotNetBar.LabelX()
        Me.txtkodeitem = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TabItemData = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.DataGridViewTransBeli = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.colTanggalBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKodeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNamaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCaraPerolehan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSumberDana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStatusBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColKeterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCreateBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColModifiedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLastModified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabItemList = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DateTimePickertglbeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grouppanelRecored.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.DataGridViewTransBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Lime
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Button_Add, Me.Button_Edit, Me.Button_Save, Me.toolStripSeparator, Me.Button_Delete, Me.Button_Copy, Me.Button_Search, Me.Button_Print, Me.toolStripSeparator1, Me.Button_Cancel, Me.Button_Load})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1308, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Button_Add
        '
        Me.Button_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Add.Image = CType(resources.GetObject("Button_Add.Image"), System.Drawing.Image)
        Me.Button_Add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(23, 22)
        Me.Button_Add.Text = "&New"
        Me.Button_Add.ToolTipText = "Tambah Data"
        '
        'Button_Edit
        '
        Me.Button_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Edit.Image = CType(resources.GetObject("Button_Edit.Image"), System.Drawing.Image)
        Me.Button_Edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(23, 22)
        Me.Button_Edit.Text = "&Open"
        Me.Button_Edit.ToolTipText = "Edit Data"
        '
        'Button_Save
        '
        Me.Button_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Save.Image = CType(resources.GetObject("Button_Save.Image"), System.Drawing.Image)
        Me.Button_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(23, 22)
        Me.Button_Save.Text = "&Save"
        Me.Button_Save.ToolTipText = "Simpan Data"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'Button_Delete
        '
        Me.Button_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Delete.Image = CType(resources.GetObject("Button_Delete.Image"), System.Drawing.Image)
        Me.Button_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(23, 22)
        Me.Button_Delete.Text = "C&ut"
        Me.Button_Delete.ToolTipText = "Hapus Data"
        '
        'Button_Copy
        '
        Me.Button_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Copy.Image = CType(resources.GetObject("Button_Copy.Image"), System.Drawing.Image)
        Me.Button_Copy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Copy.Name = "Button_Copy"
        Me.Button_Copy.Size = New System.Drawing.Size(23, 22)
        Me.Button_Copy.Text = "&Copy"
        Me.Button_Copy.ToolTipText = "Copy Data"
        '
        'Button_Search
        '
        Me.Button_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Search.Image = CType(resources.GetObject("Button_Search.Image"), System.Drawing.Image)
        Me.Button_Search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(23, 22)
        Me.Button_Search.Text = "ToolStripButton1"
        Me.Button_Search.ToolTipText = "Cari Data"
        '
        'Button_Print
        '
        Me.Button_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Print.Image = CType(resources.GetObject("Button_Print.Image"), System.Drawing.Image)
        Me.Button_Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Print.Name = "Button_Print"
        Me.Button_Print.Size = New System.Drawing.Size(23, 22)
        Me.Button_Print.Text = "&Print"
        Me.Button_Print.ToolTipText = "Print Data"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Button_Cancel
        '
        Me.Button_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Cancel.Image = CType(resources.GetObject("Button_Cancel.Image"), System.Drawing.Image)
        Me.Button_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(23, 22)
        Me.Button_Cancel.Text = "ToolStripButton1"
        Me.Button_Cancel.ToolTipText = "Batal Simpan"
        '
        'Button_Load
        '
        Me.Button_Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Load.Image = CType(resources.GetObject("Button_Load.Image"), System.Drawing.Image)
        Me.Button_Load.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Load.Name = "Button_Load"
        Me.Button_Load.Size = New System.Drawing.Size(23, 22)
        Me.Button_Load.Text = "ToolStripButton2"
        Me.Button_Load.ToolTipText = "Panggil Data"
        '
        'ItemPanelPencarianData
        '
        '
        '
        '
        Me.ItemPanelPencarianData.BackgroundStyle.Class = "ItemPanel"
        Me.ItemPanelPencarianData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemPanelPencarianData.ContainerControlProcessDialogKey = True
        Me.ItemPanelPencarianData.Dock = System.Windows.Forms.DockStyle.Top
        Me.ItemPanelPencarianData.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.txtSearch, Me.ButtonItemSearch})
        Me.ItemPanelPencarianData.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemPanelPencarianData.Location = New System.Drawing.Point(0, 25)
        Me.ItemPanelPencarianData.Name = "ItemPanelPencarianData"
        Me.ItemPanelPencarianData.Size = New System.Drawing.Size(1308, 57)
        Me.ItemPanelPencarianData.TabIndex = 10
        Me.ItemPanelPencarianData.Text = "ItemPanel1"
        '
        'txtSearch
        '
        Me.txtSearch.FocusHighlightEnabled = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.TextBoxWidth = 50
        Me.txtSearch.Tooltip = "ketik nama yang dicari..."
        Me.txtSearch.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'ButtonItemSearch
        '
        Me.ButtonItemSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonItemSearch.FontBold = True
        Me.ButtonItemSearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ButtonItemSearch.Image = CType(resources.GetObject("ButtonItemSearch.Image"), System.Drawing.Image)
        Me.ButtonItemSearch.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.ButtonItemSearch.Name = "ButtonItemSearch"
        Me.ButtonItemSearch.PopupFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonItemSearch.Text = "Cari Data"
        Me.ButtonItemSearch.Tooltip = "Klik untuk mencari data"
        '
        'TabControl
        '
        Me.TabControl.BackColor = System.Drawing.Color.White
        Me.TabControl.CanReorderTabs = True
        Me.TabControl.Controls.Add(Me.TabControlPanel1)
        Me.TabControl.Controls.Add(Me.TabControlPanel2)
        Me.TabControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl.ForeColor = System.Drawing.Color.Black
        Me.TabControl.Location = New System.Drawing.Point(1, 84)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl.SelectedTabIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1306, 613)
        Me.TabControl.TabIndex = 11
        Me.TabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl.Tabs.Add(Me.TabItemData)
        Me.TabControl.Tabs.Add(Me.TabItemList)
        Me.TabControl.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel1)
        Me.TabControlPanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.MaximumSize = New System.Drawing.Size(0, 800)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1306, 587)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItemData
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnCalcAssetRp)
        Me.GroupPanel1.Controls.Add(Me.LabelX9)
        Me.GroupPanel1.Controls.Add(Me.txtHarga)
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.Controls.Add(Me.txtketerangan)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.txtstatusbarang)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.txtsumberdana)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.DateTimePickertglbeli)
        Me.GroupPanel1.Controls.Add(Me.lblMerk)
        Me.GroupPanel1.Controls.Add(Me.txtcaraperolehan)
        Me.GroupPanel1.Controls.Add(Me.lblnamaitem)
        Me.GroupPanel1.Controls.Add(Me.btnSearchkodeitem)
        Me.GroupPanel1.Controls.Add(Me.grouppanelRecored)
        Me.GroupPanel1.Controls.Add(Me.lblKodeGroup)
        Me.GroupPanel1.Controls.Add(Me.txtkodeitem)
        Me.GroupPanel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(10, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1092, 557)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "GroupPanel1"
        '
        'btnCalcAssetRp
        '
        Me.btnCalcAssetRp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCalcAssetRp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalcAssetRp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCalcAssetRp.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcAssetRp.Image = CType(resources.GetObject("btnCalcAssetRp.Image"), System.Drawing.Image)
        Me.btnCalcAssetRp.Location = New System.Drawing.Point(586, 12)
        Me.btnCalcAssetRp.Name = "btnCalcAssetRp"
        Me.btnCalcAssetRp.Size = New System.Drawing.Size(464, 303)
        Me.btnCalcAssetRp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCalcAssetRp.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1, Me.ItemContainer2})
        Me.btnCalcAssetRp.TabIndex = 66
        Me.btnCalcAssetRp.Text = "KALKULASI ASSET"
        Me.btnCalcAssetRp.Tooltip = "Klik Untuk Menghitung Penyusutan Item/barang Asset "
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        '
        '
        '
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer2.Name = "ItemContainer2"
        '
        '
        '
        Me.ItemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(20, 382)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(75, 23)
        Me.LabelX9.TabIndex = 65
        Me.LabelX9.Text = "Harga (Rp. )"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtHarga
        '
        Me.txtHarga.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHarga.Border.Class = "TextBoxBorder"
        Me.txtHarga.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHarga.ForeColor = System.Drawing.Color.Black
        Me.txtHarga.Location = New System.Drawing.Point(137, 378)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(411, 27)
        Me.txtHarga.TabIndex = 64
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(20, 315)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 23)
        Me.LabelX8.TabIndex = 63
        Me.LabelX8.Text = "Keterangan"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtketerangan
        '
        Me.txtketerangan.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtketerangan.Border.Class = "TextBoxBorder"
        Me.txtketerangan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtketerangan.ForeColor = System.Drawing.Color.Black
        Me.txtketerangan.Location = New System.Drawing.Point(137, 315)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtketerangan.Size = New System.Drawing.Size(411, 40)
        Me.txtketerangan.TabIndex = 62
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(20, 244)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 23)
        Me.LabelX7.TabIndex = 61
        Me.LabelX7.Text = "Status Barang"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtstatusbarang
        '
        Me.txtstatusbarang.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtstatusbarang.Border.Class = "TextBoxBorder"
        Me.txtstatusbarang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtstatusbarang.ForeColor = System.Drawing.Color.Black
        Me.txtstatusbarang.Location = New System.Drawing.Point(137, 244)
        Me.txtstatusbarang.Multiline = True
        Me.txtstatusbarang.Name = "txtstatusbarang"
        Me.txtstatusbarang.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtstatusbarang.Size = New System.Drawing.Size(411, 40)
        Me.txtstatusbarang.TabIndex = 60
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(20, 181)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 59
        Me.LabelX2.Text = "Sumber Dana"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtsumberdana
        '
        Me.txtsumberdana.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtsumberdana.Border.Class = "TextBoxBorder"
        Me.txtsumberdana.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtsumberdana.ForeColor = System.Drawing.Color.Black
        Me.txtsumberdana.Location = New System.Drawing.Point(137, 181)
        Me.txtsumberdana.Multiline = True
        Me.txtsumberdana.Name = "txtsumberdana"
        Me.txtsumberdana.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtsumberdana.Size = New System.Drawing.Size(411, 40)
        Me.txtsumberdana.TabIndex = 58
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(20, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 57
        Me.LabelX1.Text = "Tanggal Beli"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'DateTimePickertglbeli
        '
        '
        '
        '
        Me.DateTimePickertglbeli.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimePickertglbeli.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePickertglbeli.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimePickertglbeli.ButtonDropDown.Visible = True
        Me.DateTimePickertglbeli.IsPopupCalendarOpen = False
        Me.DateTimePickertglbeli.Location = New System.Drawing.Point(137, 8)
        '
        '
        '
        Me.DateTimePickertglbeli.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimePickertglbeli.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePickertglbeli.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimePickertglbeli.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimePickertglbeli.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimePickertglbeli.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimePickertglbeli.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimePickertglbeli.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimePickertglbeli.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimePickertglbeli.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimePickertglbeli.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePickertglbeli.MonthCalendar.DisplayMonth = New Date(2018, 11, 1, 0, 0, 0, 0)
        Me.DateTimePickertglbeli.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DateTimePickertglbeli.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimePickertglbeli.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimePickertglbeli.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimePickertglbeli.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimePickertglbeli.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePickertglbeli.MonthCalendar.TodayButtonVisible = True
        Me.DateTimePickertglbeli.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DateTimePickertglbeli.Name = "DateTimePickertglbeli"
        Me.DateTimePickertglbeli.Size = New System.Drawing.Size(111, 27)
        Me.DateTimePickertglbeli.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimePickertglbeli.TabIndex = 56
        '
        'lblMerk
        '
        Me.lblMerk.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblMerk.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMerk.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMerk.Location = New System.Drawing.Point(11, 123)
        Me.lblMerk.Name = "lblMerk"
        Me.lblMerk.Size = New System.Drawing.Size(84, 23)
        Me.lblMerk.TabIndex = 41
        Me.lblMerk.Text = "Cara Perolehan"
        Me.lblMerk.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtcaraperolehan
        '
        Me.txtcaraperolehan.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtcaraperolehan.Border.Class = "TextBoxBorder"
        Me.txtcaraperolehan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcaraperolehan.ForeColor = System.Drawing.Color.Black
        Me.txtcaraperolehan.Location = New System.Drawing.Point(137, 123)
        Me.txtcaraperolehan.Multiline = True
        Me.txtcaraperolehan.Name = "txtcaraperolehan"
        Me.txtcaraperolehan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtcaraperolehan.Size = New System.Drawing.Size(411, 40)
        Me.txtcaraperolehan.TabIndex = 40
        '
        'lblnamaitem
        '
        Me.lblnamaitem.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblnamaitem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblnamaitem.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamaitem.Location = New System.Drawing.Point(137, 90)
        Me.lblnamaitem.Name = "lblnamaitem"
        Me.lblnamaitem.Size = New System.Drawing.Size(363, 23)
        Me.lblnamaitem.TabIndex = 33
        Me.lblnamaitem.Text = "NamaItem"
        '
        'btnSearchkodeitem
        '
        Me.btnSearchkodeitem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearchkodeitem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearchkodeitem.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchkodeitem.Image = CType(resources.GetObject("btnSearchkodeitem.Image"), System.Drawing.Image)
        Me.btnSearchkodeitem.Location = New System.Drawing.Point(376, 57)
        Me.btnSearchkodeitem.Name = "btnSearchkodeitem"
        Me.btnSearchkodeitem.Size = New System.Drawing.Size(74, 27)
        Me.btnSearchkodeitem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearchkodeitem.TabIndex = 32
        Me.btnSearchkodeitem.Text = "Search"
        Me.btnSearchkodeitem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.btnSearchkodeitem.Tooltip = "Klik Untuk Mencari Data Group Item Asset"
        '
        'grouppanelRecored
        '
        Me.grouppanelRecored.BackColor = System.Drawing.Color.White
        Me.grouppanelRecored.CanvasColor = System.Drawing.SystemColors.Control
        Me.grouppanelRecored.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.grouppanelRecored.Controls.Add(Me.txtmodifiedby)
        Me.grouppanelRecored.Controls.Add(Me.txtlastmodified)
        Me.grouppanelRecored.Controls.Add(Me.txtcreateby)
        Me.grouppanelRecored.Controls.Add(Me.txtcreatedate)
        Me.grouppanelRecored.Controls.Add(Me.LabelX6)
        Me.grouppanelRecored.Controls.Add(Me.LabelX5)
        Me.grouppanelRecored.Controls.Add(Me.LabelX4)
        Me.grouppanelRecored.Controls.Add(Me.LabelX3)
        Me.grouppanelRecored.Location = New System.Drawing.Point(773, 347)
        Me.grouppanelRecored.Name = "grouppanelRecored"
        Me.grouppanelRecored.Size = New System.Drawing.Size(309, 177)
        '
        '
        '
        Me.grouppanelRecored.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.grouppanelRecored.Style.BackColorGradientAngle = 90
        Me.grouppanelRecored.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.grouppanelRecored.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grouppanelRecored.Style.BorderBottomWidth = 1
        Me.grouppanelRecored.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.grouppanelRecored.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grouppanelRecored.Style.BorderLeftWidth = 1
        Me.grouppanelRecored.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grouppanelRecored.Style.BorderRightWidth = 1
        Me.grouppanelRecored.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grouppanelRecored.Style.BorderTopWidth = 1
        Me.grouppanelRecored.Style.CornerDiameter = 4
        Me.grouppanelRecored.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.grouppanelRecored.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.grouppanelRecored.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.grouppanelRecored.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.grouppanelRecored.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.grouppanelRecored.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.grouppanelRecored.TabIndex = 31
        Me.grouppanelRecored.Text = "Recorded"
        '
        'txtmodifiedby
        '
        Me.txtmodifiedby.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtmodifiedby.Border.Class = "TextBoxBorder"
        Me.txtmodifiedby.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmodifiedby.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodifiedby.ForeColor = System.Drawing.Color.Black
        Me.txtmodifiedby.Location = New System.Drawing.Point(128, 113)
        Me.txtmodifiedby.Name = "txtmodifiedby"
        Me.txtmodifiedby.Size = New System.Drawing.Size(168, 21)
        Me.txtmodifiedby.TabIndex = 9
        '
        'txtlastmodified
        '
        Me.txtlastmodified.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtlastmodified.Border.Class = "TextBoxBorder"
        Me.txtlastmodified.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtlastmodified.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastmodified.ForeColor = System.Drawing.Color.Black
        Me.txtlastmodified.Location = New System.Drawing.Point(127, 79)
        Me.txtlastmodified.Name = "txtlastmodified"
        Me.txtlastmodified.Size = New System.Drawing.Size(168, 21)
        Me.txtlastmodified.TabIndex = 8
        '
        'txtcreateby
        '
        Me.txtcreateby.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtcreateby.Border.Class = "TextBoxBorder"
        Me.txtcreateby.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcreateby.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcreateby.ForeColor = System.Drawing.Color.Black
        Me.txtcreateby.Location = New System.Drawing.Point(127, 45)
        Me.txtcreateby.Name = "txtcreateby"
        Me.txtcreateby.Size = New System.Drawing.Size(168, 21)
        Me.txtcreateby.TabIndex = 7
        '
        'txtcreatedate
        '
        Me.txtcreatedate.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtcreatedate.Border.Class = "TextBoxBorder"
        Me.txtcreatedate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcreatedate.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcreatedate.ForeColor = System.Drawing.Color.Black
        Me.txtcreatedate.Location = New System.Drawing.Point(127, 12)
        Me.txtcreatedate.Name = "txtcreatedate"
        Me.txtcreatedate.Size = New System.Drawing.Size(168, 21)
        Me.txtcreatedate.TabIndex = 6
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(12, 111)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.TabIndex = 5
        Me.LabelX6.Text = "Modified By"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(12, 76)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = "Last Modified"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(12, 42)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Create By"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(12, 10)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Create Date"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblKodeGroup
        '
        Me.lblKodeGroup.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblKodeGroup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblKodeGroup.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeGroup.Location = New System.Drawing.Point(20, 61)
        Me.lblKodeGroup.Name = "lblKodeGroup"
        Me.lblKodeGroup.Size = New System.Drawing.Size(75, 23)
        Me.lblKodeGroup.TabIndex = 1
        Me.lblKodeGroup.Text = "Kode Item"
        Me.lblKodeGroup.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtkodeitem
        '
        Me.txtkodeitem.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtkodeitem.Border.Class = "TextBoxBorder"
        Me.txtkodeitem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtkodeitem.ForeColor = System.Drawing.Color.Black
        Me.txtkodeitem.Location = New System.Drawing.Point(137, 57)
        Me.txtkodeitem.Name = "txtkodeitem"
        Me.txtkodeitem.Size = New System.Drawing.Size(313, 27)
        Me.txtkodeitem.TabIndex = 0
        '
        'TabItemData
        '
        Me.TabItemData.AttachedControl = Me.TabControlPanel1
        Me.TabItemData.Name = "TabItemData"
        Me.TabItemData.Text = "Data"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.DataGridViewTransBeli)
        Me.TabControlPanel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(1306, 587)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItemList
        '
        'DataGridViewTransBeli
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTransBeli.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTransBeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTransBeli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTanggalBeli, Me.colKodeItem, Me.ColNamaItem, Me.ColCaraPerolehan, Me.ColSumberDana, Me.ColStatusBarang, Me.ColKeterangan, Me.ColHarga, Me.colD, Me.ColCreateDate, Me.ColCreateBy, Me.ColModifiedBy, Me.ColLastModified})
        Me.DataGridViewTransBeli.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTransBeli.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTransBeli.EnableHeadersVisualStyles = False
        Me.DataGridViewTransBeli.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewTransBeli.Location = New System.Drawing.Point(38, 19)
        Me.DataGridViewTransBeli.Name = "DataGridViewTransBeli"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTransBeli.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTransBeli.Size = New System.Drawing.Size(1225, 204)
        Me.DataGridViewTransBeli.TabIndex = 0
        '
        'colTanggalBeli
        '
        Me.colTanggalBeli.HeaderText = "Tanggal Beli"
        Me.colTanggalBeli.Name = "colTanggalBeli"
        '
        'colKodeItem
        '
        Me.colKodeItem.HeaderText = "Kode Item"
        Me.colKodeItem.Name = "colKodeItem"
        '
        'ColNamaItem
        '
        Me.ColNamaItem.HeaderText = "Nama Item"
        Me.ColNamaItem.Name = "ColNamaItem"
        '
        'ColCaraPerolehan
        '
        Me.ColCaraPerolehan.HeaderText = "Cara Perolehan"
        Me.ColCaraPerolehan.Name = "ColCaraPerolehan"
        '
        'ColSumberDana
        '
        Me.ColSumberDana.HeaderText = "Sumber Dana"
        Me.ColSumberDana.Name = "ColSumberDana"
        '
        'ColStatusBarang
        '
        Me.ColStatusBarang.HeaderText = "Status Barang"
        Me.ColStatusBarang.Name = "ColStatusBarang"
        '
        'ColKeterangan
        '
        Me.ColKeterangan.HeaderText = "Keterangan"
        Me.ColKeterangan.Name = "ColKeterangan"
        '
        'ColHarga
        '
        Me.ColHarga.HeaderText = "Harga (Rp.)"
        Me.ColHarga.Name = "ColHarga"
        '
        'colD
        '
        Me.colD.HeaderText = "id"
        Me.colD.Name = "colD"
        Me.colD.Visible = False
        '
        'ColCreateDate
        '
        Me.ColCreateDate.HeaderText = "Create Date"
        Me.ColCreateDate.Name = "ColCreateDate"
        '
        'ColCreateBy
        '
        Me.ColCreateBy.HeaderText = "Create By"
        Me.ColCreateBy.Name = "ColCreateBy"
        '
        'ColModifiedBy
        '
        Me.ColModifiedBy.HeaderText = "Modified By"
        Me.ColModifiedBy.Name = "ColModifiedBy"
        '
        'ColLastModified
        '
        Me.ColLastModified.HeaderText = "Last Modified"
        Me.ColLastModified.Name = "ColLastModified"
        '
        'TabItemList
        '
        Me.TabItemList.AttachedControl = Me.TabControlPanel2
        Me.TabItemList.Name = "TabItemList"
        Me.TabItemList.Text = "List"
        '
        'frmTransBeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.ItemPanelPencarianData)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmTransBeli"
        Me.Size = New System.Drawing.Size(1308, 690)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.DateTimePickertglbeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grouppanelRecored.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.DataGridViewTransBeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Button_Add As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button_Edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button_Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button_Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button_Copy As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button_Search As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button_Print As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button_Cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button_Load As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItemPanelPencarianData As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents txtSearch As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents ButtonItemSearch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TabControl As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblMerk As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtcaraperolehan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblnamaitem As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSearchkodeitem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents grouppanelRecored As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtmodifiedby As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtlastmodified As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtcreateby As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtcreatedate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblKodeGroup As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtkodeitem As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TabItemData As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents DataGridViewTransBeli As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabItemList As DevComponents.DotNetBar.TabItem
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DateTimePickertglbeli As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtketerangan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtstatusbarang As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtsumberdana As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtHarga As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents colTanggalBeli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKodeItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNamaItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCaraPerolehan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSumberDana As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStatusBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColKeterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCreateBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColModifiedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColLastModified As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCalcAssetRp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer

End Class
