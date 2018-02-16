<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblAusgabe = New System.Windows.Forms.Label()
        Me.CmdAusgabe = New System.Windows.Forms.Button()
        Me.CmdRechnen1 = New System.Windows.Forms.Button()
        Me.CmdRechnen2 = New System.Windows.Forms.Button()
        Me.TxtBox1 = New System.Windows.Forms.TextBox()
        Me.NumHochRunter = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumHochRunter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblAusgabe
        '
        Me.LblAusgabe.AutoSize = True
        Me.LblAusgabe.Location = New System.Drawing.Point(43, 179)
        Me.LblAusgabe.Name = "LblAusgabe"
        Me.LblAusgabe.Size = New System.Drawing.Size(49, 13)
        Me.LblAusgabe.TabIndex = 0
        Me.LblAusgabe.Text = "Ausgabe"
        '
        'CmdAusgabe
        '
        Me.CmdAusgabe.Location = New System.Drawing.Point(220, 12)
        Me.CmdAusgabe.Name = "CmdAusgabe"
        Me.CmdAusgabe.Size = New System.Drawing.Size(75, 23)
        Me.CmdAusgabe.TabIndex = 1
        Me.CmdAusgabe.Text = "Ausgabe"
        Me.CmdAusgabe.UseVisualStyleBackColor = True
        '
        'CmdRechnen1
        '
        Me.CmdRechnen1.Location = New System.Drawing.Point(220, 41)
        Me.CmdRechnen1.Name = "CmdRechnen1"
        Me.CmdRechnen1.Size = New System.Drawing.Size(75, 23)
        Me.CmdRechnen1.TabIndex = 2
        Me.CmdRechnen1.Text = "Rechnen 1"
        Me.CmdRechnen1.UseVisualStyleBackColor = True
        '
        'CmdRechnen2
        '
        Me.CmdRechnen2.Location = New System.Drawing.Point(300, 41)
        Me.CmdRechnen2.Name = "CmdRechnen2"
        Me.CmdRechnen2.Size = New System.Drawing.Size(75, 23)
        Me.CmdRechnen2.TabIndex = 3
        Me.CmdRechnen2.Text = "Rechnen 2"
        Me.CmdRechnen2.UseVisualStyleBackColor = True
        '
        'TxtBox1
        '
        Me.TxtBox1.Location = New System.Drawing.Point(12, 12)
        Me.TxtBox1.Name = "TxtBox1"
        Me.TxtBox1.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox1.TabIndex = 4
        '
        'NumHochRunter
        '
        Me.NumHochRunter.DecimalPlaces = 1
        Me.NumHochRunter.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumHochRunter.Location = New System.Drawing.Point(12, 41)
        Me.NumHochRunter.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumHochRunter.Minimum = New Decimal(New Integer() {5, 0, 0, -2147483648})
        Me.NumHochRunter.Name = "NumHochRunter"
        Me.NumHochRunter.Size = New System.Drawing.Size(120, 20)
        Me.NumHochRunter.TabIndex = 5
        Me.NumHochRunter.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 321)
        Me.Controls.Add(Me.NumHochRunter)
        Me.Controls.Add(Me.TxtBox1)
        Me.Controls.Add(Me.CmdRechnen2)
        Me.Controls.Add(Me.CmdRechnen1)
        Me.Controls.Add(Me.CmdAusgabe)
        Me.Controls.Add(Me.LblAusgabe)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumHochRunter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblAusgabe As Label
    Friend WithEvents CmdAusgabe As Button
    Friend WithEvents CmdRechnen1 As Button
    Friend WithEvents CmdRechnen2 As Button
    Friend WithEvents TxtBox1 As TextBox
    Friend WithEvents NumHochRunter As NumericUpDown
End Class
