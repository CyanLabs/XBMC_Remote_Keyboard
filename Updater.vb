Public Module Updater
    Dim product As String = My.Application.Info.AssemblyName.Replace(" ", "_")
    Dim wc As New Net.WebClient
    Dim localversion As String = My.Application.Info.Version.ToString
   Public Sub IsLatest()
        If Environment.GetCommandLineArgs.Length > 1 Then
            For Each x As String In Environment.GetCommandLineArgs
                If x.Contains("-v=") Then localversion = x.Replace("-v=", "")
            Next
        End If
        Try
            Dim latestversion As String = wc.DownloadString("http://cyanlabs.co.uk/raw/version.php?product=" & product).Replace(" ", "")
            If localversion < latestversion Then
                Dim changelog As String = wc.DownloadString("http://cyanlabs.co.uk/raw/changelog.php?product=" & product & "&from=" & localversion & "&to=" & latestversion)
                changelog = changelog.Replace("<br/><br/>", vbNewLine & vbNewLine).Replace("<br/>", vbNewLine)
                If MsgBox("A new update is available for download" & vbNewLine & vbNewLine & "Would you like to download v" & latestversion & "?" & vbNewLine & vbNewLine & changelog, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Update Avaliable") = vbYes Then
                    If IO.File.Exists(Application.StartupPath & "\AutoUpdater.exe") Then
                        Dim updaterversion As FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(Application.StartupPath & "\AutoUpdater.exe")
                        If updaterversion.FileVersion < wc.DownloadString("http://cyanlabs.co.uk/raw/version.php?product=AutoUpdater").Replace(" ", "") Then
                            DownloadUpdater(latestversion)
                        Else
                            Process.Start(Application.StartupPath & "\AutoUpdater.exe ", "-product=" & product & " -v=" & latestversion)
                            Application.Exit()
                        End If
                    Else
                        DownloadUpdater(latestversion)
                    End If
                End If
            End If
        Catch ex As Net.WebException
            Form1.ntfyIcon.ShowBalloonTip(5000, "XBMC Remote Keyboard", ex.Message.ToString & vbNewLine & vbNewLine & "Please manually check for a update at cyanlabs.co.uk", ToolTipIcon.Error)
        Catch ex As NullReferenceException
            Form1.ntfyIcon.ShowBalloonTip(5000, "XBMC Remote Keyboard", "This application currently doesn't support autoupdating", ToolTipIcon.Error)
        Catch ex As System.Xml.XPath.XPathException
            Form1.ntfyIcon.ShowBalloonTip(5000, "XBMC Remote Keyboard", ex.Message.ToString, ToolTipIcon.Error)
        End Try
    End Sub
    Private Sub DownloadUpdater(ByVal latestversion As String)
        Try
            MsgBox("The autoupdater application is out of date, Downloading new version!", , "Updater Out Of Date")
            If IO.File.Exists(Application.StartupPath & "\AutoUpdater.exe") Then IO.File.Delete(Application.StartupPath & "\AutoUpdater.exe")
            wc.DownloadFile(New Uri("http://downloads.cyanlabs.co.uk/AutoUpdater/AutoUpdater.exe"), Application.StartupPath & "\AutoUpdater.exe")
            Process.Start(Application.StartupPath & "\AutoUpdater.exe ", "-product=" & product & " -v=" & latestversion)
            Application.Exit()
        Catch ex As Net.WebException
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Module
