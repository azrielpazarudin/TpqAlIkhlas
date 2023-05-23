Public Class Jadpel_Santri

    Private Sub Jadpel_Santri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TpqAlikhlasDataSet11.jadwalPelajaran' table. You can move, or remove it, as needed.
        Me.JadwalPelajaranTableAdapter.Fill(Me.TpqAlikhlasDataSet11.jadwalPelajaran)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Mata_Pelajaran.Show()
    End Sub
End Class