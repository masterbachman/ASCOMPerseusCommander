Public Class Form1

    Private objPerseus As ASCOM.DriverAccess.Switch

    ''' <summary>
    ''' This event is where the driver is choosen. The device ID will be saved in the settings.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub buttonChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonChoose.Click
        My.Settings.DriverId = ASCOM.DriverAccess.Switch.Choose(My.Settings.DriverId)
        SetUIState()
    End Sub

    ''' <summary>
    ''' Connects to the device to be tested.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub buttonConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonConnect.Click
        If (IsConnected) Then
            objPerseus.Connected = False
        Else
            objPerseus = New ASCOM.DriverAccess.Switch(My.Settings.DriverId)
            objPerseus.Connected = True
            LoadSwitchNameToGUI()
        End If
        SetUIState()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If IsConnected Then
            objPerseus.Connected = False
        End If
        ' the settings are saved automatically when this application is closed.
    End Sub

    ''' <summary>
    ''' Sets the state of the UI depending on the device state
    ''' </summary>
    Private Sub SetUIState()
        buttonConnect.Enabled = Not String.IsNullOrEmpty(My.Settings.DriverId)
        buttonChoose.Enabled = Not IsConnected
        buttonConnect.Text = IIf(IsConnected, "Disconnect", "Connect")
    End Sub

    ''' <summary>
    ''' Gets a value indicating whether this instance is connected.
    ''' </summary>
    ''' <value>
    ''' 
    ''' <c>true</c> if this instance is connected; otherwise, <c>false</c>.
    ''' 
    ''' </value>
    Private ReadOnly Property IsConnected() As Boolean
        Get
            If Me.objPerseus Is Nothing Then Return False
            Return objPerseus.Connected
        End Get
    End Property

    ' TODO: Add additional UI and controls to test more of the driver being tested.

    Private Sub LoadSwitchNameToGUI()
        objPerseus.SetSwitchValue(0, 1)
        Threading.Thread.Sleep(5000)
        TextBoxActivePort.Text = objPerseus.GetSwitchValue(0)
        TextBoxPort1.Text = objPerseus.GetSwitchName(0)
        objPerseus.SetSwitchValue(0, 2)
        Threading.Thread.Sleep(5000)
        TextBoxPort2.Text = objPerseus.GetSwitchName(0)
        objPerseus.SetSwitchValue(0, 3)
        Threading.Thread.Sleep(5000)
        TextBoxPort3.Text = objPerseus.GetSwitchName(0)
        objPerseus.SetSwitchValue(0, 4)
        Threading.Thread.Sleep(5000)
        TextBoxPort4.Text = objPerseus.GetSwitchName(0)
        TextBoxActivePort.Text = objPerseus.GetSwitchValue(0)
    End Sub

    Private Sub UpdateActivePortInfo()
        TextBoxActivePort.Text = objPerseus.GetSwitchValue(0)
    End Sub
    Private Sub ButtonPort1_Click(sender As Object, e As EventArgs) Handles ButtonPort1.Click
        If (IsConnected) Then
            objPerseus.Connected = True
            objPerseus.SetSwitchValue(0, 1)
            Threading.Thread.Sleep(5000)
            UpdateActivePortInfo()
        Else
        End If
    End Sub

    Private Sub ButtonPort2_Click_1(sender As Object, e As EventArgs) Handles ButtonPort2.Click
        If (IsConnected) Then
            objPerseus.Connected = True
            objPerseus.SetSwitchValue(0, 2)
            Threading.Thread.Sleep(5000)
            UpdateActivePortInfo()
        Else
        End If
    End Sub

    Private Sub ButtonPort3_Click_1(sender As Object, e As EventArgs) Handles ButtonPort3.Click
        If (IsConnected) Then
            objPerseus.Connected = True
            objPerseus.SetSwitchValue(0, 3)
            Threading.Thread.Sleep(5000)
            UpdateActivePortInfo()
        Else
        End If
    End Sub

    Private Sub ButtonPort4_Click_1(sender As Object, e As EventArgs) Handles ButtonPort4.Click
        If (IsConnected) Then
            objPerseus.Connected = True
            objPerseus.SetSwitchValue(0, 4)
            Threading.Thread.Sleep(5000)
            UpdateActivePortInfo()
        Else
        End If
    End Sub
End Class
