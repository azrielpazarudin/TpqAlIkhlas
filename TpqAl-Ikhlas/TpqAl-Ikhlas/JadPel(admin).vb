Public Class JadPel_admin

    Private Sub JadPel_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TpqAlikhlasDataSet10.jadwalPelajaran' table. You can move, or remove it, as needed.
        Me.JadwalPelajaranTableAdapter.Fill(Me.TpqAlikhlasDataSet10.jadwalPelajaran)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Jadwal_Pelajaran.Show()

    End Sub

    Private Sub panelTop_Paint(sender As Object, e As PaintEventArgs) Handles panelTop.Paint

    End Sub
End Class