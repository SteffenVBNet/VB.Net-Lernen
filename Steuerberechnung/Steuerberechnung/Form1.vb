Public Class Form1
    'Macht Nix Nur Ausgabe
    Private Sub LblGehalt_Click(sender As Object, e As EventArgs) Handles LblGehalt.Click

    End Sub
    'Ausgabe des Steuerwertes
    Private Sub LblAusgabe_Click(sender As Object, e As EventArgs) Handles LblAusgabe.Click

    End Sub
    'Eingabe des gehaltes
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtGehaltEingabe.TextChanged

    End Sub
    'Hauptfeld
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Select Case
    Private Sub CmdBerechnen2_Click(sender As Object, e As EventArgs) Handles CmdBerechnen2.Click
        Dim X As Integer
        X = TxtGehaltEingabe.Text
        Select Case X
            Case Is < 0
                LblAusgabe.Text = "Falsche Eingabe"
            Case 0 To 12000
                LblAusgabe.Text = "bis 12k"
            Case 12001 To 20000
                LblAusgabe.Text = "bis 20k"
            Case 20001 To 30000
                LblAusgabe.Text = "bis 30k"
            Case Is > 30000
                LblAusgabe.Text = "Über 30k"
        End Select
    End Sub
    'if Else berechnen
    Private Sub CmdBerechnen1_Click(sender As Object, e As EventArgs) Handles CmdBerechnen1.Click

        If (TxtGehaltEingabe.Text <= 0) Then
            LblAusgabe.Text = "Falsche Eingabe"
        ElseIf (TxtGehaltEingabe.Text <= 12000) Then
            Dim X As Integer = 0
            X = TxtGehaltEingabe.Text
            X = X * 0.12
            LblAusgabe.Text = X
        ElseIf (TxtGehaltEingabe.Text > 12000 And TxtGehaltEingabe.Text <= 20000) Then
            Dim X As Integer = 0
            X = TxtGehaltEingabe.Text
            X = X * 0.15
            LblAusgabe.Text = X
        ElseIf (TxtGehaltEingabe.Text > 20000 And TxtGehaltEingabe.Text <= 30000) Then
            Dim X As Integer = 0
            X = TxtGehaltEingabe.Text
            X = X * 0.2
            LblAusgabe.Text = X
        ElseIf (TxtGehaltEingabe.Text < 30000) Then
            Dim X As Integer = 0
            X = TxtGehaltEingabe.Text
            X = X * 0.25
            LblAusgabe.Text = X
        End If

    End Sub

End Class
