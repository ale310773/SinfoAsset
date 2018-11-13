Imports System
Imports System.Windows
Imports System.Windows.Forms
Imports System.Web.Management
Imports Demo.Module1
Public Class frmVerifikasi
    Private blnVerifikasi As Boolean = False
    Private Function base64Encode(ByVal sData As String) As String
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
    Public Function Verifikasi() As Boolean
        If Len(LTrim(RTrim(txtBiasa.Text))) = 0 And Len(LTrim(RTrim(txtHashString.Text))) = 0 Then
            blnVerifikasi = False
        Else
            If txtBiasa.Text = base64Decode(RTrim(LTrim(txtHashString.Text))) Then
                blnVerifikasi = True
            Else
                blnVerifikasi = False
            End If

        End If
        Return blnVerifikasi
    End Function
    Private Sub btnVerifikasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifikasi.Click
        Try
            If Verifikasi() = True Then
                pVerfikasi = True
            Else
                pVerfikasi = False
            End If
        Catch ex As Exception
            MsgBox("Error Message : " & ex.Message & "", MsgBoxStyle.Exclamation)
        End Try
        txtBiasa.Text = ""
        txtHashString.Text = ""
        txtBiasa.Focus()
        Me.Hide()
    End Sub
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'baru untuk LOAD PC UNIQUE ID
        GetPCUniqueID()
        txtBiasa.Focus()

    End Sub

    Private Sub txtBiasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBiasa.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'mengirim key tab
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub txtHashString_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHashString.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'mengirim key tab
            SendKeys.Send("{tab}")
        End If
    End Sub

    'Private Sub GetPCUniqueID()
    '    Dim win32MgmtClass As System.Management.ManagementClass
    '    win32MgmtClass = New System.Management.ManagementClass("Win32_Processor")
    '    Dim processors As System.Management.ManagementObjectCollection
    '    processors = win32MgmtClass.GetInstances()

    '    For Each processor As System.Management.ManagementObject In processors
    '        'MessageBox.Show(processor("ProcessorID").ToString())
    '        'txtPCUnique.Text = processor("ProcessorID").ToString()
    '        txtBiasa.Text = RTrim(LTrim(processor("ProcessorID").ToString()))
    '    Next
    'End Sub

    Private Sub frmVerifikasi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtBiasa.ReadOnly = True
        'aslinya mas brow txtBiasa.Text = RTrim(LTrim(Demo.Module1.GetPCUniqueID))
        'd ib awah ini selalu bisa berubah2
        txtBiasa.Text = originalGuid.ToString
    End Sub
End Class