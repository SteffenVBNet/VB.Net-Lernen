Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Me.Size = New Point(Me.Size.Width = 800, Me.Size.Height = 550)
        CmdHakenAus.Location = New Point(100, 50)
        CmdHakenEin.Location = New Point(100, 80)
        CmdAuslegerAus.Location = New Point(100, 110)
        CmdAuslegerEin.Location = New Point(100, 140)
        CmdKranRechts.Location = New Point(100, 170)
        CmdKranLinks.Location = New Point(100, 200)
        CmdKranHoch.Location = New Point(100, 230)
        CmdKranRunter.Location = New Point(100, 260)
        'CmdHakenEin.Location = New Point(CmdHakenEin.Location.X, CmdHakenEin.Location.Y)
        'CmdHakenAus.Location = New Point(CmdHakenAus.Location.X = 200, CmdHakenAus.Location.Y)
    End Sub

    Private Sub PanFunamen_Paint(sender As Object, e As PaintEventArgs) Handles PanFundament.Paint

        PanFundament.BackColor = Color.Black
        '   PanFundament.Location = New Point(512, 428)
        '  PanFundament.Size = New Point(74, 24)
        ' PanFundament.Location = New Point(PanFundament.Location.X = "200", PanFundament.Location.Y = "200")
        '  PanFundament.Location = New Point(PanFundament.Location.X = 512, PanFundament.Location.Y = 428)
        'PanFundament.Size = New Point(PanFundament.Size.Height = 24, PanFundament.Size.Width = 74)

    End Sub

    Private Sub PanHaken_Paint(sender As Object, e As PaintEventArgs) Handles PanHaken.Paint

        PanHaken.BackColor = Color.Green
        ' PanHaken.Location = New Point(458, 347)
        ' PanHaken.Size = New Point(21, 30)

    End Sub

    Private Sub PanAusleger_Paint(sender As Object, e As PaintEventArgs) Handles PanAusleger.Paint

        PanAusleger.BackColor = Color.Red
        'PanAusleger.Location = New Point(458, 325)
        'PanAusleger.Size = New Point(81, 22)


        'PanAusleger.Location = New Point(PanAusleger.Location.X = 458, PanAusleger.Location.Y = 325)
        ' PanAusleger.Size = New Point(PanAusleger.Size.Height = 22, PanAusleger.Size.Width = 81)

    End Sub

    Private Sub PanSenkrechtesHauptelement_Paint(sender As Object, e As PaintEventArgs) Handles PanSenkrechtesHauptelement.Paint

        PanSenkrechtesHauptelement.BackColor = Color.Blue
        '  PanSenkrechtesHauptelement.Location = New Point(539, 325)
        ' PanSenkrechtesHauptelement.Size = New Point(23, 103)

    End Sub

    Private Sub CmdHakenEin_Click(sender As Object, e As EventArgs) Handles CmdHakenEin.Click

        PanHaken.Height = PanHaken.Height - 10

    End Sub

    Private Sub CmdHakenAus_Click(sender As Object, e As EventArgs) Handles CmdHakenAus.Click

        PanHaken.Height = PanHaken.Height + 10

    End Sub

    Private Sub CmdAuslegerAus_Click(sender As Object, e As EventArgs) Handles CmdAuslegerAus.Click

        PanAusleger.Width = PanAusleger.Width + 10
        PanAusleger.Location = New Point(PanAusleger.Location.X - 10, PanAusleger.Location.Y)
        PanHaken.Location = New Point(PanHaken.Location.X - 10, PanHaken.Location.Y)

    End Sub

    Private Sub CmdAuslegerEin_Click(sender As Object, e As EventArgs) Handles CmdAuslegerEin.Click

        PanAusleger.Width = PanAusleger.Width - 10
        PanAusleger.Location = New Point(PanAusleger.Location.X + 10, PanAusleger.Location.Y)
        PanHaken.Location = New Point(PanHaken.Location.X + 10, PanHaken.Location.Y)

    End Sub

    Private Sub CmdKranRechts_Click(sender As Object, e As EventArgs) Handles CmdKranRechts.Click
        PanAusleger.Location = New Point(PanAusleger.Location.X + 10, PanAusleger.Location.Y)
        PanFundament.Location = New Point(PanFundament.Location.X + 10, PanFundament.Location.Y)
        PanHaken.Location = New Point(PanHaken.Location.X + 10, PanHaken.Location.Y)
        PanSenkrechtesHauptelement.Location = New Point(PanSenkrechtesHauptelement.Location.X + 10, PanSenkrechtesHauptelement.Location.Y)
    End Sub

    Private Sub CmdKranLinks_Click(sender As Object, e As EventArgs) Handles CmdKranLinks.Click
        PanAusleger.Location = New Point(PanAusleger.Location.X - 10, PanAusleger.Location.Y)
        PanFundament.Location = New Point(PanFundament.Location.X - 10, PanFundament.Location.Y)
        PanHaken.Location = New Point(PanHaken.Location.X - 10, PanHaken.Location.Y)
        PanSenkrechtesHauptelement.Location = New Point(PanSenkrechtesHauptelement.Location.X - 10, PanSenkrechtesHauptelement.Location.Y)
    End Sub

    Private Sub TimHakenAus_Tick(sender As Object, e As EventArgs) Handles TimHakenAus.Tick
        'PanHaken.Size = New Point(PanHaken.Size.Height + 20, PanHaken.Width)
        PanHaken.Size = New Point(PanHaken.Size.Height + 10, PanHaken.Width)
    End Sub

    Private Sub CmdKranHoch_Click(sender As Object, e As EventArgs) Handles CmdKranHoch.Click

        PanAusleger.Location = New Point(PanAusleger.Location.X, PanAusleger.Location.Y - 10)
        PanFundament.Location = New Point(PanFundament.Location.X, PanFundament.Location.Y - 10)
        PanHaken.Location = New Point(PanHaken.Location.X, PanHaken.Location.Y - 10)
        PanSenkrechtesHauptelement.Location = New Point(PanSenkrechtesHauptelement.Location.X, PanSenkrechtesHauptelement.Location.Y - 10)

    End Sub

    Private Sub CmdKranRunter_Click(sender As Object, e As EventArgs) Handles CmdKranRunter.Click

        PanAusleger.Location = New Point(PanAusleger.Location.X, PanAusleger.Location.Y + 10)
        PanFundament.Location = New Point(PanFundament.Location.X, PanFundament.Location.Y + 10)
        PanHaken.Location = New Point(PanHaken.Location.X, PanHaken.Location.Y + 10)
        PanSenkrechtesHauptelement.Location = New Point(PanSenkrechtesHauptelement.Location.X, PanSenkrechtesHauptelement.Location.Y + 10)

    End Sub
End Class
