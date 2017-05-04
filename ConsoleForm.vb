Imports System.IO



Public Class ConsoleForm

    Private _IniFileAccess As IniFileGateway

<<<<<<< HEAD
    Private _plc As IPlc
    Private _plcGenerator As PlcTypeGenerator

    Private Sub loadSET_Button_Click(sender As Object, e As EventArgs) Handles loadSET_Button.Click
=======
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles loadSET_Button.Click
>>>>>>> parent of aa9e4c4... 加入连接功能
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

            openButton.Enabled = True
            closeButton.Enabled = True

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

    Private Sub showCells(ByVal count As Integer)

        Dim address As String = ""
        Dim Name As String = ""

        For index = 1 To count
            address = _IniFileAccess.GetIniInteger("ADDRESS", "ADD" & index.ToString, 1280)
            Name = _IniFileAccess.GetIniString("ADDRESS", "Name" & index.ToString, 1280)
            Me.DataGridView1.Rows.Add(address, Name, "")
        Next

    End Sub

    Private Sub openButton_Click(sender As Object, e As EventArgs) Handles openButton.Click
        Me._plc = Me._plcGenerator.Generate()

        Me._plc.Open()

        Me.openButton.Enabled = False
        Me.closeButton.Enabled = True
        Me.saveButton.Enabled = True

        Dim count As Integer = _IniFileAccess.GetIniInteger("ADDRESS", "Count", 0)

        showCells(count)
        For index = 1 To count
            Dim values() As Short = DirectCast(Me._plc, ProServerGateway).Read((_IniFileAccess.GetIniInteger("ADDRESS", "ADD" & index, 0)), 1)
            Me.DataGridView1.Rows(index - 1).Cells(2).Value = values(0)
        Next

        saveButton.Enabled = True

    End Sub

    Private Sub ConsoleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        openButton.Enabled = False
        closeButton.Enabled = False
        saveButton.Enabled = False
        stopButton.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim str2 As String = Now() & ", "

        'For Index As Integer = 0 To CInt(Me.countTextBox.Text) - 1
        For Index As Integer = 0 To DataGridView1.RowCount - 1
            str2 = str2 & DataGridView1.Rows(Index).Cells(1).Value & ", "
        Next

        PrintLine(1, str2)
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim t As Integer = InputBox("输入多少秒记录一次", "计时"， 120)

        Dim text As String = Me.Label12.Text.ToString & Format(Now, "yyyyMMdd")

        FileOpen(1, text & ".txt", OpenMode.Output)

        Dim str As String = "Date, "

        For Index As Integer = 0 To DataGridView1.RowCount - 1
            str = str & DataGridView1.Rows(Index).Cells(0).Value & ", "
        Next


        PrintLine(1, str)


        Dim str2 As String = Now() & ", "

        For Index As Integer = 0 To DataGridView1.RowCount - 1
            str2 = str2 & DataGridView1.Rows(Index).Cells(1).Value & ", "
        Next

        PrintLine(1, str2)

        Timer1.Enabled = True
        Timer1.Interval = t * 1000

        saveButton.Enabled = False
        saveButton.Text = "保存中"
        stopButton.Enabled = True

    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        Timer1.Enabled = False

        FileClose(1)

        MsgBox("已停止")
        '点击停止时停止写入

        saveButton.Text = "保存"
        saveButton.Enabled = True
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        openButton.Enabled = True
    End Sub
End Class
