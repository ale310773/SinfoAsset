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
Public Class frmMasterDepartement
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
    Private bindingSource1 As New BindingSource
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
        ' Add any initialization after the InitializeComponent() call.
        ItemPanelPencarianData.Visible = False
        TabControl.Location = New Point(30, 30)

        GroupPanel1.Text = "Master Item Departement"

        disabledpropertyForm()
        ButtonCRUDWhenDefault()

        'If DataGridViewDepartement.RowCount > 0 Then
        '    LoadsettingDepartement()
        '    Try

        '        '                DataGridViewDepartement.Rows(0).Selected = True
        '    Catch ex As Exception

        '    End Try

        'End If
        Try
            'If Not DataGridViewItem.CurrentCell Is DBNull.Value Then
            '    LoadsettingItem()
            'End If
            If (DataGridViewDepartement.RowCount > 0 And DataGridViewDepartement.ColumnCount > 0) Then
                'MsgBox("DataGridView has no rows or columns!!")
                'Return
                LoadsettingDepartement()
            Else
                'LoadsettingDepartement()
            End If

        Catch ex As Exception

        End Try

        'baru ini dari Leo ....
        GoToFirstRecord()
        TabControl.SelectedTab = TabItemData
        'baru ini dari Leo ...
    End Sub


    Private Sub disabledpropertyForm()
        txtkodeDepartement.ReadOnly = True
        txtkodeDepartement.ForeColor = Color.Black
        txtkodeDepartement.BackColor = Color.Gold

        txtnamaDepartement.ReadOnly = True
        txtnamaDepartement.ForeColor = Color.Black
        txtnamaDepartement.BackColor = Color.Gold

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


    End Sub
    Private Sub enabledpropertyForm()
        If chrStatusSave = "ADD" Then
            txtkodeDepartement.ReadOnly = False
        Else
            txtkodeDepartement.ReadOnly = True
        End If

        txtkodeDepartement.ForeColor = Color.Black
        txtkodeDepartement.BackColor = Color.GreenYellow

        txtnamaDepartement.ReadOnly = False
        txtnamaDepartement.ForeColor = Color.Black
        txtnamaDepartement.BackColor = Color.GreenYellow

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
    End Sub
    Private Sub ButtonCRUDWhenDefault()
        Button_Add.Enabled = True
        Button_Delete.Enabled = True
        Button_Edit.Enabled = True
        Button_Cancel.Enabled = False
        Button_Save.Enabled = False
        Button_Load.Enabled = True
        ' txtkodeDepartement.ReadOnly = True

        ''ditambah oleh Leo WS baru...
        'GoToFirstRecord()

        'DataGridViewDepartement.Enabled = True
        'txtSearch.Enabled = True
    End Sub
    Private Sub ButtonCRUDWhenAdd()
        Button_Add.Enabled = False
        Button_Delete.Enabled = False
        Button_Edit.Enabled = False
        Button_Cancel.Enabled = True
        Button_Save.Enabled = True
        Button_Load.Enabled = False
        '   txtkodeDepartement.ReadOnly = False
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
        LoadsettingDepartement()
        disabledpropertyForm()

        'If DataGridViewDepartement.RowCount > 0 Then
        '    DataGridViewDepartement.Rows(0).Selected = True
        'End If
    End Sub
    Private Sub LoadsettingDepartement()
        ' refreshDepartement()
        refreshDepartement2()
        SetFormattingGridViewDepartement()
        txtSearch.Text = ""
    End Sub
    'Private Sub refreshDepartement()
    '    Dim cstrSearch As String = "%" + RTrim(LTrim(txtSearch.Text)) + "%"
    '    Dim cstrsql As String

    '    cstrsql = " select id,kode_Departement,nama_Departement from tbl_master_Departement " & _
    '  " where ( tbl_master_Departement.kode_Departement like '" & cstrSearch & "' OR " & _
    '        " dbo.tbl_master_Departement.nama_Departement " & " like '" & cstrSearch & "' )" & _
    ' "  ORDER BY tbl_master_Departement.kode_Departement "

    '    Dim adapter As New SqlDataAdapter(cstrsql, ModuleApp.Koneksi)
    '    Me.DataGridView1.Columns.Clear()
    '    Dim dt As New DataTable("Departement")
    '    adapter.Fill(dt)
    '    DataGridViewDepartement.DataSource = dt
    '    Dim tblsalestenant As DataTable
    '    tblsalestenant = dt
    'End Sub
    Private Sub refreshDepartement2()

        Dim cstrParamSearch As New SqlClient.SqlParameter
        Dim cstrsearch As String = RTrim(LTrim(txtSearch.Text))
        Dim ocmdLasTransaction As SqlCommand = New SqlCommand("usp_search_master_departement_sel", ModuleApp.Koneksi)
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
        DataGridViewDepartement.DataSource = oTblLasTransaction


    End Sub
    Private Sub SetFormattingGridViewDepartement()

        Dim ckode_Departement As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cnama_Departement As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cid As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cCreateDate As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cCreateBy As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cLastModified As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim cModifiedBy As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn



        'Dim cID As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim cTipe As System.Windows.Forms.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        ckode_Departement.Name = "kode_Departement"
        ckode_Departement.HeaderText = "Kode Departement"
        ckode_Departement.DataPropertyName = "kode_Departement"
        ckode_Departement.Width = 100
        ckode_Departement.Visible = True
        ckode_Departement.ReadOnly = True
        ckode_Departement.DefaultCellStyle.BackColor = Color.BlanchedAlmond

        cnama_Departement.Name = "nama_Departement"
        cnama_Departement.HeaderText = "Nama Departement"
        cnama_Departement.DataPropertyName = "nama_Departement"
        cnama_Departement.Width = 100
        cnama_Departement.Visible = True
        cnama_Departement.ReadOnly = True
        cnama_Departement.DefaultCellStyle.BackColor = Color.BlanchedAlmond

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

        DataGridViewDepartement.AllowUserToAddRows = False
        DataGridViewDepartement.AllowUserToDeleteRows = True
        DataGridViewDepartement.AutoGenerateColumns = False
        DataGridViewDepartement.Columns.Clear()

        '"select  sales_date,tenant_id, kode , menu , price , ppn , price_ppn , qty_sales , total_sales from tbl_temp_sales ", Module1.Koneksi)
        DataGridViewDepartement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() _
        { _
        ckode_Departement, _
        cnama_Departement, _
        cid, _
        cCreateDate, _
        cCreateBy, _
        cLastModified, _
        cModifiedBy _
        })
        Me.DataGridViewDepartement.AllowUserToAddRows = False

        'Me.DataGridViewDepartement.Columns.Item(3).DefaultCellStyle.Format = "n2"      'nominal 
        '   setting format datetime dataGridView1.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
        'Me.DataGridViewDepartement.Columns.Item(4).DefaultCellStyle.Format = "dd/MM/yyyy"      'net sales
        'Me.DataGridViewDepartement.Columns.Item(5).DefaultCellStyle.Format = "dd/MM/yyyy"      'net sales

    End Sub
    Private Sub blankrecord()
        txtkodeDepartement.Text = ""
        txtnamaDepartement.Text = ""

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
        txtkodeDepartement.Focus()
        txtnamaDepartement.Text = ""

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

        DataGridViewDepartement.CurrentCell = DataGridViewDepartement.Rows(0).Cells(0)

        If IsDBNull(DataGridViewDepartement.Rows(0).Cells(0).Value) Then
            Return
        End If
        Try

            idTable = Convert.ToString(DataGridViewDepartement.Rows(0).Cells(2).Value)
            txtkodeDepartement.Text = DataGridViewDepartement.Rows(0).Cells(0).Value
            txtnamaDepartement.Text = DataGridViewDepartement.Rows(0).Cells(1).Value

            '=============================
            txtcreatedate.Text = DataGridViewDepartement.Rows(0).Cells(3).Value
            txtcreateby.Text = DataGridViewDepartement.Rows(0).Cells(4).Value
            txtlastmodified.Text = DataGridViewDepartement.Rows(0).Cells(5).Value
            txtmodifiedby.Text = DataGridViewDepartement.Rows(0).Cells(6).Value


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
        If txtkodeDepartement.Text = "" Then
            MsgBox("KODE TIDAK BOLEH KOSONG !", MsgBoxStyle.Information)
            txtkodeDepartement.ReadOnly = False
            Return
        End If


        Dim ckode As String = ""
        Dim cgrade As String = ""

        Try
            If chrStatusSave = "ADD" Then
                saverecordDepartement()
                LoadsettingDepartement()
            Else
                UpdaterecordDepartement()
                LoadsettingDepartement()
            End If
            If DataGridViewDepartement.RowCount > 0 Then
                DataGridViewDepartement.Rows(0).Selected = True
            End If
            If chrStatusSave = "ADD" Then
                MessageBox.Show("TAMBAH DATA Departement SUKSES...", "SAVE RECORDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("UPDATE DATA Departement SUKSES...", "SAVE RECORDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            'MessageBox.Show("error while void record sales on table..." & ex.Message, "save records")
            MessageBox.Show("ERROR :" & ex.Message, "SAVE RECORDS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            blankrecord()
        Finally
            'con.close()
        End Try
        txtkodeDepartement.ReadOnly = True


    End Sub
    Private Sub UpdaterecordDepartement()

        idTable2 = Convert.ToString(Me.DataGridViewDepartement.CurrentRow.Cells(2).Value)
        xCommand.Connection = sqlconn
        Dim xParamkodeDepartement As New SqlClient.SqlParameter
        Dim xParamnamaDepartement As New SqlClient.SqlParameter
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



        xCommand.CommandText = "usp_master_Departement_upd#id"
        xCommand.CommandType = CommandType.StoredProcedure

        'parameter yang dikirim melalui objek command
        xParamkodeDepartement = xCommand.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16)
        'direction yg dipakai mode input
        xParamkodeDepartement.Direction = ParameterDirection.Input
        xCommand.Parameters("@id").Value = New Guid(idTable2)
        'idTable2
        'New Guid(idTable2)

        'parameter yang dikirim melalui objek command
        xParamnamaDepartement = xCommand.Parameters.Add("@nama_Departement", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamnamaDepartement.Direction = ParameterDirection.Input
        xCommand.Parameters("@nama_Departement").Value = LTrim(RTrim(txtnamaDepartement.Text))


        'parameter yang dikirim melalui objek command
        xParamModifiedBy = xCommand.Parameters.Add("@modified_by", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamModifiedBy.Direction = ParameterDirection.Input
        xCommand.Parameters("@modified_by").Value = LTrim(RTrim(strFullName))


        xCommand.CommandTimeout = 15000
        xCommand.ExecuteNonQuery()

        'hancurkan semua parameter
        xCommand.Parameters.Remove(xParamkodeDepartement)
        xCommand.Parameters.Remove(xParamnamaDepartement)
        xCommand.Parameters.Remove(xParamModifiedBy)
    End Sub
    Private Sub saverecordDepartement()
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
        Dim xParamkodeDepartement As New SqlClient.SqlParameter
        Dim xParamnamaDepartement As New SqlClient.SqlParameter
        Dim xParamCreateBy As New SqlClient.SqlParameter

        xCommand.Parameters.Clear()

        xCommand.CommandText = "usp_master_Departement_ins"
        xCommand.CommandType = CommandType.StoredProcedure

        'parameter yang dikirim melalui objek command
        xParamkodeDepartement = xCommand.Parameters.Add("@kode_Departement", SqlDbType.NVarChar, 50)
        'direction yg dipakai mode input
        xParamkodeDepartement.Direction = ParameterDirection.Input
        xCommand.Parameters("@kode_Departement").Value = LTrim(RTrim(txtkodeDepartement.Text))


        'parameter yang dikirim melalui objek command
        xParamnamaDepartement = xCommand.Parameters.Add("@nama_Departement", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamnamaDepartement.Direction = ParameterDirection.Input
        xCommand.Parameters("@nama_Departement").Value = LTrim(RTrim(txtnamaDepartement.Text))



        'parameter yang dikirim melalui objek command
        xParamCreateBy = xCommand.Parameters.Add("@create_by", SqlDbType.NVarChar, 100)
        'direction yg dipakai mode input
        xParamCreateBy.Direction = ParameterDirection.Input
        xCommand.Parameters("@create_by").Value = LTrim(RTrim(strFullName))




        xCommand.CommandTimeout = 15000
        xCommand.ExecuteNonQuery()

        'hancurkan semua parameter
        xCommand.Parameters.Remove(xParamkodeDepartement)
        xCommand.Parameters.Remove(xParamnamaDepartement)
        xCommand.Parameters.Remove(xParamCreateBy)

    End Sub

    Private Sub WhenDeleteRecord()
        idTable2 = Convert.ToString(Me.DataGridViewDepartement.CurrentRow.Cells(3).Value)
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
            'check dahulu Departement tabel master sudah dipakai di transaksi atau tidak ?
            Try
                'con.ConnectionString = cstrSQLKoneksi
                'con.Open()
                'cmd.Connection = con
                'cmd.CommandText = "delete from enis_simpanpinjam_ where kode ='" & RTrim(LTrim(txtKodeSimpanPinjam.Text)) & "'"
                'cmd.ExecuteNonQuery()
                Dim cmdinserttenantPOS1 As New SqlCommand("usp_master_Departement_del#id", ModuleApp.Koneksi)
                With cmdinserttenantPOS1
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16)
                    .Parameters("@id").Value = New Guid(idTable)

                End With
                cmdinserttenantPOS1.CommandTimeout = 30000
                cmdinserttenantPOS1.ExecuteNonQuery()
                MsgBox("PENGHAPUSAN DATA Departement SUKSES...", MsgBoxStyle.Information)
                LoadsettingDepartement()
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
    Private Sub whensearchData()
        LoadsettingDepartement()
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
End Class
