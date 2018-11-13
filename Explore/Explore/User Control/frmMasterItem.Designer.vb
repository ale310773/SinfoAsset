<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterItem
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasterItem))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItemPanelPencarianData = New DevComponents.DotNetBar.ItemPanel()
        Me.txtSearch = New DevComponents.DotNetBar.TextBoxItem()
        Me.TabControl = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.textsearchgroupautocomplete = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtFileName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtLokasiFoto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblLokasiFoto = New DevComponents.DotNetBar.LabelX()
        Me.lblkategori = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.txtlimitumur = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbokategori = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbltype = New DevComponents.DotNetBar.LabelX()
        Me.txtType = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblMerk = New DevComponents.DotNetBar.LabelX()
        Me.txtMerk = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbllimitumur = New DevComponents.DotNetBar.LabelX()
        Me.lblkodebarcode = New DevComponents.DotNetBar.LabelX()
        Me.txtbarcode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtketerangan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblketerangan = New DevComponents.DotNetBar.LabelX()
        Me.lblnamagroup = New DevComponents.DotNetBar.LabelX()
        Me.grouppanelRecored = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtmodifiedby = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtlastmodified = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcreateby = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcreatedate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtnamaitem = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblnamaitem = New DevComponents.DotNetBar.LabelX()
        Me.txtkodeitem = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblkodeitem = New DevComponents.DotNetBar.LabelX()
        Me.lblKodeGroup = New DevComponents.DotNetBar.LabelX()
        Me.txtkodegroup = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TabItemData = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.DataGridViewItem = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.colKodeGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNamaGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKodeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNamaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColKeterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLimitUmur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColKategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMerk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLokasiFoto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFoto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCreateBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColModifiedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLastModified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabItemList = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.btngetpicture = New DevComponents.DotNetBar.ButtonX()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.lblGambarFoto = New DevComponents.DotNetBar.LabelX()
        Me.PictureBoxFotoAsset = New System.Windows.Forms.PictureBox()
        Me.btnSearchkodeGroup = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItemSearch = New DevComponents.DotNetBar.ButtonItem()
        Me.Button_Add = New System.Windows.Forms.ToolStripButton()
        Me.Button_Edit = New System.Windows.Forms.ToolStripButton()
        Me.Button_Save = New System.Windows.Forms.ToolStripButton()
        Me.Button_Delete = New System.Windows.Forms.ToolStripButton()
        Me.Button_Copy = New System.Windows.Forms.ToolStripButton()
        Me.Button_Search = New System.Windows.Forms.ToolStripButton()
        Me.Button_Print = New System.Windows.Forms.ToolStripButton()
        Me.Button_Cancel = New System.Windows.Forms.ToolStripButton()
        Me.Button_Load = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.grouppanelRecored.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.DataGridViewItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFotoAsset, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        Me.ItemPanelPencarianData.TabIndex = 9
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
        'TabControl
        '
        Me.TabControl.CanReorderTabs = True
        Me.TabControl.Controls.Add(Me.TabControlPanel1)
        Me.TabControl.Controls.Add(Me.TabControlPanel2)
        Me.TabControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl.Location = New System.Drawing.Point(1, 85)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl.SelectedTabIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1306, 613)
        Me.TabControl.TabIndex = 10
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
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.textsearchgroupautocomplete)
        Me.GroupPanel1.Controls.Add(Me.txtFileName)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.txtLokasiFoto)
        Me.GroupPanel1.Controls.Add(Me.lblLokasiFoto)
        Me.GroupPanel1.Controls.Add(Me.btngetpicture)
        Me.GroupPanel1.Controls.Add(Me.lblGambarFoto)
        Me.GroupPanel1.Controls.Add(Me.PictureBoxFotoAsset)
        Me.GroupPanel1.Controls.Add(Me.lblkategori)
        Me.GroupPanel1.Controls.Add(Me.LabelX14)
        Me.GroupPanel1.Controls.Add(Me.txtlimitumur)
        Me.GroupPanel1.Controls.Add(Me.cbokategori)
        Me.GroupPanel1.Controls.Add(Me.lbltype)
        Me.GroupPanel1.Controls.Add(Me.txtType)
        Me.GroupPanel1.Controls.Add(Me.lblMerk)
        Me.GroupPanel1.Controls.Add(Me.txtMerk)
        Me.GroupPanel1.Controls.Add(Me.lbllimitumur)
        Me.GroupPanel1.Controls.Add(Me.lblkodebarcode)
        Me.GroupPanel1.Controls.Add(Me.txtbarcode)
        Me.GroupPanel1.Controls.Add(Me.txtketerangan)
        Me.GroupPanel1.Controls.Add(Me.lblketerangan)
        Me.GroupPanel1.Controls.Add(Me.lblnamagroup)
        Me.GroupPanel1.Controls.Add(Me.btnSearchkodeGroup)
        Me.GroupPanel1.Controls.Add(Me.grouppanelRecored)
        Me.GroupPanel1.Controls.Add(Me.txtnamaitem)
        Me.GroupPanel1.Controls.Add(Me.lblnamaitem)
        Me.GroupPanel1.Controls.Add(Me.txtkodeitem)
        Me.GroupPanel1.Controls.Add(Me.lblkodeitem)
        Me.GroupPanel1.Controls.Add(Me.lblKodeGroup)
        Me.GroupPanel1.Controls.Add(Me.txtkodegroup)
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
        'textsearchgroupautocomplete
        '
        Me.textsearchgroupautocomplete.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.textsearchgroupautocomplete.Border.Class = "TextBoxBorder"
        Me.textsearchgroupautocomplete.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textsearchgroupautocomplete.ForeColor = System.Drawing.Color.Black
        Me.textsearchgroupautocomplete.Location = New System.Drawing.Point(234, 46)
        Me.textsearchgroupautocomplete.Name = "textsearchgroupautocomplete"
        Me.textsearchgroupautocomplete.Size = New System.Drawing.Size(216, 27)
        Me.textsearchgroupautocomplete.TabIndex = 55
        Me.textsearchgroupautocomplete.Visible = False
        '
        'txtFileName
        '
        Me.txtFileName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFileName.Border.Class = "TextBoxBorder"
        Me.txtFileName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFileName.ForeColor = System.Drawing.Color.Black
        Me.txtFileName.Location = New System.Drawing.Point(527, 370)
        Me.txtFileName.Multiline = True
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFileName.Size = New System.Drawing.Size(240, 57)
        Me.txtFileName.TabIndex = 54
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(600, 350)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(86, 16)
        Me.LabelX1.TabIndex = 53
        Me.LabelX1.Text = "File Name"
        '
        'txtLokasiFoto
        '
        Me.txtLokasiFoto.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtLokasiFoto.Border.Class = "TextBoxBorder"
        Me.txtLokasiFoto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLokasiFoto.ForeColor = System.Drawing.Color.Black
        Me.txtLokasiFoto.Location = New System.Drawing.Point(527, 454)
        Me.txtLokasiFoto.Multiline = True
        Me.txtLokasiFoto.Name = "txtLokasiFoto"
        Me.txtLokasiFoto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLokasiFoto.Size = New System.Drawing.Size(240, 62)
        Me.txtLokasiFoto.TabIndex = 52
        '
        'lblLokasiFoto
        '
        Me.lblLokasiFoto.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblLokasiFoto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblLokasiFoto.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLokasiFoto.Location = New System.Drawing.Point(600, 433)
        Me.lblLokasiFoto.Name = "lblLokasiFoto"
        Me.lblLokasiFoto.Size = New System.Drawing.Size(86, 15)
        Me.lblLokasiFoto.TabIndex = 51
        Me.lblLokasiFoto.Text = "Lokasi Foto"
        '
        'lblkategori
        '
        Me.lblkategori.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblkategori.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblkategori.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkategori.Location = New System.Drawing.Point(44, 389)
        Me.lblkategori.Name = "lblkategori"
        Me.lblkategori.Size = New System.Drawing.Size(51, 23)
        Me.lblkategori.TabIndex = 47
        Me.lblkategori.Text = "Kategori"
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.Location = New System.Drawing.Point(226, 349)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(89, 23)
        Me.LabelX14.TabIndex = 46
        Me.LabelX14.Text = "Tahun"
        '
        'txtlimitumur
        '
        Me.txtlimitumur.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtlimitumur.Border.Class = "TextBoxBorder"
        Me.txtlimitumur.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtlimitumur.ForeColor = System.Drawing.Color.Black
        Me.txtlimitumur.Location = New System.Drawing.Point(109, 346)
        Me.txtlimitumur.Name = "txtlimitumur"
        Me.txtlimitumur.Size = New System.Drawing.Size(115, 27)
        Me.txtlimitumur.TabIndex = 45
        '
        'cbokategori
        '
        Me.cbokategori.DisplayMember = "Text"
        Me.cbokategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbokategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbokategori.FormattingEnabled = True
        Me.cbokategori.ItemHeight = 21
        Me.cbokategori.Location = New System.Drawing.Point(109, 389)
        Me.cbokategori.Name = "cbokategori"
        Me.cbokategori.Size = New System.Drawing.Size(411, 27)
        Me.cbokategori.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbokategori.TabIndex = 44
        '
        'lbltype
        '
        Me.lbltype.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbltype.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbltype.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype.Location = New System.Drawing.Point(20, 495)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(75, 23)
        Me.lbltype.TabIndex = 43
        Me.lbltype.Text = "Type"
        Me.lbltype.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtType
        '
        Me.txtType.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtType.Border.Class = "TextBoxBorder"
        Me.txtType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtType.ForeColor = System.Drawing.Color.Black
        Me.txtType.Location = New System.Drawing.Point(109, 492)
        Me.txtType.Multiline = True
        Me.txtType.Name = "txtType"
        Me.txtType.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtType.Size = New System.Drawing.Size(411, 27)
        Me.txtType.TabIndex = 42
        '
        'lblMerk
        '
        Me.lblMerk.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblMerk.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMerk.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMerk.Location = New System.Drawing.Point(20, 434)
        Me.lblMerk.Name = "lblMerk"
        Me.lblMerk.Size = New System.Drawing.Size(75, 23)
        Me.lblMerk.TabIndex = 41
        Me.lblMerk.Text = "Merk"
        Me.lblMerk.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtMerk
        '
        Me.txtMerk.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMerk.Border.Class = "TextBoxBorder"
        Me.txtMerk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMerk.ForeColor = System.Drawing.Color.Black
        Me.txtMerk.Location = New System.Drawing.Point(109, 431)
        Me.txtMerk.Multiline = True
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMerk.Size = New System.Drawing.Size(411, 40)
        Me.txtMerk.TabIndex = 40
        '
        'lbllimitumur
        '
        Me.lbllimitumur.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbllimitumur.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbllimitumur.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllimitumur.Location = New System.Drawing.Point(6, 348)
        Me.lbllimitumur.Name = "lbllimitumur"
        Me.lbllimitumur.Size = New System.Drawing.Size(89, 23)
        Me.lbllimitumur.TabIndex = 39
        Me.lbllimitumur.Text = "Limit Umur Item"
        Me.lbllimitumur.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblkodebarcode
        '
        Me.lblkodebarcode.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblkodebarcode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblkodebarcode.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkodebarcode.Location = New System.Drawing.Point(20, 307)
        Me.lblkodebarcode.Name = "lblkodebarcode"
        Me.lblkodebarcode.Size = New System.Drawing.Size(75, 23)
        Me.lblkodebarcode.TabIndex = 37
        Me.lblkodebarcode.Text = "Kode Barcode"
        Me.lblkodebarcode.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtbarcode
        '
        Me.txtbarcode.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtbarcode.Border.Class = "TextBoxBorder"
        Me.txtbarcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtbarcode.ForeColor = System.Drawing.Color.Black
        Me.txtbarcode.Location = New System.Drawing.Point(109, 304)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(411, 27)
        Me.txtbarcode.TabIndex = 36
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
        Me.txtketerangan.Location = New System.Drawing.Point(109, 218)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtketerangan.Size = New System.Drawing.Size(413, 70)
        Me.txtketerangan.TabIndex = 35
        '
        'lblketerangan
        '
        Me.lblketerangan.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblketerangan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblketerangan.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblketerangan.Location = New System.Drawing.Point(33, 215)
        Me.lblketerangan.Name = "lblketerangan"
        Me.lblketerangan.Size = New System.Drawing.Size(62, 23)
        Me.lblketerangan.TabIndex = 34
        Me.lblketerangan.Text = "Keterangan"
        Me.lblketerangan.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblnamagroup
        '
        Me.lblnamagroup.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblnamagroup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblnamagroup.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamagroup.Location = New System.Drawing.Point(111, 42)
        Me.lblnamagroup.Name = "lblnamagroup"
        Me.lblnamagroup.Size = New System.Drawing.Size(75, 23)
        Me.lblnamagroup.TabIndex = 33
        Me.lblnamagroup.Text = "NamaGroup"
        '
        'grouppanelRecored
        '
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
        'txtnamaitem
        '
        Me.txtnamaitem.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtnamaitem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnamaitem.ForeColor = System.Drawing.Color.Black
        Me.txtnamaitem.Location = New System.Drawing.Point(109, 124)
        Me.txtnamaitem.Multiline = True
        Me.txtnamaitem.Name = "txtnamaitem"
        Me.txtnamaitem.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtnamaitem.Size = New System.Drawing.Size(413, 70)
        Me.txtnamaitem.TabIndex = 30
        '
        'lblnamaitem
        '
        Me.lblnamaitem.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblnamaitem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblnamaitem.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamaitem.Location = New System.Drawing.Point(33, 121)
        Me.lblnamaitem.Name = "lblnamaitem"
        Me.lblnamaitem.Size = New System.Drawing.Size(62, 23)
        Me.lblnamaitem.TabIndex = 29
        Me.lblnamaitem.Text = "Nama Item"
        Me.lblnamaitem.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.txtkodeitem.Location = New System.Drawing.Point(109, 77)
        Me.txtkodeitem.Name = "txtkodeitem"
        Me.txtkodeitem.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtkodeitem.Size = New System.Drawing.Size(411, 27)
        Me.txtkodeitem.TabIndex = 3
        '
        'lblkodeitem
        '
        Me.lblkodeitem.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblkodeitem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblkodeitem.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkodeitem.Location = New System.Drawing.Point(20, 76)
        Me.lblkodeitem.Name = "lblkodeitem"
        Me.lblkodeitem.Size = New System.Drawing.Size(75, 23)
        Me.lblkodeitem.TabIndex = 2
        Me.lblkodeitem.Text = "Kode Item"
        Me.lblkodeitem.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblKodeGroup
        '
        Me.lblKodeGroup.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblKodeGroup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblKodeGroup.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeGroup.Location = New System.Drawing.Point(20, 16)
        Me.lblKodeGroup.Name = "lblKodeGroup"
        Me.lblKodeGroup.Size = New System.Drawing.Size(75, 23)
        Me.lblKodeGroup.TabIndex = 1
        Me.lblKodeGroup.Text = "Kode Group"
        Me.lblKodeGroup.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtkodegroup
        '
        Me.txtkodegroup.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtkodegroup.Border.Class = "TextBoxBorder"
        Me.txtkodegroup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtkodegroup.ForeColor = System.Drawing.Color.Black
        Me.txtkodegroup.Location = New System.Drawing.Point(109, 13)
        Me.txtkodegroup.Name = "txtkodegroup"
        Me.txtkodegroup.Size = New System.Drawing.Size(411, 27)
        Me.txtkodegroup.TabIndex = 0
        '
        'TabItemData
        '
        Me.TabItemData.AttachedControl = Me.TabControlPanel1
        Me.TabItemData.Name = "TabItemData"
        Me.TabItemData.Text = "Data"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.DataGridViewItem)
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
        'DataGridViewItem
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colKodeGroup, Me.colNamaGroup, Me.colKodeItem, Me.ColNamaItem, Me.ColKeterangan, Me.ColBarcode, Me.ColLimitUmur, Me.ColKategori, Me.ColMerk, Me.ColType, Me.ColLokasiFoto, Me.ColFoto, Me.colD, Me.ColCreateDate, Me.ColCreateBy, Me.ColModifiedBy, Me.ColLastModified})
        Me.DataGridViewItem.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewItem.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewItem.EnableHeadersVisualStyles = False
        Me.DataGridViewItem.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewItem.Location = New System.Drawing.Point(38, 19)
        Me.DataGridViewItem.Name = "DataGridViewItem"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewItem.Size = New System.Drawing.Size(1200, 481)
        Me.DataGridViewItem.TabIndex = 0
        '
        'colKodeGroup
        '
        Me.colKodeGroup.HeaderText = "Kode Group"
        Me.colKodeGroup.Name = "colKodeGroup"
        '
        'colNamaGroup
        '
        Me.colNamaGroup.HeaderText = "Nama Group"
        Me.colNamaGroup.Name = "colNamaGroup"
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
        'ColKeterangan
        '
        Me.ColKeterangan.HeaderText = "Keterangan"
        Me.ColKeterangan.Name = "ColKeterangan"
        '
        'ColBarcode
        '
        Me.ColBarcode.HeaderText = "Barcode"
        Me.ColBarcode.Name = "ColBarcode"
        '
        'ColLimitUmur
        '
        Me.ColLimitUmur.HeaderText = "Limit Umur"
        Me.ColLimitUmur.Name = "ColLimitUmur"
        '
        'ColKategori
        '
        Me.ColKategori.HeaderText = "Kategori"
        Me.ColKategori.Name = "ColKategori"
        '
        'ColMerk
        '
        Me.ColMerk.HeaderText = "Merk"
        Me.ColMerk.Name = "ColMerk"
        '
        'ColType
        '
        Me.ColType.HeaderText = "Type"
        Me.ColType.Name = "ColType"
        '
        'ColLokasiFoto
        '
        Me.ColLokasiFoto.HeaderText = "LokasiFoto"
        Me.ColLokasiFoto.Name = "ColLokasiFoto"
        '
        'ColFoto
        '
        Me.ColFoto.HeaderText = "Foto"
        Me.ColFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.ColFoto.Name = "ColFoto"
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
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'btngetpicture
        '
        Me.btngetpicture.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btngetpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btngetpicture.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btngetpicture.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngetpicture.Image = CType(resources.GetObject("btngetpicture.Image"), System.Drawing.Image)
        Me.btngetpicture.Location = New System.Drawing.Point(1002, 7)
        Me.btngetpicture.Name = "btngetpicture"
        Me.btngetpicture.Size = New System.Drawing.Size(80, 35)
        Me.btngetpicture.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btngetpicture.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1, Me.ItemContainer2})
        Me.btngetpicture.TabIndex = 50
        Me.btngetpicture.Text = "Ambil Foto"
        Me.btngetpicture.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right
        Me.btngetpicture.Tooltip = "Klik Untuk Mencari File Gambar/Foto"
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
        'lblGambarFoto
        '
        Me.lblGambarFoto.BackColor = System.Drawing.Color.Transparent
        Me.lblGambarFoto.BackgroundImage = Global.Explore.My.Resources.Resources.WinDesktop
        '
        '
        '
        Me.lblGambarFoto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblGambarFoto.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGambarFoto.ForeColor = System.Drawing.Color.White
        Me.lblGambarFoto.Location = New System.Drawing.Point(527, 19)
        Me.lblGambarFoto.Name = "lblGambarFoto"
        Me.lblGambarFoto.Size = New System.Drawing.Size(555, 23)
        Me.lblGambarFoto.TabIndex = 49
        Me.lblGambarFoto.Text = "FOTO"
        Me.lblGambarFoto.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PictureBoxFotoAsset
        '
        Me.PictureBoxFotoAsset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxFotoAsset.Location = New System.Drawing.Point(527, 42)
        Me.PictureBoxFotoAsset.Name = "PictureBoxFotoAsset"
        Me.PictureBoxFotoAsset.Size = New System.Drawing.Size(555, 298)
        Me.PictureBoxFotoAsset.TabIndex = 48
        Me.PictureBoxFotoAsset.TabStop = False
        '
        'btnSearchkodeGroup
        '
        Me.btnSearchkodeGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearchkodeGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearchkodeGroup.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchkodeGroup.Image = CType(resources.GetObject("btnSearchkodeGroup.Image"), System.Drawing.Image)
        Me.btnSearchkodeGroup.Location = New System.Drawing.Point(449, 14)
        Me.btnSearchkodeGroup.Name = "btnSearchkodeGroup"
        Me.btnSearchkodeGroup.Size = New System.Drawing.Size(74, 27)
        Me.btnSearchkodeGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearchkodeGroup.TabIndex = 32
        Me.btnSearchkodeGroup.Text = "Search"
        Me.btnSearchkodeGroup.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.btnSearchkodeGroup.Tooltip = "Klik Untuk Mencari Data Group Item Asset"
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
        'frmMasterItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.ItemPanelPencarianData)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmMasterItem"
        Me.Size = New System.Drawing.Size(1308, 690)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.grouppanelRecored.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.DataGridViewItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFotoAsset, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grouppanelRecored As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtmodifiedby As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtlastmodified As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtcreateby As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtcreatedate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents txtnamaitem As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents lblnamaitem As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtkodeitem As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblkodeitem As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblKodeGroup As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtkodegroup As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TabItemData As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents DataGridViewItem As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabItemList As DevComponents.DotNetBar.TabItem
    Friend WithEvents btnSearchkodeGroup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblnamagroup As DevComponents.DotNetBar.LabelX
    Private WithEvents txtketerangan As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents lblketerangan As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbllimitumur As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblkodebarcode As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtbarcode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbltype As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtType As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblMerk As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMerk As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbokategori As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtlimitumur As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblkategori As DevComponents.DotNetBar.LabelX
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBoxFotoAsset As System.Windows.Forms.PictureBox
    Friend WithEvents lblGambarFoto As DevComponents.DotNetBar.LabelX
    Friend WithEvents btngetpicture As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents lblLokasiFoto As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtLokasiFoto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFileName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents textsearchgroupautocomplete As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents colKodeGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNamaGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKodeItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNamaItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColKeterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColLimitUmur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColKategori As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMerk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColLokasiFoto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFoto As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCreateBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColModifiedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColLastModified As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
