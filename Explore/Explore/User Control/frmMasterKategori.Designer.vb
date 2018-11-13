<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterKategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasterKategori))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.txtSearch3 = New DevComponents.DotNetBar.TextBoxItem()
        Me.TextBoxItem1 = New DevComponents.DotNetBar.TextBoxItem()
        Me.ItemPanelPencarianData = New DevComponents.DotNetBar.ItemPanel()
        Me.txtSearch = New DevComponents.DotNetBar.TextBoxItem()
        Me.ButtonItemSearch = New DevComponents.DotNetBar.ButtonItem()
        Me.TabControl = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.grouppanelRecored = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtmodifiedby = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtlastmodified = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcreateby = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcreatedate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtnamaKategori = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblnamakategori = New DevComponents.DotNetBar.LabelX()
        Me.lblkodekategori = New DevComponents.DotNetBar.LabelX()
        Me.txtkodeKategori = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TabItemData = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.DataGridViewKategori = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.colKodeKategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNamaKategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCreateBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColModifiedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLastModified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabItemList = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.SuperValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator()
        Me.RequiredFieldValidator2 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.")
        Me.RequiredFieldValidator1 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.")
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.grouppanelRecored.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.DataGridViewKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Lime
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Button_Add, Me.Button_Edit, Me.Button_Save, Me.toolStripSeparator, Me.Button_Delete, Me.Button_Copy, Me.Button_Search, Me.Button_Print, Me.toolStripSeparator1, Me.Button_Cancel, Me.Button_Load})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1306, 25)
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
        'txtSearch3
        '
        Me.txtSearch3.FocusHighlightEnabled = True
        Me.txtSearch3.Name = "txtSearch3"
        Me.txtSearch3.TextBoxWidth = 50
        Me.txtSearch3.Tooltip = "ketik nama yang dicari..."
        Me.txtSearch3.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'TextBoxItem1
        '
        Me.TextBoxItem1.FocusHighlightEnabled = True
        Me.TextBoxItem1.Name = "TextBoxItem1"
        Me.TextBoxItem1.TextBoxWidth = 50
        Me.TextBoxItem1.Tooltip = "ketik nama yang dicari..."
        Me.TextBoxItem1.WatermarkColor = System.Drawing.SystemColors.GrayText
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
        Me.ItemPanelPencarianData.Size = New System.Drawing.Size(1306, 57)
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
        Me.TabControl.CanReorderTabs = True
        Me.TabControl.Controls.Add(Me.TabControlPanel1)
        Me.TabControl.Controls.Add(Me.TabControlPanel2)
        Me.TabControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl.Location = New System.Drawing.Point(3, 88)
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
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.grouppanelRecored)
        Me.GroupPanel1.Controls.Add(Me.txtnamaKategori)
        Me.GroupPanel1.Controls.Add(Me.lblnamakategori)
        Me.GroupPanel1.Controls.Add(Me.lblkodekategori)
        Me.GroupPanel1.Controls.Add(Me.txtkodeKategori)
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
        '
        '
        '
        Me.txtmodifiedby.Border.Class = "TextBoxBorder"
        Me.txtmodifiedby.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmodifiedby.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodifiedby.Location = New System.Drawing.Point(128, 113)
        Me.txtmodifiedby.Name = "txtmodifiedby"
        Me.txtmodifiedby.Size = New System.Drawing.Size(168, 21)
        Me.txtmodifiedby.TabIndex = 9
        '
        'txtlastmodified
        '
        '
        '
        '
        Me.txtlastmodified.Border.Class = "TextBoxBorder"
        Me.txtlastmodified.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtlastmodified.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastmodified.Location = New System.Drawing.Point(127, 79)
        Me.txtlastmodified.Name = "txtlastmodified"
        Me.txtlastmodified.Size = New System.Drawing.Size(168, 21)
        Me.txtlastmodified.TabIndex = 8
        '
        'txtcreateby
        '
        '
        '
        '
        Me.txtcreateby.Border.Class = "TextBoxBorder"
        Me.txtcreateby.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcreateby.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcreateby.Location = New System.Drawing.Point(127, 45)
        Me.txtcreateby.Name = "txtcreateby"
        Me.txtcreateby.Size = New System.Drawing.Size(168, 21)
        Me.txtcreateby.TabIndex = 7
        '
        'txtcreatedate
        '
        '
        '
        '
        Me.txtcreatedate.Border.Class = "TextBoxBorder"
        Me.txtcreatedate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcreatedate.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'txtnamaKategori
        '
        '
        '
        '
        Me.txtnamaKategori.Border.Class = "TextBoxBorder"
        Me.txtnamaKategori.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnamaKategori.Location = New System.Drawing.Point(167, 79)
        Me.txtnamaKategori.Multiline = True
        Me.txtnamaKategori.Name = "txtnamaKategori"
        Me.txtnamaKategori.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtnamaKategori.Size = New System.Drawing.Size(411, 56)
        Me.txtnamaKategori.TabIndex = 3
        Me.SuperValidator1.SetValidator1(Me.txtnamaKategori, Me.RequiredFieldValidator2)
        '
        'lblnamakategori
        '
        Me.lblnamakategori.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblnamakategori.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblnamakategori.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamakategori.Location = New System.Drawing.Point(15, 81)
        Me.lblnamakategori.Name = "lblnamakategori"
        Me.lblnamakategori.Size = New System.Drawing.Size(118, 23)
        Me.lblnamakategori.TabIndex = 2
        Me.lblnamakategori.Text = "Nama Kategori"
        Me.lblnamakategori.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblkodekategori
        '
        Me.lblkodekategori.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblkodekategori.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblkodekategori.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkodekategori.Location = New System.Drawing.Point(58, 37)
        Me.lblkodekategori.Name = "lblkodekategori"
        Me.lblkodekategori.Size = New System.Drawing.Size(75, 23)
        Me.lblkodekategori.TabIndex = 1
        Me.lblkodekategori.Text = "Kode Kategori"
        Me.lblkodekategori.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtkodeKategori
        '
        '
        '
        '
        Me.txtkodeKategori.Border.Class = "TextBoxBorder"
        Me.txtkodeKategori.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtkodeKategori.Location = New System.Drawing.Point(167, 34)
        Me.txtkodeKategori.Name = "txtkodeKategori"
        Me.txtkodeKategori.Size = New System.Drawing.Size(411, 27)
        Me.txtkodeKategori.TabIndex = 0
        Me.SuperValidator1.SetValidator1(Me.txtkodeKategori, Me.RequiredFieldValidator1)
        '
        'TabItemData
        '
        Me.TabItemData.AttachedControl = Me.TabControlPanel1
        Me.TabItemData.Name = "TabItemData"
        Me.TabItemData.Text = "Data"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.DataGridViewKategori)
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
        'DataGridViewKategori
        '
        Me.DataGridViewKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKategori.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colKodeKategori, Me.colNamaKategori, Me.colD, Me.ColCreateDate, Me.ColCreateBy, Me.ColModifiedBy, Me.ColLastModified})
        Me.DataGridViewKategori.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewKategori.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewKategori.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewKategori.Location = New System.Drawing.Point(38, 19)
        Me.DataGridViewKategori.Name = "DataGridViewKategori"
        Me.DataGridViewKategori.Size = New System.Drawing.Size(1200, 322)
        Me.SuperTooltip1.SetSuperTooltip(Me.DataGridViewKategori, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Double Klik untuk menampilkan data", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
        Me.DataGridViewKategori.TabIndex = 0
        '
        'colKodeKategori
        '
        Me.colKodeKategori.HeaderText = "Kode Kategori"
        Me.colKodeKategori.Name = "colKodeKategori"
        '
        'colNamaKategori
        '
        Me.colNamaKategori.HeaderText = "Nama Kategori"
        Me.colNamaKategori.Name = "colNamaKategori"
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
        'SuperValidator1
        '
        Me.SuperValidator1.ErrorProvider = Me.ErrorProvider1
        Me.SuperValidator1.Highlighter = Me.Highlighter1
        Me.SuperValidator1.SteppedValidation = True
        Me.SuperValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl
        '
        'RequiredFieldValidator2
        '
        Me.RequiredFieldValidator2.ErrorMessage = "Your error message here."
        Me.RequiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'RequiredFieldValidator1
        '
        Me.RequiredFieldValidator1.ErrorMessage = "Your error message here."
        Me.RequiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'frmMasterKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.ItemPanelPencarianData)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmMasterKategori"
        Me.Size = New System.Drawing.Size(1306, 688)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.grouppanelRecored.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.DataGridViewKategori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtSearch3 As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents TextBoxItem1 As DevComponents.DotNetBar.TextBoxItem
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
    Friend WithEvents txtnamaKategori As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblnamakategori As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblkodekategori As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtkodeKategori As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TabItemData As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents DataGridViewKategori As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabItemList As DevComponents.DotNetBar.TabItem
    Friend WithEvents colKodeKategori As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNamaKategori As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCreateBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColModifiedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColLastModified As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents SuperValidator1 As DevComponents.DotNetBar.Validator.SuperValidator
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents RequiredFieldValidator2 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Friend WithEvents RequiredFieldValidator1 As DevComponents.DotNetBar.Validator.RequiredFieldValidator

End Class
