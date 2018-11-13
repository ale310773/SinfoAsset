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
Public Class frmMasterItem
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
    Public strDateTglLahir As Date
    Public strDateTglLapor As Date
    Public strDateTglTransaksi As Date
    Private bindingSource1 As New BindingSource()
    Private savedCursor As Windows.Forms.Cursor

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
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Loadcbokategori()
        autocompetesearchgroup()
        ItemPanelPencarianData.Visible = False
        TabControl.Location = New Point(30, 30)

        GroupPanel1.Text = "Master Item"

        disabledpropertyForm()
        ButtonCRUDWhenDefault()

        'If DataGridViewItem.RowCount > 0 Then
        '    LoadsettingItem()
        '    Try

        '        DataGridViewItem.Rows(0).Selected = True
        '    Catch ex As Exception

        '    End Try

        'End If
        Try
            'If Not DataGridViewItem.CurrentCell Is DBNull.Value Then
            '    LoadsettingItem()
            'End If
            If (DataGridViewItem.RowCount > 0 And DataGridViewItem.ColumnCount > 0) Then
                'MsgBox("DataGridView has no rows or columns!!")
                'Return
                LoadsettingItem()
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
    Private Sub Loadcbokategori()
        'Dim strSQL As String = "select kode_kategori,nama_kategori,2 as angka union '--PILIH--','--PILIH--',1 as angka  from dbo.tbl_master_kategori order by  angka "
        Dim strSQL As String = "select a.* from (select kode_kategori,nama_kategori,2 as angka  from dbo.tbl_master_kategori union select '--PILIH--','--PILIH--', 1 as angka ) a order by a.angka,a.nama_kategori"
        Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, ModuleApp.Koneksi)
        Dim ds As New DataSet
        da.Fill(ds, "kategori")
        With Me.cbokategori
            .DataSource = ds.Tables("kategori")
            .DisplayMember = "nama_kategori"
            .ValueMember = "kode_kategori"
            .SelectedIndex = 0
        End With
        'Dim adapter As New SqlDataAdapter("select dbo.tbl_items.nama ,dbo.tbl_satuan.nama  ,dbo.tbl_items.create_date ,dbo.tbl_items.create_by ,dbo.tbl_items.last_modified ,dbo.tbl_items.modified_by from dbo.tbl_items inner join dbo.tbl_satuan on dbo.tbl_items.satuan_id = dbo.tbl_satuan.id ", Module1.Koneksi)
        'Dim dt As New DataTable("items")
    End Sub


    Private Sub disabledpropertyForm()
        txtkodegroup.ReadOnly = True
        txtkodegroup.ForeColor = Color.Black
        txtkodegroup.BackColor = Color.Gold

        txtkodeitem.ReadOnly = True
        txtkodeitem.ForeColor = Color.Black
        txtkodeitem.BackColor = Color.Gold

        txtnamaitem.ReadOnly = True
        txtnamaitem.ForeColor = Color.Black
        txtnamaitem.BackColor = Color.Gold

        txtketerangan.ReadOnly = True
        txtketerangan.ForeColor = Color.Black
        txtketerangan.BackColor = Color.Gold

        txtbarcode.ReadOnly = True
        txtbarcode.ForeColor = Color.Black
        txtbarcode.BackColor = Color.Gold

        txtlimitumur.ReadOnly = True
        txtlimitumur.ForeColor = Color.Black
        txtlimitumur.BackColor = Color.Gold

        cbokategori.Enabled = False
        cbokategori.ForeColor = Color.Black
        cbokategori.BackColor = Color.Gold
        cbokategori.DisabledForeColor = Color.Black
        cbokategori.DisabledBackColor = Color.Gold

        txtMerk.ReadOnly = True
        txtMerk.ForeColor = Color.Black
        txtMerk.BackColor = Color.Gold


        txtType.ReadOnly = True
        txtType.ForeColor = Color.Black
        txtType.BackColor = Color.Gold

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


        txtFileName.ReadOnly = True
        txtFileName.ForeColor = Color.Black
        txtFileName.BackColor = Color.Gold


        txtLokasiFoto.ReadOnly = True
        txtLokasiFoto.ForeColor = Color.Black
        txtLokasiFoto.BackColor = Color.Gold



        btngetpicture.Enabled = False
        btnSearchkodeGroup.Enabled = False


    End Sub
    Private Sub enabledpropertyForm()
        If chrStatusSave = "ADD" Then
            txtkodegroup.ReadOnly = True
            txtkodeitem.ReadOnly = True
        Else
            txtkodegroup.ReadOnly = True
            txtkodeitem.ReadOnly = True
        End If

        txtkodegroup.ForeColor = Color.Black
        txtkodegroup.BackColor = Color.GreenYellow

        txtkodeitem.ForeColor = Color.Black
        txtkodeitem.BackColor = Color.GreenYellow


        txtnamaItem.ReadOnly = False
        txtnamaItem.ForeColor = Color.Black
        txtnamaitem.BackColor = Color.GreenYellow


        txtketerangan.ReadOnly = False
        txtketerangan.ForeColor = Color.Black
        txtketerangan.BackColor = Color.GreenYellow

        txtbarcode.ReadOnly = False
        txtbarcode.ForeColor = Color.Black
        txtbarcode.BackColor = Color.GreenYellow

        txtlimitumur.ReadOnly = False
        txtlimitumur.ForeColor = Color.Black
        txtlimitumur.BackColor = Color.GreenYellow

        cbokategori.Enabled = True
        cbokategori.ForeColor = Color.Black
        cbokategori.BackColor = Color.GreenYellow

        txtMerk.ReadOnly = False
        txtMerk.ForeColor = Color.Black
        txtMerk.BackColor = Color.GreenYellow


        txtType.ReadOnly = False
        txtType.ForeColor = Color.Black
        txtType.BackColor = Color.GreenYellow


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


        txtFileName.ReadOnly = True
        txtFileName.ForeColor = Color.Black
        txtFileName.BackColor = Color.GreenYellow


        txtLokasiFoto.ReadOnly = True
        txtLokasiFoto.ForeColor = Color.Black
        txtLokasiFoto.BackColor = Color.GreenYellow



        btngetpicture.Enabled = True
        btnSearchkodeGroup.Enabled = True


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

        'DataGridViewItem.Enabled = True
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
        LoadsettingItem()
        disabledpropertyForm()

        'If DataGridViewItem.RowCount > 0 Then
        '    DataGridViewItem.Rows(0).Selected = True
        'End If
    End Sub
    Private Sub LoadsettingItem()
        ' refreshGroup()
        refreshItem2()
        SetFormattingGridViewItem()
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
    '    DataGridViewItem.DataSource = dt
    '    Dim tblsalestenant As DataTable
    '    tblsalestenant = dt
    'End Sub
    Private Sub refreshItem2()

        Dim cstrParamSearch As New SqlClient.SqlParameter
        Dim cstrsearch As String = RTrim(LTrim(txtSearch.Text))
        Dim ocmdLasTransaction As SqlCommand = New SqlCommand("usp_search_master_Item_sel", ModuleApp.Koneksi)
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
        DataGridViewItem.DataSource = oTblLasTransaction




    End Sub
    Private Sub SetFormattingGridViewItem()

        Dim ckode_Item As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cnama_Item As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim ckode_group As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cnama_group As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cketerangan As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim ckode_barcode As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim nlimit_umur As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim ckode_kategori As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cnama_kategori As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cid As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cMerk As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cType2 As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cFoto As System.Windows.Forms.DataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn
        Dim cLokasiFoto As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn


        Dim cCreateDate As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cCreateBy As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cLastModified As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cModifiedBy As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn


        'Dim cID As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim cTipe As System.Windows.Forms.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn

        'DataGridViewItem.Rows.c  


        ckode_group.Name = "kode_group"
        ckode_group.HeaderText = "Kode Group"
        ckode_group.DataPropertyName = "kode_group"
        ckode_group.Width = 100
        ckode_group.Visible = True
        ckode_group.ReadOnly = True
        ckode_group.DefaultCellStyle.BackColor = Color.BlanchedAlmond




        cnama_group.Name = "nama_group"
        cnama_group.HeaderText = "Nama Group"
        cnama_group.DataPropertyName = "nama_group"
        cnama_group.Width = 100
        cnama_group.Visible = True
        cnama_group.ReadOnly = True
        cnama_group.DefaultCellStyle.BackColor = Color.BlanchedAlmond

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

        cketerangan.Name = "keterangan"
        cketerangan.HeaderText = "Keterangan"
        cketerangan.DataPropertyName = "keterangan"
        cketerangan.Width = 200
        cketerangan.Visible = True
        cketerangan.ReadOnly = True
        cketerangan.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        ckode_barcode.Name = "kode_barcode"
        ckode_barcode.HeaderText = "Barcode"
        ckode_barcode.DataPropertyName = "kode_barcode"
        ckode_barcode.Width = 100
        ckode_barcode.Visible = True
        ckode_barcode.ReadOnly = True
        ckode_barcode.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        nlimit_umur.Name = "limit_umur"
        nlimit_umur.HeaderText = "Limit Umur"
        nlimit_umur.DataPropertyName = "limit_umur"
        nlimit_umur.Width = 80
        nlimit_umur.Visible = True
        nlimit_umur.ReadOnly = True
        nlimit_umur.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        ckode_kategori.Name = "kode_kategori"
        ckode_kategori.HeaderText = "Kode Kategori"
        ckode_kategori.DataPropertyName = "kode_kategori"
        ckode_kategori.Width = 60
        ckode_kategori.Visible = True
        ckode_kategori.ReadOnly = True
        ckode_kategori.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        cnama_kategori.Name = "nama_kategori"
        cnama_kategori.HeaderText = "Kategori"
        cnama_kategori.DataPropertyName = "nama_kategori"
        cnama_kategori.Width = 60
        cnama_kategori.Visible = True
        cnama_kategori.ReadOnly = True
        cnama_kategori.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        cMerk.Name = "merk"
        cMerk.HeaderText = "Merk"
        cMerk.DataPropertyName = "merk"
        cMerk.Width = 60
        cMerk.Visible = True
        cMerk.ReadOnly = True
        cMerk.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        cFoto.Name = "Foto"
        cFoto.HeaderText = "Foto"
        cFoto.DataPropertyName = "Foto"
        cFoto.Width = 60
        cFoto.Visible = True
        cFoto.ReadOnly = True
        cFoto.ImageLayout = DataGridViewImageCellLayout.Stretch
        cFoto.DefaultCellStyle.BackColor = Color.BlanchedAlmond


        cLokasiFoto.Name = "lokasi_foto"
        cLokasiFoto.HeaderText = "Lokasi Foto"
        cLokasiFoto.DataPropertyName = "lokasi_foto"
        cLokasiFoto.Width = 60
        cLokasiFoto.Visible = True
        cLokasiFoto.ReadOnly = True
        cLokasiFoto.DefaultCellStyle.BackColor = Color.BlanchedAlmond


        cType2.Name = "type"
        cType2.HeaderText = "Type"
        cType2.DataPropertyName = "type"
        cType2.Width = 60
        cType2.Visible = True
        cType2.ReadOnly = True
        cType2.DefaultCellStyle.BackColor = Color.BlanchedAlmond


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

        DataGridViewItem.AllowUserToAddRows = False
        DataGridViewItem.AllowUserToDeleteRows = True
        DataGridViewItem.AutoGenerateColumns = False
        DataGridViewItem.Columns.Clear()

        '"select  sales_date,tenant_id, kode , menu , price , ppn , price_ppn , qty_sales , total_sales from tbl_temp_sales ", Module1.Koneksi)
        DataGridViewItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() _
        { _
        ckode_group, _
        cnama_group, _
        ckode_Item, _
        cnama_Item, _
        cketerangan, _
        ckode_barcode, _
        nlimit_umur, _
        ckode_kategori, _
        cnama_kategori, _
        cMerk, _
        cType2, _
        cFoto, _
        cLokasiFoto, _
        cid, _
        cCreateDate, _
        cCreateBy, _
        cLastModified, _
        cModifiedBy _
        })
        Me.DataGridViewItem.AllowUserToAddRows = False

        'Me.DataGridViewItem.Columns.Item(3).DefaultCellStyle.Format = "n2"      'nominal 
        '   setting format datetime dataGridView1.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
        'Me.DataGridViewItem.Columns.Item(4).DefaultCellStyle.Format = "dd/MM/yyyy"      'net sales
        'Me.DataGridViewItem.Columns.Item(5).DefaultCellStyle.Format = "dd/MM/yyyy"      'net sales


        'For i = 0 To DataGridViewItem.Rows.Count - 1
        '    DataGridViewItem.Rows(i).Height = 100
        'Next
        DataGridViewItem.RowTemplate.Height = 70

    End Sub
    Private Sub blankrecord()
        txtkodegroup.Text = ""
        txtkodeitem.Text = ""
        txtnamaitem.Text = ""

        txtketerangan.Text = ""
        txtbarcode.Text = ""
        txtlimitumur.Text = ""
        ' cbokategori.SelectedText = "--PILIH--"
        txtMerk.Text = ""
        txtType.Text = ""

        txtcreatedate.Text = ""
        txtcreateby.Text = ""
        txtlastmodified.Text = ""
        txtmodifiedby.Text = ""

        PictureBoxFotoAsset.Image = Nothing
        txtLokasiFoto.Text = ""
        txtFileName.Text = ""
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

        btnSearchkodeGroup.Focus()
        txtnamaitem.Text = ""

        '  txtPeriodeAcounting.Focus()
    End Sub
    Private Sub GoToFirstRecord()

        'DateTimePickerSalesDate.Value = DataGridView1.Item(2, i).Value
        'txtReferenceNo.Text = DataGridView1.Item(0, i).Value
        'txtNomeranggota.Text = DataGridView1.Item(1, i).Value
        'cboKodeJenisSimpan.SelectedValue = DataGridView1.Item(3, i).Value
        'txtInstallment2.Text = DataGridView1.Item(10, i).Value
        'txtInterval.Text = DataGridView1.Item(12, i).Value
        'cboPeriodeInterval.SelectedValue = DataGridView1.Item(11, i).Value
        'dateTimePickerTglAwalKomponen.Value = DataGridView1.Item(13, i).Value
        'DateTimePickerTglAkhirKomponen.Value = DataGridView1.Item(14, i).Value
        'txtPokok.Text = DataGridView1.Item(4, i).Value
        'txtBunga.Text = DataGridView1.Item(5, i).Value
        'txtTotal.Text = DataGridView1.Item(6, i).Value
        'txtptongantotalperbln.Text = DataGridView1.Item(7, i).Value
        'txtptonganpokoperbln.Text = DataGridView1.Item(8, i).Value
        'txtptonganbungaperbln.Text = DataGridView1.Item(9, i).Value
        'idTable = DataGridView1.Item(15, i).Value

        'Select 
        'tbl_transaksi.reference_no,       0
        'tbl_transaksi.no_anggota,  1
        'tbl_anggota.Nama ,  2
        'tbl_transaksi.tgl_transaksi,  3
        'tbl_transaksi.kode_jenis_komponen , 4
        'tbl_transaksi.pokok ,  5
        'tbl_transaksi.bunga, 6
        'tbl_transaksi.total, 7
        'tbl_transaksi.potongan_total_bln, 8
        'tbl_transaksi.potongan_pokok_bln, 9
        'tbl_transaksi.potongan_bunga_bln, 10 
        'tbl_transaksi.installment, 11
        'tbl_transaksi.tipe_periode, 12
        'tbl_transaksi.interval, 13
        'tbl_transaksi.tgl_awal,  14
        'tbl_transaksi.tgl_akhir, 15
        'tbl_transaksi.id  ,  16
        'tbl_transaksi.is_special_case,  17
        'tbl_transaksi.bunga_special   18
        'From tbl_transaksi inner join tbl_anggota on tbl_transaksi.no_anggota = tbl_anggota.no_anggota

        If (DataGridViewItem.RowCount = 0 And DataGridViewItem.ColumnCount = 0) Then
            Return
        End If


        DataGridViewItem.CurrentCell = DataGridViewItem.Rows(0).Cells(0)

        If IsDBNull(DataGridViewItem.Rows(0).Cells(0).Value) Then
            Return
        End If
        Try

            idTable = Convert.ToString(DataGridViewItem.Rows(0).Cells(13).Value)

            txtkodegroup.Text = DataGridViewItem.Rows(0).Cells(0).Value
            lblnamagroup.Text = DataGridViewItem.Rows(0).Cells(1).Value
            txtkodeitem.Text = DataGridViewItem.Rows(0).Cells(2).Value
            txtnamaitem.Text = DataGridViewItem.Rows(0).Cells(3).Value
            txtketerangan.Text = DataGridViewItem.Rows(0).Cells(4).Value
            txtbarcode.Text = DataGridViewItem.Rows(0).Cells(5).Value
            txtlimitumur.Text = DataGridViewItem.Rows(0).Cells(6).Value
            cbokategori.SelectedValue = DataGridViewItem.Rows(0).Cells(7).Value
            '  txtkodegroup.Text = DataGridViewItem.Rows(i).Cells(0).Value
            txtMerk.Text = DataGridViewItem.Rows(0).Cells(9).Value
            txtType.Text = DataGridViewItem.Rows(0).Cells(10).Value


            Try
                Dim arr() As Byte
                arr = DataGridViewItem.Rows(0).Cells(11).Value
                PictureBoxFotoAsset.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBoxFotoAsset.Image = Image.FromStream(New IO.MemoryStream(arr))

            Catch ex As Exception

            End Try

            '       PictureBoxFotoAsset.Image = DataGridViewItem.Rows(i).Cells(11).Value
            txtLokasiFoto.Text = DataGridViewItem.Rows(0).Cells(12).Value

            '...idTable = Convert.ToString(DataGridView1.Item(20, i).Value)

            txtcreatedate.Text = DataGridViewItem.Rows(0).Cells(14).Value
            txtcreateby.Text = DataGridViewItem.Rows(0).Cells(15).Value
            txtlastmodified.Text = DataGridViewItem.Rows(0).Cells(16).Value
            txtmodifiedby.Text = DataGridViewItem.Rows(0).Cells(17).Value


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
    Private Sub whensaverecord()
        'If txtkodegroup.Text = "" Then
        '    MsgBox("KODE TIDAK BOLEH KOSONG !", MsgBoxStyle.Information)
        '    txtkodegroup.ReadOnly = False
        '    Return
        'End If

        If cbokategori.Text = "--PILIH--" Or txtkodegroup.Text = "" Then
            MsgBox("KATEGORI BARANG HARUS DIISI / DIPILIH ATAU KODE GROUP BELUM DIISI", MsgBoxStyle.Critical)
            blankrecord()
            Return
        End If



        Dim ckode As String = ""
        Dim cgrade As String = ""

        Try
            If chrStatusSave = "ADD" Then
                saverecordItem()
                LoadsettingItem()
            Else
                UpdaterecordItem()
                LoadsettingItem()
            End If
            If DataGridViewItem.RowCount > 0 Then
                DataGridViewItem.Rows(0).Selected = True
            End If
            If chrStatusSave = "ADD" Then
                MessageBox.Show("TAMBAH DATA ITEM SUKSES...", "SAVE RECORDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("UPDATE DATA ITEM SUKSES...", "SAVE RECORDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            'MessageBox.Show("error while void record sales on table..." & ex.Message, "save records")
            MessageBox.Show("ERROR :" & ex.Message, "SAVE RECORDS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            blankrecord()
        Finally
            'con.close()
        End Try
        txtkodegroup.ReadOnly = True


    End Sub
    Private Sub UpdaterecordItem()

        idTable2 = Convert.ToString(Me.DataGridViewItem.CurrentRow.Cells(13).Value)
        xCommand.Connection = sqlconn

        Dim xParamId As New SqlClient.SqlParameter
        Dim xParamkodeGroup As New SqlClient.SqlParameter
        Dim xParamkodeItem As New SqlClient.SqlParameter
        Dim xParamnamaItem As New SqlClient.SqlParameter
        Dim xParamketerangan As New SqlClient.SqlParameter
        Dim xParamkode_barcode As New SqlClient.SqlParameter
        Dim xParamlimit_umur As New SqlClient.SqlParameter
        Dim xParamkode_kategori As New SqlClient.SqlParameter
        Dim xParamMerk As New SqlClient.SqlParameter
        Dim xParamType As New SqlClient.SqlParameter
        Dim xParamModifiedBy As New SqlClient.SqlParameter
        Dim xParamfoto As New SqlClient.SqlParameter
        Dim xParamlokasifoto As New SqlClient.SqlParameter

        'untuk gambar foto !!!
        Dim ms As New System.IO.MemoryStream()
        PictureBoxFotoAsset.Image.Save(ms, PictureBoxFotoAsset.Image.RawFormat)
        Dim CPic() As Byte = ms.GetBuffer
        ms.Close()


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


        xCommand.CommandText = "usp_master_item_upd#id"
        xCommand.CommandType = CommandType.StoredProcedure

        'parameter yang dikirim melalui objek command
        xParamId = xCommand.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16)
        'direction yg dipakai mode input
        xParamId.Direction = ParameterDirection.Input
        xCommand.Parameters("@id").Value = New Guid(idTable2)
        'idTable2
        'New Guid(idTable2)

        'parameter yang dikirim melalui objek command
        xParamkodeItem = xCommand.Parameters.Add("@kode_item", SqlDbType.NVarChar, 50)
        'direction yg dipakai mode input
        xParamkodeItem.Direction = ParameterDirection.Input
        xCommand.Parameters("@kode_item").Value = LTrim(RTrim(txtkodeitem.Text))


        'parameter yang dikirim melalui objek command
        xParamnamaItem = xCommand.Parameters.Add("@nama_Item", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamnamaItem.Direction = ParameterDirection.Input
        xCommand.Parameters("@nama_Item").Value = LTrim(RTrim(txtnamaitem.Text))

        'parameter yang dikirim melalui objek command
        xParamketerangan = xCommand.Parameters.Add("@keterangan", SqlDbType.NVarChar, 255)
        'direction yg dipakai mode input
        xParamketerangan.Direction = ParameterDirection.Input
        xCommand.Parameters("@keterangan").Value = LTrim(RTrim(txtketerangan.Text))

        'parameter yang dikirim melalui objek command
        xParamkode_barcode = xCommand.Parameters.Add("@kode_barcode", SqlDbType.NVarChar, 50)
        'direction yg dipakai mode input
        xParamkode_barcode.Direction = ParameterDirection.Input
        xCommand.Parameters("@kode_barcode").Value = LTrim(RTrim(txtbarcode.Text))

        'parameter yang dikirim melalui objek command
        xParamlimit_umur = xCommand.Parameters.Add("@limit_umur", SqlDbType.Int, 4)
        'direction yg dipakai mode input
        xParamlimit_umur.Direction = ParameterDirection.Input
        xCommand.Parameters("@limit_umur").Value = LTrim(RTrim(txtlimitumur.Text))

        'parameter yang dikirim melalui objek command
        xParamkodeGroup = xCommand.Parameters.Add("@kode_group", SqlDbType.NVarChar, 50)
        'direction yg dipakai mode input
        xParamkodeGroup.Direction = ParameterDirection.Input
        xCommand.Parameters("@kode_group").Value = LTrim(RTrim(txtkodegroup.Text))

        'parameter yang dikirim melalui objek command
        xParamkode_kategori = xCommand.Parameters.Add("@kode_kategori", SqlDbType.NVarChar, 5)
        'direction yg dipakai mode input
        xParamkode_kategori.Direction = ParameterDirection.Input
        xCommand.Parameters("@kode_kategori").Value = LTrim(RTrim(cbokategori.SelectedValue))


        'parameter yang dikirim melalui objek command
        xParamMerk = xCommand.Parameters.Add("@merk", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamMerk.Direction = ParameterDirection.Input
        xCommand.Parameters("@merk").Value = LTrim(RTrim(txtMerk.Text))


        'parameter yang dikirim melalui objek command
        xParamType = xCommand.Parameters.Add("@type", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamType.Direction = ParameterDirection.Input
        xCommand.Parameters("@type").Value = LTrim(RTrim(txtType.Text))


        'parameter yang dikirim melalui objek command
        xParamfoto = xCommand.Parameters.Add("@foto", SqlDbType.Image, 900000000)
        'direction yg dipakai mode input
        xParamfoto.Direction = ParameterDirection.Input
        xCommand.Parameters("@foto").Value = CPic

        'parameter yang dikirim melalui objek command
        xParamlokasifoto = xCommand.Parameters.Add("@lokasi_foto", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamlokasifoto.Direction = ParameterDirection.Input
        xCommand.Parameters("@lokasi_foto").Value = LTrim(RTrim(txtLokasiFoto.Text))



        'parameter yang dikirim melalui objek command
        xParamModifiedBy = xCommand.Parameters.Add("@modified_by", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamModifiedBy.Direction = ParameterDirection.Input
        xCommand.Parameters("@modified_by").Value = LTrim(RTrim(strFullName))


        xCommand.CommandTimeout = 15000
        xCommand.ExecuteNonQuery()

        'hancurkan semua parameter
        xCommand.Parameters.Remove(xParamId)
        xCommand.Parameters.Remove(xParamkodeGroup)
        xCommand.Parameters.Remove(xParamkodeItem)
        xCommand.Parameters.Remove(xParamnamaItem)
        xCommand.Parameters.Remove(xParamketerangan)
        xCommand.Parameters.Remove(xParamkode_barcode)
        xCommand.Parameters.Remove(xParamlimit_umur)
        xCommand.Parameters.Remove(xParamkode_kategori)
        xCommand.Parameters.Remove(xParamMerk)
        xCommand.Parameters.Remove(xParamType)
        xCommand.Parameters.Remove(xParamfoto)
        xCommand.Parameters.Remove(xParamlokasifoto)
        xCommand.Parameters.Remove(xParamModifiedBy)
    End Sub
    Private Sub saverecordItem()
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
        Dim xParamkodeGroup As New SqlClient.SqlParameter
        Dim xParamnamaGroup As New SqlClient.SqlParameter
        Dim xParamkodeItem As New SqlClient.SqlParameter
        Dim xParamnamaItem As New SqlClient.SqlParameter
        Dim xParamketerangan As New SqlClient.SqlParameter
        Dim xParamkode_barcode As New SqlClient.SqlParameter
        Dim xParamlimit_umur As New SqlClient.SqlParameter
        Dim xParamkode_kategori As New SqlClient.SqlParameter
        Dim xParamMerk As New SqlClient.SqlParameter
        Dim xParamType As New SqlClient.SqlParameter
        Dim xParamfoto As New SqlClient.SqlParameter
        Dim xParamlokasifoto As New SqlClient.SqlParameter

        Dim xParamCreateBy As New SqlClient.SqlParameter

        Dim ms As New System.IO.MemoryStream()
        PictureBoxFotoAsset.Image.Save(ms, PictureBoxFotoAsset.Image.RawFormat)
        Dim CPic() As Byte = ms.GetBuffer
        ms.Close()



        xCommand.Parameters.Clear()

        xCommand.CommandText = "usp_master_item_ins"
        xCommand.CommandType = CommandType.StoredProcedure

        'parameter yang dikirim melalui objek command
        xParamkodeGroup = xCommand.Parameters.Add("@kode_Group", SqlDbType.NVarChar, 50)
        'direction yg dipakai mode input
        xParamkodeGroup.Direction = ParameterDirection.Input
        xCommand.Parameters("@kode_Group").Value = LTrim(RTrim(txtkodegroup.Text))

        Try
            txtkodeitem.Text = LTrim(RTrim(txtkodegroup.Text)) + "." + GetKodeItemByGroup()
            txtbarcode.Text = LTrim(RTrim(txtkodegroup.Text)) + "." + GetKodeItemByGroup()
            'txtbarcode.Text = LTrim(RTrim(txtkodegroup.Text)) + "." + RandomBarCode()
            'txtbarcode.Text = RandomBarCode()
        Catch ex As Exception

        End Try

        'parameter yang dikirim melalui objek command
        xParamkodeItem = xCommand.Parameters.Add("@kode_item", SqlDbType.NVarChar, 50)
        'direction yg dipakai mode input
        xParamkodeItem.Direction = ParameterDirection.Input
        xCommand.Parameters("@kode_item").Value = LTrim(RTrim(txtkodeitem.Text))


        'parameter yang dikirim melalui objek command
        xParamnamaItem = xCommand.Parameters.Add("@nama_item", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamnamaItem.Direction = ParameterDirection.Input
        xCommand.Parameters("@nama_item").Value = LTrim(RTrim(txtnamaitem.Text))

        'parameter yang dikirim melalui objek command
        xParamketerangan = xCommand.Parameters.Add("@keterangan", SqlDbType.NVarChar, 255)
        'direction yg dipakai mode input
        xParamketerangan.Direction = ParameterDirection.Input
        xCommand.Parameters("@keterangan").Value = LTrim(RTrim(txtketerangan.Text))

        'parameter yang dikirim melalui objek command
        xParamkode_barcode = xCommand.Parameters.Add("@kode_barcode", SqlDbType.NVarChar, 50)
        'direction yg dipakai mode input
        xParamkode_barcode.Direction = ParameterDirection.Input
        xCommand.Parameters("@kode_barcode").Value = LTrim(RTrim(txtbarcode.Text))

        'parameter yang dikirim melalui objek command
        xParamlimit_umur = xCommand.Parameters.Add("@limit_umur", SqlDbType.Int, 4)
        'direction yg dipakai mode input
        xParamlimit_umur.Direction = ParameterDirection.Input
        xCommand.Parameters("@limit_umur").Value = LTrim(RTrim(txtlimitumur.Text))

        'parameter yang dikirim melalui objek command
        xParamkode_kategori = xCommand.Parameters.Add("@kode_kategori", SqlDbType.NVarChar, 5)
        'direction yg dipakai mode input
        xParamkode_kategori.Direction = ParameterDirection.Input
        xCommand.Parameters("@kode_kategori").Value = LTrim(RTrim(cbokategori.SelectedValue))


        'parameter yang dikirim melalui objek command
        xParamMerk = xCommand.Parameters.Add("@merk", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamMerk.Direction = ParameterDirection.Input
        xCommand.Parameters("@merk").Value = LTrim(RTrim(txtMerk.Text))


        'parameter yang dikirim melalui objek command
        xParamType = xCommand.Parameters.Add("@type", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamType.Direction = ParameterDirection.Input
        xCommand.Parameters("@type").Value = LTrim(RTrim(txtType.Text))

        'parameter yang dikirim melalui objek command
        xParamfoto = xCommand.Parameters.Add("@foto", SqlDbType.Image, 900000000)
        'direction yg dipakai mode input
        xParamfoto.Direction = ParameterDirection.Input
        xCommand.Parameters("@foto").Value = CPic

        'parameter yang dikirim melalui objek command
        xParamlokasifoto = xCommand.Parameters.Add("@lokasi_foto", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamlokasifoto.Direction = ParameterDirection.Input
        xCommand.Parameters("@lokasi_foto").Value = LTrim(RTrim(txtLokasiFoto.Text))


        'parameter yang dikirim melalui objek command
        xParamCreateBy = xCommand.Parameters.Add("@create_by", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamCreateBy.Direction = ParameterDirection.Input
        xCommand.Parameters("@create_by").Value = LTrim(RTrim(strFullName))




        xCommand.CommandTimeout = 15000
        xCommand.ExecuteNonQuery()

        'hancurkan semua parameter
        xCommand.Parameters.Remove(xParamkodeItem)
        xCommand.Parameters.Remove(xParamkodeGroup)
        xCommand.Parameters.Remove(xParamnamaItem)
        xCommand.Parameters.Remove(xParamketerangan)
        xCommand.Parameters.Remove(xParamkode_barcode)
        xCommand.Parameters.Remove(xParamlimit_umur)
        xCommand.Parameters.Remove(xParamkode_kategori)
        xCommand.Parameters.Remove(xParamMerk)
        xCommand.Parameters.Remove(xParamType)
        xCommand.Parameters.Remove(xParamfoto)
        xCommand.Parameters.Remove(xParamlokasifoto)
        xCommand.Parameters.Remove(xParamCreateBy)

    End Sub
    Function GetKodeItemByGroup()
        Dim intCounter As Integer
        Dim strCounter21 As String
        Dim strPeriode As String
        Dim strTransactionNo As String
        Dim cstrParamPeriode As New SqlClient.SqlParameter


        Dim ocmdLasTransaction As New SqlCommand("usp_get_last_counter_master_item", ModuleApp.Koneksi)
        With ocmdLasTransaction
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 1000
            .Parameters.Add("@kode_group", SqlDbType.NVarChar, 50)
            .Parameters("@kode_group").Value = RTrim(LTrim(txtkodegroup.Text))
        End With

        Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdLasTransaction)
        Dim dsLasTransaction As New DataSet
        Dim oTblLasTransaction As New DataTable
        daLasTransaction.Fill(dsLasTransaction, "tbl_counter_transaction")
        oTblLasTransaction = dsLasTransaction.Tables("tbl_counter_transaction")
        Dim drLasTransaction As SqlDataReader
        drLasTransaction = ocmdLasTransaction.ExecuteReader
        Do
            While drLasTransaction.Read()
                'strPeriode = drLasTransaction(0)
                strTransactionNo = drLasTransaction(0)
            End While
        Loop While drLasTransaction.NextResult()
        'strTransactionNo = LTrim(RTrim(cstrPeriodeYear)) + LTrim(RTrim(strCounter21))

        'Dim strIntcounter As String
        'Dim nLenIntcounter As Integer
        'strIntcounter = LTrim(RTrim(Str(intCounter)))
        ''  nLenIntcounter = Len(strIntcounter)
        'nLenIntcounter = 1
        'Select Case nLenIntcounter
        '    Case 1
        '        strTransactionNo = ".000" + strIntcounter
        '    Case 2
        '        strTransactionNo = ".00" + strIntcounter
        '    Case 3
        '        strTransactionNo = ".000" + strIntcounter
        '    Case 4
        '        strTransactionNo = "." + strIntcounter
        '    Case Else
        '        strTransactionNo = "." + "xxxx"
        'End Select

        drLasTransaction.Close()
        Return strTransactionNo
    End Function

    Private Sub Button_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Delete.Click
        WhenDeleteRecord()
        ButtonCRUDWhenDefault()
    End Sub
    Private Sub WhenDeleteRecord()
        idTable2 = Convert.ToString(Me.DataGridViewItem.CurrentRow.Cells(3).Value)
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
                Dim cmdinserttenantPOS1 As New SqlCommand("usp_master_Item_del#id", ModuleApp.Koneksi)
                With cmdinserttenantPOS1
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16)
                    .Parameters("@id").Value = New Guid(idTable)

                End With
                cmdinserttenantPOS1.CommandTimeout = 30000
                cmdinserttenantPOS1.ExecuteNonQuery()
                MsgBox("PENGHAPUSAN DATA ITEM SUKSES...", MsgBoxStyle.Information)
                LoadsettingItem()
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

    Private Sub btngetpicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngetpicture.Click
        whenopenGetPicture()
    End Sub

    Private Sub whenopenGetPicture()
        txtFileName.Text = ""
        txtLokasiFoto.Text = ""
        'Imports Microsoft.Win32

        '...

        'Dim dlg As New OpenFileDialog()

        '' Filter by Word Documents
        'dlg.Filter = "Word Documents|*.doc"

        'dlg.ShowDialog()

        'OFD.Filter = "Image Files (*.jpg, *.bmp, *.gif, *.png)*.jpg; *.bmp; *.gif; *.png"
        'OFD.Filter = "Word Documents|*.doc"
        'aslinya brow ..OFD.Filter = "Image Files|*.jpg"
        OFD.Filter = "Image Files|*.jpg;*.bmp; *.gif; *.png"
        OFD.ShowDialog()
        If RTrim(Trim(txtFileName.Text)) = "OpenFileDialog1" Then
            txtLokasiFoto.Text = ""
            MsgBox("Belum ada Foto nya", MsgBoxStyle.Exclamation)
            Return
        Else
            ' MsgBox(OFD.SafeFileName)
            txtLokasiFoto.Text = RTrim(Trim(OFD.FileName))  '  + "\" + RTrim(LTrim(OFD.SafeFileName))
        End If
        txtFileName.Text = OFD.FileName
        txtFileName.SelectionStart = txtFileName.Text.Length
        If Trim(txtFileName.Text) <> "" Then
            PictureBoxFotoAsset.Image = Image.FromFile(txtFileName.Text)
            '            PictureBoxFotoAsset.SizeMode = PictureBoxSizeMode.Zoom
            PictureBoxFotoAsset.SizeMode = PictureBoxSizeMode.StretchImage
            'fokus langsung ke input nama klien
            ToolStrip1.Focus()
            Button_Save.Select()
        Else
            MsgBox("Belum ada Foto nya", MsgBoxStyle.Exclamation)
            Return
        End If
    End Sub

    Private Sub btnSearchkodeGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchkodeGroup.Click
        frmSearchMasterGroup.ShowDialog()
        'frmToolTip.ShowDialog()

        txtkodegroup.Text = pstrKodeGroup
        txtkodegroup.Focus()
    End Sub

    Private Sub ButtonItemSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemSearch.Click
        whensearchData()
    End Sub
    Private Sub whensearchData()
        LoadsettingItem()
    End Sub

    Private Sub TabItemData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItemData.Click
        ButtonCRUDWhenDefault()


        If (DataGridViewItem.RowCount = 0 And DataGridViewItem.ColumnCount = 0) Then
            Return
        End If



        TabControl.SelectedTab = TabItemData
        Dim i As Integer
        i = DataGridViewItem.CurrentRow.Index

        idTable = Convert.ToString(DataGridViewItem.Rows(i).Cells(13).Value)


        txtkodegroup.Text = DataGridViewItem.Rows(i).Cells(0).Value
        lblnamagroup.Text = DataGridViewItem.Rows(i).Cells(1).Value
        txtkodeitem.Text = DataGridViewItem.Rows(i).Cells(2).Value
        txtnamaitem.Text = DataGridViewItem.Rows(i).Cells(3).Value
        txtketerangan.Text = DataGridViewItem.Rows(i).Cells(4).Value
        txtbarcode.Text = DataGridViewItem.Rows(i).Cells(5).Value
        txtlimitumur.Text = DataGridViewItem.Rows(i).Cells(6).Value
        cbokategori.SelectedValue = DataGridViewItem.Rows(i).Cells(7).Value
        '  txtkodegroup.Text = DataGridViewItem.Rows(i).Cells(0).Value
        txtMerk.Text = DataGridViewItem.Rows(i).Cells(9).Value
        txtType.Text = DataGridViewItem.Rows(i).Cells(10).Value


        Try
            Dim arr() As Byte
            arr = DataGridViewItem.Rows(i).Cells(11).Value
            PictureBoxFotoAsset.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBoxFotoAsset.Image = Image.FromStream(New IO.MemoryStream(arr))

        Catch ex As Exception

        End Try

        '       PictureBoxFotoAsset.Image = DataGridViewItem.Rows(i).Cells(11).Value
        txtLokasiFoto.Text = DataGridViewItem.Rows(i).Cells(12).Value

        '...idTable = Convert.ToString(DataGridView1.Item(20, i).Value)
        'get pciture or get image from sql serve r data .... "
        'Try
        '    Dim isAllowVoucher As Boolean = False
        '    Dim nCountTenant As Integer = 0
        '    Dim cStrSQLverifikasivoucher As String
        '    Dim arr() As Byte
        '    'Dim intCounter As Integer
        '    Dim cstrParamPeriode As New SqlClient.SqlParameter
        '    cStrSQLverifikasivoucher = "select foto from tbl_master_item where id ='" & idTable & "'"
        '    Dim ocmdVerifyTransaction As SqlCommand = New SqlCommand(cStrSQLverifikasivoucher, ModuleApp.Koneksi)
        '    ocmdVerifyTransaction.CommandTimeout = 1000
        '    ocmdVerifyTransaction.CommandType = CommandType.Text
        '    'cstrParamPeriode = ocmdVerifyTransaction.Parameters.Add("@sales_date", SqlDbType.DateTime, 8)
        '    ''direction yg dipakai mode input
        '    'cstrParamPeriode.Direction = ParameterDirection.Input
        '    'ocmdVerifyTransaction.Parameters("@sales_date").Value = strDateSales

        '    Dim daVerifyTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdVerifyTransaction)
        '    Dim dsVerifyTransaction As New DataSet
        '    Dim oTblVerifyTransaction As New DataTable
        '    daVerifyTransaction.Fill(dsVerifyTransaction, "tbl_verify_transaction")
        '    oTblVerifyTransaction = dsVerifyTransaction.Tables("tbl_verify_transaction")
        '    Dim drVerifyTransaction As SqlDataReader
        '    drVerifyTransaction = ocmdVerifyTransaction.ExecuteReader
        '    Do
        '        While drVerifyTransaction.Read()
        '            'nCountTenant = drVerifyTransaction(0)
        '            arr = drVerifyTransaction(0)
        '            PictureBoxFotoAsset.SizeMode = PictureBoxSizeMode.StretchImage
        '            PictureBoxFotoAsset.Image = Image.FromStream(New IO.MemoryStream(arr))
        '        End While
        '    Loop While drVerifyTransaction.NextResult()
        'Catch ex As Exception
        '    MsgBox("error  : " & ex.Message)
        'End Try
        'end of get picture ...



        txtcreatedate.Text = DataGridViewItem.Rows(i).Cells(14).Value
        txtcreateby.Text = DataGridViewItem.Rows(i).Cells(15).Value
        txtlastmodified.Text = DataGridViewItem.Rows(i).Cells(16).Value
        txtmodifiedby.Text = DataGridViewItem.Rows(i).Cells(17).Value
    End Sub

    Private Sub TabItemList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItemList.Click
        Disabledtoolbar()
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

    Private Sub DataGridViewItem_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewItem.CellClick
        'ckode_group, _    0
        'cnama_group, _1
        'ckode_Item, _2
        'cnama_Item, _3
        'cketerangan, _4
        'ckode_barcode, _5
        'nlimit_umur, _ 6
        'ckode_kategori, _ 7
        'cnama_kategori, _ 8
        'cMerk, _ 9
        'cType2, _ 10
        'cFoto, _11
        'cLokasiFoto, _12
        'cid, _ 13
        'cCreateDate, _14
        'cCreateBy, _ 15
        'cLastModified, _16
        'cModifiedBy 17

        If (DataGridViewItem.RowCount = 0 & DataGridViewItem.ColumnCount = 0) Then
            Return
        End If


        Dim i As Integer
        i = DataGridViewItem.CurrentRow.Index

        idTable = Convert.ToString(DataGridViewItem.Rows(i).Cells(13).Value)


        txtkodegroup.Text = DataGridViewItem.Rows(i).Cells(0).Value
        lblnamagroup.Text = DataGridViewItem.Rows(i).Cells(1).Value
        txtkodeitem.Text = DataGridViewItem.Rows(i).Cells(2).Value
        txtnamaitem.Text = DataGridViewItem.Rows(i).Cells(3).Value
        txtketerangan.Text = DataGridViewItem.Rows(i).Cells(4).Value
        txtbarcode.Text = DataGridViewItem.Rows(i).Cells(5).Value
        txtlimitumur.Text = DataGridViewItem.Rows(i).Cells(6).Value
        cbokategori.SelectedValue = DataGridViewItem.Rows(i).Cells(7).Value
        '  txtkodegroup.Text = DataGridViewItem.Rows(i).Cells(0).Value
        txtMerk.Text = DataGridViewItem.Rows(i).Cells(9).Value
        txtType.Text = DataGridViewItem.Rows(i).Cells(10).Value

        Try
            Dim arr() As Byte
            arr = DataGridViewItem.Rows(i).Cells(11).Value
            PictureBoxFotoAsset.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBoxFotoAsset.Image = Image.FromStream(New IO.MemoryStream(arr))

        Catch ex As Exception

        End Try


        'PictureBoxFotoAsset.Image = DataGridViewItem.Rows(i).Cells(11).Value
        txtLokasiFoto.Text = DataGridViewItem.Rows(i).Cells(12).Value
        '...idTable = Convert.ToString(DataGridView1.Item(20, i).Value)
        'get pciture or get image from sql serve r data .... "
        'Try
        '    Dim isAllowVoucher As Boolean = False
        '    Dim nCountTenant As Integer = 0
        '    Dim cStrSQLverifikasivoucher As String
        '    Dim arr() As Byte
        '    'Dim intCounter As Integer
        '    Dim cstrParamPeriode As New SqlClient.SqlParameter
        '    cStrSQLverifikasivoucher = "select foto from tbl_master_item where id ='" & idTable & "'"
        '    Dim ocmdVerifyTransaction As SqlCommand = New SqlCommand(cStrSQLverifikasivoucher, ModuleApp.Koneksi)
        '    ocmdVerifyTransaction.CommandTimeout = 1000
        '    ocmdVerifyTransaction.CommandType = CommandType.Text
        '    'cstrParamPeriode = ocmdVerifyTransaction.Parameters.Add("@sales_date", SqlDbType.DateTime, 8)
        '    ''direction yg dipakai mode input
        '    'cstrParamPeriode.Direction = ParameterDirection.Input
        '    'ocmdVerifyTransaction.Parameters("@sales_date").Value = strDateSales

        '    Dim daVerifyTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdVerifyTransaction)
        '    Dim dsVerifyTransaction As New DataSet
        '    Dim oTblVerifyTransaction As New DataTable
        '    daVerifyTransaction.Fill(dsVerifyTransaction, "tbl_verify_transaction")
        '    oTblVerifyTransaction = dsVerifyTransaction.Tables("tbl_verify_transaction")
        '    Dim drVerifyTransaction As SqlDataReader
        '    drVerifyTransaction = ocmdVerifyTransaction.ExecuteReader
        '    Do
        '        While drVerifyTransaction.Read()
        '            'nCountTenant = drVerifyTransaction(0)
        '            arr = drVerifyTransaction(0)
        '            PictureBoxFotoAsset.SizeMode = PictureBoxSizeMode.StretchImage
        '            PictureBoxFotoAsset.Image = Image.FromStream(New IO.MemoryStream(arr))
        '        End While
        '    Loop While drVerifyTransaction.NextResult()
        'Catch ex As Exception
        '    MsgBox("error  : " & ex.Message)
        'End Try
        'end of get picture ...



        txtcreatedate.Text = DataGridViewItem.Rows(i).Cells(14).Value
        txtcreateby.Text = DataGridViewItem.Rows(i).Cells(15).Value
        txtlastmodified.Text = DataGridViewItem.Rows(i).Cells(16).Value
        txtmodifiedby.Text = DataGridViewItem.Rows(i).Cells(17).Value
    End Sub

    Private Sub DataGridViewItem_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewItem.CellDoubleClick
        If (DataGridViewItem.RowCount = 0 And DataGridViewItem.ColumnCount = 0) Then
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
            i = DataGridViewItem.CurrentRow.Index


            idTable = Convert.ToString(DataGridViewItem.Rows(e.RowIndex).Cells(13).Value)
            txtkodegroup.Text = DataGridViewItem.Rows(e.RowIndex).Cells(0).Value
            lblnamagroup.Text = DataGridViewItem.Rows(e.RowIndex).Cells(1).Value


            txtkodeitem.Text = DataGridViewItem.Rows(e.RowIndex).Cells(2).Value
            txtnamaitem.Text = DataGridViewItem.Rows(e.RowIndex).Cells(3).Value
            txtketerangan.Text = DataGridViewItem.Rows(e.RowIndex).Cells(4).Value
            txtbarcode.Text = DataGridViewItem.Rows(e.RowIndex).Cells(5).Value
            txtlimitumur.Text = DataGridViewItem.Rows(e.RowIndex).Cells(6).Value
            cbokategori.SelectedValue = DataGridViewItem.Rows(e.RowIndex).Cells(7).Value
            '  txtkodegroup.Text = DataGridViewItem.Rows(i).Cells(0).Value
            txtMerk.Text = DataGridViewItem.Rows(e.RowIndex).Cells(9).Value
            txtType.Text = DataGridViewItem.Rows(e.RowIndex).Cells(10).Value

            Try
                Dim arr() As Byte
                arr = DataGridViewItem.Rows(e.RowIndex).Cells(11).Value
                PictureBoxFotoAsset.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBoxFotoAsset.Image = Image.FromStream(New IO.MemoryStream(arr))

            Catch ex As Exception

            End Try

            'PictureBoxFotoAsset.Image = DataGridViewItem.Rows(i).Cells(11).Value
            txtLokasiFoto.Text = DataGridViewItem.Rows(e.RowIndex).Cells(12).Value


            'recorded
            txtcreatedate.Text = DataGridViewItem.Rows(e.RowIndex).Cells(14).Value
            txtcreateby.Text = DataGridViewItem.Rows(e.RowIndex).Cells(15).Value
            txtlastmodified.Text = DataGridViewItem.Rows(e.RowIndex).Cells(16).Value
            txtmodifiedby.Text = DataGridViewItem.Rows(e.RowIndex).Cells(17).Value


 
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridViewItem_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewItem.CellMouseDoubleClick
        If (DataGridViewItem.RowCount = 0 And DataGridViewItem.ColumnCount = 0) Then
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
            i = DataGridViewItem.CurrentRow.Index

            idTable = Convert.ToString(DataGridViewItem.Rows(e.RowIndex).Cells(13).Value)

            txtkodegroup.Text = DataGridViewItem.Rows(e.RowIndex).Cells(0).Value
            lblnamagroup.Text = DataGridViewItem.Rows(e.RowIndex).Cells(1).Value


            txtkodeitem.Text = DataGridViewItem.Rows(e.RowIndex).Cells(2).Value
            txtnamaitem.Text = DataGridViewItem.Rows(e.RowIndex).Cells(3).Value
            txtketerangan.Text = DataGridViewItem.Rows(e.RowIndex).Cells(4).Value
            txtbarcode.Text = DataGridViewItem.Rows(e.RowIndex).Cells(5).Value
            txtlimitumur.Text = DataGridViewItem.Rows(e.RowIndex).Cells(6).Value
            cbokategori.SelectedValue = DataGridViewItem.Rows(e.RowIndex).Cells(7).Value
            '  txtkodegroup.Text = DataGridViewItem.Rows(i).Cells(0).Value
            txtMerk.Text = DataGridViewItem.Rows(e.RowIndex).Cells(9).Value
            txtType.Text = DataGridViewItem.Rows(e.RowIndex).Cells(10).Value

            Try
                Dim arr() As Byte
                arr = DataGridViewItem.Rows(e.RowIndex).Cells(11).Value
                PictureBoxFotoAsset.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBoxFotoAsset.Image = Image.FromStream(New IO.MemoryStream(arr))

            Catch ex As Exception

            End Try

            'PictureBoxFotoAsset.Image = DataGridViewItem.Rows(i).Cells(11).Value
            txtLokasiFoto.Text = DataGridViewItem.Rows(e.RowIndex).Cells(12).Value


            'recorded
            txtcreatedate.Text = DataGridViewItem.Rows(e.RowIndex).Cells(14).Value
            txtcreateby.Text = DataGridViewItem.Rows(e.RowIndex).Cells(15).Value
            txtlastmodified.Text = DataGridViewItem.Rows(e.RowIndex).Cells(16).Value
            txtmodifiedby.Text = DataGridViewItem.Rows(e.RowIndex).Cells(17).Value


            'txtkodegroup.Text = DataGridViewItem.Rows(e.RowIndex).Cells(0).Value
            'lblnamagroup.Text = DataGridViewItem.Rows(e.RowIndex).Cells(1).Value
            ''DateTimePickerStartDate.Value = DataGridViewLokasi.Rows(e.RowIndex).Cells(4).Value
            ''DateTimePickerEnDate.Value = DataGridViewLokasi.Rows(e.RowIndex).Cells(5).Value
            ''txtNominal.Text = FormatNumber(DataGridViewLokasi.Rows(e.RowIndex).Cells(3).Value, 2, TriState.UseDefault)
            ''recorded
            'txtcreatedate.Text = DataGridViewItem.Rows(e.RowIndex).Cells(3).Value
            'txtcreateby.Text = DataGridViewItem.Rows(e.RowIndex).Cells(4).Value
            'txtlastmodified.Text = DataGridViewItem.Rows(e.RowIndex).Cells(5).Value
            'txtmodifiedby.Text = DataGridViewItem.Rows(e.RowIndex).Cells(6).Value

        Catch ex As Exception

        End Try


        ButtonCRUDWhenDefault()
    End Sub

    Private Sub txtkodegroup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodegroup.TextChanged
        lblnamagroup.Text = searchnamagroup()
    End Sub

    Private Function searchnamagroup()
        Dim cstrnama As String

        Dim ocmdLasTransaction As SqlCommand = New SqlCommand("select nama_group  from tbl_master_group_item where  kode_group ='" & RTrim(LTrim(txtkodegroup.Text)) & "'", ModuleApp.Koneksi)
        ocmdLasTransaction.CommandTimeout = 1000
        ocmdLasTransaction.CommandType = CommandType.Text


        Dim daLasTransaction As SqlDataAdapter = New SqlDataAdapter(ocmdLasTransaction)
        Dim dsLasTransaction As New DataSet
        Dim oTblLasTransaction As New DataTable
        daLasTransaction.Fill(dsLasTransaction, "tbl_master_group_item")
        oTblLasTransaction = dsLasTransaction.Tables("tbl_master_group_item")
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
    Private Sub autocompetesearchgroup()
        textsearchgroupautocomplete.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        textsearchgroupautocomplete.AutoCompleteSource = AutoCompleteSource.CustomSource

        Dim coll As New AutoCompleteStringCollection

        Dim oconn As New SqlConnection()

        'declare @search as nvarchar(100)
        'set @search = 'pure'
        'set @search = '%' + rtrim(ltrim(@search))+ '%'
        'select no_anggota,nama from tbl_anggota where ( no_anggota like @search or nama like @search )


        '   Dim cstrSearch As String = "%" + RTrim(LTrim(txtSearch.Text)) + "%"
        oconn.ConnectionString = cstrSQLKoneksi


        Dim cstrParamSearch As New SqlClient.SqlParameter
        Dim cstrsearch As String = RTrim(LTrim(textsearchgroupautocomplete.Text))
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

        Dim sgroupnama As String

        Dim drLasTransaction2 As SqlDataReader
        drLasTransaction2 = ocmdLasTransaction.ExecuteReader
        Do
            While drLasTransaction2.Read()
                'strPeriode = drLasTransaction2(0)
                sgroupnama = LTrim(RTrim(drLasTransaction2(2)))
                coll.Add(sgroupnama)
                ' cstrKodeJenisKomponen = LTrim(RTrim(drLasTransaction2(1)))
            End While
        Loop While drLasTransaction2.NextResult()
        'strTransactionNo = LTrim(RTrim(cstrPeriodeYear)) + LTrim(RTrim(strCounter21))
        drLasTransaction2.Close()

        textsearchgroupautocomplete.AutoCompleteCustomSource = coll


        'Dim snamagroup As String
        'Dim i As Integer
        ''  Displaydata()

        'For i = 0 To (oTblLasTransaction.Rows.Count - 1)
        '    With oTblLasTransaction.Rows(i)
        '        '  Dim lSingleItem As ListViewItem
        '        '  lSingleItem = ListView1.Items.Add(.Item("kode_group").ToString)
        '        '  lSingleItem.SubItems.Add(.Item("nama_group").ToString)
        '        '
        '        'ListView1.Items.Add(i.ToString, i - 1).ToolTipText = "Double click"
        '        '
        '        'lSingleItem(.ToolTipText = "Double Click"
        '        '        'strPeriode = drLasTransaction2(0)
        '        '        ckodesimpsukarela = LTrim(RTrim(drLasTransaction2(0)))
        '        '        ' cstrKodeJenisKomponen = LTrim(RTrim(drLasTransaction2(1)))
        '        snamagroup = LTrim(RTrim(dsLasTransaction(2)))

        '    End With
        'Next i

    End Sub

    Private Sub txtkodegroup_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkodegroup.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'ToolStrip1.Focus()
            'Button_Save.Select()
            txtnamaitem.Focus()
            'txtKodeItems.Enabled = True
        End If
    End Sub

    Private Sub txtnamaitem_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnamaitem.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'ToolStrip1.Focus()
            'Button_Save.Select()
            txtketerangan.Focus()
            'txtKodeItems.Enabled = True
        End If
    End Sub
    Private Sub txtketerangan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtketerangan.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'ToolStrip1.Focus()
            'Button_Save.Select()
            txtbarcode.Focus()
            'txtKodeItems.Enabled = True
        End If
    End Sub

    Private Sub txtbarcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbarcode.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'ToolStrip1.Focus()
            'Button_Save.Select()
            txtlimitumur.Focus()
            'txtKodeItems.Enabled = True
        End If
    End Sub

    Private Sub txtlimitumur_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlimitumur.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'ToolStrip1.Focus()
            'Button_Save.Select()
            cbokategori.Focus()
            'txtKodeItems.Enabled = True
        End If
    End Sub

    Private Sub cbokategori_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbokategori.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'ToolStrip1.Focus()
            'Button_Save.Select()
            txtMerk.Focus()
            'txtKodeItems.Enabled = True
        End If
    End Sub

    Private Sub txtMerk_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMerk.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'ToolStrip1.Focus()
            'Button_Save.Select()
            txtType.Focus()
            'txtKodeItems.Enabled = True
        End If
    End Sub

    Private Sub txtType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtType.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'ToolStrip1.Focus()
            'Button_Save.Select()
            btngetpicture.Focus()
            'txtKodeItems.Enabled = True
        End If
    End Sub
    Private Sub ToolStrip1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip1.MouseHover
        If savedCursor Is Nothing Then
            savedCursor = Me.Cursor
            Me.Cursor = Cursors.Hand
        End If


    End Sub
    Private Sub ToolStrip1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStrip1.MouseLeave
        Me.Cursor = savedCursor
        savedCursor = Nothing
    End Sub

  
End Class


