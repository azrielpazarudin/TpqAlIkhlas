Public Class Kegiatan_Belajar_Santri
    Dim sourceBuffer As String
    Dim myBool As Boolean = True
    Sub hideKBMdetail()
        kelasContainerShape.Visible = False
        kelasPictureBox.Visible = False
        namaSantri.Visible = False
        kelasLabel.Visible = False
        MataPelajaranLabel.Visible = False
        namaGuruLabel.Visible = False
        DataGridView1.Visible = False
        daftarMateriLabel.Visible = False
        bukaMaterBtn.Visible = False
        backButton.Visible = False
        pilihMapelCB.Visible = True
        pilihMapelLabel.Visible = True
    End Sub

    Sub showKBMdetail()
        kelasContainerShape.Visible = True
        kelasPictureBox.Visible = True
        namaSantri.Visible = True
        kelasLabel.Visible = True
        MataPelajaranLabel.Visible = True
        namaGuruLabel.Visible = True
        DataGridView1.Visible = True
        pilihMapelCB.Visible = False
        pilihMapelLabel.Visible = False
        daftarMateriLabel.Visible = True
        bukaMaterBtn.Visible = True
        bukaMaterBtn.Enabled = False
        backButton.Visible = True
    End Sub
    


    Private Sub Kegiatan_Belajar_Santri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TpqAlikhlasDataSet6.materi' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'TpqAlikhlasDataSet7.mataPelajaran' table. You can move, or remove it, as needed.
        Me.MataPelajaranTableAdapter.Fill(Me.TpqAlikhlasDataSet7.mataPelajaran)

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
            Call hideKBMDetail()
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

    ' ACTION


    Private Sub pilihMapelCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pilihMapelCB.SelectedIndexChanged
        Call showKBMdetail()
        Call connection()
        Da = New SqlClient.SqlDataAdapter("select namaSantri from santri where namaUser = '" & userNameLabel.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "santri")
        namaSantri.Text = "Nama                : " + Ds.Tables(0).Rows(0).Item("namaSantri").ToString()
        Da = New SqlClient.SqlDataAdapter("select namaKelas from santri where namaUser ='" & userNameLabel.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "kelas")
        kelasLabel.Text = "Kelas                 : " + Ds.Tables(0).Rows(0).Item("namaKelas").ToString()
        MataPelajaranLabel.Text = "Mata Pelajaran : " + pilihMapelCB.Text()
        If pilihMapelCB.Text() = "Al-Qur'an & Hadits" Then
            pilihMapelCB.Text() = "Al-Qur''an & Hadits"
        End If
        Da = New SqlClient.SqlDataAdapter("select pengajar.namaPengajar from pengajar inner join mataPelajaran on mataPelajaran.niy = pengajar.niy where mataPelajaran.namaMatpel ='" & pilihMapelCB.Text() & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pengajar")
        namaGuruLabel.Text = "Pengajar            : " + Ds.Tables(0).Rows(0).Item("namaPengajar").ToString()
        Call dataGridReaload()
        myBool = False
    End Sub
    Sub dataGridReaload()
        Call connection()
        Da = New SqlClient.SqlDataAdapter("Select judulMateri,filePath from materi inner join kegiatanBelajar on materi.kodeKBM = kegiatanBelajar.kodeKBM inner join mataPelajaran on kegiatanBelajar.kodeMatpel = mataPelajaran.kodeMatpel where mataPelajaran.namaMatpel='" & pilihMapelCB.Text() & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "materi")
        DataGridView1.DataSource = Ds.Tables("materi")
    End Sub

    ' PILIH  MATERI
    Private Sub dataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)
            sourceBuffer = row.Cells(1).Value.ToString
            If sourceBuffer = "" Then
                bukaMaterBtn.Enabled = False
            Else
                bukaMaterBtn.Enabled = True
            End If
        End If
    End Sub
    'BUKA MATERI
    Private Sub bukaMaterBtn_Click(sender As Object, e As EventArgs) Handles bukaMaterBtn.Click
        Dim oWord As Microsoft.Office.Interop.Word.Application
        Dim doc As Microsoft.Office.Interop.Word.Document
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        doc = oWord.Documents.Add(sourceBuffer)
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Call hideKBMdetail()
    End Sub
End Class