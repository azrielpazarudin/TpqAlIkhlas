Public Class Data_Kelas
    Sub addEditMode()
        saveBtn.Enabled = True
        cancelBtn.Enabled = True
        kodeKelasCb.Enabled = True
        kodeKelasCb.Text = ""
        namaKelasTb.Enabled = True
        jumlahSantriTb.Enabled = True
        addBtn.Enabled = False
        editBtn.Enabled = False
        deleteBtn.Enabled = False
    End Sub
    Sub closeAEM()
        saveBtn.Enabled = False
        cancelBtn.Enabled = False
        kodeKelasCb.Enabled = False
        kodeKelasCb.Text = ""
        namaKelasTb.Enabled = False
        jumlahSantriTb.Enabled = False
        addBtn.Enabled = True
        saveBtn.Enabled = False
        cancelBtn.Enabled = False
        editBtn.Enabled = True
        deleteBtn.Enabled = True
        exitBtn.Enabled = True
    End Sub
    Sub clear()
        kodeKelasCb.Text = ""
        namaKelasTb.Text = ""
        jumlahSantriTb.Text = ""
    End Sub

    Sub dataGridReload()
        Da = New SqlClient.SqlDataAdapter("select *from kelas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "kelas")
        DataGridView1.DataSource = Ds.Tables("kelas")

    End Sub

    Private Sub Data_Kelas_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        userNameLabel.Text = Login.userNameBuffer.Text
        Call connection()
        Da = New SqlClient.SqlDataAdapter("select status from akun where namaUser='" & userNameLabel.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "akun")
        statusLabel.Text = Ds.Tables(0).Rows(0).Item("status").ToString()
        kodeKelasCb.Enabled = False
        namaKelasTb.Enabled = False
        jumlahSantriTb.Enabled = False
        kodeKelasCb.Text = ""
        If statusLabel.Text = "admin" Then
            Call closeAEM()

        Else
            addBtn.Enabled = False
            saveBtn.Enabled = False
            cancelBtn.Enabled = False
            editBtn.Enabled = False
            deleteBtn.Enabled = False
            exitBtn.Enabled = False
        End If

    End Sub

    Private Sub Data_Kelas_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KelasTableAdapter.Fill(Me.TpqAlikhlasDataSet5.kelas)
    End Sub

    ' FORM BORDER NAVIGATION
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
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh  Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    ' DATA KELAS
    Private Sub dataKelasBtn_Click(sender As Object, e As EventArgs) Handles dataKelasBtn.Click
        MessageBox.Show("Anda Sedang Di Menu Data Kelas", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub dataKelasLabel_Click(sender As Object, e As EventArgs) Handles dataKelasLabel.Click
        MessageBox.Show("Anda Sedang Di Menu Data Kelas", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub dataKelasLogo_Click(sender As Object, e As EventArgs) Handles dataKelasLogo.Click
        MessageBox.Show("Anda Sedang Di Menu Data Kelas", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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


    'ACTION (ADMIN MODE)'
    ' SEARCH'
    Private Sub searchTb_MousClick(sender As Object, e As EventArgs) Handles searchTb.MouseClick
        MessageBox.Show("Lakukan Pencarian Berdasarkan Nama Kelas", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
    Private Sub searchTb_TextChanged(sender As Object, e As EventArgs) Handles searchTb.TextChanged
        Call connection()
        Da = New SqlClient.SqlDataAdapter("Select * from kelas where namaKelas LIKE '%" & searchTb.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "kelas")
        DataGridView1.DataSource = Ds.Tables("kelas")
    End Sub
    '   Pilih Data       
    Private Sub dataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            kodeKelasCb.Text = row.Cells(0).Value.ToString()
            namaKelasTb.Text = row.Cells(1).Value.ToString()
            jumlahSantriTb.Text = row.Cells(2).Value.ToString()
            Dim buffer = kodeKelasCb.Text
            If delete = True Then
                Dim dr As DialogResult = MessageBox.Show("Apakah Anda Yakin Untuk Menghapus Data Ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                If dr = Windows.Forms.DialogResult.Yes Then
                    Call connection()
                    Cmd = New SqlClient.SqlCommand("delete from kelas where kodeKelas = '" & buffer & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    MessageBox.Show("Berhasil Menghapus Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    delete = False
                    Call closeAEM()
                    Call clear()
                    Call dataGridReload()
                End If
                
            End If
        End If
    End Sub
    ' ADD
    Dim add As Boolean = False
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        MessageBox.Show("Menambah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Call addEditMode()
        add = True
    End Sub
    ' EXIT
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Call closeAEM()
    End Sub
   
    ' DELETE'
    Dim delete As Boolean = False
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        MessageBox.Show("Menghapus Data (pilih data yang ada di table)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        delete = True
    End Sub

    ' EDIT'
    Dim edit As Boolean = False
    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        MessageBox.Show("Mengubah Data (pilih data yang ada di table)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Call addEditMode()
        edit = True
    End Sub

    ' SAVE
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim kodeKelasBuff As String = kodeKelasCb.Text
        Dim namaKelasBuff As String = namaKelasTb.Text
        Dim jumlahSantriBuff As String = jumlahSantriTb.Text
        If add = True Then
            If kodeKelasCb.Text = "" Or namaKelasTb.Text = "" Or jumlahSantriTb.Text = "" Then
                MessageBox.Show("Data Harus Lengkap", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Call addEditMode()
                kodeKelasCb.Text = kodeKelasBuff
                namaKelasTb.Text = namaKelasBuff
                jumlahSantriTb.Text = jumlahSantriBuff
            Else

                Call connection()
                Cmd = New SqlClient.SqlCommand("insert into kelas values ('" & kodeKelasCb.Text & "','" & namaKelasTb.Text & "','" & jumlahSantriTb.Text & "')", Conn)
                Rd = Cmd.ExecuteReader
                MessageBox.Show("Berhasil Menambah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                add = False
                Call addEditMode()
                Call clear()
                Call dataGridReload()

            End If
        End If
        If edit = True Then

            Call addEditMode()
            kodeKelasCb.Enabled = False
            kodeKelasCb.Text = kodeKelasBuff
            kodeKelasCb.Enabled = False
            Cmd = New SqlClient.SqlCommand("update kelas set namaKelas='" & namaKelasTb.Text & "',jumlahSantri='" & jumlahSantriTb.Text & "' where kodeKelas='" & kodeKelasCb.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            MessageBox.Show("Berhasil Merubah Data ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Call clear()
            edit = False
            Call closeAEM()
            Call dataGridReload()
        End If

    End Sub

    
End Class


