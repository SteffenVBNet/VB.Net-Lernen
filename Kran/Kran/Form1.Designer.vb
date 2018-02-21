<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanFundament = New System.Windows.Forms.Panel()
        Me.PanSenkrechtesHauptelement = New System.Windows.Forms.Panel()
        Me.PanAusleger = New System.Windows.Forms.Panel()
        Me.PanHaken = New System.Windows.Forms.Panel()
        Me.CmdHakenAus = New System.Windows.Forms.Button()
        Me.CmdHakenEin = New System.Windows.Forms.Button()
        Me.CmdAuslegerAus = New System.Windows.Forms.Button()
        Me.CmdAuslegerEin = New System.Windows.Forms.Button()
        Me.CmdKranRechts = New System.Windows.Forms.Button()
        Me.TimHakenAus = New System.Windows.Forms.Timer(Me.components)
        Me.CmdKranLinks = New System.Windows.Forms.Button()
        Me.CmdKranHoch = New System.Windows.Forms.Button()
        Me.CmdKranRunter = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PanFundament
        '
        Me.PanFundament.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PanFundament.Location = New System.Drawing.Point(512, 428)
        Me.PanFundament.Name = "PanFundament"
        Me.PanFundament.Size = New System.Drawing.Size(74, 24)
        Me.PanFundament.TabIndex = 0
        '
        'PanSenkrechtesHauptelement
        '
        Me.PanSenkrechtesHauptelement.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanSenkrechtesHauptelement.Location = New System.Drawing.Point(539, 325)
        Me.PanSenkrechtesHauptelement.Name = "PanSenkrechtesHauptelement"
        Me.PanSenkrechtesHauptelement.Size = New System.Drawing.Size(23, 103)
        Me.PanSenkrechtesHauptelement.TabIndex = 1
        '
        'PanAusleger
        '
        Me.PanAusleger.BackColor = System.Drawing.SystemColors.Desktop
        Me.PanAusleger.Location = New System.Drawing.Point(458, 325)
        Me.PanAusleger.Name = "PanAusleger"
        Me.PanAusleger.Size = New System.Drawing.Size(81, 22)
        Me.PanAusleger.TabIndex = 2
        '
        'PanHaken
        '
        Me.PanHaken.BackColor = System.Drawing.SystemColors.Highlight
        Me.PanHaken.Location = New System.Drawing.Point(458, 347)
        Me.PanHaken.Name = "PanHaken"
        Me.PanHaken.Size = New System.Drawing.Size(21, 30)
        Me.PanHaken.TabIndex = 0
        '
        'CmdHakenAus
        '
        Me.CmdHakenAus.Location = New System.Drawing.Point(1038, 100)
        Me.CmdHakenAus.Name = "CmdHakenAus"
        Me.CmdHakenAus.Size = New System.Drawing.Size(93, 23)
        Me.CmdHakenAus.TabIndex = 3
        Me.CmdHakenAus.Text = "Haken aus"
        Me.CmdHakenAus.UseVisualStyleBackColor = True
        '
        'CmdHakenEin
        '
        Me.CmdHakenEin.Location = New System.Drawing.Point(1038, 129)
        Me.CmdHakenEin.Name = "CmdHakenEin"
        Me.CmdHakenEin.Size = New System.Drawing.Size(93, 23)
        Me.CmdHakenEin.TabIndex = 4
        Me.CmdHakenEin.Text = "Haken ein"
        Me.CmdHakenEin.UseVisualStyleBackColor = True
        '
        'CmdAuslegerAus
        '
        Me.CmdAuslegerAus.Location = New System.Drawing.Point(1038, 158)
        Me.CmdAuslegerAus.Name = "CmdAuslegerAus"
        Me.CmdAuslegerAus.Size = New System.Drawing.Size(93, 23)
        Me.CmdAuslegerAus.TabIndex = 5
        Me.CmdAuslegerAus.Text = "Ausleger aus"
        Me.CmdAuslegerAus.UseVisualStyleBackColor = True
        '
        'CmdAuslegerEin
        '
        Me.CmdAuslegerEin.Location = New System.Drawing.Point(1038, 187)
        Me.CmdAuslegerEin.Name = "CmdAuslegerEin"
        Me.CmdAuslegerEin.Size = New System.Drawing.Size(93, 23)
        Me.CmdAuslegerEin.TabIndex = 6
        Me.CmdAuslegerEin.Text = "Ausleger ein"
        Me.CmdAuslegerEin.UseVisualStyleBackColor = True
        '
        'CmdKranRechts
        '
        Me.CmdKranRechts.Location = New System.Drawing.Point(1038, 216)
        Me.CmdKranRechts.Name = "CmdKranRechts"
        Me.CmdKranRechts.Size = New System.Drawing.Size(93, 23)
        Me.CmdKranRechts.TabIndex = 7
        Me.CmdKranRechts.Text = "Kran rechts"
        Me.CmdKranRechts.UseVisualStyleBackColor = True
        '
        'TimHakenAus
        '
        '
        'CmdKranLinks
        '
        Me.CmdKranLinks.Location = New System.Drawing.Point(1038, 245)
        Me.CmdKranLinks.Name = "CmdKranLinks"
        Me.CmdKranLinks.Size = New System.Drawing.Size(93, 23)
        Me.CmdKranLinks.TabIndex = 8
        Me.CmdKranLinks.Text = "Kran links"
        Me.CmdKranLinks.UseVisualStyleBackColor = True
        '
        'CmdKranHoch
        '
        Me.CmdKranHoch.Location = New System.Drawing.Point(1038, 274)
        Me.CmdKranHoch.Name = "CmdKranHoch"
        Me.CmdKranHoch.Size = New System.Drawing.Size(93, 23)
        Me.CmdKranHoch.TabIndex = 9
        Me.CmdKranHoch.Text = "Kran Hoch"
        Me.CmdKranHoch.UseVisualStyleBackColor = True
        '
        'CmdKranRunter
        '
        Me.CmdKranRunter.Location = New System.Drawing.Point(1038, 303)
        Me.CmdKranRunter.Name = "CmdKranRunter"
        Me.CmdKranRunter.Size = New System.Drawing.Size(93, 23)
        Me.CmdKranRunter.TabIndex = 10
        Me.CmdKranRunter.Text = "Kran Runter"
        Me.CmdKranRunter.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(822, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 20)
        Me.TextBox1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(822, 161)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 20)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(822, 190)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(152, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(822, 219)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(152, 20)
        Me.TextBox4.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 635)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CmdKranRunter)
        Me.Controls.Add(Me.CmdKranHoch)
        Me.Controls.Add(Me.CmdKranLinks)
        Me.Controls.Add(Me.CmdKranRechts)
        Me.Controls.Add(Me.CmdAuslegerEin)
        Me.Controls.Add(Me.CmdAuslegerAus)
        Me.Controls.Add(Me.CmdHakenEin)
        Me.Controls.Add(Me.CmdHakenAus)
        Me.Controls.Add(Me.PanHaken)
        Me.Controls.Add(Me.PanAusleger)
        Me.Controls.Add(Me.PanSenkrechtesHauptelement)
        Me.Controls.Add(Me.PanFundament)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanFundament As Panel
    Friend WithEvents PanSenkrechtesHauptelement As Panel
    Friend WithEvents PanAusleger As Panel
    Friend WithEvents PanHaken As Panel
    Friend WithEvents CmdHakenAus As Button
    Friend WithEvents CmdHakenEin As Button
    Friend WithEvents CmdAuslegerAus As Button
    Friend WithEvents CmdAuslegerEin As Button
    Friend WithEvents CmdKranRechts As Button
    Friend WithEvents TimHakenAus As Timer
    Friend WithEvents CmdKranLinks As Button
    Friend WithEvents CmdKranHoch As Button
    Friend WithEvents CmdKranRunter As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
