Imports System.Windows
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Data
Imports System
Imports System.Security.Cryptography
Imports Demo.Module1
Imports System.Net.Sockets.Socket 'coba usb
Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports System.Configuration
Public Class frmInfoAssetoSusut
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
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Public Sub New(ByVal paramdt_tgl_beli As DateTime, ByVal paramstr_kode_item As String, ByVal paramint_limit_umur As Integer, ByVal paramDec_harga_beli As Decimal, ByVal paramtext_nama_item As String)

        ' This call is required by the designer.
        Koneksi()
        InitializeComponent()
        '' Add any initialization after the InitializeComponent() call.

        If DataGridViewPenyusutanAsset.RowCount > 0 Then
            LoadsettingTranSusut(paramdt_tgl_beli, paramstr_kode_item, paramint_limit_umur, paramDec_harga_beli)
            '     DataGridViewItem.Rows(0).Selected = True
        End If
        txtKodeItem.Text = paramstr_kode_item
        txtnamaitem.Text = paramtext_nama_item
    End Sub
    Private Sub LoadsettingTranSusut(ByVal paramdt_tgl_beli As DateTime, ByVal paramstr_kode_item As String, ByVal paramint_limit_umur As Integer, ByVal paramDec_harga_beli As Decimal)
        refreshTranSusut(paramdt_tgl_beli, paramstr_kode_item, paramint_limit_umur, paramDec_harga_beli)
        'refreshLokasi2()
        SetFormattingGridViewTranSusut()
    End Sub
    Private Sub refreshTranSusut(ByVal paramdt_tgl_beli, ByVal paramstr_kode_item, ByVal paramint_limit_umur, ByVal paramDec_harga_beli)
        Dim cstrParamSearch As New SqlClient.SqlParameter
        'Dim cstrsearch As String = RTrim(LTrim(txtSearch.Text))
        Dim ocmdLasTransaction As SqlCommand = New SqlCommand("usp_insert_asset_item", ModuleApp.Koneksi)
        ocmdLasTransaction.CommandTimeout = 1000
        ocmdLasTransaction.CommandType = CommandType.StoredProcedure

        cstrParamSearch = ocmdLasTransaction.Parameters.Add("@tgl_beli", SqlDbType.DateTime, 8)
        'direction yg dipakai mode input
        cstrParamSearch.Direction = ParameterDirection.Input
        ocmdLasTransaction.Parameters("@tgl_beli").Value = paramdt_tgl_beli

        cstrParamSearch = ocmdLasTransaction.Parameters.Add("@kode_item", SqlDbType.NVarChar, 50)
        'direction yg dipakai mode input
        cstrParamSearch.Direction = ParameterDirection.Input
        ocmdLasTransaction.Parameters("@kode_item").Value = paramstr_kode_item

        cstrParamSearch = ocmdLasTransaction.Parameters.Add("@limit_umur", SqlDbType.Int, 4)
        'direction yg dipakai mode input
        cstrParamSearch.Direction = ParameterDirection.Input
        ocmdLasTransaction.Parameters("@limit_umur").Value = paramint_limit_umur

        cstrParamSearch = ocmdLasTransaction.Parameters.Add("@harga_beli", SqlDbType.Decimal, 9)
        'direction yg dipakai mode input
        cstrParamSearch.Direction = ParameterDirection.Input
        ocmdLasTransaction.Parameters("@harga_beli").Value = paramDec_harga_beli


        Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdLasTransaction)
        Dim dsLasTransaction As New DataSet
        Dim oTblLasTransaction As New DataTable
        daLasTransaction.Fill(dsLasTransaction, "tbl_itemassetsusut")
        oTblLasTransaction = dsLasTransaction.Tables("tbl_itemassetsusut")
        DataGridViewPenyusutanAsset.DataSource = oTblLasTransaction

        'Dim adapter As New SqlDataAdapter(cstrsql, Module1.Koneksi)
        ''Me.DataGridView1.Columns.Clear()
        'Dim dt As New DataTable("TranSusut")
        'adapter.Fill(dt)
        'DataGridViewPenyusutanAsset.DataSource = dt
        'Dim tblsalestenant As DataTable
        'tblsalestenant = dt
    End Sub
    Private Sub SetFormattingGridViewTranSusut()

        'a.id ,
        'a.tgl_beli,
        'a.kode_item,
        'b.nama_item,
        'a.cara_perolehan,
        'a.sumber_dana,
        'a.status_barang,
        'a.keterangan,
        'a.harga

        Dim nindex As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim nTahun As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim decharga_perolehan As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim decakumulasi_susut As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim decnilai_buku As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim decbeban_susut As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn

        'Dim cID As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim cTipe As System.Windows.Forms.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        nindex.Name = "index"
        nindex.HeaderText = "Index"
        nindex.DataPropertyName = "index"
        nindex.Width = 80
        nindex.Visible = True
        nindex.ReadOnly = True
        nindex.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        nTahun.Name = "tahun_jalan"
        nTahun.HeaderText = "Tahun"
        nTahun.DataPropertyName = "tahun_jalan"
        nTahun.Width = 100
        nTahun.Visible = True
        nTahun.ReadOnly = True
        nTahun.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        decharga_perolehan.Name = "harga_perolehan"
        decharga_perolehan.HeaderText = "Harga Perolehan (Rp)"
        decharga_perolehan.DataPropertyName = "harga_perolehan"
        decharga_perolehan.Width = 100
        decharga_perolehan.Visible = True
        decharga_perolehan.ReadOnly = True
        decharga_perolehan.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        decakumulasi_susut.Name = "akumulasi_susut"
        decakumulasi_susut.HeaderText = "Akumulasi Penyusutan (Rp)"
        decakumulasi_susut.DataPropertyName = "akumulasi_susut"
        decakumulasi_susut.Width = 100
        decakumulasi_susut.Visible = True
        decakumulasi_susut.ReadOnly = True
        decakumulasi_susut.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        decnilai_buku.Name = "nilai_buku"
        decnilai_buku.HeaderText = "Nilai Buku (Rp)"
        decnilai_buku.DataPropertyName = "nilai_buku"
        decnilai_buku.Width = 100
        decnilai_buku.Visible = True
        decnilai_buku.ReadOnly = True
        decnilai_buku.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        decbeban_susut.Name = "beban_susut"
        decbeban_susut.HeaderText = "Beban Penyusutan (Rp)"
        decbeban_susut.DataPropertyName = "beban_susut"
        decbeban_susut.Width = 100
        decbeban_susut.Visible = True
        decbeban_susut.ReadOnly = True
        decbeban_susut.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        DataGridViewPenyusutanAsset.AllowUserToAddRows = False
        DataGridViewPenyusutanAsset.AllowUserToDeleteRows = True
        DataGridViewPenyusutanAsset.AutoGenerateColumns = False
        DataGridViewPenyusutanAsset.Columns.Clear()

        '"select  sales_date,tenant_id, kode , menu , price , ppn , price_ppn , qty_sales , total_sales from tbl_temp_sales ", Module1.Koneksi)
        DataGridViewPenyusutanAsset.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() _
        { _
        nindex, _
        nTahun, _
        decharga_perolehan, _
        decakumulasi_susut, _
        decnilai_buku, _
        decbeban_susut
        })
        Me.DataGridViewPenyusutanAsset.AllowUserToAddRows = False

        'Me.DataGridViewLokasi.Columns.Item(3).DefaultCellStyle.Format = "n2"      'nominal 
        '   setting format datetime dataGridView1.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
        'Me.DataGridViewLokasi.Columns.Item(4).DefaultCellStyle.Format = "dd/MM/yyyy"      'net sales
        'Me.DataGridViewLokasi.Columns.Item(5).DefaultCellStyle.Format = "dd/MM/yyyy"      'net sales
        Me.DataGridViewPenyusutanAsset.Columns.Item(2).DefaultCellStyle.Format = "n2"      'nominal 
        Me.DataGridViewPenyusutanAsset.Columns.Item(3).DefaultCellStyle.Format = "n2"      'nominal 
        Me.DataGridViewPenyusutanAsset.Columns.Item(4).DefaultCellStyle.Format = "n2"      'nominal 
        Me.DataGridViewPenyusutanAsset.Columns.Item(5).DefaultCellStyle.Format = "n2"      'nominal 

        'Me.DataGridViewPenyusutanAsset.Columns.Item(0).DefaultCellStyle.Format = "dd/MM/yyyy"      'net sales




    End Sub

End Class