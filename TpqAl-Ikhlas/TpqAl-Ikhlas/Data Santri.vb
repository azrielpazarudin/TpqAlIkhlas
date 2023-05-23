Public Class Data_santri
    Sub addEditMode()
        nisnTb.Enabled = True
        namaSantriTb.Enabled = True
        jenisKelaminCb.Enabled = True
        kodeKelasCb.Enabled = True
        alamatTb.Enabled = True
        kataSandiTb.Enabled = True
        noHpTb.Enabled = True
        namaOrtuTb.Enabled = True
        noHpOrtuTb.Enabled = True
        saveBtn.Enabled = True
        cancelBtn.Enabled = True
        addBtn.Enabled = False
        editBtn.Enabled = False
        deleteBtn.Enabled = False
    End Sub
    Sub clearTb()
        nisnTb.Text = ""
        namaSantriTb.Text = ""
        jenisKelaminCb.Text = ""
        kodeKelasCb.Text = ""
        namaKelasTb.Text = ""
        namaUserTb.Text = ""
        alamatTb.Text = ""
        kataSandiTb.Text = ""
        noHpTb.Text = ""
        namaOrtuTb.Text = ""
        noHpOrtuTb.Text = ""
    End Sub
    Sub closAEM()
        addBtn.Enabled = True
        saveBtn.Enabled = False
        cancelBtn.Enabled = False
        editBtn.Enabled = True
        deleteBtn.Enabled = True
        exitBtn.Enabled = True

        nisnTb.Enabled = False
        namaSantriTb.Enabled = False
        jenisKelaminCb.Enabled = False
        kodeKelasCb.Enabled = False
        namaKelasTb.Enabled = False
        namaUserTb.Enabled = False
        alamatTb.Enabled = False
        kataSandiTb.Enabled = False
        noHpTb.Enabled = False
        namaOrtuTb.Enabled = False
        noHpOrtuTb.Enabled = False
    End Sub
    ' RELOAD DATA GRID (ADMIN)
    Sub dataGridReload()
        Call connection()
        Da = New SqlClient.SqlDataAdapter("Select * from santri", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "santri")
        DataGridView1.DataSource = Ds.Tables("santri")
    End Sub
    Private Sub Data_santri_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        userNameLabel.Text = Login.userNameBuffer.Text
        Call connection()
        Da = New SqlClient.SqlDataAdapter("select status from akun where namaUser='" & userNameLabel.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "akun")
        statusLabel.Text = Ds.Tables(0).Rows(0).Item("status").ToString()
        If statusLabel.Text = "admin" Then
            addBtn.Enabled = True
            saveBtn.Enabled = False
            cancelBtn.Enabled = False
            editBtn.Enabled = True
            deleteBtn.Enabled = True
            exitBtn.Enabled = True
            kodeKelasCb.Text = ""
            nisnTb.Enabled = False
            namaSantriTb.Enabled = False
            jenisKelaminCb.Enabled = False
            kodeKelasCb.Enabled = False
            namaKelasTb.Enabled = False
            namaUserTb.Enabled = False
            alamatTb.Enabled = False
            kataSandiTb.Enabled = False
            noHpTb.Enabled = False
            namaOrtuTb.Enabled = False
            noHpOrtuTb.Enabled = False
           
        Else
            nisnTb.Enabled = False
            namaSantriTb.Enabled = False
            jenisKelaminCb.Enabled = False
            kodeKelasCb.Enabled = False
            namaKelasTb.Enabled = False
            namaUserTb.Enabled = False
            alamatTb.Enabled = False
            kataSandiTb.Enabled = False
            noHpTb.Enabled = False
            namaOrtuTb.Enabled = False
            noHpOrtuTb.Enabled = False
            addBtn.Enabled = False
            saveBtn.Enabled = False
            cancelBtn.Enabled = False
            editBtn.Enabled = False
            deleteBtn.Enabled = False
            exitBtn.Enabled = False
        End If
    End Sub

    Private Sub Data_santri_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TpqAlikhlasDataSet5.kelas' table. You can move, or remove it, as needed.
        Me.KelasTableAdapter.Fill(Me.TpqAlikhlasDataSet5.kelas)
        Me.SantriTableAdapter.Fill(Me.TpqAlikhlasDataSet3.santri)
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
            End
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

    Private Sub dataSantriBtn_Click(sender As Object, e As EventArgs) Handles dataSantriBtn.Click
        MessageBox.Show("Anda Sedang Di Menu Jadwal Pelajaran", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub dataSantriLabel_Click(sender As Object, e As EventArgs) Handles dataSantriLabel.Click
        MessageBox.Show("Anda Sedang Di Menu Jadwal Pelajaran", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub dataSantriLogo_Click(sender As Object, e As EventArgs) Handles dataSantriLogo.Click
        MessageBox.Show("Anda Sedang Di Menu Jadwal Pelajaran", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

   
    'ADMIN MODE'
    'SEARCH'
    Private Sub searchTb_MousClick(sender As Object, e As EventArgs) Handles searchTb.MouseClick
        MessageBox.Show("Lakukan Pencarian Berdasarkan Nama", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchTb.TextChanged

        Call connection()
        Da = New SqlClient.SqlDataAdapter("Select *from santri where namaSantri LIKE '%" & searchTb.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "santri")
        DataGridView1.DataSource = Ds.Tables("santri")

    End Sub


    ' CRUD
    '   Add
    Dim add As Boolean = False
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        MessageBox.Show("Menambah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Call addEditMode()
        add = True
        namaUserTb.Enabled = True
    End Sub
    ' Edit
    Dim edit As Boolean = False
    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        MessageBox.Show("Mengubah Data (pilih data yang tersedia di table)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Call addEditMode()
        nisnTb.Enabled = False
        edit = True
    End Sub

    '   SAVE 
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim succes As Boolean = False
        If add = True Then
            If nisnTb.Text = "" Or namaSantriTb.Text = "" Or jenisKelaminCb.Text = "" Or kodeKelasCb.Text = "" Or namaKelasTb.Text = "" Or namaUserTb.Text = "" Or kataSandiTb.Text = "" Or alamatTb.Text = "" Or noHpTb.Text = "" Or namaOrtuTb.Text = "" Or noHpOrtuTb.Text = "" Then
                MessageBox.Show("Data Harus Lengkap", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Call addEditMode()
                succes = False
                namaUserTb.Enabled = True
            Else
                Call connection()
                Cmd = New SqlClient.SqlCommand("select nisn from santri where nisn = '" & nisnTb.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                If Rd.HasRows Then
                    MessageBox.Show("Nisn Tidak Boleh Sama", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Call addEditMode()
                    succes = False
                    namaUserTb.Enabled = True
                Else
                    succes = True
                End If
                Call connection()
                Cmd = New SqlClient.SqlCommand("select namaUser from santri where namaUser = '" & namaUserTb.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                If Rd.HasRows Then
                    MessageBox.Show("Nama User Tidak Boleh Sama", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Call addEditMode()
                    succes = False
                    namaUserTb.Enabled = True
                Else
                    succes = True
                End If
                If succes = True Then
                    Call connection()
                    Cmd = New SqlClient.SqlCommand("insert into akun values('" & namaUserTb.Text & "','" & kataSandiTb.Text & "','santri')", Conn)
                    Rd = Cmd.ExecuteReader
                    Call connection()
                    Cmd = New SqlClient.SqlCommand("insert into santri values('" & nisnTb.Text & "','" & namaSantriTb.Text & "','" & jenisKelaminCb.Text & "','" & kodeKelasCb.Text & "','" & namaKelasTb.Text & "','" & namaUserTb.Text & "','" & kataSandiTb.Text & "','" & alamatTb.Text & "','" & noHpTb.Text & "','" & namaOrtuTb.Text & "','" & noHpOrtuTb.Text & "')", Conn)
                    Rd = Cmd.ExecuteReader
                    Call connection()
                    Dim jumlahBuffer As String
                    Da = New SqlClient.SqlDataAdapter("select count(kodeKelas) as total from santri where kodeKelas='" & kodeKelasCb.Text & "'", Conn)
                    Ds = New DataSet
                    Da.Fill(Ds, "jumlah")
                    jumlahBuffer = Ds.Tables(0).Rows(0).Item("total").ToString()
                    Call connection()
                    Cmd = New SqlClient.SqlCommand("update kelas set jumlahSantri ='" & jumlahBuffer & "' where kodeKelas ='" & kodeKelasCb.Text & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    MessageBox.Show("berhasil Menambah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Call clearTb()
                    Call addEditMode()
                    Call dataGridReload()
                    add = False
                    succes = False

                End If

            End If
        End If
        If edit = True Then
            Call connection()
            Cmd = New SqlClient.SqlCommand("update santri set namaSantri='" & namaSantriTb.Text & "',jenisKelamin='" & jenisKelaminCb.Text & "',kodeKelas='" & kodeKelasCb.Text & "',namaKelas='" & namaKelasTb.Text & "',kataSandi='" & kataSandiTb.Text & "',noHp='" & noHpTb.Text & "',alamat='" & alamatTb.Text & "',namaOrtu='" & namaOrtuTb.Text & "',noHpOrtu='" & noHpOrtuTb.Text & "' where nisn='" & nisnTb.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Call connection()
            Cmd = New SqlClient.SqlCommand("update akun set kataSandi='" & kataSandiTb.Text & "' where namaUser='" & namaUserTb.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            MessageBox.Show("Berhasil Merubah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Call clearTb()
            Call addEditMode()
            Call dataGridReload()
            add = False
            succes = False
        End If

    End Sub
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Call closAEM()
        Call clearTb()
    End Sub

    Private Sub kodeKelasCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kodeKelasCb.SelectedIndexChanged
        Call connection()
        Da = New SqlClient.SqlDataAdapter("select namaKelas from kelas where kodeKelas='" & kodeKelasCb.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "kelas")
        namaKelasTb.Text = Ds.Tables(0).Rows(0).Item("namaKelas").ToString()
    End Sub
    '   Cancel
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Call clearTb()
    End Sub
  
    'DELETE
    Dim delete As Boolean = False
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        MessageBox.Show("Menghapus Data (pilih data yang tersedia di table)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        addBtn.Enabled = False
        editBtn.Enabled = False
        delete = True
    End Sub
    ' PILIH DATA DI DATA GRID

    Private Sub dataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            nisnTb.Text = row.Cells(0).Value.ToString()
            namaSantriTb.Text = row.Cells(1).Value.ToString()
            jenisKelaminCb.Text = row.Cells(2).Value.ToString()
            kodeKelasCb.Text = row.Cells(3).Value.ToString()
            namaKelasTb.Text = row.Cells(4).Value.ToString()
            namaUserTb.Text = row.Cells(5).Value.ToString()
            kataSandiTb.Text = row.Cells(6).Value.ToString()
            alamatTb.Text = row.Cells(7).Value.ToString()
            noHpTb.Text = row.Cells(8).Value.ToString()
            namaOrtuTb.Text = row.Cells(9).Value.ToString()
            noHpOrtuTb.Text = row.Cells(10).Value.ToString()
          
            If delete = True Then
                Dim Dr As DialogResult = MessageBox.Show("Apakah Anda Yakin Untuk Menghapus Data Tersebut?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                If Dr = Windows.Forms.DialogResult.Yes Then
                    nisnTb.Text = row.Cells(0).Value.ToString()
                    Call connection()
                    Cmd = New SqlClient.SqlCommand("delete from santri where nisn = '" & nisnTb.Text & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    Call connection()
                    Cmd = New SqlClient.SqlCommand("delete from akun where namaUser = '" & namaUserTb.Text & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    Dim jumlahBuffer As String
                    Call connection()
                    Da = New SqlClient.SqlDataAdapter("select count(kodeKelas) as total from santri where kodeKelas='" & kodeKelasCb.Text & "'", Conn)
                    Ds = New DataSet
                    Da.Fill(Ds, "jumlah")
                    jumlahBuffer = Ds.Tables(0).Rows(0).Item("total").ToString()
                    Call connection()
                    Cmd = New SqlClient.SqlCommand("update kelas set jumlahSantri ='" & jumlahBuffer & "' where kodeKelas ='" & kodeKelasCb.Text & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Call clearTb()
                    delete = False
                    Call dataGridReload()

                End If

            End If

        End If
    End Sub

End Class