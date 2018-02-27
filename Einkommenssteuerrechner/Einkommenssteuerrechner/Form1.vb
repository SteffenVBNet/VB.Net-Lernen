Public Class Form1

    Private Sub TxtEinkommen_TextChanged(sender As Object, e As EventArgs) Handles TxtEinkommen.TextChanged

    End Sub

    Private Sub TxtAusgabe_TextChanged(sender As Object, e As EventArgs) Handles TxtAusgabe.TextChanged

    End Sub

    Private Sub CmdEInkommenssteuer_Click(sender As Object, e As EventArgs) Handles CmdEInkommenssteuer.Click
        Dim Gehalt As Double
        Dim Ausgabe As Double
        Gehalt = TxtEinkommen.Text

        If Gehalt > 260533 Then
            Gehalt = Gehalt - 260533
            Ausgabe = Ueber260533(Gehalt)
            TxtAusgabe.Text = Ausgabe

        ElseIf Gehalt > 54950 Then

        ElseIf Gehalt > 13996 Then

        ElseIf Gehalt > 9000 Then
            Gehalt = Gehalt - 9000
            Ausgabe = Ueber9000(Gehalt)
            TxtAusgabe.Text = Ausgabe

        ElseIf Gehalt <= 9000 Then
            TxtAusgabe.Text = "Im Grundfreibetrag"

        ElseIf Gehalt <= 0 Then
            TxtAusgabe.Text = "Sie können kein negatives Gehalt eingeben"

        End If

    End Sub

    Private Sub LblAusgabe1_Click(sender As Object, e As EventArgs) Handles LblAusgabe1.Click

    End Sub


    'Methoden

    '260k Methode
    Private Function Ueber260533(Gehalt) As Double
        Dim Rueckgabe As Double
        Rueckgabe = Fix(Gehalt)
        'Die Größe „x“ ist das auf einen vollen Euro-Betrag abgerundete zu versteuernde Einkommen. 6Der sich ergebende Steuerbetrag ist auf den nächsten vollen Euro-Betrag abzurunden.
        Rueckgabe = 0.45 * Rueckgabe - 16437.7
        Return Rueckgabe
    End Function

    'von 54.950-260.532
    Private Function Bis260532(Gehalt)
        Dim Rueckgabe As Double
        Rueckgabe = Fix(Gehalt)
        Rueckgabe = 0.42 * Rueckgabe - 8621.75
        Return Rueckgabe
    End Function

    'von 13.997-54.949
    Private Function Bis54949(Gehalt)
        Dim Rueckgabe As Double
        'Die Größe „Rueckgabe“ ist ein Zehntausendstel des 13 996 Euro übersteigenden Teils des auf einen vollen Euro-Betrag abgerundeten zu versteuernden Einkommen
        Rueckgabe = Fix(Gehalt) / 10000
        Rueckgabe = (220.13 * Rueckgabe + 2397) * Rueckgabe + 948.49
        Return Rueckgabe
    End Function

    'von 9.001-13.996
    Private Function Bis13996(Gehalt)
        Dim Rueckgabe As Double
        'Die Größe „Rueckgabe“ ist ein Zehntausendstel des den Grundfreibetrag übersteigenden Teils des auf einen vollen Euro-Betrag abgerundeten zu versteuernden Einkommens
        Rueckgabe = Fix(Gehalt) / 10000
        Rueckgabe = (997.8 * Rueckgabe + 1400) * Rueckgabe
        Return Rueckgabe
    End Function



End Class
