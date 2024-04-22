Public Class Form1
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Register.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.ToString.Trim
        Dim password As String = txtPassword.Text.ToString.Trim

        Try
            con.Open()
            cmd.CommandText = "SELECT * FROM tblUser where 
                                [username] = '" & username & "' 
                                and [password] = '" & password & "'"
            cmd.Connection = con
            dataReader = cmd.ExecuteReader()

            If (dataReader.Read() = True) Then
                Dim fullname As String = dataReader("fullname").ToString()
                MessageBox.Show("Welcome " + fullname, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Incorrect username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
