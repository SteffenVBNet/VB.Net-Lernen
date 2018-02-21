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
        Me.LblGehalt = New System.Windows.Forms.Label()
        Me.TxtGehaltEingabe = New System.Windows.Forms.TextBox()
        Me.LblAusgabe = New System.Windows.Forms.Label()
        Me.CmdBerechnen1 = New System.Windows.Forms.Button()
        Me.CmdBerechnen2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblGehalt
        '
        Me.LblGehalt.AutoSize = True
        Me.LblGehalt.Location = New System.Drawing.Point(18, 49)
        Me.LblGehalt.Name = "LblGehalt"
        Me.LblGehalt.Size = New System.Drawing.Size(38, 13)
        Me.LblGehalt.TabIndex = 0
        Me.LblGehalt.Text = "Gehalt"
        '
        'TxtGehaltEingabe
        '
        Me.TxtGehaltEingabe.Location = New System.Drawing.Point(21, 65)
        Me.TxtGehaltEingabe.Name = "TxtGehaltEingabe"
        Me.TxtGehaltEingabe.Size = New System.Drawing.Size(124, 20)
        Me.TxtGehaltEingabe.TabIndex = 1
        '
        'LblAusgabe
        '
        Me.LblAusgabe.AutoSize = True
        Me.LblAusgabe.Location = New System.Drawing.Point(151, 72)
        Me.LblAusgabe.Name = "LblAusgabe"
        Me.LblAusgabe.Size = New System.Drawing.Size(0, 13)
        Me.LblAusgabe.TabIndex = 2
        '
        'CmdBerechnen1
        '
        Me.CmdBerechnen1.Location = New System.Drawing.Point(21, 101)
        Me.CmdBerechnen1.Name = "CmdBerechnen1"
        Me.CmdBerechnen1.Size = New System.Drawing.Size(92, 23)
        Me.CmdBerechnen1.TabIndex = 3
        Me.CmdBerechnen1.Text = "Berechnen 1"
        Me.CmdBerechnen1.UseVisualStyleBackColor = True
        '
        'CmdBerechnen2
        '
        Me.CmdBerechnen2.Location = New System.Drawing.Point(119, 101)
        Me.CmdBerechnen2.Name = "CmdBerechnen2"
        Me.CmdBerechnen2.Size = New System.Drawing.Size(87, 23)
        Me.CmdBerechnen2.TabIndex = 4
        Me.CmdBerechnen2.Text = "Berechnen 2"
        Me.CmdBerechnen2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CmdBerechnen2)
        Me.Controls.Add(Me.CmdBerechnen1)
        Me.Controls.Add(Me.LblAusgabe)
        Me.Controls.Add(Me.TxtGehaltEingabe)
        Me.Controls.Add(Me.LblGehalt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblGehalt As Label
    Friend WithEvents TxtGehaltEingabe As TextBox
    Friend WithEvents LblAusgabe As Label
    Friend WithEvents CmdBerechnen1 As Button
    Friend WithEvents CmdBerechnen2 As Button
End Class
