Public Class Login
    Public Sub save()
        username.Text = ""
        password.Text = ""
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        loginBtn.FlatAppearance.CheckedBackColor = Color.Black
        loginBtn.FlatAppearance.BorderColor = Color.Black
        userNameBuffer.Visible = False
        userNameBuffer.Text = username.Text
        If saveDataIdCB.Checked = False Then
            Call save()
        End If
        username.Focus()
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

    Private Sub username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress
        If e.KeyChar = Chr(13) Then
            password.Focus()
        End If
    End Sub

    Private Sub password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If e.KeyChar = Chr(13) Then
            loginBtn.Focus()
        End If
    End Sub

    'focus and Hoverable
    Private Sub loginBtn_Got_Focus(sender As Object, e As EventArgs) Handles loginBtn.GotFocus
        loginBtnShape.BorderColor = Color.LimeGreen
        loginBtnShape.BorderWidth = 5

    End Sub

    Private Sub loginBtn_Mouse_Hover(sender As Object, e As EventArgs) Handles loginBtnShape.MouseHover
        loginBtnShape.BorderColor = Color.LimeGreen
        loginBtnShape.BorderWidth = 5
        Cursor = Cursors.Hand
    End Sub

    Private Sub loginBtn_Mouse_Leave(sender As Object, e As EventArgs) Handles loginBtn.MouseLeave
        loginBtnShape.BorderColor = Color.Black
        loginBtnShape.BorderWidth = 0
    End Sub

    Private Sub loginBtnShape_Mouse_Hover(sender As Object, e As EventArgs) Handles loginBtn.MouseHover
        loginBtnShape.BorderColor = Color.LimeGreen
        loginBtnShape.BorderWidth = 5
        Cursor = Cursors.Hand
    End Sub

    Private Sub loginBtnShape_Mouse_Leave(sender As Object, e As EventArgs) Handles loginBtn.MouseLeave
        loginBtnShape.BorderColor = Color.Black
        loginBtnShape.BorderWidth = 0
    End Sub

    Private Sub cancelBtn_Got_Focus(sender As Object, e As EventArgs) Handles cancelBtn.GotFocus
        cancelBtnShape.BorderColor = Color.LimeGreen
        cancelBtnShape.BorderWidth = 5

    End Sub

    Private Sub cancelBtn_Mouse_Hover(sender As Object, e As EventArgs) Handles cancelBtn.MouseHover
        cancelBtnShape.BorderColor = Color.LimeGreen
        cancelBtnShape.BorderWidth = 5
        Cursor = Cursors.Hand
    End Sub

    Private Sub cancelBtn_Mouse_Leave(sender As Object, e As EventArgs) Handles cancelBtnShape.MouseLeave
        cancelBtnShape.BorderColor = Color.Black
        cancelBtnShape.BorderWidth = 0
    End Sub

    Private Sub cancelBtnShape_Mouse_Hover(sender As Object, e As EventArgs) Handles cancelBtn.MouseHover
        cancelBtnShape.BorderColor = Color.LimeGreen
        cancelBtnShape.BorderWidth = 5
        Cursor = Cursors.Hand
    End Sub

    Private Sub cancelBtnShape_Mouse_Leave(sender As Object, e As EventArgs) Handles cancelBtn.MouseLeave
        loginBtnShape.BorderColor = Color.Black
        loginBtnShape.BorderWidth = 0
    End Sub

    'LOGIN METHOD
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Call connection()
        Cmd = New SqlClient.SqlCommand("Select namaUser,kataSandi from akun WHERE namaUser ='" & username.Text & "' and kataSandi = '" & password.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then

            MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Hide()
            Home.Show()
        Else

            MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            username.Clear()
            password.Clear()
            username.Focus()

        End If
    End Sub


    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        username.Clear()
        password.Clear()
        username.Focus()
    End Sub

    Private Sub Login_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

