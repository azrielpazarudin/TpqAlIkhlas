Public Class Data_Pengajar
    'ADMIN MODE'
    Sub adminMode()
        addBtn.Enabled = True
        editBtn.Enabled = True
        deleteBtn.Enabled = True
        saveBtn.Enabled = False
        cancelBtn.Enabled = False
        exitBtn.Enabled = False
        niyTb.Enabled = False
        namaPengajarTB.Enabled = False
        alamatTb.Enabled = False
        namaUserTb.Enabled = False
        kataSandiTb.Enabled = False
        noHpTb.Enabled = False
    End Sub
    Sub clear()
        niyTb.Text = ""
        namaPengajarTB.Text = ""
        alamatTb.Text = ""
        namaUserTb.Text = ""
        kataSandiTb.Text = ""
        noHpTb.Text = ""
    End Sub
    Private Sub Data_Pengajar_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        userNameLabel.Text = Login.userNameBuffer.Text
        Call connection()
        Da = New SqlClient.SqlDataAdapter("select status from akun where namaUser='" & userNameLabel.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "akun")
        statusLabel.Text = Ds.Tables(0).Rows(0).Item("status").ToString()
        Call adminMode()
    End Sub
    ' RELOAD DATA GRID (ADMIN)
    Sub dataGridReload()
        Call connection()
        Da = New SqlClient.SqlDataAdapter("Select * from pengajar", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pengajar")
        DataGridView1.DataSource = Ds.Tables("pengajar")
    End Sub
    Private Sub Data_Pengajar_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TpqAlikhlasDataSet8.pengajar' table. You can move, or remove it, as needed.
        Call dataGridReload()
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
        Me.Hide()
        Data_santri.Show()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles dataSantriLabel.Click
        Me.Hide()
        Data_santri.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles dataSantriLogo.Click
        Me.Hide()
        Data_santri.Show()
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
        MessageBox.Show("Anda Sedang Di Menu Data Pengajar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub dataPengajarLabel_Click(sender As Object, e As EventArgs) Handles dataPengajarLabel.Click
        MessageBox.Show("Anda Sedang Di Menu Data Pengajar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub dataPengajarLogo_Click(sender As Object, e As EventArgs) Handles dataPengajarLogo.Click
        MessageBox.Show("Anda Sedang Di Menu Data Pengajar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

        If statusLabel.Text = "santri" Then
            Me.Hide()
            Kegiatan_Belajar_Santri.Show()
        ElseIf statusLabel.Text = "pengajar" Then
            Me.Hide()
            Kegiatan_Belajar.Show()
        End If

    End Sub

    Private Sub kegiatanBelajarLabel_Click(sender As Object, e As EventArgs) Handles kegiatanBelajarLabel.Click
        If statusLabel.Text = "santri" Then
            Me.Hide()
            Kegiatan_Belajar_Santri.Show()
        ElseIf statusLabel.Text = "pengajar" Then
            Me.Hide()
            Kegiatan_Belajar.Show()
        End If
    End Sub

    Private Sub kegiatanBelajarLogo_Click(sender As Object, e As EventArgs) Handles kegiatanBelajarLogo.Click
        If statusLabel.Text = "santri" Then
            Me.Hide()
            Kegiatan_Belajar_Santri.Show()
        ElseIf statusLabel.Text = "pengajar" Then
            Me.Hide()
            Kegiatan_Belajar.Show()
        End If
    End Sub

    'KEGIATAN BELAJAR HOVERABLE

    Private Sub kegiatanBelajarBtn_Mouse_Hover(sender As Object, e As EventArgs) Handles kegiatanBelajarBtn.MouseHover
        kegiatanBelajarBtn.BackColor = Color.DarkGreen
        kegiatanBelajarLabel.ForeColor = Color.WhiteSmoke
        kegiatanBelajarLabel.BackColor = Color.DarkGreen
        kegiatanBelajarLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub kegiatanBelajarBtn_Mouse_Leave(sender As Object, e As EventArgs) Handles kegiatanBelajarBtn.MouseLeave
        kegiatanBelajarBtn.BackColor = Color.DarkSeaGreen
        kegiatanBelajarLabel.ForeColor = Color.DimGray
        kegiatanBelajarLabel.BackColor = Color.DarkSeaGreen
        kegiatanBelajarLogo.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub kegiatanBelajarLogo_Mouse_Hover(sender As Object, e As EventArgs) Handles kegiatanBelajarBtn.MouseHover
        kegiatanBelajarBtn.BackColor = Color.DarkGreen
        kegiatanBelajarLabel.ForeColor = Color.WhiteSmoke
        kegiatanBelajarLabel.BackColor = Color.DarkGreen
        kegiatanBelajarLogo.BackColor = Color.DarkGreen
    End Sub

    Private Sub kegiatanBelajarLogo_Mouse_Leave(sender As Object, e As EventArgs) Handles kegiatanBelajarLogo.MouseLeave
        kegiatanBelajarBtn.BackColor = Color.DarkSeaGreen
        kegiatanBelajarLabel.ForeColor = Color.DimGray
        kegiatanBelajarLabel.BackColor = Color.DarkSeaGreen
        kegiatanBelajarLogo.BackColor = Color.DarkSeaGreen
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


    ' ACTION (ADMIN MODE)

    Private Sub searchTb_MousClick(sender As Object, e As EventArgs) Handles searchTb.MouseClick
        MessageBox.Show("Lakukan Pencarian Berdasarkan Nama", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub searchTb_TextChanged(sender As Object, e As EventArgs) Handles searchTb.TextChanged
        Da = New SqlClient.SqlDataAdapter("Select * from pengajar where namaPengajar LIKE '%" & searchTb.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pengajar")
        DataGridView1.DataSource = Ds.Tables("pengajar")
    End Sub
    'SEARCH'
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Da = New SqlClient.SqlDataAdapter("Select niy,namaPengajar,alamat,noHp from pengajar where namaPengajar LIKE '%" & searchTb.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pengajar")
        DataGridView1.DataSource = Ds.Tables("pengajar")
    End Sub

    ' CRUD
    Sub addEditMode()
        niyTb.Enabled = True
        namaPengajarTB.Enabled = True
        alamatTb.Enabled = True
        namaUserTb.Enabled = True
        kataSandiTb.Enabled = True
        noHpTb.Enabled = True
        addBtn.Enabled = False
        editBtn.Enabled = False
    End Sub

    ' ADD
    Dim edit As Boolean
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        MessageBox.Show("Menambah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        saveBtn.Enabled = True
        cancelBtn.Enabled = True
        exitBtn.Enabled = True
        editBtn.Enabled = False
        deleteBtn.Enabled = False
        Call addEditMode()

    End Sub
  

    
    ' EDIT
    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        MessageBox.Show("Mengubah Data (pilih data yang terdapat dalam table)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        saveBtn.Enabled = True
        cancelBtn.Enabled = True
        exitBtn.Enabled = True
        editBtn.Enabled = False
        deleteBtn.Enabled = False
        edit = True
        Call addEditMode()

    End Sub

    'DELETE
    Dim delete As Boolean = False
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        MessageBox.Show("Pilih data dalam tabel yang akan di hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        delete = True
        addBtn.Enabled = False
        editBtn.Enabled = False
        exitBtn.Enabled = True
    End Sub
    'pilih data di Data Grid

    Private Sub dataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            niyTb.Text = row.Cells(0).Value.ToString()
            namaPengajarTB.Text = row.Cells(1).Value.ToString()
            alamatTb.Text = row.Cells(2).Value.ToString()
            noHpTb.Text = row.Cells(3).Value.ToString()
            namaUserTb.Text = row.Cells(4).Value.ToString()
            kataSandiTb.Text = row.Cells(5).Value.ToString()
            If edit = True Then
                niyTb.Enabled = False
                namaUserTb.Enabled = False
            End If
            ' UNTUK DELETE
            If delete = True Then
                niyTb.Text = row.Cells(0).Value.ToString()
                namaPengajarTB.Text = row.Cells(1).Value.ToString()
                alamatTb.Text = row.Cells(2).Value.ToString()
                noHpTb.Text = row.Cells(3).Value.ToString()
                namaUserTb.Text = row.Cells(4).Value.ToString()
                kataSandiTb.Text = row.Cells(5).Value.ToString()
                Dim Dr As DialogResult = MessageBox.Show("Apakah Anda Yakin Untuk Menghapus Data Tersebut?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                niyTb.Text = row.Cells(0).Value.ToString()
                namaPengajarTB.Text = row.Cells(1).Value.ToString()
                alamatTb.Text = row.Cells(2).Value.ToString()
                noHpTb.Text = row.Cells(3).Value.ToString()
                namaUserTb.Text = row.Cells(4).Value.ToString()
                kataSandiTb.Text = row.Cells(5).Value.ToString()
                If Dr = DialogResult.Yes Then
                    Call connection()
                    Cmd = New SqlClient.SqlCommand("delete from pengajar  where namaUser = '" & namaUserTb.Text & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    Call connection()
                    Cmd = New SqlClient.SqlCommand("delete from akun  where namaUser = '" & namaUserTb.Text & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    MessageBox.Show("Data Berhasil Di Hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Call clear()
                    Call dataGridReload()
                    Call adminMode()
                    delete = False
                End If
            End If
        End If

    End Sub

    ' Save
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim niyBuff As String = niyTb.Text
        Dim namaPengajarBuff As String = namaPengajarTB.Text
        Dim alamatBuff As String = alamatTb.Text
        Dim noHpBuff As String = noHpTb.Text
        Dim namaUserBuff As String = namaUserTb.Text
        Dim kataSandiBuff As String = kataSandiTb.Text
        Call connection()
        Dim succes As Boolean
        If edit = True Then
            If niyTb.Text = "" Or namaPengajarTB.Text = "" Or alamatTb.Text = "" Or noHpTb.Text = "" Or namaUserTb.Text = "" Or kataSandiTb.Text = "" Then
                MessageBox.Show("Data Harus Lengkap", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                niyTb.Enabled = True
                namaPengajarTB.Enabled = True
                noHpTb.Enabled = True
                alamatTb.Enabled = True
                namaUserTb.Enabled = True
                kataSandiTb.Enabled = True
                GoTo s
                succes = False
            Else
                Cmd = New SqlClient.SqlCommand("update pengajar set namaPengajar='" & namaPengajarTB.Text & "',alamat='" & alamatTb.Text & "',noHp='" & noHpTb.Text & "',kataSandi='" & kataSandiTb.Text & "' where niy='" & niyTb.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Call connection()
                Cmd = New SqlClient.SqlCommand("update akun set kataSandi='" & kataSandiTb.Text & "' where namaUser='" & namaUserTb.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                MessageBox.Show("Berhasil Merubah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                namaPengajarTB.Enabled = True
                noHpTb.Enabled = True
                alamatTb.Enabled = True
                kataSandiTb.Enabled = True
            End If
        Else
            Cmd = New SqlClient.SqlCommand("select niy from pengajar where niy = '" & niyTb.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MessageBox.Show("NIY tidak boleh sama", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                niyTb.Text = niyBuff
                namaPengajarTB.Text = namaPengajarBuff
                alamatTb.Text = alamatBuff
                noHpTb.Text = noHpBuff
                namaUserTb.Text = namaUserBuff
                kataSandiTb.Text = kataSandiBuff
                niyTb.Enabled = True
                namaPengajarTB.Enabled = True
                noHpTb.Enabled = True
                alamatTb.Enabled = True
                namaUserTb.Enabled = True
                kataSandiTb.Enabled = True
                GoTo s
                succes = False
            End If
            Call connection()
            Cmd = New SqlClient.SqlCommand("select namaUser from pengajar where namaUser = '" & namaUserTb.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MessageBox.Show("Nama User tidak boleh sama", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                niyTb.Text = niyBuff
                namaPengajarTB.Text = namaPengajarBuff
                alamatTb.Text = alamatBuff
                noHpTb.Text = noHpBuff
                namaUserTb.Text = namaUserBuff
                kataSandiTb.Text = kataSandiBuff
                niyTb.Enabled = True
                namaPengajarTB.Enabled = True
                noHpTb.Enabled = True
                alamatTb.Enabled = True
                namaUserTb.Enabled = True
                kataSandiTb.Enabled = True
                GoTo s
                succes = False
            End If
            Call connection()
            Cmd = New SqlClient.SqlCommand("select niy,namaUser from pengajar where namaUser = '" & namaUserTb.Text & "'and niy = '" & niyTb.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                MessageBox.Show("NIY dan Nama User tidak boleh sama", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                niyTb.Text = niyBuff
                namaPengajarTB.Text = namaPengajarBuff
                alamatTb.Text = alamatBuff
                noHpTb.Text = noHpBuff
                namaUserTb.Text = namaUserBuff
                kataSandiTb.Text = kataSandiBuff
                niyTb.Enabled = True
                namaPengajarTB.Enabled = True
                noHpTb.Enabled = True
                alamatTb.Enabled = True
                namaUserTb.Enabled = True
                kataSandiTb.Enabled = True
                GoTo s
                succes = False
            End If
            If niyTb.Text = "" Or namaPengajarTB.Text = "" Or alamatTb.Text = "" Or noHpTb.Text = "" Or namaUserTb.Text = "" Or kataSandiTb.Text = "" Then
                MessageBox.Show("Data Harus Lengkap", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                niyTb.Enabled = True
                namaPengajarTB.Enabled = True
                noHpTb.Enabled = True
                alamatTb.Enabled = True
                namaUserTb.Enabled = True
                kataSandiTb.Enabled = True
                GoTo s
                succes = False
            Else
                Call connection()
                Cmd = New SqlClient.SqlCommand("insert into akun values ('" & namaUserTb.Text & "','" & kataSandiTb.Text & "','pengajar')", Conn)
                Rd = Cmd.ExecuteReader
                Call connection()
                Cmd = New SqlClient.SqlCommand("insert into pengajar values ('" & niyTb.Text & "','" & namaPengajarTB.Text & "','" & alamatTb.Text & "','" & noHpTb.Text & "','" & namaUserTb.Text & "','" & kataSandiTb.Text & "')", Conn)
                Rd = Cmd.ExecuteReader
                succes = True
                If succes = True Then
                    MessageBox.Show("Berhasil Menambahkan Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    niyTb.Text = ""
                    namaPengajarTB.Text = ""
                    alamatTb.Text = ""
                    namaUserTb.Text = ""
                    kataSandiTb.Text = ""
                    noHpTb.Text = ""
                    niyTb.Enabled = True
                    namaPengajarTB.Enabled = True
                    noHpTb.Enabled = True
                    alamatTb.Enabled = True
                    namaUserTb.Enabled = True
                    kataSandiTb.Enabled = True
                End If

            End If
        End If

s:
            saveBtn.Enabled = True
            cancelBtn.Enabled = True
            exitBtn.Enabled = True
            editBtn.Enabled = False
            deleteBtn.Enabled = False
            Call dataGridReload()
            addBtn.Enabled = False
    End Sub
    '  cancel btn
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        If edit = True Then
            Call adminMode()
        Else
            Call clear()
        End If
    End Sub
    ' EXIT
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        edit = False
        delete = False
        Call adminMode()
    End Sub
  
End Class