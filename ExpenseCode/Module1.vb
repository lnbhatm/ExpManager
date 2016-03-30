

Module Module1
    Public acountmanager As String = My.Application.Info.DirectoryPath & "\AccountManager.xls"

    Public Sub DisableSound()
        Dim keyValue As String
        keyValue = "&#37;SystemRoot%\Media\"
        If Environment.OSVersion.Version.Major = 5 AndAlso Environment.OSVersion.Version.Minor > 0 Then
            keyValue += "Windows XP Start.wav"
        ElseIf Environment.OSVersion.Version.Major = 6 Then
            keyValue += "Windows Navigation Start.wav"
        Else
            Return
        End If
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("AppEvents\Schemes\Apps\Explorer\Navigating\.Current", True)
        key.SetValue(Nothing, "", Microsoft.Win32.RegistryValueKind.ExpandString)
    End Sub

End Module
