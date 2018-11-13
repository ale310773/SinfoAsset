Imports System
Imports System.Security.Cryptography
Imports Explore.ModuleApp
Imports System.Net.Sockets.Socket 'coba usb
Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar
Public Class frmTransBeli
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
    Private bindingSource1 As New BindingSource()
    Private savedCursor As Windows.Forms.Cursor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ItemPanelPencarianData.Visible = False
        TabControl.Location = New Point(30, 30)

        GroupPanel1.Text = "Transaksi Pembelian"
        disabledpropertyForm()
        ButtonCRUDWhenDefault()

        'If DataGridViewTransBeli.RowCount > 0 Then
        '    LoadsettingItem()
        '    Try

        '        DataGridViewTransBeli.Rows(0).Selected = True
        '    Catch ex As Exception

        '    End Try

        'End If
        Try
            'If Not DataGridViewTransBeli.CurrentCell Is DBNull.Value Then
            '    LoadsettingItem()
            'End If
            If (DataGridViewTransBeli.RowCount > 0 And DataGridViewTransBeli.ColumnCount > 0) Then
                'MsgBox("DataGridView has no rows or columns!!")
                'Return
                LoadsettingTransBeli()
            Else
                'LoadsettingItem()
            End If

        Catch ex As Exception

        End Try



        'baru ini dari Leo ....
        GoToFirstRecord()
        TabControl.SelectedTab = TabItemData
        'baru ini dari Leo ...
    End Sub
    Private Sub whensearch()
        txtSearch.Enabled = True
        txtSearch.Focus()
        ItemPanelPencarianData.Visible = Not (ItemPanelPencarianData.Visible)
        If ItemPanelPencarianData.Visible = False Then
            'TabControl1.Location.X = 30
            TabControl.Location = New Point(30, 30)
        Else
            TabControl.Location = New Point(30, 98)
        End If

        '32, 98
    End Sub
    Private Sub disabledpropertyForm()
        txtkodeitem.ReadOnly = True
        txtkodeitem.ForeColor = Color.Black
        txtkodeitem.BackColor = Color.Gold

        txtketerangan.ReadOnly = True
        txtketerangan.ForeColor = Color.Black
        txtketerangan.BackColor = Color.Gold

        txtcaraperolehan.ReadOnly = True
        txtcaraperolehan.ForeColor = Color.Black
        txtcaraperolehan.BackColor = Color.Gold

        txtsumberdana.ReadOnly = True
        txtsumberdana.ForeColor = Color.Black
        txtsumberdana.BackColor = Color.Gold

        txtstatusbarang.ReadOnly = True
        txtstatusbarang.ForeColor = Color.Black
        txtstatusbarang.BackColor = Color.Gold

        txtHarga.ReadOnly = True
        txtHarga.ForeColor = Color.Black
        txtHarga.BackColor = Color.Gold

        DateTimePickertglbeli.Enabled = False
        btnSearchkodeitem.Enabled = False
        btnCalcAssetRp.Enabled = True

        txtcreateby.ReadOnly = True
        txtcreateby.ForeColor = Color.Black
        txtcreateby.BackColor = Color.Gold

        txtcreatedate.ReadOnly = True
        txtcreatedate.ForeColor = Color.Black
        txtcreatedate.BackColor = Color.Gold

        txtmodifiedby.ReadOnly = True
        txtmodifiedby.ForeColor = Color.Black
        txtmodifiedby.BackColor = Color.Gold

        txtlastmodified.ReadOnly = True
        txtlastmodified.ForeColor = Color.Black
        txtlastmodified.BackColor = Color.Gold


        btnCalcAssetRp.Enabled = False
        btnSearchkodeitem.Enabled = False


    End Sub
    Private Sub enabledpropertyForm()

        If chrStatusSave = "ADD" Then
            txtkodeitem.ReadOnly = True
        Else
            txtkodeitem.ReadOnly = True
        End If
        txtkodeitem.ForeColor = Color.Black
        txtkodeitem.BackColor = Color.GreenYellow

        txtketerangan.ReadOnly = False
        txtketerangan.ForeColor = Color.Black
        txtketerangan.BackColor = Color.GreenYellow

        txtcaraperolehan.ReadOnly = False
        txtcaraperolehan.ForeColor = Color.Black
        txtcaraperolehan.BackColor = Color.GreenYellow

        txtsumberdana.ReadOnly = False
        txtsumberdana.ForeColor = Color.Black
        txtsumberdana.BackColor = Color.GreenYellow

        txtstatusbarang.ReadOnly = False
        txtstatusbarang.ForeColor = Color.Black
        txtstatusbarang.BackColor = Color.GreenYellow

        txtHarga.ReadOnly = False
        txtHarga.ForeColor = Color.Black
        txtHarga.BackColor = Color.GreenYellow

        DateTimePickertglbeli.Enabled = True
        btnSearchkodeitem.Enabled = True
        btnCalcAssetRp.Enabled = False


        txtcreateby.ReadOnly = False
        txtcreateby.ForeColor = Color.Black
        txtcreateby.BackColor = Color.GreenYellow

        txtcreatedate.ReadOnly = False
        txtcreatedate.ForeColor = Color.Black
        txtcreatedate.BackColor = Color.GreenYellow

        txtmodifiedby.ReadOnly = False
        txtmodifiedby.ForeColor = Color.Black
        txtmodifiedby.BackColor = Color.GreenYellow

        txtlastmodified.ReadOnly = False
        txtlastmodified.ForeColor = Color.Black
        txtlastmodified.BackColor = Color.GreenYellow


        btnCalcAssetRp.Enabled = True
        btnSearchkodeitem.Enabled = True
    End Sub
    Private Sub ButtonCRUDWhenDefault()
        Button_Add.Enabled = True
        Button_Delete.Enabled = True
        Button_Edit.Enabled = True
        Button_Cancel.Enabled = False
        Button_Save.Enabled = False
        Button_Load.Enabled = True
        ' txtkodeGroup.ReadOnly = True

        ''ditambah oleh Leo WS baru...
        'GoToFirstRecord()

        'DataGridViewTransBeli.Enabled = True
        'txtSearch.Enabled = True
    End Sub
    Private Sub ButtonCRUDWhenAdd()
        Button_Add.Enabled = False
        Button_Delete.Enabled = False
        Button_Edit.Enabled = False
        Button_Cancel.Enabled = True
        Button_Save.Enabled = True
        Button_Load.Enabled = False
        '   txtkodeGroup.ReadOnly = False
    End Sub
    Private Sub ButtonCRUDWhenModify()
        Button_Add.Enabled = False
        Button_Delete.Enabled = False
        Button_Edit.Enabled = False
        Button_Cancel.Enabled = True
        Button_Save.Enabled = True
        '  btnCancel.Enabled = False
    End Sub
    Private Sub ButtonCRUDWhenDelete()
        ButtonCRUDWhenDefault()
    End Sub
    Private Sub ButtonCRUDWhenCancel()
        ButtonCRUDWhenDefault()
    End Sub
    Private Sub ButtonCRUDWhenAfterSave()
        ButtonCRUDWhenDefault()
    End Sub
    Private Sub whencancel2()
        blankrecord()
        LoadsettingTransBeli()
        disabledpropertyForm()

        'If DataGridViewTransBeli.RowCount > 0 Then
        '    DataGridViewTransBeli.Rows(0).Selected = True
        'End If
    End Sub
    Private Sub LoadsettingTransBeli()
        ' refreshGroup()
        refreshTransBeli2()
        SetFormattingGridViewTransBeli()
        txtSearch.Text = ""
    End Sub
    'Private Sub refreshGroup()
    '    Dim cstrSearch As String = "%" + RTrim(LTrim(txtSearch.Text)) + "%"
    '    Dim cstrsql As String

    '    cstrsql = " select id,kode_Group,nama_Group from tbl_master_Group " & _
    '  " where ( tbl_master_Group.kode_Group like '" & cstrSearch & "' OR " & _
    '        " dbo.tbl_master_Group.nama_Group " & " like '" & cstrSearch & "' )" & _
    ' "  ORDER BY tbl_master_Group.kode_Group "

    '    Dim adapter As New SqlDataAdapter(cstrsql, ModuleApp.Koneksi)
    '    Me.DataGridView1.Columns.Clear()
    '    Dim dt As New DataTable("Group")
    '    adapter.Fill(dt)
    '    DataGridViewTransBeli.DataSource = dt
    '    Dim tblsalestenant As DataTable
    '    tblsalestenant = dt
    'End Sub
    Private Sub refreshTransBeli2()

        '        Dim cstrSearch As String = "%" + RTrim(LTrim(txtSearch.Text)) + "%"
        '        Dim cstrsql As String

        '        '       cstrsql = " select tbl_master_TransBeli.id,tbl_master_TransBeli.kode_Item,tbl_master_Item.nama_Item,tbl_master_Item.keterangan ," & _
        '        '       " tbl_master_Item.kode_barcode, tbl_master_Item.limit_umur, tbl_master_Item.kode_kategori, tbl_master_kategori.nama_kategori " & _
        '        '" from tbl_master_Item   inner join tbl_master_kategori  on tbl_master_Item.kode_kategori = tbl_master_kategori.kode_kategori " & _
        '        '    "  ORDER BY tbl_master_Item.kode_Item "

        '        cstrsql = " select a.id ,a.tgl_beli,a.kode_item ,b.nama_item,a.cara_perolehan, a.sumber_dana ,a.status_barang ,a.keterangan ,a.harga " & _
        '" from tbl_trans_beli a inner join tbl_master_item b on a.kode_item = b.kode_item " & _
        '" where ( a.kode_item like  '" & cstrSearch & "' OR  b.nama_item like '" & cstrSearch & "' OR a.sumber_dana like  '" & cstrSearch & "' OR a.cara_perolehan like '" & _
        ' cstrSearch & "' OR a.status_barang like  '" & cstrSearch & "' OR a.keterangan like  '" & cstrSearch & "' OR   harga like " & " cast( '" & cstrSearch & "' as nvarchar(50)))" & _
        '" ORDER BY b.nama_item"


        '        '   cstrsql = " select id ,tgl_beli ,kode_item ,cara_perolehan, sumber_dana ,status_barang ,keterangan ,harga from tbl_trans_beli" & _
        '        ' " where ( a.kode_Item like '" & cstrSearch & "' OR " & _
        '        '       " a.nama_Item like '" & cstrSearch & "'  OR a.keterangan like '" & cstrSearch & "' OR a.kode_barcode like '" & cstrSearch & "' OR b.nama_kategori like '" & cstrSearch & "')" & _
        '        '"  ORDER BY a.kode_Item "

        '        Dim adapter As New SqlDataAdapter(cstrsql, ModuleApp.Koneksi)
        '        'Me.DataGridView1.Columns.Clear()
        '        Dim dt As New DataTable("TransBeli")
        '        adapter.Fill(dt)
        '        DataGridViewTransBeli.DataSource = dt
        '        Dim tblsalestenant As DataTable
        '        tblsalestenant = dt

        Dim cstrParamSearch As New SqlClient.SqlParameter
        Dim cstrsearch As String = RTrim(LTrim(txtSearch.Text))
        Dim ocmdLasTransaction As SqlCommand = New SqlCommand("usp_search_trans_beli_sel", ModuleApp.Koneksi)
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
        DataGridViewTransBeli.DataSource = oTblLasTransaction


    End Sub
    Private Sub SetFormattingGridViewTransBeli()

        Dim dttgl_beli As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim ckode_Item As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cnama_Item As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim ccara_perolehan As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim csumber_dana As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cstatus_barang As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cketerangan As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim nharga As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cid As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn


        Dim cCreateDate As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cCreateBy As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cLastModified As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cModifiedBy As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn

        'Dim cID As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim cTipe As System.Windows.Forms.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn

        'DataGridViewTransBeli.Rows.  

        dttgl_beli.Name = "tgl_beli"
        dttgl_beli.HeaderText = "Tgl Beli"
        dttgl_beli.DataPropertyName = "tgl_beli"
        dttgl_beli.Width = 80
        dttgl_beli.Visible = True
        dttgl_beli.ReadOnly = True
        dttgl_beli.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        ckode_Item.Name = "kode_Item"
        ckode_Item.HeaderText = "Kode Item"
        ckode_Item.DataPropertyName = "kode_Item"
        ckode_Item.Width = 100
        ckode_Item.Visible = True
        ckode_Item.ReadOnly = True
        ckode_Item.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        cnama_Item.Name = "nama_Item"
        cnama_Item.HeaderText = "Nama Item"
        cnama_Item.DataPropertyName = "nama_Item"
        cnama_Item.Width = 100
        cnama_Item.Visible = True
        cnama_Item.ReadOnly = True
        cnama_Item.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        ccara_perolehan.Name = "cara_perolehan"
        ccara_perolehan.HeaderText = "Cara Perolehan"
        ccara_perolehan.DataPropertyName = "cara_perolehan"
        ccara_perolehan.Width = 100
        ccara_perolehan.Visible = True
        ccara_perolehan.ReadOnly = True
        ccara_perolehan.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        csumber_dana.Name = "sumber_dana"
        csumber_dana.HeaderText = "Sumber Dana"
        csumber_dana.DataPropertyName = "sumber_dana"
        csumber_dana.Width = 100
        csumber_dana.Visible = True
        csumber_dana.ReadOnly = True
        csumber_dana.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        cstatus_barang.Name = "status_barang"
        cstatus_barang.HeaderText = "Status Barang"
        cstatus_barang.DataPropertyName = "status_barang"
        cstatus_barang.Width = 100
        cstatus_barang.Visible = True
        cstatus_barang.ReadOnly = True
        cstatus_barang.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        cketerangan.Name = "keterangan"
        cketerangan.HeaderText = "Keterangan"
        cketerangan.DataPropertyName = "keterangan"
        cketerangan.Width = 100
        cketerangan.Visible = True
        cketerangan.ReadOnly = True
        cketerangan.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        nharga.Name = "harga"
        nharga.HeaderText = "Harga (Rp)"
        nharga.DataPropertyName = "harga"
        nharga.Width = 100
        nharga.Visible = True
        nharga.ReadOnly = True
        nharga.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        cid.Name = "id"
        cid.HeaderText = "id"
        cid.DataPropertyName = "id"
        cid.Width = 150
        cid.Visible = False
        cid.ReadOnly = True

        cCreateDate.Name = "create_date"
        cCreateDate.HeaderText = "Create Date"
        cCreateDate.DataPropertyName = "create_date"
        cCreateDate.Width = 150
        cCreateDate.Visible = True
        cCreateDate.ReadOnly = True
        cCreateDate.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        cCreateBy.Name = "create_by"
        cCreateBy.HeaderText = "Create By"
        cCreateBy.DataPropertyName = "create_by"
        cCreateBy.Width = 90
        cCreateBy.Visible = True
        cCreateBy.ReadOnly = True
        cCreateBy.DefaultCellStyle.BackColor = Color.BlanchedAlmond


        cLastModified.Name = "modified_date"
        cLastModified.HeaderText = "Modified Date"
        cLastModified.DataPropertyName = "modified_date"
        cLastModified.Width = 150
        cLastModified.Visible = True
        cLastModified.ReadOnly = True
        cLastModified.DefaultCellStyle.BackColor = Color.BlanchedAlmond


        cModifiedBy.Name = "modified_by"
        cModifiedBy.HeaderText = "Modified By"
        cModifiedBy.DataPropertyName = "modified_by"
        cModifiedBy.Width = 90
        cModifiedBy.Visible = True
        cModifiedBy.ReadOnly = True
        cModifiedBy.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        DataGridViewTransBeli.AllowUserToAddRows = False
        DataGridViewTransBeli.AllowUserToDeleteRows = True
        DataGridViewTransBeli.AutoGenerateColumns = False
        DataGridViewTransBeli.Columns.Clear()

        '"select  sales_date,tenant_id, kode , menu , price , ppn , price_ppn , qty_sales , total_sales from tbl_temp_sales ", Module1.Koneksi)
        DataGridViewTransBeli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() _
        { _
        dttgl_beli, _
        ckode_Item, _
        cnama_Item, _
        ccara_perolehan, _
        csumber_dana, _
        cstatus_barang, _
        cketerangan, _
        nharga, _
        cid, _
        cCreateDate, _
        cCreateBy, _
        cLastModified, _
        cModifiedBy _
        })
        Me.DataGridViewTransBeli.AllowUserToAddRows = False

        'Me.DataGridViewTransBeli.Columns.Item(3).DefaultCellStyle.Format = "n2"      'nominal 
        '   setting format datetime dataGridView1.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
        'Me.DataGridViewTransBeli.Columns.Item(4).DefaultCellStyle.Format = "dd/MM/yyyy"      'net sales
        'Me.DataGridViewTransBeli.Columns.Item(5).DefaultCellStyle.Format = "dd/MM/yyyy"      'net sales


        'For i = 0 To DataGridViewTransBeli.Rows.Count - 1
        '    DataGridViewTransBeli.Rows(i).Height = 100
        'Next

        'setting di bawah dibuat untuk yg punhya file gamabr / foto / image !!!
        ' DataGridViewTransBeli.RowTemplate.Height = 30

    End Sub
    Private Sub blankrecord()
        txtkodeitem.Text = ""
        '        txtnamaitem.Text = ""
        txtketerangan.Text = ""
        '       txtbarcode.Text = ""
        '        txtlimitumur.Text = 1
        'DateTimePickertglbeli
        txtcaraperolehan.Text = ""
        txtsumberdana.Text = ""
        txtstatusbarang.Text = ""
        txtketerangan.Text = ""
        txtHarga.Text = 0

        txtcreatedate.Text = ""
        txtcreateby.Text = ""
        txtlastmodified.Text = ""
        txtmodifiedby.Text = ""
    End Sub
    Private Sub WhenAddRecord()
        'Me.TabControl1.SelectedIndex = 0
        'NavigationWhenAdd()
        'RecordProperty()

        'arahkan ke tab data 
        TabControl.SelectedTab = TabItemData

        enabledpropertyForm()
        ButtonCRUDWhenAdd()
        'Me.TabControlSimpanPinjam.SelectedIndex = 0
        chrStatusSave = "ADD"
        '  txtkodeItem.Focus()

        chrStatusSave = "ADD"
        DateTimePickertglbeli.Focus()

        '  txtPeriodeAcounting.Focus()
    End Sub
    Private Sub GoToFirstRecord()

        If (DataGridViewTransBeli.RowCount = 0 And DataGridViewTransBeli.ColumnCount = 0) Then
            Return
        End If


        DataGridViewTransBeli.CurrentCell = DataGridViewTransBeli.Rows(0).Cells(0)

        If IsDBNull(DataGridViewTransBeli.Rows(0).Cells(0).Value) Then
            Return
        End If
        Try

            idTable = Convert.ToString(DataGridViewTransBeli.Rows(0).Cells(8).Value)

            DateTimePickertglbeli.Value = DataGridViewTransBeli.Rows(0).Cells(0).Value
            txtkodeitem.Text = DataGridViewTransBeli.Rows(0).Cells(1).Value
            lblnamaitem.Text = DataGridViewTransBeli.Rows(0).Cells(2).Value
            txtcaraperolehan.Text = DataGridViewTransBeli.Rows(0).Cells(3).Value
            txtsumberdana.Text = DataGridViewTransBeli.Rows(0).Cells(4).Value
            txtstatusbarang.Text = DataGridViewTransBeli.Rows(0).Cells(5).Value
            txtketerangan.Text = DataGridViewTransBeli.Rows(0).Cells(6).Value
            txtHarga.Text = DataGridViewTransBeli.Rows(0).Cells(7).Value

            txtcreatedate.Text = DataGridViewTransBeli.Rows(0).Cells(9).Value
            txtcreateby.Text = DataGridViewTransBeli.Rows(0).Cells(10).Value
            txtlastmodified.Text = DataGridViewTransBeli.Rows(0).Cells(11).Value
            txtmodifiedby.Text = DataGridViewTransBeli.Rows(0).Cells(12).Value



        Catch ex As Exception
            MsgBox("Error Message : " & ex.Message & "", MsgBoxStyle.Exclamation)
            Return
        End Try

    End Sub
    Private Sub whenmodify()

        'handle jika dari grid ke edit 
        Try

            TabControl.SelectedTab = TabItemData
            'ckode_lokasi, _
            '      cnama_lokasi, _
            '      cketerangan, _
            '      cid
            '})

            'idTable = Convert.ToString(DataGridViewLokasi.Rows(e.RowIndex).Cells(3).Value)
            'txtkodelokasi.Text = DataGridViewLokasi.Rows(e.RowIndex).Cells(0).Value
            'txtnamalokasi.Text = DataGridViewLokasi.Rows(e.RowIndex).Cells(1).Value
            'txtketerangan.Text = DataGridViewLokasi.Rows(e.RowIndex).Cells(2).Value
            ''DateTimePickerStartDate.Value = DataGridViewLokasi.Rows(e.RowIndex).Cells(4).Value
            ''DateTimePickerEnDate.Value = DataGridViewLokasi.Rows(e.RowIndex).Cells(5).Value
            ''txtNominal.Text = FormatNumber(DataGridViewLokasi.Rows(e.RowIndex).Cells(3).Value, 2, TriState.UseDefault)

            ''recorded
            'txtcreatedate.Text = DataGridViewLokasi.Rows(e.RowIndex).Cells(4).Value
            'txtcreateby.Text = DataGridViewLokasi.Rows(e.RowIndex).Cells(5).Value
            'txtlastmodified.Text = DataGridViewLokasi.Rows(e.RowIndex).Cells(6).Value
            'txtmodifiedby.Text = DataGridViewLokasi.Rows(e.RowIndex).Cells(7).Value

        Catch ex As Exception

        End Try

        'end handle




        chrStatusSave = "EDIT"
        ButtonCRUDWhenModify()
        '  txtPeriodeAcounting.Focus()
        enabledpropertyForm()
    End Sub
    Private Sub whensaverecord()
        If txtkodeitem.Text = "" Then
            MsgBox("KODE TIDAK BOLEH KOSONG !", MsgBoxStyle.Information)
            txtkodeitem.ReadOnly = False
            Return
        End If
        Dim ckode As String = ""
        Dim cgrade As String = ""
        Try
            If chrStatusSave = "ADD" Then
                saverecordTransBeli()
                LoadsettingTransBeli()
            Else
                UpdaterecordTransBeli()
                LoadsettingTransBeli()
            End If
            If DataGridViewTransBeli.RowCount > 0 Then
                DataGridViewTransBeli.Rows(0).Selected = True
            End If
            If chrStatusSave = "ADD" Then
                MessageBox.Show("TAMBAH DATA TRANSAKSI BELI SUKSES...", "SAVE RECORDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("UPDATE DATA TRANSAKSI BELI SUKSES...", "SAVE RECORDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            'MessageBox.Show("error while void record sales on table..." & ex.Message, "save records")
            MessageBox.Show("ERROR :" & ex.Message, "SAVE RECORDS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            blankrecord()
        Finally
            'con.close()
        End Try
        txtkodeitem.ReadOnly = True


    End Sub
    Private Sub UpdaterecordTransBeli()

        idTable2 = Convert.ToString(Me.DataGridViewTransBeli.CurrentRow.Cells(8).Value)
        xCommand.Connection = sqlconn

        Dim xParamID As New SqlClient.SqlParameter
        Dim xParamtgl_beli As New SqlClient.SqlParameter
        Dim xParamkodeItem As New SqlClient.SqlParameter
        Dim xParamcara_perolehan As New SqlClient.SqlParameter
        Dim xParamsumber_dana As New SqlClient.SqlParameter
        Dim xParamstatus_barang As New SqlClient.SqlParameter
        Dim xParamketerangan As New SqlClient.SqlParameter
        Dim xParamharga As New SqlClient.SqlParameter
        Dim xParamModifiedBy As New SqlClient.SqlParameter

        xCommand.Parameters.Clear()

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
        End If
        sqlconn.ConnectionString = cstrSQLKoneksi
        Try
            sqlconn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        xCommand.CommandText = "usp_trans_beli_upd#id"
        xCommand.CommandType = CommandType.StoredProcedure

        idTable2 = Convert.ToString(Me.DataGridViewTransBeli.CurrentRow.Cells(8).Value)
        Dim dtgl_beli As DateTime = DateTimePickertglbeli.Value.Date



        xCommand.CommandText = "usp_trans_beli_upd#id"
        xCommand.CommandType = CommandType.StoredProcedure

        'parameter yang dikirim melalui objek command
        xParamID = xCommand.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16)
        'direction yg dipakai mode input
        xParamID.Direction = ParameterDirection.Input
        xCommand.Parameters("@id").Value = New Guid(idTable2)
        'idTable2
        'New Guid(idTable2)

        'parameter yang dikirim melalui objek command
        xParamtgl_beli = xCommand.Parameters.Add("@tgl_beli", SqlDbType.DateTime, 8)
        'direction yg dipakai mode input
        xParamtgl_beli.Direction = ParameterDirection.Input
        xCommand.Parameters("@tgl_beli").Value = dtgl_beli


        'parameter yang dikirim melalui objek command
        xParamkodeItem = xCommand.Parameters.Add("@kode_item", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamkodeItem.Direction = ParameterDirection.Input
        xCommand.Parameters("@kode_item").Value = LTrim(RTrim(txtkodeitem.Text))

        'parameter yang dikirim melalui objek command
        xParamcara_perolehan = xCommand.Parameters.Add("@cara_perolehan", SqlDbType.NVarChar, 255)
        'direction yg dipakai mode input
        xParamcara_perolehan.Direction = ParameterDirection.Input
        xCommand.Parameters("@cara_perolehan").Value = LTrim(RTrim(txtcaraperolehan.Text))

        'parameter yang dikirim melalui objek command
        xParamsumber_dana = xCommand.Parameters.Add("@sumber_dana", SqlDbType.NVarChar, 255)
        'direction yg dipakai mode input
        xParamsumber_dana.Direction = ParameterDirection.Input
        xCommand.Parameters("@sumber_dana").Value = LTrim(RTrim(txtsumberdana.Text))

        'parameter yang dikirim melalui objek command
        xParamstatus_barang = xCommand.Parameters.Add("@status_barang", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamstatus_barang.Direction = ParameterDirection.Input
        xCommand.Parameters("@status_barang").Value = LTrim(RTrim(txtstatusbarang.Text))

        'parameter yang dikirim melalui objek command
        xParamketerangan = xCommand.Parameters.Add("@keterangan", SqlDbType.NVarChar, 255)
        'direction yg dipakai mode input
        xParamketerangan.Direction = ParameterDirection.Input
        xCommand.Parameters("@keterangan").Value = LTrim(RTrim(txtketerangan.Text))

        'parameter yang dikirim melalui objek command
        xParamharga = xCommand.Parameters.Add("@harga", SqlDbType.Decimal, 9)
        'direction yg dipakai mode input
        xParamharga.Direction = ParameterDirection.Input
        xCommand.Parameters("@harga").Value = LTrim(RTrim(txtHarga.Text))


        'parameter yang dikirim melalui objek command
        xParamModifiedBy = xCommand.Parameters.Add("@modified_by", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamModifiedBy.Direction = ParameterDirection.Input
        xCommand.Parameters("@modified_by").Value = LTrim(RTrim(strFullName))


        xCommand.CommandTimeout = 15000
        xCommand.ExecuteNonQuery()

        'hancurkan semua parameter
        xCommand.Parameters.Remove(xParamID)
        xCommand.Parameters.Remove(xParamtgl_beli)
        xCommand.Parameters.Remove(xParamkodeItem)
        xCommand.Parameters.Remove(xParamcara_perolehan)
        xCommand.Parameters.Remove(xParamsumber_dana)
        xCommand.Parameters.Remove(xParamstatus_barang)
        xCommand.Parameters.Remove(xParamketerangan)
        xCommand.Parameters.Remove(xParamharga)
        xCommand.Parameters.Remove(xParamModifiedBy)
    End Sub
    Private Sub saverecordTransBeli()
        'Dim con As New SqlConnection
        'Dim cmd As New SqlCommand
        'Dim cstrsql As String

        '' Dim cPeriode As String = LTrim(RTrim(txtPeriodeAcounting.Text))
        'Dim cstrnoanggota As String = txtNomeranggota.Text
        'Dim nDecNominal As Decimal = txtNominal.Text
        'Dim dtglawal As DateTime = DateTimePickerStartDate.Value.Date
        'Dim dtglakhir As DateTime = DateTimePickerEnDate.Value.Date
        'Dim is_Aktif As Integer = IIf(chkboxisAktif.Checked = True, 1, 0)
        'cstrsql = " insert into tbl_gaji_anggota ( no_anggota , start_date ,end_date , nominal ,aktif ) " & _
        '        " values ( '" & cstrnoanggota & "','" & dtglawal & "','" & dtglakhir & "'," & nDecNominal.ToString & "," & is_Aktif.ToString & ")"
        '' Dim mResult
        'Dim ObjConnection As New SqlConnection()
        'Try
        '    con.ConnectionString = cstrSQLKoneksi
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandText = cstrsql
        '    cmd.ExecuteNonQuery()
        '    MessageBox.Show("INSERT RECORD GAJI ANGGOTA SUKSES...")
        'Catch ex As Exception
        '    MessageBox.Show("Error while void record sales on table..." & ex.Message, "Save Records")
        'Finally
        '    con.Close()
        'End Try

        '@kode_lokasi				nvarchar(50) = null , 
        '@nama_lokasi			nvarchar(100) = null ,	
        '@keterangan				nvarchar(255) = null 
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
        End If
        sqlconn.ConnectionString = cstrSQLKoneksi
        Try
            sqlconn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        xCommand.Connection = sqlconn
        Dim xParamtgl_beli As New SqlClient.SqlParameter
        Dim xParamkodeItem As New SqlClient.SqlParameter
        Dim xParamcara_perolehan As New SqlClient.SqlParameter
        Dim xParamsumber_dana As New SqlClient.SqlParameter
        Dim xParamstatus_barang As New SqlClient.SqlParameter
        Dim xParamketerangan As New SqlClient.SqlParameter
        Dim xParamharga As New SqlClient.SqlParameter
        Dim dtgl_beli As DateTime = DateTimePickertglbeli.Value.Date
        Dim xParamCreateBy As New SqlClient.SqlParameter

        xCommand.Parameters.Clear()

        xCommand.CommandText = "usp_tbl_trans_beli_ins"
        xCommand.CommandType = CommandType.StoredProcedure

        'parameter yang dikirim melalui objek command
        xParamtgl_beli = xCommand.Parameters.Add("@tgl_beli", SqlDbType.DateTime, 8)
        'direction yg dipakai mode input
        xParamtgl_beli.Direction = ParameterDirection.Input
        xCommand.Parameters("@tgl_beli").Value = dtgl_beli


        'parameter yang dikirim melalui objek command
        xParamkodeItem = xCommand.Parameters.Add("@kode_item", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamkodeItem.Direction = ParameterDirection.Input
        xCommand.Parameters("@kode_item").Value = LTrim(RTrim(txtkodeitem.Text))

        'parameter yang dikirim melalui objek command
        xParamcara_perolehan = xCommand.Parameters.Add("@cara_perolehan", SqlDbType.NVarChar, 255)
        'direction yg dipakai mode input
        xParamcara_perolehan.Direction = ParameterDirection.Input
        xCommand.Parameters("@cara_perolehan").Value = LTrim(RTrim(txtcaraperolehan.Text))

        'parameter yang dikirim melalui objek command
        xParamsumber_dana = xCommand.Parameters.Add("@sumber_dana", SqlDbType.NVarChar, 255)
        'direction yg dipakai mode input
        xParamsumber_dana.Direction = ParameterDirection.Input
        xCommand.Parameters("@sumber_dana").Value = LTrim(RTrim(txtsumberdana.Text))

        'parameter yang dikirim melalui objek command
        xParamstatus_barang = xCommand.Parameters.Add("@status_barang", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamstatus_barang.Direction = ParameterDirection.Input
        xCommand.Parameters("@status_barang").Value = LTrim(RTrim(txtstatusbarang.Text))

        'parameter yang dikirim melalui objek command
        xParamketerangan = xCommand.Parameters.Add("@keterangan", SqlDbType.NVarChar, 255)
        'direction yg dipakai mode input
        xParamketerangan.Direction = ParameterDirection.Input
        xCommand.Parameters("@keterangan").Value = LTrim(RTrim(txtketerangan.Text))

        'parameter yang dikirim melalui objek command
        xParamharga = xCommand.Parameters.Add("@harga", SqlDbType.Decimal, 9)
        'direction yg dipakai mode input
        xParamharga.Direction = ParameterDirection.Input
        xCommand.Parameters("@harga").Value = LTrim(RTrim(txtHarga.Text))


        'parameter yang dikirim melalui objek command
        xParamCreateBy = xCommand.Parameters.Add("@create_by", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamCreateBy.Direction = ParameterDirection.Input
        xCommand.Parameters("@create_by").Value = LTrim(RTrim(strFullName))


        xCommand.CommandTimeout = 15000
        xCommand.ExecuteNonQuery()

        'hancurkan semua parameter
        xCommand.Parameters.Remove(xParamtgl_beli)
        xCommand.Parameters.Remove(xParamkodeItem)
        xCommand.Parameters.Remove(xParamcara_perolehan)
        xCommand.Parameters.Remove(xParamsumber_dana)
        xCommand.Parameters.Remove(xParamstatus_barang)
        xCommand.Parameters.Remove(xParamketerangan)
        xCommand.Parameters.Remove(xParamharga)
        xCommand.Parameters.Remove(xParamCreateBy)

    End Sub
    'Function GetKodeItemByGroup()
    '    Dim intCounter As Integer
    '    Dim strCounter21 As String
    '    Dim strPeriode As String
    '    Dim strTransactionNo As String
    '    Dim cstrParamPeriode As New SqlClient.SqlParameter


    '    Dim ocmdLasTransaction As New SqlCommand("usp_get_last_counter_master_item", ModuleApp.Koneksi)
    '    With ocmdLasTransaction
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandTimeout = 1000
    '        .Parameters.Add("@kode_group", SqlDbType.NVarChar, 50)
    '        .Parameters("@kode_group").Value = RTrim(LTrim(txtkodeitem.Text))
    '    End With

    '    Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdLasTransaction)
    '    Dim dsLasTransaction As New DataSet
    '    Dim oTblLasTransaction As New DataTable
    '    daLasTransaction.Fill(dsLasTransaction, "tbl_counter_transaction")
    '    oTblLasTransaction = dsLasTransaction.Tables("tbl_counter_transaction")
    '    Dim drLasTransaction As SqlDataReader
    '    drLasTransaction = ocmdLasTransaction.ExecuteReader
    '    Do
    '        While drLasTransaction.Read()
    '            'strPeriode = drLasTransaction(0)
    '            strTransactionNo = drLasTransaction(0)
    '        End While
    '    Loop While drLasTransaction.NextResult()
    '    'strTransactionNo = LTrim(RTrim(cstrPeriodeYear)) + LTrim(RTrim(strCounter21))

    '    'Dim strIntcounter As String
    '    'Dim nLenIntcounter As Integer
    '    'strIntcounter = LTrim(RTrim(Str(intCounter)))
    '    ''  nLenIntcounter = Len(strIntcounter)
    '    'nLenIntcounter = 1
    '    'Select Case nLenIntcounter
    '    '    Case 1
    '    '        strTransactionNo = ".000" + strIntcounter
    '    '    Case 2
    '    '        strTransactionNo = ".00" + strIntcounter
    '    '    Case 3
    '    '        strTransactionNo = ".000" + strIntcounter
    '    '    Case 4
    '    '        strTransactionNo = "." + strIntcounter
    '    '    Case Else
    '    '        strTransactionNo = "." + "xxxx"
    '    'End Select

    '    drLasTransaction.Close()
    '    Return strTransactionNo
    'End Function

    Function GeLimitUmurBytKodeItem()
        Dim intLimitUmur As Integer
        Dim strTransactionNo As String
        Dim cstrParamPeriode As New SqlClient.SqlParameter


        Dim ocmdLasTransaction As New SqlCommand("usp_get_limit_umur_master_item", ModuleApp.Koneksi)
        With ocmdLasTransaction
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 1000
            .Parameters.Add("@kode_item", SqlDbType.NVarChar, 50)
            .Parameters("@kode_item").Value = RTrim(LTrim(txtkodeitem.Text))
        End With

        Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdLasTransaction)
        Dim dsLasTransaction As New DataSet
        Dim oTblLasTransaction As New DataTable
        daLasTransaction.Fill(dsLasTransaction, "tbl_limit_umur_master_item")
        oTblLasTransaction = dsLasTransaction.Tables("tbl_limit_umur_master_item")
        Dim drLasTransaction As SqlDataReader
        drLasTransaction = ocmdLasTransaction.ExecuteReader
        Do
            While drLasTransaction.Read()
                'strPeriode = drLasTransaction(0)
                intLimitUmur = drLasTransaction(0)
            End While
        Loop While drLasTransaction.NextResult()
        drLasTransaction.Close()
        Return intLimitUmur
    End Function
    Private Sub whensearchData()
        LoadsettingTransBeli()
    End Sub
    Private Sub Disabledtoolbar()
        Button_Add.Enabled = False
        Button_Edit.Enabled = False
        Button_Cancel.Enabled = False
        Button_Copy.Enabled = False
        Button_Save.Enabled = False
        Button_Print.Enabled = False
        Button_Load.Enabled = False
        Button_Delete.Enabled = False
    End Sub
    Private Function searchnamaitem()
        Dim cstrnama As String

        Dim ocmdLasTransaction As SqlCommand = New SqlCommand("select nama_item  from tbl_master_item where  kode_item ='" & RTrim(LTrim(txtkodeitem.Text)) & "'", ModuleApp.Koneksi)
        ocmdLasTransaction.CommandTimeout = 1000
        ocmdLasTransaction.CommandType = CommandType.Text


        Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdLasTransaction)
        Dim dsLasTransaction As New DataSet
        Dim oTblLasTransaction As New DataTable
        daLasTransaction.Fill(dsLasTransaction, "tbl_master_item")
        oTblLasTransaction = dsLasTransaction.Tables("tbl_master_item")
        Dim drLasTransaction As SqlDataReader
        drLasTransaction = ocmdLasTransaction.ExecuteReader
        Do
            While drLasTransaction.Read()
                cstrnama = drLasTransaction(0)
            End While
        Loop While drLasTransaction.NextResult()
        drLasTransaction.Close()
        Return cstrnama
    End Function

    'Private Function searchnamagroup()
    '    Dim cstrnama As String

    '    Dim ocmdLasTransaction As SqlCommand = New SqlCommand("select nama_group  from tbl_master_group_item where  kode_group ='" & RTrim(LTrim(txtkodeitem.Text)) & "'", ModuleApp.Koneksi)
    '    ocmdLasTransaction.CommandTimeout = 1000
    '    ocmdLasTransaction.CommandType = CommandType.Text


    '    Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdLasTransaction)
    '    Dim dsLasTransaction As New DataSet
    '    Dim oTblLasTransaction As New DataTable
    '    daLasTransaction.Fill(dsLasTransaction, "tbl_master_group_item")
    '    oTblLasTransaction = dsLasTransaction.Tables("tbl_master_group_item")
    '    Dim drLasTransaction As SqlDataReader
    '    drLasTransaction = ocmdLasTransaction.ExecuteReader
    '    Do
    '        While drLasTransaction.Read()
    '            cstrnama = drLasTransaction(0)
    '        End While
    '    Loop While drLasTransaction.NextResult()
    '    drLasTransaction.Close()
    '    Return cstrnama
    'End Function

    Private Sub Button_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Add.Click
        blankrecord()
        WhenAddRecord()
    End Sub
    Private Sub Button_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Edit.Click
        whenmodify()
    End Sub

    Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save.Click
        whensaverecord()
        disabledpropertyForm()
        ButtonCRUDWhenAfterSave()
    End Sub

    Private Sub Button_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Delete.Click
        WhenDeleteRecord()
        ButtonCRUDWhenDefault()
    End Sub
    Private Sub WhenDeleteRecord()
        idTable2 = Convert.ToString(Me.DataGridViewTransBeli.CurrentRow.Cells(8).Value)
        Dim mResult
        mResult = MsgBox("APAKAH ANDA YAKIN AKAN MENGHAPUS DATA INI?", _
        vbYesNo + vbQuestion, "KONFIRMASI")
        If mResult = vbNo Then
            'Return
            'Me.Dispose()
            ''Me.Hide()
            'frmMenuTreeview.TreeView1.CollapseAll()
            'frmMenuTreeview.TreeView1.ExpandAll()
            'frmMenuTreeview.btnExit.Visible = True
            'frmMenuTreeview.Panel1.Dock = DockStyle.None
            Exit Sub
        Else
            'check dahulu Group tabel master sudah dipakai di transaksi atau tidak ?
            Try
                'con.ConnectionString = cstrSQLKoneksi
                'con.Open()
                'cmd.Connection = con
                'cmd.CommandText = "delete from enis_simpanpinjam_ where kode ='" & RTrim(LTrim(txtKodeSimpanPinjam.Text)) & "'"
                'cmd.ExecuteNonQuery()
                Dim cmdinserttenantPOS1 As New SqlCommand("usp_trans_beli_del#id", ModuleApp.Koneksi)
                With cmdinserttenantPOS1
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16)
                    .Parameters("@id").Value = New Guid(idTable)

                End With
                cmdinserttenantPOS1.CommandTimeout = 30000
                cmdinserttenantPOS1.ExecuteNonQuery()
                MsgBox("PENGHAPUSAN DATA ITEM SUKSES...", MsgBoxStyle.Information)
                LoadsettingTransBeli()
                'If Me.TabControlSimpanPinjam.SelectedIndex = 0 Then
                '    Loadsettingperiodeaccounting()
                'Else
                '    Loadsettingparameterpinjaman()
                'End If

            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "HAPUS DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                'con.Close()
            End Try

        End If

    End Sub

    Private Sub Button_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Search.Click
        TabControl.SelectedTab = TabItemList
        whensearch()
        txtSearch.Focus()
    End Sub
    Private Sub ButtonItemSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemSearch.Click
        whensearchData()
    End Sub

    Private Sub Button_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Cancel.Click
        whencancel2()
        ButtonCRUDWhenCancel()
        'ditambah oleh Leo WS baru...
        GoToFirstRecord()
        'If DataGridViewLokasi.RowCount > 0 Then
        '    LoadsettingLokasi()
        '    DataGridViewLokasi.Rows(0).Selected = True

        'End If
    End Sub

    Private Sub TabItemData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItemData.Click
        ButtonCRUDWhenDefault()


        If (DataGridViewTransBeli.RowCount = 0 And DataGridViewTransBeli.ColumnCount = 0) Then
            Return
        End If



        TabControl.SelectedTab = TabItemData
        Dim i As Integer
        i = DataGridViewTransBeli.CurrentRow.Index

        idTable = Convert.ToString(DataGridViewTransBeli.Rows(i).Cells(8).Value)

        DateTimePickertglbeli.Value = DataGridViewTransBeli.Rows(i).Cells(0).Value
        txtkodeitem.Text = DataGridViewTransBeli.Rows(i).Cells(1).Value
        lblnamaitem.Text = DataGridViewTransBeli.Rows(i).Cells(2).Value
        txtcaraperolehan.Text = DataGridViewTransBeli.Rows(i).Cells(3).Value
        txtsumberdana.Text = DataGridViewTransBeli.Rows(i).Cells(4).Value
        txtstatusbarang.Text = DataGridViewTransBeli.Rows(i).Cells(5).Value
        txtketerangan.Text = DataGridViewTransBeli.Rows(i).Cells(6).Value
        txtHarga.Text = DataGridViewTransBeli.Rows(i).Cells(7).Value

        txtcreatedate.Text = DataGridViewTransBeli.Rows(i).Cells(9).Value
        txtcreateby.Text = DataGridViewTransBeli.Rows(i).Cells(10).Value
        txtlastmodified.Text = DataGridViewTransBeli.Rows(i).Cells(11).Value
        txtmodifiedby.Text = DataGridViewTransBeli.Rows(i).Cells(12).Value
    End Sub

    Private Sub TabItemList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItemList.Click
        Disabledtoolbar()
    End Sub
    Private Sub DataGridViewTransBeli_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewTransBeli.CellClick
        'dttgl_beli, _ 0
        'ckode_Item, _1
        'cnama_Item, _2
        'ccara_perolehan, _3
        'csumber_dana, _ 4
        'cstatus_barang, _5
        'cketerangan, _6
        'nharga, _ 7
        'cid, _  8
        'cCreateDate, _ 9
        'cCreateBy, _10
        'cLastModified, _11
        'cModifiedBy 12

        If (DataGridViewTransBeli.RowCount = 0 And DataGridViewTransBeli.ColumnCount = 0) Then
            Return
        End If


        Dim i As Integer
        i = DataGridViewTransBeli.CurrentRow.Index

        idTable = Convert.ToString(DataGridViewTransBeli.Rows(i).Cells(8).Value)

        DateTimePickertglbeli.Value = DataGridViewTransBeli.Rows(i).Cells(0).Value
        txtkodeitem.Text = DataGridViewTransBeli.Rows(i).Cells(1).Value
        lblnamaitem.Text = DataGridViewTransBeli.Rows(i).Cells(2).Value
        txtcaraperolehan.Text = DataGridViewTransBeli.Rows(i).Cells(3).Value
        txtsumberdana.Text = DataGridViewTransBeli.Rows(i).Cells(4).Value
        txtstatusbarang.Text = DataGridViewTransBeli.Rows(i).Cells(5).Value
        txtketerangan.Text = DataGridViewTransBeli.Rows(i).Cells(6).Value
        txtHarga.Text = DataGridViewTransBeli.Rows(i).Cells(7).Value

        txtcreatedate.Text = DataGridViewTransBeli.Rows(i).Cells(9).Value
        txtcreateby.Text = DataGridViewTransBeli.Rows(i).Cells(10).Value
        txtlastmodified.Text = DataGridViewTransBeli.Rows(i).Cells(11).Value
        txtmodifiedby.Text = DataGridViewTransBeli.Rows(i).Cells(12).Value
    End Sub
    Private Sub DataGridViewTransBeli_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewTransBeli.CellDoubleClick
        If (DataGridViewTransBeli.RowCount = 0 And DataGridViewTransBeli.ColumnCount = 0) Then
            Return
        End If

        Try
            TabControl.SelectedTab = TabItemData
            'ckode_lokasi, _
            '      cnama_lokasi, _
            '      cketerangan, _
            '      cid
            '})

            Dim i As Integer
            i = DataGridViewTransBeli.CurrentRow.Index


            idTable = Convert.ToString(DataGridViewTransBeli.Rows(e.RowIndex).Cells(8).Value)

            DateTimePickertglbeli.Value = DataGridViewTransBeli.Rows(e.RowIndex).Cells(0).Value
            txtkodeitem.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(1).Value
            lblnamaitem.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(2).Value
            txtcaraperolehan.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(3).Value
            txtsumberdana.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(4).Value
            txtstatusbarang.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(5).Value
            txtketerangan.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(6).Value
            txtHarga.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(7).Value

            'recorded
            txtcreatedate.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(9).Value
            txtcreateby.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(10).Value
            txtlastmodified.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(11).Value
            txtmodifiedby.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(12).Value



        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridViewTransBeli_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewTransBeli.CellMouseDoubleClick
        If (DataGridViewTransBeli.RowCount = 0 And DataGridViewTransBeli.ColumnCount = 0) Then
            Return
        End If

        Try
            TabControl.SelectedTab = TabItemData
            'ckode_lokasi, _
            '      cnama_lokasi, _
            '      cketerangan, _
            '      cid
            '})
            Dim i As Integer
            i = DataGridViewTransBeli.CurrentRow.Index

            idTable = Convert.ToString(DataGridViewTransBeli.Rows(e.RowIndex).Cells(8).Value)

            DateTimePickertglbeli.Value = DataGridViewTransBeli.Rows(e.RowIndex).Cells(0).Value
            txtkodeitem.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(1).Value
            lblnamaitem.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(2).Value
            txtcaraperolehan.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(3).Value
            txtsumberdana.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(4).Value
            txtstatusbarang.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(5).Value
            txtketerangan.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(6).Value
            txtHarga.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(7).Value

            'recorded
            txtcreatedate.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(9).Value
            txtcreateby.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(10).Value
            txtlastmodified.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(11).Value
            txtmodifiedby.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(12).Value

            'txtkodegroup.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(0).Value
            'lblnamagroup.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(1).Value
            ''DateTimePickerStartDate.Value = DataGridViewLokasi.Rows(e.RowIndex).Cells(4).Value
            ''DateTimePickerEnDate.Value = DataGridViewLokasi.Rows(e.RowIndex).Cells(5).Value
            ''txtNominal.Text = FormatNumber(DataGridViewLokasi.Rows(e.RowIndex).Cells(3).Value, 2, TriState.UseDefault)
            ''recorded
            'txtcreatedate.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(3).Value
            'txtcreateby.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(4).Value
            'txtlastmodified.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(5).Value
            'txtmodifiedby.Text = DataGridViewTransBeli.Rows(e.RowIndex).Cells(6).Value

        Catch ex As Exception

        End Try


        ButtonCRUDWhenDefault()
    End Sub
    Private Sub btnSearchkodeitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchkodeitem.Click
        whensearchItem()
    End Sub
    Private Sub whensearchItem()
        frmSearchMasterItem.ShowDialog()
        'frmToolTip.ShowDialog()

        txtkodeitem.Text = pstrKodeItem
        txtkodeitem.Focus()
    End Sub

    Private Sub ToolStrip1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip1.MouseHover
        If savedCursor Is Nothing Then
            savedCursor = Me.Cursor
            Me.Cursor = Cursors.Hand
        End If
    End Sub
    Private Sub ToolStrip1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip1.MouseLeave
        Me.Cursor = savedCursor
        savedCursor = Nothing
    End Sub
    Private Sub DateTimePickertglbeli_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickertglbeli.Enter

        btnSearchkodeitem.Focus()
        'txtkodeitem.Focus()    'Add Row Table
        'txtKodeItems.Enabled = True

    End Sub
    Private Sub txtkodeitem_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkodeitem.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtcaraperolehan.Focus()    'Add Row Table
            'txtKodeItems.Enabled = True
        End If
    End Sub
    Private Sub txtcaraperolehan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcaraperolehan.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtsumberdana.Focus()    'Add Row Table
            'txtKodeItems.Enabled = True
        End If
    End Sub

    Private Sub txtsumberdana_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsumberdana.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtstatusbarang.Focus()    'Add Row Table
            'txtKodeItems.Enabled = True
        End If

    End Sub

    Private Sub txtstatusbarang_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstatusbarang.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtketerangan.Focus()    'Add Row Table
            'txtKodeItems.Enabled = True
        End If
    End Sub

    Private Sub txtketerangan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtketerangan.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtHarga.Focus()    'Add Row Table
            'txtKodeItems.Enabled = True
        End If

    End Sub
    Private Sub txtHarga_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            ToolStrip1.Focus()
            Button_Save.Select()
            'txtKodeItems.Enabled = True
        End If
    End Sub
    Private Sub txtkodeitem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodeitem.TextChanged
        lblnamaitem.Text = searchnamaitem()
    End Sub
    Private Sub btnCalcAssetRp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcAssetRp.Click
        '  frmInfoAssetoSusut.ShowDialog()

        'Dim dlg As Form2 = New Form2(CustomerID)
        'dlg.ShowDialog()

        '@tgl_beli        datetime = null ,
        '@kode_item	nvarchar(50) = null ,
        '@limit_umur   int = null,
        '@harga_beli   decimal(18,2)

        If LTrim(RTrim(txtkodeitem.Text)) = "" Then
            MsgBox("Data Item Tidak Boleh Kosong", MsgBoxStyle.Critical)
            Return
        End If

        Dim paramdt_tgl_beli As DateTime = DateTimePickertglbeli.Value.Date
        Dim paramstr_kode_item As String = LTrim(RTrim(txtkodeitem.Text))
        Dim paramint_limit_umur As Integer = GeLimitUmurBytKodeItem()
        Dim paramDec_harga_beli As Decimal = txtHarga.Text
        Dim paramtext_nama_item As String = RTrim(LTrim(lblnamaitem.Text))

        Dim frmInfoAssetoSusut2 As frmInfoAssetoSusut = New frmInfoAssetoSusut(paramdt_tgl_beli, paramstr_kode_item, paramint_limit_umur, paramDec_harga_beli, paramtext_nama_item)
        frmInfoAssetoSusut2.ShowDialog()
    End Sub
End Class
