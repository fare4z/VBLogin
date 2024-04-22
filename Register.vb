Public Class Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim username As String = txtUsername.Text.ToString.Trim
        Dim password As String = txtPassword.Text.ToString.Trim
        Dim fullname As String = txtFullname.Text.ToString.ToUpper

        Try
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "INSERT INTO tblUser
                           ([username] , [password] , [fullname]) Values 
                            ('" & username & "','" & password & "','" & fullname & "' )"

            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form1.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



    End Sub
End Class