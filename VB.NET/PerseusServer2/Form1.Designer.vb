<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.labelDriverId = New System.Windows.Forms.Label()
        Me.buttonConnect = New System.Windows.Forms.Button()
        Me.buttonChoose = New System.Windows.Forms.Button()
        Me.ButtonPort1 = New System.Windows.Forms.Button()
        Me.ButtonPort2 = New System.Windows.Forms.Button()
        Me.ButtonPort3 = New System.Windows.Forms.Button()
        Me.ButtonPort4 = New System.Windows.Forms.Button()
        Me.TextBoxPort1 = New System.Windows.Forms.TextBox()
        Me.TextBoxPort2 = New System.Windows.Forms.TextBox()
        Me.TextBoxPort3 = New System.Windows.Forms.TextBox()
        Me.TextBoxPort4 = New System.Windows.Forms.TextBox()
        Me.TextBoxActivePort = New System.Windows.Forms.TextBox()
        Me.LabelActivePort = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelDriverId
        '
        Me.labelDriverId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelDriverId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.ASCOM.PerseusServer.My.MySettings.Default, "DriverId", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.labelDriverId.Location = New System.Drawing.Point(12, 9)
        Me.labelDriverId.Name = "labelDriverId"
        Me.labelDriverId.Size = New System.Drawing.Size(317, 21)
        Me.labelDriverId.TabIndex = 5
        Me.labelDriverId.Text = Global.ASCOM.PerseusServer.My.MySettings.Default.DriverId
        Me.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'buttonConnect
        '
        Me.buttonConnect.Location = New System.Drawing.Point(257, 33)
        Me.buttonConnect.Name = "buttonConnect"
        Me.buttonConnect.Size = New System.Drawing.Size(72, 23)
        Me.buttonConnect.TabIndex = 4
        Me.buttonConnect.Text = "Connect"
        Me.buttonConnect.UseVisualStyleBackColor = True
        '
        'buttonChoose
        '
        Me.buttonChoose.Location = New System.Drawing.Point(179, 33)
        Me.buttonChoose.Name = "buttonChoose"
        Me.buttonChoose.Size = New System.Drawing.Size(72, 23)
        Me.buttonChoose.TabIndex = 3
        Me.buttonChoose.Text = "Choose"
        Me.buttonChoose.UseVisualStyleBackColor = True
        '
        'ButtonPort1
        '
        Me.ButtonPort1.Location = New System.Drawing.Point(11, 146)
        Me.ButtonPort1.Name = "ButtonPort1"
        Me.ButtonPort1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPort1.TabIndex = 6
        Me.ButtonPort1.Text = "PORT 1"
        Me.ButtonPort1.UseVisualStyleBackColor = True
        '
        'ButtonPort2
        '
        Me.ButtonPort2.Location = New System.Drawing.Point(92, 146)
        Me.ButtonPort2.Name = "ButtonPort2"
        Me.ButtonPort2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPort2.TabIndex = 7
        Me.ButtonPort2.Text = "PORT 2"
        Me.ButtonPort2.UseVisualStyleBackColor = True
        '
        'ButtonPort3
        '
        Me.ButtonPort3.Location = New System.Drawing.Point(173, 146)
        Me.ButtonPort3.Name = "ButtonPort3"
        Me.ButtonPort3.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPort3.TabIndex = 8
        Me.ButtonPort3.Text = "PORT 3"
        Me.ButtonPort3.UseVisualStyleBackColor = True
        '
        'ButtonPort4
        '
        Me.ButtonPort4.Location = New System.Drawing.Point(254, 146)
        Me.ButtonPort4.Name = "ButtonPort4"
        Me.ButtonPort4.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPort4.TabIndex = 9
        Me.ButtonPort4.Text = "PORT 4"
        Me.ButtonPort4.UseVisualStyleBackColor = True
        '
        'TextBoxPort1
        '
        Me.TextBoxPort1.Location = New System.Drawing.Point(12, 113)
        Me.TextBoxPort1.Name = "TextBoxPort1"
        Me.TextBoxPort1.Size = New System.Drawing.Size(74, 20)
        Me.TextBoxPort1.TabIndex = 10
        '
        'TextBoxPort2
        '
        Me.TextBoxPort2.Location = New System.Drawing.Point(93, 112)
        Me.TextBoxPort2.Name = "TextBoxPort2"
        Me.TextBoxPort2.Size = New System.Drawing.Size(74, 20)
        Me.TextBoxPort2.TabIndex = 11
        '
        'TextBoxPort3
        '
        Me.TextBoxPort3.Location = New System.Drawing.Point(174, 112)
        Me.TextBoxPort3.Name = "TextBoxPort3"
        Me.TextBoxPort3.Size = New System.Drawing.Size(74, 20)
        Me.TextBoxPort3.TabIndex = 12
        '
        'TextBoxPort4
        '
        Me.TextBoxPort4.Location = New System.Drawing.Point(255, 112)
        Me.TextBoxPort4.Name = "TextBoxPort4"
        Me.TextBoxPort4.Size = New System.Drawing.Size(74, 20)
        Me.TextBoxPort4.TabIndex = 13
        '
        'TextBoxActivePort
        '
        Me.TextBoxActivePort.Location = New System.Drawing.Point(13, 60)
        Me.TextBoxActivePort.Name = "TextBoxActivePort"
        Me.TextBoxActivePort.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxActivePort.TabIndex = 14
        '
        'LabelActivePort
        '
        Me.LabelActivePort.AutoSize = True
        Me.LabelActivePort.Location = New System.Drawing.Point(13, 42)
        Me.LabelActivePort.Name = "LabelActivePort"
        Me.LabelActivePort.Size = New System.Drawing.Size(62, 13)
        Me.LabelActivePort.TabIndex = 15
        Me.LabelActivePort.Text = "Active Port:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 191)
        Me.Controls.Add(Me.LabelActivePort)
        Me.Controls.Add(Me.TextBoxActivePort)
        Me.Controls.Add(Me.TextBoxPort4)
        Me.Controls.Add(Me.TextBoxPort3)
        Me.Controls.Add(Me.TextBoxPort2)
        Me.Controls.Add(Me.TextBoxPort1)
        Me.Controls.Add(Me.ButtonPort4)
        Me.Controls.Add(Me.ButtonPort3)
        Me.Controls.Add(Me.ButtonPort2)
        Me.Controls.Add(Me.ButtonPort1)
        Me.Controls.Add(Me.labelDriverId)
        Me.Controls.Add(Me.buttonConnect)
        Me.Controls.Add(Me.buttonChoose)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents labelDriverId As System.Windows.Forms.Label
    Private WithEvents buttonConnect As System.Windows.Forms.Button
    Private WithEvents buttonChoose As System.Windows.Forms.Button
    Friend WithEvents ButtonPort1 As Button
    Friend WithEvents ButtonPort2 As Button
    Friend WithEvents ButtonPort3 As Button
    Friend WithEvents ButtonPort4 As Button
    Friend WithEvents TextBoxPort1 As TextBox
    Friend WithEvents TextBoxPort2 As TextBox
    Friend WithEvents TextBoxPort3 As TextBox
    Friend WithEvents TextBoxPort4 As TextBox
    Friend WithEvents TextBoxActivePort As TextBox
    Friend WithEvents LabelActivePort As Label
End Class
