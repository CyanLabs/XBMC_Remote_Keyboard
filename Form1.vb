Imports System.Net
Imports System.IO
Imports WindowsHookLib
Imports System.Text
Imports System.Threading

Public Class Form1
    Dim WithEvents kHook As New KeyboardHook
    Dim uri
    Dim hookenabled As Boolean = True
    Dim closable As Boolean = False
    Private UpdateChecker As System.Threading.Thread = New Thread(AddressOf Updater.IsLatest)

    Private Function SendRequest(uri As Uri, jsonDataBytes As Byte(), contentType As String, method As String) As String
        Dim req As WebRequest = WebRequest.Create(uri)
        req.ContentType = contentType
        req.Method = method
        req.ContentLength = jsonDataBytes.Length

        Dim stream = req.GetRequestStream()
        stream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
        stream.Close()

        Dim response = req.GetResponse().GetResponseStream()

        Dim reader As New StreamReader(response)
        Dim res = reader.ReadToEnd()
        reader.Close()
        response.Close()

        Return res
    End Function

    Private Sub kHook_KeyDown(ByVal sender As Object, ByVal e As WindowsHookLib.KeyboardEventArgs) Handles kHook.KeyDown
        If e.Modifiers = Keys.Alt AndAlso hookenabled Then
            e.Handled = True
            If e.KeyCode = Keys.Left Then
                If IsStopped() Then
                    SendJSON("input.left")
                Else
                    SendJSON("Player.Seek", """playerid"":1,""value"":""smallbackward""")
                End If
            ElseIf e.KeyCode = Keys.Up Then
                If IsStopped() Then
                    SendJSON("input.up")
                Else
                    SendJSON("Player.Seek", """playerid"":1,""value"":""bigforward""")
                End If
            ElseIf e.KeyCode = Keys.Right Then
                If IsStopped() Then
                    SendJSON("input.right")
                Else
                    SendJSON("Player.Seek", """playerid"":1,""value"":""smallforward""")
                End If
            ElseIf e.KeyCode = Keys.Down Then
                If IsStopped() Then
                    SendJSON("input.down")
                Else
                    SendJSON("Player.Seek", """playerid"":1,""value"":""bigbackward""")
                End If
            ElseIf e.KeyCode = Keys.P Or e.KeyCode = Keys.Space Then
                If Not IsStopped() Then SendJSON("Player.PlayPause", """playerid"":1")
            ElseIf e.KeyCode = Keys.Enter Then
                SendJSON("Input.select")
            ElseIf e.KeyCode = Keys.Escape Then
                SendJSON("Input.Home")
            ElseIf e.KeyCode = Keys.Back Then
                SendJSON("Input.Back")
            ElseIf e.KeyCode = Keys.C Then
                SendJSON("Input.ContextMenu")
            ElseIf e.KeyCode = Keys.I Then
                SendJSON("Input.Info")
            Else
                e.Handled = False
            End If
        End If
    End Sub
    Dim updated As Boolean = False, newversion As String
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ntfyIcon.ShowBalloonTip(3000, "XBMC Remote Keyboard", "Press ALT + [KEY] to control XBMC", ToolTipIcon.Info)
        If My.Settings.IP = "127.0.0.1" Then
            hookenabled = False
            Me.Opacity = 100
        Else
            Me.Hide()
            Me.Opacity = 0
            Me.ShowInTaskbar = False
        End If
        NsTextBox1.Text = My.Settings.IP
        NsTextBox2.Text = My.Settings.Port
        If My.Settings.IP.Contains("http://") Or My.Settings.IP.Contains("https://") Then uri = My.Settings.IP & ":" & My.Settings.Port & "/jsonrpc" Else 
        uri = "http://" & My.Settings.IP & ":" & My.Settings.Port & "/jsonrpc"
        If Environment.GetCommandLineArgs.Length > 1 Then
            For Each x As String In Environment.GetCommandLineArgs
                If x.Contains("-updated=") Then
                    updated = True
                    newversion = x.Replace("-updated=", "")
                End If
            Next
        End If
        If updated Then
            ntfyIcon.ShowBalloonTip(3000, "XBMC Remote Keyboard", "You have successfully updated to V" & newversion, ToolTipIcon.Info)
        Else
            ntfyIcon.ShowBalloonTip(3000, "XBMC Remote Keyboard", "Checking for updates!", ToolTipIcon.Info)
            UpdateChecker.IsBackground = True
            UpdateChecker.Start()
        End If
        kHook.InstallHook()
    End Sub

    Private Function SendJSON(ByVal JSONRequest As String, Optional ByVal Parameters As String = "")
        Dim JSONString = ""

        If Parameters = "" Then
            JSONString = "{""id"":1,""jsonrpc"":""2.0"",""method"":""" & JSONRequest & """}"
        Else
            JSONString = "{""id"":1,""jsonrpc"":""2.0"",""method"":""" & JSONRequest & """,""params"":{" & Parameters & "}}"
        End If

        Return SendRequest(New Uri(uri), Encoding.UTF8.GetBytes(JSONString.Replace("ACTION", JSONRequest)), "application/json", "POST")
    End Function

    Private Function IsStopped()
        If SendJSON("Player.GetActivePlayers") = "{""id"":1,""jsonrpc"":""2.0"",""result"":[]}" Then Return True
        Return False
    End Function

    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        If Not System.Net.IPAddress.TryParse(NsTextBox1.Text, Nothing) Then
            MsgBox("Invalid IP Address Entered!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        My.Settings.IP = NsTextBox1.Text
        My.Settings.Port = NsTextBox2.Text
        My.Settings.Save()
        If My.Settings.IP.Contains("http://") Or My.Settings.IP.Contains("https://") Then uri = My.Settings.IP & ":" & My.Settings.Port & "/jsonrpc" Else 
        uri = "http://" & My.Settings.IP & ":" & My.Settings.Port & "/jsonrpc"
        hookenabled = True
    End Sub

    Private Sub DisableKeyhookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableKeyhookToolStripMenuItem.Click
        If DisableKeyhookToolStripMenuItem.Text = "Disable Keyhook" Then
            DisableKeyhookToolStripMenuItem.Text = "Enable Keyhook"
            hookenabled = False
        Else
            DisableKeyhookToolStripMenuItem.Text = "Disable Keyhook"
            hookenabled = True
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click, ntfyIcon.DoubleClick
        Me.Opacity = 100
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    Private Sub NsControlButton1_Click(sender As Object, e As EventArgs) Handles NsControlButton1.Click
        Me.Opacity = 0
        Me.Hide()
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Process.Start("http://cyanlabs.co.uk")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        closable = True
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closable = True Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
End Class