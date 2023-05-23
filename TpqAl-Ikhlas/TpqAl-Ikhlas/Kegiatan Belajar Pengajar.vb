Public Class Kegiatan_Belajar

    Dim myBool As Boolean = True
    Private Sub Kegiatan_Belajar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TpqAlikhlasDataSet6.materi' table. You can move, or remove it, as needed.
        Me.KelasTableAdapter.Fill(Me.TpqAlikhlasDataSet5.kelas)
    End Sub

    Dim sourceBuffer As String
    Sub hideKBMdetail()
        kelasContainerShape.Visible = False
        kelasLabel.Visible = False
        kelasPictureBox.Visible = False
        kodeKelasContainerShape.Visible = False
        KKlabel.Visible = False
        kodeKelasLabel.Visible = False
        browseFileBtn.Visible = False
        viewBtn.Visible = False
        namaGuruLabel.Visible = False
        MataPelajaranLabel.Visible = False
        DataGridView1.Visible = False
        pilihKelasCb.Visible = True
        pilihKelasLabel.Visible = True
        uploadMateriBtn.Visible = False
        judulMateriLabel.Visible = False
        judulMateriTB.Visible = False
        uploadFileLabel.Visible = False
        backButton.Visible = False
    End Sub

    Sub showKBMdetail()
        kelasContainerShape.Visible = True
        kelasLabel.Visible = True
        kelasPictureBox.Visible = True
        kodeKelasContainerShape.Visible = True
        KKlabel.Visible = True
        kodeKelasLabel.Visible = True
        browseFileBtn.Visible = True
        viewBtn.Visible = True
        namaGuruLabel.Visible = True
        pilihKelasCb.Visible = False
        pilihKelasLabel.Text = "BUAT MATERI"
        MataPelajaranLabel.Visible = True
        DataGridView1.Visible = True
        uploadMateriBtn.Visible = True
        judulMateriLabel.Visible = True
        judulMateriTB.Visible = True
        uploadFileLabel.Visible = True
        backButton.Visible = True
        Call dataGridReload()
    End Sub

    Private Sub Kegiatan_Belajar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        userNameLabel.Text = Login.userNameBuffer.Text
        Call connection()
        Da = New SqlClient.SqlDataAdapter("select status from akun where namaUser='" & userNameLabel.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "akun")
        statusLabel.Text = Ds.Tables(0).Rows(0).Item("status").ToString()
        Call hideKBMdetail()
    End Sub

    'FORM BORDER NAVIGATION

    Private Sub MinimizeBtn_Click(sender As Object, e As EventArgs) Handles MinimizeBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MaximizeBtn_Click(sender As Object, e As EventArgs) Handles MaximizeBtn.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Dim Dr As DialogResult = MessageBox.Show("Anda Yakin Ingin Menutup Aplikasi ?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If Dr = DialogResult.Yes Then
            Me.Close()
        ElseIf Dr = Windows.Forms.DialogResult.No Then
            If browseFileBtn.Visible = True Then
                Call showKBMdetail()
            Else
                Call showKBMdetail()
            End If
        End If
    End Sub

    ' SIDE BAR NAVIGATION

    'HOME

    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub homeLabel_Click(sender As Object, e As EventArgs) Handles homeLabel.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub homeLogo_Click(sender As Object, e As EventArgs) Handles homeLogo.Click
        Me.Hide()
        Home.Show()
    End Sub

    'HOME HOVERABLE

    Private Sub homeBtn_Mouse_Hover(sender As Object, e As EventArgs) Handles homeBtn.MouseHover
        homeBtn.BackColor = Color.DarkGreen
        homeLabel.ForeColor = Color.WhiteSmoke
        homeLabel.BackColor = Color.DarkGreen
        homeLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub homeBtn_Mouse_Leave(sender As Object, e As EventArgs) Handles homeBtn.MouseLeave
        homeBtn.BackColor = Color.DarkSeaGreen
        homeLabel.ForeColor = Color.DimGray
        homeLabel.BackColor = Color.DarkSeaGreen
        homeLogo.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub homeLogo_Mouse_Hover(sender As Object, e As EventArgs) Handles homeLogo.MouseHover
        homeBtn.BackColor = Color.DarkGreen
        homeLabel.ForeColor = Color.WhiteSmoke
        homeLabel.BackColor = Color.DarkGreen
        homeLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub homeLogo_Mouse_Leave(sender As Object, e As EventArgs) Handles homeLogo.MouseLeave
        homeBtn.BackColor = Color.DarkSeaGreen
        homeLabel.ForeColor = Color.DimGray
        homeLabel.BackColor = Color.DarkSeaGreen
        homeLogo.BackColor = Color.DarkSeaGreen
    End Sub

    'DATA SANTRI

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles dataSantriBtn.Click
        If statusLabel.Text = "santri" Then
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh Pengajar Dan Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf statusLabel.Text = "pengajar" Then
            Me.Hide()
            Data_santri.Show()
        Else
            Me.Hide()
            Data_santri.Show()
        End If

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles dataSantriLabel.Click
        If statusLabel.Text = "santri" Then
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh Pengajar Dan Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf statusLabel.Text = "pengajar" Then
            Me.Hide()
            Data_santri.Show()
        Else
            Me.Hide()
            Data_santri.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles dataSantriLogo.Click
        If statusLabel.Text = "santri" Then
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh Pengajar Dan Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf statusLabel.Text = "pengajar" Then
            Me.Hide()
            Data_santri.Show()
        Else
            Me.Hide()
            Data_santri.Show()
        End If
    End Sub

    'DATA SANTRI HOVERABLE

    Private Sub dataSantriBtn_Mouse_Hover(sender As Object, e As EventArgs) Handles dataSantriBtn.MouseHover
        dataSantriBtn.BackColor = Color.DarkGreen
        dataSantriLabel.ForeColor = Color.WhiteSmoke
        dataSantriLabel.BackColor = Color.DarkGreen
        dataSantriLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub dataSantriBtn_Mouse_Leave(sender As Object, e As EventArgs) Handles dataSantriBtn.MouseLeave
        dataSantriBtn.BackColor = Color.DarkSeaGreen
        dataSantriLabel.ForeColor = Color.DimGray
        dataSantriLabel.BackColor = Color.DarkSeaGreen
        dataSantriLogo.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub dataSantriLogo_Mouse_Hover(sender As Object, e As EventArgs) Handles dataSantriLogo.MouseHover
        dataSantriBtn.BackColor = Color.DarkGreen
        dataSantriLabel.ForeColor = Color.WhiteSmoke
        dataSantriLabel.BackColor = Color.DarkGreen
        dataSantriLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub dataSantriLogo_Mouse_Leave(sender As Object, e As EventArgs) Handles dataSantriLogo.MouseLeave
        dataSantriBtn.BackColor = Color.DarkSeaGreen
        dataSantriLabel.ForeColor = Color.DimGray
        dataSantriLabel.BackColor = Color.DarkSeaGreen
        dataSantriLogo.BackColor = Color.DarkSeaGreen
    End Sub

    'DATA PENGAJAR

    Private Sub dataPengajarBtn_Click(sender As Object, e As EventArgs) Handles dataPengajarBtn.Click
        If statusLabel.Text = "santri" Then
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf statusLabel.Text = "pengajar" Then
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Me.Hide()
            Data_Pengajar.Show()
        End If
    End Sub

    Private Sub dataPengajarLabel_Click(sender As Object, e As EventArgs) Handles dataPengajarLabel.Click
        If statusLabel.Text = "santri" Then
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf statusLabel.Text = "pengajar" Then
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Me.Hide()
            Data_Pengajar.Show()
        End If
    End Sub

    Private Sub dataPengajarLogo_Click(sender As Object, e As EventArgs) Handles dataPengajarLogo.Click
        If statusLabel.Text = "santri" Then
        ElseIf statusLabel.Text = "pengajar" Then
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Me.Hide()
            Data_Pengajar.Show()
        End If
    End Sub

    'DATA PENGAJAR HOVERABLE

    Private Sub dataPengajarBtn_Mouse_Hover(sender As Object, e As EventArgs) Handles dataPengajarBtn.MouseHover
        dataPengajarBtn.BackColor = Color.DarkGreen
        dataPengajarLabel.ForeColor = Color.WhiteSmoke
        dataPengajarLabel.BackColor = Color.DarkGreen
        dataPengajarLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub dataPengajarBtn_Mouse_Leave(sender As Object, e As EventArgs) Handles dataPengajarBtn.MouseLeave
        dataPengajarBtn.BackColor = Color.DarkSeaGreen
        dataPengajarLabel.ForeColor = Color.DimGray
        dataPengajarLabel.BackColor = Color.DarkSeaGreen
        dataPengajarLogo.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub dataPengajarLogo_Mouse_Hover(sender As Object, e As EventArgs) Handles dataPengajarBtn.MouseHover
        dataPengajarBtn.BackColor = Color.DarkGreen
        dataPengajarLabel.ForeColor = Color.WhiteSmoke
        dataPengajarLabel.BackColor = Color.DarkGreen
        dataPengajarLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub dataPengajarLogo_Mouse_Leave(sender As Object, e As EventArgs) Handles dataPengajarLogo.MouseLeave
        dataPengajarBtn.BackColor = Color.DarkSeaGreen
        dataPengajarLabel.ForeColor = Color.DimGray
        dataPengajarLabel.BackColor = Color.DarkSeaGreen
        dataPengajarLogo.BackColor = Color.DarkSeaGreen
    End Sub

    'DATA KELAS

    Private Sub dataKelasBtn_Click(sender As Object, e As EventArgs) Handles dataKelasBtn.Click
        Me.Hide()
        Data_Kelas.Show()
    End Sub

    Private Sub dataKelasLabel_Click(sender As Object, e As EventArgs) Handles dataKelasLabel.Click
        Me.Hide()
        Data_Kelas.Show()
    End Sub

    Private Sub dataKelasLogo_Click(sender As Object, e As EventArgs) Handles dataKelasLogo.Click
        Me.Hide()
        Data_Kelas.Show()
    End Sub

    'DATA KELAS HOVERABLE

    Private Sub dataKelasBtn_Mouse_Hover(sender As Object, e As EventArgs) Handles dataKelasBtn.MouseHover
        dataKelasBtn.BackColor = Color.DarkGreen
        dataKelasLabel.ForeColor = Color.WhiteSmoke
        dataKelasLabel.BackColor = Color.DarkGreen
        dataKelasLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub dataKelasBtn_Mouse_Leave(sender As Object, e As EventArgs) Handles dataKelasBtn.MouseLeave
        dataKelasBtn.BackColor = Color.DarkSeaGreen
        dataKelasLabel.ForeColor = Color.DimGray
        dataKelasLabel.BackColor = Color.DarkSeaGreen
        dataKelasLogo.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub dataKelasLogo_Mouse_Hover(sender As Object, e As EventArgs) Handles dataKelasBtn.MouseHover
        dataKelasBtn.BackColor = Color.DarkGreen
        dataKelasLabel.ForeColor = Color.WhiteSmoke
        dataKelasLabel.BackColor = Color.DarkGreen
        dataKelasLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub dataKelasLogo_Mouse_Leave(sender As Object, e As EventArgs) Handles dataKelasLogo.MouseLeave
        dataKelasBtn.BackColor = Color.DarkSeaGreen
        dataKelasLabel.ForeColor = Color.DimGray
        dataKelasLabel.BackColor = Color.DarkSeaGreen
        dataKelasLogo.BackColor = Color.DarkSeaGreen
    End Sub

    'JADWAL PELAJARAN

    Private Sub jadwalPelajaranBtn_Click(sender As Object, e As EventArgs) Handles jadwalPelajaranBtn.Click
        If statusLabel.Text = "admin" Then
            Me.Hide()
            Jadwal_Pelajaran.Show()
        Else
            Me.Hide()
            Mata_Pelajaran.Show()
        End If

    End Sub

    Private Sub jadwalPelajaranLabel_Click(sender As Object, e As EventArgs) Handles jadwalPelajaranLabel.Click
        If statusLabel.Text = "admin" Then
            Me.Hide()
            Jadwal_Pelajaran.Show()
        Else
            Me.Hide()
            Mata_Pelajaran.Show()
        End If
    End Sub

    Private Sub jadwalPelajaranLogo_Click(sender As Object, e As EventArgs) Handles jadwalPelajaranLogo.Click
        If statusLabel.Text = "admin" Then
            Me.Hide()
            Jadwal_Pelajaran.Show()
        Else
            Me.Hide()
            Mata_Pelajaran.Show()
        End If
    End Sub

    'JADWAL PELAJARAN HOVERABLE

    Private Sub jadwalPelajaranBtn_Mouse_Hover(sender As Object, e As EventArgs) Handles jadwalPelajaranBtn.MouseHover
        jadwalPelajaranBtn.BackColor = Color.DarkGreen
        jadwalPelajaranLabel.ForeColor = Color.WhiteSmoke
        jadwalPelajaranLabel.BackColor = Color.DarkGreen
        jadwalPelajaranLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub jadwalPelajaranBtn_Mouse_Leave(sender As Object, e As EventArgs) Handles jadwalPelajaranBtn.MouseLeave
        jadwalPelajaranBtn.BackColor = Color.DarkSeaGreen
        jadwalPelajaranLabel.ForeColor = Color.DimGray
        jadwalPelajaranLabel.BackColor = Color.DarkSeaGreen
        jadwalPelajaranLogo.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub jadwalPelajaranLogo_Mouse_Hover(sender As Object, e As EventArgs) Handles jadwalPelajaranBtn.MouseHover
        jadwalPelajaranBtn.BackColor = Color.DarkGreen
        jadwalPelajaranLabel.ForeColor = Color.WhiteSmoke
        jadwalPelajaranLabel.BackColor = Color.DarkGreen
        jadwalPelajaranLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub jadwalPelajaranLogo_Mouse_Leave(sender As Object, e As EventArgs) Handles jadwalPelajaranLogo.MouseLeave
        jadwalPelajaranBtn.BackColor = Color.DarkSeaGreen
        jadwalPelajaranLabel.ForeColor = Color.DimGray
        jadwalPelajaranLabel.BackColor = Color.DarkSeaGreen
        jadwalPelajaranLogo.BackColor = Color.DarkSeaGreen
    End Sub

    'KEGIATAN BELAJAR

    Private Sub kegiatanBelajarBtn_Click(sender As Object, e As EventArgs) Handles kegiatanBelajarBtn.Click
        MessageBox.Show("Anda Sedang Di Menu Kegiatan Belajar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        If myBool = True Then
            Call hideKBMdetail()
        Else
            Call showKBMdetail()
        End If
    End Sub

    Private Sub kegiatanBelajarLogo_Click(sender As Object, e As EventArgs) Handles kegiatanBelajarLogo.Click
        MessageBox.Show("Anda Sedang Di Menu Kegiatan Belajar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        If myBool = True Then
            Call hideKBMdetail()
        Else
            Call showKBMdetail()
        End If
    End Sub

    Private Sub kegiatanBelajarLabel_Click(sender As Object, e As EventArgs) Handles kegiatanBelajarLabel.Click
        MessageBox.Show("Anda Sedang Di Menu Kegiatan Belajar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        If myBool = True Then
            Call hideKBMdetail()
        Else
            Call showKBMdetail()
        End If
    End Sub

    'LOG OUT

    Private Sub logOutBtn_Click(sender As Object, e As EventArgs) Handles logOutBtn.Click
        Dim Dr As DialogResult = MessageBox.Show("Anda Yakin Ingin Log Out ?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If Dr = DialogResult.Yes Then
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub logOutLogo_Click(sender As Object, e As EventArgs) Handles logOutLogo.Click
        Dim Dr As DialogResult = MessageBox.Show("Anda Yakin Ingin Log Out ?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If Dr = DialogResult.Yes Then
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub logOutLabel_Click(sender As Object, e As EventArgs) Handles logOutLabel.Click
        Dim Dr As DialogResult = MessageBox.Show("Anda Yakin Ingin Log Out ?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If Dr = DialogResult.Yes Then
            Me.Hide()
            Login.Show()
        End If
    End Sub

    'LOG OUT HOVERABLE

    Private Sub logOutBtn_Mouse_Hover(sender As Object, e As EventArgs) Handles logOutBtn.MouseHover
        logOutBtn.BackColor = Color.DarkGreen
        logOutLabel.ForeColor = Color.WhiteSmoke
        logOutLabel.BackColor = Color.DarkGreen
        logOutLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub logOutBtn_Mouse_Leave(sender As Object, e As EventArgs) Handles logOutBtn.MouseLeave
        logOutBtn.BackColor = Color.DarkSeaGreen
        logOutLabel.ForeColor = Color.DimGray
        logOutLabel.BackColor = Color.DarkSeaGreen
        logOutLogo.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub logOutLogo_Mouse_Hover(sender As Object, e As EventArgs) Handles logOutBtn.MouseHover
        logOutBtn.BackColor = Color.DarkGreen
        logOutLabel.ForeColor = Color.WhiteSmoke
        logOutLabel.BackColor = Color.DarkGreen
        logOutLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub logOutLogo_Mouse_Leave(sender As Object, e As EventArgs) Handles logOutLogo.MouseLeave
        logOutBtn.BackColor = Color.DarkSeaGreen
        logOutLabel.ForeColor = Color.DimGray
        logOutLabel.BackColor = Color.DarkSeaGreen
        logOutLogo.BackColor = Color.DarkSeaGreen
    End Sub

    'ACTION

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pilihKelasCb.SelectedIndexChanged
        kelasLabel.Text = "Kelas                : " + pilihKelasCb.Text()
        Call showKBMdetail()
        If sourceBuffer = "" Then
            viewBtn.Enabled = False
        End If
        If pilihKelasCb.Text() = "" Then

        Else
            Call connection()
            Da = New SqlClient.SqlDataAdapter("select namaPengajar from pengajar where namaUser = '" & userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "pengajar")
            namaGuruLabel.Text = "Pengajar           : " + Ds.Tables(0).Rows(0).Item("namaPengajar").ToString()
            Da = New SqlClient.SqlDataAdapter("select mataPelajaran.namaMatpel from mataPelajaran inner join pengajar on mataPelajaran.niy = pengajar.niy where pengajar.namaUser = '" & userNameLabel.Text() & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "mataPelajaran")
            MataPelajaranLabel.Text = "Mata Pelajaran : " + Ds.Tables(0).Rows(0).Item("namaMatpel").ToString()
            Da = New SqlClient.SqlDataAdapter("select kodeKelas from kelas where namaKelas = '" & pilihKelasCb.Text() & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "kelas")
            kodeKelasLabel.Text = Ds.Tables(0).Rows(0).Item("kodeKelas").ToString()
            myBool = False
        End If
        Call dataGridReload()
    End Sub
    Sub dataGridReload()
        Call connection()
        Da = New SqlClient.SqlDataAdapter("Select judulMateri,filePath from materi inner join kegiatanBelajar on materi.kodeKBM = kegiatanBelajar.kodeKBM where kegiatanBelajar.kodeKelas = '" & kodeKelasLabel.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "materi")
        DataGridView1.DataSource = Ds.Tables("materi")
    End Sub

    ' BROWSE BTN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles browseFileBtn.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            sourceBuffer = OpenFileDialog1.FileName
            viewBtn.Enabled = True
        End If
        Call showKBMdetail()


    End Sub

    ' PILIH  MATERI
    Private Sub dataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)
            sourceBuffer = row.Cells(1).Value.ToString
            If sourceBuffer = "" Then
                viewBtn.Enabled = False
            Else
                viewBtn.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles viewBtn.Click
        Dim oWord As Microsoft.Office.Interop.Word.Application
        Dim doc As Microsoft.Office.Interop.Word.Document
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        doc = oWord.Documents.Add(sourceBuffer)
    End Sub

    'UPLOAD MATERI BTN

    Private Sub uploadMateriBtn_Click(sender As Object, e As EventArgs) Handles uploadMateriBtn.Click
        Dim kkbmBuffer As String
        sourceBuffer = OpenFileDialog1.FileName
        If sourceBuffer.ToString() = "" Then
            Da = New SqlClient.SqlDataAdapter("select kodeKBM from kegiatanBelajar inner join pengajar on kegiatanBelajar.niy = pengajar.niy inner join kelas on kegiatanBelajar.kodeKelas = kelas.kodeKelas where kelas.kodeKelas='" & kodeKelasLabel.Text & "' and pengajar.namaUser = '" & userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "kegiatanBelajar")
            kkbmBuffer = Ds.Tables(0).Rows(0).Item("kodeKBM").ToString()
            Dim isi1 As String = "insert into materi SELECT N'" & kkbmBuffer & "','" & judulMateriTB.Text & "',N'',''"
            Cmd = New SqlClient.SqlCommand(isi1, Conn)
            Cmd.ExecuteNonQuery()
        Else
            Call connection()
            Da = New SqlClient.SqlDataAdapter("select kodeKBM from kegiatanBelajar inner join pengajar on kegiatanBelajar.niy = pengajar.niy inner join kelas on kegiatanBelajar.kodeKelas = kelas.kodeKelas where kelas.kodeKelas='" & kodeKelasLabel.Text & "' and pengajar.namaUser = '" & userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "kegiatanBelajar")
            kkbmBuffer = Ds.Tables(0).Rows(0).Item("kodeKBM").ToString()
            Dim isi As String = "insert into materi SELECT N'" & kkbmBuffer & "','" & judulMateriTB.Text & "',N'" & sourceBuffer & "', BulkColumn FROM OPENROWSET(BULK  N'" & sourceBuffer & "', SINGLE_BLOB) blob"
            Cmd = New SqlClient.SqlCommand(isi, Conn)
            Cmd.ExecuteNonQuery()
        End If
        judulMateriTB.Text = ""
        MessageBox.Show("Berhasil Mengupload Materi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Call showKBMdetail()
        Call dataGridReload()


    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Call hideKBMdetail()
    End Sub

   
End Class
