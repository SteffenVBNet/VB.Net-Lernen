﻿Public Class Form1

    Private Sub TxtEinkommen_TextChanged(sender As Object, e As EventArgs) Handles TxtEinkommen.TextChanged

    End Sub

    Private Sub TxtAusgabe_TextChanged(sender As Object, e As EventArgs) Handles TxtAusgabe.TextChanged

    End Sub

    Private Sub CmdEInkommenssteuer_Click(sender As Object, e As EventArgs) Handles CmdEInkommenssteuer.Click
        Dim Gehalt As Double
        Dim Ausgabe As Double
        Gehalt = TxtEinkommen.Text

        If Gehalt > 260533 Then

            Ausgabe = Ueber260533(Gehalt)
            TxtAusgabe.Text = Ausgabe

        ElseIf Gehalt > 54950 Then

        ElseIf Gehalt > 13996 Then

        ElseIf Gehalt > 9000 Then
            Ausgabe = Ueber9000(Gehalt)
        ElseIf Gehalt <= 9000 Then
            TxtAusgabe.Text = "Im Grundfreibetrag"

        ElseIf Gehalt <= 0 Then
            TxtAusgabe.Text = "Sie können kein negatives Gehalt eingeben"

        End If

    End Sub

    Private Sub LblAusgabe1_Click(sender As Object, e As EventArgs) Handles LblAusgabe1.Click

    End Sub

    Private Function Ueber9000(Gehalt) As Double
        Dim Rueckgabe As Double
        Rueckgabe = Gehalt - 9000
        Rueckgabe = Fix(Gehalt)

        Return 0
    End Function
    Private Function Ueber260533(Gehalt) As Double
        Dim Rueckgabe As Double
        Rueckgabe = Gehalt - 260533
        Rueckgabe = Fix(Rueckgabe)
        'Die Größe „x“ ist das auf einen vollen Euro-Betrag abgerundete zu versteuernde Einkommen. 6Der sich ergebende Steuerbetrag ist auf den nächsten vollen Euro-Betrag abzurunden.
        Rueckgabe = 0.45 * Rueckgabe - 16437.7
        Return Rueckgabe
    End Function

End Class
