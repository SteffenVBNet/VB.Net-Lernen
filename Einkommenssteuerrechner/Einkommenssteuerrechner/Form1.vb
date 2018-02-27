Public Class Form1

    Private Sub TxtEinkommen_TextChanged(sender As Object, e As EventArgs) Handles TxtEinkommen.TextChanged

    End Sub

    Private Sub TxtAusgabe_TextChanged(sender As Object, e As EventArgs) Handles TxtAusgabe.TextChanged

    End Sub

    Private Sub CmdEInkommenssteuer_Click(sender As Object, e As EventArgs) Handles CmdEInkommenssteuer.Click
        Dim Gehalt As Double
        Dim Steuer(3) As Double
        Dim Ausgabe As Double

        Gehalt = TxtEinkommen.Text

        If Gehalt < 0 Then
            TxtAusgabe.Text = "Sie können kein negatives Gehalt eingeben"

        ElseIf Gehalt = 0 Then
            TxtAusgabe.Text = "Sie können kein Gehalt = 0 haben"

        ElseIf Gehalt <= 9000 Then
            TxtAusgabe.Text = "Im Grundfreibetrag"

        Else

            If Gehalt > 260533 Then
                Steuer(0) = Ueber260533(Gehalt)
                Gehalt = 260533

            End If

            If Gehalt > 54950 Then
                Steuer(1) = Bis260532(Gehalt)
                Gehalt = 54950

            End If

            If Gehalt > 13996 Then
                Steuer(2) = Bis54949(Gehalt)
                Gehalt = 13996
            End If

            If Gehalt > 9000 Then
                Steuer(3) = Bis13996(Gehalt)
                Gehalt = 9000
            End If

            'Zusammenrechen der Steuer
            For i = 0 To Steuer.Count - 1
                Ausgabe += Steuer(i)
            Next

            'Ausgabe & runden
            Ausgabe = Math.Round(Ausgabe, 2)
            TxtAusgabe.Text = Ausgabe

        End If



    End Sub

    Private Sub LblAusgabe1_Click(sender As Object, e As EventArgs) Handles LblAusgabe1.Click


    End Sub


    'Methoden

    '260k Methode
    Private Function Ueber260533(Gehalt) As Double
        Dim Rueckgabe As Double
        Gehalt = Gehalt - 260533
        Rueckgabe = Fix(Gehalt)
        'Die Größe „x“ ist das auf einen vollen Euro-Betrag abgerundete zu versteuernde Einkommen. 6Der sich ergebende Steuerbetrag ist auf den nächsten vollen Euro-Betrag abzurunden.
        Rueckgabe = 0.45 * Rueckgabe - 16437.7
        Return Rueckgabe
    End Function

    'von 54.950-260.532
    Private Function Bis260532(Gehalt)
        Dim Rueckgabe As Double
        Gehalt = Gehalt - 54950
        Rueckgabe = Fix(Gehalt)
        Rueckgabe = 0.42 * Rueckgabe - 8621.75
        Return Rueckgabe
    End Function

    'von 13.997-54.949
    Private Function Bis54949(Gehalt)
        Dim Rueckgabe As Double
        Gehalt = Gehalt - 13996
        'Die Größe „Rueckgabe“ ist ein Zehntausendstel des 13 996 Euro übersteigenden Teils des auf einen vollen Euro-Betrag abgerundeten zu versteuernden Einkommen
        Rueckgabe = Fix(Gehalt) / 10000
        'folgende Formel so verändert das die vorhährige angewand werden muss
        Rueckgabe = (220.13 * Rueckgabe + 2397) * Rueckgabe
        Return Rueckgabe
    End Function

    'von 9.001-13.996
    Private Function Bis13996(Gehalt)
        Dim Rueckgabe As Double
        Gehalt = Gehalt - 9000
        'Die Größe „Rueckgabe“ ist ein Zehntausendstel des den Grundfreibetrag übersteigenden Teils des auf einen vollen Euro-Betrag abgerundeten zu versteuernden Einkommens
        Rueckgabe = Fix(Gehalt) / 10000
        Rueckgabe = (997.8 * Rueckgabe + 1400) * Rueckgabe
        Return Rueckgabe
    End Function



End Class
