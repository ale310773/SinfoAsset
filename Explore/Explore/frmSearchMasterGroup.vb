Imports System.Windows
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Data
Imports System
Imports System.Security.Cryptography
Imports Explore.ModuleApp
Imports System.Net.Sockets.Socket 'coba usb
Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmSearchMasterGroup
    Public m_HoveredItem As ListViewItem
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
    Public m_SortingColumn As ColumnHeader
    Class ListViewComparer
        Implements IComparer
        Private m_ColumnNumber As Integer
        Private m_SortOrder As SortOrder
        Public Sub New(ByVal column_number As Integer, ByVal _
            sort_order As SortOrder)
            m_ColumnNumber = column_number
            m_SortOrder = sort_order
        End Sub
        ' Compare the items in the appropriate column
        ' for objects x and y.
        Public Function Compare(ByVal x As Object, ByVal y As _
            Object) As Integer Implements _
            System.Collections.IComparer.Compare
            Dim item_x As ListViewItem = DirectCast(x,  _
                ListViewItem)
            Dim item_y As ListViewItem = DirectCast(y,  _
                ListViewItem)

            ' Get the sub-item values.
            Dim string_x As String
            If item_x.SubItems.Count <= m_ColumnNumber Then
                string_x = ""
            Else
                string_x = item_x.SubItems(m_ColumnNumber).Text
            End If

            Dim string_y As String
            If item_y.SubItems.Count <= m_ColumnNumber Then
                string_y = ""
            Else
                string_y = item_y.SubItems(m_ColumnNumber).Text
            End If

            ' Compare them.
            If m_SortOrder = SortOrder.Ascending Then
                If IsNumeric(string_x) And IsNumeric(string_y) _
                    Then
                    Return Val(string_x).CompareTo(Val(string_y))
                ElseIf IsDate(string_x) And IsDate(string_y) _
                    Then
                    Return DateTime.Parse(string_x).CompareTo(DateTime.Parse(string_y))
                Else
                    Return String.Compare(string_x, string_y)
                End If
            Else
                If IsNumeric(string_x) And IsNumeric(string_y) _
                    Then
                    Return Val(string_y).CompareTo(Val(string_x))
                ElseIf IsDate(string_x) And IsDate(string_y) _
                    Then
                    Return DateTime.Parse(string_y).CompareTo(DateTime.Parse(string_x))
                Else
                    Return String.Compare(string_y, string_x)
                End If
            End If
        End Function
    End Class

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmSearchMasterGroup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        txtSearch.Focus()
        ListView1.ShowItemToolTips = True
        Displaydata()
    End Sub
    Private Sub Displaydata()
        Dim newImageKey As String = "person"
        '      Dim cstrimagelocation As String = cstrDirectoryimageSource + "user_man.png"

        'ImageList1.Images.Add(newImageKey, Image.FromFile("D:\ale\program\SINFO_KOPSIMJAM\Images\user_man.png"))
        '   ImageList1.Images.Add(newImageKey, Image.FromFile(cstrimagelocation))
        ImageList1.Images.Add(newImageKey, My.Resources.Computer)
        'grouphomeslider.Image = My.Resources.Preferences


        Dim ImageKey As String = Guid.NewGuid().ToString()
        Dim Img As New Bitmap(180, 100)
        Dim g As Graphics = Graphics.FromImage(Img)
        ImageList1.Images.Add(ImageKey, Img)
        ListView1.StateImageList = ImageList1

        Dim oconn As New SqlConnection()

        'declare @search as nvarchar(100)
        'set @search = 'pure'
        'set @search = '%' + rtrim(ltrim(@search))+ '%'
        'select no_anggota,nama from tbl_anggota where ( no_anggota like @search or nama like @search )


        '   Dim cstrSearch As String = "%" + RTrim(LTrim(txtSearch.Text)) + "%"
        oconn.ConnectionString = cstrSQLKoneksi


        Dim cstrParamSearch As New SqlClient.SqlParameter
        Dim cstrsearch As String = RTrim(LTrim(txtSearch.Text))
        Dim ocmdLasTransaction As SqlCommand = New SqlCommand("usp_search_master_group_sel", ModuleApp.Koneksi)
        ocmdLasTransaction.CommandTimeout = 1000
        ocmdLasTransaction.CommandType = CommandType.StoredProcedure
        cstrParamSearch = ocmdLasTransaction.Parameters.Add("@search", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        cstrParamSearch.Direction = ParameterDirection.Input
        ocmdLasTransaction.Parameters("@search").Value = cstrsearch


        Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdLasTransaction)
        Dim dsLasTransaction As New DataSet
        Dim oTblLasTransaction As New DataTable
        daLasTransaction.Fill(dsLasTransaction, "tbl_Search")
        oTblLasTransaction = dsLasTransaction.Tables("tbl_Search")


        Dim i As Integer
        '  Displaydata()
        ListView1.Items.Clear()
        ListView1.ShowItemToolTips = True
        For i = 0 To (oTblLasTransaction.Rows.Count - 1)
            With oTblLasTransaction.Rows(i)
                Dim lSingleItem As ListViewItem
                lSingleItem = ListView1.Items.Add(.Item("kode_group").ToString)
                lSingleItem.SubItems.Add(.Item("nama_group").ToString)
                '
                'ListView1.Items.Add(i.ToString, i - 1).ToolTipText = "Double click"
                '
                'lSingleItem(.ToolTipText = "Double Click"
            End With
        Next i
        'Me.ListView1.Items.Add(listItem)
        txtSearch.Focus()


        ' DataGridViewLokasi.DataSource = oTblLasTransaction



        'Dim cstrsql As String
        'If cboDepartement.Text = "--PILIH--" Then
        '    cstrsql = "select no_anggota,nama,departement from tbl_anggota where ( no_anggota like '" & cstrSearch & "' OR nama like '" & cstrSearch & "') AND tbl_anggota.aktif = 1"
        'Else
        '    cstrsql = "select no_anggota,nama,departement from tbl_anggota where ( no_anggota like '" & cstrSearch & "' OR nama like '" & cstrSearch & "') AND tbl_anggota.aktif = 1 " & _
        '        " AND departement like '%" & RTrim(LTrim(cboDepartement.Text)) & "%'"
        'End If
        'Dim ocmd As SqlCommand = New SqlCommand(cstrsql, oconn)
        ''aslinya sebelum ada departement
        '' Dim ocmd As SqlCommand = New SqlCommand("select no_anggota,nama,departement from tbl_anggota where ( no_anggota like '" & cstrSearch & "' OR nama like '" & cstrSearch & "') AND tbl_anggota.aktif = 1", oconn)
        'ocmd.CommandType = CommandType.Text


        'Dim da As SqlDataAdapter = New SqlDataAdapter(ocmd)
        'Dim ds As New DataSet
        'Dim oTbl As New DataTable
        'da.Fill(ds, "tbl_anggota")
        'oTbl = ds.Tables("tbl_anggota")

        'Dim i As Integer
        ''  Displaydata()
        'ListView1.Items.Clear()
        'ListView1.ShowItemToolTips = True
        'For i = 0 To (oTbl.Rows.Count - 1)
        '    With oTbl.Rows(i)
        '        Dim lSingleItem As ListViewItem
        '        lSingleItem = ListView1.Items.Add(.Item("no_anggota").ToString)
        '        lSingleItem.SubItems.Add(.Item("nama").ToString)
        '        lSingleItem.SubItems.Add(.Item("departement").ToString)

        '        '
        '        'ListView1.Items.Add(i.ToString, i - 1).ToolTipText = "Double click"
        '        '
        '        'lSingleItem(.ToolTipText = "Double Click"
        '    End With
        'Next i
        ''Me.ListView1.Items.Add(listItem)
        'txtSearch.Focus()
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        whenselectGrid()
    End Sub
    Private Sub whenselectGrid()
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            'If ListView1.Items.Item(i).Checked = True Then 'Jika baris yang pilih, checkbox = true

            '    'Buat proses simpan disini
            'End If
            'If ListView1.Items(0).Selected Then
            '    Dim ss As String = ListView1.Items(0).Text
            '    MsgBox("hai nomer : " & ss)
            'End If
            'Dim ss As String = ListView1.Items(i).Text
            'Dim ss2 As String = ListView1.Items(i).SubItems(1).Text
            If ListView1.Items(i).Selected Then

                'Dim ss As String = ListView1.Items(i).Text
                'Dim ss2 As String = ListView1.Items(i).SubItems(1).Text
                'MsgBox("hai nomer : " & ss & "nama : " & ss2)
                pstrKodeGroup = ListView1.Items(i).Text
            End If
        Next i
        Me.Dispose()

    End Sub
    Private Sub ListView1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        pstrKodeGroup = ListView1.SelectedItems(0).Text
        'pstrNomerAnggota = ListView1.Items(ListView1.SelectedItems.Item(e))
        'MsgBox("hai : " & pstrNomerAnggota)
        Me.Dispose()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Displaydata()
    End Sub
End Class