Imports DevComponents.DotNetBar
Imports System
Imports System.Security.Cryptography
Imports System.Data.SqlClient
Imports System.Windows
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Data
Imports Explore.ModuleApp
Public Class FormLogin
    ' Inherits System.Windows.Forms.Form


    'versi demo asli Const LocationReg = "System\Windows\User" 'lokasi penyimpanan d registry (ubah sesuai selera)
    Const LocationReg = "WINDOWS\system32_reservedalenov" 'lokasi penyimpanan d registry (ubah sesuai selera)
    Const PasswordReg = "rahasiabanget" 'kode kunci registrasi
    Public nLamaTrial = 15


    Public comPrinter As IO.Ports.SerialPort
    Private xKoneksi As New SqlClient.SqlConnection
    Private xCommand As New SqlClient.SqlCommand
    Private xCommandinsertintoticket As New SqlClient.SqlCommand
    Private xCommandInsertSales As New SqlClient.SqlCommand
    Private xReader As SqlClient.SqlDataReader
    Public GuidWahanaP As Guid
    Public strNoTicketP As String
    Public SalesDateP As Date
    Public priceticketP As Decimal
    Public strOperatorP As String
    Public priceVoucherP As Decimal
    Public isVoucherP As Boolean
    Public ConnectionString As String
    Public oconnection As New SqlConnection()
    Public reader As SqlClient.SqlDataReader = Nothing
    Public conn As SqlClient.SqlConnection = Nothing
    Public cmd As SqlClient.SqlCommand = Nothing
    '    Public AlterTableBtn As System.Windows.Forms.Button
    Public GuidWahanaIDKey As Guid
    Public sql As String = Nothing
    Public StatusSimpanAdd As Boolean = False
    Public StatusSimpanModifiy As Boolean = False
    Public sqlconn As New SqlClient.SqlConnection
    Public StrSQLConnection As String
    Protected GuidWahana As String
    Public strarray As Array()
    Dim EntireFileDatabase As String
    Dim EntireFileServer As String
    Dim EntireFileUser As String
    Dim EntireFilePassword As String
    Dim imageloginform As String
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            ' Me.Hide()
            'Form1.ShowDialog()
            'Me.Close()
            'Dim strConnection As String = " server = " & EntireFileServer & " ;  " & " Database = " & EntireFileDatabase & " ;integrated security=true;user id = " & EntireFileUser & " ; password = " & EntireFilePassword
            'If sqlconn.State = ConnectionState.Open Then
            '    sqlconn.Close()
            'End If
            ''sqlconn.ConnectionString = "server = leows2;Database = wahana;integrated security=true;user id=sa;password=rahasia;"
            'sqlconn.ConnectionString = strConnection
            'Try
            '    sqlconn.Open()
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
            strUser = LTrim(RTrim(UsernameTextBox.Text))
            strPassword = LTrim(RTrim(PasswordTextBox.Text))

            Try
                If VerifyLogin(strUser, strPassword) = False Then
                    MsgBox("Please Verify Your User Login or Password...", MsgBoxStyle.Exclamation)
                    oconnection.Close()
                    Return
                Else
                    'Timer1.Start()
                    'ProgressBar1.Show()
                    'Me.Hide()
                    'frmMenuTreeview.Show()
                    'frmMenuTreeview.cbModul.Focus()
                    MsgBox("Welcome to System User " + RTrim(LTrim(UsernameTextBox.Text)))
                    Me.Hide()
                    'frmMenuTreeview.Show()
                    'frmMenuTreeview.cbModul.Focus()
                    Form1.ShowDialog()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Finally
            End Try
        Catch ex As Exception

        End Try



    End Sub
    Private Function VerifyLogin(ByVal strUserP2 As String, ByVal strpasswordP2 As String) As Boolean
        Dim blnPasswordisTrue As Boolean
        blnPasswordisTrue = False
        ' Dim oconnection As New SqlConnection()
        'EntireFileServer = "leows2pc"
        'EntireFileDatabase = "sales"
        'EntireFileUser = "sa"
        'EntireFilePassword = "rahasia"

        'System.Configuration.s()
        ' strEntireFileServer = Configuration.ConfigurationSettings.AppSettings("entireFileserver").ToString
        'strEntireFileDatabase = Configuration.ConfigurationSettings.AppSettings("EntireFileDatabase").ToString
        'strEntireFileUser = Configuration.ConfigurationSettings.AppSettings("EntireFileUser").ToString
        'strEntireFilePassword = Configuration.ConfigurationSettings.AppSettings("EntireFilePassword").ToString
        'cstrDirectoryimageSource = Configuration.ConfigurationSettings.AppSettings("cDirectoryimageSource").ToString


        strEntireFileServer = System.Configuration.ConfigurationManager.AppSettings("entireFileserver").ToString
        strEntireFileDatabase = System.Configuration.ConfigurationManager.AppSettings("EntireFileDatabase").ToString
        strEntireFileUser = System.Configuration.ConfigurationManager.AppSettings("EntireFileUser").ToString
        strEntireFilePassword = System.Configuration.ConfigurationManager.AppSettings("EntireFilePassword").ToString
        cstrDirectoryimageSource = System.Configuration.ConfigurationManager.AppSettings("cDirectoryimageSource").ToString

        'Dim strConnection As String = " server = " & strEntireFileServer & " ;  " & " Database = " & strEntireFileDatabase & " ;integrated security=true;user id = " & strEntireFileUser & " ; password = " & strEntireFilePassword
        'Persist Security Info=False
        'aslinya ..!!! 10 nov 2014 Dim strConnection As String = " Data Source = " & strEntireFileServer & " ;  Persist Security Info=false " & " ; user id = " & strEntireFileUser & " ; Pwd = " & strEntireFilePassword & " ; Initial Catalog = " & strEntireFileDatabase & " ; integrated security=true"
        Dim strConnection As String = " Data Source = " & strEntireFileServer & " ;  Persist Security Info=false " & " ; user id = " & strEntireFileUser & " ; Pwd = " & strEntireFilePassword & " ; Initial Catalog = " & strEntireFileDatabase & " "
        'Dim strConnection As String = " server = " & strEntireFileServer & " ;  Persist Security Info=False " & " ; Database = " & strEntireFileDatabase & " ;integrated security=true;user id = " & strEntireFileUser & " ; password = " & strEntireFilePassword
        '<add key="Sql_SalesPusat" value="Data Source=172.16.66.22;Persist Security Info=True;User ID=sa;Pwd=rahasia;Initial Catalog=sales_pusat"/>
        oconnection.ConnectionString = strConnection
        Try
            cstruserLogin = RTrim(LTrim(UsernameTextBox.Text))
            oconnection.Open()
            'If Module1.KoneksiServer.State = ConnectionState.Closed Then
            '    Module1.KoneksiServer.Open()
            'End If


            Dim ocmdX As SqlCommand = New SqlCommand("usp_get_password", ModuleApp.Koneksi)
            'Dim ocmdX As SqlCommand = New SqlCommand("usp_verify_login", Module1.KoneksiServer)
            ocmdX.Parameters.Add("@user", SqlDbType.NVarChar, 100).Value = LTrim(RTrim(strUserP2))
            'ocmdX.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = LTrim(RTrim(strpasswordP2))
            ocmdX.CommandTimeout = 90000
            ocmdX.CommandType = CommandType.StoredProcedure
            Dim da2 As SqlDataAdapter = New SqlDataAdapter(ocmdX)
            Dim ds2 As New DataSet
            Dim oTbl2 As New DataTable
            da2.Fill(ds2, "tbl_user_login")
            oTbl2 = ds2.Tables("tbl_user_login")
            If oTbl2.Rows.Count = 0 Or (strUserP2 = "" Or strpasswordP2 = "") Then
                MsgBox("NO DATA USER,PLEASE INSERT DATA ...", MsgBoxStyle.Exclamation)
                Return False
            End If
            Dim drUserLogin As SqlDataReader
            drUserLogin = ocmdX.ExecuteReader
            Do
                While drUserLogin.Read()
                    ' blnPasswordisTrue = (drUserLogin(0))
                    ' GuidUserID = (drUserLogin(1)).ToString
                    strGetPassword = LTrim(RTrim((drUserLogin(0))))
                    strFullName = (drUserLogin(1))
                End While
            Loop While drUserLogin.NextResult()
            drUserLogin.Close()

            ' CEK ENCODING ..DECODING password 
            If LTrim(RTrim(ModuleApp.base64Decode(strGetPassword))) = LTrim(RTrim(strpasswordP2)) Then
                blnPasswordisTrue = True
            Else
                blnPasswordisTrue = False
            End If

            'Dim ocmdX As SqlCommand = New SqlCommand("usp_verify_login", Module1.Koneksi)
            ''Dim ocmdX As SqlCommand = New SqlCommand("usp_verify_login", Module1.KoneksiServer)
            'ocmdX.Parameters.Add("@user", SqlDbType.NVarChar, 100).Value = LTrim(RTrim(strUserP2))
            'ocmdX.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = LTrim(RTrim(strpasswordP2))
            'ocmdX.CommandTimeout = 90000
            'ocmdX.CommandType = CommandType.StoredProcedure
            'Dim da2 As SqlDataAdapter = New SqlDataAdapter(ocmdX)
            'Dim ds2 As New DataSet
            'Dim oTbl2 As New DataTable
            'da2.Fill(ds2, "tbl_user_login")
            'oTbl2 = ds2.Tables("tbl_user_login")
            'If oTbl2.Rows.Count = 0 Then
            '    MsgBox("NO DATA USER,PLEASE INSERT DATA ...", MsgBoxStyle.Exclamation)
            '    Return False
            'End If
            'Dim drUserLogin As SqlDataReader
            'drUserLogin = ocmdX.ExecuteReader
            'Do
            '    While drUserLogin.Read()
            '        blnPasswordisTrue = (drUserLogin(0))
            '        GuidUserID = (drUserLogin(1)).ToString
            '        strFullName = (drUserLogin(2))
            '    End While
            'Loop While drUserLogin.NextResult()
            'drUserLogin.Close()




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
        'blnPasswordisTrue = True
        Return blnPasswordisTrue
    End Function

    Function GetInfoReg() As String 'fungsi utk mendapatkan info registrasi
        Dim Reg = CreateObject("WScript.Shell")
        Try
            GetInfoReg = Reg.RegRead("HKEY_CLASSES_ROOT\" & LocationReg & "\")
        Catch
            Reg.RegWrite("HKEY_CLASSES_ROOT\" & LocationReg & "\", Now.Date) 'memasukkan tgl sekarang
            GetInfoReg = Now.Date
        End Try
    End Function
    Function SuccessReg() As Boolean 'fungsi utk prosedur pemasukan kode registrasi
        Dim s As String
Lagi:
        's = InputBox("Masukkan kode registrasi", "Registrasi")
        'If s = PasswordReg Then
        '    Dim Reg = CreateObject("WScript.Shell")
        '    Reg.RegWrite("HKEY_CLASSES_ROOT\" & LocationReg & "\", "Registered") 'mendaftarkan k registry
        '    MsgBox("Terima kasih telah melakukan registrasi", vbInformation, "Registrasi Sukses")
        '    SuccessReg = True

        'ElseIf s = "" Then
        '    SuccessReg = False

        'Else
        '    If MsgBox("Maaf kode registrasi salah, coba lagi ?", vbYesNo + vbExclamation, "Registrasi") = vbYes Then GoTo Lagi
        '    SuccessReg = False
        'End If
        frmVerifikasi.ShowDialog()
        If pVerfikasi = True Then
            Dim Reg = CreateObject("WScript.Shell")
            Reg.RegWrite("HKEY_CLASSES_ROOT\" & LocationReg & "\", "Registered") 'mendaftarkan k registry
            MsgBox("Terima kasih telah melakukan registrasi", vbInformation, "Registrasi Sukses")
            SuccessReg = True
        Else
            If MsgBox("Maaf registrasi salah, coba lagi ?", vbYesNo + vbExclamation, "Registrasi") = vbYes Then GoTo Lagi
            SuccessReg = False
        End If
    End Function
    Private Sub FormLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim s As String, l As Long
        s = GetInfoReg()
        If s <> "Registered" Then 'jika belum terdaftar"
            'l = 30 - CType(Now.Date - CDate(s), TimeSpan).TotalDays 'max penggunaan trial 30 hari
            l = nLamaTrial - CType(Now.Date - CDate(s), TimeSpan).TotalDays 'max penggunaan trial 30 hari


            'If l > 0 And l <= 30 Then 'jika masih ada sisa hari
            If l > 0 And l <= nLamaTrial Then 'jika masih ada sisa hari

                If MsgBox("Aplikasi ini hanya dapat digunakan sampai " & l & " hari lagi." & vbCrLf & _
                "Jika ingin menggunakan tanpa batasan waktu, masukkan kode registrasi" & vbCrLf & vbCrLf & _
                "Masukkan kode registrasi sekarang ?", vbYesNo + vbInformation, "Registrasi") = vbYes Then SuccessReg()

            Else 'jika kadaluarsa
                If MsgBox("Aplikasi ini sudah tidak dapat digunakan lagi." & vbCrLf & _
                "Jika ingin menggunakannya kembali, masukkan kode registrasi" & vbCrLf & vbCrLf & _
                "Masukkan kode registrasi sekarang ?", vbYesNo + vbExclamation, "Registrasi") = vbYes Then

                    If SuccessReg() = False Then End 'mengakhiri aplikasi
                Else
                    End 'mengakhiri aplikasi
                End If

            End If
        End If

    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        ' Me.Close()
        Application.Exit()
    End Sub
    Private Sub PasswordTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'mengirim key tab
            SendKeys.Send("{tab}")

        End If
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UsernameTextBox.Focus()
    End Sub
    Function GetInfoReg() As String 'fungsi utk mendapatkan info registrasi
        Dim Reg = CreateObject("WScript.Shell")
        Try
            GetInfoReg = Reg.RegRead("HKEY_CLASSES_ROOT\" & LocationReg & "\")
        Catch
            Reg.RegWrite("HKEY_CLASSES_ROOT\" & LocationReg & "\", Now.Date) 'memasukkan tgl sekarang
            GetInfoReg = Now.Date
        End Try
    End Function
    Function SuccessReg() As Boolean 'fungsi utk prosedur pemasukan kode registrasi
        Dim s As String
Lagi:
        's = InputBox("Masukkan kode registrasi", "Registrasi")
        'If s = PasswordReg Then
        '    Dim Reg = CreateObject("WScript.Shell")
        '    Reg.RegWrite("HKEY_CLASSES_ROOT\" & LocationReg & "\", "Registered") 'mendaftarkan k registry
        '    MsgBox("Terima kasih telah melakukan registrasi", vbInformation, "Registrasi Sukses")
        '    SuccessReg = True

        'ElseIf s = "" Then
        '    SuccessReg = False

        'Else
        '    If MsgBox("Maaf kode registrasi salah, coba lagi ?", vbYesNo + vbExclamation, "Registrasi") = vbYes Then GoTo Lagi
        '    SuccessReg = False
        'End If
        frmVerifikasi.ShowDialog()
        If pVerfikasi = True Then
            Dim Reg = CreateObject("WScript.Shell")
            Reg.RegWrite("HKEY_CLASSES_ROOT\" & LocationReg & "\", "Registered") 'mendaftarkan k registry
            MsgBox("Terima kasih telah melakukan registrasi", vbInformation, "Registrasi Sukses")
            SuccessReg = True
        Else
            If MsgBox("Maaf registrasi salah, coba lagi ?", vbYesNo + vbExclamation, "Registrasi") = vbYes Then GoTo Lagi
            SuccessReg = False
        End If
    End Function
End Class