Public Class Form1
    Private Sub TxtBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtBox1.TextChanged

    End Sub

    Private Sub LblAusgabe_Click(sender As Object, e As EventArgs) Handles LblAusgabe.Click

    End Sub

    Private Sub CmdAusgabe_Click(sender As Object, e As EventArgs) Handles CmdAusgabe.Click
        LblAusgabe.Text = "Sie haben '" & TxtBox1.Text & "' eingegeben"
    End Sub

    Private Sub CmdRechnen1_Click(sender As Object, e As EventArgs) Handles CmdRechnen1.Click
        LblAusgabe.Text = TxtBox1.Text * 2
    End Sub

    Private Sub CmdRechnen2_Click(sender As Object, e As EventArgs) Handles CmdRechnen2.Click
        LblAusgabe.Text = Convert.ToDouble(TxtBox1.Text) * 2
    End Sub

    Private Sub NumHochRunter_ValueChanged(sender As Object, e As EventArgs) Handles NumHochRunter.ValueChanged
        'das ist nur ein test
        LblAusgabe.Text = NumHochRunter.Value
    End Sub

End Class
