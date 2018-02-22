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
        Me.TxtEinkommen = New System.Windows.Forms.TextBox()
        Me.LblAusgabe1 = New System.Windows.Forms.Label()
        Me.CmdEInkommenssteuer = New System.Windows.Forms.Button()
        Me.TxtAusgabe = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtEinkommen
        '
        Me.TxtEinkommen.Location = New System.Drawing.Point(12, 118)
        Me.TxtEinkommen.Name = "TxtEinkommen"
        Me.TxtEinkommen.Size = New System.Drawing.Size(171, 20)
        Me.TxtEinkommen.TabIndex = 0
        '
        'LblAusgabe1
        '
        Me.LblAusgabe1.AutoSize = True
        Me.LblAusgabe1.Location = New System.Drawing.Point(12, 102)
        Me.LblAusgabe1.Name = "LblAusgabe1"
        Me.LblAusgabe1.Size = New System.Drawing.Size(62, 13)
        Me.LblAusgabe1.TabIndex = 1
        Me.LblAusgabe1.Text = "Einkommen"
        '
        'CmdEInkommenssteuer
        '
        Me.CmdEInkommenssteuer.Location = New System.Drawing.Point(12, 144)
        Me.CmdEInkommenssteuer.Name = "CmdEInkommenssteuer"
        Me.CmdEInkommenssteuer.Size = New System.Drawing.Size(136, 23)
        Me.CmdEInkommenssteuer.TabIndex = 2
        Me.CmdEInkommenssteuer.Text = "EinkommensSteuer"
        Me.CmdEInkommenssteuer.UseVisualStyleBackColor = True
        '
        'TxtAusgabe
        '
        Me.TxtAusgabe.Location = New System.Drawing.Point(169, 144)
        Me.TxtAusgabe.Name = "TxtAusgabe"
        Me.TxtAusgabe.Size = New System.Drawing.Size(278, 20)
        Me.TxtAusgabe.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 335)
        Me.Controls.Add(Me.TxtAusgabe)
        Me.Controls.Add(Me.CmdEInkommenssteuer)
        Me.Controls.Add(Me.LblAusgabe1)
        Me.Controls.Add(Me.TxtEinkommen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtEinkommen As TextBox
    Friend WithEvents LblAusgabe1 As Label
    Friend WithEvents CmdEInkommenssteuer As Button
    Friend WithEvents TxtAusgabe As TextBox
End Class
