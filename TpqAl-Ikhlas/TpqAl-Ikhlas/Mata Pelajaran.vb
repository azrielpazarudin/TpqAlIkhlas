Public Class Mata_Pelajaran
    Sub addEditMode()
        addBtn.Enabled = False
        editBtn.Enabled = False
        deleteBtn.Enabled = False
        saveBtn.Enabled = True
        cancelBtn.Enabled = True
        kodeMatpelTb.Enabled = True
        namaMatpelTb.Enabled = True
        niyCb.Enabled = True
        namaPengajarTb.Enabled = True
    End Sub
    Sub closeAEM()
        addBtn.Enabled = True
        saveBtn.Enabled = False
        cancelBtn.Enabled = False
        editBtn.Enabled = True
        deleteBtn.Enabled = True
    End Sub
    Sub clear()
        kodeMatpelTb.Text = ""
        namaMatpelTb.Text = ""
        niyCb.Text = ""
        namaPengajarTb.Text = ""
    End Sub
    Sub dataGridReload()
        Da = New SqlClient.SqlDataAdapter("select *from mataPelajaran", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "matpel")
        DataGridView1.DataSource = Ds.Tables("matpel")
    End Sub
    Sub start()
        kodeMatpelTb.Enabled = False
        namaMatpelTb.Enabled = False
        niyCb.Enabled = False
        niyCb.Text = ""
        namaPengajarTb.Enabled = False
    End Sub
    Private Sub Mata_Pelajaran_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        'TODO: This line of code loads data into the 'TpqAlikhlasDataSet12.mataPelajaran' table. You can move, or remove it, as needed.
        Me.MataPelajaranTableAdapter.Fill(Me.TpqAlikhlasDataSet12.mataPelajaran)
        userNameLabel.Text = Login.userNameBuffer.Text
        Call connection()
        Da = New SqlClient.SqlDataAdapter("select status from akun where namaUser='" & userNameLabel.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "akun")
        statusLabel.Text = Ds.Tables(0).Rows(0).Item("status").ToString()
        Call start()

        If statusLabel.Text = "admin" Then
            Call closeAEM()
            Button1.Text = "Kembali"
        Else
            Button1.Text = "Lihat Jadwal Lengkap"
            addBtn.Enabled = False
            saveBtn.Enabled = False
            cancelBtn.Enabled = False
            editBtn.Enabled = False
            deleteBtn.Enabled = False
            exitBtn.Enabled = False
        End If


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
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh  Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf statusLabel.Text = "pengajar" Then
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Me.Hide()
            Data_Pengajar.Show()
        End If
    End Sub

    Private Sub dataPengajarLogo_Click(sender As Object, e As EventArgs) Handles dataPengajarLogo.Click
        If statusLabel.Text = "santri" Then
            MessageBox.Show("Menu Ini Hanya Dapat Diakses Oleh  Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
        dataKelasBtn.BackColor = Color.DarkSeaGreen
        dataKelasLabel.ForeColor = Color.DimGray
        dataKelasLabel.BackColor = Color.DarkSeaGreen
        dataKelasLogo.BackColor = Color.DarkSeaGreen
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
        MessageBox.Show("Anda Sedang Di Menu Jadwal Pelajaran", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub jadwalPelajaranLabel_Click(sender As Object, e As EventArgs) Handles jadwalPelajaranLabel.Click
        MessageBox.Show("Anda Sedang Di Menu Jadwal Pelajaran", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub jadwalPelajaranLogo_Click(sender As Object, e As EventArgs) Handles jadwalPelajaranLogo.Click
        MessageBox.Show("Anda Sedang Di Menu Jadwal Pelajaran", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    'KEGIATAN BELAJAR

    Private Sub kegiatanBelajarBtn_Click(sender As Object, e As EventArgs) Handles kegiatanBelajarBtn.Click
        Me.Hide()
        Kegiatan_Belajar.Show()
    End Sub

    Private Sub kegiatanBelajarLabel_Click(sender As Object, e As EventArgs) Handles kegiatanBelajarLabel.Click
        Me.Hide()
        Kegiatan_Belajar.Show()
    End Sub

    Private Sub kegiatanBelajarLogo_Click(sender As Object, e As EventArgs) Handles kegiatanBelajarLogo.Click
        Me.Hide()
        Kegiatan_Belajar.Show()
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

    ' ACTION (ADMIN MODE)'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If statusLabel.Text = "admin" Then
            Me.Hide()
            Jadwal_Pelajaran.Show()

        Else
            Me.Hide()
            Jadpel_Santri.Show()
        End If

    End Sub
    ' SEARCH'
    Private Sub searchTb_MousClick(sender As Object, e As EventArgs) Handles searchTb.MouseClick
        MessageBox.Show("Lakukan Pencarian Berdasarkan Nama Mata Pelajaran", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchTb.TextChanged
        Call connection()
        Da = New SqlClient.SqlDataAdapter("Select * from mataPelajaran where namaMatpel LIKE '%" & searchTb.Text & "%' order by kodeMatpel asc", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "matpel")
        DataGridView1.DataSource = Ds.Tables("matpel")
    End Sub
    ' PILIH DATA DI DATA GRID'
    Private Sub dataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            kodeMatpelTb.Text = row.Cells(0).Value.ToString()
            namaMatpelTb.Text = row.Cells(1).Value.ToString()
            niyCb.Text = row.Cells(2).Value.ToString()
            namaPengajarTb.Text = row.Cells(3).Value.ToString()
        End If
        If delete = True Then
            Dim dr As DialogResult = MessageBox.Show("Apakah Anda Yakin Untuk Menghapus Data Ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If dr = Windows.Forms.DialogResult.Yes Then
                Call connection()
                Cmd = New SqlClient.SqlCommand("select kodeMatpel from kegiatanBelajar where kodeMatpel = '" & kodeMatpelTb.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                If Rd.HasRows Then
                    Call connection()
                    Cmd = New SqlClient.SqlCommand("delete from kegiatanBelajar where kodeMatpel ='" & kodeMatpelTb.Text & "' ", Conn)
                    Rd = Cmd.ExecuteReader
                End If
                Call connection()
                Cmd = New SqlClient.SqlCommand("delete from mataPelajaran where kodeMatpel ='" & kodeMatpelTb.Text & "' ", Conn)
                Rd = Cmd.ExecuteReader
                MessageBox.Show("Berhasil Menghapus Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                delete = False
                Call closeAEM()
                Call clear()
                Call dataGridReload()
            End If
           
        End If
    End Sub

    Private Sub niyCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles niyCb.SelectedIndexChanged
        If niyCb.Text = "" Then
        Else
            Da = New SqlClient.SqlDataAdapter("select namaPengajar from pengajar where niy='" & niyCb.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "pengajar")
            namaPengajarTb.Text = Ds.Tables(0).Rows(0).Item("namaPengajar").ToString()
        End If
        Call connection()
    End Sub
    ' ADD'
    Dim add As Boolean = False
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        MessageBox.Show("Menambah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        add = True
        Call addEditMode()

    End Sub

    'EDIT'
    Dim edit As Boolean = False
    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        edit = True
        MessageBox.Show("Mengubah Data ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Call addEditMode()
        kodeMatpelTb.Enabled = False

    End Sub
    ' DELETE'
    Sub deleteMode()
        addBtn.Enabled = False
        editBtn.Enabled = False
    End Sub
    Dim delete As Boolean = False
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        MessageBox.Show("Menghapus Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Call deleteMode()
        delete = True
    End Sub
    ' ADD'
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If add = True Then
            If kodeMatpelTb.Text = "" Or namaMatpelTb.Text = "" Or niyCb.Text = "" Or namaPengajarTb.Text = "" Then
                MessageBox.Show("Data Harus Lengkap", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Call addEditMode()
            Else
                Call connection()
                Cmd = New SqlClient.SqlCommand("select kodeMatpel from mataPelajaran where kodeMatpel ='" & kodeMatpelTb.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                If Rd.HasRows Then
                    MessageBox.Show("Kode Matpel Tidak Boleh Sama", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Call addEditMode()
                End If
                Call connection()
                Cmd = New SqlClient.SqlCommand("select niy from pengajar where niy ='" & niyCb.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                If Rd.HasRows Then
                    Call connection()
                    Cmd = New SqlClient.SqlCommand("insert into mataPelajaran values('" & kodeMatpelTb.Text & "','" & namaMatpelTb.Text & "','" & niyCb.Text & "','" & namaPengajarTb.Text & "')", Conn)
                    Rd = Cmd.ExecuteReader
                    Call connection()
                    MessageBox.Show("Berhasil Menambah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Call clear()
                    Call addEditMode()
                    Call dataGridReload()
                Else
                    MessageBox.Show("Niy Tidak Sesuai", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Call addEditMode()
                End If
            End If
        End If
        If edit = True Then
            Call connection()
            Cmd = New SqlClient.SqlCommand("update mataPelajaran set kodeMatpel='" & kodeMatpelTb.Text & "',namaMatpel='" & namaMatpelTb.Text & "',niy='" & niyCb.Text & "',namaPengajar='" & namaPengajarTb.Text & "' where kodeMatpel='" & kodeMatpelTb.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            MessageBox.Show("Berhasil Mengubah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Call closeAEM()
            Call clear()
            Call dataGridReload()

        End If
    End Sub

    ' EXIT '
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        add = False
        edit = False
        Call closeAEM()
        Call start()
    End Sub
    '  CANCEL'
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Call clear()
    End Sub

  
End Class