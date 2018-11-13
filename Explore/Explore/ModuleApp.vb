Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows
Imports System.Windows.Forms
Imports System.Management
Imports System.Reflection
Module ModuleApp
    'demo only for demo ...
    Dim home As New Home
    Dim Login As New Login
    Dim frmMasterLokasi As New frmMasterLokasi
    Dim frmMasterKategori As New frmMasterKategori
    Dim frmMasterKondisi As New frmMasterKondisi
    Dim frmMasterItemGroup As New frmMasterItemGroup
    Dim frmMasterItem As New frmMasterItem
    Dim frmTransBeli As New frmTransBeli
    Dim frmTransTerima As New frmTransTerima

    Public pVerfikasi As Boolean = False
    'demo only for demo ...


    Public nIntegeraddrowWODetail As Integer = 0

    Public cStrsearch As String = ""
    Public blnOKSearch As Boolean = False
    Public cStrColumnSearch As String = ""
    Public cstruserLogin As String = ""
    Public strConnection As String = ""
    Public conn As SqlConnection
    Public strUser As String
    Public strPassword As String
    Public GuidUserID As String
    Public strFullName As String
    Public strGetPassword As String
    Public strNamaTenant As String
    Public strDateSales As Date
    Public strEntireFileDatabase As String
    Public strEntireFileServer As String
    Public strEntireFileUser As String
    Public strEntireFilePassword As String
    Public strPrinterPort As String
    Public comPrinter As IO.Ports.SerialPort
    Public strConnServer As String
    Public cstrSQLKoneksi As String
    Public cstrDirectoryimageSource As String
    Public cstrNamaPerusahaan As String
    Public cstrLogoPerusahaan As String
    Public cstrImageLoginForm As String
    Public cstrDirectoryReport As String
    Public cstrntgratedLogon As String
    Public cstrNamaPrinter As String
    Public nDecCalculator As Decimal
    Public nIntPPn As Integer
    Public cCashierNumber As String
    Public nLineNo As Integer = 0

    Public nInputAmount As Decimal
    Public nStockItemDisplay As Decimal


    Public blnisUseCashDrawer As Boolean
    Public blnisOpenCashDrawerAfterPrint As Boolean
    Public cKodeMenuPrefix1 As String
    Public cKodeMenuPrefix2 As String
    Public cLogoFormLogin As String
    Public strConnPOS1 As String
    Public strConnPOS2 As String
    Public blnIsVoucher As Boolean = False        'baru untuk voucher nominal rupiah 
    Public nDecTotalTransaksiSalesVerifiy As Decimal = 0
    Public nPubNominalVoucher As Decimal
    Public nPubTotalNominalVoucher As Decimal = 0 'baru utk POS Kantin TSB hitung jml qty X nominal vouchernya simpan di dalam variabel Public TotalNominalVoucher
    Public nPubQtyVoucher As Decimal = 0 'baru utk POS Kantin TSB hitung jml qty X nominal vouchernya simpan di dalam variabel Public TotalNominalVoucher
    Public nPubDiscountPercent As Decimal
    Public nPubDiscountNominal As Decimal
    Public nPubSelisihVoucher As Decimal
    Public nPubSalesVoucher As Decimal = 0
    Public blnisuseBarCode As Boolean
    Public cKodeTenant As String = ""
    Public cStrNamaTenant As String = ""
    Public nDenda As Decimal
    Public cPubKodeItem As String
    Public nPubSetKodeItem As Integer
    Public cstrPCUNIQUEID As String
    Public originalGuid As Guid = Guid.NewGuid()
    Public nPubIsUseCustomerID As Integer = 0
    Public nPubIsUsePaymentEntry As Integer = 0
    Public strAlamatPerusahaan As String
    Public DR As SqlDataReader
    Public pNoRegistrasi As String = ""
    Public pNoWorkOrder As String = ""
    Public pstrPersonalIT As String = ""
    Public pstrNoISO As String = ""
    Public pstrNomerAnggota As String = ""
    Public pstrKodeItem As String = ""

    Public pstrKodeGroup As String = ""
    Public pstrKodeKabupaten As String = ""
    Public pstrKodeKecamatan As String = ""
    Public pstrKodeBidangTugas As String = ""
    Public pstrKodeSubBidangTugas As String = ""
    Public pstrKodeRincianTugas As String = ""
    Public pstrKodeLaporan As String = ""
    Public pCallSearchLaporan As String = ""  ' digunakan untuk menfecek pemanggil search laporan di tindakan tua atau arahan



    Public pstrSubMenuID As String
    Public pstrNamaMenu As String = ""
    Public pstrNamaMenuUtama As String = ""
    Public pstrNamaForm As String = ""
    Public pstrDeskripsiMenu As String = ""
    Public pnIntOrder As Integer = 0
    Public pstrNomerReference As String = ""
    Public pstrTransaksiDetilID As String = ""
    Public pnIntervalTimer1 As Integer = 0
    Public pnIntervalTimer2 As Integer = 0
    Public nPubZoomingReportInfo As Integer = 0
    Public nPubExpiredDays As Integer = 0
    Public nPubJmlDataInfoAnggotaKoperasi = 0
    Public blnisuseBarCodeAnggota As Boolean
    Public dtTglPotongVer As DateTime
    Public nNominalTimeOut2 As Integer = 90000
    Public pstrReferenceNoReprint As String = ""

    'baru untuk POS Mini Market ..21 Juli 2017
    Public strTipePembayaranVisitor As String = "CASH" 'defaultnya Tipe = 'CASH; selain itu tipe = 'CREDIT'
    'Public strTipePembayaranVisitor As String = "" 'defaultnya Tipe = 'CASH; selain itu tipe = 'CREDIT'


    'baru utk TSB mini market kontrol stock
    Public pstrItemcodeDetail As String = ""
    Public pstrNamaItemDetail As String = ""
    Public pDecStockItem As Decimal = 0
    Public ptgldateverify As DateTime
    Public pstrKodeWarehouse As String = ""

    'baru untuk Edit Viewlist Transfer ITem  22 jan 2018
    Public pStatusAddEditTransferItem As String = ""
    Public pstrtransferitemid As String = ""
    Public pstrtransferitemNo As String = ""
    Public Function Koneksi() As SqlConnection
        ' strCon = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Northwind;Data Source=riyulaptop"
        'strConnDB = System.Configuration.ConfigurationManager.AppSettings("sqlConnection").ToString
        'strMachineID = System.Configuration.ConfigurationManager.AppSettings("machine_id").ToString
        'strItemVoid = System.Configuration.ConfigurationManager.AppSettings("item_void").ToString
        strEntireFileServer = System.Configuration.ConfigurationManager.AppSettings("entireFileserver").ToString
        strEntireFileDatabase = System.Configuration.ConfigurationManager.AppSettings("EntireFileDatabase").ToString
        strEntireFileUser = System.Configuration.ConfigurationManager.AppSettings("EntireFileUser").ToString
        strEntireFilePassword = System.Configuration.ConfigurationManager.AppSettings("EntireFilePassword").ToString
        cstrDirectoryimageSource = System.Configuration.ConfigurationManager.AppSettings("cDirectoryimageSource").ToString
        cstrNamaPerusahaan = System.Configuration.ConfigurationManager.AppSettings("cNamaPerusahaan").ToString
        cstrLogoPerusahaan = System.Configuration.ConfigurationManager.AppSettings("cLogoPerusahaan").ToString
        '        cstrSQLKoneksi = "data source= " & strEntireFileServer & "; initial catalog = " & strEntireFileDatabase & ";integrated security=true;user id = " & strEntireFileUser & ";password = " & strEntireFilePassword & ";"
        cstrSQLKoneksi = "data source= " & strEntireFileServer & "; initial catalog = " & strEntireFileDatabase & ";user id = " & strEntireFileUser & ";password = " & strEntireFilePassword & "; Connect Timeout=200; pooling='true'; Max Pool Size=200;"
        cstrNamaPrinter = System.Configuration.ConfigurationManager.AppSettings("cNamaPrinter").ToString
        nIntPPn = Int(System.Configuration.ConfigurationManager.AppSettings("nPPnProsen").ToString)
        cstrDirectoryReport = System.Configuration.ConfigurationManager.AppSettings("cDirectoryReport").ToString
        cstrntgratedLogon = System.Configuration.ConfigurationManager.AppSettings("cIntegratedLogOn").ToString
        cCashierNumber = System.Configuration.ConfigurationManager.AppSettings("cChasierNo").ToString
        strAlamatPerusahaan = System.Configuration.ConfigurationManager.AppSettings("cAlamatPerusahaan").ToString
        cKodeTenant = System.Configuration.ConfigurationManager.AppSettings("cKodeTenant").ToString
        pstrNoISO = System.Configuration.ConfigurationManager.AppSettings("cstrNoReferISO").ToString
        '--baru utk lokasi logo form login 
        cLogoFormLogin = System.Configuration.ConfigurationManager.AppSettings("cImageLogoForm").ToString
        'baru utnuk nominal voucher rupiah
        nPubNominalVoucher = System.Configuration.ConfigurationManager.AppSettings("nNominalVoucher").ToString

        '--baru utk pilihan barcode reader --
        blnisuseBarCode = System.Configuration.ConfigurationManager.AppSettings("useBarCode").ToString
        blnisuseBarCodeAnggota = System.Configuration.ConfigurationManager.AppSettings("useBarCodeAnggota").ToString
        '-- baru utk cash drawer option --....
        blnisUseCashDrawer = System.Configuration.ConfigurationManager.AppSettings("useCashDrawer").ToString
        blnisOpenCashDrawerAfterPrint = System.Configuration.ConfigurationManager.AppSettings("OpenCashDrawerafterprint").ToString
        '---end cash drawer -------------------


        'baru untuk timer interval 1 dan timer interval 2
        pnIntervalTimer1 = System.Configuration.ConfigurationManager.AppSettings("nIntervalTimer1").ToString
        pnIntervalTimer2 = System.Configuration.ConfigurationManager.AppSettings("nIntervalTimer2").ToString


        'baru untuk zooming info report anggota koperasi 
        nPubZoomingReportInfo = System.Configuration.ConfigurationManager.AppSettings("nZoomingReport").ToString

        nPubExpiredDays = System.Configuration.ConfigurationManager.AppSettings("nExpiredDays").ToString

        Dim conn As New SqlConnection
        'conn = New SqlConnection("server=leows2pc,database=sales; user=sa;password=rahasia;")
        'conn = New SqlConnection("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=sales;Data Source=supplier;")
        'conn = New SqlConnection("data source=leows2pc;initial catalog = sales;integrated security=true;user id=sa;password=rahasia;")
        conn = New SqlConnection(cstrSQLKoneksi)
        conn.Open()
        Return conn

    End Function
    Public Function KoneksiServer() As SqlConnection
        strConnServer = System.Configuration.ConfigurationManager.AppSettings("Sql_SalesPusat").ToString
        ' POS_INVENTORY_PUSAT
        Dim connServer As New SqlConnection
        connServer = New SqlConnection(strConnServer)
        connServer.Open()
        Return connServer
    End Function
    Public Function KoneksiPOS1() As SqlConnection
        strConnPOS1 = System.Configuration.ConfigurationManager.AppSettings("Sql_POS1").ToString
        ' POS_INVENTORY_PUSAT
        Dim connPOS1 As New SqlConnection
        connPOS1 = New SqlConnection(strConnPOS1)
        connPOS1.Open()
        Return connPOS1
    End Function
    Public Function KoneksiPOS2() As SqlConnection
        strConnPOS2 = System.Configuration.ConfigurationManager.AppSettings("Sql_POS2").ToString
        ' POS_INVENTORY_PUSAT
        Dim connPOS2 As New SqlConnection
        connPOS2 = New SqlConnection(strConnPOS2)
        connPOS2.Open()
        Return connPOS2
    End Function
    Public Function RataKiri(ByVal sText As String, ByVal MaxLength As Integer, ByVal startOffset As Integer) As String
        Dim strRet As String = ""
        Dim intSpace As Integer = 0

        If sText.Length > (MaxLength - startOffset) Then
            strRet = sText.Substring(0, (MaxLength - startOffset))

            intSpace = 0
        Else
            strRet = Strings.LSet(sText, (MaxLength - startOffset))

        End If

        Return strRet

    End Function
    Public Function RataKanan(ByVal sText As String, ByVal MaxLength As Integer) As String
        Dim strRet As String = ""
        Dim intSpace As Integer = 0

        If sText.Length > MaxLength Then
            strRet = sText.Substring(0, MaxLength)

            intSpace = 0
        Else
            strRet = Strings.RSet(sText, MaxLength)

        End If

        Return strRet
    End Function
    Public Function CenterAlign(ByVal value As String, ByVal maxLength As Integer) As String

        Dim RangeSisa As Integer
        Dim LeftSpace As Integer
        Dim RightSpace As Integer

        Dim str As String


        If value.Length > maxLength Then
            value = Mid(value, 1, maxLength)
        End If

        RangeSisa = (maxLength - value.Length)
        LeftSpace = Math.Round(RangeSisa / 2)
        RightSpace = (RangeSisa - LeftSpace)

        str = (Space(LeftSpace) + value + Space(RightSpace))

        Return str

    End Function
    Public Function CenterAlign(ByVal value As String, ByVal maxLength As Integer, ByVal startOffset As Integer, ByVal lastOffset As Integer) As String

        Dim RangeSisa As Integer
        Dim LeftSpace As Integer
        Dim RightSpace As Integer
        Dim lengthSisa As Integer

        Dim str As String

        lengthSisa = (maxLength - (startOffset + lastOffset))

        If value.Length > lengthSisa Then
            value = Mid(value, 1, lengthSisa)
        End If

        RangeSisa = (lengthSisa - value.Length)
        LeftSpace = Math.Round(RangeSisa / 2)
        RightSpace = (RangeSisa - LeftSpace)

        str = (Space(LeftSpace) + value + Space(RightSpace))

        Return str

    End Function
    'Public Sub SetCRDbSource(ByRef rptDoc As CrystalDecisions.CrystalReports.Engine.ReportClass)
    '    Dim crTable As CrystalDecisions.CrystalReports.Engine.Table
    '    Dim crTableLogOnInfo As CrystalDecisions.Shared.TableLogOnInfo
    '    Dim oCI As New CrystalDecisions.Shared.ConnectionInfo

    '    With oCI
    '        .Type = CrystalDecisions.Shared.ConnectionInfoType.SQL
    '        .ServerName = System.Configuration.ConfigurationManager.AppSettings("entireFileserver").ToString
    '        .DatabaseName = System.Configuration.ConfigurationManager.AppSettings("EntireFileDatabase") 'clsConfig.DBNAME

    '        .UserID = System.Configuration.ConfigurationManager.AppSettings("EntireFileUser")
    '        .Password = System.Configuration.ConfigurationManager.AppSettings("EntireFilePassword")
    '        'If Not IsNothing(System.Configuration.ConfigurationManager.AppSettings("CR_DB_IntgratedLogon")) AndAlso System.Configuration.ConfigurationManager.AppSettings("CR_DB_IntgratedLogon").ToString = "True" Then
    '        '    .IntegratedSecurity = True
    '        'Else
    '        '    .IntegratedSecurity = False

    '        '    .UserID = System.Configuration.ConfigurationManager.AppSettings("CR_DB_UserID")
    '        '    .Password = System.Configuration.ConfigurationManager.AppSettings("CR_DB_PWD")

    '        'End If


    '    End With

    '    rptDoc.SetDatabaseLogon(oCI.UserID, oCI.Password, oCI.ServerName, oCI.DatabaseName, True)

    '    For Each crTable In rptDoc.Database.Tables
    '        crTableLogOnInfo = crTable.LogOnInfo
    '        crTableLogOnInfo.ConnectionInfo = oCI
    '        crTable.ApplyLogOnInfo(crTableLogOnInfo)
    '        crTable.Location = oCI.DatabaseName & ".dbo." & crTable.Location.Substring(crTable.Location.LastIndexOf(".") + 1)
    '    Next
    '    'rptDoc.DataSourceConnections.It()
    '    'rptDoc.SetDatabaseLogon(oCI.UserID, oCI.Password, oCI.ServerName, oCI.DatabaseName, True)

    'End Sub

    'Private Function DisplayReports(ByVal tglMulaiRpt As DateTime, ByVal tglAkhirRpt As DateTime, ByVal FilterBranch As String) As CrystalDecisions.CrystalReports.Engine.ReportClass

    '    Dim docRptSumDSR1 As CrystalDecisions.CrystalReports.Engine.ReportDocument


    '    'tglMulaiRpt = New Date(dtpMonthRpt.Value.Year, dtpMonthRpt.Value.Month, 1, 0, 0, 0)
    '    'tglAkhirRpt = New Date(dtpMonthRpt.Value.Year, dtpMonthRpt.Value.Month, DateTime.DaysInMonth(dtpMonthRpt.Value.Year, dtpMonthRpt.Value.Month), 23, 59, 59)

    '    'If FilterBranch <> "none" Then
    '    '    docRptSumDSR1 = New Summary_Daily_Sales_Per_Stores_Net_Gross_Final

    '    '    docRptSumDSR1.SetParameterValue("@channel_id", ChannelID)
    '    '    docRptSumDSR1.SetParameterValue("@branch_id", FilterBranch)
    '    '    docRptSumDSR1.SetParameterValue("Month_Report", tglMulaiRpt.ToString("MMM yyyy"))
    '    '    docRptSumDSR1.SetParameterValue("@from_reportdate", tglMulaiRpt)
    '    '    docRptSumDSR1.SetParameterValue("@to_reportdate", tglAkhirRpt)

    '    'Else
    '    '    docRptSumDSR1 = New Summary_Daily_Sales_All_Stores_Net_Gross_Final
    '    '    docRptSumDSR1.SetParameterValue("@channel_id", ChannelID)
    '    '    docRptSumDSR1.SetParameterValue("Month_Report", tglMulaiRpt.ToString("MMM yyyy"))
    '    '    docRptSumDSR1.SetParameterValue("@from_reportdate", tglMulaiRpt)
    '    '    docRptSumDSR1.SetParameterValue("@to_reportdate", tglAkhirRpt)

    '    'End If

    '    SetCRDbSource(docRptSumDSR1)
    '    Return docRptSumDSR1




    '    'CrystalReportViewer1.ReportSource = docRptSumDSR1

    '    'CrystalReportViewer1.Zoom(100)




    'End Function
    Public Function base64Encode(ByVal sData As String) As String
        Try
            Dim encData_byte As Byte() = New Byte(sData.Length - 1) {}
            encData_byte = System.Text.Encoding.UTF8.GetBytes(sData)
            Dim encodedData As String = Convert.ToBase64String(encData_byte)
            Return (encodedData)
        Catch ex As Exception
            Throw (New Exception("Error in base64Encode" & ex.Message))
        End Try
    End Function
    Public Function base64Decode(ByVal sData As String) As String
        Dim encoder As New System.Text.UTF8Encoding()
        Dim utf8Decode As System.Text.Decoder = encoder.GetDecoder()
        Dim todecode_byte As Byte() = Convert.FromBase64String(sData)
        Dim charCount As Integer = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
        Dim decoded_char As Char() = New Char(charCount - 1) {}
        utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
        Dim result As String = New [String](decoded_char)
        Return result
    End Function
    Public Function GetPCUniqueID() As String
        Dim win32MgmtClass As System.Management.ManagementClass
        win32MgmtClass = New System.Management.ManagementClass("Win32_Processor")
        Dim processors As System.Management.ManagementObjectCollection
        processors = win32MgmtClass.GetInstances()

        For Each processor As System.Management.ManagementObject In processors
            'MessageBox.Show(processor("ProcessorID").ToString())
            'txtPCUnique.Text = processor("ProcessorID").ToString()
            'txtBiasa.Text = RTrim(LTrim(processor("ProcessorID").ToString()))
            cstrPCUNIQUEID = RTrim(LTrim(processor("ProcessorID").ToString()))
        Next
        Return cstrPCUNIQUEID
    End Function
    'Sub tampil_login()
    '    remove()
    '    FormLogin.Controls.Add(Login)

    '    FormLogin.Size = New Drawing.Size(1500, 690)

    '    Login.Size = New Drawing.Size(1500, 690)


    '    Login.Parent = FormLogin
    '    Login.Dock = DockStyle.Fill
    '    Login.Show()
    '    Login.ResumeLayout()
    '    FormLogin.Show()
    'End Sub
    Sub tampil_home()
        'remove()
        'home.Dock = DockStyle.None
        'Form1.panelContent.Controls.Add(home)
        'home.Location = New Point(90, 30)
        remove()
        Form1.Controls.Add(home)

        Form1.Size = New Drawing.Size(1500, 690)
        home.Size = New Drawing.Size(1500, 690)
        home.Location = New Drawing.Point(210, 30)  ' (x,y)  => x = kiri kanan ; y= atas bawah 

        home.Parent = Form1
        home.Dock = DockStyle.None
        home.Show()
        home.ResumeLayout()

    End Sub
    Sub tampil_home_slider()
        'remove()
        'home.Dock = DockStyle.None
        'Form1.panelContent.Controls.Add(home)
        'home.Location = New Point(90, 30)
        remove()
        Form1.Controls.Add(home)

        Form1.Size = New Drawing.Size(1500, 690)
        home.Size = New Drawing.Size(1500, 690)
        '    home.Location = New Drawing.Point(210, 30)  ' (x,y)  => x = kiri kanan ; y= atas bawah 

        home.Location = New Drawing.Point(50, 30)  ' (x,y)  => x = kiri kanan ; y= atas bawah 

        home.Parent = Form1
        home.Dock = DockStyle.None
        home.Show()
        home.ResumeLayout()

    End Sub
    Sub tampil_usercontrol(ByVal sBlobkID As String)

        ' Dim ctl As New sBlobkID
        Dim ctl As New frmMasterLokasi
        ctl.Name = "frmMasterLokasi"
        ' Panel1.Controls.Add(ctl)

        Form1.Controls.Add(ctl)

        Form1.Size = New Drawing.Size(1500, 690)

        ctl.TabControl.Size = New Drawing.Size(1500, 690)
    End Sub
    Sub tampil_masterlokasi()
        remove()
        frmMasterLokasi.Dock = DockStyle.None
        Form1.Controls.Add(frmMasterLokasi)

        'layout laptop
        'Form1.Size = New Drawing.Size(1500, 710)
        Form1.Size = New Drawing.Size(1500, 950)
        'frmMasterLokasi.Location = New Drawing.Point(400, 90)
        'frmMasterLokasi.TabControl.Size = New Drawing.Size(1500, 710)
        frmMasterLokasi.TabControl.Size = New Drawing.Size(1500, 950)
        frmMasterLokasi.Location = New Drawing.Point(210, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 


        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        '1092, 502
        '   untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 840)
        'frmMasterLokasi.TabControl.Size = New Drawing.Size(1500, 840)


        frmMasterLokasi.Parent = Form1
        frmMasterLokasi.Dock = DockStyle.None
        frmMasterLokasi.Show()
        frmMasterLokasi.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)

    End Sub


    Sub tampil_masterlokasi_slider()
        remove()
        frmMasterLokasi.Dock = DockStyle.None
        Form1.Controls.Add(frmMasterLokasi)

        'layout laptop
        'Form1.Size = New Drawing.Size(1500, 710)
        Form1.Size = New Drawing.Size(1500, 950)
        'frmMasterLokasi.Location = New Drawing.Point(400, 90)
        'frmMasterLokasi.TabControl.Size = New Drawing.Size(1500, 710)
        frmMasterLokasi.TabControl.Size = New Drawing.Size(1500, 950)
        frmMasterLokasi.Location = New Drawing.Point(50, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 


        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        '1092, 502
        '   untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 840)
        'frmMasterLokasi.TabControl.Size = New Drawing.Size(1500, 840)


        frmMasterLokasi.Parent = Form1
        frmMasterLokasi.Dock = DockStyle.None
        frmMasterLokasi.Show()
        frmMasterLokasi.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)

    End Sub

    Sub tampil_masterkategori()
        remove()
        frmMasterKategori.Dock = DockStyle.None
        ' masterkabupaten.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmMasterKategori)

        Form1.Size = New Drawing.Size(1500, 690)

        frmMasterKategori.TabControl.Size = New Drawing.Size(1500, 950)
        frmMasterKategori.Location = New Drawing.Point(210, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmMasterKategori.Parent = Form1
        frmMasterKategori.Dock = DockStyle.None
        frmMasterKategori.Show()
        frmMasterKategori.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)




    End Sub


    Sub tampil_masterkategori_slider()
        remove()
        frmMasterKategori.Dock = DockStyle.None
        ' masterkabupaten.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmMasterKategori)

        Form1.Size = New Drawing.Size(1500, 690)

        frmMasterKategori.TabControl.Size = New Drawing.Size(1500, 950)
        frmMasterKategori.Location = New Drawing.Point(50, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmMasterKategori.Parent = Form1
        frmMasterKategori.Dock = DockStyle.None
        frmMasterKategori.Show()
        frmMasterKategori.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)




    End Sub


    Sub tampil_masterkondisi()
        remove()
        frmMasterKondisi.Dock = DockStyle.None
        ' masterkabupaten.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmMasterKondisi)

        Form1.Size = New Drawing.Size(1500, 690)

        frmMasterKondisi.TabControl.Size = New Drawing.Size(1500, 950)
        frmMasterKondisi.Location = New Drawing.Point(210, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmMasterKondisi.Parent = Form1
        frmMasterKondisi.Dock = DockStyle.None
        frmMasterKondisi.Show()
        frmMasterKondisi.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)




    End Sub
    Sub tampil_masterkondisi_slider()
        remove()
        frmMasterKondisi.Dock = DockStyle.None
        ' masterkabupaten.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmMasterKondisi)

        Form1.Size = New Drawing.Size(1500, 690)

        frmMasterKondisi.TabControl.Size = New Drawing.Size(1500, 950)
        frmMasterKondisi.Location = New Drawing.Point(50, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmMasterKondisi.Parent = Form1
        frmMasterKondisi.Dock = DockStyle.None
        frmMasterKondisi.Show()
        frmMasterKondisi.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)




    End Sub


    Sub tampil_masterItemGroup()
        remove()
        frmMasterKondisi.Dock = DockStyle.None
        ' masterkabupaten.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmMasterItemGroup)

        Form1.Size = New Drawing.Size(1500, 690)

        frmMasterItemGroup.TabControl.Size = New Drawing.Size(1500, 950)
        frmMasterItemGroup.Location = New Drawing.Point(210, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmMasterItemGroup.Parent = Form1
        frmMasterItemGroup.Dock = DockStyle.None
        frmMasterItemGroup.Show()
        frmMasterItemGroup.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)


    End Sub
    Sub tampil_masterItemGroup_slider()
        remove()
        frmMasterItemGroup.Dock = DockStyle.None
        ' masterkabupaten.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmMasterItemGroup)

        Form1.Size = New Drawing.Size(1500, 690)

        frmMasterItemGroup.TabControl.Size = New Drawing.Size(1500, 950)
        frmMasterItemGroup.Location = New Drawing.Point(50, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmMasterItemGroup.Parent = Form1
        frmMasterItemGroup.Dock = DockStyle.None
        frmMasterItemGroup.Show()
        frmMasterItemGroup.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)




    End Sub

    Sub tampil_masterItem()
        remove()
        frmMasterItem.Dock = DockStyle.None
        ' masterkabupaten.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmMasterItem)

        Form1.Size = New Drawing.Size(1500, 690)

        frmMasterItem.TabControl.Size = New Drawing.Size(1500, 950)
        frmMasterItem.Location = New Drawing.Point(210, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmMasterItem.Parent = Form1
        frmMasterItem.Dock = DockStyle.None
        frmMasterItem.Show()
        frmMasterItem.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)


    End Sub

    Sub tampil_masterItem_slider()
        remove()
        frmMasterItemGroup.Dock = DockStyle.None
        ' frmMasterItem.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmMasterItem)

        Form1.Size = New Drawing.Size(1500, 690)

        frmMasterItem.TabControl.Size = New Drawing.Size(1500, 950)
        frmMasterItem.Location = New Drawing.Point(50, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmMasterItem.Parent = Form1
        frmMasterItem.Dock = DockStyle.None
        frmMasterItem.Show()
        frmMasterItem.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)




    End Sub



    Sub tampil_trans_beli()
        remove()
        frmTransBeli.Dock = DockStyle.None
        ' masterkabupaten.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmTransBeli)

        Form1.Size = New Drawing.Size(1500, 690)
        frmTransBeli.Size = New Drawing.Size(1500, 950)
        '   frmTransBeli.TabControl.Size = New Drawing.Size(1500, 950)
        frmTransBeli.Location = New Drawing.Point(210, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmTransBeli.Parent = Form1
        frmTransBeli.Dock = DockStyle.None
        frmTransBeli.Show()
        frmTransBeli.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)


    End Sub

    Sub tampil_trans_beli_slider()
        remove()
        frmTransBeli.Dock = DockStyle.None
        ' frmMasterItem.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmTransBeli)

        Form1.Size = New Drawing.Size(1500, 690)

        frmTransBeli.Size = New Drawing.Size(1500, 950)
        '      frmTransBeli.TabControl.Size = New Drawing.Size(1500, 950)
        frmTransBeli.Location = New Drawing.Point(50, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmTransBeli.Parent = Form1
        frmTransBeli.Dock = DockStyle.None
        frmTransBeli.Show()
        frmTransBeli.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)




    End Sub


    Sub tampil_trans_terima()
        remove()
        frmTransTerima.Dock = DockStyle.None
        ' masterkabupaten.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmTransTerima)

        Form1.Size = New Drawing.Size(1500, 690)
        frmTransTerima.Size = New Drawing.Size(1500, 950)
        '   frmTransBeli.TabControl.Size = New Drawing.Size(1500, 950)
        frmTransTerima.Location = New Drawing.Point(210, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmTransTerima.Parent = Form1
        frmTransTerima.Dock = DockStyle.None
        frmTransTerima.Show()
        frmTransTerima.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)


    End Sub
    Sub tampil_trans_terima_slider()
        remove()
        frmTransTerima.Dock = DockStyle.None
        ' frmMasterItem.Size.Height = Form1.Width

        'radPanel2.Controls.Add(control2); 

        '1112, 546

        'Form1.panelContent.Size = New Size(1200, 640)
        'Form1.panelContent.Location = New Point(220, 30)

        Form1.Controls.Add(frmTransTerima)

        Form1.Size = New Drawing.Size(1500, 690)

        frmTransTerima.Size = New Drawing.Size(1500, 950)
        '      frmTransBeli.TabControl.Size = New Drawing.Size(1500, 950)
        frmTransTerima.Location = New Drawing.Point(50, 30)   ' (x,y)  => x = kiri kanan ; y= atas bawah 

        'untuk di PC layoutnya
        'Form1.panelContent.Size = New Drawing.Size(1500, 830)

        'masterkabupaten.TabControlkabupaten.Size = New Drawing.Size(1500, 830)


        'Form1.panelContent.Location = New Drawing.Point(212, 32)

        frmTransTerima.Parent = Form1
        frmTransTerima.Dock = DockStyle.None
        frmTransTerima.Show()
        frmTransTerima.ResumeLayout()

        'Dim MyDataGridview As New DataGridView()
        'MyDataGridview.Parent = Me.MyPanel
        'MyDataGridview.Dock = DockStyle.Fill
        'MyDataGridview.Show()

        'masterkabupaten.Location = New Point(90, 30)
        'masterkabupaten.TabControlkabupaten.Location = New Point(90, 30)




    End Sub


    Sub remove()

        Form1.Controls.Remove(home)
        Form1.Controls.Remove(frmMasterLokasi)
        Form1.Controls.Remove(frmMasterKategori)
        Form1.Controls.Remove(frmMasterKondisi)
        Form1.Controls.Remove(frmMasterItemGroup)
        Form1.Controls.Remove(frmMasterItem)
        Form1.Controls.Remove(frmTransBeli)
        Form1.Controls.Remove(frmTransTerima)
        'Form1.ItemPanel1.Controls.Remove(masterkabupaten)
        'Form1.ItemPanel1.Controls.Remove(masterkecamatan)


        'Form1.Controls.Remove(home)
        'Form1.Controls.Remove(kodevoucer)
        'Form1.Controls.Remove(jurnalumum)
        'Form1.Controls.Remove(ParmReportNeraca)
        'Form1.Controls.Remove(parmreportlabarugi)
        'Form1.Controls.Remove(profil)
        'Form1.Controls.Remove(user)
        'Form1.Controls.Remove(generaljournal)
    End Sub


End Module
