Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score As Integer = txt1.Text
        Dim message As String

        Select Case score
            Case 80 To 100
                message = "Your grade is between 80-100 and your pointer in 4.00"
            Case 75 To 79
                message = "Your grade is between 79-75 and your pointer in 3.67"
            Case 70 To 74
                message = "Your grade is between 74-70 and your pointer is 3.33"
            Case 65 To 69
                message = "Your grade is between 69-65 and your pointer is 3.00"
            Case 60 To 64
                message = "Your grade is between 64-60 and your pointer is 2.67"
            Case 55 To 59
                message = "Your grade is between 59-55 and your pointer is 2.33"
            Case 50 To 54
                message = "Your grade is between 54-50 and your pointer is 2.00"
            Case 47 To 49
                message = "Your grade is between 49-47 and your pointer is 1.67"
            Case 44 To 46
                message = "Your grade is between 46-44 and your pointer is 1.33"
            Case 40 To 43
                message = "Your grade is between 43-40 and your pointer is 1.00"
            Case 30 To 39
                message = "Your grade is between 39-30 and your pointer 0.67"
            Case 20 To 29
                message = "Your grade is between 29-20 and your pointer 0.33"
            Case 0 To 19
                message = "Your grade is between 19-0 and your pointer 0.00"

        End Select
        MessageBox.Show(message, "Case Statement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
End Class
