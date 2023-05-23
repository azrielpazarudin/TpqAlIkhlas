Public Class informasi_akun

    Private Sub informasi_akun_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        If Home.statusLabel.Text = "santri" Then
            dataIndex0.Text = "NISN"
            dataIndex1.Text = "Nama"
            dataIndex2.Text = "Jenis Kelamin"
            dataIndex3.Text = "Kode Kelas"
            dataIndex4.Text = "Nama Kelas"
            dataIndex5.Text = "Nama User"
            dataIndex6.Text = "Kata Sandi"
            dataIndex7.Text = "Alamat"
            dataIndex8.Text = "No Hp"
            dataIndex9.Text = "Nama Ortu"
            dataIndex10.Text = "No Hp Ortu"
            Call connection()
           
            ' Isi data index 0
            Da = New SqlClient.SqlDataAdapter("select nisn from santri where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "akun")
            dataIndex0Value.Text = ": " + Ds.Tables(0).Rows(0).Item("nisn").ToString()

            ' Isi data index 1
            Da = New SqlClient.SqlDataAdapter("select namaSantri from santri where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "akun")
            dataIndex1Value.Text = ": " + Ds.Tables(0).Rows(0).Item("namaSantri").ToString()

            ' Isi data index 2
            Da = New SqlClient.SqlDataAdapter("select jenisKelamin from santri where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "akun")
            dataIndex2Value.Text = ": " + Ds.Tables(0).Rows(0).Item("jenisKelamin").ToString()

            ' Isi data index 3
            Da = New SqlClient.SqlDataAdapter("select kodeKelas from santri where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "akun")
            dataIndex3Value.Text = ": " + Ds.Tables(0).Rows(0).Item("kodeKelas").ToString()

            ' Isi data index 4
            Da = New SqlClient.SqlDataAdapter("select namaKelas from santri where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "akun")
            dataIndex4Value.Text = ": " + Ds.Tables(0).Rows(0).Item("namaKelas").ToString()

            ' Isi data index 5
            Da = New SqlClient.SqlDataAdapter("select namaUser from santri where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "akun")
            dataIndex5Value.Text = ": " + Ds.Tables(0).Rows(0).Item("namaUser").ToString()

            ' Isi data index 6
            Da = New SqlClient.SqlDataAdapter("select kataSandi from santri where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "akun")
            dataIndex6Value.Text = ": " + Ds.Tables(0).Rows(0).Item("kataSandi").ToString()

            ' Isi data index 7
            Da = New SqlClient.SqlDataAdapter("select alamat from santri where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "akun")
            dataIndex7Value.Text = ": " + Ds.Tables(0).Rows(0).Item("alamat").ToString()

            ' Isi data index 8
            Da = New SqlClient.SqlDataAdapter("select noHp from santri where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "akun")
            dataIndex8Value.Text = ": " + Ds.Tables(0).Rows(0).Item("noHp").ToString()

            ' Isi data index 9
            Da = New SqlClient.SqlDataAdapter("select namaOrtu from santri where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "akun")
            dataIndex9Value.Text = ": " + Ds.Tables(0).Rows(0).Item("namaOrtu").ToString()

            ' Isi data index 10
            Da = New SqlClient.SqlDataAdapter("select noHpOrtu from santri where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "akun")
            dataIndex10Value.Text = ": " + Ds.Tables(0).Rows(0).Item("noHpOrtu").ToString()

        ElseIf Home.statusLabel.Text = "pengajar" Then
            dataIndex0.Text = ""
            dataIndex1.Text = ""
            dataIndex2.Text = "NIY"
            dataIndex3.Text = "Nama"
            dataIndex4.Text = "Alamat"
            dataIndex5.Text = "No Hp"
            dataIndex6.Text = "Nama User"
            dataIndex7.Text = "Kata Sandi"
            dataIndex8.Text = ""
            dataIndex9.Text = ""
            dataIndex10.Text = ""
            dataIndex0Value.Text = ""
            dataIndex1Value.Text = ""
            dataIndex8Value.Text = ""
            dataIndex9Value.Text = ""
            dataIndex10Value.Text = ""

            ' Isi data index 2
            Da = New SqlClient.SqlDataAdapter("select niy from pengajar where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "pengajar")
            dataIndex2Value.Text = ": " + Ds.Tables(0).Rows(0).Item("niy").ToString()

            ' Isi data index 3
            Da = New SqlClient.SqlDataAdapter("select namaPengajar from pengajar where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "pengajar")
            dataIndex3Value.Text = ": " + Ds.Tables(0).Rows(0).Item("namaPengajar").ToString()

            ' Isi data index 4
            Da = New SqlClient.SqlDataAdapter("select alamat from pengajar where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "pengajar")
            dataIndex4Value.Text = ": " + Ds.Tables(0).Rows(0).Item("alamat").ToString()

            ' Isi data index 5
            Da = New SqlClient.SqlDataAdapter("select noHp from pengajar where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "pengajar")
            dataIndex5Value.Text = ": " + Ds.Tables(0).Rows(0).Item("noHp").ToString()

            ' Isi data index 6
            Da = New SqlClient.SqlDataAdapter("select namaUser from pengajar where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "pengajar")
            dataIndex6Value.Text = ": " + Ds.Tables(0).Rows(0).Item("namaUser").ToString()

            ' Isi data index 7
            Da = New SqlClient.SqlDataAdapter("select kataSandi from pengajar where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "pengajar")
            dataIndex7Value.Text = ": " + Ds.Tables(0).Rows(0).Item("kataSandi").ToString()

        Else
            dataIndex0.Text = ""
            dataIndex1.Text = ""
            dataIndex2.Text = ""
            dataIndex3.Text = ""
            dataIndex4.Text = "Nama User"
            dataIndex5.Text = "Kata Sandi"
            dataIndex6.Text = ""
            dataIndex7.Text = ""
            dataIndex8.Text = ""
            dataIndex9.Text = ""
            dataIndex10.Text = ""
            dataIndex0Value.Text = ""
            dataIndex1Value.Text = ""
            dataIndex2Value.Text = ""
            dataIndex3Value.Text = ""
            dataIndex6Value.Text = ""
            dataIndex7Value.Text = ""
            dataIndex8Value.Text = ""
            dataIndex9Value.Text = ""
            dataIndex10Value.Text = ""

            ' Isi data index 4
            Da = New SqlClient.SqlDataAdapter("select namaUser from akun where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "admin")
            dataIndex4Value.Text = ": " + Ds.Tables(0).Rows(0).Item("namaUser").ToString()

            ' Isi data index 5
            Da = New SqlClient.SqlDataAdapter("select kataSandi from akun where namaUser='" & Home.userNameLabel.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds,"admin")
            dataIndex5Value.Text = ": " + Ds.Tables(0).Rows(0).Item("kataSandi").ToString()
        End If
    End Sub

    Private Sub homeLogo_Click(sender As Object, e As EventArgs) Handles homeLogo.Click
        Me.Hide()
        Home.Show()
    End Sub


End Class