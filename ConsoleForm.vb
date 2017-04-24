Imports System.IO



Public Class ConsoleForm

    Private _IniFileAccess As IniFileGateway

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles loadSET_Button.Click
        Dim FileName As String
        Dim filestream1 As System.IO.FileStream
        Dim chrstream1 As System.IO.StreamReader

        OpenFileDialog1.InitialDirectory = System.Environment.CurrentDirectory
        OpenFileDialog1.Filter = "文本文件(*.txt)|*.txt|配置文件(*.pl)|*.pl|所有文件|*.*"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.Title = "打开文件窗口"
        OpenFileDialog1.AddExtension() = False
        OpenFileDialog1.CheckPathExists() = True
        OpenFileDialog1.ValidateNames() = True
        OpenFileDialog1.ShowHelp() = True

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            FileName = OpenFileDialog1.FileName
            If FileName <> "" Then
                filestream1 = File.Open(FileName, IO.FileMode.Open, FileAccess.Read)
                chrstream1 = New System.IO.StreamReader(filestream1)
                openSetting(FileName)
                'TextBox1.AppendText(chrstream1.ReadToEnd)
            End If
        End If



    End Sub

    Private Sub openSetting(ByVal FileName As String)

        Dim IniFilePath As String = FileName

        _IniFileAccess = New IniFileGateway(IniFilePath)

        Me.ipAddressTextBox.Text = _IniFileAccess.GetIniString("SETTINGS", "IPADDRESS", "192.168.0.10")
        Me.PortNo1TextBox.Text = _IniFileAccess.GetIniInteger("SETTINGS", "PORTNO1", 1280)
        Me.PortNo2TextBox.Text = _IniFileAccess.GetIniInteger("SETTINGS", "PORTNO2", 1281)
        Me.PortNo3TextBox.Text = _IniFileAccess.GetIniInteger("SETTINGS", "PORTNO3", 1282)
        Me.PortNo4TextBox.Text = _IniFileAccess.GetIniInteger("SETTINGS", "PORTNO4", 1283)
        Me.PortNo5TextBox.Text = _IniFileAccess.GetIniInteger("SETTINGS", "PORTNO5", 1284)
        Me.PortNo6TextBox.Text = _IniFileAccess.GetIniInteger("SETTINGS", "PORTNO6", 1285)
        Me.PortNo7TextBox.Text = _IniFileAccess.GetIniInteger("SETTINGS", "PORTNO7", 1286)
        Me.PortNo8TextBox.Text = _IniFileAccess.GetIniInteger("SETTINGS", "PORTNO8", 1287)
        Me.portCountTextBox.Text = _IniFileAccess.GetIniInteger("SETTINGS", "PORTCOUNT", 8)
        Me.portBaseTextBox.Text = _IniFileAccess.GetIniInteger("SETTINGS", "USE_PORT_BASE", 1279)
        Me.usePortAdderssTextBox.Text = _IniFileAccess.GetIniInteger("SETTINGS", "USE_PORT_ADDRESS", 8097)

    End Sub


End Class
