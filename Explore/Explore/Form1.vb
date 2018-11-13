Imports DevComponents.DotNetBar
Imports System.Windows
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Data
Imports System
Imports System.Security.Cryptography
Imports System.Net.Sockets.Socket 'coba usb
Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports Explore.ModuleApp
Public Class Form1
    Inherits System.Windows.Forms.Form
    Private sBlockName As String
    Private xKoneksi As New SqlClient.SqlConnection
    Private xCommand As New SqlClient.SqlCommand
    Private xReader As SqlClient.SqlDataReader
    Public ConnectionString As String
    Public reader As SqlClient.SqlDataReader = Nothing
    Public conn As SqlClient.SqlConnection = Nothing
    Public cmd As SqlClient.SqlCommand = Nothing
    Public AlterTableBtn As System.Windows.Forms.Button
    Public GuidWahanaIDKey As Guid
    Public sql As String = Nothing
    Public StatusSimpanAdd As Boolean = False
    Public StatusSimpanModifiy As Boolean = False
    Public sqlconn As New SqlClient.SqlConnection
    Public StrSQLConnection As String
    Protected GuidWahana As String
    Public dgvWahana As DataSet
    Dim EntireFileDatabase As String
    Dim EntireFileServer As String
    Dim EntireFileUser As String
    Dim EntireFilePassword As String
    Public iTest As Integer = 0
    Public iTestOld As Integer = 0
    Public chrStatusSave As String = "ADD"
    Public idTable As String
    Public idTable2 As String
    Public cstrPeriodeYear As String
    Public SalesDateP As Date
    Public strDateTglLahir As Date
    Public strDateTglLapor As Date
    Public strDateTglTransaksi As Date
    Public iVScrollItem As Integer
    Private bindingSource1 As New BindingSource()
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ExplorerBar1.Location.Y = 90

        '  PanelNavigasi.VerticalScroll.Minimum = 300

        ' PanelNavigasi.VerticalScroll.Visible = True


        'isi status bar bottom dan  animasi header  
        LabelItemHeader.Text = " Sistem Informasi Management Asset Versi 2.2 --- Copyright @2018 By Solution Soft       "
        LabelItemHeader.BackColor = Color.Black
        LabelItemHeader.ForeColor = Color.Red
        Timer1.Start()
        ButtonKembaliSemula.Hide()
        FillStatusBarBottom()
        ' end status


        lblUser.Text = strFullName
        tampil_home()



        Dim grouphomeslider As ExplorerBarGroupItem = New ExplorerBarGroupItem("grouphome", "")
        grouphomeslider.Image = My.Resources.Preferences
        grouphomeslider.Tooltip = "Home"
        grouphomeslider.SetDefaultAppearance()

        ExplorerBarSlider.Groups.Add(grouphomeslider)
        Dim btnHomeSlider As ButtonItem = New ButtonItem("Home", "")
        btnHomeSlider.HotFontUnderline = True
        btnHomeSlider.HotTrackingStyle = eHotTrackingStyle.None
        btnHomeSlider.Icon = My.Resources.Bokehlicia_Captiva_Edit_gnote
        btnHomeSlider.ImagePosition = eImagePosition.Left
        btnHomeSlider.ButtonStyle = eButtonStyle.Default
        btnHomeSlider.Cursor = Cursors.Hand
        btnHomeSlider.Tooltip = "Home"
        grouphomeslider.SubItems.Add(btnHomeSlider)
        AddHandler btnHomeSlider.Click, AddressOf ButtonHomeItemSlider_Click


        SetupMainHeaderMenuSlider()


        Dim grouplogoutslider As ExplorerBarGroupItem = New ExplorerBarGroupItem("grouplogout", "")
        grouplogoutslider.Image = My.Resources.Preferences
        grouplogoutslider.Tooltip = "Logout"
        grouplogoutslider.SetDefaultAppearance()
        ExplorerBarSlider.Groups.Add(grouplogoutslider)
        ' Other Search Options
        Dim btnLogoutslider As ButtonItem = New ButtonItem("Logout", "")
        btnLogoutslider.HotFontUnderline = True
        btnLogoutslider.HotTrackingStyle = eHotTrackingStyle.None
        btnLogoutslider.Icon = My.Resources.Hopstarter_Soft_Scraps_User_Executive_Green
        btnLogoutslider.ImagePosition = eImagePosition.Left
        btnLogoutslider.ButtonStyle = eButtonStyle.ImageAndText
        btnLogoutslider.Cursor = Cursors.Hand
        btnLogoutslider.Tooltip = "Logout"
        grouplogoutslider.SubItems.Add(btnLogoutslider)
        AddHandler btnLogoutslider.Click, AddressOf ButtonLogout_Click



        Dim groupexitslider As ExplorerBarGroupItem = New ExplorerBarGroupItem("groupexit", "")
        groupexitslider.Image = My.Resources.Preferences
        groupexitslider.Tooltip = "Exit"
        groupexitslider.SetDefaultAppearance()
        ExplorerBarSlider.Groups.Add(groupexitslider)
        ' Other Search Options
        Dim btnExitslider As ButtonItem = New ButtonItem("Exit", "")
        btnExitslider.HotFontUnderline = True
        btnExitslider.HotTrackingStyle = eHotTrackingStyle.None
        btnExitslider.Image = My.Resources.power_off_icon_hi_0
        'btnExitslider.Icon = My.Resources.Hopstarter_Soft_Scraps_User_Executive_Green
        btnExitslider.ImagePosition = eImagePosition.Left
        btnExitslider.ButtonStyle = eButtonStyle.ImageAndText
        btnExitslider.Cursor = Cursors.Hand
        btnExitslider.Tooltip = "Exit"
        groupexitslider.SubItems.Add(btnExitslider)
        AddHandler btnExitslider.Click, AddressOf ButtonExit_Click



        ExplorerBarSlider.Hide()


        Dim grouphome As ExplorerBarGroupItem = New ExplorerBarGroupItem("grouphome", "Home")
        grouphome.SetDefaultAppearance()

        ExplorerBar1.Groups.Add(grouphome)
        Dim btnHome As ButtonItem = New ButtonItem("Home", "Home")
        btnHome.HotFontUnderline = True
        btnHome.HotTrackingStyle = eHotTrackingStyle.None
        btnHome.Icon = My.Resources.notes_8
        btnHome.ImagePosition = eImagePosition.Left
        btnHome.ButtonStyle = eButtonStyle.ImageAndText
        btnHome.Cursor = Cursors.Hand
        grouphome.SubItems.Add(btnHome)
        AddHandler btnHome.Click, AddressOf ButtonHomeItem_Click

        SetupMainHeaderMenu()


        Dim grouplogout As ExplorerBarGroupItem = New ExplorerBarGroupItem("grouplogout", "Logout")
        grouplogout.SetDefaultAppearance()
        ExplorerBar1.Groups.Add(grouplogout)
        ' Other Search Options
        Dim btnLogout As ButtonItem = New ButtonItem("Logout", "Logout")
        btnLogout.HotFontUnderline = True
        btnLogout.HotTrackingStyle = eHotTrackingStyle.None
        btnLogout.Icon = My.Resources.Hopstarter_Soft_Scraps_User_Executive_Green
        btnLogout.ImagePosition = eImagePosition.Left
        btnLogout.ButtonStyle = eButtonStyle.ImageAndText
        btnLogout.Cursor = Cursors.Hand
        grouplogout.SubItems.Add(btnLogout)
        AddHandler btnLogout.Click, AddressOf ButtonLogout_Click



        Dim groupexit As ExplorerBarGroupItem = New ExplorerBarGroupItem("groupexit", "EXIT")
        groupexit.SetDefaultAppearance()
        ExplorerBar1.Groups.Add(groupexit)
        ' Other Search Options
        Dim btnExit As ButtonItem = New ButtonItem("Exit", "Exit")
        btnExit.HotFontUnderline = True
        btnExit.HotTrackingStyle = eHotTrackingStyle.None
        btnExit.Image = My.Resources.power_off_icon_hi_0
        btnExit.ImagePosition = eImagePosition.Left
        btnExit.ButtonStyle = eButtonStyle.ImageAndText
        btnExit.Cursor = Cursors.Hand
        groupexit.SubItems.Add(btnExit)
        AddHandler btnExit.Click, AddressOf ButtonExit_Click


        'Dim grouphome As ExplorerBarGroupItem = New ExplorerBarGroupItem("grouphome", "Home")
        'grouphome.SetDefaultAppearance()
        'ExplorerBar1.Groups.Add(grouphome)
        'Dim btnHome As ButtonItem = New ButtonItem("Home", "Home")
        'btnHome.HotFontUnderline = True
        'btnHome.HotTrackingStyle = eHotTrackingStyle.None
        'btnHome.Icon = My.Resources.notes_8
        'btnHome.ImagePosition = eImagePosition.Left
        'btnHome.ButtonStyle = eButtonStyle.ImageAndText
        'btnHome.Cursor = Cursors.Hand
        'grouphome.SubItems.Add(btnHome)
        'AddHandler btnHome.Click, AddressOf ButtonHomeItem_Click



        'Dim group As ExplorerBarGroupItem = New ExplorerBarGroupItem("group1", "MASTER")
        'group.SetDefaultAppearance()
        'ExplorerBar1.Groups.Add(group)


        '' Other Search Options

        'Dim btn2 As ButtonItem = New ButtonItem("Menu1", "MasterKabupaten")
        'btn2.HotFontUnderline = True
        'btn2.HotTrackingStyle = eHotTrackingStyle.None
        'btn2.Icon = My.Resources.notes_8
        'btn2.ImagePosition = eImagePosition.Left
        'btn2.ButtonStyle = eButtonStyle.ImageAndText
        'btn2.Cursor = Cursors.Hand
        'group.SubItems.Add(btn2)
        'AddHandler btn2.Click, AddressOf ButtonItem_Click

        'btn2 = New ButtonItem("Menu1", "MasterKecamatan")
        'btn2.HotFontUnderline = True
        'btn2.HotTrackingStyle = eHotTrackingStyle.None
        'btn2.Icon = My.Resources.notes_8
        'btn2.ImagePosition = eImagePosition.Left
        'btn2.ButtonStyle = eButtonStyle.ImageAndText
        'btn2.Cursor = Cursors.Hand
        'group.SubItems.Add(btn2)
        'AddHandler btn2.Click, AddressOf ButtonItem_Click


        'btn2 = New ButtonItem("Menu1", "Modul3")
        'btn2.HotFontUnderline = True
        'btn2.HotTrackingStyle = eHotTrackingStyle.None
        'btn2.Icon = My.Resources.notes_8
        'btn2.ImagePosition = eImagePosition.Left
        'btn2.ButtonStyle = eButtonStyle.ImageAndText
        'btn2.Cursor = Cursors.Hand
        'group.SubItems.Add(btn2)
        'AddHandler btn2.Click, AddressOf ButtonItem_Click


        'Dim group2 As ExplorerBarGroupItem = New ExplorerBarGroupItem("group1", "TRANSACTION")
        'group2.SetDefaultAppearance()
        'ExplorerBar1.Groups.Add(group2)

        'btn2 = New ButtonItem("Menu2", "Modul4")
        'btn2.HotFontUnderline = True
        'btn2.HotTrackingStyle = eHotTrackingStyle.None
        'btn2.Icon = My.Resources.Bokehlicia_Captiva_Edit_gnote
        'btn2.ImagePosition = eImagePosition.Left
        'btn2.ButtonStyle = eButtonStyle.ImageAndText
        'btn2.Cursor = Cursors.Hand
        'group2.SubItems.Add(btn2)
        'AddHandler btn2.Click, AddressOf ButtonItem_Click

        'btn2 = New ButtonItem("Menu2", "Modul5")
        'btn2.HotFontUnderline = True
        'btn2.HotTrackingStyle = eHotTrackingStyle.None
        'btn2.Icon = My.Resources.Bokehlicia_Captiva_Edit_gnote
        'btn2.ImagePosition = eImagePosition.Left
        'btn2.ButtonStyle = eButtonStyle.ImageAndText
        'btn2.Cursor = Cursors.Hand
        'group2.SubItems.Add(btn2)
        'AddHandler btn2.Click, AddressOf ButtonItem_Click


        'btn2 = New ButtonItem("Menu2", "Modul6")
        'btn2.HotFontUnderline = True
        'btn2.HotTrackingStyle = eHotTrackingStyle.None
        'btn2.Icon = My.Resources.Bokehlicia_Captiva_Edit_gnote
        'btn2.ImagePosition = eImagePosition.Left
        'btn2.ButtonStyle = eButtonStyle.ImageAndText
        'btn2.Cursor = Cursors.Hand
        'group2.SubItems.Add(btn2)
        'AddHandler btn2.Click, AddressOf ButtonItem_Click



        'group = New ExplorerBarGroupItem("group3", "REPORT")
        'group.SetDefaultAppearance()
        'ExplorerBar1.Groups.Add(group)


        '' Other Search Options
        'Dim btn As ButtonItem = New ButtonItem("Menu3", "Report1")
        'btn.HotFontUnderline = True
        'btn.HotTrackingStyle = eHotTrackingStyle.None
        'btn.Image = My.Resources.Options
        'btn.ImagePosition = eImagePosition.Left
        'btn.ButtonStyle = eButtonStyle.ImageAndText
        'btn.Cursor = Cursors.Hand
        'group.SubItems.Add(btn)
        'AddHandler btn.Click, AddressOf ButtonItem_Click

        '' Change Preferences
        'btn = New ButtonItem("Menu3", "Report2")
        'btn.HotFontUnderline = True
        'btn.HotTrackingStyle = eHotTrackingStyle.None
        'btn.Image = My.Resources.Preferences
        'btn.ImagePosition = eImagePosition.Left
        'btn.ButtonStyle = eButtonStyle.ImageAndText
        'btn.Cursor = Cursors.Hand
        'group.SubItems.Add(btn)
        'AddHandler btn.Click, AddressOf ButtonItem_Click


        'Dim groupexit As ExplorerBarGroupItem = New ExplorerBarGroupItem("groupexit", "EXIT")
        'groupexit.SetDefaultAppearance()
        'ExplorerBar1.Groups.Add(groupexit)




        '' Other Search Options
        'Dim btnExit As ButtonItem = New ButtonItem("Exit", "Exit")
        'btnExit.HotFontUnderline = True
        'btnExit.HotTrackingStyle = eHotTrackingStyle.None
        'btnExit.Image = My.Resources.power_off_icon_hi_0
        'btnExit.ImagePosition = eImagePosition.Left
        'btnExit.ButtonStyle = eButtonStyle.ImageAndText
        'btnExit.Cursor = Cursors.Hand
        'groupexit.SubItems.Add(btnExit)
        'AddHandler btnExit.Click, AddressOf ButtonExit_Click




    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'tampil_home()
        ''   SetupBlok()
        'Dim groupexit As ExplorerBarGroupItem = New ExplorerBarGroupItem("groupexit", "EXIT")
        'groupexit.SetDefaultAppearance()
        'ExplorerBar1.Groups.Add(groupexit)
        '' Other Search Options
        'Dim btnExit As ButtonItem = New ButtonItem("Exit", "Exit")
        'btnExit.HotFontUnderline = True
        'btnExit.HotTrackingStyle = eHotTrackingStyle.None
        'btnExit.Image = My.Resources.power_off_icon_hi_0
        'btnExit.ImagePosition = eImagePosition.Left
        'btnExit.ButtonStyle = eButtonStyle.ImageAndText
        'btnExit.Cursor = Cursors.Hand
        'groupexit.SubItems.Add(btnExit)
        'AddHandler btnExit.Click, AddressOf ButtonExit_Click

    End Sub
    'Public Function Koneksi() As SqlConnection
    '    ' strCon = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Northwind;Data Source=riyulaptop"
    '    'strConnDB = System.Configuration.ConfigurationManager.AppSettings("sqlConnection").ToString
    '    'strMachineID = System.Configuration.ConfigurationManager.AppSettings("machine_id").ToString
    '    'strItemVoid = System.Configuration.ConfigurationManager.AppSettings("item_void").ToString
    '    strEntireFileServer = System.Configuration.ConfigurationManager.AppSettings("entireFileserver").ToString
    '    strEntireFileDatabase = System.Configuration.ConfigurationManager.AppSettings("EntireFileDatabase").ToString
    '    strEntireFileUser = System.Configuration.ConfigurationManager.AppSettings("EntireFileUser").ToString
    '    strEntireFilePassword = System.Configuration.ConfigurationManager.AppSettings("EntireFilePassword").ToString
    '    cstrDirectoryimageSource = System.Configuration.ConfigurationManager.AppSettings("cDirectoryimageSource").ToString
    '    cstrNamaPerusahaan = System.Configuration.ConfigurationManager.AppSettings("cNamaPerusahaan").ToString
    '    cstrLogoPerusahaan = System.Configuration.ConfigurationManager.AppSettings("cLogoPerusahaan").ToString
    '    '        cstrSQLKoneksi = "data source= " & strEntireFileServer & "; initial catalog = " & strEntireFileDatabase & ";integrated security=true;user id = " & strEntireFileUser & ";password = " & strEntireFilePassword & ";"
    '    cstrSQLKoneksi = "data source= " & strEntireFileServer & "; initial catalog = " & strEntireFileDatabase & ";user id = " & strEntireFileUser & ";password = " & strEntireFilePassword & "; Connect Timeout=200; pooling='true'; Max Pool Size=200;"
    '    cstrNamaPrinter = System.Configuration.ConfigurationManager.AppSettings("cNamaPrinter").ToString
    '    nIntPPn = Int(System.Configuration.ConfigurationManager.AppSettings("nPPnProsen").ToString)
    '    cstrDirectoryReport = System.Configuration.ConfigurationManager.AppSettings("cDirectoryReport").ToString
    '    cstrntgratedLogon = System.Configuration.ConfigurationManager.AppSettings("cIntegratedLogOn").ToString
    '    cCashierNumber = System.Configuration.ConfigurationManager.AppSettings("cChasierNo").ToString
    '    strAlamatPerusahaan = System.Configuration.ConfigurationManager.AppSettings("cAlamatPerusahaan").ToString
    '    cKodeTenant = System.Configuration.ConfigurationManager.AppSettings("cKodeTenant").ToString
    '    pstrNoISO = System.Configuration.ConfigurationManager.AppSettings("cstrNoReferISO").ToString
    '    '--baru utk lokasi logo form login 
    '    cLogoFormLogin = System.Configuration.ConfigurationManager.AppSettings("cImageLogoForm").ToString
    '    'baru utnuk nominal voucher rupiah
    '    nPubNominalVoucher = System.Configuration.ConfigurationManager.AppSettings("nNominalVoucher").ToString

    '    '--baru utk pilihan barcode reader --
    '    blnisuseBarCode = System.Configuration.ConfigurationManager.AppSettings("useBarCode").ToString
    '    blnisuseBarCodeAnggota = System.Configuration.ConfigurationManager.AppSettings("useBarCodeAnggota").ToString
    '    '-- baru utk cash drawer option --....
    '    blnisUseCashDrawer = System.Configuration.ConfigurationManager.AppSettings("useCashDrawer").ToString
    '    blnisOpenCashDrawerAfterPrint = System.Configuration.ConfigurationManager.AppSettings("OpenCashDrawerafterprint").ToString
    '    '---end cash drawer -------------------


    '    'baru untuk timer interval 1 dan timer interval 2
    '    pnIntervalTimer1 = System.Configuration.ConfigurationManager.AppSettings("nIntervalTimer1").ToString
    '    pnIntervalTimer2 = System.Configuration.ConfigurationManager.AppSettings("nIntervalTimer2").ToString


    '    'baru untuk zooming info report anggota koperasi 
    '    nPubZoomingReportInfo = System.Configuration.ConfigurationManager.AppSettings("nZoomingReport").ToString

    '    nPubExpiredDays = System.Configuration.ConfigurationManager.AppSettings("nExpiredDays").ToString

    '    Dim conn As New SqlConnection
    '    'conn = New SqlConnection("server=leows2pc,database=sales; user=sa;password=rahasia;")
    '    'conn = New SqlConnection("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=sales;Data Source=supplier;")
    '    'conn = New SqlConnection("data source=leows2pc;initial catalog = sales;integrated security=true;user id=sa;password=rahasia;")
    '    conn = New SqlConnection(cstrSQLKoneksi)
    '    conn.Open()
    '    Return conn

    'End Function

    'Private Sub koneksi()
    '    'EntireFileServer = "leows2pc"
    '    'EntireFileDatabase = "SALES"
    '    'EntireFileUser = "sa"
    '    'EntireFilePassword = "rahasia"
    '    'Dim strConnection As String = " server = " & EntireFileServer & " ;  " & " Database = " & EntireFileDatabase & " ;integrated security=true;user id = " & EntireFileUser & " ; password = " & EntireFilePassword
    '    If sqlconn.State = ConnectionState.Open Then
    '        sqlconn.Close()
    '    End If
    '    sqlconn.ConnectionString = cstrSQLKoneksi
    '    Try
    '        sqlconn.Open()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    Private Sub SetupMainHeaderMenu()
        Dim cstrSQL As String
        Dim cstrSQLsubmenu As String
        Dim sgroupname As String = ""
        cstrSQLsubmenu = ""
        'Dim cstrnamatenant As String



        'cstrSQL = " SELECT     name,  namaform FROM tbl_sub_menu WHERE     (menu_utama_id IN (SELECT     id FROM(tbl_menu_utama WHERE      (modul = 'camat') AND (name = 'master'))) " & _
        '" ORDER BY [order] "



        cstrSQL = " select name from tbl_menu_utama where modul = 'asset' order by [order]  "
        Dim ocmdGetBlock As SqlCommand = New SqlCommand(cstrSQL, ModuleApp.Koneksi)
        ocmdGetBlock.CommandTimeout = 8000
        ocmdGetBlock.CommandType = CommandType.Text
        'ocmdGetnamaTenant.ExecuteNonQuery()


        Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdGetBlock)
        Dim dsLasTransaction As New DataSet
        Dim oTblLasTransaction As New DataTable
        daLasTransaction.Fill(dsLasTransaction, "tbl_menu_blobk")
        oTblLasTransaction = dsLasTransaction.Tables("tbl_menu_blobk")
        Dim drLasTransaction As SqlDataReader
        drLasTransaction = ocmdGetBlock.ExecuteReader

        'flpanelBlok.Controls.Clear()
        Do
            While drLasTransaction.Read()

                sgroupname = LTrim(RTrim(drLasTransaction(0)))

                'asli Dim groupheader As ExplorerBarGroupItem = New ExplorerBarGroupItem(sgroupname, sgroupname)
                'asli  ExplorerBar1.Groups.Add(groupheader)

                'strPeriode = drLasTransaction(0)
                'intCounter = drLasTransaction(1)
                'strCounter21 = drLasTransaction(2)

                'Dim newItmButton As New Button()
                'With newItmButton
                '    '.Name = itemRow("iteminventorysubgroup_id")
                '    '.Text = itemRow("iteminventorysubgroup_name")
                '    .Name = drLasTransaction(0)
                '    .Text = drLasTransaction(0)
                '    .ForeColor = Color.White
                '    '.BackColor = Color.BlueViolet
                '    .BackColor = Color.Green
                '    .Height = 51
                '    .Width = 110
                '    .Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
                '    .FlatStyle = FlatStyle.Flat
                '    .FlatAppearance.MouseOverBackColor = Color.Salmon
                '    .FlatAppearance.BorderColor = Color.Black
                '    .FlatAppearance.BorderSize = 2

                'End With
                'AddHandler newItmButton.Click, AddressOf ButtonItem_Click
                '  flpanelBlok.Controls.Add(newItmButton)

                Dim groupheader As New ExplorerBarGroupItem
                ' = New ExplorerBarGroupItem(sgroupname, sgroupname)
                With groupheader
                    'Dim group As ExplorerBarGroupItem = New ExplorerBarGroupItem("group1", "MASTER")
                    'group.SetDefaultAppearance()
                    'ExplorerBar1.Groups.Add(group)
                    .Name = sgroupname
                    .Text = sgroupname
                    .Expanded = False
                End With
                groupheader.SetDefaultAppearance()
                ExplorerBar1.Groups.Add(groupheader)
                'isi sub menu dari group header
                ' SetupBlokRak(sgroupname)
                cstrSQLsubmenu = "SELECT     name,  namaform FROM tbl_sub_menu WHERE     menu_utama_id IN (SELECT     id FROM tbl_menu_utama " & _
                      " WHERE      modul = 'asset' AND name = '" & sgroupname & "') ORDER BY [order] "


                Dim ocmdBlokRak As SqlCommand = New SqlCommand(cstrSQLsubmenu, ModuleApp.Koneksi)
                ocmdBlokRak.CommandTimeout = 8000
                ocmdBlokRak.CommandType = CommandType.Text
                Dim daLasTransactionsubmenu As SqlDataAdapter = New SqlDataAdapter(ocmdBlokRak)
                Dim dsLasTransactionsubmenu As New DataSet
                Dim oTblLasTransactionsubmenu As New DataTable


                daLasTransactionsubmenu.Fill(dsLasTransactionsubmenu, "tbl_submenu")
                oTblLasTransactionsubmenu = dsLasTransactionsubmenu.Tables("tbl_submenu")
                Dim drLasTransactionsubmenu As SqlDataReader
                drLasTransactionsubmenu = ocmdBlokRak.ExecuteReader


                '  flpanelRak.Controls.Clear()
                Do
                    While drLasTransactionsubmenu.Read()
                        Dim btnsubmenu As ButtonItem = New ButtonItem
                        With btnsubmenu
                            .Name = drLasTransactionsubmenu(1)
                            .Text = drLasTransactionsubmenu(0)
                            .HotFontUnderline = True
                            .HotTrackingStyle = eHotTrackingStyle.None
                            .Image = My.Resources.Computer
                            .ImagePosition = eImagePosition.Left
                            .ButtonStyle = eButtonStyle.ImageAndText
                            .Cursor = Cursors.Hand
                        End With
                        ' btn2.Cursor = Cursors.Hand
                        groupheader.SubItems.Add(btnsubmenu)
                        AddHandler btnsubmenu.Click, AddressOf ButtonItem_Click

                        'Dim btn2 As ButtonItem = New ButtonItem("Menu1", "MasterKabupaten")
                        'btn2.HotFontUnderline = True
                        'btn2.HotTrackingStyle = eHotTrackingStyle.None
                        'btn2.Icon = My.Resources.notes_8
                        'btn2.ImagePosition = eImagePosition.Left
                        'btn2.ButtonStyle = eButtonStyle.ImageAndText
                        'btn2.Cursor = Cursors.Hand
                        'group.SubItems.Add(btn2)
                        'AddHandler btn2.Click, AddressOf ButtonItem_Click

                        'btn2 = New ButtonItem("Menu1", "MasterKecamatan")
                        'btn2.HotFontUnderline = True
                        'btn2.HotTrackingStyle = eHotTrackingStyle.None
                        'btn2.Icon = My.Resources.notes_8
                        'btn2.ImagePosition = eImagePosition.Left
                        'btn2.ButtonStyle = eButtonStyle.ImageAndText
                        'btn2.Cursor = Cursors.Hand
                        'group.SubItems.Add(btn2)
                        'AddHandler btn2.Click, AddressOf ButtonItem_Click


                        'strPeriode = drLasTransaction(0)
                        'intCounter = drLasTransaction(1)
                        'strCounter21 = drLasTransaction(2)

                        'Dim newItmButton As New Button()
                        'nBit = drLasTransaction(1)
                        'With newItmButton
                        '    '.Name = itemRow("iteminventorysubgroup_id")
                        '    '.Text = itemRow("iteminventorysubgroup_name")
                        '    .Name = drLasTransaction(0)
                        '    .Text = drLasTransaction(0)
                        '    .ForeColor = Color.White
                        '    '.BackColor = Color.BlueViolet
                        '    '.BackColor = Color.Blue       ------ original aslinya lho !
                        '    If nBit = 0 Then
                        '        .BackColor = Color.Blue
                        '    Else
                        '        .BackColor = Color.Red
                        '    End If

                        '    .Height = 51
                        '    .Width = 110
                        '    .Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
                        '    .FlatStyle = FlatStyle.Flat
                        '    .FlatAppearance.MouseOverBackColor = Color.Salmon
                        '    .FlatAppearance.BorderColor = Color.Black
                        '    .FlatAppearance.BorderSize = 2

                        'End With
                        'AddHandler newItmButton.Click, AddressOf ButtonItemRak_Click
                        'flpanelRak.Controls.Add(newItmButton)

                    End While
                Loop While drLasTransactionsubmenu.NextResult()

            End While
        Loop While drLasTransaction.NextResult()
    End Sub
    Private Sub SetupBlokRak(ByVal strBlok As String)
        Dim cstrSQL As String
        'Dim cstrnamatenant As String
        'cstrSQL = " select nama , status from tbl_rak  order by nama "
        'cstrSQL = "select case when tbl_rak.nama is null then '' else tbl_rak.nama end as nama ,case when tbl_rak.status is null then 0 else  tbl_rak.status end as status ,tbl_blok.nama from tbl_rak right join tbl_blok on tbl_blok.id = tbl_rak.blok_id"
        'cstrSQL = "select tbl_rak.nama,tbl_rak.status,tbl_blok.nama from tbl_rak inner join tbl_blok on tbl_blok.id = tbl_rak.blok_id where tbl_blok.nama = '" & LTrim(RTrim(strBlok)) & "'"


        cstrSQL = "SELECT     name,  namaform FROM tbl_sub_menu WHERE     menu_utama_id IN (SELECT     id FROM tbl_menu_utama " & _
                            " WHERE      modul = 'asset' AND name = 'master') ORDER BY [order] "



        Dim ocmdBlokRak As SqlCommand = New SqlCommand(cstrSQL, ModuleApp.Koneksi)

        ocmdBlokRak.CommandTimeout = 8000
        ocmdBlokRak.CommandType = CommandType.Text
        'ocmdGetnamaTenant.ExecuteNonQuery()

        Dim nBit As Integer
        Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdBlokRak)
        Dim dsLasTransaction As New DataSet
        Dim oTblLasTransaction As New DataTable
        daLasTransaction.Fill(dsLasTransaction, "tbl_Rak")
        oTblLasTransaction = dsLasTransaction.Tables("tbl_Rak")
        Dim drLasTransaction As SqlDataReader
        drLasTransaction = ocmdBlokRak.ExecuteReader


        '  flpanelRak.Controls.Clear()
        Do
            While drLasTransaction.Read()
                Dim btnsubmenu As ButtonItem = New ButtonItem
                With btnsubmenu
                    .Name = drLasTransaction(0)
                    .Text = drLasTransaction(1)
                    .HotFontUnderline = True
                    .HotTrackingStyle = eHotTrackingStyle.None
                    .Icon = My.Resources.notes_8
                    .ImagePosition = eImagePosition.Left
                    .ButtonStyle = eButtonStyle.ImageAndText
                    .Cursor = Cursors.Hand
                End With


                'Dim btn2 As ButtonItem = New ButtonItem("Menu1", "MasterKabupaten")
                'btn2.HotFontUnderline = True
                'btn2.HotTrackingStyle = eHotTrackingStyle.None
                'btn2.Icon = My.Resources.notes_8
                'btn2.ImagePosition = eImagePosition.Left
                'btn2.ButtonStyle = eButtonStyle.ImageAndText
                'btn2.Cursor = Cursors.Hand
                'group.SubItems.Add(btn2)
                'AddHandler btn2.Click, AddressOf ButtonItem_Click

                'btn2 = New ButtonItem("Menu1", "MasterKecamatan")
                'btn2.HotFontUnderline = True
                'btn2.HotTrackingStyle = eHotTrackingStyle.None
                'btn2.Icon = My.Resources.notes_8
                'btn2.ImagePosition = eImagePosition.Left
                'btn2.ButtonStyle = eButtonStyle.ImageAndText
                'btn2.Cursor = Cursors.Hand
                'group.SubItems.Add(btn2)
                'AddHandler btn2.Click, AddressOf ButtonItem_Click


                'strPeriode = drLasTransaction(0)
                'intCounter = drLasTransaction(1)
                'strCounter21 = drLasTransaction(2)

                'Dim newItmButton As New Button()
                'nBit = drLasTransaction(1)
                'With newItmButton
                '    '.Name = itemRow("iteminventorysubgroup_id")
                '    '.Text = itemRow("iteminventorysubgroup_name")
                '    .Name = drLasTransaction(0)
                '    .Text = drLasTransaction(0)
                '    .ForeColor = Color.White
                '    '.BackColor = Color.BlueViolet
                '    '.BackColor = Color.Blue       ------ original aslinya lho !
                '    If nBit = 0 Then
                '        .BackColor = Color.Blue
                '    Else
                '        .BackColor = Color.Red
                '    End If

                '    .Height = 51
                '    .Width = 110
                '    .Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
                '    .FlatStyle = FlatStyle.Flat
                '    .FlatAppearance.MouseOverBackColor = Color.Salmon
                '    .FlatAppearance.BorderColor = Color.Black
                '    .FlatAppearance.BorderSize = 2

                'End With
                'AddHandler newItmButton.Click, AddressOf ButtonItemRak_Click
                'flpanelRak.Controls.Add(newItmButton)

            End While
        Loop While drLasTransaction.NextResult()
    End Sub

    'Private Sub SetupBlok()
    '    Dim cstrSQL As String
    '    'Dim cstrnamatenant As String
    '    cstrSQL = " select name from tbl_menu_utama where modul = 'camat' order by [order]  "


    '    'cstrSQL = " SELECT     name,  namaform FROM tbl_sub_menu WHERE     (menu_utama_id IN (SELECT     id FROM(tbl_menu_utama WHERE      (modul = 'camat') AND (name = 'master'))) " & _
    '    '" ORDER BY [order] "

    '    Dim ocmdGetBlock As SqlCommand = New SqlCommand(cstrSQL, ModuleApp.Koneksi)
    '    ocmdGetBlock.CommandTimeout = 800
    '    ocmdGetBlock.CommandType = CommandType.Text
    '    'ocmdGetnamaTenant.ExecuteNonQuery()


    '    Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdGetBlock)
    '    Dim dsLasTransaction As New DataSet
    '    Dim oTblLasTransaction As New DataTable
    '    daLasTransaction.Fill(dsLasTransaction, "tbl_menu_blobk")
    '    oTblLasTransaction = dsLasTransaction.Tables("tbl_menu_blobk")
    '    Dim drLasTransaction As SqlDataReader
    '    drLasTransaction = ocmdGetBlock.ExecuteReader

    '    flpanelBlok.Controls.Clear()
    '    Do
    '        While drLasTransaction.Read()
    '            'strPeriode = drLasTransaction(0)
    '            'intCounter = drLasTransaction(1)
    '            'strCounter21 = drLasTransaction(2)

    '            Dim newItmButton As New Button()
    '            With newItmButton
    '                '.Name = itemRow("iteminventorysubgroup_id")
    '                '.Text = itemRow("iteminventorysubgroup_name")
    '                .Name = drLasTransaction(0)
    '                .Text = drLasTransaction(0)
    '                .ForeColor = Color.White
    '                '.BackColor = Color.BlueViolet
    '                .BackColor = Color.Green
    '                .Height = 51
    '                .Width = 110
    '                .Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
    '                .FlatStyle = FlatStyle.Flat
    '                .FlatAppearance.MouseOverBackColor = Color.Salmon
    '                .FlatAppearance.BorderColor = Color.Black
    '                .FlatAppearance.BorderSize = 2

    '            End With
    '            AddHandler newItmButton.Click, AddressOf ButtonItem_Click
    '            flpanelBlok.Controls.Add(newItmButton)

    '        End While
    '    Loop While drLasTransaction.NextResult()
    'End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub
    Private Sub ExplorerBar1_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ss As String
        Dim n As New ExplorerBarGroupItem
        Dim btn As New ButtonItem

        'Dim btn As Button = CType(sender, Button)



        'f_ViewNameInfo()

        '  ExplorerBar1.su
        'DotNetBarManager.Bars[“mybar”].Items[“myitem”]



        'ExplorerBar1.by 
        '  ss = ExplorerBar1.e   

        '        ss = ExplorerBar1.Parent.Name
        '    MsgBox(ss)
        ' ss=ExplorerBar1.Name. 
    End Sub
    Private Sub ButtonItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sBlockID As String = CType(sender, ButtonItem).Name
        sBlockName = CType(sender, ButtonItem).Text

        '  tampil_usercontrol(sBlockID)


        'Dim number As Integer = 8
        Select Case sBlockID
            Case "frmMasterLokasi"
                tampil_masterlokasi()
            Case "frmMasterKategori"
                tampil_masterkategori()
            Case "frmMasterKondisi"
                tampil_masterkondisi()
            Case "frmMasterItemGroup"
                tampil_masterItemGroup()
            Case "frmMasterItem"
                tampil_masterItem()
            Case "frmTransBeli"
                tampil_trans_beli()
            Case "frmTransTerima"
                tampil_trans_beli()




            Case Else
                Debug.WriteLine("Not between 1 and 10, inclusive")
        End Select

        ''  MsgBox("nama = " & sBlockName)
        'If sBlockName = "MasterKabupaten" Then
        '    tampil_masterlokasi()
        'End If


        'If sBlockName = "MasterKecamatan" Then
        '    tampil_masterkecamatan()
        'End If



        'tampil_masterkabupaten

        'MsgBox("ASSALAMUALIKUM ...." + sBlockName)
        'SetupBlokRak(sBlobkID)
        ''baru leo
        'InfoJmlRakKosong(LTrim(RTrim(sBlobkID)))

        'txtverifikasibloknomer.Text = LTrim(RTrim(CType(sender, Button).Text))
        'SetFormattingGridView()
        'gridBerwarna()
        'If txtQtyInput.Text = "" Then
        '    txtQtyInput.Text = 1
        'End If
        'DataGridViewSales.Rows.Add(sItemInvName, txtQtyInput.Text)
        'txtTotalQty.Text = Val(txtTotalQty.Text) + Val(txtQtyInput.Text)
        'txtQtyInput.Text = 1
    End Sub
    Private Sub ButtonItemSlider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sBlockID As String = CType(sender, ButtonItem).Name
        sBlockName = CType(sender, ButtonItem).Text

        '  tampil_usercontrol(sBlockID)


        'Dim number As Integer = 8
        Select Case sBlockID
            Case "frmMasterLokasi"
                tampil_masterlokasi_slider()
            Case "frmMasterKategori"
                tampil_masterkategori_slider()
            Case "frmMasterKondisi"
                tampil_masterkondisi_slider()
            Case "frmMasterItemGroup"
                tampil_masterItemGroup_slider()
            Case "frmMasterItem"
                tampil_masterItem_slider()
            Case "frmTransBeli"
                tampil_trans_beli_slider()
            Case "frmTransTerima"
                tampil_trans_terima_slider()

            Case Else
                Debug.WriteLine("Not between 1 and 10, inclusive")
        End Select






        ''  MsgBox("nama = " & sBlockName)
        'If sBlockName = "MasterKabupaten" Then
        '    tampil_masterlokasi()
        'End If


        'If sBlockName = "MasterKecamatan" Then
        '    tampil_masterkecamatan()
        'End If



        'tampil_masterkabupaten

        'MsgBox("ASSALAMUALIKUM ...." + sBlockName)
        'SetupBlokRak(sBlobkID)
        ''baru leo
        'InfoJmlRakKosong(LTrim(RTrim(sBlobkID)))

        'txtverifikasibloknomer.Text = LTrim(RTrim(CType(sender, Button).Text))
        'SetFormattingGridView()
        'gridBerwarna()
        'If txtQtyInput.Text = "" Then
        '    txtQtyInput.Text = 1
        'End If
        'DataGridViewSales.Rows.Add(sItemInvName, txtQtyInput.Text)
        'txtTotalQty.Text = Val(txtTotalQty.Text) + Val(txtQtyInput.Text)
        'txtQtyInput.Text = 1
    End Sub



    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormLoginNew.Dispose()
        Application.Exit()
    End Sub
    Private Sub ButtonHomeItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tampil_home()
    End Sub
    Private Sub ButtonHomeItemSlider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tampil_home_slider()
    End Sub

    Private Sub ButtonLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'tampil_login()
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
        End If
        'sqlconn.ConnectionString = cstrSQLKoneksi
        'Try
        '    sqlconn.Open()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        'FormLoginNew.Dispose()
        'Me.Visible = False
        'Me.Close()

        'For Each frm As Form In Application.OpenForms
        '    'If frm IsNot IsMdiChild Then
        '    frm.Close()
        '    'End If
        'Next frm
        'ExplorerBar1.Group 
        closeexpandedGroup()
        ExplorerBar1.Show()
        ExplorerBarSlider.Hide()
        tampil_home()
        Me.Hide()
        FormLoginNew.Show()
        'FormLoginNew.ShowDialog()
        FormLoginNew.BringToFront()

        FormLoginNew.UsernameTextBox.Text = ""
        FormLoginNew.PasswordTextBox.Text = ""

        ExplorerBar1.Show()
        ExplorerBarSlider.Hide()
        tampil_home()


    End Sub
    Private Sub closeexpandedGroup()
        'ExplorerBar1.  
        'ExplorerBar1.Groups.
        Dim a As New ExplorerBarGroupItem
        a.Expanded = False
        'MsgBox(ExplorerBar1.Name)
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'ExplorerBar1.MinimumSize.Height = 900
        'ExplorerBar1(Size)
        '204, 463

        'Dim panelnavigasi2 As New Object PanelNavigasi 
        'PanelNavigasi.MinimumSize = New Size(204, 600)
        '  PanelNavigasi.Do 
        ' RadDocking.SetFloatingLocation(container, new Point(300, 300));
        'RadDocking.SetFloatingLocation(container, new Point(300, 300));
        'RadDocking.SetFloatingSize(container, new Size(800, 600));
        '  PanelNavigasi.Dock.None = DockStyle.Right

        'Ukuran Form default = 1330, 616
        'width form 1330
        'height form 616

        'Ukuran panelContent default = 1112, 546
        'width form 1112
        'height form 546

        'jadi selisih antar form dan panelcontent adalah 
        'width   =  1330 - 1112 = 218
        'height  =  616  - 546  =  70   

        Dim widthForm As Integer = Me.Width
        Dim heightForm As Integer = Me.Height

        'datagrid
        'panelContent.Size = New Drawing.Size(widthForm - 218, heightForm - 70)
        'panelContent.Size = New Drawing.Size(1500, 546)
        'panelContent.Location = New Drawing.Point(210, 25)

        '        panelContent.Location = New Drawing.Point(212, 32)

        ''button
        'Button1.Size = New Drawing.Size(widthForm - 380, heightForm - 253)

        'panel navigasi size default : = 204, 463
        'ExplorerBar1 204, 460

        PanelNavigasi.Size = New Drawing.Size(204, 900)
        ExplorerBar1.Size = New Drawing.Size(204, 900)

        'frmMasterLokasi.Location = New Drawing.Point(400, 90)
        'frmMasterLokasi.TabControl.Size = New Drawing.Size(1500, 710)

    End Sub
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.WindowState = FormWindowState.Minimized
    'End Sub

    Private Sub ButtonMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Function ConvertHarIndo(ByVal strday As String) As String
        Dim strIndonesianamahari As String
        Select Case strday
            Case "Sunday"
                strIndonesianamahari = "Minggu"
            Case "Monday"
                strIndonesianamahari = "Senin"
            Case "Tuesday"
                strIndonesianamahari = "Selasa"
            Case "Wednesday"
                strIndonesianamahari = "Rabu"
            Case "Thursday"
                strIndonesianamahari = "Kamis"
            Case "Friday"
                strIndonesianamahari = "Jumat"
            Case "Saturday"
                strIndonesianamahari = "Sabtu"
        End Select

        Return strIndonesianamahari
    End Function
    Function GetNamaBulanHarIndo(ByVal intmonth As Integer) As String
        Dim strIndonesianamabulan As String
        Select Case intmonth
            Case 1
                strIndonesianamabulan = "Januari"
            Case 2
                strIndonesianamabulan = "Februari"
            Case 3
                strIndonesianamabulan = "Maret"
            Case 4
                strIndonesianamabulan = "April"
            Case 5
                strIndonesianamabulan = "Mei"
            Case 6
                strIndonesianamabulan = "Juni"
            Case 7
                strIndonesianamabulan = "Juli"
            Case 8
                strIndonesianamabulan = "Agustus"
            Case 9
                strIndonesianamabulan = "September"
            Case 10
                strIndonesianamabulan = "Oktober"
            Case 11
                strIndonesianamabulan = "November"
            Case 12
                strIndonesianamabulan = "Desember"

        End Select

        Return strIndonesianamabulan
    End Function
    Private Sub FillStatusBarBottom()
        Dim strIPAddress As String
        Dim strHostName As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()

        ToolStripPCName2.Text = "Nama PC : " & System.Net.Dns.GetHostName

        '        ToolStripSplitPCName.Text = System.Net.Dns.GetHostName


        ToolStripSplitUserName2.Text = " User : " & RTrim(LTrim(strFullName))


        ToolStripDayDate.Text = "Hari / Tanggal : " & ConvertHarIndo(WeekdayName(Weekday(Today))) & " / " & (Date.Today).Day & " " & GetNamaBulanHarIndo((Date.Today).Month) & " " & (Date.Today).Year
        'Me.ToolStripStatusLabel1.Text = " Tanggal : " & (Date.Today).Day & "-" & (Date.Today).Month & "-" & (Date.Today).Year
        'Me.ToolStripStatusLabel2.Text = " Hari : " & WeekdayName(Weekday(Today))
        'Me.ToolStripStatusLabel3.Text = " Jam : " & TimeString
        'ToolStripJam.Text = " Jam : " & TimeString

        ToolStripPerusahaan.Text = LTrim(RTrim(cstrNamaPerusahaan))

        ToolStripAddress.Text = strAlamatPerusahaan
    End Sub
    Private Sub ButtonSilder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSilder.Click

        While (PanelInfouser.Width > 46)
            PanelInfouser.Width -= 1
            ButtonKembaliSemula.Show()
            '  Button3.Show()
            '  button_tunggal_show()
        End While

        While (PanelNavigasi.Width > 46)
            PanelNavigasi.Width -= 1
            ButtonKembaliSemula.Show()
            '  Button3.Show()
            '   button_tunggal_show()
        End While
        ' tampil_home_slide()
        ExplorerBar1.Hide()
        ExplorerBarSlider.Show()
        tampil_home_slider()
    End Sub
    Private Sub ButtonKembaliSemula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKembaliSemula.Click
        While (PanelInfouser.Width < 200)
            PanelInfouser.Width += 1
            ButtonKembaliSemula.Hide()

            ' button_tunggal_hide()
        End While

        While (PanelNavigasi.Width < 200)
            PanelNavigasi.Width += 1
            ButtonKembaliSemula.Hide()

            ' button_tunggal_hide()
        End While

        ExplorerBar1.Show()
        ExplorerBarSlider.Hide()
        tampil_home()


    End Sub
    Private Sub SetupMainHeaderMenuSlider()
        Dim cstrSQL As String
        Dim cstrSQLsubmenu As String
        Dim sgroupname As String = ""
        cstrSQLsubmenu = ""
        'Dim cstrnamatenant As String



        'cstrSQL = " SELECT     name,  namaform FROM tbl_sub_menu WHERE     (menu_utama_id IN (SELECT     id FROM(tbl_menu_utama WHERE      (modul = 'camat') AND (name = 'master'))) " & _
        '" ORDER BY [order] "



        cstrSQL = " select name from tbl_menu_utama where modul = 'asset' order by [order]  "
        Dim ocmdGetBlock As SqlCommand = New SqlCommand(cstrSQL, ModuleApp.Koneksi)
        ocmdGetBlock.CommandTimeout = 8000
        ocmdGetBlock.CommandType = CommandType.Text
        'ocmdGetnamaTenant.ExecuteNonQuery()


        Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdGetBlock)
        Dim dsLasTransaction As New DataSet
        Dim oTblLasTransaction As New DataTable
        daLasTransaction.Fill(dsLasTransaction, "tbl_menu_blobk")
        oTblLasTransaction = dsLasTransaction.Tables("tbl_menu_blobk")
        Dim drLasTransaction As SqlDataReader
        drLasTransaction = ocmdGetBlock.ExecuteReader

        'flpanelBlok.Controls.Clear()
        Do
            While drLasTransaction.Read()

                sgroupname = LTrim(RTrim(drLasTransaction(0)))

                'asli Dim groupheader As ExplorerBarGroupItem = New ExplorerBarGroupItem(sgroupname, sgroupname)
                'asli  ExplorerBar1.Groups.Add(groupheader)

                'strPeriode = drLasTransaction(0)
                'intCounter = drLasTransaction(1)
                'strCounter21 = drLasTransaction(2)

                'Dim newItmButton As New Button()
                'With newItmButton
                '    '.Name = itemRow("iteminventorysubgroup_id")
                '    '.Text = itemRow("iteminventorysubgroup_name")
                '    .Name = drLasTransaction(0)
                '    .Text = drLasTransaction(0)
                '    .ForeColor = Color.White
                '    '.BackColor = Color.BlueViolet
                '    .BackColor = Color.Green
                '    .Height = 51
                '    .Width = 110
                '    .Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
                '    .FlatStyle = FlatStyle.Flat
                '    .FlatAppearance.MouseOverBackColor = Color.Salmon
                '    .FlatAppearance.BorderColor = Color.Black
                '    .FlatAppearance.BorderSize = 2

                'End With
                'AddHandler newItmButton.Click, AddressOf ButtonItem_Click
                '  flpanelBlok.Controls.Add(newItmButton)

                Dim groupheader As New ExplorerBarGroupItem
                ' = New ExplorerBarGroupItem(sgroupname, sgroupname)
                With groupheader
                    'Dim group As ExplorerBarGroupItem = New ExplorerBarGroupItem("group1", "MASTER")
                    'group.SetDefaultAppearance()
                    'ExplorerBar1.Groups.Add(group)
                    .Name = sgroupname
                    '  .Text = sgroupname
                    .Image = My.Resources.Preferences
                    .Tooltip = sgroupname
                    .Expanded = False
                End With
                groupheader.SetDefaultAppearance()
                ExplorerBarSlider.Groups.Add(groupheader)
                'isi sub menu dari group header
                ' SetupBlokRak(sgroupname)
                cstrSQLsubmenu = "SELECT     name,  namaform FROM tbl_sub_menu WHERE     menu_utama_id IN (SELECT     id FROM tbl_menu_utama " & _
                      " WHERE      modul = 'asset' AND name = '" & sgroupname & "') ORDER BY [order] "


                Dim ocmdBlokRak As SqlCommand = New SqlCommand(cstrSQLsubmenu, ModuleApp.Koneksi)
                ocmdBlokRak.CommandTimeout = 8000
                ocmdBlokRak.CommandType = CommandType.Text
                Dim daLasTransactionsubmenu As SqlDataAdapter = New SqlDataAdapter(ocmdBlokRak)
                Dim dsLasTransactionsubmenu As New DataSet
                Dim oTblLasTransactionsubmenu As New DataTable


                daLasTransactionsubmenu.Fill(dsLasTransactionsubmenu, "tbl_submenu")
                oTblLasTransactionsubmenu = dsLasTransactionsubmenu.Tables("tbl_submenu")
                Dim drLasTransactionsubmenu As SqlDataReader
                drLasTransactionsubmenu = ocmdBlokRak.ExecuteReader


                '  flpanelRak.Controls.Clear()
                Do
                    While drLasTransactionsubmenu.Read()
                        Dim btnsubmenu As ButtonItem = New ButtonItem
                        With btnsubmenu
                            .Name = drLasTransactionsubmenu(1)
                            ' .Text = drLasTransactionsubmenu(0)
                            .HotFontUnderline = True
                            .HotTrackingStyle = eHotTrackingStyle.None
                            .Image = My.Resources.Preferences
                            .ImagePosition = eImagePosition.Left
                            .ButtonStyle = eButtonStyle.ImageAndText
                            .Cursor = Cursors.Hand
                            .Tooltip = drLasTransactionsubmenu(0)
                        End With
                        ' btn2.Cursor = Cursors.Hand
                        groupheader.SubItems.Add(btnsubmenu)
                        AddHandler btnsubmenu.Click, AddressOf ButtonItemSlider_Click

                        'Dim btn2 As ButtonItem = New ButtonItem("Menu1", "MasterKabupaten")
                        'btn2.HotFontUnderline = True
                        'btn2.HotTrackingStyle = eHotTrackingStyle.None
                        'btn2.Icon = My.Resources.notes_8
                        'btn2.ImagePosition = eImagePosition.Left
                        'btn2.ButtonStyle = eButtonStyle.ImageAndText
                        'btn2.Cursor = Cursors.Hand
                        'group.SubItems.Add(btn2)
                        'AddHandler btn2.Click, AddressOf ButtonItem_Click

                        'btn2 = New ButtonItem("Menu1", "MasterKecamatan")
                        'btn2.HotFontUnderline = True
                        'btn2.HotTrackingStyle = eHotTrackingStyle.None
                        'btn2.Icon = My.Resources.notes_8
                        'btn2.ImagePosition = eImagePosition.Left
                        'btn2.ButtonStyle = eButtonStyle.ImageAndText
                        'btn2.Cursor = Cursors.Hand
                        'group.SubItems.Add(btn2)
                        'AddHandler btn2.Click, AddressOf ButtonItem_Click


                        'strPeriode = drLasTransaction(0)
                        'intCounter = drLasTransaction(1)
                        'strCounter21 = drLasTransaction(2)

                        'Dim newItmButton As New Button()
                        'nBit = drLasTransaction(1)
                        'With newItmButton
                        '    '.Name = itemRow("iteminventorysubgroup_id")
                        '    '.Text = itemRow("iteminventorysubgroup_name")
                        '    .Name = drLasTransaction(0)
                        '    .Text = drLasTransaction(0)
                        '    .ForeColor = Color.White
                        '    '.BackColor = Color.BlueViolet
                        '    '.BackColor = Color.Blue       ------ original aslinya lho !
                        '    If nBit = 0 Then
                        '        .BackColor = Color.Blue
                        '    Else
                        '        .BackColor = Color.Red
                        '    End If

                        '    .Height = 51
                        '    .Width = 110
                        '    .Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
                        '    .FlatStyle = FlatStyle.Flat
                        '    .FlatAppearance.MouseOverBackColor = Color.Salmon
                        '    .FlatAppearance.BorderColor = Color.Black
                        '    .FlatAppearance.BorderSize = 2

                        'End With
                        'AddHandler newItmButton.Click, AddressOf ButtonItemRak_Click
                        'flpanelRak.Controls.Add(newItmButton)

                    End While
                Loop While drLasTransactionsubmenu.NextResult()

            End While
        Loop While drLasTransaction.NextResult()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelItemHeader.Text = LabelItemHeader.Text.Substring(1) & LabelItemHeader.Text.Substring(0, 1)
        ToolStripJam.Text = " Jam : " & TimeOfDay
    End Sub
End Class
