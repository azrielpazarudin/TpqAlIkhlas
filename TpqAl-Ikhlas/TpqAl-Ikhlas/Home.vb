Public Class Home

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        userNameLabel.Text = Login.userNameBuffer.Text
        Call connection()
        Da = New SqlClient.SqlDataAdapter("select status from akun where namaUser='" & userNameLabel.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "akun")
        statusLabel.Text = Ds.Tables(0).Rows(0).Item("status").ToString()
        Da = New SqlClient.SqlDataAdapter("select COUNT(niy) as total from pengajar", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pengajar")
        totalPengajarLabel.Text = Ds.Tables(0).Rows(0).Item("total").ToString()
        Da = New SqlClient.SqlDataAdapter("select COUNT(nisn) as total from santri", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "santri")
        totalSantriLabel.Text = Ds.Tables(0).Rows(0).Item("total").ToString()
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
    ' Informasi Akun
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles informasiAkunPB.Click      
            Me.Hide()
            informasi_akun.Show()
    End Sub

    'HOME
    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        MessageBox.Show("Anda Sedang Di Menu Home", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub homeLabel_Click(sender As Object, e As EventArgs) Handles homeLabel.Click
        MessageBox.Show("Anda Sedang Di Menu Home", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub homeLogo_Click(sender As Object, e As EventArgs) Handles homeLogo.Click
        MessageBox.Show("Anda Sedang Di Menu Home", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
If statusLabel.Text = "santri" Then
            Me.Hide()
            Kegiatan_Belajar_Santri.Show()
        ElseIf statusLabel.Text = "pengajar" Then
            Me.Hide()
            Kegiatan_Belajar.Show()
        Else
            Dim dr As DialogResult = MessageBox.Show("Silahkan Login Sebagai Pengajar Atau Santri", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If dr = Windows.Forms.DialogResult.Yes Then
                Me.Hide()
                Login.Show()
            End If
        End If
      
    End Sub

    Private Sub kegiatanBelajarLabel_Click(sender As Object, e As EventArgs) Handles kegiatanBelajarLabel.Click
        If statusLabel.Text = "santri" Then
            Me.Hide()
            Kegiatan_Belajar_Santri.Show()
        ElseIf statusLabel.Text = "pengajar" Then
            Me.Hide()
            Kegiatan_Belajar.Show()
        Else
            Dim dr As DialogResult = MessageBox.Show("Silahkan Login Sebagai Pengajar Atau Santri", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If dr = Windows.Forms.DialogResult.Yes Then
                Me.Hide()
                Login.Show()
            End If
        End If
    End Sub

    Private Sub kegiatanBelajarLogo_Click(sender As Object, e As EventArgs) Handles kegiatanBelajarLogo.Click
        If statusLabel.Text = "santri" Then
            Me.Hide()
            Kegiatan_Belajar_Santri.Show()
        ElseIf statusLabel.Text = "pengajar" Then
            Me.Hide()
            Kegiatan_Belajar.Show()
        Else
            Dim dr As DialogResult = MessageBox.Show("Silahkan Login Sebagai Pengajar Atau Santri", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If dr = Windows.Forms.DialogResult.Yes Then
                Me.Hide()
                Login.Show()
            End If
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
  
   
    Private Sub Home_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    
End Class
